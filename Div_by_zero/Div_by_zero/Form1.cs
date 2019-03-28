using System;
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
            int numer = 10;
            int denom = 10;

            int.TryParse(textNumerator.Text, out numer); // 
            int.TryParse(textDenom.Text, out denom);

            double division = (double) numer / (double) denom; // Issue DivByZero

            MessageBox.Show($"Result is {division}");


        }

        private int GetSomeNumber(int seed)
        {
            Random rand = new Random(seed);

            return rand.Next(0, 10); // can return from 0 to 10
        }

        private double Divide(int denom, int numer)
        {
            if (denom != 0)
            {
                double result = (double) numer / (double) denom; // 
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

        private void button3_Click(object sender, EventArgs e)
        {
           int denom= GetSomeNumber(20);

           int iVar = 100 / denom; // Issue DivByZero

            MessageBox.Show(iVar.ToString());
        }
    }
}
