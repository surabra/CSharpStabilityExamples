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
        private string[] strings;
        private ArrayList list;
        public Form1()
        {
            InitializeComponent();
            strings = new string[2];
            strings[0] = "A";
            strings[1] = "B";

            list = new ArrayList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            list.Add("one");
            list.Add("two");

            MessageBox.Show(AccessList(2));

            string listStr = AccessList2(2);
           

          
            string access = AccessArray(2);

            string access2 = AccessArray2(2);
        }

        private string AccessList(int index)
        {
            return (string)list[index];
        }
        private string AccessList2(int index)
        {
            if (index > 0 && index < list.Count)
            {
                return (string) list[index];
            }
            else
            {
                return String.Empty;
                
            }
        }

        private string  AccessArray(int index)
        {
            return strings[index];

           
        }

        private string AccessArray2(int index)
        {
            if (index >= 0 && index < strings.Length)
            {
                return strings[index];
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
