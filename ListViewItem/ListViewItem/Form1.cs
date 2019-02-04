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
            listView1.Items.Add("string1");
            listView1.Items.Add("string2");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string subItem = listView1.Items[5].ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string GetListViewItem(int index)
        {
            if (index > 0 && index < listView1.Items.Count)
            {
                return listView1.Items[index].ToString();
            }
            else
            {
                return string.Empty;
            }
        }
    }

   
}
