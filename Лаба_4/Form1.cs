using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //inputPercentNumber.Text
        private void next_Click(object sender, EventArgs e)
        {
            byte error = 0;
            byte counter = 0;
            /*while (error == 0)
            {
                error = 0;
                if (String.IsNullOrEmpty(inputPercentNumber.Text))
                {
                    Error.Visible = true;
                    inputPercentNumber.BackColor = Color.Red;
                }

                if (String.IsNullOrEmpty(inputNumber.Text))
                {
                    Error.Visible = true;
                    inputNumber.BackColor = Color.Red;
                }
                else
                {
                    error++; 
                }
                
            }*/
            
            if (!String.IsNullOrEmpty(inputPercentNumber.Text) || !String.IsNullOrEmpty(inputNumber.Text))
            {
                string str = inputPercentNumber.Text;
                double num = Convert.ToDouble(inputNumber.Text);
                double Percent = Convert.ToDouble(inputPercentNumber.Text);

                outputNumber.Text = Convert.ToString(num / 100 * Percent); 
            }
            else
            {

                MessageBox.Show("Вы не ввели одно или несколько значений", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                /*if (String.IsNullOrEmpty(inputPercentNumber.Text))
                {
                    Error.Visible = true;
                    inputPercentNumber.BackColor = Color.Red;
                }

                if (String.IsNullOrEmpty(inputNumber.Text))
                {
                    Error.Visible = true;
                    inputNumber.BackColor = Color.Red;
                }*/
            }

            
        }

        private void reset_Click(object sender, EventArgs e)
        {
            inputNumber.Clear();
            inputPercentNumber.Clear();
            outputNumber.Clear();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == (char)Keys.Enter)
            {
                next_Click(next, null);
            }
        }

        private void inputPercentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void inputPercentNumber_Enter(object sender, EventArgs e)
        {
            Error.Visible = false;
            inputPercentNumber.BackColor = Color.White;
            inputNumber.BackColor = Color.White;
        }
    }
}
