using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

using calculator;

namespace CalculatorFrac
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Text = "Fraction Calculator";
            SetDefault(equalsButton);
            numerator1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            numerator2.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            denominator1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            denominator2.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            addButton.CheckedChanged += new System.EventHandler(this.textBox_TextChanged);
            subtractButton.CheckedChanged += new System.EventHandler(this.textBox_TextChanged);
            divideButton.CheckedChanged += new System.EventHandler(this.textBox_TextChanged);
            multiplyButton.CheckedChanged += new System.EventHandler(this.textBox_TextChanged);

        }

        //add
        private void addButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        //numerator1
        private void numerator1_TextChanged(object sender, EventArgs e)
        {
            
        }

        //numerator2
        private void numerator2_TextChanged(object sender, EventArgs e)
        {

        }

        //denominator1
        private void denominator1_TextChanged(object sender, EventArgs e)
        {

        }

        //denominator2
        private void denominator2_TextChanged(object sender, EventArgs e)
        {

        }

        //subtract
        private void subtractButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        //multiply
        private void multiplyButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        //divide
        private void divideButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        //equals
        private void equalsButton_Click(object sender, EventArgs e)
        {
            int n;
            bool isNumeric = (int.TryParse((this.numerator1.Text), out n) && int.TryParse((this.numerator2.Text), out n)
                && int.TryParse((this.denominator1.Text), out n) && int.TryParse((this.denominator2.Text), out n));
            if ((String.IsNullOrEmpty(this.numerator1.Text)) || (String.IsNullOrEmpty(this.numerator2.Text)) ||
                (String.IsNullOrEmpty(this.denominator1.Text)) || (String.IsNullOrEmpty(this.denominator2.Text)) ||
                (isNumeric == false))
            {
                MessageBox.Show("Must enter a valid number in each field.", "Fraction Calculator Error",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            else if(((Int32.Parse(this.denominator1.Text)) == 0) || ((Int32.Parse(this.denominator2.Text)) == 0))
            { 
                MessageBox.Show("Denominator can not be zero.", "Fraction Calculator Error",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            else if(!(addButton.Checked) && !(subtractButton.Checked) &&
                    !(multiplyButton.Checked) && !(divideButton.Checked))
            {
                MessageBox.Show("Please choose an operator.", "Fraction Calculator Error",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            else
            {
                int num1 = Int32.Parse(this.numerator1.Text);
                int num2 = Int32.Parse(this.numerator2.Text);
                int den1 = Int32.Parse(this.denominator1.Text);
                int den2 = Int32.Parse(this.denominator2.Text);

                Fraction frac1 = new Fraction(num1, den1);
                Fraction frac2 = new Fraction(num2, den2);

                string answer = "none";
                Fraction ans;
                answerField.Visible = true;
                
                if (addButton.Checked)
                {
                    ans = frac1 + frac2;
                    answer = (ans.numerator().ToString()) + "/" + (ans.denominator().ToString());
                }
                else if (subtractButton.Checked)
                {
                    ans = frac1 - frac2;
                    answer = (ans.numerator().ToString()) + "/" + (ans.denominator().ToString());
                }
                else if (multiplyButton.Checked)
                {
                    ans = frac1 * frac2;
                    answer = (ans.numerator().ToString()) + "/" + (ans.denominator().ToString());
                }
                else if (divideButton.Checked)
                {
                    ans = frac1 / frac2;
                    answer = (ans.numerator().ToString()) + "/" + (ans.denominator().ToString());
                }

                answerField.Text = answer;
            }
        }

        //answer
        private void answerField_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SetDefault(Button myDefaultBtn)
        {
            this.AcceptButton = myDefaultBtn;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.C))
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            answerField.Text = " ";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
