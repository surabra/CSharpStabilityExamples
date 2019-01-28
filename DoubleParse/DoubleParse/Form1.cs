using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleParse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox1.Text);

            //double value = 0.0;

            //if(double.TryParse(textBox1.Text, out value))
            //{
            //    MessageBox.Show(value.ToString());
            //}

            MessageBox.Show(value.ToString());
        }
    }
}
