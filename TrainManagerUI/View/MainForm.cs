using System;
using System.Windows.Forms;

namespace TrainManagerUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (View.TrainForm t = new View.TrainForm())
            {
                t.ShowDialog();
            }
        }
    }
}
