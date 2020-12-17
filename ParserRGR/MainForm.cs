using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RGRRiverParser.Model;

namespace RGRRiverParser
{
    public partial class MainForm : Form
    {
        private string baseURL = "https://ru.wikipedia.org/";
        private Parser.ParserWorker parserWorker;

        public MainForm()
        {
            InitializeComponent();

            // Настройка parserWorker
            parserWorker = new Parser.ParserWorker(baseURL);
            parserWorker.OnNewData += onNewDataEventHandler;
            parserWorker.OnCompleted += onCompletedEventHandler;
        }

        /// <summary>
        /// Обработчик события "получения новой информации".
        /// Обновляет содержимое listView, а также Value прогресс-бара.
        /// </summary>
        /// <param name="rivers">Массив с полученными реками</param>
        /// <param name="done">Количество разобранных страниц</param>
        /// <param name="total">Общее количество страниц</param>
        private void onNewDataEventHandler(List<River> rivers, int done, int total)
        {
            foreach (River river in rivers)
            {
                var listViewItem = listViewRivers.Items.Add(river.name);
                listViewItem.Tag = river;
                listViewItem.SubItems.Add(river.length.ToString());
                listViewItem.SubItems.Add(river.source);
                listViewItem.SubItems.Add(river.mouth);
            }
            toolStripProgressBarPageProgress.Maximum = total;
            toolStripProgressBarPageProgress.Value = done;
        }

        /// <summary>
        /// Обработчик события "завершения разбора информации".
        /// </summary>
        private void onCompletedEventHandler(object _)
        {
            MessageBox.Show("Парсинг завершён!");
            // Разблокируем необходимые элементы управления:
            unblockUserInterface();
        }

        private void checkBoxChangeFirstPage_CheckedChanged(object sender, EventArgs e)
        {
            textBoxFirstPage.Enabled = checkBoxChangeFirstPage.Checked;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            checkBoxChangeFirstPage.Checked = false;
            textBoxFirstPage.Enabled = checkBoxChangeFirstPage.Checked;
            textBoxFirstPage.Text = "w/index.php?title=%D0%9A%D0%B0%D1%82%D0%B5%D0%B3%D0%BE%D1%80%D0%B8%D1%8F:%D0%A0%D0%B5%D0%BA%D0%B8_%D0%BF%D0%BE_%D0%B0%D0%BB%D1%84%D0%B0%D0%B2%D0%B8%D1%82%D1%83";
            numericUpDownNumOfPages.Value = 0;

            // Разблокируем необходимые элементы управления:
            unblockUserInterface();
            buttonCopyToDB.Enabled = false;

            // Очищаем список рек:
            listViewRivers.Items.Clear();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            parserWorker.Start(textBoxFirstPage.Text,
                numericUpDownNumOfPages.Value != 0? (int)numericUpDownNumOfPages.Value: int.MaxValue
                );
            // Блокируем необходимые элементы управления:
            blockUserInteface();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            parserWorker.Stop();
        }

        private void unblockUserInterface()
        {
            // Разблокируем необходимые элементы управления:
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            buttonCopyToDB.Enabled = true;
            textBoxFirstPage.Enabled = true;
            numericUpDownNumOfPages.Enabled = true;

            checkBoxChangeFirstPage.Enabled = true;
        }
        private void blockUserInteface()
        {
            // Блокируем необходимые элементы управления:
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            buttonCopyToDB.Enabled = false;
            textBoxFirstPage.Enabled = false;
            numericUpDownNumOfPages.Enabled = false;

            checkBoxChangeFirstPage.Enabled = false;
        }

        private void buttonCopyToDB_Click(object sender, EventArgs e)
        {
            bool wasAnyRiverDuplicated = false;
            foreach(object listViewItem in listViewRivers.Items)
            {
                // Флаг станет true, если хотя бы одна река не будет добавлена.
                wasAnyRiverDuplicated = wasAnyRiverDuplicated || (!addRiverToDB((listViewItem as ListViewItem).Tag as River));
            }
            if (wasAnyRiverDuplicated)
            {
                MessageBox.Show("Одна или несколько рек в исходном наборе обработанных данных не была добавлена в базу данных, так как она была добавлена ранее.");
            }
            riversTableAdapter.Fill(riversDataSet.Rivers);
        }

        /// <summary>
        /// Добавляет реку в базу данных.
        /// </summary>
        /// <param name="river">Объект, представляющий реку.</param>
        /// <returns>Была ли река добавлена?</returns>
        private bool addRiverToDB(River river)
        {
            bool riverAlreadyExists = false;
            foreach (DataGridViewRow row in riversDataGridView.Rows)
            {
                if (
                    (string)row.Cells[1].Value == river.name &&
                    ((double)row.Cells[2].Value).ToString() == river.length.ToString() &&
                    (string)row.Cells[3].Value == river.source &&
                    (string)row.Cells[4].Value == river.mouth
                    )
                {
                    riverAlreadyExists = true;
                    break;
                }
            }
            if (!riverAlreadyExists)
                riversTableAdapter.Insert(
                    river.name,
                    river.length,
                    river.source,
                    river.mouth
                    );
            return !riverAlreadyExists;
        }

        private void riversBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this.riversBindingSource.EndEdit();
            }
            catch (System.Data.NoNullAllowedException)
            {
                MessageBox.Show("Попытка сохранить пустую строку! Проверьте значения строк!");
                return;
            }
            foreach (DataGridViewRow newRow in riversDataGridView.Rows)
            {
                if ((int)newRow.Cells[0].Value > 0)
                    continue;
                bool riverAlreadyExists = false;
                foreach (DataGridViewRow row in riversDataGridView.Rows)
                {
                    if (
                    ((int)row.Cells[0].Value > 0) &&
                    (string)row.Cells[1].Value == (string)newRow.Cells[1].Value &&
                    ((double)row.Cells[2].Value).ToString() == ((double)newRow.Cells[2].Value).ToString() &&
                    (string)row.Cells[3].Value == (newRow.Cells[3].Value != System.DBNull.Value ? (string)newRow.Cells[3].Value : "") &&
                    (string)row.Cells[4].Value == (newRow.Cells[4].Value != System.DBNull.Value ? (string)newRow.Cells[4].Value : "")
                    // (string)row.Cells[4].Value == (string)newRow.Cells[4].Value
                    )
                    {
                        riverAlreadyExists = true;
                        break;
                    }
                }
                if (riverAlreadyExists)
                {
                    riversDataGridView.Rows.Remove(newRow);
                }
            }
            this.tableAdapterManager.UpdateAll(this.riversDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "riversDataSet.Rivers". При необходимости она может быть перемещена или удалена.
            this.riversTableAdapter.Fill(this.riversDataSet.Rivers);
        }

        private void riversDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ошибка при сохранении значений в базу данных! Проверьте значения в строках!");
            return;
        }
    }
}
