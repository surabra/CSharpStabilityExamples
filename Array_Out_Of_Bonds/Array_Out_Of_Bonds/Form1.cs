using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Array_Out_Of_Bonds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();

            list.Add("one");
            list.Add("two");
           
            // ArgumentOutOfRangeException
            MessageBox.Show((string)list[2]);

            //int index = 2;
            //if(index >=0 && index < list.Count)
            //{
            //    MessageBox.Show((string)list[index]);
            //}
            //else
            //{
            //    MessageBox.Show("Index out of Range");
            //}

        }
    }
}
