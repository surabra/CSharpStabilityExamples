using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_SelectItem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem as string;

            int length = selectedItem.Length;


            // Fix

            if(!string.IsNullOrEmpty(selectedItem))
            {
                int len = selectedItem.Length;
            }
            
        }

        private string GetSelectedItem()
        {
            if (comboBox1.SelectedItem != null)
            {
                return (string) comboBox1.SelectedItem;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
