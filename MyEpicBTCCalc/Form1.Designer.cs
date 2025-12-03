namespace MyEpicBTCCalc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bitcoingAmountInput = new TextBox();
            btcLabel = new Label();
            currencySelector = new ComboBox();
            toCurrencyLabel = new Label();
            getRate = new Button();
            bitcoinResultLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // bitcoingAmountInput
            // 
            bitcoingAmountInput.Location = new Point(137, 50);
            bitcoingAmountInput.Name = "bitcoingAmountInput";
            bitcoingAmountInput.Size = new Size(156, 23);
            bitcoingAmountInput.TabIndex = 0;
            // 
            // btcLabel
            // 
            btcLabel.AutoSize = true;
            btcLabel.BackColor = Color.Transparent;
            btcLabel.ForeColor = SystemColors.ActiveCaptionText;
            btcLabel.Location = new Point(137, 32);
            btcLabel.Name = "btcLabel";
            btcLabel.Size = new Size(82, 15);
            btcLabel.TabIndex = 1;
            btcLabel.Text = "Bitcoini kogus";
            // 
            // currencySelector
            // 
            currencySelector.FormattingEnabled = true;
            currencySelector.Items.AddRange(new object[] { "EUR", "USD" });
            currencySelector.Location = new Point(137, 119);
            currencySelector.Name = "currencySelector";
            currencySelector.Size = new Size(156, 23);
            currencySelector.TabIndex = 2;
            currencySelector.Text = "USD";
            currencySelector.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // toCurrencyLabel
            // 
            toCurrencyLabel.AutoSize = true;
            toCurrencyLabel.BackColor = Color.Transparent;
            toCurrencyLabel.ForeColor = SystemColors.ActiveCaptionText;
            toCurrencyLabel.Location = new Point(137, 101);
            toCurrencyLabel.Name = "toCurrencyLabel";
            toCurrencyLabel.Size = new Size(66, 15);
            toCurrencyLabel.TabIndex = 3;
            toCurrencyLabel.Text = "Sihtvaluuta";
            // 
            // getRate
            // 
            getRate.Location = new Point(218, 214);
            getRate.Name = "getRate";
            getRate.Size = new Size(75, 23);
            getRate.TabIndex = 4;
            getRate.Text = "Arvuta";
            getRate.UseVisualStyleBackColor = true;
            getRate.Click += getRate_Click;
            // 
            // bitcoinResultLabel
            // 
            bitcoinResultLabel.AutoSize = true;
            bitcoinResultLabel.BackColor = Color.Transparent;
            bitcoinResultLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 186);
            bitcoinResultLabel.ForeColor = SystemColors.ActiveCaptionText;
            bitcoinResultLabel.Location = new Point(26, 454);
            bitcoinResultLabel.Name = "bitcoinResultLabel";
            bitcoinResultLabel.Size = new Size(78, 32);
            bitcoinResultLabel.TabIndex = 5;
            bitcoinResultLabel.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(26, 439);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 6;
            label1.Text = "Arvutuse tulemus:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(480, 518);
            Controls.Add(label1);
            Controls.Add(bitcoinResultLabel);
            Controls.Add(getRate);
            Controls.Add(toCurrencyLabel);
            Controls.Add(currencySelector);
            Controls.Add(btcLabel);
            Controls.Add(bitcoingAmountInput);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox bitcoingAmountInput;
        private Label btcLabel;
        private ComboBox currencySelector;
        private Label toCurrencyLabel;
        private Button getRate;
        private Label bitcoinResultLabel;
        private Label label1;
    }
}
