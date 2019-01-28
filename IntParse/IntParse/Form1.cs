using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntParse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void int_parse_Click(object sender, EventArgs e)
        {
            int value = int.Parse(textBox1.Text);

            //int value = 0;
            //if( int.TryParse(textBox1.Text, out value))
            //{
            //    MessageBox.Show(value.ToString());
            //}
            //else
            //{
            //    value = 0;
            //}
           
        }
    }
}
