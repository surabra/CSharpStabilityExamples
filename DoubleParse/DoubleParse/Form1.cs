﻿using System;
using System.Windows.Forms;

namespace DoubleParse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox1.Text);        // Issue Double.Parse

            MessageBox.Show(value.ToString());
        }

        private double CorrectParse(string dParse)
        {
            double dRes = 0.0;

            Double.TryParse(dParse, out dRes);
            return dRes;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double dVal = CorrectParse(textBox1.Text);

            MessageBox.Show(dVal.ToString());
        }
    }
}
