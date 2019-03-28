using System;
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
            int value = int.Parse(textBox1.Text);  // Issue int.Parse

            MessageBox.Show(value.ToString());

        }

        private int CorrectIntParse(string parse)
        {
            int value = 0;

            int.TryParse(textBox1.Text, out value);

            return value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ret = CorrectIntParse(textBox1.Text);

            MessageBox.Show(ret.ToString());
        }
    }
}
