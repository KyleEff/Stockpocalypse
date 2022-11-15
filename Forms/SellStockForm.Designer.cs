namespace StockForms.Forms
{
    partial class SellStockForm
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
            System.Windows.Forms.GroupBox _orderResultGroupBox;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.GroupBox OrderInfoGroupBox;
            System.Windows.Forms.Label _profitLabel;
            System.Windows.Forms.Label _enterQuantityLabel;
            System.Windows.Forms.Label QuantityLabel;
            System.Windows.Forms.Label _totalCostLabel;
            System.Windows.Forms.Label PriceLabel;
            System.Windows.Forms.Label NameLabel;
            System.Windows.Forms.Label SymbolLabel;
            System.Windows.Forms.GroupBox _porfolioResultGroupBox;
            this.OrderResultsTextBox = new System.Windows.Forms.TextBox();
            this._depositCashButton = new System.Windows.Forms.Button();
            this.CashTextBox = new System.Windows.Forms.TextBox();
            this._profitTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SymbolTextBox = new System.Windows.Forms.TextBox();
            this._portfolioDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocktickerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityownedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dollarcostaverageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portfolioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewPortfolio = new StockForms.ViewPortfolio();
            this.SellButton = new System.Windows.Forms.Button();
            this._priceButton = new System.Windows.Forms.Button();
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
            this.portfolioTableAdapter = new StockForms.ViewPortfolioTableAdapters.portfolioTableAdapter();
            _orderResultGroupBox = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            OrderInfoGroupBox = new System.Windows.Forms.GroupBox();
            _profitLabel = new System.Windows.Forms.Label();
            _enterQuantityLabel = new System.Windows.Forms.Label();
            QuantityLabel = new System.Windows.Forms.Label();
            _totalCostLabel = new System.Windows.Forms.Label();
            PriceLabel = new System.Windows.Forms.Label();
            NameLabel = new System.Windows.Forms.Label();
            SymbolLabel = new System.Windows.Forms.Label();
            _porfolioResultGroupBox = new System.Windows.Forms.GroupBox();
            _orderResultGroupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            OrderInfoGroupBox.SuspendLayout();
            _porfolioResultGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._portfolioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portfolioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPortfolio)).BeginInit();
            this._menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _orderResultGroupBox
            // 
            _orderResultGroupBox.Controls.Add(this.OrderResultsTextBox);
            _orderResultGroupBox.Location = new System.Drawing.Point(12, 179);
            _orderResultGroupBox.Name = "_orderResultGroupBox";
            _orderResultGroupBox.Size = new System.Drawing.Size(176, 234);
            _orderResultGroupBox.TabIndex = 20;
            _orderResultGroupBox.TabStop = false;
            _orderResultGroupBox.Text = "Order Results";
            // 
            // OrderResultsTextBox
            // 
            this.OrderResultsTextBox.Location = new System.Drawing.Point(6, 19);
            this.OrderResultsTextBox.Multiline = true;
            this.OrderResultsTextBox.Name = "OrderResultsTextBox";
            this.OrderResultsTextBox.Size = new System.Drawing.Size(164, 200);
            this.OrderResultsTextBox.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this._depositCashButton);
            groupBox2.Controls.Add(this.CashTextBox);
            groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox2.Location = new System.Drawing.Point(606, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(200, 77);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cash Available For Trade";
            // 
            // _depositCashButton
            // 
            this._depositCashButton.Location = new System.Drawing.Point(23, 48);
            this._depositCashButton.Name = "_depositCashButton";
            this._depositCashButton.Size = new System.Drawing.Size(155, 23);
            this._depositCashButton.TabIndex = 7;
            this._depositCashButton.Text = "Deposit Cash";
            this._depositCashButton.UseVisualStyleBackColor = true;
            // 
            // CashTextBox
            // 
            this.CashTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CashTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashTextBox.Location = new System.Drawing.Point(6, 21);
            this.CashTextBox.Name = "CashTextBox";
            this.CashTextBox.ReadOnly = true;
            this.CashTextBox.Size = new System.Drawing.Size(188, 26);
            this.CashTextBox.TabIndex = 10;
            this.CashTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OrderInfoGroupBox
            // 
            OrderInfoGroupBox.Controls.Add(this._profitTextBox);
            OrderInfoGroupBox.Controls.Add(_profitLabel);
            OrderInfoGroupBox.Controls.Add(_enterQuantityLabel);
            OrderInfoGroupBox.Controls.Add(this.QuantityTextBox);
            OrderInfoGroupBox.Controls.Add(this.TotalTextBox);
            OrderInfoGroupBox.Controls.Add(QuantityLabel);
            OrderInfoGroupBox.Controls.Add(this.PriceTextBox);
            OrderInfoGroupBox.Controls.Add(_totalCostLabel);
            OrderInfoGroupBox.Controls.Add(PriceLabel);
            OrderInfoGroupBox.Controls.Add(this.NameTextBox);
            OrderInfoGroupBox.Controls.Add(NameLabel);
            OrderInfoGroupBox.Controls.Add(this.SymbolTextBox);
            OrderInfoGroupBox.Controls.Add(SymbolLabel);
            OrderInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            OrderInfoGroupBox.Location = new System.Drawing.Point(12, 27);
            OrderInfoGroupBox.Name = "OrderInfoGroupBox";
            OrderInfoGroupBox.Size = new System.Drawing.Size(542, 146);
            OrderInfoGroupBox.TabIndex = 17;
            OrderInfoGroupBox.TabStop = false;
            OrderInfoGroupBox.Text = "Order Information";
            // 
            // _profitTextBox
            // 
            this._profitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._profitTextBox.Location = new System.Drawing.Point(399, 106);
            this._profitTextBox.Name = "_profitTextBox";
            this._profitTextBox.ReadOnly = true;
            this._profitTextBox.Size = new System.Drawing.Size(100, 22);
            this._profitTextBox.TabIndex = 12;
            this._profitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _profitLabel
            // 
            _profitLabel.AutoSize = true;
            _profitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _profitLabel.Location = new System.Drawing.Point(408, 87);
            _profitLabel.Name = "_profitLabel";
            _profitLabel.Size = new System.Drawing.Size(83, 16);
            _profitLabel.TabIndex = 11;
            _profitLabel.Text = "Total Profit";
            // 
            // _enterQuantityLabel
            // 
            _enterQuantityLabel.AutoSize = true;
            _enterQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _enterQuantityLabel.ForeColor = System.Drawing.Color.Red;
            _enterQuantityLabel.Location = new System.Drawing.Point(176, 109);
            _enterQuantityLabel.Name = "_enterQuantityLabel";
            _enterQuantityLabel.Size = new System.Drawing.Size(140, 16);
            _enterQuantityLabel.TabIndex = 10;
            _enterQuantityLabel.Text = "ENTER QUANTITY";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(70, 106);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(100, 22);
            this.QuantityTextBox.TabIndex = 7;
            this.QuantityTextBox.TextChanged += new System.EventHandler(this.QuantityTextBox_TextChanged);
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextBox.Location = new System.Drawing.Point(399, 37);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 22);
            this.TotalTextBox.TabIndex = 9;
            this.TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Location = new System.Drawing.Point(6, 109);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new System.Drawing.Size(58, 16);
            QuantityLabel.TabIndex = 6;
            QuantityLabel.Text = "Quantity:";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(70, 78);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.PriceTextBox.TabIndex = 5;
            // 
            // _totalCostLabel
            // 
            _totalCostLabel.AutoSize = true;
            _totalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _totalCostLabel.Location = new System.Drawing.Point(410, 18);
            _totalCostLabel.Name = "_totalCostLabel";
            _totalCostLabel.Size = new System.Drawing.Size(79, 16);
            _totalCostLabel.TabIndex = 8;
            _totalCostLabel.Text = "Total Sale";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new System.Drawing.Point(23, 81);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new System.Drawing.Size(41, 16);
            PriceLabel.TabIndex = 4;
            PriceLabel.Text = "Price:";
            PriceLabel.Click += new System.EventHandler(this.PriceLabel_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(70, 50);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(252, 22);
            this.NameTextBox.TabIndex = 3;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new System.Drawing.Point(17, 53);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new System.Drawing.Size(47, 16);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name:";
            // 
            // SymbolTextBox
            // 
            this.SymbolTextBox.Location = new System.Drawing.Point(70, 22);
            this.SymbolTextBox.Name = "SymbolTextBox";
            this.SymbolTextBox.Size = new System.Drawing.Size(100, 22);
            this.SymbolTextBox.TabIndex = 1;
            // 
            // SymbolLabel
            // 
            SymbolLabel.AutoSize = true;
            SymbolLabel.Location = new System.Drawing.Point(8, 25);
            SymbolLabel.Name = "SymbolLabel";
            SymbolLabel.Size = new System.Drawing.Size(56, 16);
            SymbolLabel.TabIndex = 0;
            SymbolLabel.Text = "Symbol:";
            // 
            // _porfolioResultGroupBox
            // 
            _porfolioResultGroupBox.Controls.Add(this._portfolioDataGridView);
            _porfolioResultGroupBox.Location = new System.Drawing.Point(191, 179);
            _porfolioResultGroupBox.Name = "_porfolioResultGroupBox";
            _porfolioResultGroupBox.Size = new System.Drawing.Size(647, 358);
            _porfolioResultGroupBox.TabIndex = 21;
            _porfolioResultGroupBox.TabStop = false;
            _porfolioResultGroupBox.Text = "Portfolio Results";
            // 
            // _portfolioDataGridView
            // 
            this._portfolioDataGridView.AllowUserToAddRows = false;
            this._portfolioDataGridView.AllowUserToDeleteRows = false;
            this._portfolioDataGridView.AutoGenerateColumns = false;
            this._portfolioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._portfolioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.stocktickerDataGridViewTextBoxColumn,
            this.stocknameDataGridViewTextBoxColumn,
            this.quantityownedDataGridViewTextBoxColumn,
            this.dollarcostaverageDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this._portfolioDataGridView.DataSource = this.portfolioBindingSource;
            this._portfolioDataGridView.Location = new System.Drawing.Point(6, 19);
            this._portfolioDataGridView.Name = "_portfolioDataGridView";
            this._portfolioDataGridView.ReadOnly = true;
            this._portfolioDataGridView.Size = new System.Drawing.Size(637, 331);
            this._portfolioDataGridView.TabIndex = 0;
            this._portfolioDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.PortfolioDataGridView_CellEnter);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // stocktickerDataGridViewTextBoxColumn
            // 
            this.stocktickerDataGridViewTextBoxColumn.DataPropertyName = "stock_ticker";
            this.stocktickerDataGridViewTextBoxColumn.HeaderText = "Ticker";
            this.stocktickerDataGridViewTextBoxColumn.Name = "stocktickerDataGridViewTextBoxColumn";
            this.stocktickerDataGridViewTextBoxColumn.ReadOnly = true;
            this.stocktickerDataGridViewTextBoxColumn.Width = 75;
            // 
            // stocknameDataGridViewTextBoxColumn
            // 
            this.stocknameDataGridViewTextBoxColumn.DataPropertyName = "stock_name";
            this.stocknameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.stocknameDataGridViewTextBoxColumn.Name = "stocknameDataGridViewTextBoxColumn";
            this.stocknameDataGridViewTextBoxColumn.ReadOnly = true;
            this.stocknameDataGridViewTextBoxColumn.Width = 300;
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
            // SellButton
            // 
            this.SellButton.Location = new System.Drawing.Point(12, 419);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(173, 54);
            this.SellButton.TabIndex = 16;
            this.SellButton.Text = "SELL";
            this.SellButton.UseVisualStyleBackColor = true;
            this.SellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // _priceButton
            // 
            this._priceButton.Location = new System.Drawing.Point(12, 479);
            this._priceButton.Name = "_priceButton";
            this._priceButton.Size = new System.Drawing.Size(173, 54);
            this._priceButton.TabIndex = 22;
            this._priceButton.Text = "GET PRICE";
            this._priceButton.UseVisualStyleBackColor = true;
            this._priceButton.Click += new System.EventHandler(this.PriceButton_Click);
            // 
            // _menuStrip
            // 
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tradeToolStripMenuItem});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(844, 24);
            this._menuStrip.TabIndex = 23;
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
            // portfolioTableAdapter
            // 
            this.portfolioTableAdapter.ClearBeforeFill = true;
            // 
            // SellStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 542);
            this.Controls.Add(this._menuStrip);
            this.Controls.Add(this._priceButton);
            this.Controls.Add(groupBox2);
            this.Controls.Add(_porfolioResultGroupBox);
            this.Controls.Add(_orderResultGroupBox);
            this.Controls.Add(OrderInfoGroupBox);
            this.Controls.Add(this.SellButton);
            this.Name = "SellStockForm";
            this.Text = "Sell Stock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SellStockForm_FormClosing);
            this.Load += new System.EventHandler(this.SellStockForm_Load);
            _orderResultGroupBox.ResumeLayout(false);
            _orderResultGroupBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            OrderInfoGroupBox.ResumeLayout(false);
            OrderInfoGroupBox.PerformLayout();
            _porfolioResultGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._portfolioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portfolioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPortfolio)).EndInit();
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OrderResultsTextBox;
        private System.Windows.Forms.Button _depositCashButton;
        private System.Windows.Forms.TextBox CashTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        public System.Windows.Forms.TextBox QuantityTextBox;
        public System.Windows.Forms.TextBox PriceTextBox;
        public System.Windows.Forms.TextBox NameTextBox;
        public System.Windows.Forms.TextBox SymbolTextBox;
        private System.Windows.Forms.Button SellButton;
        private System.Windows.Forms.Button _priceButton;
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
        private ViewPortfolio viewPortfolio;
        private System.Windows.Forms.BindingSource portfolioBindingSource;
        private ViewPortfolioTableAdapters.portfolioTableAdapter portfolioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocktickerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityownedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dollarcostaverageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox _profitTextBox;
    }
}