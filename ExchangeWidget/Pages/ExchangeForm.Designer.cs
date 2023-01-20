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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.CurrencyList = new System.Windows.Forms.TabControl();
            this.CursPage = new System.Windows.Forms.TabPage();
            this.CurrencyDataGridView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NominalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CursColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FavoritesPage = new System.Windows.Forms.TabPage();
            this.FavoritesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.AddFavoriteButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteFavoriteButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.FakePanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.CurrencyList.SuspendLayout();
            this.CursPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyDataGridView)).BeginInit();
            this.FavoritesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FavoritesDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.CurrencyList);
            this.MainPanel.Controls.Add(this.toolStrip1);
            this.MainPanel.Controls.Add(this.statusStrip1);
            this.MainPanel.Controls.Add(this.FakePanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(818, 450);
            this.MainPanel.TabIndex = 0;
            // 
            // CurrencyList
            // 
            this.CurrencyList.Controls.Add(this.CursPage);
            this.CurrencyList.Controls.Add(this.FavoritesPage);
            this.CurrencyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrencyList.Location = new System.Drawing.Point(0, 49);
            this.CurrencyList.Name = "CurrencyList";
            this.CurrencyList.SelectedIndex = 0;
            this.CurrencyList.Size = new System.Drawing.Size(818, 379);
            this.CurrencyList.TabIndex = 0;
            this.CurrencyList.Selected += new System.Windows.Forms.TabControlEventHandler(this.CurrencyList_Selected);
            // 
            // CursPage
            // 
            this.CursPage.Controls.Add(this.CurrencyDataGridView);
            this.CursPage.Location = new System.Drawing.Point(4, 24);
            this.CursPage.Name = "CursPage";
            this.CursPage.Padding = new System.Windows.Forms.Padding(3);
            this.CursPage.Size = new System.Drawing.Size(810, 351);
            this.CursPage.TabIndex = 0;
            this.CursPage.Text = "Курсы валют";
            this.CursPage.UseVisualStyleBackColor = true;
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
            this.CurrencyDataGridView.Size = new System.Drawing.Size(804, 345);
            this.CurrencyDataGridView.TabIndex = 0;
            this.CurrencyDataGridView.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
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
            // FavoritesPage
            // 
            this.FavoritesPage.Controls.Add(this.FavoritesDataGridView);
            this.FavoritesPage.Location = new System.Drawing.Point(4, 24);
            this.FavoritesPage.Name = "FavoritesPage";
            this.FavoritesPage.Padding = new System.Windows.Forms.Padding(3);
            this.FavoritesPage.Size = new System.Drawing.Size(810, 351);
            this.FavoritesPage.TabIndex = 1;
            this.FavoritesPage.Text = "Избранное";
            this.FavoritesPage.UseVisualStyleBackColor = true;
            // 
            // FavoritesDataGridView
            // 
            this.FavoritesDataGridView.AllowUserToAddRows = false;
            this.FavoritesDataGridView.AllowUserToDeleteRows = false;
            this.FavoritesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FavoritesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.FavoritesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FavoritesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.FavoritesDataGridView.MultiSelect = false;
            this.FavoritesDataGridView.Name = "FavoritesDataGridView";
            this.FavoritesDataGridView.ReadOnly = true;
            this.FavoritesDataGridView.RowTemplate.Height = 25;
            this.FavoritesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FavoritesDataGridView.Size = new System.Drawing.Size(804, 345);
            this.FavoritesDataGridView.TabIndex = 1;
            this.FavoritesDataGridView.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Название валюты";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nominal";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номинал";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Curs";
            this.dataGridViewTextBoxColumn3.HeaderText = "Курс";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn4.HeaderText = "Цифровой код валюты";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 180;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CharCode";
            this.dataGridViewTextBoxColumn5.HeaderText = "Символьный код валюты";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 180;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshButton,
            this.AddFavoriteButton,
            this.DeleteFavoriteButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(818, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Image = global::ExchangeWidget.Properties.Resources.refresh;
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(81, 22);
            this.RefreshButton.Text = "Обновить";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // AddFavoriteButton
            // 
            this.AddFavoriteButton.Enabled = false;
            this.AddFavoriteButton.Image = global::ExchangeWidget.Properties.Resources.add;
            this.AddFavoriteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddFavoriteButton.Name = "AddFavoriteButton";
            this.AddFavoriteButton.Size = new System.Drawing.Size(150, 22);
            this.AddFavoriteButton.Text = "Добавить в избранное";
            this.AddFavoriteButton.Click += new System.EventHandler(this.AddFavoriteButton_Click);
            // 
            // DeleteFavoriteButton
            // 
            this.DeleteFavoriteButton.Image = global::ExchangeWidget.Properties.Resources.remove;
            this.DeleteFavoriteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteFavoriteButton.Name = "DeleteFavoriteButton";
            this.DeleteFavoriteButton.Size = new System.Drawing.Size(154, 22);
            this.DeleteFavoriteButton.Text = "Удалить из избранного";
            this.DeleteFavoriteButton.Click += new System.EventHandler(this.DeleteFavoriteButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(818, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(108, 17);
            this.StatusLabel.Text = "Здесь будет статус";
            // 
            // FakePanel
            // 
            this.FakePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FakePanel.Location = new System.Drawing.Point(0, 0);
            this.FakePanel.Name = "FakePanel";
            this.FakePanel.Size = new System.Drawing.Size(818, 24);
            this.FakePanel.TabIndex = 4;
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
            this.CurrencyList.ResumeLayout(false);
            this.CursPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyDataGridView)).EndInit();
            this.FavoritesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FavoritesDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton RefreshButton;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusLabel;
        private TabControl CurrencyList;
        private TabPage CursPage;
        private TabPage FavoritesPage;
        private ToolStripButton AddFavoriteButton;
        public Panel MainPanel;
        private DataGridView CurrencyDataGridView;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn NominalColumn;
        private DataGridViewTextBoxColumn CursColumn;
        private DataGridViewTextBoxColumn CodeColumn;
        private DataGridViewTextBoxColumn CharCodeColumn;
        private DataGridView FavoritesDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Panel FakePanel;
        private ToolStripButton DeleteFavoriteButton;
    }
}