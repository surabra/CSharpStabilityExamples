using System;
using System.Linq;
using System.Windows.Forms;


namespace Stack
{
    public partial class Form1 : Form
    {
        System.Collections.Generic.Stack<int> stackCollection;
        private int _last;

        public Form1()
        {
            stackCollection = new System.Collections.Generic.Stack<int>();
            _last = 1;
            InitializeComponent();
        }

        private void Stack_New_Click(object sender, EventArgs e)
        {
            var any = stackCollection.Pop(); // Issue Array/Collection Access

            MessageBox.Show(any.ToString());
        }

        private void FillStack_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                stackCollection.Push(_last++);
            }
        }

        private void ProperAccess_Click(object sender, EventArgs e)
        {
            if (stackCollection.Any())
            {
                var ret = stackCollection.Pop();
                MessageBox.Show(ret.ToString());

            }
            else
            {
                MessageBox.Show("Collection is empty");
            }
        }
    }
}
