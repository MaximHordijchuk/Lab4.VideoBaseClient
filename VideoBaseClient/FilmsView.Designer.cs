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
            this.filmView = new System.Windows.Forms.DataGridView();
            this.topToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSaveTable = new System.Windows.Forms.ToolStripButton();
            this.toolStripSearch = new System.Windows.Forms.ToolStripButton();
            this.gbFiltres = new System.Windows.Forms.GroupBox();
            this.tbDirectorName = new System.Windows.Forms.TextBox();
            this.directorLabel = new System.Windows.Forms.Label();
            this.tbActorName = new System.Windows.Forms.TextBox();
            this.actorLabel = new System.Windows.Forms.Label();
            this.tbFilmTitle = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.gbResultFilms = new System.Windows.Forms.GroupBox();
            this.gbResultActors = new System.Windows.Forms.GroupBox();
            this.actorsView = new System.Windows.Forms.DataGridView();
            this.dCRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCRNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTCharactersOfFilmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videoBaseDataSet = new VideoBaseClient.VideoBaseDataSet();
            this.fMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMTITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMLENGTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMIMDBRATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMKPRATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMANOTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTFilmsOfGenreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dTFilmsOfGenreTableAdapter = new VideoBaseClient.VideoBaseDataSetTableAdapters.DTFilmsOfGenreTableAdapter();
            this.dTCharactersOfFilmTableAdapter = new VideoBaseClient.VideoBaseDataSetTableAdapters.DTCharactersOfFilmTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.filmView)).BeginInit();
            this.topToolStrip.SuspendLayout();
            this.gbFiltres.SuspendLayout();
            this.gbResultFilms.SuspendLayout();
            this.gbResultActors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actorsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTCharactersOfFilmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTFilmsOfGenreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // filmView
            // 
            this.filmView.AllowUserToOrderColumns = true;
            this.filmView.AutoGenerateColumns = false;
            this.filmView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fMIDDataGridViewTextBoxColumn,
            this.fMTITLEDataGridViewTextBoxColumn,
            this.fMYEARDataGridViewTextBoxColumn,
            this.dGNAMEDataGridViewTextBoxColumn,
            this.fMLENGTHDataGridViewTextBoxColumn,
            this.fMIMDBRATEDataGridViewTextBoxColumn,
            this.fMKPRATEDataGridViewTextBoxColumn,
            this.fMANOTDataGridViewTextBoxColumn});
            this.filmView.DataSource = this.dTFilmsOfGenreBindingSource;
            this.filmView.Location = new System.Drawing.Point(9, 19);
            this.filmView.Name = "filmView";
            this.filmView.Size = new System.Drawing.Size(386, 254);
            this.filmView.TabIndex = 0;
            this.filmView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.filmView_CellMouseEnter);
            // 
            // topToolStrip
            // 
            this.topToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSaveTable,
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
            // gbFiltres
            // 
            this.gbFiltres.Controls.Add(this.tbDirectorName);
            this.gbFiltres.Controls.Add(this.directorLabel);
            this.gbFiltres.Controls.Add(this.tbActorName);
            this.gbFiltres.Controls.Add(this.actorLabel);
            this.gbFiltres.Controls.Add(this.tbFilmTitle);
            this.gbFiltres.Controls.Add(this.titleLabel);
            this.gbFiltres.Location = new System.Drawing.Point(12, 28);
            this.gbFiltres.Name = "gbFiltres";
            this.gbFiltres.Size = new System.Drawing.Size(604, 107);
            this.gbFiltres.TabIndex = 2;
            this.gbFiltres.TabStop = false;
            this.gbFiltres.Text = "Параметри пошуку";
            // 
            // tbDirectorName
            // 
            this.tbDirectorName.Location = new System.Drawing.Point(89, 75);
            this.tbDirectorName.Name = "tbDirectorName";
            this.tbDirectorName.Size = new System.Drawing.Size(509, 20);
            this.tbDirectorName.TabIndex = 5;
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
            // tbActorName
            // 
            this.tbActorName.Location = new System.Drawing.Point(89, 49);
            this.tbActorName.Name = "tbActorName";
            this.tbActorName.Size = new System.Drawing.Size(509, 20);
            this.tbActorName.TabIndex = 3;
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
            // tbFilmTitle
            // 
            this.tbFilmTitle.Location = new System.Drawing.Point(89, 23);
            this.tbFilmTitle.Name = "tbFilmTitle";
            this.tbFilmTitle.Size = new System.Drawing.Size(509, 20);
            this.tbFilmTitle.TabIndex = 1;
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
            // gbResultFilms
            // 
            this.gbResultFilms.Controls.Add(this.filmView);
            this.gbResultFilms.Location = new System.Drawing.Point(12, 141);
            this.gbResultFilms.Name = "gbResultFilms";
            this.gbResultFilms.Size = new System.Drawing.Size(401, 279);
            this.gbResultFilms.TabIndex = 3;
            this.gbResultFilms.TabStop = false;
            this.gbResultFilms.Text = "Фільми за жанром";
            // 
            // gbResultActors
            // 
            this.gbResultActors.Controls.Add(this.actorsView);
            this.gbResultActors.Location = new System.Drawing.Point(419, 141);
            this.gbResultActors.Name = "gbResultActors";
            this.gbResultActors.Size = new System.Drawing.Size(197, 279);
            this.gbResultActors.TabIndex = 4;
            this.gbResultActors.TabStop = false;
            this.gbResultActors.Text = "Актори фільму";
            // 
            // actorsView
            // 
            this.actorsView.AutoGenerateColumns = false;
            this.actorsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actorsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dCRIDDataGridViewTextBoxColumn,
            this.dCRNAMEDataGridViewTextBoxColumn});
            this.actorsView.DataSource = this.dTCharactersOfFilmBindingSource;
            this.actorsView.Location = new System.Drawing.Point(6, 89);
            this.actorsView.Name = "actorsView";
            this.actorsView.Size = new System.Drawing.Size(185, 184);
            this.actorsView.TabIndex = 0;
            // 
            // dCRIDDataGridViewTextBoxColumn
            // 
            this.dCRIDDataGridViewTextBoxColumn.DataPropertyName = "DCR_ID";
            this.dCRIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.dCRIDDataGridViewTextBoxColumn.Name = "dCRIDDataGridViewTextBoxColumn";
            this.dCRIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dCRIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dCRNAMEDataGridViewTextBoxColumn
            // 
            this.dCRNAMEDataGridViewTextBoxColumn.DataPropertyName = "DCR_NAME";
            this.dCRNAMEDataGridViewTextBoxColumn.HeaderText = "Актор";
            this.dCRNAMEDataGridViewTextBoxColumn.Name = "dCRNAMEDataGridViewTextBoxColumn";
            // 
            // dTCharactersOfFilmBindingSource
            // 
            this.dTCharactersOfFilmBindingSource.DataMember = "DTCharactersOfFilm";
            this.dTCharactersOfFilmBindingSource.DataSource = this.videoBaseDataSet;
            // 
            // videoBaseDataSet
            // 
            this.videoBaseDataSet.DataSetName = "VideoBaseDataSet";
            this.videoBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fMIDDataGridViewTextBoxColumn
            // 
            this.fMIDDataGridViewTextBoxColumn.DataPropertyName = "FM_ID";
            this.fMIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.fMIDDataGridViewTextBoxColumn.Name = "fMIDDataGridViewTextBoxColumn";
            this.fMIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.fMIDDataGridViewTextBoxColumn.Visible = false;
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
            // dGNAMEDataGridViewTextBoxColumn
            // 
            this.dGNAMEDataGridViewTextBoxColumn.DataPropertyName = "DG_NAME";
            this.dGNAMEDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.dGNAMEDataGridViewTextBoxColumn.Name = "dGNAMEDataGridViewTextBoxColumn";
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
            // dTFilmsOfGenreBindingSource
            // 
            this.dTFilmsOfGenreBindingSource.DataMember = "DTFilmsOfGenre";
            this.dTFilmsOfGenreBindingSource.DataSource = this.videoBaseDataSet;
            // 
            // dTFilmsOfGenreTableAdapter
            // 
            this.dTFilmsOfGenreTableAdapter.ClearBeforeFill = true;
            // 
            // dTCharactersOfFilmTableAdapter
            // 
            this.dTCharactersOfFilmTableAdapter.ClearBeforeFill = true;
            // 
            // FilmsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 432);
            this.Controls.Add(this.gbResultActors);
            this.Controls.Add(this.gbResultFilms);
            this.Controls.Add(this.gbFiltres);
            this.Controls.Add(this.topToolStrip);
            this.Name = "FilmsView";
            this.Text = "Фільми за жанром";
            ((System.ComponentModel.ISupportInitialize)(this.filmView)).EndInit();
            this.topToolStrip.ResumeLayout(false);
            this.topToolStrip.PerformLayout();
            this.gbFiltres.ResumeLayout(false);
            this.gbFiltres.PerformLayout();
            this.gbResultFilms.ResumeLayout(false);
            this.gbResultActors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.actorsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTCharactersOfFilmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTFilmsOfGenreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView filmView;
        private System.Windows.Forms.ToolStrip topToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripSaveTable;
        private System.Windows.Forms.ToolStripButton toolStripSearch;
        private System.Windows.Forms.GroupBox gbFiltres;
        private System.Windows.Forms.TextBox tbFilmTitle;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox tbActorName;
        private System.Windows.Forms.Label actorLabel;
        private System.Windows.Forms.GroupBox gbResultFilms;
        private System.Windows.Forms.GroupBox gbResultActors;
        private System.Windows.Forms.DataGridView actorsView;
        private System.Windows.Forms.TextBox tbDirectorName;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMTITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMLENGTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMIMDBRATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMKPRATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMANOTDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dTFilmsOfGenreBindingSource;
        private VideoBaseDataSet videoBaseDataSet;
        private VideoBaseDataSetTableAdapters.DTFilmsOfGenreTableAdapter dTFilmsOfGenreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCRNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dTCharactersOfFilmBindingSource;
        private VideoBaseDataSetTableAdapters.DTCharactersOfFilmTableAdapter dTCharactersOfFilmTableAdapter;
    }
}