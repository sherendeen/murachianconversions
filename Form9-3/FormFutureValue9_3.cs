using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form9_3
{
    public partial class FormFutureValue9_3 : Form
    {
        public FormFutureValue9_3()
        {
            InitializeComponent();
        }

        private void FormFutureValue9_3_Load(object sender, EventArgs e)
        {

        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {

            try
            {
                if (IsValidData())
                {
                    decimal monthlyInvestment = decimal.Parse(textBoxMonthlyInvestment.Text, NumberStyles.Currency);
                    decimal yearlyInterestRate = decimal.Parse(textBoxInterestRate.Text);
                    int years = int.Parse(textBoxNumberOfYears.Text);
                    decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

                    int months = years * 12;
                    decimal futureValue = GetFutureValue(monthlyInvestment, monthlyInterestRate, months);

                    // there does not exist a FormatCurrency() function in C#
                    // This functionality of the ToString method also exists in VB.NET but
                    // it is normal to use FormatCurrency
                    textBoxFutureValue.Text = futureValue.ToString("C");
                    // @see https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
                }
            }
            catch (OverflowException ex)
            {

                // in C# you cannot simply leave off the parentheses of a method
                MessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine +
                    ex.GetType().ToString() + Environment.NewLine + Environment.NewLine + 
                    ex.StackTrace, "An overflow exception has occured!");
                // also observe that we have to go out of our way to use plus symbols
                // instead of ampersands because c# does not like it
            }
            catch (Exception ex)
            {
                // it would have been significantly cleaner to use interpolated strings
                // and both languages both possess this feature
                MessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine + 
                    ex.GetType().ToString() +Environment.NewLine + Environment.NewLine +
                    ex.StackTrace, "Exception");
            }

        }

        private bool IsValidData()
        {
            return
                IsPresent(textBoxMonthlyInvestment, "Monthly Investment") && 
                IsCurrency(textBoxMonthlyInvestment, "Monthly Investment") &&
                IsWithinRange(textBoxMonthlyInvestment, "Monthly Investment", 1, 1000) && 
                IsPresent(textBoxInterestRate, "Yearly Interest Rate") &&
                IsDecimal(textBoxInterestRate, "Yearly Interest Rate") &&
                IsWithinRange(textBoxInterestRate, "Yearly Interest Rate", 1, 15) &&
                IsPresent(textBoxNumberOfYears, "Number of Years") &&
                IsInt32(textBoxNumberOfYears, "Number of Years") &&
                IsWithinRange(textBoxNumberOfYears, "Number of Years", 1, 50);
            // one of the refreshing parts about c# is that you don't need to use underscores
            // in order to break up statements
            // onto multiple lines. C# does not care a whole lot about spacing
        }

        private bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Select();
                return false;
            }
            return true;
        }

        //

        private bool IsCurrency(TextBox textBox, string name)
        {
            decimal number = 0.0M;
            if (decimal.TryParse(textBox.Text,NumberStyles.Currency,CultureInfo.CurrentCulture, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a currency value.", "Entry Error");
                textBox.Select();
                textBox.SelectAll();
                return false;
            }
        }

        private bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0.0M;
            if (decimal.TryParse(textBox.Text,NumberStyles.Number,CultureInfo.CurrentCulture,out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a decimal value.", "Entry Error");
                textBox.Select();
                textBox.SelectAll();
                return false;
            }
        }

        private bool IsInt32(TextBox textBox, string name)
        {
            int number = 0;
            if (int.TryParse(textBox.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be an integer.", "Entry Error");
                textBox.Select();
                textBox.SelectAll();
                return false;
            }
        }

        private bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal number = decimal.Parse(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between "+ min +" and "
                    + max + ".", "Entry Error");
                textBox.Select();
                textBox.SelectAll();
                return false;
            }
            return true;
        }

        private decimal GetFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0.0m;
            for(int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }
    }
}
