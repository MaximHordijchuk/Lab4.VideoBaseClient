namespace VideoBaseClient
{
    partial class FilmsView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmsView));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.topToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSaveTable = new System.Windows.Forms.ToolStripButton();
            this.toolStripRemoveRow = new System.Windows.Forms.ToolStripButton();
            this.toolStripSearch = new System.Windows.Forms.ToolStripButton();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.tbFilmTitle = new System.Windows.Forms.TextBox();
            this.actorLabel = new System.Windows.Forms.Label();
            this.tbActorName = new System.Windows.Forms.TextBox();
            this.directorLabel = new System.Windows.Forms.Label();
            this.tbDirectorName = new System.Windows.Forms.TextBox();
            this.fMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMTITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCRNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTFilmsOfGenreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videoBaseDataSet = new VideoBaseClient.VideoBaseDataSet();
            this.dTFilmsOfGenreTableAdapter = new VideoBaseClient.VideoBaseDataSetTableAdapters.DTFilmsOfGenreTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.topToolStrip.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dTFilmsOfGenreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fMIDDataGridViewTextBoxColumn,
            this.fMTITLEDataGridViewTextBoxColumn,
            this.fMYEARDataGridViewTextBoxColumn,
            this.dGNAMEDataGridViewTextBoxColumn,
            this.dCRNAMEDataGridViewTextBoxColumn,
            this.dDNAMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dTFilmsOfGenreBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 190);
            this.dataGridView1.TabIndex = 0;
            // 
            // topToolStrip
            // 
            this.topToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSaveTable,
            this.toolStripRemoveRow,
            this.toolStripSearch});
            this.topToolStrip.Location = new System.Drawing.Point(0, 0);
            this.topToolStrip.Name = "topToolStrip";
            this.topToolStrip.Size = new System.Drawing.Size(628, 25);
            this.topToolStrip.TabIndex = 1;
            this.topToolStrip.Text = "Інструменти";
            // 
            // toolStripSaveTable
            // 
            this.toolStripSaveTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSaveTable.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSaveTable.Image")));
            this.toolStripSaveTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveTable.Name = "toolStripSaveTable";
            this.toolStripSaveTable.Size = new System.Drawing.Size(23, 22);
            this.toolStripSaveTable.Text = "Зберегти";
            // 
            // toolStripRemoveRow
            // 
            this.toolStripRemoveRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRemoveRow.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRemoveRow.Image")));
            this.toolStripRemoveRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRemoveRow.Name = "toolStripRemoveRow";
            this.toolStripRemoveRow.Size = new System.Drawing.Size(23, 22);
            this.toolStripRemoveRow.Text = "Видалити";
            // 
            // toolStripSearch
            // 
            this.toolStripSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSearch.Image")));
            this.toolStripSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSearch.Name = "toolStripSearch";
            this.toolStripSearch.Size = new System.Drawing.Size(23, 22);
            this.toolStripSearch.Text = "Шукати";
            this.toolStripSearch.Click += new System.EventHandler(this.toolStripSearch_Click);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.tbDirectorName);
            this.searchGroupBox.Controls.Add(this.directorLabel);
            this.searchGroupBox.Controls.Add(this.tbActorName);
            this.searchGroupBox.Controls.Add(this.actorLabel);
            this.searchGroupBox.Controls.Add(this.tbFilmTitle);
            this.searchGroupBox.Controls.Add(this.titleLabel);
            this.searchGroupBox.Location = new System.Drawing.Point(12, 28);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(604, 107);
            this.searchGroupBox.TabIndex = 2;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Параметри пошуку";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(6, 26);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(80, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Назва фільму:";
            // 
            // tbFilmTitle
            // 
            this.tbFilmTitle.Location = new System.Drawing.Point(89, 23);
            this.tbFilmTitle.Name = "tbFilmTitle";
            this.tbFilmTitle.Size = new System.Drawing.Size(509, 20);
            this.tbFilmTitle.TabIndex = 1;
            // 
            // actorLabel
            // 
            this.actorLabel.AutoSize = true;
            this.actorLabel.Location = new System.Drawing.Point(6, 52);
            this.actorLabel.Name = "actorLabel";
            this.actorLabel.Size = new System.Drawing.Size(40, 13);
            this.actorLabel.TabIndex = 2;
            this.actorLabel.Text = "Актор:";
            // 
            // tbActorName
            // 
            this.tbActorName.Location = new System.Drawing.Point(89, 49);
            this.tbActorName.Name = "tbActorName";
            this.tbActorName.Size = new System.Drawing.Size(509, 20);
            this.tbActorName.TabIndex = 3;
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.Location = new System.Drawing.Point(6, 78);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(55, 13);
            this.directorLabel.TabIndex = 4;
            this.directorLabel.Text = "Режисер:";
            // 
            // tbDirectorName
            // 
            this.tbDirectorName.Location = new System.Drawing.Point(89, 75);
            this.tbDirectorName.Name = "tbDirectorName";
            this.tbDirectorName.Size = new System.Drawing.Size(509, 20);
            this.tbDirectorName.TabIndex = 5;
            // 
            // fMIDDataGridViewTextBoxColumn
            // 
            this.fMIDDataGridViewTextBoxColumn.DataPropertyName = "FM_ID";
            this.fMIDDataGridViewTextBoxColumn.HeaderText = "FM_ID";
            this.fMIDDataGridViewTextBoxColumn.Name = "fMIDDataGridViewTextBoxColumn";
            this.fMIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fMTITLEDataGridViewTextBoxColumn
            // 
            this.fMTITLEDataGridViewTextBoxColumn.DataPropertyName = "FM_TITLE";
            this.fMTITLEDataGridViewTextBoxColumn.HeaderText = "FM_TITLE";
            this.fMTITLEDataGridViewTextBoxColumn.Name = "fMTITLEDataGridViewTextBoxColumn";
            // 
            // fMYEARDataGridViewTextBoxColumn
            // 
            this.fMYEARDataGridViewTextBoxColumn.DataPropertyName = "FM_YEAR";
            this.fMYEARDataGridViewTextBoxColumn.HeaderText = "FM_YEAR";
            this.fMYEARDataGridViewTextBoxColumn.Name = "fMYEARDataGridViewTextBoxColumn";
            // 
            // dGNAMEDataGridViewTextBoxColumn
            // 
            this.dGNAMEDataGridViewTextBoxColumn.DataPropertyName = "DG_NAME";
            this.dGNAMEDataGridViewTextBoxColumn.HeaderText = "DG_NAME";
            this.dGNAMEDataGridViewTextBoxColumn.Name = "dGNAMEDataGridViewTextBoxColumn";
            // 
            // dCRNAMEDataGridViewTextBoxColumn
            // 
            this.dCRNAMEDataGridViewTextBoxColumn.DataPropertyName = "DCR_NAME";
            this.dCRNAMEDataGridViewTextBoxColumn.HeaderText = "DCR_NAME";
            this.dCRNAMEDataGridViewTextBoxColumn.Name = "dCRNAMEDataGridViewTextBoxColumn";
            // 
            // dDNAMEDataGridViewTextBoxColumn
            // 
            this.dDNAMEDataGridViewTextBoxColumn.DataPropertyName = "DD_NAME";
            this.dDNAMEDataGridViewTextBoxColumn.HeaderText = "DD_NAME";
            this.dDNAMEDataGridViewTextBoxColumn.Name = "dDNAMEDataGridViewTextBoxColumn";
            // 
            // dTFilmsOfGenreBindingSource
            // 
            this.dTFilmsOfGenreBindingSource.DataMember = "DTFilmsOfGenre";
            this.dTFilmsOfGenreBindingSource.DataSource = this.videoBaseDataSet;
            // 
            // videoBaseDataSet
            // 
            this.videoBaseDataSet.DataSetName = "VideoBaseDataSet";
            this.videoBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTFilmsOfGenreTableAdapter
            // 
            this.dTFilmsOfGenreTableAdapter.ClearBeforeFill = true;
            // 
            // FilmsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 432);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.topToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FilmsView";
            this.Text = "Фільми за жанром";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.topToolStrip.ResumeLayout(false);
            this.topToolStrip.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dTFilmsOfGenreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip topToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripSaveTable;
        private System.Windows.Forms.ToolStripButton toolStripRemoveRow;
        private System.Windows.Forms.ToolStripButton toolStripSearch;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.TextBox tbFilmTitle;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox tbActorName;
        private System.Windows.Forms.Label actorLabel;
        private System.Windows.Forms.TextBox tbDirectorName;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMTITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCRNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dTFilmsOfGenreBindingSource;
        private VideoBaseDataSet videoBaseDataSet;
        private VideoBaseDataSetTableAdapters.DTFilmsOfGenreTableAdapter dTFilmsOfGenreTableAdapter;
    }
}