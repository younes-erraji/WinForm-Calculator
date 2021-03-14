using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcul
{
    public partial class FormCalcul : Form
    {
        string op;
        double x;
        public FormCalcul()
        {
            InitializeComponent();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbresult.Text = "0";
        }
        private void btnV_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (tbresult.Text == "0")
                tbresult.Clear();
            tbresult.Text = tbresult.Text + b.Text;
            if (tbresult.Text == "." && b.Text == ".")
                tbresult.Text = "0.";
        }

        private void btnsous_Click(object sender, EventArgs e)
        {
            
            Button b = (Button)sender;
            if (tbresult.Text != "" && label.Text != "")
                btnegal.PerformClick();
            op = b.Text;
            x = double.Parse(tbresult.Text);
            label.Text = tbresult.Text + " " + op;
            tbresult.Clear();
            
        }

        private void btnegal_Click(object sender, EventArgs e)
        {
            switch(op)
            {
                case "+": {
                        double n = Convert.ToDouble(tbresult.Text);
                        tbresult.Text=(x + n).ToString();
                        label.Text = "";
                          }
                    break;
                case "-":
                    {
                        double n = Convert.ToDouble(tbresult.Text);
                        tbresult.Text =(x - n).ToString();
                        label.Text = "";
                    }
                    break;
                case "*":
                    {
                        double n = Convert.ToDouble(tbresult.Text);
                        tbresult.Text =(x * n).ToString();
                        label.Text = "";
                    }
                    break;
                case "/":
                    {
                        double n = Convert.ToDouble(tbresult.Text);
                        tbresult.Text =(x / n).ToString();
                        label.Text = "";
                    }
                    break;
            }
        }

        private void tbresult_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '+': e.Handled = true; btnplus.PerformClick(); break;
                case '-': e.Handled = true; btnsous.PerformClick(); break;
                case '*': e.Handled = true; btnmult.PerformClick(); break;
                case '/': e.Handled = true; btndiv.PerformClick(); break;
                case (char)Keys.Enter: e.Handled = true; btnegal.PerformClick(); break;
                case (char)Keys.Back:
                case '1':
                case '2': 
                case '3': 
                case '4': 
                case '5': 
                case '6': 
                case '7': 
                case '8': 
                case '9': 
                case '0': e.Handled = false; break;
                default: e.Handled = true;
                    MessageBox.Show("Enter the number only"); break;
            }
        }
    }
}