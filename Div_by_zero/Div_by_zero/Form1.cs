using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Div_by_zero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numer = 0;
            int denom = 0;

            int.TryParse(textNumerator.Text, out numer);
            int.TryParse(textDenom.Text, out denom);

            double division = (double) numer / (double) denom;

            MessageBox.Show($"Result is {division}");


        }

        private double Divide(int denom, int numer)
        {
            if (denom != 0)
            {
                double result = (double) numer / (double) denom;
                return result;
            }
            else
            {
                return 0.0;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numer = 0;
            int denom = 0;

            int.TryParse(textNumerator.Text, out numer);
            int.TryParse(textDenom.Text, out denom);

            if (denom != 0)
            {
                double division = (double) numer / (double) denom;

                MessageBox.Show($"Result is {division}");
            }
            else
            {
                MessageBox.Show($"Impossible. Denominator is {textDenom.Text}");
            }
        }
    }
}
