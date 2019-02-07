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
            for (int i = 0; i < 10; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
                

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            string subItem = listView1.Items[index].Text;
            MessageBox.Show(subItem);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string GetListViewItem(int index)
        {
            if (index >= 0 && index < listView1.Items.Count)
            {
                return listView1.Items[index].Text;
            }
            else
            {
                return string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string access = GetListViewItem(comboBox1.SelectedIndex);
            if (string.IsNullOrEmpty(access))
            {
                MessageBox.Show($"Error: Trying to access a index {comboBox1.SelectedIndex}");
            }
            else
            {
                MessageBox.Show(access);
            }
            
        }
    }

   
}
