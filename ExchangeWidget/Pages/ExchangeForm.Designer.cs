namespace ExchangeWidget.Pages
{
    partial class ExchangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExchangeForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.CurrencyList = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CurrencyDataGridView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NominalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CursColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FavouritesList = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.AddFavouriteButton = new System.Windows.Forms.ToolStripButton();
            this.MainPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.CurrencyList.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.CurrencyList);
            this.MainPanel.Controls.Add(this.toolStrip1);
            this.MainPanel.Controls.Add(this.statusStrip1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(818, 450);
            this.MainPanel.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(818, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(108, 17);
            this.toolStripStatusLabel1.Text = "Здесь будет статус";
            // 
            // CurrencyList
            // 
            this.CurrencyList.Controls.Add(this.tabPage1);
            this.CurrencyList.Controls.Add(this.FavouritesList);
            this.CurrencyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrencyList.Location = new System.Drawing.Point(0, 25);
            this.CurrencyList.Name = "CurrencyList";
            this.CurrencyList.SelectedIndex = 0;
            this.CurrencyList.Size = new System.Drawing.Size(818, 403);
            this.CurrencyList.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CurrencyDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(810, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Курсы валют";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CurrencyDataGridView
            // 
            this.CurrencyDataGridView.AllowUserToAddRows = false;
            this.CurrencyDataGridView.AllowUserToDeleteRows = false;
            this.CurrencyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurrencyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.NominalColumn,
            this.CursColumn,
            this.CodeColumn,
            this.CharCodeColumn});
            this.CurrencyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrencyDataGridView.Location = new System.Drawing.Point(3, 3);
            this.CurrencyDataGridView.MultiSelect = false;
            this.CurrencyDataGridView.Name = "CurrencyDataGridView";
            this.CurrencyDataGridView.ReadOnly = true;
            this.CurrencyDataGridView.RowTemplate.Height = 25;
            this.CurrencyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CurrencyDataGridView.Size = new System.Drawing.Size(804, 369);
            this.CurrencyDataGridView.TabIndex = 0;
            this.CurrencyDataGridView.SelectionChanged += new System.EventHandler(this.CurrencyDataGridView_SelectionChanged);
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Название валюты";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 200;
            // 
            // NominalColumn
            // 
            this.NominalColumn.DataPropertyName = "Nominal";
            this.NominalColumn.HeaderText = "Номинал";
            this.NominalColumn.Name = "NominalColumn";
            this.NominalColumn.ReadOnly = true;
            // 
            // CursColumn
            // 
            this.CursColumn.DataPropertyName = "Curs";
            this.CursColumn.HeaderText = "Курс";
            this.CursColumn.Name = "CursColumn";
            this.CursColumn.ReadOnly = true;
            // 
            // CodeColumn
            // 
            this.CodeColumn.DataPropertyName = "Code";
            this.CodeColumn.HeaderText = "Цифровой код валюты";
            this.CodeColumn.Name = "CodeColumn";
            this.CodeColumn.ReadOnly = true;
            this.CodeColumn.Width = 180;
            // 
            // CharCodeColumn
            // 
            this.CharCodeColumn.DataPropertyName = "CharCode";
            this.CharCodeColumn.HeaderText = "Символьный код валюты";
            this.CharCodeColumn.Name = "CharCodeColumn";
            this.CharCodeColumn.ReadOnly = true;
            this.CharCodeColumn.Width = 180;
            // 
            // FavouritesList
            // 
            this.FavouritesList.Location = new System.Drawing.Point(4, 24);
            this.FavouritesList.Name = "FavouritesList";
            this.FavouritesList.Padding = new System.Windows.Forms.Padding(3);
            this.FavouritesList.Size = new System.Drawing.Size(810, 375);
            this.FavouritesList.TabIndex = 1;
            this.FavouritesList.Text = "Избранное";
            this.FavouritesList.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshButton,
            this.AddFavouriteButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(818, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(81, 22);
            this.RefreshButton.Text = "Обновить";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // AddFavouriteButton
            // 
            this.AddFavouriteButton.Enabled = false;
            this.AddFavouriteButton.Image = ((System.Drawing.Image)(resources.GetObject("AddFavouriteButton.Image")));
            this.AddFavouriteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddFavouriteButton.Name = "AddFavouriteButton";
            this.AddFavouriteButton.Size = new System.Drawing.Size(150, 22);
            this.AddFavouriteButton.Text = "Добавить в избранное";
            // 
            // ExchangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.MainPanel);
            this.Name = "ExchangeForm";
            this.Text = "ExchangeForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.CurrencyList.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton RefreshButton;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TabControl CurrencyList;
        private TabPage tabPage1;
        private TabPage FavouritesList;
        private ToolStripButton AddFavouriteButton;
        public Panel MainPanel;
        private DataGridView CurrencyDataGridView;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn NominalColumn;
        private DataGridViewTextBoxColumn CursColumn;
        private DataGridViewTextBoxColumn CodeColumn;
        private DataGridViewTextBoxColumn CharCodeColumn;
    }
}