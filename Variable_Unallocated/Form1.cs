using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variable_Unallocated
{
    public partial class Form1 : Form
    {
        private bool bShutDown;

        public Form1()
        {
            InitializeComponent();
            bShutDown = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (bShutDown)
            {
                // List<Form> formlist; // This will be caught by the compiler. error CS0165: Use of unassigned local variable 'formlist'
                List<Form> formlist = null; // Complier will be happy with this. However the variable is pointing to a null object.
                foreach (Form frm in System.Windows.Forms.Application.OpenForms)
                {
                    formlist.Add(frm);
                }
                foreach (Form form in formlist)
                {
                    form.Close();
                }
            }
        }
    }
}
