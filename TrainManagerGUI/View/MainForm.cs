using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace TrainManagerGUI
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

        private void button2_Click(object sender, EventArgs e)
        {
            using (View.TripForm t = new View.TripForm())
            {
                t.ShowDialog();
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (View.ScheduleForm t = new View.ScheduleForm())
            {
                t.ShowDialog();
            }
        }

    }
}
