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

        private void next_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(inputNumber.Text);
            double Percent = Convert.ToDouble(inputPercentNumber.Text);

            outputNumber.Text = Convert.ToString(num / 100 * Percent);
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
    }
}
