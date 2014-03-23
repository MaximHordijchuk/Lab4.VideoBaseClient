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
            this.videoBaseDataSet = new VideoBaseClient.VideoBaseDataSet();
            this.dTFilmsOfGenreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dTFilmsOfGenreTableAdapter = new VideoBaseClient.VideoBaseDataSetTableAdapters.DTFilmsOfGenreTableAdapter();
            this.fMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMTITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSaveTable = new System.Windows.Forms.ToolStripButton();
            this.toolStripRemoveRow = new System.Windows.Forms.ToolStripButton();
            this.toolStripSearch = new System.Windows.Forms.ToolStripButton();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.filmTitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTFilmsOfGenreBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
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
            this.dGNAMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dTFilmsOfGenreBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 190);
            this.dataGridView1.TabIndex = 0;
            // 
            // videoBaseDataSet
            // 
            this.videoBaseDataSet.DataSetName = "VideoBaseDataSet";
            this.videoBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTFilmsOfGenreBindingSource
            // 
            this.dTFilmsOfGenreBindingSource.DataMember = "DTFilmsOfGenre";
            this.dTFilmsOfGenreBindingSource.DataSource = this.videoBaseDataSet;
            // 
            // dTFilmsOfGenreTableAdapter
            // 
            this.dTFilmsOfGenreTableAdapter.ClearBeforeFill = true;
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSaveTable,
            this.toolStripRemoveRow,
            this.toolStripSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(628, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
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
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.filmTitle);
            this.searchGroupBox.Controls.Add(this.titleLabel);
            this.searchGroupBox.Location = new System.Drawing.Point(12, 28);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(604, 143);
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
            // filmTitle
            // 
            this.filmTitle.Location = new System.Drawing.Point(89, 23);
            this.filmTitle.Name = "filmTitle";
            this.filmTitle.Size = new System.Drawing.Size(509, 20);
            this.filmTitle.TabIndex = 1;
            // 
            // FilmsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 432);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FilmsView";
            this.Text = "Фільми за жанром";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTFilmsOfGenreBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMTITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dTFilmsOfGenreBindingSource;
        private VideoBaseDataSet videoBaseDataSet;
        private VideoBaseDataSetTableAdapters.DTFilmsOfGenreTableAdapter dTFilmsOfGenreTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripSaveTable;
        private System.Windows.Forms.ToolStripButton toolStripRemoveRow;
        private System.Windows.Forms.ToolStripButton toolStripSearch;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.TextBox filmTitle;
        private System.Windows.Forms.Label titleLabel;
    }
}