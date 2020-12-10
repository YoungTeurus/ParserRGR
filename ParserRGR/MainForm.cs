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
    public partial class Form1 : Form
    {
        private string baseURL = "https://ru.wikipedia.org/";
        private Parser.ParserWorker parserWorker;

        public Form1()
        {
            InitializeComponent();

            parserWorker = new Parser.ParserWorker(baseURL);
            parserWorker.OnNewData += (rivers, done, total) => {
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
            };
            parserWorker.OnCompleted += (obj) => MessageBox.Show("Парсинг завершён!");
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

            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            buttonCopyToDB.Enabled = false;

            listViewRivers.Items.Clear();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            parserWorker.Start(textBoxFirstPage.Text,
                numericUpDownNumOfPages.Value != 0? (int)numericUpDownNumOfPages.Value: int.MaxValue
                );
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            buttonCopyToDB.Enabled = false;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            parserWorker.Stop();
            buttonStop.Enabled = false;
            buttonStart.Enabled = true;
            buttonCopyToDB.Enabled = true;
        }

        private void buttonCopyToDB_Click(object sender, EventArgs e)
        {
            foreach(object listViewItem in listViewRivers.Items)
            {
                addRiverToDB((listViewItem as ListViewItem).Tag as River);
            }
            riversTableAdapter.Fill(riversDataSet.Rivers);
        }

        private void addRiverToDB(River river)
        {
            bool riverAlreadyExists = false;
            foreach (DataGridViewRow row in riversDataGridView.Rows)
            {
                var a = (string)row.Cells[1].Value == river.name;
                var b = (string)row.Cells[2].Value == river.length.ToString();
                var c = (string)row.Cells[3].Value == river.source;
                var d = (string)row.Cells[4].Value == river.mouth;
                if (
                    a &&
                    b &&
                    c &&
                    d
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
        }

        private void riversBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.riversBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.riversDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "riversDataSet.Rivers". При необходимости она может быть перемещена или удалена.
            this.riversTableAdapter.Fill(this.riversDataSet.Rivers);
        }
    }
}
