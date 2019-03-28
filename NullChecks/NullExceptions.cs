using System;
using System.Windows.Forms;

namespace NullChecks
{
    public partial class NullExceptions : Form
    {
        private Form1 _frmParent;
        private BlockFactory _factory;
        public NullExceptions(Form1 frm)
        {
            _factory = new BlockFactory();
            _frmParent = frm;
            InitializeComponent();
            for (int i = 0; i < 100; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Blocks block = _factory.CreateBlock(int.Parse(comboBox1.SelectedItem.ToString())); // Issue NulReferenceException

            _frmParent.BlocksList.Add(block);

            textBox1.Text = block.Score.ToString(); // Issue NullReferenceException
        }
    }
}
