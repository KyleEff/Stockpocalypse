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
            System.Windows.Forms.Label MainTitle;
            System.Windows.Forms.Label Subtitle;
            System.Windows.Forms.GroupBox IndicesGroupBox;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.GroupBox _spGroupBox;
            System.Windows.Forms.Label _spPercentLabel;
            System.Windows.Forms.Label _spPrevDayLabel;
            System.Windows.Forms.Label _spLowLabel;
            System.Windows.Forms.Label _spHighLabel;
            System.Windows.Forms.Label _spDailyChangeLabel;
            System.Windows.Forms.Label _spLabel;
            System.Windows.Forms.GroupBox _djiGroupBox;
            System.Windows.Forms.Label _djiPercentLabel;
            System.Windows.Forms.Label _djiPrevDayLabel;
            System.Windows.Forms.Label _lowLabel;
            System.Windows.Forms.Label _djiHighLabel;
            System.Windows.Forms.Label _djiDayChangeLabel;
            System.Windows.Forms.Label _djiLabel;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.GroupBox groupBox3;
            this._marketTodayLabel = new System.Windows.Forms.Label();
            this._spPrevTextBox = new System.Windows.Forms.TextBox();
            this._spLowTextBox = new System.Windows.Forms.TextBox();
            this._spHighTextBox = new System.Windows.Forms.TextBox();
            this._spChangeTextBox = new System.Windows.Forms.TextBox();
            this._spTextBox = new System.Windows.Forms.TextBox();
            this._djiPrevTextBox = new System.Windows.Forms.TextBox();
            this._djiLowTextBox = new System.Windows.Forms.TextBox();
            this._djiHighTextBox = new System.Windows.Forms.TextBox();
            this._djiChangeTextBox = new System.Windows.Forms.TextBox();
            this._djiTextBox = new System.Windows.Forms.TextBox();
            this.CashTextBox = new System.Windows.Forms.TextBox();
            this._depositCashButton = new System.Windows.Forms.Button();
            this._exitButton = new System.Windows.Forms.Button();
            this._viewPortfolioButton = new System.Windows.Forms.Button();
            this._sellButton = new System.Windows.Forms.Button();
            this.GetQuoteButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
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
            MainTitle = new System.Windows.Forms.Label();
            Subtitle = new System.Windows.Forms.Label();
            IndicesGroupBox = new System.Windows.Forms.GroupBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            _spGroupBox = new System.Windows.Forms.GroupBox();
            _spPercentLabel = new System.Windows.Forms.Label();
            _spPrevDayLabel = new System.Windows.Forms.Label();
            _spLowLabel = new System.Windows.Forms.Label();
            _spHighLabel = new System.Windows.Forms.Label();
            _spDailyChangeLabel = new System.Windows.Forms.Label();
            _spLabel = new System.Windows.Forms.Label();
            _djiGroupBox = new System.Windows.Forms.GroupBox();
            _djiPercentLabel = new System.Windows.Forms.Label();
            _djiPrevDayLabel = new System.Windows.Forms.Label();
            _lowLabel = new System.Windows.Forms.Label();
            _djiHighLabel = new System.Windows.Forms.Label();
            _djiDayChangeLabel = new System.Windows.Forms.Label();
            _djiLabel = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            IndicesGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            _spGroupBox.SuspendLayout();
            _djiGroupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            this._menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTitle
            // 
            MainTitle.AutoSize = true;
            MainTitle.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            MainTitle.Location = new System.Drawing.Point(126, 27);
            MainTitle.Name = "MainTitle";
            MainTitle.Size = new System.Drawing.Size(348, 52);
            MainTitle.TabIndex = 0;
            MainTitle.Text = "Stockpocalypse";
            // 
            // Subtitle
            // 
            Subtitle.AutoSize = true;
            Subtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Subtitle.Location = new System.Drawing.Point(46, 79);
            Subtitle.Name = "Subtitle";
            Subtitle.Size = new System.Drawing.Size(508, 25);
            Subtitle.TabIndex = 1;
            Subtitle.Text = "The Last Stock Trading Program You Will Ever Use!";
            // 
            // IndicesGroupBox
            // 
            IndicesGroupBox.Controls.Add(groupBox1);
            IndicesGroupBox.Controls.Add(_spGroupBox);
            IndicesGroupBox.Controls.Add(_djiGroupBox);
            IndicesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            IndicesGroupBox.Location = new System.Drawing.Point(11, 200);
            IndicesGroupBox.Name = "IndicesGroupBox";
            IndicesGroupBox.Size = new System.Drawing.Size(398, 360);
            IndicesGroupBox.TabIndex = 11;
            IndicesGroupBox.TabStop = false;
            IndicesGroupBox.Text = "Market Indices";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this._marketTodayLabel);
            groupBox1.Location = new System.Drawing.Point(7, 246);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(385, 106);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Market Today";
            // 
            // _marketTodayLabel
            // 
            this._marketTodayLabel.AutoSize = true;
            this._marketTodayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._marketTodayLabel.Location = new System.Drawing.Point(35, 34);
            this._marketTodayLabel.Name = "_marketTodayLabel";
            this._marketTodayLabel.Size = new System.Drawing.Size(179, 29);
            this._marketTodayLabel.TabIndex = 0;
            this._marketTodayLabel.Text = "The Market Is ";
            this._marketTodayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _spGroupBox
            // 
            _spGroupBox.Controls.Add(_spPercentLabel);
            _spGroupBox.Controls.Add(_spPrevDayLabel);
            _spGroupBox.Controls.Add(this._spPrevTextBox);
            _spGroupBox.Controls.Add(_spLowLabel);
            _spGroupBox.Controls.Add(this._spLowTextBox);
            _spGroupBox.Controls.Add(_spHighLabel);
            _spGroupBox.Controls.Add(this._spHighTextBox);
            _spGroupBox.Controls.Add(_spDailyChangeLabel);
            _spGroupBox.Controls.Add(_spLabel);
            _spGroupBox.Controls.Add(this._spChangeTextBox);
            _spGroupBox.Controls.Add(this._spTextBox);
            _spGroupBox.Location = new System.Drawing.Point(7, 134);
            _spGroupBox.Name = "_spGroupBox";
            _spGroupBox.Size = new System.Drawing.Size(385, 106);
            _spGroupBox.TabIndex = 10;
            _spGroupBox.TabStop = false;
            _spGroupBox.Text = "Standard and Poors 500";
            // 
            // _spPercentLabel
            // 
            _spPercentLabel.AutoSize = true;
            _spPercentLabel.Location = new System.Drawing.Point(359, 81);
            _spPercentLabel.Name = "_spPercentLabel";
            _spPercentLabel.Size = new System.Drawing.Size(20, 16);
            _spPercentLabel.TabIndex = 11;
            _spPercentLabel.Text = "%";
            // 
            // _spPrevDayLabel
            // 
            _spPrevDayLabel.AutoSize = true;
            _spPrevDayLabel.Location = new System.Drawing.Point(265, 18);
            _spPrevDayLabel.Name = "_spPrevDayLabel";
            _spPrevDayLabel.Size = new System.Drawing.Size(100, 16);
            _spPrevDayLabel.TabIndex = 9;
            _spPrevDayLabel.Text = "Previous Day";
            // 
            // _spPrevTextBox
            // 
            this._spPrevTextBox.Location = new System.Drawing.Point(254, 37);
            this._spPrevTextBox.Name = "_spPrevTextBox";
            this._spPrevTextBox.ReadOnly = true;
            this._spPrevTextBox.Size = new System.Drawing.Size(125, 22);
            this._spPrevTextBox.TabIndex = 8;
            this._spPrevTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _spLowLabel
            // 
            _spLowLabel.AutoSize = true;
            _spLowLabel.Location = new System.Drawing.Point(6, 80);
            _spLowLabel.Name = "_spLowLabel";
            _spLowLabel.Size = new System.Drawing.Size(38, 16);
            _spLowLabel.TabIndex = 7;
            _spLowLabel.Text = "Low:";
            // 
            // _spLowTextBox
            // 
            this._spLowTextBox.Location = new System.Drawing.Point(72, 77);
            this._spLowTextBox.Name = "_spLowTextBox";
            this._spLowTextBox.ReadOnly = true;
            this._spLowTextBox.Size = new System.Drawing.Size(125, 22);
            this._spLowTextBox.TabIndex = 6;
            this._spLowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _spHighLabel
            // 
            _spHighLabel.AutoSize = true;
            _spHighLabel.Location = new System.Drawing.Point(6, 52);
            _spHighLabel.Name = "_spHighLabel";
            _spHighLabel.Size = new System.Drawing.Size(43, 16);
            _spHighLabel.TabIndex = 5;
            _spHighLabel.Text = "High:";
            // 
            // _spHighTextBox
            // 
            this._spHighTextBox.Location = new System.Drawing.Point(72, 49);
            this._spHighTextBox.Name = "_spHighTextBox";
            this._spHighTextBox.ReadOnly = true;
            this._spHighTextBox.Size = new System.Drawing.Size(125, 22);
            this._spHighTextBox.TabIndex = 4;
            this._spHighTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _spDailyChangeLabel
            // 
            _spDailyChangeLabel.AutoSize = true;
            _spDailyChangeLabel.Location = new System.Drawing.Point(232, 81);
            _spDailyChangeLabel.Name = "_spDailyChangeLabel";
            _spDailyChangeLabel.Size = new System.Drawing.Size(64, 16);
            _spDailyChangeLabel.TabIndex = 3;
            _spDailyChangeLabel.Text = "Change:";
            // 
            // _spLabel
            // 
            _spLabel.AutoSize = true;
            _spLabel.Location = new System.Drawing.Point(6, 24);
            _spLabel.Name = "_spLabel";
            _spLabel.Size = new System.Drawing.Size(60, 16);
            _spLabel.TabIndex = 2;
            _spLabel.Text = "Current:";
            // 
            // _spChangeTextBox
            // 
            this._spChangeTextBox.Location = new System.Drawing.Point(298, 78);
            this._spChangeTextBox.Name = "_spChangeTextBox";
            this._spChangeTextBox.ReadOnly = true;
            this._spChangeTextBox.Size = new System.Drawing.Size(61, 22);
            this._spChangeTextBox.TabIndex = 1;
            this._spChangeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _spTextBox
            // 
            this._spTextBox.Location = new System.Drawing.Point(72, 21);
            this._spTextBox.Name = "_spTextBox";
            this._spTextBox.ReadOnly = true;
            this._spTextBox.Size = new System.Drawing.Size(125, 22);
            this._spTextBox.TabIndex = 0;
            this._spTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _djiGroupBox
            // 
            _djiGroupBox.Controls.Add(_djiPercentLabel);
            _djiGroupBox.Controls.Add(_djiPrevDayLabel);
            _djiGroupBox.Controls.Add(this._djiPrevTextBox);
            _djiGroupBox.Controls.Add(_lowLabel);
            _djiGroupBox.Controls.Add(this._djiLowTextBox);
            _djiGroupBox.Controls.Add(_djiHighLabel);
            _djiGroupBox.Controls.Add(this._djiHighTextBox);
            _djiGroupBox.Controls.Add(_djiDayChangeLabel);
            _djiGroupBox.Controls.Add(_djiLabel);
            _djiGroupBox.Controls.Add(this._djiChangeTextBox);
            _djiGroupBox.Controls.Add(this._djiTextBox);
            _djiGroupBox.Location = new System.Drawing.Point(7, 22);
            _djiGroupBox.Name = "_djiGroupBox";
            _djiGroupBox.Size = new System.Drawing.Size(385, 106);
            _djiGroupBox.TabIndex = 0;
            _djiGroupBox.TabStop = false;
            _djiGroupBox.Text = "Dow Jones Industrial Average 30";
            // 
            // _djiPercentLabel
            // 
            _djiPercentLabel.AutoSize = true;
            _djiPercentLabel.Location = new System.Drawing.Point(359, 80);
            _djiPercentLabel.Name = "_djiPercentLabel";
            _djiPercentLabel.Size = new System.Drawing.Size(20, 16);
            _djiPercentLabel.TabIndex = 10;
            _djiPercentLabel.Text = "%";
            // 
            // _djiPrevDayLabel
            // 
            _djiPrevDayLabel.AutoSize = true;
            _djiPrevDayLabel.Location = new System.Drawing.Point(265, 18);
            _djiPrevDayLabel.Name = "_djiPrevDayLabel";
            _djiPrevDayLabel.Size = new System.Drawing.Size(100, 16);
            _djiPrevDayLabel.TabIndex = 9;
            _djiPrevDayLabel.Text = "Previous Day";
            // 
            // _djiPrevTextBox
            // 
            this._djiPrevTextBox.Location = new System.Drawing.Point(254, 37);
            this._djiPrevTextBox.Name = "_djiPrevTextBox";
            this._djiPrevTextBox.ReadOnly = true;
            this._djiPrevTextBox.Size = new System.Drawing.Size(125, 22);
            this._djiPrevTextBox.TabIndex = 8;
            this._djiPrevTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _lowLabel
            // 
            _lowLabel.AutoSize = true;
            _lowLabel.Location = new System.Drawing.Point(6, 80);
            _lowLabel.Name = "_lowLabel";
            _lowLabel.Size = new System.Drawing.Size(38, 16);
            _lowLabel.TabIndex = 7;
            _lowLabel.Text = "Low:";
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
            _djiHighLabel.AutoSize = true;
            _djiHighLabel.Location = new System.Drawing.Point(6, 52);
            _djiHighLabel.Name = "_djiHighLabel";
            _djiHighLabel.Size = new System.Drawing.Size(43, 16);
            _djiHighLabel.TabIndex = 5;
            _djiHighLabel.Text = "High:";
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
            // _djiDayChangeLabel
            // 
            _djiDayChangeLabel.AutoSize = true;
            _djiDayChangeLabel.Location = new System.Drawing.Point(232, 80);
            _djiDayChangeLabel.Name = "_djiDayChangeLabel";
            _djiDayChangeLabel.Size = new System.Drawing.Size(64, 16);
            _djiDayChangeLabel.TabIndex = 3;
            _djiDayChangeLabel.Text = "Change:";
            // 
            // _djiLabel
            // 
            _djiLabel.AutoSize = true;
            _djiLabel.Location = new System.Drawing.Point(6, 24);
            _djiLabel.Name = "_djiLabel";
            _djiLabel.Size = new System.Drawing.Size(60, 16);
            _djiLabel.TabIndex = 2;
            _djiLabel.Text = "Current:";
            // 
            // _djiChangeTextBox
            // 
            this._djiChangeTextBox.Location = new System.Drawing.Point(298, 77);
            this._djiChangeTextBox.Name = "_djiChangeTextBox";
            this._djiChangeTextBox.ReadOnly = true;
            this._djiChangeTextBox.Size = new System.Drawing.Size(61, 22);
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
            // groupBox2
            // 
            groupBox2.Controls.Add(this.CashTextBox);
            groupBox2.Controls.Add(this._depositCashButton);
            groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox2.Location = new System.Drawing.Point(200, 117);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(200, 77);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cash Available For Trade";
            // 
            // CashTextBox
            // 
            this.CashTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CashTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashTextBox.Location = new System.Drawing.Point(6, 19);
            this.CashTextBox.Name = "CashTextBox";
            this.CashTextBox.ReadOnly = true;
            this.CashTextBox.Size = new System.Drawing.Size(188, 26);
            this.CashTextBox.TabIndex = 8;
            this.CashTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // groupBox3
            // 
            groupBox3.Controls.Add(this._exitButton);
            groupBox3.Controls.Add(this._viewPortfolioButton);
            groupBox3.Controls.Add(this._sellButton);
            groupBox3.Controls.Add(this.GetQuoteButton);
            groupBox3.Controls.Add(this.SearchButton);
            groupBox3.Controls.Add(this._buyButton);
            groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox3.Location = new System.Drawing.Point(415, 222);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(181, 317);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Options";
            // 
            // _exitButton
            // 
            this._exitButton.Location = new System.Drawing.Point(6, 267);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(168, 42);
            this._exitButton.TabIndex = 15;
            this._exitButton.Text = "EXIT";
            this._exitButton.UseVisualStyleBackColor = true;
            this._exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // _viewPortfolioButton
            // 
            this._viewPortfolioButton.Location = new System.Drawing.Point(6, 219);
            this._viewPortfolioButton.Name = "_viewPortfolioButton";
            this._viewPortfolioButton.Size = new System.Drawing.Size(168, 42);
            this._viewPortfolioButton.TabIndex = 14;
            this._viewPortfolioButton.Text = "VIEW PORTFOLIO";
            this._viewPortfolioButton.UseVisualStyleBackColor = true;
            this._viewPortfolioButton.Click += new System.EventHandler(this.ViewPortfolioButton_Click);
            // 
            // _sellButton
            // 
            this._sellButton.Location = new System.Drawing.Point(6, 171);
            this._sellButton.Name = "_sellButton";
            this._sellButton.Size = new System.Drawing.Size(168, 42);
            this._sellButton.TabIndex = 13;
            this._sellButton.Text = "SELL";
            this._sellButton.UseVisualStyleBackColor = true;
            this._sellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // GetQuoteButton
            // 
            this.GetQuoteButton.Location = new System.Drawing.Point(6, 75);
            this.GetQuoteButton.Name = "GetQuoteButton";
            this.GetQuoteButton.Size = new System.Drawing.Size(168, 42);
            this.GetQuoteButton.TabIndex = 2;
            this.GetQuoteButton.Text = "GET QUOTE";
            this.GetQuoteButton.UseVisualStyleBackColor = true;
            this.GetQuoteButton.Click += new System.EventHandler(this.GetQuoteButton_Clicked);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(6, 27);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(168, 42);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "SEARCH";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // _buyButton
            // 
            this._buyButton.Location = new System.Drawing.Point(6, 123);
            this._buyButton.Name = "_buyButton";
            this._buyButton.Size = new System.Drawing.Size(168, 42);
            this._buyButton.TabIndex = 12;
            this._buyButton.Text = "BUY";
            this._buyButton.UseVisualStyleBackColor = true;
            this._buyButton.Click += new System.EventHandler(this.BuyButtonClick);
            // 
            // _menuStrip
            // 
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tradeToolStripMenuItem});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(600, 24);
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
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 559);
            this.Controls.Add(groupBox3);
            this.Controls.Add(groupBox2);
            this.Controls.Add(IndicesGroupBox);
            this.Controls.Add(this._menuStrip);
            this.Controls.Add(Subtitle);
            this.Controls.Add(MainTitle);
            this.Name = "Dashboard";
            this.Text = "Stockpocalypse";
            IndicesGroupBox.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            _spGroupBox.ResumeLayout(false);
            _spGroupBox.PerformLayout();
            _djiGroupBox.ResumeLayout(false);
            _djiGroupBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GetQuoteButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button _depositCashButton;
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
        private System.Windows.Forms.TextBox _djiTextBox;
        private System.Windows.Forms.TextBox _djiChangeTextBox;
        private System.Windows.Forms.TextBox _djiLowTextBox;
        private System.Windows.Forms.TextBox _djiHighTextBox;
        private System.Windows.Forms.TextBox _djiPrevTextBox;
        private System.Windows.Forms.TextBox _spPrevTextBox;
        private System.Windows.Forms.TextBox _spLowTextBox;
        private System.Windows.Forms.TextBox _spHighTextBox;
        private System.Windows.Forms.TextBox _spChangeTextBox;
        private System.Windows.Forms.TextBox _spTextBox;
        private System.Windows.Forms.Button _buyButton;
        private System.Windows.Forms.Label _marketTodayLabel;
        private System.Windows.Forms.Button _viewPortfolioButton;
        private System.Windows.Forms.Button _sellButton;
        private System.Windows.Forms.Button _exitButton;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
    }
}

