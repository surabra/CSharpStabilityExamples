using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


            char sChar = Strings.Chr(300);

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
