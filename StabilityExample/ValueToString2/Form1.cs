using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValueToString2
{
    public partial class Form1 : Form
    {
        public SomeClass smeclass = null;
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(smeclass));
            MessageBox.Show(smeclass.ToString()); // Issue null tostring will crash
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
          
        }
    }
    public class SomeClass
    {

    }

    
}
