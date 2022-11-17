namespace StockForms.Forms
{
    partial class PortfolioForm
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
            System.Windows.Forms.TableLayoutPanel _buttonTableLayoutPanel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label _purchaseValueLabel;
            this._exitButton = new System.Windows.Forms.Button();
            this._sellButton = new System.Windows.Forms.Button();
            this._buyButton = new System.Windows.Forms.Button();
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portfolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._portfolioDataGridView = new System.Windows.Forms.DataGridView();
            this.portfolioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewPortfolio = new StockForms.ViewPortfolio();
            this.portfolioTableAdapter = new StockForms.ViewPortfolioTableAdapters.portfolioTableAdapter();
            this._purchaseValueTextBox = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_ticker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityownedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dollarcostaverageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            _buttonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            _purchaseValueLabel = new System.Windows.Forms.Label();
            _buttonTableLayoutPanel.SuspendLayout();
            this._menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._portfolioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portfolioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPortfolio)).BeginInit();
            this.SuspendLayout();
            // 
            // _buttonTableLayoutPanel
            // 
            _buttonTableLayoutPanel.ColumnCount = 3;
            _buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            _buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            _buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            _buttonTableLayoutPanel.Controls.Add(this._exitButton, 2, 0);
            _buttonTableLayoutPanel.Controls.Add(this._sellButton, 1, 0);
            _buttonTableLayoutPanel.Controls.Add(this._buyButton, 0, 0);
            _buttonTableLayoutPanel.Location = new System.Drawing.Point(13, 390);
            _buttonTableLayoutPanel.Name = "_buttonTableLayoutPanel";
            _buttonTableLayoutPanel.RowCount = 1;
            _buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            _buttonTableLayoutPanel.Size = new System.Drawing.Size(775, 48);
            _buttonTableLayoutPanel.TabIndex = 13;
            // 
            // _exitButton
            // 
            this._exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._exitButton.Location = new System.Drawing.Point(519, 3);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(252, 42);
            this._exitButton.TabIndex = 2;
            this._exitButton.Text = "EXIT";
            this._exitButton.UseVisualStyleBackColor = true;
            this._exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // _sellButton
            // 
            this._sellButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sellButton.Location = new System.Drawing.Point(261, 3);
            this._sellButton.Name = "_sellButton";
            this._sellButton.Size = new System.Drawing.Size(252, 42);
            this._sellButton.TabIndex = 1;
            this._sellButton.Text = "SELL";
            this._sellButton.UseVisualStyleBackColor = true;
            this._sellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // _buyButton
            // 
            this._buyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buyButton.Location = new System.Drawing.Point(3, 3);
            this._buyButton.Name = "_buyButton";
            this._buyButton.Size = new System.Drawing.Size(252, 42);
            this._buyButton.TabIndex = 0;
            this._buyButton.Text = "BUY";
            this._buyButton.UseVisualStyleBackColor = true;
            this._buyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // _menuStrip
            // 
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tradeToolStripMenuItem});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(800, 24);
            this._menuStrip.TabIndex = 11;
            this._menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // tradeToolStripMenuItem
            // 
            this.tradeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.quoteToolStripMenuItem,
            this.buyToolStripMenuItem,
            this.sellToolStripMenuItem,
            this.portfolioToolStripMenuItem});
            this.tradeToolStripMenuItem.Name = "tradeToolStripMenuItem";
            this.tradeToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.tradeToolStripMenuItem.Text = "Trade";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.SearchToolStripMenuItem_Click);
            // 
            // quoteToolStripMenuItem
            // 
            this.quoteToolStripMenuItem.Name = "quoteToolStripMenuItem";
            this.quoteToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.quoteToolStripMenuItem.Text = "Quote";
            this.quoteToolStripMenuItem.Click += new System.EventHandler(this.QuoteToolStripMenuItem_Click);
            // 
            // buyToolStripMenuItem
            // 
            this.buyToolStripMenuItem.Name = "buyToolStripMenuItem";
            this.buyToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.buyToolStripMenuItem.Text = "Buy";
            this.buyToolStripMenuItem.Click += new System.EventHandler(this.BuyToolStripMenuItem_Click);
            // 
            // sellToolStripMenuItem
            // 
            this.sellToolStripMenuItem.Name = "sellToolStripMenuItem";
            this.sellToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.sellToolStripMenuItem.Text = "Sell";
            this.sellToolStripMenuItem.Click += new System.EventHandler(this.SellToolStripMenuItem_Click);
            // 
            // portfolioToolStripMenuItem
            // 
            this.portfolioToolStripMenuItem.Name = "portfolioToolStripMenuItem";
            this.portfolioToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.portfolioToolStripMenuItem.Text = "Portfolio";
            this.portfolioToolStripMenuItem.Click += new System.EventHandler(this.PortfolioToolStripMenuItem_Click);
            // 
            // _portfolioDataGridView
            // 
            this._portfolioDataGridView.AllowUserToAddRows = false;
            this._portfolioDataGridView.AllowUserToDeleteRows = false;
            this._portfolioDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._portfolioDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._portfolioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._portfolioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.stock_ticker,
            this.stock_name,
            this.quantityownedDataGridViewTextBoxColumn,
            this.dollarcostaverageDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this._portfolioDataGridView.DataSource = this.portfolioBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._portfolioDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this._portfolioDataGridView.Location = new System.Drawing.Point(145, 27);
            this._portfolioDataGridView.Name = "_portfolioDataGridView";
            this._portfolioDataGridView.ReadOnly = true;
            this._portfolioDataGridView.Size = new System.Drawing.Size(643, 357);
            this._portfolioDataGridView.TabIndex = 12;
            this._portfolioDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.PortfolioDataGridView_CellEnter);
            // 
            // portfolioBindingSource
            // 
            this.portfolioBindingSource.DataMember = "portfolio";
            this.portfolioBindingSource.DataSource = this.viewPortfolio;
            // 
            // viewPortfolio
            // 
            this.viewPortfolio.DataSetName = "ViewPortfolio";
            this.viewPortfolio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // portfolioTableAdapter
            // 
            this.portfolioTableAdapter.ClearBeforeFill = true;
            // 
            // _purchaseValueLabel
            // 
            _purchaseValueLabel.AutoSize = true;
            _purchaseValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _purchaseValueLabel.Location = new System.Drawing.Point(13, 36);
            _purchaseValueLabel.Name = "_purchaseValueLabel";
            _purchaseValueLabel.Size = new System.Drawing.Size(116, 16);
            _purchaseValueLabel.TabIndex = 14;
            _purchaseValueLabel.Text = "Purchase Value";
            // 
            // _purchaseValueTextBox
            // 
            this._purchaseValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._purchaseValueTextBox.Location = new System.Drawing.Point(8, 56);
            this._purchaseValueTextBox.Name = "_purchaseValueTextBox";
            this._purchaseValueTextBox.ReadOnly = true;
            this._purchaseValueTextBox.Size = new System.Drawing.Size(127, 22);
            this._purchaseValueTextBox.TabIndex = 15;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // stock_ticker
            // 
            this.stock_ticker.DataPropertyName = "stock_ticker";
            this.stock_ticker.HeaderText = "Ticker";
            this.stock_ticker.Name = "stock_ticker";
            this.stock_ticker.ReadOnly = true;
            this.stock_ticker.Width = 75;
            // 
            // stock_name
            // 
            this.stock_name.DataPropertyName = "stock_name";
            this.stock_name.HeaderText = "Name";
            this.stock_name.Name = "stock_name";
            this.stock_name.ReadOnly = true;
            this.stock_name.Width = 300;
            // 
            // quantityownedDataGridViewTextBoxColumn
            // 
            this.quantityownedDataGridViewTextBoxColumn.DataPropertyName = "quantity_owned";
            this.quantityownedDataGridViewTextBoxColumn.HeaderText = "Quantity Owned";
            this.quantityownedDataGridViewTextBoxColumn.Name = "quantityownedDataGridViewTextBoxColumn";
            this.quantityownedDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityownedDataGridViewTextBoxColumn.Width = 75;
            // 
            // dollarcostaverageDataGridViewTextBoxColumn
            // 
            this.dollarcostaverageDataGridViewTextBoxColumn.DataPropertyName = "dollar_cost_average";
            this.dollarcostaverageDataGridViewTextBoxColumn.HeaderText = "Dollar Cost Average";
            this.dollarcostaverageDataGridViewTextBoxColumn.Name = "dollarcostaverageDataGridViewTextBoxColumn";
            this.dollarcostaverageDataGridViewTextBoxColumn.ReadOnly = true;
            this.dollarcostaverageDataGridViewTextBoxColumn.Width = 75;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total Value";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 75;
            // 
            // PortfolioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._purchaseValueTextBox);
            this.Controls.Add(_purchaseValueLabel);
            this.Controls.Add(_buttonTableLayoutPanel);
            this.Controls.Add(this._portfolioDataGridView);
            this.Controls.Add(this._menuStrip);
            this.Name = "PortfolioForm";
            this.Text = "View Portfolio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PortfolioForm_FormClosing);
            this.Load += new System.EventHandler(this.PortfolioForm_Load);
            _buttonTableLayoutPanel.ResumeLayout(false);
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._portfolioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portfolioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPortfolio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portfolioToolStripMenuItem;
        private System.Windows.Forms.DataGridView _portfolioDataGridView;
        private System.Windows.Forms.Button _exitButton;
        private System.Windows.Forms.Button _sellButton;
        private System.Windows.Forms.Button _buyButton;
        private ViewPortfolio viewPortfolio;
        private System.Windows.Forms.BindingSource portfolioBindingSource;
        private ViewPortfolioTableAdapters.portfolioTableAdapter portfolioTableAdapter;
        private System.Windows.Forms.TextBox _purchaseValueTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_ticker;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityownedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dollarcostaverageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}