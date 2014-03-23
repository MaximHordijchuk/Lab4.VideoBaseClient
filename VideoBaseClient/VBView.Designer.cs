namespace VideoBaseClient
{
    partial class VBView
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VBView));
            this.topToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolsSaveButton = new System.Windows.Forms.ToolStripButton();
            this.tablesTabs = new System.Windows.Forms.TabControl();
            this.filmsTab = new System.Windows.Forms.TabPage();
            this.removeFilmButton = new System.Windows.Forms.Button();
            this.filmsView = new System.Windows.Forms.DataGridView();
            this.genresTab = new System.Windows.Forms.TabPage();
            this.removeGenreButton = new System.Windows.Forms.Button();
            this.genresView = new System.Windows.Forms.DataGridView();
            this.dGIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorsTab = new System.Windows.Forms.TabPage();
            this.removeActorButton = new System.Windows.Forms.Button();
            this.actorsView = new System.Windows.Forms.DataGridView();
            this.dCRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorsTab = new System.Windows.Forms.TabPage();
            this.removeDirectorButton = new System.Windows.Forms.Button();
            this.directorsView = new System.Windows.Forms.DataGridView();
            this.dDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countriesTab = new System.Windows.Forms.TabPage();
            this.removeCountryButton = new System.Windows.Forms.Button();
            this.countriesView = new System.Windows.Forms.DataGridView();
            this.dCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMTITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMLENGTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMIMDBRATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMKPRATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMANOTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fILMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videoBaseDataSet = new VideoBaseClient.VideoBaseDataSet();
            this.dGNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dICGENREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dCRNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dICCHARACTERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dDNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dICDIRECTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dCNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dICCOUNTRYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fILMTableAdapter = new VideoBaseClient.VideoBaseDataSetTableAdapters.FILMTableAdapter();
            this.dIC_GENRETableAdapter = new VideoBaseClient.VideoBaseDataSetTableAdapters.DIC_GENRETableAdapter();
            this.dIC_CHARACTERTableAdapter = new VideoBaseClient.VideoBaseDataSetTableAdapters.DIC_CHARACTERTableAdapter();
            this.dIC_DIRECTORTableAdapter = new VideoBaseClient.VideoBaseDataSetTableAdapters.DIC_DIRECTORTableAdapter();
            this.dIC_COUNTRYTableAdapter = new VideoBaseClient.VideoBaseDataSetTableAdapters.DIC_COUNTRYTableAdapter();
            this.topToolStrip.SuspendLayout();
            this.tablesTabs.SuspendLayout();
            this.filmsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmsView)).BeginInit();
            this.genresTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genresView)).BeginInit();
            this.actorsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actorsView)).BeginInit();
            this.directorsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.directorsView)).BeginInit();
            this.countriesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countriesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fILMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICGENREBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICCHARACTERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICDIRECTORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICCOUNTRYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // topToolStrip
            // 
            this.topToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsSaveButton});
            this.topToolStrip.Location = new System.Drawing.Point(0, 0);
            this.topToolStrip.Name = "topToolStrip";
            this.topToolStrip.Size = new System.Drawing.Size(660, 25);
            this.topToolStrip.TabIndex = 0;
            this.topToolStrip.Text = "toolStrip1";
            // 
            // toolsSaveButton
            // 
            this.toolsSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolsSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("toolsSaveButton.Image")));
            this.toolsSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsSaveButton.Name = "toolsSaveButton";
            this.toolsSaveButton.Size = new System.Drawing.Size(23, 22);
            this.toolsSaveButton.Text = "toolStripButton1";
            this.toolsSaveButton.Click += new System.EventHandler(this.toolsSaveButton_Click);
            // 
            // tablesTabs
            // 
            this.tablesTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablesTabs.Controls.Add(this.filmsTab);
            this.tablesTabs.Controls.Add(this.genresTab);
            this.tablesTabs.Controls.Add(this.actorsTab);
            this.tablesTabs.Controls.Add(this.directorsTab);
            this.tablesTabs.Controls.Add(this.countriesTab);
            this.tablesTabs.Location = new System.Drawing.Point(12, 28);
            this.tablesTabs.Name = "tablesTabs";
            this.tablesTabs.SelectedIndex = 0;
            this.tablesTabs.Size = new System.Drawing.Size(636, 334);
            this.tablesTabs.TabIndex = 1;
            // 
            // filmsTab
            // 
            this.filmsTab.Controls.Add(this.removeFilmButton);
            this.filmsTab.Controls.Add(this.filmsView);
            this.filmsTab.Location = new System.Drawing.Point(4, 22);
            this.filmsTab.Name = "filmsTab";
            this.filmsTab.Padding = new System.Windows.Forms.Padding(3);
            this.filmsTab.Size = new System.Drawing.Size(628, 308);
            this.filmsTab.TabIndex = 0;
            this.filmsTab.Text = "Фільми";
            this.filmsTab.UseVisualStyleBackColor = true;
            // 
            // removeFilmButton
            // 
            this.removeFilmButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeFilmButton.Location = new System.Drawing.Point(3, 284);
            this.removeFilmButton.Name = "removeFilmButton";
            this.removeFilmButton.Size = new System.Drawing.Size(142, 21);
            this.removeFilmButton.TabIndex = 2;
            this.removeFilmButton.Text = "Видалити рядок";
            this.removeFilmButton.UseVisualStyleBackColor = true;
            this.removeFilmButton.Click += new System.EventHandler(this.removeFilmButton_Click);
            // 
            // filmsView
            // 
            this.filmsView.AllowUserToDeleteRows = false;
            this.filmsView.AllowUserToOrderColumns = true;
            this.filmsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filmsView.AutoGenerateColumns = false;
            this.filmsView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.filmsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fMTITLEDataGridViewTextBoxColumn,
            this.fMYEARDataGridViewTextBoxColumn,
            this.fMLENGTHDataGridViewTextBoxColumn,
            this.fMIMDBRATEDataGridViewTextBoxColumn,
            this.fMKPRATEDataGridViewTextBoxColumn,
            this.fMANOTDataGridViewTextBoxColumn});
            this.filmsView.DataSource = this.fILMBindingSource;
            this.filmsView.Location = new System.Drawing.Point(3, 3);
            this.filmsView.Name = "filmsView";
            this.filmsView.Size = new System.Drawing.Size(622, 275);
            this.filmsView.TabIndex = 0;
            this.filmsView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.filmsView_CellValueChanged);
            // 
            // genresTab
            // 
            this.genresTab.Controls.Add(this.removeGenreButton);
            this.genresTab.Controls.Add(this.genresView);
            this.genresTab.Location = new System.Drawing.Point(4, 22);
            this.genresTab.Name = "genresTab";
            this.genresTab.Padding = new System.Windows.Forms.Padding(3);
            this.genresTab.Size = new System.Drawing.Size(628, 308);
            this.genresTab.TabIndex = 1;
            this.genresTab.Text = "Жанри";
            this.genresTab.UseVisualStyleBackColor = true;
            // 
            // removeGenreButton
            // 
            this.removeGenreButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeGenreButton.Location = new System.Drawing.Point(3, 284);
            this.removeGenreButton.Name = "removeGenreButton";
            this.removeGenreButton.Size = new System.Drawing.Size(142, 21);
            this.removeGenreButton.TabIndex = 3;
            this.removeGenreButton.Text = "Видалити рядок";
            this.removeGenreButton.UseVisualStyleBackColor = true;
            this.removeGenreButton.Click += new System.EventHandler(this.removeGenreButton_Click);
            // 
            // genresView
            // 
            this.genresView.AllowUserToDeleteRows = false;
            this.genresView.AllowUserToOrderColumns = true;
            this.genresView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genresView.AutoGenerateColumns = false;
            this.genresView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.genresView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genresView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dGIDDataGridViewTextBoxColumn,
            this.dGNAMEDataGridViewTextBoxColumn});
            this.genresView.DataSource = this.dICGENREBindingSource;
            this.genresView.Location = new System.Drawing.Point(3, 3);
            this.genresView.Name = "genresView";
            this.genresView.Size = new System.Drawing.Size(622, 275);
            this.genresView.TabIndex = 0;
            this.genresView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.genresView_CellDoubleClick);
            this.genresView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.genresView_CellValueChanged);
            // 
            // dGIDDataGridViewTextBoxColumn
            // 
            this.dGIDDataGridViewTextBoxColumn.DataPropertyName = "DG_ID";
            this.dGIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.dGIDDataGridViewTextBoxColumn.Name = "dGIDDataGridViewTextBoxColumn";
            this.dGIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dGIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // actorsTab
            // 
            this.actorsTab.Controls.Add(this.removeActorButton);
            this.actorsTab.Controls.Add(this.actorsView);
            this.actorsTab.Location = new System.Drawing.Point(4, 22);
            this.actorsTab.Name = "actorsTab";
            this.actorsTab.Size = new System.Drawing.Size(628, 308);
            this.actorsTab.TabIndex = 2;
            this.actorsTab.Text = "Актори";
            this.actorsTab.UseVisualStyleBackColor = true;
            // 
            // removeActorButton
            // 
            this.removeActorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeActorButton.Location = new System.Drawing.Point(3, 284);
            this.removeActorButton.Name = "removeActorButton";
            this.removeActorButton.Size = new System.Drawing.Size(142, 21);
            this.removeActorButton.TabIndex = 3;
            this.removeActorButton.Text = "Видалити рядок";
            this.removeActorButton.UseVisualStyleBackColor = true;
            this.removeActorButton.Click += new System.EventHandler(this.removeActorButton_Click);
            // 
            // actorsView
            // 
            this.actorsView.AllowUserToDeleteRows = false;
            this.actorsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actorsView.AutoGenerateColumns = false;
            this.actorsView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.actorsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actorsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dCRIDDataGridViewTextBoxColumn,
            this.dCRNAMEDataGridViewTextBoxColumn});
            this.actorsView.DataSource = this.dICCHARACTERBindingSource;
            this.actorsView.Location = new System.Drawing.Point(3, 3);
            this.actorsView.Name = "actorsView";
            this.actorsView.Size = new System.Drawing.Size(622, 275);
            this.actorsView.TabIndex = 0;
            this.actorsView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.actorsView_CellValueChanged);
            // 
            // dCRIDDataGridViewTextBoxColumn
            // 
            this.dCRIDDataGridViewTextBoxColumn.DataPropertyName = "DCR_ID";
            this.dCRIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.dCRIDDataGridViewTextBoxColumn.Name = "dCRIDDataGridViewTextBoxColumn";
            this.dCRIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dCRIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // directorsTab
            // 
            this.directorsTab.Controls.Add(this.removeDirectorButton);
            this.directorsTab.Controls.Add(this.directorsView);
            this.directorsTab.Location = new System.Drawing.Point(4, 22);
            this.directorsTab.Name = "directorsTab";
            this.directorsTab.Size = new System.Drawing.Size(628, 308);
            this.directorsTab.TabIndex = 3;
            this.directorsTab.Text = "Режисери";
            this.directorsTab.UseVisualStyleBackColor = true;
            // 
            // removeDirectorButton
            // 
            this.removeDirectorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeDirectorButton.Location = new System.Drawing.Point(3, 284);
            this.removeDirectorButton.Name = "removeDirectorButton";
            this.removeDirectorButton.Size = new System.Drawing.Size(142, 21);
            this.removeDirectorButton.TabIndex = 3;
            this.removeDirectorButton.Text = "Видалити рядок";
            this.removeDirectorButton.UseVisualStyleBackColor = true;
            this.removeDirectorButton.Click += new System.EventHandler(this.removeDirectorButton_Click);
            // 
            // directorsView
            // 
            this.directorsView.AllowUserToDeleteRows = false;
            this.directorsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directorsView.AutoGenerateColumns = false;
            this.directorsView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.directorsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directorsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dDIDDataGridViewTextBoxColumn,
            this.dDNAMEDataGridViewTextBoxColumn});
            this.directorsView.DataSource = this.dICDIRECTORBindingSource;
            this.directorsView.Location = new System.Drawing.Point(3, 3);
            this.directorsView.Name = "directorsView";
            this.directorsView.Size = new System.Drawing.Size(622, 275);
            this.directorsView.TabIndex = 0;
            this.directorsView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.directorsView_CellValueChanged);
            // 
            // dDIDDataGridViewTextBoxColumn
            // 
            this.dDIDDataGridViewTextBoxColumn.DataPropertyName = "DD_ID";
            this.dDIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.dDIDDataGridViewTextBoxColumn.Name = "dDIDDataGridViewTextBoxColumn";
            this.dDIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dDIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // countriesTab
            // 
            this.countriesTab.Controls.Add(this.removeCountryButton);
            this.countriesTab.Controls.Add(this.countriesView);
            this.countriesTab.Location = new System.Drawing.Point(4, 22);
            this.countriesTab.Name = "countriesTab";
            this.countriesTab.Size = new System.Drawing.Size(628, 308);
            this.countriesTab.TabIndex = 4;
            this.countriesTab.Text = "Країни";
            this.countriesTab.UseVisualStyleBackColor = true;
            // 
            // removeCountryButton
            // 
            this.removeCountryButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeCountryButton.Location = new System.Drawing.Point(3, 284);
            this.removeCountryButton.Name = "removeCountryButton";
            this.removeCountryButton.Size = new System.Drawing.Size(142, 21);
            this.removeCountryButton.TabIndex = 3;
            this.removeCountryButton.Text = "Видалити рядок";
            this.removeCountryButton.UseVisualStyleBackColor = true;
            this.removeCountryButton.Click += new System.EventHandler(this.removeCountryButton_Click);
            // 
            // countriesView
            // 
            this.countriesView.AllowUserToDeleteRows = false;
            this.countriesView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countriesView.AutoGenerateColumns = false;
            this.countriesView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.countriesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countriesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dCIDDataGridViewTextBoxColumn,
            this.dCNAMEDataGridViewTextBoxColumn});
            this.countriesView.DataSource = this.dICCOUNTRYBindingSource;
            this.countriesView.Location = new System.Drawing.Point(3, 3);
            this.countriesView.Name = "countriesView";
            this.countriesView.Size = new System.Drawing.Size(622, 275);
            this.countriesView.TabIndex = 0;
            this.countriesView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.countriesView_CellValueChanged);
            // 
            // dCIDDataGridViewTextBoxColumn
            // 
            this.dCIDDataGridViewTextBoxColumn.DataPropertyName = "DC_ID";
            this.dCIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.dCIDDataGridViewTextBoxColumn.Name = "dCIDDataGridViewTextBoxColumn";
            this.dCIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dCIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // fMTITLEDataGridViewTextBoxColumn
            // 
            this.fMTITLEDataGridViewTextBoxColumn.DataPropertyName = "FM_TITLE";
            this.fMTITLEDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.fMTITLEDataGridViewTextBoxColumn.Name = "fMTITLEDataGridViewTextBoxColumn";
            // 
            // fMYEARDataGridViewTextBoxColumn
            // 
            this.fMYEARDataGridViewTextBoxColumn.DataPropertyName = "FM_YEAR";
            this.fMYEARDataGridViewTextBoxColumn.HeaderText = "Рік";
            this.fMYEARDataGridViewTextBoxColumn.Name = "fMYEARDataGridViewTextBoxColumn";
            // 
            // fMLENGTHDataGridViewTextBoxColumn
            // 
            this.fMLENGTHDataGridViewTextBoxColumn.DataPropertyName = "FM_LENGTH";
            this.fMLENGTHDataGridViewTextBoxColumn.HeaderText = "Тривалість";
            this.fMLENGTHDataGridViewTextBoxColumn.Name = "fMLENGTHDataGridViewTextBoxColumn";
            // 
            // fMIMDBRATEDataGridViewTextBoxColumn
            // 
            this.fMIMDBRATEDataGridViewTextBoxColumn.DataPropertyName = "FM_IMDB_RATE";
            this.fMIMDBRATEDataGridViewTextBoxColumn.HeaderText = "Рейтинг IMDB";
            this.fMIMDBRATEDataGridViewTextBoxColumn.Name = "fMIMDBRATEDataGridViewTextBoxColumn";
            // 
            // fMKPRATEDataGridViewTextBoxColumn
            // 
            this.fMKPRATEDataGridViewTextBoxColumn.DataPropertyName = "FM_KP_RATE";
            this.fMKPRATEDataGridViewTextBoxColumn.HeaderText = "Рейтинг Кінопошуку";
            this.fMKPRATEDataGridViewTextBoxColumn.Name = "fMKPRATEDataGridViewTextBoxColumn";
            // 
            // fMANOTDataGridViewTextBoxColumn
            // 
            this.fMANOTDataGridViewTextBoxColumn.DataPropertyName = "FM_ANOT";
            this.fMANOTDataGridViewTextBoxColumn.HeaderText = "Анотація";
            this.fMANOTDataGridViewTextBoxColumn.Name = "fMANOTDataGridViewTextBoxColumn";
            // 
            // fILMBindingSource
            // 
            this.fILMBindingSource.DataMember = "FILM";
            this.fILMBindingSource.DataSource = this.videoBaseDataSet;
            // 
            // videoBaseDataSet
            // 
            this.videoBaseDataSet.DataSetName = "VideoBaseDataSet";
            this.videoBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dGNAMEDataGridViewTextBoxColumn
            // 
            this.dGNAMEDataGridViewTextBoxColumn.DataPropertyName = "DG_NAME";
            this.dGNAMEDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.dGNAMEDataGridViewTextBoxColumn.Name = "dGNAMEDataGridViewTextBoxColumn";
            // 
            // dICGENREBindingSource
            // 
            this.dICGENREBindingSource.DataMember = "DIC_GENRE";
            this.dICGENREBindingSource.DataSource = this.videoBaseDataSet;
            // 
            // dCRNAMEDataGridViewTextBoxColumn
            // 
            this.dCRNAMEDataGridViewTextBoxColumn.DataPropertyName = "DCR_NAME";
            this.dCRNAMEDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.dCRNAMEDataGridViewTextBoxColumn.Name = "dCRNAMEDataGridViewTextBoxColumn";
            // 
            // dICCHARACTERBindingSource
            // 
            this.dICCHARACTERBindingSource.DataMember = "DIC_CHARACTER";
            this.dICCHARACTERBindingSource.DataSource = this.videoBaseDataSet;
            // 
            // dDNAMEDataGridViewTextBoxColumn
            // 
            this.dDNAMEDataGridViewTextBoxColumn.DataPropertyName = "DD_NAME";
            this.dDNAMEDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.dDNAMEDataGridViewTextBoxColumn.Name = "dDNAMEDataGridViewTextBoxColumn";
            // 
            // dICDIRECTORBindingSource
            // 
            this.dICDIRECTORBindingSource.DataMember = "DIC_DIRECTOR";
            this.dICDIRECTORBindingSource.DataSource = this.videoBaseDataSet;
            // 
            // dCNAMEDataGridViewTextBoxColumn
            // 
            this.dCNAMEDataGridViewTextBoxColumn.DataPropertyName = "DC_NAME";
            this.dCNAMEDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.dCNAMEDataGridViewTextBoxColumn.Name = "dCNAMEDataGridViewTextBoxColumn";
            // 
            // dICCOUNTRYBindingSource
            // 
            this.dICCOUNTRYBindingSource.DataMember = "DIC_COUNTRY";
            this.dICCOUNTRYBindingSource.DataSource = this.videoBaseDataSet;
            // 
            // fILMTableAdapter
            // 
            this.fILMTableAdapter.ClearBeforeFill = true;
            // 
            // dIC_GENRETableAdapter
            // 
            this.dIC_GENRETableAdapter.ClearBeforeFill = true;
            // 
            // dIC_CHARACTERTableAdapter
            // 
            this.dIC_CHARACTERTableAdapter.ClearBeforeFill = true;
            // 
            // dIC_DIRECTORTableAdapter
            // 
            this.dIC_DIRECTORTableAdapter.ClearBeforeFill = true;
            // 
            // dIC_COUNTRYTableAdapter
            // 
            this.dIC_COUNTRYTableAdapter.ClearBeforeFill = true;
            // 
            // VBView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 374);
            this.Controls.Add(this.tablesTabs);
            this.Controls.Add(this.topToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VBView";
            this.Text = "Фільмотека";
            this.Load += new System.EventHandler(this.VBView_Load);
            this.topToolStrip.ResumeLayout(false);
            this.topToolStrip.PerformLayout();
            this.tablesTabs.ResumeLayout(false);
            this.filmsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filmsView)).EndInit();
            this.genresTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.genresView)).EndInit();
            this.actorsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.actorsView)).EndInit();
            this.directorsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.directorsView)).EndInit();
            this.countriesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.countriesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fILMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICGENREBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICCHARACTERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICDIRECTORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICCOUNTRYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip topToolStrip;
        private System.Windows.Forms.ToolStripButton toolsSaveButton;
        private System.Windows.Forms.TabControl tablesTabs;
        private System.Windows.Forms.TabPage filmsTab;
        private System.Windows.Forms.TabPage genresTab;
        private System.Windows.Forms.DataGridView genresView;
        private System.Windows.Forms.TabPage actorsTab;
        private System.Windows.Forms.DataGridView actorsView;
        private System.Windows.Forms.TabPage directorsTab;
        private System.Windows.Forms.DataGridView directorsView;
        private System.Windows.Forms.TabPage countriesTab;
        private System.Windows.Forms.DataGridView countriesView;
        private System.Windows.Forms.DataGridView filmsView;
        private VideoBaseDataSet videoBaseDataSet;
        private System.Windows.Forms.BindingSource fILMBindingSource;
        private VideoBaseDataSetTableAdapters.FILMTableAdapter fILMTableAdapter;
        private System.Windows.Forms.BindingSource dICGENREBindingSource;
        private VideoBaseDataSetTableAdapters.DIC_GENRETableAdapter dIC_GENRETableAdapter;
        private System.Windows.Forms.BindingSource dICCHARACTERBindingSource;
        private VideoBaseDataSetTableAdapters.DIC_CHARACTERTableAdapter dIC_CHARACTERTableAdapter;
        private System.Windows.Forms.BindingSource dICDIRECTORBindingSource;
        private VideoBaseDataSetTableAdapters.DIC_DIRECTORTableAdapter dIC_DIRECTORTableAdapter;
        private System.Windows.Forms.BindingSource dICCOUNTRYBindingSource;
        private VideoBaseDataSetTableAdapters.DIC_COUNTRYTableAdapter dIC_COUNTRYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMTITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMLENGTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMIMDBRATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMKPRATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMANOTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button removeFilmButton;
        private System.Windows.Forms.Button removeGenreButton;
        private System.Windows.Forms.Button removeActorButton;
        private System.Windows.Forms.Button removeDirectorButton;
        private System.Windows.Forms.Button removeCountryButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCRNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCNAMEDataGridViewTextBoxColumn;
    }
}

