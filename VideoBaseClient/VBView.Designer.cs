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
            this.genresTab = new System.Windows.Forms.TabPage();
            this.genresView = new System.Windows.Forms.DataGridView();
            this.actorsTab = new System.Windows.Forms.TabPage();
            this.actorsView = new System.Windows.Forms.DataGridView();
            this.directorsTab = new System.Windows.Forms.TabPage();
            this.directorsView = new System.Windows.Forms.DataGridView();
            this.countriesTab = new System.Windows.Forms.TabPage();
            this.countriesView = new System.Windows.Forms.DataGridView();
            this.filmsView = new System.Windows.Forms.DataGridView();
            this.videoBaseDataSet = new VideoBaseClient.VideoBaseDataSet();
            this.fILMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fILMTableAdapter = new VideoBaseClient.VideoBaseDataSetTableAdapters.FILMTableAdapter();
            this.dICGENREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIC_GENRETableAdapter = new VideoBaseClient.VideoBaseDataSetTableAdapters.DIC_GENRETableAdapter();
            this.dICCHARACTERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIC_CHARACTERTableAdapter = new VideoBaseClient.VideoBaseDataSetTableAdapters.DIC_CHARACTERTableAdapter();
            this.dICDIRECTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIC_DIRECTORTableAdapter = new VideoBaseClient.VideoBaseDataSetTableAdapters.DIC_DIRECTORTableAdapter();
            this.dICCOUNTRYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIC_COUNTRYTableAdapter = new VideoBaseClient.VideoBaseDataSetTableAdapters.DIC_COUNTRYTableAdapter();
            this.fMTITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMLENGTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMIMDBRATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMKPRATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMANOTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCRNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topToolStrip.SuspendLayout();
            this.tablesTabs.SuspendLayout();
            this.filmsTab.SuspendLayout();
            this.genresTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genresView)).BeginInit();
            this.actorsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actorsView)).BeginInit();
            this.directorsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.directorsView)).BeginInit();
            this.countriesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countriesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fILMBindingSource)).BeginInit();
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
            this.tablesTabs.Size = new System.Drawing.Size(636, 293);
            this.tablesTabs.TabIndex = 1;
            // 
            // filmsTab
            // 
            this.filmsTab.Controls.Add(this.filmsView);
            this.filmsTab.Location = new System.Drawing.Point(4, 22);
            this.filmsTab.Name = "filmsTab";
            this.filmsTab.Padding = new System.Windows.Forms.Padding(3);
            this.filmsTab.Size = new System.Drawing.Size(628, 267);
            this.filmsTab.TabIndex = 0;
            this.filmsTab.Text = "Фільми";
            this.filmsTab.UseVisualStyleBackColor = true;
            // 
            // genresTab
            // 
            this.genresTab.Controls.Add(this.genresView);
            this.genresTab.Location = new System.Drawing.Point(4, 22);
            this.genresTab.Name = "genresTab";
            this.genresTab.Padding = new System.Windows.Forms.Padding(3);
            this.genresTab.Size = new System.Drawing.Size(628, 267);
            this.genresTab.TabIndex = 1;
            this.genresTab.Text = "Жанри";
            this.genresTab.UseVisualStyleBackColor = true;
            // 
            // genresView
            // 
            this.genresView.AutoGenerateColumns = false;
            this.genresView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genresView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dGNAMEDataGridViewTextBoxColumn});
            this.genresView.DataSource = this.dICGENREBindingSource;
            this.genresView.Location = new System.Drawing.Point(3, 3);
            this.genresView.Name = "genresView";
            this.genresView.Size = new System.Drawing.Size(622, 261);
            this.genresView.TabIndex = 0;
            // 
            // actorsTab
            // 
            this.actorsTab.Controls.Add(this.actorsView);
            this.actorsTab.Location = new System.Drawing.Point(4, 22);
            this.actorsTab.Name = "actorsTab";
            this.actorsTab.Size = new System.Drawing.Size(628, 267);
            this.actorsTab.TabIndex = 2;
            this.actorsTab.Text = "Актори";
            this.actorsTab.UseVisualStyleBackColor = true;
            // 
            // actorsView
            // 
            this.actorsView.AutoGenerateColumns = false;
            this.actorsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actorsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dCRNAMEDataGridViewTextBoxColumn});
            this.actorsView.DataSource = this.dICCHARACTERBindingSource;
            this.actorsView.Location = new System.Drawing.Point(3, 3);
            this.actorsView.Name = "actorsView";
            this.actorsView.Size = new System.Drawing.Size(622, 261);
            this.actorsView.TabIndex = 0;
            // 
            // directorsTab
            // 
            this.directorsTab.Controls.Add(this.directorsView);
            this.directorsTab.Location = new System.Drawing.Point(4, 22);
            this.directorsTab.Name = "directorsTab";
            this.directorsTab.Size = new System.Drawing.Size(628, 267);
            this.directorsTab.TabIndex = 3;
            this.directorsTab.Text = "Режисери";
            this.directorsTab.UseVisualStyleBackColor = true;
            // 
            // directorsView
            // 
            this.directorsView.AutoGenerateColumns = false;
            this.directorsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directorsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dDNAMEDataGridViewTextBoxColumn});
            this.directorsView.DataSource = this.dICDIRECTORBindingSource;
            this.directorsView.Location = new System.Drawing.Point(3, 3);
            this.directorsView.Name = "directorsView";
            this.directorsView.Size = new System.Drawing.Size(622, 261);
            this.directorsView.TabIndex = 0;
            // 
            // countriesTab
            // 
            this.countriesTab.Controls.Add(this.countriesView);
            this.countriesTab.Location = new System.Drawing.Point(4, 22);
            this.countriesTab.Name = "countriesTab";
            this.countriesTab.Size = new System.Drawing.Size(628, 267);
            this.countriesTab.TabIndex = 4;
            this.countriesTab.Text = "Країни";
            this.countriesTab.UseVisualStyleBackColor = true;
            // 
            // countriesView
            // 
            this.countriesView.AutoGenerateColumns = false;
            this.countriesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countriesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dCNAMEDataGridViewTextBoxColumn});
            this.countriesView.DataSource = this.dICCOUNTRYBindingSource;
            this.countriesView.Location = new System.Drawing.Point(3, 3);
            this.countriesView.Name = "countriesView";
            this.countriesView.Size = new System.Drawing.Size(622, 261);
            this.countriesView.TabIndex = 0;
            // 
            // filmsView
            // 
            this.filmsView.AllowUserToOrderColumns = true;
            this.filmsView.AutoGenerateColumns = false;
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
            this.filmsView.Size = new System.Drawing.Size(622, 261);
            this.filmsView.TabIndex = 0;
            // 
            // videoBaseDataSet
            // 
            this.videoBaseDataSet.DataSetName = "VideoBaseDataSet";
            this.videoBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fILMBindingSource
            // 
            this.fILMBindingSource.DataMember = "FILM";
            this.fILMBindingSource.DataSource = this.videoBaseDataSet;
            // 
            // fILMTableAdapter
            // 
            this.fILMTableAdapter.ClearBeforeFill = true;
            // 
            // dICGENREBindingSource
            // 
            this.dICGENREBindingSource.DataMember = "DIC_GENRE";
            this.dICGENREBindingSource.DataSource = this.videoBaseDataSet;
            // 
            // dIC_GENRETableAdapter
            // 
            this.dIC_GENRETableAdapter.ClearBeforeFill = true;
            // 
            // dICCHARACTERBindingSource
            // 
            this.dICCHARACTERBindingSource.DataMember = "DIC_CHARACTER";
            this.dICCHARACTERBindingSource.DataSource = this.videoBaseDataSet;
            // 
            // dIC_CHARACTERTableAdapter
            // 
            this.dIC_CHARACTERTableAdapter.ClearBeforeFill = true;
            // 
            // dICDIRECTORBindingSource
            // 
            this.dICDIRECTORBindingSource.DataMember = "DIC_DIRECTOR";
            this.dICDIRECTORBindingSource.DataSource = this.videoBaseDataSet;
            // 
            // dIC_DIRECTORTableAdapter
            // 
            this.dIC_DIRECTORTableAdapter.ClearBeforeFill = true;
            // 
            // dICCOUNTRYBindingSource
            // 
            this.dICCOUNTRYBindingSource.DataMember = "DIC_COUNTRY";
            this.dICCOUNTRYBindingSource.DataSource = this.videoBaseDataSet;
            // 
            // dIC_COUNTRYTableAdapter
            // 
            this.dIC_COUNTRYTableAdapter.ClearBeforeFill = true;
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
            // dGNAMEDataGridViewTextBoxColumn
            // 
            this.dGNAMEDataGridViewTextBoxColumn.DataPropertyName = "DG_NAME";
            this.dGNAMEDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.dGNAMEDataGridViewTextBoxColumn.Name = "dGNAMEDataGridViewTextBoxColumn";
            // 
            // dCRNAMEDataGridViewTextBoxColumn
            // 
            this.dCRNAMEDataGridViewTextBoxColumn.DataPropertyName = "DCR_NAME";
            this.dCRNAMEDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.dCRNAMEDataGridViewTextBoxColumn.Name = "dCRNAMEDataGridViewTextBoxColumn";
            // 
            // dDNAMEDataGridViewTextBoxColumn
            // 
            this.dDNAMEDataGridViewTextBoxColumn.DataPropertyName = "DD_NAME";
            this.dDNAMEDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.dDNAMEDataGridViewTextBoxColumn.Name = "dDNAMEDataGridViewTextBoxColumn";
            // 
            // dCNAMEDataGridViewTextBoxColumn
            // 
            this.dCNAMEDataGridViewTextBoxColumn.DataPropertyName = "DC_NAME";
            this.dCNAMEDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.dCNAMEDataGridViewTextBoxColumn.Name = "dCNAMEDataGridViewTextBoxColumn";
            // 
            // VBView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 333);
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
            this.genresTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.genresView)).EndInit();
            this.actorsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.actorsView)).EndInit();
            this.directorsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.directorsView)).EndInit();
            this.countriesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.countriesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fILMBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dGNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCRNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCNAMEDataGridViewTextBoxColumn;
    }
}

