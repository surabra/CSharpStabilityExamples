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

namespace ListViewItemName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string name = string.Empty;
            String strObj = (String)comboBox1.SelectedItem;
            string str = strObj.Substring(0, strObj.Length - 1);

            //String strObj2 = (string)comboBox1.SelectedItem;
            //if(!String.IsNullOrEmpty(strObj2))
            //{
            //    string strs2 = strObj2.Substring(0, strObj2.Length - 1);
            //}


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

   
}
