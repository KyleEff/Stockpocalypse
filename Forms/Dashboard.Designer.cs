namespace StockForms
{
    partial class Dashboard
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
            this.MainTitle = new System.Windows.Forms.Label();
            this.Subtitle = new System.Windows.Forms.Label();
            this.GetQuoteButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.TimeSeriesTestButton = new System.Windows.Forms.Button();
            this.DepositCashButton = new System.Windows.Forms.Button();
            this.CashTextBox = new System.Windows.Forms.TextBox();
            this.CashLabel = new System.Windows.Forms.Label();
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portfolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IndicesGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NDQGroupBox = new System.Windows.Forms.GroupBox();
            this.DJIGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._lowLabel = new System.Windows.Forms.Label();
            this._djiLowTextBox = new System.Windows.Forms.TextBox();
            this._djiHighLabel = new System.Windows.Forms.Label();
            this._djiHighTextBox = new System.Windows.Forms.TextBox();
            this._djiDayChange = new System.Windows.Forms.Label();
            this._djiLabel = new System.Windows.Forms.Label();
            this._djiChangeTextBox = new System.Windows.Forms.TextBox();
            this._djiTextBox = new System.Windows.Forms.TextBox();
            this._menuStrip.SuspendLayout();
            this.IndicesGroupBox.SuspendLayout();
            this.DJIGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainTitle.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTitle.Location = new System.Drawing.Point(236, 24);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(348, 52);
            this.MainTitle.TabIndex = 0;
            this.MainTitle.Text = "Stockpocalypse";
            // 
            // Subtitle
            // 
            this.Subtitle.AutoSize = true;
            this.Subtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtitle.Location = new System.Drawing.Point(149, 91);
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Size = new System.Drawing.Size(508, 25);
            this.Subtitle.TabIndex = 1;
            this.Subtitle.Text = "The Last Stock Trading Program You Will Ever Use!";
            // 
            // GetQuoteButton
            // 
            this.GetQuoteButton.Location = new System.Drawing.Point(416, 192);
            this.GetQuoteButton.Name = "GetQuoteButton";
            this.GetQuoteButton.Size = new System.Drawing.Size(168, 42);
            this.GetQuoteButton.TabIndex = 2;
            this.GetQuoteButton.Text = "GET QUOTE";
            this.GetQuoteButton.UseVisualStyleBackColor = true;
            this.GetQuoteButton.Click += new System.EventHandler(this.GetQuoteButton_Clicked);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(416, 144);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(168, 42);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "SEARCH STOCKS";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // TimeSeriesTestButton
            // 
            this.TimeSeriesTestButton.Location = new System.Drawing.Point(416, 581);
            this.TimeSeriesTestButton.Name = "TimeSeriesTestButton";
            this.TimeSeriesTestButton.Size = new System.Drawing.Size(372, 23);
            this.TimeSeriesTestButton.TabIndex = 6;
            this.TimeSeriesTestButton.Text = "TIME SERIES TEST";
            this.TimeSeriesTestButton.UseVisualStyleBackColor = true;
            this.TimeSeriesTestButton.Click += new System.EventHandler(this.TimeSeriesTestButton_Click);
            // 
            // DepositCashButton
            // 
            this.DepositCashButton.Location = new System.Drawing.Point(28, 176);
            this.DepositCashButton.Name = "DepositCashButton";
            this.DepositCashButton.Size = new System.Drawing.Size(175, 23);
            this.DepositCashButton.TabIndex = 7;
            this.DepositCashButton.Text = "DEPOSIT CASH";
            this.DepositCashButton.UseVisualStyleBackColor = true;
            this.DepositCashButton.Click += new System.EventHandler(this.DepositCashButton_Click);
            // 
            // CashTextBox
            // 
            this.CashTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CashTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashTextBox.Location = new System.Drawing.Point(12, 144);
            this.CashTextBox.Name = "CashTextBox";
            this.CashTextBox.ReadOnly = true;
            this.CashTextBox.Size = new System.Drawing.Size(208, 26);
            this.CashTextBox.TabIndex = 8;
            this.CashTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CashLabel
            // 
            this.CashLabel.AutoSize = true;
            this.CashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashLabel.Location = new System.Drawing.Point(12, 128);
            this.CashLabel.Name = "CashLabel";
            this.CashLabel.Size = new System.Drawing.Size(171, 16);
            this.CashLabel.TabIndex = 9;
            this.CashLabel.Text = "Cash Available For Trading";
            // 
            // _menuStrip
            // 
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tradeToolStripMenuItem});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(800, 24);
            this._menuStrip.TabIndex = 10;
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
            // IndicesGroupBox
            // 
            this.IndicesGroupBox.Controls.Add(this.groupBox1);
            this.IndicesGroupBox.Controls.Add(this.NDQGroupBox);
            this.IndicesGroupBox.Controls.Add(this.DJIGroupBox);
            this.IndicesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndicesGroupBox.Location = new System.Drawing.Point(12, 205);
            this.IndicesGroupBox.Name = "IndicesGroupBox";
            this.IndicesGroupBox.Size = new System.Drawing.Size(398, 360);
            this.IndicesGroupBox.TabIndex = 11;
            this.IndicesGroupBox.TabStop = false;
            this.IndicesGroupBox.Text = "Market Indices";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(7, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 107);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Standard && Poors 500";
            // 
            // NDQGroupBox
            // 
            this.NDQGroupBox.Location = new System.Drawing.Point(7, 134);
            this.NDQGroupBox.Name = "NDQGroupBox";
            this.NDQGroupBox.Size = new System.Drawing.Size(385, 105);
            this.NDQGroupBox.TabIndex = 1;
            this.NDQGroupBox.TabStop = false;
            this.NDQGroupBox.Text = "Nasdaq-100";
            // 
            // DJIGroupBox
            // 
            this.DJIGroupBox.Controls.Add(this.label1);
            this.DJIGroupBox.Controls.Add(this.textBox1);
            this.DJIGroupBox.Controls.Add(this._lowLabel);
            this.DJIGroupBox.Controls.Add(this._djiLowTextBox);
            this.DJIGroupBox.Controls.Add(this._djiHighLabel);
            this.DJIGroupBox.Controls.Add(this._djiHighTextBox);
            this.DJIGroupBox.Controls.Add(this._djiDayChange);
            this.DJIGroupBox.Controls.Add(this._djiLabel);
            this.DJIGroupBox.Controls.Add(this._djiChangeTextBox);
            this.DJIGroupBox.Controls.Add(this._djiTextBox);
            this.DJIGroupBox.Location = new System.Drawing.Point(7, 22);
            this.DJIGroupBox.Name = "DJIGroupBox";
            this.DJIGroupBox.Size = new System.Drawing.Size(385, 106);
            this.DJIGroupBox.TabIndex = 0;
            this.DJIGroupBox.TabStop = false;
            this.DJIGroupBox.Text = "Dow Jones Industrial Average 30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Previous Day";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(125, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _lowLabel
            // 
            this._lowLabel.AutoSize = true;
            this._lowLabel.Location = new System.Drawing.Point(6, 80);
            this._lowLabel.Name = "_lowLabel";
            this._lowLabel.Size = new System.Drawing.Size(38, 16);
            this._lowLabel.TabIndex = 7;
            this._lowLabel.Text = "Low:";
            // 
            // _djiLowTextBox
            // 
            this._djiLowTextBox.Location = new System.Drawing.Point(72, 77);
            this._djiLowTextBox.Name = "_djiLowTextBox";
            this._djiLowTextBox.ReadOnly = true;
            this._djiLowTextBox.Size = new System.Drawing.Size(125, 22);
            this._djiLowTextBox.TabIndex = 6;
            this._djiLowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _djiHighLabel
            // 
            this._djiHighLabel.AutoSize = true;
            this._djiHighLabel.Location = new System.Drawing.Point(6, 52);
            this._djiHighLabel.Name = "_djiHighLabel";
            this._djiHighLabel.Size = new System.Drawing.Size(43, 16);
            this._djiHighLabel.TabIndex = 5;
            this._djiHighLabel.Text = "High:";
            // 
            // _djiHighTextBox
            // 
            this._djiHighTextBox.Location = new System.Drawing.Point(72, 49);
            this._djiHighTextBox.Name = "_djiHighTextBox";
            this._djiHighTextBox.ReadOnly = true;
            this._djiHighTextBox.Size = new System.Drawing.Size(125, 22);
            this._djiHighTextBox.TabIndex = 4;
            this._djiHighTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _djiDayChange
            // 
            this._djiDayChange.AutoSize = true;
            this._djiDayChange.Location = new System.Drawing.Point(238, 80);
            this._djiDayChange.Name = "_djiDayChange";
            this._djiDayChange.Size = new System.Drawing.Size(64, 16);
            this._djiDayChange.TabIndex = 3;
            this._djiDayChange.Text = "Change:";
            // 
            // _djiLabel
            // 
            this._djiLabel.AutoSize = true;
            this._djiLabel.Location = new System.Drawing.Point(6, 24);
            this._djiLabel.Name = "_djiLabel";
            this._djiLabel.Size = new System.Drawing.Size(60, 16);
            this._djiLabel.TabIndex = 2;
            this._djiLabel.Text = "Current:";
            // 
            // _djiChangeTextBox
            // 
            this._djiChangeTextBox.Location = new System.Drawing.Point(304, 77);
            this._djiChangeTextBox.Name = "_djiChangeTextBox";
            this._djiChangeTextBox.ReadOnly = true;
            this._djiChangeTextBox.Size = new System.Drawing.Size(75, 22);
            this._djiChangeTextBox.TabIndex = 1;
            this._djiChangeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _djiTextBox
            // 
            this._djiTextBox.Location = new System.Drawing.Point(72, 21);
            this._djiTextBox.Name = "_djiTextBox";
            this._djiTextBox.ReadOnly = true;
            this._djiTextBox.Size = new System.Drawing.Size(125, 22);
            this._djiTextBox.TabIndex = 0;
            this._djiTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.IndicesGroupBox);
            this.Controls.Add(this._menuStrip);
            this.Controls.Add(this.CashLabel);
            this.Controls.Add(this.CashTextBox);
            this.Controls.Add(this.DepositCashButton);
            this.Controls.Add(this.TimeSeriesTestButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.GetQuoteButton);
            this.Controls.Add(this.Subtitle);
            this.Controls.Add(this.MainTitle);
            this.Name = "Dashboard";
            this.Text = "Stockpocalypse";
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this.IndicesGroupBox.ResumeLayout(false);
            this.DJIGroupBox.ResumeLayout(false);
            this.DJIGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.Label Subtitle;
        private System.Windows.Forms.Button GetQuoteButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button TimeSeriesTestButton;
        private System.Windows.Forms.Button DepositCashButton;
        private System.Windows.Forms.Label CashLabel;
        private System.Windows.Forms.TextBox CashTextBox;
        private System.Windows.Forms.MenuStrip _menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portfolioToolStripMenuItem;
        private System.Windows.Forms.GroupBox IndicesGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox NDQGroupBox;
        private System.Windows.Forms.GroupBox DJIGroupBox;
        private System.Windows.Forms.TextBox _djiTextBox;
        private System.Windows.Forms.Label _djiLabel;
        private System.Windows.Forms.TextBox _djiChangeTextBox;
        private System.Windows.Forms.Label _djiDayChange;
        private System.Windows.Forms.Label _lowLabel;
        private System.Windows.Forms.TextBox _djiLowTextBox;
        private System.Windows.Forms.Label _djiHighLabel;
        private System.Windows.Forms.TextBox _djiHighTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

