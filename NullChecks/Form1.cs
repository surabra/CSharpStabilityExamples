using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NullChecks
{
    public partial class Form1 : Form
    {
        private static GhAppForm _ghApp = null;
        private  DateForm _dtForm = null;
        public List<Blocks> BlocksList { get; private set; }

        public static GhAppForm GetGhAppForm()
        {
            if (_ghApp == null)
            {
                _ghApp = new GhAppForm();
            }

            return _ghApp;
        }
        public Form1()
        {
            InitializeComponent();
            BlocksList = new List<Blocks>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _dtForm = new DateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _dtForm.ShowDialog();

            _dtForm.Dispose();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (NullExceptions nullExcep = new NullExceptions(this))
            {
                nullExcep.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var ghApp = GetGhAppForm();
            ghApp.Show();
            ghApp.BringToFront();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _ghApp.Dispose();
        }
    }
}
