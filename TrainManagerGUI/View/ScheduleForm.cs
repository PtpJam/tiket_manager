using System;
using System.Windows.Forms;

using DapabaseLibrary.Model;
using DapabaseLibrary.Controller.Database;

namespace TrainManagerGUI.View
{
    public partial class ScheduleForm : Form
    {
        private Schedule_Controller controller = new Schedule_Controller();

        public ScheduleForm()
        {
            InitializeComponent();

            foreach (Schedule item in controller.Schedules)
            {
                comboBox1.Items.Add($"{item.Train}");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
