using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TollBoothManagementSystem.Services;

namespace TollBoothManagementSystem
{
    public partial class FrmAdminPage : Form
    {
        private readonly VehicleDetailsServices _service;

        private bool _isStatetypeComboBoxChanged = false;

        public static FrmEmployeeDetails frmEmployeeDetailsObj;

        public FrmAdminPage()
        {
            InitializeComponent();
            _service = new VehicleDetailsServices();
        }

        private void FrmAdminPage_Load(object sender, EventArgs e)
        {
            lblNameDisplayAdmin.Text = FrmLoginPage.loggedUser;
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
            FrmSplashScreen.frmLoginPageObj.Show();
            FrmLoginPage.frmAdminPageObj.Dispose();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void employeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeDetailsObj = new FrmEmployeeDetails();
            frmEmployeeDetailsObj.Show();
            FrmLoginPage.frmAdminPageObj.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            Clear();
            ClearGridViewDisplay();
        }

        private void comboBoxStateOrTerritory_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isStatetypeComboBoxChanged = true;
        }

        private void btnVehicleSearch_Click(object sender, EventArgs e)
        {
            if (!_isStatetypeComboBoxChanged)
                return;
            var vehicleReg = comboBoxStateOrTerritory.SelectedItem.ToString() + "-" + txtRegionalTransportAuthority.Text 
                + "-" + txtLetters.Text + "-" + txtDigits.Text;
            var vehicleDetails = _service.VehicleSearch(vehicleReg);

            if (vehicleDetails == null)
            {
                MessageBox.Show("No result found", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataGridViewDisplay.ReadOnly = true;
            dataGridViewDisplay.DataSource = vehicleDetails;
            Clear();
        }
        private void btnDailyReportView_Click(object sender, EventArgs e)
        {
            var startDate = DateTime.Today;
            var endDate = DateTime.Now;
            var vehicleDetails = _service.ViewVehicleDetails(startDate, endDate);
            ClearGridViewDisplay();

            if (vehicleDetails == null)
            {
                MessageBox.Show("No result found", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataGridViewDisplay.ReadOnly = true;
            dataGridViewDisplay.DataSource = vehicleDetails;
        }

        private void btnWeeklyReportView_Click(object sender, EventArgs e)
        {
            var startDate = DateTime.Today.AddDays(-1 * (int)(DateTime.Today.DayOfWeek) + 1);
            var endDate = DateTime.Now;
            var vehicleDetails = _service.ViewVehicleDetails(startDate, endDate);

            ClearGridViewDisplay();

            if (vehicleDetails == null)
            {
                MessageBox.Show("No result found", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataGridViewDisplay.ReadOnly = true;
            dataGridViewDisplay.DataSource = vehicleDetails;
        }

        private void btnMonthlyReportView_Click(object sender, EventArgs e)
        {
            var today = DateTime.Now;
            var startDate = new DateTime(today.Year, today.Month, 1);
            var endDate = DateTime.Now;
            var vehicleDetails = _service.ViewVehicleDetails(startDate, endDate);
            
            ClearGridViewDisplay();

            if (vehicleDetails == null)
            {
                MessageBox.Show("No result found", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataGridViewDisplay.ReadOnly = true;
            dataGridViewDisplay.DataSource = vehicleDetails;
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            var startDate = dateTimePickerFrom.Value;
            var endDate = dateTimePickerTo.Value;
            if (startDate>=endDate)
            {
                MessageBox.Show("Start date should be less than end date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (startDate > DateTime.Now || endDate > DateTime.Now)
            {
                MessageBox.Show("Can't select future date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var vehicleDetails = _service.ViewVehicleDetails(startDate, endDate);
           
            ClearGridViewDisplay();

            if (vehicleDetails == null)
            {
                MessageBox.Show("No result found", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataGridViewDisplay.ReadOnly = true;
            dataGridViewDisplay.DataSource = vehicleDetails;
        }

        private void dailyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var startDate = DateTime.Today;
            var endDate = DateTime.Now;
            var vehicleDetails = _service.ViewVehicleDetails(startDate, endDate);

            if (vehicleDetails == null)
            {
                MessageBox.Show("No result found","Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save File";
            saveFileDialog.DefaultExt = "csv";
            saveFileDialog.Filter = "csv files (*.csv)|*.csv";
            string fileName = "";
            var saveDialogue = saveFileDialog.ShowDialog();
            if (saveDialogue == DialogResult.Cancel)
                return;
            if (saveDialogue == DialogResult.OK)
                fileName = saveFileDialog.FileName;
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                var heading = "Date and Time,Vehicle Registration No,Vehicle Class,Trip Type,Amount,Returned\n";
                writer.Write(heading);
                foreach (var vehicle in vehicleDetails)
                {
                    var result = vehicle.VehicleDateTime.ToString() + "," + vehicle.VehicleReg.ToString() + "," 
                        + vehicle.VehicleClass.ToString() + "," + vehicle.TripType.ToString() + "," 
                        + vehicle.Amount.ToString() + "," + vehicle.Returned.ToString() + "\n";
                    writer.Write(result);
                }
            }
            MessageBox.Show("Daily Report Printed","Printed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void weeklyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var startDate = DateTime.Today.AddDays(-1 * (int)(DateTime.Today.DayOfWeek) + 1);
            var endDate = DateTime.Now;
            var vehicleDetails = _service.ViewVehicleDetails(startDate, endDate);

            if (vehicleDetails == null)
            {
                MessageBox.Show("No result found", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save File";
            saveFileDialog.DefaultExt = "csv";
            saveFileDialog.Filter = "csv files (*.csv)|*.csv";
            string fileName = "";
            var saveDialogue = saveFileDialog.ShowDialog();
            if (saveDialogue == DialogResult.Cancel)
                return;
            if (saveDialogue == DialogResult.OK)
                fileName = saveFileDialog.FileName;
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var vehicle in vehicleDetails)
                {
                    var heading = "Date and Time,Vehicle Registration No,Vehicle Class,Trip Type,Amount,Returned\n";
                    writer.Write(heading);
                    var result = vehicle.VehicleDateTime.ToString() + "," + vehicle.VehicleReg.ToString() + "," 
                        + vehicle.VehicleClass.ToString() + "," + vehicle.TripType.ToString() + "," 
                        + vehicle.Amount.ToString() + "," + vehicle.Returned.ToString() + "\n";
                    writer.Write(result);
                }
            }
            MessageBox.Show("Weekly Report Printed", "Printed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void monthlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var today = DateTime.Now;
            var startDate = new DateTime(today.Year, today.Month, 1);
            var endDate = DateTime.Now;
            var vehicleDetails = _service.ViewVehicleDetails(startDate, endDate);
            if (vehicleDetails == null)
            {
                MessageBox.Show("No result found","Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save File";
            saveFileDialog.DefaultExt = "csv";
            saveFileDialog.Filter = "csv files (*.csv)|*.csv";
            string fileName = "";
            var saveDialogue = saveFileDialog.ShowDialog();
            if (saveDialogue == DialogResult.Cancel)
                return;
            if (saveDialogue == DialogResult.OK)
                fileName = saveFileDialog.FileName;
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                var heading = "Date and Time,Vehicle Registration No,Vehicle Class,Trip Type,Amount,Returned\n";
                writer.Write(heading);
                foreach (var vehicle in vehicleDetails)
                {
                    var result = vehicle.VehicleDateTime.ToString() + "," + vehicle.VehicleReg.ToString() + "," 
                        + vehicle.VehicleClass.ToString() + "," + vehicle.TripType.ToString() + "," 
                        + vehicle.Amount.ToString() + "," + vehicle.Returned.ToString() + "\n";
                    writer.Write(result);
                }
            }
            MessageBox.Show("Monthly Report Printed", "Printed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var startDate = dateTimePickerFrom.Value;
            var endDate = dateTimePickerTo.Value;
            if (startDate >= endDate)
            {
                MessageBox.Show("Start date should be less than end date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (startDate > DateTime.Now || endDate > DateTime.Now)
            {
                MessageBox.Show("Can't select future date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var vehicleDetails = _service.ViewVehicleDetails(startDate, endDate);
            if (vehicleDetails == null)
            {
                MessageBox.Show("No result found", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save File";
            saveFileDialog.DefaultExt = "csv";
            saveFileDialog.Filter = "csv files (*.csv)|*.csv";
            string fileName = "";
            var saveDialogue = saveFileDialog.ShowDialog();
            if (saveDialogue == DialogResult.Cancel)
                return;
            if (saveDialogue == DialogResult.OK)
                fileName = saveFileDialog.FileName;
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                var heading = "Date and Time,Vehicle Registration No,Vehicle Class,Trip Type,Amount,Returned\n";
                writer.Write(heading);
                foreach (var vehicle in vehicleDetails)
                {

                    var result = vehicle.VehicleDateTime.ToString() + "," + vehicle.VehicleReg.ToString() + "," 
                        + vehicle.VehicleClass.ToString() + "," + vehicle.TripType.ToString() + "," 
                        + vehicle.Amount.ToString() + "," + vehicle.Returned.ToString() + "\n";
                    writer.Write(result);
                }
            }
            MessageBox.Show("Custom Report Printed", "Printed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmAdminPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }      
}
    

