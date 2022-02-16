using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using TollBoothManagementSystem.Data;
using TollBoothManagementSystem.Model;
using TollBoothManagementSystem.Services;

namespace TollBoothManagementSystem
{
    public partial class frmDashboardPage : Form
    {
        private readonly VehicleDetailsServices _connection;
        public frmDashboardPage()
        {
            InitializeComponent();
            _connection = new VehicleDetailsServices();
        }

        private void frmDashboardPage_Load(object sender, EventArgs e)
        {
            lblNameDisplayEmployee.Text = frmLoginPage.loggedUser;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmLoginPage().Show();
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            comboBoxStateOrTerritory.Text = "";
            txtRegionalTransportAuthority.Text = "";
            txtLetters.Text = "";
            txtDigits.Text = "";
            comboBoxTripType.Text = "";
            comboBoxVehicleClass.Text = "";
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            var vehicleReg = comboBoxStateOrTerritory.SelectedItem.ToString() + " " + txtRegionalTransportAuthority.Text + " " + txtLetters.Text + " " + txtDigits.Text;
            var vehicleDetails = new VehicleDetails()
            { 
                VehicleReg = vehicleReg,
                VehicleDateTime = DateTime.Now,
                VehicleClass = comboBoxVehicleClass.SelectedItem.ToString(),
                Amount = 100,
                TripType = comboBoxVehicleClass.SelectedItem.ToString(),
            };
            var addOneEntry = _connection.AddOneEntry(vehicleDetails);
            if (addOneEntry > 0)
                MessageBox.Show("Vehicle details added");        
        }
    }
}


