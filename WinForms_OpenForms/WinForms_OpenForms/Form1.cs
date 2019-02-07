using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_OpenForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new WinForms_OpenForms.Form1();
           
            frm.Show(this);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // If forms are opened this will crash with InvalidOperationException

            foreach (Form1 frm in System.Windows.Forms.Application.OpenForms)
            {
                frm.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Proper code
            List<Form> openform = new List<Form>();
            foreach (Form frm in System.Windows.Forms.Application.OpenForms)
            {
                openform.Add(frm);
            }

            foreach (Form frm in openform)
            {
                frm.Close();
            }

        }
    }
}
