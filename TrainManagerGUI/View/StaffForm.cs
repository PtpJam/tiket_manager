using System;
using System.Windows.Forms;

using DapabaseLibrary.Model;
using DapabaseLibrary.Controller.Database;

namespace TrainManagerGUI.View
{
    public partial class StaffForm : Form
    {
        private Seller controller = new Seller();

        public StaffForm()
        {
            InitializeComponent();


            // TODO:
            // foreach (Seller item in controller.Se)
            // {
            //     comboBox1.Items.Add(item.Id);
            // }
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {

        }
    }
}
