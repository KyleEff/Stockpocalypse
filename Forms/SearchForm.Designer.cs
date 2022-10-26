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
            System.Windows.Forms.GroupBox _stockInformationGroupBox;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label _tickerLabel;
            System.Windows.Forms.GroupBox _resultGroupBox;
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this._exchangeTextBox = new System.Windows.Forms.TextBox();
            this._tickerTextBox = new System.Windows.Forms.TextBox();
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._resultsTextBox = new System.Windows.Forms.ListBox();
            _stockInformationGroupBox = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            _tickerLabel = new System.Windows.Forms.Label();
            _resultGroupBox = new System.Windows.Forms.GroupBox();
            _stockInformationGroupBox.SuspendLayout();
            this._menuStrip.SuspendLayout();
            _resultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _stockInformationGroupBox
            // 
            _stockInformationGroupBox.Controls.Add(this._nameTextBox);
            _stockInformationGroupBox.Controls.Add(label2);
            _stockInformationGroupBox.Controls.Add(this._exchangeTextBox);
            _stockInformationGroupBox.Controls.Add(label1);
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
            // _exchangeTextBox
            // 
            this._exchangeTextBox.Location = new System.Drawing.Point(88, 90);
            this._exchangeTextBox.Name = "_exchangeTextBox";
            this._exchangeTextBox.Size = new System.Drawing.Size(197, 22);
            this._exchangeTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 93);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 16);
            label1.TabIndex = 2;
            label1.Text = "Exchange:";
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
            // _menuStrip
            // 
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tradeToolStripMenuItem});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(824, 24);
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
            // _resultGroupBox
            // 
            _resultGroupBox.Controls.Add(this._resultsTextBox);
            _resultGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _resultGroupBox.Location = new System.Drawing.Point(309, 28);
            _resultGroupBox.Name = "_resultGroupBox";
            _resultGroupBox.Size = new System.Drawing.Size(503, 250);
            _resultGroupBox.TabIndex = 12;
            _resultGroupBox.TabStop = false;
            _resultGroupBox.Text = "Search Results";
            // 
            // _resultsTextBox
            // 
            this._resultsTextBox.FormattingEnabled = true;
            this._resultsTextBox.ItemHeight = 16;
            this._resultsTextBox.Location = new System.Drawing.Point(7, 22);
            this._resultsTextBox.Name = "_resultsTextBox";
            this._resultsTextBox.Size = new System.Drawing.Size(490, 212);
            this._resultsTextBox.TabIndex = 0;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 466);
            this.Controls.Add(_resultGroupBox);
            this.Controls.Add(this._menuStrip);
            this.Controls.Add(_stockInformationGroupBox);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
            _stockInformationGroupBox.ResumeLayout(false);
            _stockInformationGroupBox.PerformLayout();
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            _resultGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.TextBox _exchangeTextBox;
        private System.Windows.Forms.TextBox _tickerTextBox;
        private System.Windows.Forms.MenuStrip _menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem;
        private System.Windows.Forms.ListBox _resultsTextBox;
    }
}