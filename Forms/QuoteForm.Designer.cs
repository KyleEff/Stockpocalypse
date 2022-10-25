namespace StockForms.Forms
{
    partial class QuoteForm
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
            this.GetQuoteButton = new System.Windows.Forms.Button();
            this.NasdaqRadioButton = new System.Windows.Forms.RadioButton();
            this.NyseRadioButton = new System.Windows.Forms.RadioButton();
            this.ExchangeRadioButtonGroup = new System.Windows.Forms.GroupBox();
            this.StockListBox = new System.Windows.Forms.ListBox();
            this.StocksListGroup = new System.Windows.Forms.GroupBox();
            this.DateTimeBox = new System.Windows.Forms.TextBox();
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DailyHigh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DailyLow = new System.Windows.Forms.TextBox();
            this.BuyStockButton = new System.Windows.Forms.Button();
            this.ExchangeRadioButtonGroup.SuspendLayout();
            this.StocksListGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetQuoteButton
            // 
            this.GetQuoteButton.Location = new System.Drawing.Point(12, 396);
            this.GetQuoteButton.Name = "GetQuoteButton";
            this.GetQuoteButton.Size = new System.Drawing.Size(152, 53);
            this.GetQuoteButton.TabIndex = 3;
            this.GetQuoteButton.Text = "GET QUOTE";
            this.GetQuoteButton.UseVisualStyleBackColor = true;
            this.GetQuoteButton.Click += new System.EventHandler(this.GetQuoteButton_Click);
            // 
            // NasdaqRadioButton
            // 
            this.NasdaqRadioButton.AutoSize = true;
            this.NasdaqRadioButton.Location = new System.Drawing.Point(6, 42);
            this.NasdaqRadioButton.Name = "NasdaqRadioButton";
            this.NasdaqRadioButton.Size = new System.Drawing.Size(70, 17);
            this.NasdaqRadioButton.TabIndex = 4;
            this.NasdaqRadioButton.Text = "NASDAQ";
            this.NasdaqRadioButton.UseVisualStyleBackColor = true;
            this.NasdaqRadioButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NasdaqRadioButton_MouseClick);
            // 
            // NyseRadioButton
            // 
            this.NyseRadioButton.AutoSize = true;
            this.NyseRadioButton.Checked = true;
            this.NyseRadioButton.Location = new System.Drawing.Point(6, 19);
            this.NyseRadioButton.Name = "NyseRadioButton";
            this.NyseRadioButton.Size = new System.Drawing.Size(54, 17);
            this.NyseRadioButton.TabIndex = 5;
            this.NyseRadioButton.TabStop = true;
            this.NyseRadioButton.Text = "NYSE";
            this.NyseRadioButton.UseVisualStyleBackColor = true;
            this.NyseRadioButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NyseRadioButton_MouseClick);
            // 
            // ExchangeRadioButtonGroup
            // 
            this.ExchangeRadioButtonGroup.Controls.Add(this.NyseRadioButton);
            this.ExchangeRadioButtonGroup.Controls.Add(this.NasdaqRadioButton);
            this.ExchangeRadioButtonGroup.Location = new System.Drawing.Point(12, 12);
            this.ExchangeRadioButtonGroup.Name = "ExchangeRadioButtonGroup";
            this.ExchangeRadioButtonGroup.Size = new System.Drawing.Size(93, 70);
            this.ExchangeRadioButtonGroup.TabIndex = 6;
            this.ExchangeRadioButtonGroup.TabStop = false;
            this.ExchangeRadioButtonGroup.Text = "Exchange";
            // 
            // StockListBox
            // 
            this.StockListBox.FormattingEnabled = true;
            this.StockListBox.Location = new System.Drawing.Point(6, 19);
            this.StockListBox.Name = "StockListBox";
            this.StockListBox.Size = new System.Drawing.Size(439, 212);
            this.StockListBox.TabIndex = 7;
            this.StockListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StockListBox_MouseClick);
            // 
            // StocksListGroup
            // 
            this.StocksListGroup.Controls.Add(this.StockListBox);
            this.StocksListGroup.Location = new System.Drawing.Point(121, 12);
            this.StocksListGroup.Name = "StocksListGroup";
            this.StocksListGroup.Size = new System.Drawing.Size(451, 241);
            this.StocksListGroup.TabIndex = 8;
            this.StocksListGroup.TabStop = false;
            this.StocksListGroup.Text = "Stock List";
            // 
            // DateTimeBox
            // 
            this.DateTimeBox.Location = new System.Drawing.Point(290, 267);
            this.DateTimeBox.Name = "DateTimeBox";
            this.DateTimeBox.ReadOnly = true;
            this.DateTimeBox.Size = new System.Drawing.Size(124, 20);
            this.DateTimeBox.TabIndex = 9;
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.Location = new System.Drawing.Point(217, 270);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(67, 13);
            this.DateTimeLabel.TabIndex = 10;
            this.DateTimeLabel.Text = "Date / Time:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(250, 296);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(34, 13);
            this.PriceLabel.TabIndex = 12;
            this.PriceLabel.Text = "Price:";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(290, 293);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.ReadOnly = true;
            this.PriceBox.Size = new System.Drawing.Size(124, 20);
            this.PriceBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Daily High:";
            // 
            // DailyHigh
            // 
            this.DailyHigh.Location = new System.Drawing.Point(290, 319);
            this.DailyHigh.Name = "DailyHigh";
            this.DailyHigh.ReadOnly = true;
            this.DailyHigh.Size = new System.Drawing.Size(124, 20);
            this.DailyHigh.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Daily Low:";
            // 
            // DailyLow
            // 
            this.DailyLow.Location = new System.Drawing.Point(290, 345);
            this.DailyLow.Name = "DailyLow";
            this.DailyLow.ReadOnly = true;
            this.DailyLow.Size = new System.Drawing.Size(124, 20);
            this.DailyLow.TabIndex = 15;
            // 
            // BuyStockButton
            // 
            this.BuyStockButton.Location = new System.Drawing.Point(414, 396);
            this.BuyStockButton.Name = "BuyStockButton";
            this.BuyStockButton.Size = new System.Drawing.Size(158, 53);
            this.BuyStockButton.TabIndex = 17;
            this.BuyStockButton.Text = "BUY STOCK";
            this.BuyStockButton.UseVisualStyleBackColor = true;
            this.BuyStockButton.Click += new System.EventHandler(this.BuyStockButton_Click);
            // 
            // QuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.BuyStockButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DailyLow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DailyHigh);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.DateTimeLabel);
            this.Controls.Add(this.DateTimeBox);
            this.Controls.Add(this.StocksListGroup);
            this.Controls.Add(this.ExchangeRadioButtonGroup);
            this.Controls.Add(this.GetQuoteButton);
            this.Name = "QuoteForm";
            this.Text = "Find Quote";
            this.ExchangeRadioButtonGroup.ResumeLayout(false);
            this.ExchangeRadioButtonGroup.PerformLayout();
            this.StocksListGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetQuoteButton;
        private System.Windows.Forms.RadioButton NasdaqRadioButton;
        private System.Windows.Forms.RadioButton NyseRadioButton;
        private System.Windows.Forms.GroupBox ExchangeRadioButtonGroup;
        private System.Windows.Forms.ListBox StockListBox;
        private System.Windows.Forms.GroupBox StocksListGroup;
        private System.Windows.Forms.TextBox DateTimeBox;
        private System.Windows.Forms.Label DateTimeLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DailyHigh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DailyLow;
        private System.Windows.Forms.Button BuyStockButton;
    }
}