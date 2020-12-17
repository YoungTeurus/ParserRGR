namespace RGRRiverParser
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarPageProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.listViewRivers = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMouth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCopyToDB = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.checkBoxChangeFirstPage = new System.Windows.Forms.CheckBox();
            this.labelNumOfPagesComment = new System.Windows.Forms.Label();
            this.labelNumOfPages = new System.Windows.Forms.Label();
            this.numericUpDownNumOfPages = new System.Windows.Forms.NumericUpDown();
            this.labelStartPage = new System.Windows.Forms.Label();
            this.textBoxFirstPage = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.riversDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.riversDataSet = new RGRRiverParser.Model.RiversDataSet();
            this.riversBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.riversBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.riversTableAdapter = new RGRRiverParser.Model.RiversDataSetTableAdapters.RiversTableAdapter();
            this.tableAdapterManager = new RGRRiverParser.Model.RiversDataSetTableAdapters.TableAdapterManager();
            this.tabControl.SuspendLayout();
            this.tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfPages)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.riversDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riversDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riversBindingNavigator)).BeginInit();
            this.riversBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.splitContainer);
            this.tabPage.Location = new System.Drawing.Point(4, 25);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(792, 421);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "Парсинг";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(3, 3);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.statusStrip);
            this.splitContainer.Panel1.Controls.Add(this.listViewRivers);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.buttonReset);
            this.splitContainer.Panel2.Controls.Add(this.buttonCopyToDB);
            this.splitContainer.Panel2.Controls.Add(this.buttonStop);
            this.splitContainer.Panel2.Controls.Add(this.buttonStart);
            this.splitContainer.Panel2.Controls.Add(this.checkBoxChangeFirstPage);
            this.splitContainer.Panel2.Controls.Add(this.labelNumOfPagesComment);
            this.splitContainer.Panel2.Controls.Add(this.labelNumOfPages);
            this.splitContainer.Panel2.Controls.Add(this.numericUpDownNumOfPages);
            this.splitContainer.Panel2.Controls.Add(this.labelStartPage);
            this.splitContainer.Panel2.Controls.Add(this.textBoxFirstPage);
            this.splitContainer.Size = new System.Drawing.Size(786, 415);
            this.splitContainer.SplitterDistance = 585;
            this.splitContainer.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBarPageProgress});
            this.statusStrip.Location = new System.Drawing.Point(0, 389);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(585, 26);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(290, 20);
            this.toolStripStatusLabel.Text = "Прогресс обработки текущей страницы:";
            // 
            // toolStripProgressBarPageProgress
            // 
            this.toolStripProgressBarPageProgress.Name = "toolStripProgressBarPageProgress";
            this.toolStripProgressBarPageProgress.Size = new System.Drawing.Size(100, 18);
            // 
            // listViewRivers
            // 
            this.listViewRivers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderLength,
            this.columnHeaderSource,
            this.columnHeaderMouth});
            this.listViewRivers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewRivers.HideSelection = false;
            this.listViewRivers.Location = new System.Drawing.Point(0, 0);
            this.listViewRivers.Name = "listViewRivers";
            this.listViewRivers.Size = new System.Drawing.Size(585, 415);
            this.listViewRivers.TabIndex = 0;
            this.listViewRivers.UseCompatibleStateImageBehavior = false;
            this.listViewRivers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Название";
            this.columnHeaderName.Width = 120;
            // 
            // columnHeaderLength
            // 
            this.columnHeaderLength.Text = "Протяжённость, км";
            this.columnHeaderLength.Width = 150;
            // 
            // columnHeaderSource
            // 
            this.columnHeaderSource.Text = "Исток";
            this.columnHeaderSource.Width = 150;
            // 
            // columnHeaderMouth
            // 
            this.columnHeaderMouth.Text = "Устье";
            this.columnHeaderMouth.Width = 150;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(1, 253);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(196, 51);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Восстановить настройки по умолчанию";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonCopyToDB
            // 
            this.buttonCopyToDB.Enabled = false;
            this.buttonCopyToDB.Location = new System.Drawing.Point(2, 217);
            this.buttonCopyToDB.Name = "buttonCopyToDB";
            this.buttonCopyToDB.Size = new System.Drawing.Size(196, 30);
            this.buttonCopyToDB.TabIndex = 5;
            this.buttonCopyToDB.Text = "Перенести в БД";
            this.buttonCopyToDB.UseVisualStyleBackColor = true;
            this.buttonCopyToDB.Click += new System.EventHandler(this.buttonCopyToDB_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(1, 181);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(196, 30);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Остановить разбор";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(1, 145);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(196, 30);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Начать разбор";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // checkBoxChangeFirstPage
            // 
            this.checkBoxChangeFirstPage.AutoSize = true;
            this.checkBoxChangeFirstPage.Location = new System.Drawing.Point(1, 14);
            this.checkBoxChangeFirstPage.Name = "checkBoxChangeFirstPage";
            this.checkBoxChangeFirstPage.Size = new System.Drawing.Size(191, 21);
            this.checkBoxChangeFirstPage.TabIndex = 4;
            this.checkBoxChangeFirstPage.Text = "Изменить нач. страницу";
            this.checkBoxChangeFirstPage.UseVisualStyleBackColor = true;
            this.checkBoxChangeFirstPage.CheckedChanged += new System.EventHandler(this.checkBoxChangeFirstPage_CheckedChanged);
            // 
            // labelNumOfPagesComment
            // 
            this.labelNumOfPagesComment.AutoSize = true;
            this.labelNumOfPagesComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumOfPagesComment.Location = new System.Drawing.Point(4, 108);
            this.labelNumOfPagesComment.Name = "labelNumOfPagesComment";
            this.labelNumOfPagesComment.Size = new System.Drawing.Size(93, 12);
            this.labelNumOfPagesComment.TabIndex = 3;
            this.labelNumOfPagesComment.Text = "(0 для неогр. кол-ва)";
            // 
            // labelNumOfPages
            // 
            this.labelNumOfPages.AutoSize = true;
            this.labelNumOfPages.Location = new System.Drawing.Point(3, 88);
            this.labelNumOfPages.Name = "labelNumOfPages";
            this.labelNumOfPages.Size = new System.Drawing.Size(148, 17);
            this.labelNumOfPages.TabIndex = 3;
            this.labelNumOfPages.Text = "Количество страниц:";
            // 
            // numericUpDownNumOfPages
            // 
            this.numericUpDownNumOfPages.Location = new System.Drawing.Point(119, 108);
            this.numericUpDownNumOfPages.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownNumOfPages.Name = "numericUpDownNumOfPages";
            this.numericUpDownNumOfPages.Size = new System.Drawing.Size(73, 22);
            this.numericUpDownNumOfPages.TabIndex = 2;
            // 
            // labelStartPage
            // 
            this.labelStartPage.AutoSize = true;
            this.labelStartPage.Location = new System.Drawing.Point(3, 38);
            this.labelStartPage.Name = "labelStartPage";
            this.labelStartPage.Size = new System.Drawing.Size(192, 17);
            this.labelStartPage.TabIndex = 1;
            this.labelStartPage.Text = "Страница начала парсинга:";
            // 
            // textBoxFirstPage
            // 
            this.textBoxFirstPage.Enabled = false;
            this.textBoxFirstPage.Location = new System.Drawing.Point(3, 58);
            this.textBoxFirstPage.Name = "textBoxFirstPage";
            this.textBoxFirstPage.Size = new System.Drawing.Size(189, 22);
            this.textBoxFirstPage.TabIndex = 0;
            this.textBoxFirstPage.Text = "w/index.php?title=%D0%9A%D0%B0%D1%82%D0%B5%D0%B3%D0%BE%D1%80%D0%B8%D1%8F:%D0%A0%D" +
    "0%B5%D0%BA%D0%B8_%D0%BF%D0%BE_%D0%B0%D0%BB%D1%84%D0%B0%D0%B2%D0%B8%D1%82%D1%83";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.riversDataGridView);
            this.tabPage2.Controls.Add(this.riversBindingNavigator);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Загрузка в БД";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // riversDataGridView
            // 
            this.riversDataGridView.AutoGenerateColumns = false;
            this.riversDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.riversDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.riversDataGridView.DataSource = this.riversBindingSource;
            this.riversDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.riversDataGridView.Location = new System.Drawing.Point(3, 30);
            this.riversDataGridView.Name = "riversDataGridView";
            this.riversDataGridView.RowHeadersWidth = 51;
            this.riversDataGridView.RowTemplate.Height = 24;
            this.riversDataGridView.Size = new System.Drawing.Size(786, 388);
            this.riversDataGridView.TabIndex = 0;
            this.riversDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.riversDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "length";
            this.dataGridViewTextBoxColumn3.HeaderText = "length";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "source";
            this.dataGridViewTextBoxColumn4.HeaderText = "source";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "mouth";
            this.dataGridViewTextBoxColumn5.HeaderText = "mouth";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // riversBindingSource
            // 
            this.riversBindingSource.DataMember = "Rivers";
            this.riversBindingSource.DataSource = this.riversDataSet;
            // 
            // riversDataSet
            // 
            this.riversDataSet.DataSetName = "RiversDataSet";
            this.riversDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // riversBindingNavigator
            // 
            this.riversBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.riversBindingNavigator.BindingSource = this.riversBindingSource;
            this.riversBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.riversBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.riversBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.riversBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.riversBindingNavigatorSaveItem});
            this.riversBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.riversBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.riversBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.riversBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.riversBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.riversBindingNavigator.Name = "riversBindingNavigator";
            this.riversBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.riversBindingNavigator.Size = new System.Drawing.Size(786, 27);
            this.riversBindingNavigator.TabIndex = 1;
            this.riversBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // riversBindingNavigatorSaveItem
            // 
            this.riversBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.riversBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("riversBindingNavigatorSaveItem.Image")));
            this.riversBindingNavigatorSaveItem.Name = "riversBindingNavigatorSaveItem";
            this.riversBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.riversBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.riversBindingNavigatorSaveItem.Click += new System.EventHandler(this.riversBindingNavigatorSaveItem_Click);
            // 
            // riversTableAdapter
            // 
            this.riversTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RiversTableAdapter = this.riversTableAdapter;
            this.tableAdapterManager.UpdateOrder = RGRRiverParser.Model.RiversDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Парсер рек";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfPages)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.riversDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riversDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riversBindingNavigator)).EndInit();
            this.riversBindingNavigator.ResumeLayout(false);
            this.riversBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listViewRivers;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderLength;
        private System.Windows.Forms.ColumnHeader columnHeaderSource;
        private System.Windows.Forms.ColumnHeader columnHeaderMouth;
        private System.Windows.Forms.TextBox textBoxFirstPage;
        private System.Windows.Forms.Label labelNumOfPagesComment;
        private System.Windows.Forms.Label labelNumOfPages;
        private System.Windows.Forms.NumericUpDown numericUpDownNumOfPages;
        private System.Windows.Forms.Label labelStartPage;
        private System.Windows.Forms.CheckBox checkBoxChangeFirstPage;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonCopyToDB;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarPageProgress;
        private Model.RiversDataSet riversDataSet;
        private System.Windows.Forms.BindingSource riversBindingSource;
        private Model.RiversDataSetTableAdapters.RiversTableAdapter riversTableAdapter;
        private Model.RiversDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator riversBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton riversBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView riversDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

