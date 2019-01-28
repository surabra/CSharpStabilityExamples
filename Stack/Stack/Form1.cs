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

namespace Stack
{
    public partial class Form1 : Form
    {
        System.Collections.Generic.Stack<int> stackCollection;
        System.Collections.Stack stack = new System.Collections.Stack();

        public Form1()
        {
            stackCollection = new System.Collections.Generic.Stack<int>();
            
            InitializeComponent();
        }

        private void Stack_New_Click(object sender, EventArgs e)
        {
            var any = stackCollection.Pop();

            
            if(stackCollection.Any())
            {
                var any2 = stackCollection.Pop();
            }
        }
    }
}
