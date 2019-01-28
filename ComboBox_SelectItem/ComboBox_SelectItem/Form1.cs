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
            string selectedItem = (string)comboBox1.SelectedItem;

            int length = selectedItem.Length;


            // Fix

            if(!string.IsNullOrEmpty(selectedItem))
            {
                int len = selectedItem.Length;
            }
            //
        }
    }
}
