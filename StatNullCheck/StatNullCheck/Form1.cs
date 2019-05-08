using System;
using System.Windows.Forms;

namespace StatNullCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SomeClass.AnotherInstance.Name); // Issue NullReferenceException
            SetAnother();
        }

        private void SetAnother()
        {
            AnotherClass another = new AnotherClass();
            SomeClass.AnotherInstance = another;
            SomeClass.AnotherInstance.Name = "Another";
        }
    }
}
