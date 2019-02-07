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
        private static Array _strAaArrays = new String[] {"one", "two", "three", "four"};

        public Form1()
        {
            InitializeComponent();
            foreach (var strAa in _strAaArrays)
            {
                comboBox1.Items.Add(strAa);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem as string;

            int length = selectedItem.Length;

            MessageBox.Show($"{selectedItem} with Length {length}");

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

        private void button2_Click(object sender, EventArgs e)
        {
            var selectItem = GetSelectedItem();
            MessageBox.Show($"{selectItem} with Length {selectItem.Length}");

        }
    }
}
