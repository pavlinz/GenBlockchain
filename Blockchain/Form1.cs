using System;
using System.Windows.Forms;

namespace Blockchain
{
    public partial class MainWindow : Form
    {
        private Chain _chain = new Chain();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void addBlockBtn_Click(object sender, EventArgs e)
        {
            outputDataListBox.Items.Clear();

            _chain.Add(inputDataBox.Text, "Admin");

            foreach (var block in _chain.Blocks)
            {
                outputDataListBox.Items.Add(block.ToString());
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            foreach(var block in _chain.Blocks)
            {
                outputDataListBox.Items.Add(block.ToString());
            }
        }
    }
}
