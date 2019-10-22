namespace Form9_3
{
    partial class FormFutureValue9_3
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
            this.labelMonthlyInvestment = new System.Windows.Forms.Label();
            this.labelInterestRate = new System.Windows.Forms.Label();
            this.labelFutureValue = new System.Windows.Forms.Label();
            this.labelNumberOfYears = new System.Windows.Forms.Label();
            this.textBoxMonthlyInvestment = new System.Windows.Forms.TextBox();
            this.textBoxInterestRate = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfYears = new System.Windows.Forms.TextBox();
            this.textBoxFutureValue = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMonthlyInvestment
            // 
            this.labelMonthlyInvestment.AutoSize = true;
            this.labelMonthlyInvestment.Location = new System.Drawing.Point(27, 16);
            this.labelMonthlyInvestment.Name = "labelMonthlyInvestment";
            this.labelMonthlyInvestment.Size = new System.Drawing.Size(102, 13);
            this.labelMonthlyInvestment.TabIndex = 0;
            this.labelMonthlyInvestment.Text = "Monthly Investment:";
            // 
            // labelInterestRate
            // 
            this.labelInterestRate.AutoSize = true;
            this.labelInterestRate.Location = new System.Drawing.Point(27, 43);
            this.labelInterestRate.Name = "labelInterestRate";
            this.labelInterestRate.Size = new System.Drawing.Size(103, 13);
            this.labelInterestRate.TabIndex = 1;
            this.labelInterestRate.Text = "Yearly Interest Rate:";
            // 
            // labelFutureValue
            // 
            this.labelFutureValue.AutoSize = true;
            this.labelFutureValue.Location = new System.Drawing.Point(59, 95);
            this.labelFutureValue.Name = "labelFutureValue";
            this.labelFutureValue.Size = new System.Drawing.Size(70, 13);
            this.labelFutureValue.TabIndex = 3;
            this.labelFutureValue.Text = "Future Value:";
            // 
            // labelNumberOfYears
            // 
            this.labelNumberOfYears.AutoSize = true;
            this.labelNumberOfYears.Location = new System.Drawing.Point(40, 69);
            this.labelNumberOfYears.Name = "labelNumberOfYears";
            this.labelNumberOfYears.Size = new System.Drawing.Size(89, 13);
            this.labelNumberOfYears.TabIndex = 2;
            this.labelNumberOfYears.Text = "Number of Years:";
            // 
            // textBoxMonthlyInvestment
            // 
            this.textBoxMonthlyInvestment.Location = new System.Drawing.Point(135, 13);
            this.textBoxMonthlyInvestment.Name = "textBoxMonthlyInvestment";
            this.textBoxMonthlyInvestment.Size = new System.Drawing.Size(100, 20);
            this.textBoxMonthlyInvestment.TabIndex = 1;
            // 
            // textBoxInterestRate
            // 
            this.textBoxInterestRate.Location = new System.Drawing.Point(135, 40);
            this.textBoxInterestRate.Name = "textBoxInterestRate";
            this.textBoxInterestRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxInterestRate.TabIndex = 2;
            // 
            // textBoxNumberOfYears
            // 
            this.textBoxNumberOfYears.Location = new System.Drawing.Point(135, 66);
            this.textBoxNumberOfYears.Name = "textBoxNumberOfYears";
            this.textBoxNumberOfYears.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberOfYears.TabIndex = 3;
            // 
            // textBoxFutureValue
            // 
            this.textBoxFutureValue.Location = new System.Drawing.Point(135, 92);
            this.textBoxFutureValue.Name = "textBoxFutureValue";
            this.textBoxFutureValue.ReadOnly = true;
            this.textBoxFutureValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxFutureValue.TabIndex = 800;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(62, 118);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(92, 23);
            this.buttonCalculate.TabIndex = 9;
            this.buttonCalculate.Text = "&Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(160, 118);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // FormFutureValue9_3
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(259, 150);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxFutureValue);
            this.Controls.Add(this.textBoxNumberOfYears);
            this.Controls.Add(this.textBoxInterestRate);
            this.Controls.Add(this.textBoxMonthlyInvestment);
            this.Controls.Add(this.labelFutureValue);
            this.Controls.Add(this.labelNumberOfYears);
            this.Controls.Add(this.labelInterestRate);
            this.Controls.Add(this.labelMonthlyInvestment);
            this.Name = "FormFutureValue9_3";
            this.Text = "Future Value";
            this.Load += new System.EventHandler(this.FormFutureValue9_3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMonthlyInvestment;
        private System.Windows.Forms.Label labelInterestRate;
        private System.Windows.Forms.Label labelFutureValue;
        private System.Windows.Forms.Label labelNumberOfYears;
        private System.Windows.Forms.TextBox textBoxMonthlyInvestment;
        private System.Windows.Forms.TextBox textBoxInterestRate;
        private System.Windows.Forms.TextBox textBoxNumberOfYears;
        private System.Windows.Forms.TextBox textBoxFutureValue;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonExit;
    }
}

