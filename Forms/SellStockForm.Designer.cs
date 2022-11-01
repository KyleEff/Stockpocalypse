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
            System.Windows.Forms.GroupBox _orderResultGroupBox;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.GroupBox OrderInfoGroupBox;
            System.Windows.Forms.Label _enterQuantityLabel;
            System.Windows.Forms.Label QuantityLabel;
            System.Windows.Forms.Label _totalCostLabel;
            System.Windows.Forms.Label PriceLabel;
            System.Windows.Forms.Label NameLabel;
            System.Windows.Forms.Label SymbolLabel;
            System.Windows.Forms.GroupBox _porfolioResultGroupBox;
            System.Windows.Forms.Label _portfolioNameLabel;
            System.Windows.Forms.Label _quantityOwnedLabel;
            System.Windows.Forms.Label _dcaLabel;
            System.Windows.Forms.Label _totalValueLabel;
            this.OrderResultsTextBox = new System.Windows.Forms.TextBox();
            this._depositCashButton = new System.Windows.Forms.Button();
            this.CashTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SymbolTextBox = new System.Windows.Forms.TextBox();
            this._portfolioResultListBox = new System.Windows.Forms.ListBox();
            this.SellButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portfolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._priceButton = new System.Windows.Forms.Button();
            _orderResultGroupBox = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            OrderInfoGroupBox = new System.Windows.Forms.GroupBox();
            _enterQuantityLabel = new System.Windows.Forms.Label();
            QuantityLabel = new System.Windows.Forms.Label();
            _totalCostLabel = new System.Windows.Forms.Label();
            PriceLabel = new System.Windows.Forms.Label();
            NameLabel = new System.Windows.Forms.Label();
            SymbolLabel = new System.Windows.Forms.Label();
            _porfolioResultGroupBox = new System.Windows.Forms.GroupBox();
            _portfolioNameLabel = new System.Windows.Forms.Label();
            _quantityOwnedLabel = new System.Windows.Forms.Label();
            _dcaLabel = new System.Windows.Forms.Label();
            _totalValueLabel = new System.Windows.Forms.Label();
            _orderResultGroupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            OrderInfoGroupBox.SuspendLayout();
            _porfolioResultGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.TotalTextBox.Location = new System.Drawing.Point(400, 72);
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
            _totalCostLabel.Location = new System.Drawing.Point(411, 53);
            _totalCostLabel.Name = "_totalCostLabel";
            _totalCostLabel.Size = new System.Drawing.Size(78, 16);
            _totalCostLabel.TabIndex = 8;
            _totalCostLabel.Text = "Total Cost";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new System.Drawing.Point(23, 81);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new System.Drawing.Size(41, 16);
            PriceLabel.TabIndex = 4;
            PriceLabel.Text = "Price:";
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
            _porfolioResultGroupBox.Controls.Add(_totalValueLabel);
            _porfolioResultGroupBox.Controls.Add(_dcaLabel);
            _porfolioResultGroupBox.Controls.Add(_quantityOwnedLabel);
            _porfolioResultGroupBox.Controls.Add(_portfolioNameLabel);
            _porfolioResultGroupBox.Controls.Add(this._portfolioResultListBox);
            _porfolioResultGroupBox.Location = new System.Drawing.Point(191, 179);
            _porfolioResultGroupBox.Name = "_porfolioResultGroupBox";
            _porfolioResultGroupBox.Size = new System.Drawing.Size(647, 358);
            _porfolioResultGroupBox.TabIndex = 21;
            _porfolioResultGroupBox.TabStop = false;
            _porfolioResultGroupBox.Text = "Portfolio Results";
            // 
            // _portfolioResultListBox
            // 
            this._portfolioResultListBox.FormattingEnabled = true;
            this._portfolioResultListBox.Location = new System.Drawing.Point(7, 33);
            this._portfolioResultListBox.Name = "_portfolioResultListBox";
            this._portfolioResultListBox.Size = new System.Drawing.Size(634, 316);
            this._portfolioResultListBox.TabIndex = 0;
            this._portfolioResultListBox.SelectedIndexChanged += new System.EventHandler(this.PortfolioResultListBox_SelectedIndexChanged);
            // 
            // SellButton
            // 
            this.SellButton.Location = new System.Drawing.Point(12, 419);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(142, 54);
            this.SellButton.TabIndex = 16;
            this.SellButton.Text = "SELL";
            this.SellButton.UseVisualStyleBackColor = true;
            this.SellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tradeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
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
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // tradeToolStripMenuItem
            // 
            this.tradeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quoteToolStripMenuItem,
            this.buyToolStripMenuItem,
            this.sellToolStripMenuItem,
            this.portfolioToolStripMenuItem});
            this.tradeToolStripMenuItem.Name = "tradeToolStripMenuItem";
            this.tradeToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.tradeToolStripMenuItem.Text = "Trade";
            // 
            // quoteToolStripMenuItem
            // 
            this.quoteToolStripMenuItem.Name = "quoteToolStripMenuItem";
            this.quoteToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.quoteToolStripMenuItem.Text = "Quote";
            // 
            // buyToolStripMenuItem
            // 
            this.buyToolStripMenuItem.Name = "buyToolStripMenuItem";
            this.buyToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.buyToolStripMenuItem.Text = "Buy";
            // 
            // sellToolStripMenuItem
            // 
            this.sellToolStripMenuItem.Name = "sellToolStripMenuItem";
            this.sellToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.sellToolStripMenuItem.Text = "Sell";
            // 
            // portfolioToolStripMenuItem
            // 
            this.portfolioToolStripMenuItem.Name = "portfolioToolStripMenuItem";
            this.portfolioToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.portfolioToolStripMenuItem.Text = "Portfolio";
            // 
            // _priceButton
            // 
            this._priceButton.Location = new System.Drawing.Point(12, 479);
            this._priceButton.Name = "_priceButton";
            this._priceButton.Size = new System.Drawing.Size(142, 54);
            this._priceButton.TabIndex = 22;
            this._priceButton.Text = "GET PRICE";
            this._priceButton.UseVisualStyleBackColor = true;
            this._priceButton.Click += new System.EventHandler(this.PriceButton_Click);
            // 
            // _portfolioNameLabel
            // 
            _portfolioNameLabel.AutoSize = true;
            _portfolioNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _portfolioNameLabel.Location = new System.Drawing.Point(6, 16);
            _portfolioNameLabel.Name = "_portfolioNameLabel";
            _portfolioNameLabel.Size = new System.Drawing.Size(39, 13);
            _portfolioNameLabel.TabIndex = 1;
            _portfolioNameLabel.Text = "Name";
            // 
            // _quantityOwnedLabel
            // 
            _quantityOwnedLabel.AutoSize = true;
            _quantityOwnedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _quantityOwnedLabel.Location = new System.Drawing.Point(207, 16);
            _quantityOwnedLabel.Name = "_quantityOwnedLabel";
            _quantityOwnedLabel.Size = new System.Drawing.Size(97, 13);
            _quantityOwnedLabel.TabIndex = 2;
            _quantityOwnedLabel.Text = "Quantity Owned";
            // 
            // _dcaLabel
            // 
            _dcaLabel.AutoSize = true;
            _dcaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _dcaLabel.Location = new System.Drawing.Point(368, 16);
            _dcaLabel.Name = "_dcaLabel";
            _dcaLabel.Size = new System.Drawing.Size(120, 13);
            _dcaLabel.TabIndex = 3;
            _dcaLabel.Text = "Dollar Cost Average";
            // 
            // _totalValueLabel
            // 
            _totalValueLabel.AutoSize = true;
            _totalValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _totalValueLabel.Location = new System.Drawing.Point(554, 16);
            _totalValueLabel.Name = "_totalValueLabel";
            _totalValueLabel.Size = new System.Drawing.Size(72, 13);
            _totalValueLabel.TabIndex = 4;
            _totalValueLabel.Text = "Total Value";
            // 
            // SellStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 542);
            this.Controls.Add(this._priceButton);
            this.Controls.Add(groupBox2);
            this.Controls.Add(_porfolioResultGroupBox);
            this.Controls.Add(_orderResultGroupBox);
            this.Controls.Add(OrderInfoGroupBox);
            this.Controls.Add(this.SellButton);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SellStockForm";
            this.Text = "Sell Stock";
            _orderResultGroupBox.ResumeLayout(false);
            _orderResultGroupBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            OrderInfoGroupBox.ResumeLayout(false);
            OrderInfoGroupBox.PerformLayout();
            _porfolioResultGroupBox.ResumeLayout(false);
            _porfolioResultGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portfolioToolStripMenuItem;
        private System.Windows.Forms.Button _priceButton;
        private System.Windows.Forms.ListBox _portfolioResultListBox;
    }
}