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
    public partial class LoginForm : Form
    {

        private static Form _parent;

        public  Form PareForm { get; set; }
        private static LoginForm _loginForm;
        public static LoginForm _LoginForm
        {
            get
            {
                if (_loginForm == null || _loginForm.IsDisposed)
                {
                    LoginForm._loginForm = new LoginForm();
                    _loginForm.TopLevel = false;
                    _loginForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    _loginForm.Dock = DockStyle.Fill;
                    _loginForm.Show();
                }

                return _loginForm;
            }
            set { _loginForm = value; }
        }
        private LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 frm = PareForm as Form1;
            if (frm != null)
            {
                frm.log_closed?.Invoke();
            }
        }
    }
}
