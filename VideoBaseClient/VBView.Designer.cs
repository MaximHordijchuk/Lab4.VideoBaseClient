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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VBView));
            this.topToolStrip = new System.Windows.Forms.ToolStrip();
            this.tablesTabs = new System.Windows.Forms.TabControl();
            this.filmsTab = new System.Windows.Forms.TabPage();
            this.genresTab = new System.Windows.Forms.TabPage();
            this.actorsTab = new System.Windows.Forms.TabPage();
            this.directorsTab = new System.Windows.Forms.TabPage();
            this.countriesTab = new System.Windows.Forms.TabPage();
            this.toolsSaveButton = new System.Windows.Forms.ToolStripButton();
            this.filmsView = new System.Windows.Forms.DataGridView();
            this.genresView = new System.Windows.Forms.DataGridView();
            this.actorsView = new System.Windows.Forms.DataGridView();
            this.directorsView = new System.Windows.Forms.DataGridView();
            this.countriesView = new System.Windows.Forms.DataGridView();
            this.topToolStrip.SuspendLayout();
            this.tablesTabs.SuspendLayout();
            this.filmsTab.SuspendLayout();
            this.genresTab.SuspendLayout();
            this.actorsTab.SuspendLayout();
            this.directorsTab.SuspendLayout();
            this.countriesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesView)).BeginInit();
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
            // toolsSaveButton
            // 
            this.toolsSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolsSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("toolsSaveButton.Image")));
            this.toolsSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsSaveButton.Name = "toolsSaveButton";
            this.toolsSaveButton.Size = new System.Drawing.Size(23, 22);
            this.toolsSaveButton.Text = "toolStripButton1";
            // 
            // filmsView
            // 
            this.filmsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmsView.Location = new System.Drawing.Point(3, 3);
            this.filmsView.Name = "filmsView";
            this.filmsView.Size = new System.Drawing.Size(622, 261);
            this.filmsView.TabIndex = 0;
            // 
            // genresView
            // 
            this.genresView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genresView.Location = new System.Drawing.Point(3, 3);
            this.genresView.Name = "genresView";
            this.genresView.Size = new System.Drawing.Size(622, 261);
            this.genresView.TabIndex = 0;
            // 
            // actorsView
            // 
            this.actorsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actorsView.Location = new System.Drawing.Point(3, 3);
            this.actorsView.Name = "actorsView";
            this.actorsView.Size = new System.Drawing.Size(622, 261);
            this.actorsView.TabIndex = 0;
            // 
            // directorsView
            // 
            this.directorsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directorsView.Location = new System.Drawing.Point(3, 3);
            this.directorsView.Name = "directorsView";
            this.directorsView.Size = new System.Drawing.Size(622, 261);
            this.directorsView.TabIndex = 0;
            // 
            // countriesView
            // 
            this.countriesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countriesView.Location = new System.Drawing.Point(3, 3);
            this.countriesView.Name = "countriesView";
            this.countriesView.Size = new System.Drawing.Size(622, 261);
            this.countriesView.TabIndex = 0;
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
            this.topToolStrip.ResumeLayout(false);
            this.topToolStrip.PerformLayout();
            this.tablesTabs.ResumeLayout(false);
            this.filmsTab.ResumeLayout(false);
            this.genresTab.ResumeLayout(false);
            this.actorsTab.ResumeLayout(false);
            this.directorsTab.ResumeLayout(false);
            this.countriesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filmsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip topToolStrip;
        private System.Windows.Forms.ToolStripButton toolsSaveButton;
        private System.Windows.Forms.TabControl tablesTabs;
        private System.Windows.Forms.TabPage filmsTab;
        private System.Windows.Forms.DataGridView filmsView;
        private System.Windows.Forms.TabPage genresTab;
        private System.Windows.Forms.DataGridView genresView;
        private System.Windows.Forms.TabPage actorsTab;
        private System.Windows.Forms.DataGridView actorsView;
        private System.Windows.Forms.TabPage directorsTab;
        private System.Windows.Forms.DataGridView directorsView;
        private System.Windows.Forms.TabPage countriesTab;
        private System.Windows.Forms.DataGridView countriesView;
    }
}

