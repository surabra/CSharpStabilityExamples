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
        // 1-000000141571
        // ORDPLANDEV-17563
        // 595844
        private void button1_Click(object sender, EventArgs e)
        {
            string sName = $"{sender.ToString()} {e.ToString()}";

            int iPos = sName.IndexOf("sender");

            string str = sName.Substring(iPos, 3);


        }

        private void corrrectCode()
        {
            string sName = "Some string";
            int iPos = sName.IndexOf("anything");

            if (iPos != -1)
            {
                string str = sName.Substring(iPos, 3);

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
