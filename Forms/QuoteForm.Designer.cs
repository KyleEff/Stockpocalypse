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
            System.Windows.Forms.GroupBox _exchangeRadioButtonGroup;
            System.Windows.Forms.GroupBox _stocksListGroup;
            System.Windows.Forms.Label _dateTimeLabel;
            System.Windows.Forms.Label _priceLabel;
            System.Windows.Forms.Label _dailyHighLabel;
            System.Windows.Forms.Label _dailyLowLabel;
            System.Windows.Forms.Button _buyButton;
            System.Windows.Forms.Button _sellButton;
            System.Windows.Forms.Button _exitButton;
            System.Windows.Forms.Label _volumeLabel;
            System.Windows.Forms.Label _dailyPercentChange;
            System.Windows.Forms.TableLayoutPanel _buttonPanel;
            this.NyseRadioButton = new System.Windows.Forms.RadioButton();
            this.NasdaqRadioButton = new System.Windows.Forms.RadioButton();
            this._stockListBox = new System.Windows.Forms.ListBox();
            this.GetQuoteButton = new System.Windows.Forms.Button();
            this._dateTimeBox = new System.Windows.Forms.TextBox();
            this._priceBox = new System.Windows.Forms.TextBox();
            this._dailyHigh = new System.Windows.Forms.TextBox();
            this._dailyLowTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._dailyChangeTextBox = new System.Windows.Forms.TextBox();
            this._volumeTextBox = new System.Windows.Forms.TextBox();
            _exchangeRadioButtonGroup = new System.Windows.Forms.GroupBox();
            _stocksListGroup = new System.Windows.Forms.GroupBox();
            _dateTimeLabel = new System.Windows.Forms.Label();
            _priceLabel = new System.Windows.Forms.Label();
            _dailyHighLabel = new System.Windows.Forms.Label();
            _dailyLowLabel = new System.Windows.Forms.Label();
            _buyButton = new System.Windows.Forms.Button();
            _sellButton = new System.Windows.Forms.Button();
            _exitButton = new System.Windows.Forms.Button();
            _volumeLabel = new System.Windows.Forms.Label();
            _dailyPercentChange = new System.Windows.Forms.Label();
            _buttonPanel = new System.Windows.Forms.TableLayoutPanel();
            _exchangeRadioButtonGroup.SuspendLayout();
            _stocksListGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            _buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _exchangeRadioButtonGroup
            // 
            _exchangeRadioButtonGroup.Controls.Add(this.NyseRadioButton);
            _exchangeRadioButtonGroup.Controls.Add(this.NasdaqRadioButton);
            _exchangeRadioButtonGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _exchangeRadioButtonGroup.Location = new System.Drawing.Point(12, 12);
            _exchangeRadioButtonGroup.Name = "_exchangeRadioButtonGroup";
            _exchangeRadioButtonGroup.Size = new System.Drawing.Size(103, 70);
            _exchangeRadioButtonGroup.TabIndex = 6;
            _exchangeRadioButtonGroup.TabStop = false;
            _exchangeRadioButtonGroup.Text = "Exchange";
            // 
            // NyseRadioButton
            // 
            this.NyseRadioButton.AutoSize = true;
            this.NyseRadioButton.Checked = true;
            this.NyseRadioButton.Location = new System.Drawing.Point(6, 19);
            this.NyseRadioButton.Name = "NyseRadioButton";
            this.NyseRadioButton.Size = new System.Drawing.Size(66, 20);
            this.NyseRadioButton.TabIndex = 5;
            this.NyseRadioButton.TabStop = true;
            this.NyseRadioButton.Text = "NYSE";
            this.NyseRadioButton.UseVisualStyleBackColor = true;
            this.NyseRadioButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NyseRadioButton_MouseClick);
            // 
            // NasdaqRadioButton
            // 
            this.NasdaqRadioButton.AutoSize = true;
            this.NasdaqRadioButton.Location = new System.Drawing.Point(6, 42);
            this.NasdaqRadioButton.Name = "NasdaqRadioButton";
            this.NasdaqRadioButton.Size = new System.Drawing.Size(88, 20);
            this.NasdaqRadioButton.TabIndex = 4;
            this.NasdaqRadioButton.Text = "NASDAQ";
            this.NasdaqRadioButton.UseVisualStyleBackColor = true;
            this.NasdaqRadioButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NasdaqRadioButton_MouseClick);
            // 
            // _stocksListGroup
            // 
            _stocksListGroup.Controls.Add(this._stockListBox);
            _stocksListGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _stocksListGroup.Location = new System.Drawing.Point(121, 12);
            _stocksListGroup.Name = "_stocksListGroup";
            _stocksListGroup.Size = new System.Drawing.Size(754, 259);
            _stocksListGroup.TabIndex = 8;
            _stocksListGroup.TabStop = false;
            _stocksListGroup.Text = "Stock List";
            // 
            // _stockListBox
            // 
            this._stockListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._stockListBox.FormattingEnabled = true;
            this._stockListBox.ItemHeight = 15;
            this._stockListBox.Location = new System.Drawing.Point(6, 19);
            this._stockListBox.Name = "_stockListBox";
            this._stockListBox.Size = new System.Drawing.Size(742, 229);
            this._stockListBox.TabIndex = 7;
            this._stockListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StockListBox_MouseClick);
            // 
            // _dateTimeLabel
            // 
            _dateTimeLabel.AutoSize = true;
            _dateTimeLabel.Location = new System.Drawing.Point(6, 22);
            _dateTimeLabel.Name = "_dateTimeLabel";
            _dateTimeLabel.Size = new System.Drawing.Size(92, 16);
            _dateTimeLabel.TabIndex = 10;
            _dateTimeLabel.Text = "Date / Time:";
            // 
            // _priceLabel
            // 
            _priceLabel.AutoSize = true;
            _priceLabel.Location = new System.Drawing.Point(47, 50);
            _priceLabel.Name = "_priceLabel";
            _priceLabel.Size = new System.Drawing.Size(47, 16);
            _priceLabel.TabIndex = 12;
            _priceLabel.Text = "Price:";
            // 
            // _dailyHighLabel
            // 
            _dailyHighLabel.AutoSize = true;
            _dailyHighLabel.Location = new System.Drawing.Point(341, 22);
            _dailyHighLabel.Name = "_dailyHighLabel";
            _dailyHighLabel.Size = new System.Drawing.Size(83, 16);
            _dailyHighLabel.TabIndex = 14;
            _dailyHighLabel.Text = "Daily High:";
            // 
            // _dailyLowLabel
            // 
            _dailyLowLabel.AutoSize = true;
            _dailyLowLabel.Location = new System.Drawing.Point(346, 50);
            _dailyLowLabel.Name = "_dailyLowLabel";
            _dailyLowLabel.Size = new System.Drawing.Size(78, 16);
            _dailyLowLabel.TabIndex = 16;
            _dailyLowLabel.Text = "Daily Low:";
            // 
            // _buyButton
            // 
            _buyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            _buyButton.Location = new System.Drawing.Point(3, 3);
            _buyButton.Name = "_buyButton";
            _buyButton.Size = new System.Drawing.Size(281, 46);
            _buyButton.TabIndex = 0;
            _buyButton.Text = "BUY STOCK";
            _buyButton.UseVisualStyleBackColor = true;
            _buyButton.Click += new System.EventHandler(this.BuyStockButton_Click);
            // 
            // _sellButton
            // 
            _sellButton.Dock = System.Windows.Forms.DockStyle.Fill;
            _sellButton.Location = new System.Drawing.Point(290, 3);
            _sellButton.Name = "_sellButton";
            _sellButton.Size = new System.Drawing.Size(281, 46);
            _sellButton.TabIndex = 1;
            _sellButton.Text = "SELL STOCK";
            _sellButton.UseVisualStyleBackColor = true;
            // 
            // _exitButton
            // 
            _exitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            _exitButton.Location = new System.Drawing.Point(577, 3);
            _exitButton.Name = "_exitButton";
            _exitButton.Size = new System.Drawing.Size(282, 46);
            _exitButton.TabIndex = 2;
            _exitButton.Text = "EXIT";
            _exitButton.UseVisualStyleBackColor = true;
            // 
            // _volumeLabel
            // 
            _volumeLabel.AutoSize = true;
            _volumeLabel.Location = new System.Drawing.Point(31, 78);
            _volumeLabel.Name = "_volumeLabel";
            _volumeLabel.Size = new System.Drawing.Size(63, 16);
            _volumeLabel.TabIndex = 18;
            _volumeLabel.Text = "Volume:";
            // 
            // _dailyPercentChange
            // 
            _dailyPercentChange.AutoSize = true;
            _dailyPercentChange.Location = new System.Drawing.Point(320, 78);
            _dailyPercentChange.Name = "_dailyPercentChange";
            _dailyPercentChange.Size = new System.Drawing.Size(104, 16);
            _dailyPercentChange.TabIndex = 20;
            _dailyPercentChange.Text = "Daily Change:";
            // 
            // GetQuoteButton
            // 
            this.GetQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetQuoteButton.Location = new System.Drawing.Point(12, 130);
            this.GetQuoteButton.Name = "GetQuoteButton";
            this.GetQuoteButton.Size = new System.Drawing.Size(103, 53);
            this.GetQuoteButton.TabIndex = 3;
            this.GetQuoteButton.Text = "GET QUOTE";
            this.GetQuoteButton.UseVisualStyleBackColor = true;
            this.GetQuoteButton.Click += new System.EventHandler(this.GetQuoteButton_Click);
            // 
            // _dateTimeBox
            // 
            this._dateTimeBox.Location = new System.Drawing.Point(101, 19);
            this._dateTimeBox.Name = "_dateTimeBox";
            this._dateTimeBox.ReadOnly = true;
            this._dateTimeBox.Size = new System.Drawing.Size(179, 22);
            this._dateTimeBox.TabIndex = 9;
            // 
            // _priceBox
            // 
            this._priceBox.Location = new System.Drawing.Point(101, 47);
            this._priceBox.Name = "_priceBox";
            this._priceBox.ReadOnly = true;
            this._priceBox.Size = new System.Drawing.Size(124, 22);
            this._priceBox.TabIndex = 11;
            // 
            // _dailyHigh
            // 
            this._dailyHigh.Location = new System.Drawing.Point(430, 19);
            this._dailyHigh.Name = "_dailyHigh";
            this._dailyHigh.ReadOnly = true;
            this._dailyHigh.Size = new System.Drawing.Size(124, 22);
            this._dailyHigh.TabIndex = 13;
            // 
            // _dailyLowTextBox
            // 
            this._dailyLowTextBox.Location = new System.Drawing.Point(430, 47);
            this._dailyLowTextBox.Name = "_dailyLowTextBox";
            this._dailyLowTextBox.ReadOnly = true;
            this._dailyLowTextBox.Size = new System.Drawing.Size(124, 22);
            this._dailyLowTextBox.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(_dailyPercentChange);
            this.groupBox1.Controls.Add(this._dailyChangeTextBox);
            this.groupBox1.Controls.Add(this._volumeTextBox);
            this.groupBox1.Controls.Add(_volumeLabel);
            this.groupBox1.Controls.Add(this._dateTimeBox);
            this.groupBox1.Controls.Add(_dateTimeLabel);
            this.groupBox1.Controls.Add(_dailyLowLabel);
            this.groupBox1.Controls.Add(this._priceBox);
            this.groupBox1.Controls.Add(this._dailyLowTextBox);
            this.groupBox1.Controls.Add(_priceLabel);
            this.groupBox1.Controls.Add(_dailyHighLabel);
            this.groupBox1.Controls.Add(this._dailyHigh);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 111);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quote Results";
            // 
            // _dailyChangeTextBox
            // 
            this._dailyChangeTextBox.Location = new System.Drawing.Point(430, 75);
            this._dailyChangeTextBox.Name = "_dailyChangeTextBox";
            this._dailyChangeTextBox.ReadOnly = true;
            this._dailyChangeTextBox.Size = new System.Drawing.Size(124, 22);
            this._dailyChangeTextBox.TabIndex = 19;
            // 
            // _volumeTextBox
            // 
            this._volumeTextBox.Location = new System.Drawing.Point(101, 75);
            this._volumeTextBox.Name = "_volumeTextBox";
            this._volumeTextBox.ReadOnly = true;
            this._volumeTextBox.Size = new System.Drawing.Size(124, 22);
            this._volumeTextBox.TabIndex = 17;
            // 
            // _buttonPanel
            // 
            _buttonPanel.ColumnCount = 3;
            _buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            _buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            _buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            _buttonPanel.Controls.Add(_sellButton, 1, 0);
            _buttonPanel.Controls.Add(_buyButton, 0, 0);
            _buttonPanel.Controls.Add(_exitButton, 2, 0);
            _buttonPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _buttonPanel.Location = new System.Drawing.Point(13, 397);
            _buttonPanel.Name = "_buttonPanel";
            _buttonPanel.RowCount = 1;
            _buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            _buttonPanel.Size = new System.Drawing.Size(862, 52);
            _buttonPanel.TabIndex = 19;
            // 
            // QuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 461);
            this.Controls.Add(_buttonPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(_stocksListGroup);
            this.Controls.Add(_exchangeRadioButtonGroup);
            this.Controls.Add(this.GetQuoteButton);
            this.Name = "QuoteForm";
            this.Text = "Find Quote";
            _exchangeRadioButtonGroup.ResumeLayout(false);
            _exchangeRadioButtonGroup.PerformLayout();
            _stocksListGroup.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            _buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetQuoteButton;
        private System.Windows.Forms.RadioButton NasdaqRadioButton;
        private System.Windows.Forms.RadioButton NyseRadioButton;
        private System.Windows.Forms.ListBox _stockListBox;
        private System.Windows.Forms.TextBox _dateTimeBox;
        private System.Windows.Forms.TextBox _priceBox;
        private System.Windows.Forms.TextBox _dailyHigh;
        private System.Windows.Forms.TextBox _dailyLowTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _dailyChangeTextBox;
        private System.Windows.Forms.TextBox _volumeTextBox;
    }
}