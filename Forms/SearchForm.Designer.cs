namespace StockForms
{
    partial class SearchForm
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
            System.Windows.Forms.GroupBox _stockInformationGroupBox;
            System.Windows.Forms.Label _typeLabel;
            System.Windows.Forms.Label _micLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label _exchangeLabel;
            System.Windows.Forms.Label _tickerLabel;
            System.Windows.Forms.GroupBox _resultGroupBox;
            this._typeComboBox = new System.Windows.Forms.ComboBox();
            this._searchButton = new System.Windows.Forms.Button();
            this._micTextBox = new System.Windows.Forms.TextBox();
            this._exchangeComboBox = new System.Windows.Forms.ComboBox();
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this._tickerTextBox = new System.Windows.Forms.TextBox();
            this._resultsListBox = new System.Windows.Forms.ListBox();
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._micToolTip = new System.Windows.Forms.ToolTip(this.components);
            this._exitButton = new System.Windows.Forms.Button();
            _stockInformationGroupBox = new System.Windows.Forms.GroupBox();
            _typeLabel = new System.Windows.Forms.Label();
            _micLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            _exchangeLabel = new System.Windows.Forms.Label();
            _tickerLabel = new System.Windows.Forms.Label();
            _resultGroupBox = new System.Windows.Forms.GroupBox();
            _stockInformationGroupBox.SuspendLayout();
            _resultGroupBox.SuspendLayout();
            this._menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _stockInformationGroupBox
            // 
            _stockInformationGroupBox.Controls.Add(this._typeComboBox);
            _stockInformationGroupBox.Controls.Add(_typeLabel);
            _stockInformationGroupBox.Controls.Add(this._searchButton);
            _stockInformationGroupBox.Controls.Add(this._micTextBox);
            _stockInformationGroupBox.Controls.Add(_micLabel);
            _stockInformationGroupBox.Controls.Add(this._exchangeComboBox);
            _stockInformationGroupBox.Controls.Add(this._nameTextBox);
            _stockInformationGroupBox.Controls.Add(label2);
            _stockInformationGroupBox.Controls.Add(_exchangeLabel);
            _stockInformationGroupBox.Controls.Add(this._tickerTextBox);
            _stockInformationGroupBox.Controls.Add(_tickerLabel);
            _stockInformationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _stockInformationGroupBox.Location = new System.Drawing.Point(12, 27);
            _stockInformationGroupBox.Name = "_stockInformationGroupBox";
            _stockInformationGroupBox.Size = new System.Drawing.Size(291, 251);
            _stockInformationGroupBox.TabIndex = 0;
            _stockInformationGroupBox.TabStop = false;
            _stockInformationGroupBox.Text = "Stock Information";
            // 
            // _typeComboBox
            // 
            this._typeComboBox.FormattingEnabled = true;
            this._typeComboBox.Items.AddRange(new object[] {
            "Common Stock",
            "Preferred Stock",
            "Real Estate Investment Trust (REIT)",
            "Depositary Receipt",
            "Unit"});
            this._typeComboBox.Location = new System.Drawing.Point(88, 151);
            this._typeComboBox.Name = "_typeComboBox";
            this._typeComboBox.Size = new System.Drawing.Size(197, 24);
            this._typeComboBox.TabIndex = 10;
            // 
            // _typeLabel
            // 
            _typeLabel.AutoSize = true;
            _typeLabel.Location = new System.Drawing.Point(6, 151);
            _typeLabel.Name = "_typeLabel";
            _typeLabel.Size = new System.Drawing.Size(47, 16);
            _typeLabel.TabIndex = 9;
            _typeLabel.Text = "Type:";
            // 
            // _searchButton
            // 
            this._searchButton.Location = new System.Drawing.Point(6, 181);
            this._searchButton.Name = "_searchButton";
            this._searchButton.Size = new System.Drawing.Size(279, 64);
            this._searchButton.TabIndex = 9;
            this._searchButton.Text = "SEARCH";
            this._searchButton.UseVisualStyleBackColor = true;
            this._searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // _micTextBox
            // 
            this._micTextBox.Location = new System.Drawing.Point(88, 120);
            this._micTextBox.Name = "_micTextBox";
            this._micTextBox.Size = new System.Drawing.Size(197, 22);
            this._micTextBox.TabIndex = 8;
            // 
            // _micLabel
            // 
            _micLabel.AutoSize = true;
            _micLabel.Location = new System.Drawing.Point(6, 123);
            _micLabel.Name = "_micLabel";
            _micLabel.Size = new System.Drawing.Size(37, 16);
            _micLabel.TabIndex = 7;
            _micLabel.Text = "MIC:";
            this._micToolTip.SetToolTip(_micLabel, "A market identifier code (MIC)\r\nis a four-character code used to\r\nidentify stock " +
        "markets and other\r\ntrading exchanges within global\r\ntrading and referencing comp" +
        "uter\r\nsystems.");
            // 
            // _exchangeComboBox
            // 
            this._exchangeComboBox.FormattingEnabled = true;
            this._exchangeComboBox.Items.AddRange(new object[] {
            "NYSE",
            "NASDAQ"});
            this._exchangeComboBox.Location = new System.Drawing.Point(88, 90);
            this._exchangeComboBox.Name = "_exchangeComboBox";
            this._exchangeComboBox.Size = new System.Drawing.Size(197, 24);
            this._exchangeComboBox.TabIndex = 6;
            // 
            // _nameTextBox
            // 
            this._nameTextBox.Location = new System.Drawing.Point(88, 62);
            this._nameTextBox.Name = "_nameTextBox";
            this._nameTextBox.Size = new System.Drawing.Size(197, 22);
            this._nameTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 65);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 16);
            label2.TabIndex = 4;
            label2.Text = "Name:";
            // 
            // _exchangeLabel
            // 
            _exchangeLabel.AutoSize = true;
            _exchangeLabel.Location = new System.Drawing.Point(6, 93);
            _exchangeLabel.Name = "_exchangeLabel";
            _exchangeLabel.Size = new System.Drawing.Size(79, 16);
            _exchangeLabel.TabIndex = 2;
            _exchangeLabel.Text = "Exchange:";
            // 
            // _tickerTextBox
            // 
            this._tickerTextBox.Location = new System.Drawing.Point(88, 34);
            this._tickerTextBox.Name = "_tickerTextBox";
            this._tickerTextBox.Size = new System.Drawing.Size(197, 22);
            this._tickerTextBox.TabIndex = 1;
            // 
            // _tickerLabel
            // 
            _tickerLabel.AutoSize = true;
            _tickerLabel.Location = new System.Drawing.Point(6, 37);
            _tickerLabel.Name = "_tickerLabel";
            _tickerLabel.Size = new System.Drawing.Size(55, 16);
            _tickerLabel.TabIndex = 0;
            _tickerLabel.Text = "Ticker:";
            // 
            // _resultGroupBox
            // 
            _resultGroupBox.Controls.Add(this._resultsListBox);
            _resultGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _resultGroupBox.Location = new System.Drawing.Point(309, 27);
            _resultGroupBox.Name = "_resultGroupBox";
            _resultGroupBox.Size = new System.Drawing.Size(877, 434);
            _resultGroupBox.TabIndex = 12;
            _resultGroupBox.TabStop = false;
            _resultGroupBox.Text = "Search Results";
            // 
            // _resultsListBox
            // 
            this._resultsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._resultsListBox.FormattingEnabled = true;
            this._resultsListBox.ItemHeight = 16;
            this._resultsListBox.Location = new System.Drawing.Point(7, 22);
            this._resultsListBox.Name = "_resultsListBox";
            this._resultsListBox.Size = new System.Drawing.Size(864, 404);
            this._resultsListBox.TabIndex = 0;
            // 
            // _menuStrip
            // 
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tradeToolStripMenuItem});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(1198, 24);
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
            this.sellToolStripMenuItem});
            this.tradeToolStripMenuItem.Name = "tradeToolStripMenuItem";
            this.tradeToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.tradeToolStripMenuItem.Text = "Trade";
            // 
            // quoteToolStripMenuItem
            // 
            this.quoteToolStripMenuItem.Name = "quoteToolStripMenuItem";
            this.quoteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.quoteToolStripMenuItem.Text = "Quote";
            // 
            // buyToolStripMenuItem
            // 
            this.buyToolStripMenuItem.Name = "buyToolStripMenuItem";
            this.buyToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.buyToolStripMenuItem.Text = "Buy";
            // 
            // sellToolStripMenuItem
            // 
            this.sellToolStripMenuItem.Name = "sellToolStripMenuItem";
            this.sellToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.sellToolStripMenuItem.Text = "Sell";
            // 
            // _micToolTip
            // 
            this._micToolTip.Tag = "MICCode";
            this._micToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this._micToolTip.ToolTipTitle = "Market Identifier Code";
            // 
            // _exitButton
            // 
            this._exitButton.Location = new System.Drawing.Point(12, 415);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(291, 39);
            this._exitButton.TabIndex = 10;
            this._exitButton.Text = "EXIT";
            this._exitButton.UseVisualStyleBackColor = true;
            this._exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 466);
            this.Controls.Add(this._exitButton);
            this.Controls.Add(_resultGroupBox);
            this.Controls.Add(this._menuStrip);
            this.Controls.Add(_stockInformationGroupBox);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
            _stockInformationGroupBox.ResumeLayout(false);
            _stockInformationGroupBox.PerformLayout();
            _resultGroupBox.ResumeLayout(false);
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.TextBox _tickerTextBox;
        private System.Windows.Forms.MenuStrip _menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem;
        private System.Windows.Forms.ListBox _resultsListBox;
        private System.Windows.Forms.TextBox _micTextBox;
        private System.Windows.Forms.ToolTip _micToolTip;
        private System.Windows.Forms.Button _exitButton;
        private System.Windows.Forms.Button _searchButton;
        private System.Windows.Forms.ComboBox _typeComboBox;
        public System.Windows.Forms.ComboBox _exchangeComboBox;
    }
}