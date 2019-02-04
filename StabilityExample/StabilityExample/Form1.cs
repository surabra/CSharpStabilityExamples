using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string sName = $"{sender.ToString()} {e.ToString()}";
            int iPos = sName.IndexOf("sender", StringComparison.Ordinal);
            string str = sName.Substring(iPos, 3);

            correctCode();
        }

        private void correctCode()
        {
            string sName = "Some string";
            int iPos = sName.IndexOf("anything");

            if (iPos != -1)
            {
                string str = sName.Substring(iPos, 3);
                Console.WriteLine(str);
            }
        }

        private void correctCode2()
        {
            string sName = "Some string";
            int iPos = sName.IndexOf("anything");
            try
            {
                string str = sName.Substring(iPos, 3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }
             

            
        }
    }
}
