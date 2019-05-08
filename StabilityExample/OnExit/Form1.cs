using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnExit
{
    public delegate void LoginForm_Closed();
    public partial class Form1 : Form
    {
        public LoginForm_Closed log_closed;

        private LoginForm _LoginForm;

        public LoginForm logForm
        {
            get { return _LoginForm; }
            set { _LoginForm = value; }
           
        }

        public Form1()
        {
            
            InitializeComponent();

            log_closed += Log_Closed;
            this.panel1.Controls.Add(LoginForm._LoginForm);
            logForm = LoginForm._LoginForm;
            logForm.PareForm = this;
        }

        private void Log_Closed()
        {
            _LoginForm = null;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _LoginForm.Dispose();

        }
    }
}
