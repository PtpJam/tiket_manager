using System;
using System.Windows.Forms;

using DapabaseLibrary.Model;
using DapabaseLibrary.Controller.Database;

namespace TrainManagerGUI.View
{
    public partial class TripForm : Form
    {
        private Trip_Controller controller = new Trip_Controller();

        public TripForm()
        {
            InitializeComponent();

            foreach (Trip item in controller.Trips)
            {
                comboBox1.Items.Add($"{item.From} - {item.Destination}");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TripForm_Load(object sender, EventArgs e)
        {

        }
    }
}
