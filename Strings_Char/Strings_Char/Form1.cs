using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Strings_Char
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            char sChar = Strings.Chr(300); // Issue Stringd.Chr

            MessageBox.Show(sChar.ToString());
        }

        private char CorrectCode(int charCode)
        {
            char convertChar = Convert.ToChar(charCode);
            return convertChar;
        }

        private void ProperAccess_Click(object sender, EventArgs e)
        {
            char correct = CorrectCode(300);

            MessageBox.Show(correct.ToString());
        }
    }
}
