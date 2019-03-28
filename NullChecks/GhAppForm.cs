using System;
using System.Windows.Forms;

namespace NullChecks
{
    public partial class GhAppForm : Form
    {
        public GhAppForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Hide();
        }
    }
}
