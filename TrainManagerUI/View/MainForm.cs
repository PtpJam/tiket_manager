using System;

using System.Windows.Forms;
using TrainManagerUI.View;

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
            using (TrainForm t = new View.TrainForm())
            {
                t.ShowDialog();
            }
        }
    }
}
