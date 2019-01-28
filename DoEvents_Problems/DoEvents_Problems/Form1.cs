using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoEvents_Problems
{
    public partial class Form1 : Form
    {
        TaskScheduler uiScheduler;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50000; i++)
            {
                listBox1.Items.Add(i.ToString());

                Application.DoEvents();  // <-- Calling DoEvents processes other events that may occur
                textBox1.Text = $"Updating Listbox with {i}";

                System.Windows.Forms.Application.DoEvents();

                

            }

            textBox1.Text = "Done";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            textBox1.Dispose();
            textBox1 = null;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Task<string> s = UpdateUI();
            await s;

             
        }

        private async Task<String>  UpdateUI()
        {
            String s = "completed";

            await Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 50000; i++)
                {
                    listBox1.Items.Add(i.ToString());
                    textBox1.Text = $"Updating Listbox with {i}";
                    if (i % 1000 == 0)
                    {
                        listBox1.Invalidate();
                        listBox1.Update();
                    }

                }
            }, CancellationToken.None, TaskCreationOptions.None, uiScheduler);

            return s;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            uiScheduler  = TaskScheduler.FromCurrentSynchronizationContext();
        }
    }
}
