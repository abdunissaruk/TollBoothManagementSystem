using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TollBoothManagementSystem.Services;

namespace TollBoothManagementSystem
{
    public partial class frmAdminPage : Form
    {
        private readonly VehicleDetailsServices _service;
        public frmAdminPage()
        {
            InitializeComponent();
            _service = new VehicleDetailsServices();
        }

        private void frmAdminPage_Load(object sender, EventArgs e)
        {
            lblNameDisplayAdmin.Text = frmLoginPage.loggedUser;
        }

        private void Clear()
        {
            comboBoxStateOrTerritory.Text = "";
            txtRegionalTransportAuthority.Text = "";
            txtLetters.Text = "";
            txtDigits.Text = "";
        }

        private void ClearGridViewDisplay()
        {
            dataGridViewDisplay.Columns.Clear();
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

        private void employeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmEmployeeDetails().Show();
            Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDailyReportView_Click(object sender, EventArgs e)
        {
            var startDate = DateTime.Now.AddDays(-1);
            var endDate = DateTime.Now;
            var vehicleDetails = _service.ViewVehicleDetails(startDate, endDate);
            ClearGridViewDisplay();
            if (vehicleDetails != null)
            {
                dataGridViewDisplay.ReadOnly = true;
                dataGridViewDisplay.DataSource = vehicleDetails;
            }
            else
                MessageBox.Show("No result found");
        }

        private void btnWeeklyReportView_Click(object sender, EventArgs e)
        {
            var startDate = DateTime.Now.AddDays(-7);
            var endDate = DateTime.Now;
            var vehicleDetails = _service.ViewVehicleDetails(startDate, endDate);
            ClearGridViewDisplay();
            if (vehicleDetails != null)
            {
                dataGridViewDisplay.ReadOnly = true;
                dataGridViewDisplay.DataSource = vehicleDetails;
            }
            else
                MessageBox.Show("No result found");
        }

        private void btnMonthlyReportView_Click(object sender, EventArgs e)
        {
            var startDate = DateTime.Now.AddDays(-30);
            var endDate = DateTime.Now;
            var vehicleDetails = _service.ViewVehicleDetails(startDate, endDate);
            ClearGridViewDisplay();
            if (vehicleDetails != null)
            {
                dataGridViewDisplay.ReadOnly = true;
                dataGridViewDisplay.DataSource = vehicleDetails;
            }
            else
                MessageBox.Show("No result found");
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            var startDate = dateTimePickerFrom.Value;
            var endDate = dateTimePickerTo.Value;
            var vehicleDetails = _service.ViewVehicleDetails(startDate, endDate);
            ClearGridViewDisplay();
            if (vehicleDetails != null)
            {
                dataGridViewDisplay.ReadOnly = true;
                dataGridViewDisplay.DataSource = vehicleDetails;
            }
            else
                MessageBox.Show("No result found");
        }
        private void btnVehicleSearch_Click(object sender, EventArgs e)
        {
            var vehicleReg = comboBoxStateOrTerritory.SelectedItem.ToString() + txtRegionalTransportAuthority.Text + txtLetters.Text + txtDigits.Text;
            var vehicleDetails = _service.VehicleSearch(vehicleReg);

            if (vehicleReg != null)
            { 
                dataGridViewDisplay.ReadOnly = true;
                dataGridViewDisplay.DataSource = vehicleDetails;
            }
            else
                MessageBox.Show("No result found");
        }
    }
}
