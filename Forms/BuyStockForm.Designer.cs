namespace StockForms.Forms
{
    partial class BuyStockForm
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
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.GroupBox OrderInfoGroupBox;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label QuantityLabel;
            System.Windows.Forms.Label PriceLabel;
            System.Windows.Forms.Label NameLabel;
            System.Windows.Forms.Label SymbolLabel;
            System.Windows.Forms.GroupBox _orderResultGroupBox;
            this._depositCashButton = new System.Windows.Forms.Button();
            this.CashTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SymbolTextBox = new System.Windows.Forms.TextBox();
            this.OrderResultsTextBox = new System.Windows.Forms.TextBox();
            this.BuyButton = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._quoteButton = new System.Windows.Forms.Button();
            this._exitButton = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            OrderInfoGroupBox = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            QuantityLabel = new System.Windows.Forms.Label();
            PriceLabel = new System.Windows.Forms.Label();
            NameLabel = new System.Windows.Forms.Label();
            SymbolLabel = new System.Windows.Forms.Label();
            _orderResultGroupBox = new System.Windows.Forms.GroupBox();
            groupBox2.SuspendLayout();
            OrderInfoGroupBox.SuspendLayout();
            _orderResultGroupBox.SuspendLayout();
            this._menuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this._depositCashButton);
            groupBox2.Controls.Add(this.CashTextBox);
            groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox2.Location = new System.Drawing.Point(354, 256);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(200, 77);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cash Available For Trade";
            // 
            // _depositCashButton
            // 
            this._depositCashButton.Location = new System.Drawing.Point(22, 49);
            this._depositCashButton.Name = "_depositCashButton";
            this._depositCashButton.Size = new System.Drawing.Size(155, 23);
            this._depositCashButton.TabIndex = 7;
            this._depositCashButton.Text = "Deposit Cash";
            this._depositCashButton.UseVisualStyleBackColor = true;
            this._depositCashButton.Click += new System.EventHandler(this.DepositCashButton_Click);
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
            OrderInfoGroupBox.Controls.Add(label2);
            OrderInfoGroupBox.Controls.Add(this.TotalTextBox);
            OrderInfoGroupBox.Controls.Add(label1);
            OrderInfoGroupBox.Controls.Add(this.QuantityTextBox);
            OrderInfoGroupBox.Controls.Add(QuantityLabel);
            OrderInfoGroupBox.Controls.Add(this.PriceTextBox);
            OrderInfoGroupBox.Controls.Add(PriceLabel);
            OrderInfoGroupBox.Controls.Add(this.NameTextBox);
            OrderInfoGroupBox.Controls.Add(NameLabel);
            OrderInfoGroupBox.Controls.Add(this.SymbolTextBox);
            OrderInfoGroupBox.Controls.Add(SymbolLabel);
            OrderInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            OrderInfoGroupBox.Location = new System.Drawing.Point(12, 27);
            OrderInfoGroupBox.Name = "OrderInfoGroupBox";
            OrderInfoGroupBox.Size = new System.Drawing.Size(542, 146);
            OrderInfoGroupBox.TabIndex = 3;
            OrderInfoGroupBox.TabStop = false;
            OrderInfoGroupBox.Text = "Order Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.Red;
            label2.Location = new System.Drawing.Point(176, 109);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(140, 16);
            label2.TabIndex = 10;
            label2.Text = "ENTER QUANTITY";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextBox.Location = new System.Drawing.Point(398, 50);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 22);
            this.TotalTextBox.TabIndex = 9;
            this.TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(409, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 16);
            label1.TabIndex = 8;
            label1.Text = "Total Cost";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(70, 106);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(100, 22);
            this.QuantityTextBox.TabIndex = 7;
            this.QuantityTextBox.TextChanged += new System.EventHandler(this.QuantityTextBox_TextChanged);
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
            // _orderResultGroupBox
            // 
            _orderResultGroupBox.Controls.Add(this.OrderResultsTextBox);
            _orderResultGroupBox.Location = new System.Drawing.Point(12, 179);
            _orderResultGroupBox.Name = "_orderResultGroupBox";
            _orderResultGroupBox.Size = new System.Drawing.Size(323, 234);
            _orderResultGroupBox.TabIndex = 15;
            _orderResultGroupBox.TabStop = false;
            _orderResultGroupBox.Text = "Order Results";
            // 
            // OrderResultsTextBox
            // 
            this.OrderResultsTextBox.Location = new System.Drawing.Point(6, 19);
            this.OrderResultsTextBox.Multiline = true;
            this.OrderResultsTextBox.Name = "OrderResultsTextBox";
            this.OrderResultsTextBox.Size = new System.Drawing.Size(310, 209);
            this.OrderResultsTextBox.TabIndex = 6;
            // 
            // BuyButton
            // 
            this.BuyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyButton.Location = new System.Drawing.Point(3, 3);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(175, 53);
            this.BuyButton.TabIndex = 2;
            this.BuyButton.Text = "BUY";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // _menuStrip
            // 
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tradeToolStripMenuItem});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(567, 24);
            this._menuStrip.TabIndex = 16;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this._quoteButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._exitButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BuyButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 414);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(543, 59);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // _quoteButton
            // 
            this._quoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._quoteButton.Location = new System.Drawing.Point(184, 3);
            this._quoteButton.Name = "_quoteButton";
            this._quoteButton.Size = new System.Drawing.Size(175, 53);
            this._quoteButton.TabIndex = 5;
            this._quoteButton.Text = "GET QUOTE";
            this._quoteButton.UseVisualStyleBackColor = true;
            this._quoteButton.Click += new System.EventHandler(this.QuoteButton_Click);
            // 
            // _exitButton
            // 
            this._exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._exitButton.Location = new System.Drawing.Point(365, 3);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(175, 53);
            this._exitButton.TabIndex = 4;
            this._exitButton.Text = "EXIT";
            this._exitButton.UseVisualStyleBackColor = true;
            this._exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BuyStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 485);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this._menuStrip);
            this.Controls.Add(_orderResultGroupBox);
            this.Controls.Add(groupBox2);
            this.Controls.Add(OrderInfoGroupBox);
            this.Name = "BuyStockForm";
            this.Text = "Purchase Stock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuyForm_Closing);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            OrderInfoGroupBox.ResumeLayout(false);
            OrderInfoGroupBox.PerformLayout();
            _orderResultGroupBox.ResumeLayout(false);
            _orderResultGroupBox.PerformLayout();
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.TextBox TotalTextBox;
        public System.Windows.Forms.TextBox SymbolTextBox;
        public System.Windows.Forms.TextBox QuantityTextBox;
        public System.Windows.Forms.TextBox PriceTextBox;
        public System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox OrderResultsTextBox;
        private System.Windows.Forms.TextBox CashTextBox;
        private System.Windows.Forms.Button _depositCashButton;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button _exitButton;
        private System.Windows.Forms.Button _quoteButton;
    }
}