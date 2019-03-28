using System;
using System.Windows.Forms;

namespace StabilityExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string sName = textBox1.Text;
            int iPos = sName.IndexOf(".exe", StringComparison.Ordinal);
            string appName = sName.Substring(0, iPos); // Issue IndexOutOfRange

            MessageBox.Show(appName);
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            string sName = textBox1.Text;
            if (String.IsNullOrEmpty(sName))
            {
                MessageBox.Show($"Please Enter a Valid Exe Name");
                return;
            }

            int iPos = sName.IndexOf(".exe", StringComparison.Ordinal);
            if (iPos > 0)
            {
                string appName = sName.Substring(0, iPos);
                MessageBox.Show(appName);
            }
            else
            {
                MessageBox.Show(sName);
            }
        }
    }
}
