using System;

using System.Windows.Forms;

using DapabaseLibrary.Model;
using DapabaseLibrary.Controller.Database;

namespace TrainManagerGUI.View
{
    public partial class TrainForm : Form
    {
        private Train_Controller controller = new Train_Controller();

        public TrainForm()
        {
            InitializeComponent();

            foreach (Train item in controller.Trains)
            {
                comboBox1.Items.Add(item.Id);
            }

        }

        private void TrainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
