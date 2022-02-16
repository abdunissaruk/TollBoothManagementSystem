﻿using System;
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

        private void btnVehicleSearch_Click(object sender, EventArgs e)
        {
            var vehicleReg = comboBoxStateOrTerritory.SelectedItem.ToString() + txtRegionalTransportAuthority.Text + txtLetters.Text + txtDigits.Text;
            var vehicleDetails = _service.VehicleSearch(vehicleReg);

            if (vehicleDetails == null)
            {
                MessageBox.Show("No result found");
                return;
            }

            dataGridViewDisplay.ReadOnly = true;
            dataGridViewDisplay.DataSource = vehicleDetails;
        }
        private void btnDailyReportView_Click(object sender, EventArgs e)
        {
            var startDate = DateTime.Now.AddDays(-1);
            var endDate = DateTime.Now;
            var vehicleDetails = _service.ViewVehicleDetails(startDate, endDate);
            ClearGridViewDisplay();

            if (vehicleDetails == null)
            {
                MessageBox.Show("No result found");
                return;
            }

            dataGridViewDisplay.ReadOnly = true;
            dataGridViewDisplay.DataSource = vehicleDetails;
        }

        private void btnWeeklyReportView_Click(object sender, EventArgs e)
        {
            var startDate = DateTime.Now.AddDays(-7);
            var endDate = DateTime.Now;
            var vehicleDetails = _service.ViewVehicleDetails(startDate, endDate);

            ClearGridViewDisplay();

            if (vehicleDetails == null)
            {
                MessageBox.Show("No result found");
                return;
            }

            dataGridViewDisplay.ReadOnly = true;
            dataGridViewDisplay.DataSource = vehicleDetails;
        }

        private void btnMonthlyReportView_Click(object sender, EventArgs e)
        {
            var startDate = DateTime.Now.AddDays(-30);
            var endDate = DateTime.Now;
            var vehicleDetails = _service.ViewVehicleDetails(startDate, endDate);
            
            ClearGridViewDisplay();

            if (vehicleDetails == null)
            {
                MessageBox.Show("No result found");
                return;
            }

            dataGridViewDisplay.ReadOnly = true;
            dataGridViewDisplay.DataSource = vehicleDetails;
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            var startDate = dateTimePickerFrom.Value;
            var endDate = dateTimePickerTo.Value;
            var vehicleDetails = _service.ViewVehicleDetails(startDate, endDate);
           
            ClearGridViewDisplay();

            if (vehicleDetails == null)
            {
                MessageBox.Show("No result found");
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
                MessageBox.Show("No result found");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save File";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
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
                    var result = vehicle.VehicleDateTime.ToString() + "  -  " + vehicle.VehicleReg.ToString() + "  -  " + vehicle.VehicleClass.ToString() + "  -  " + vehicle.TripType.ToString() + "  -  " + vehicle.Amount.ToString() + "\n";
                    writer.Write(result);
                }
            }
            MessageBox.Show("Daily Report Printed");
        }

        private void weeklyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var startDate = DateTime.Now.AddDays(-7);
            var endDate = DateTime.Now;
            var vehicleDetails = _service.ViewVehicleDetails(startDate, endDate);

            if (vehicleDetails == null)
            {
                MessageBox.Show("No result found");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save File";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
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
                    var result = vehicle.VehicleDateTime.ToString() + "  -  " + vehicle.VehicleReg.ToString() + "  -  " + vehicle.VehicleClass.ToString() + "  -  " + vehicle.TripType.ToString() + "  -  " + vehicle.Amount.ToString() + "\n";
                    writer.Write(result);
                }
            }
            MessageBox.Show("Weekly Report Printed");
        }

        private void monthlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var startDate = DateTime.Now.AddDays(-30);
            var endDate = DateTime.Now;
            var vehicleDetails = _service.ViewVehicleDetails(startDate, endDate);
            if (vehicleDetails != null)
            {
                MessageBox.Show("No result found");
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save File";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
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
                    var result = vehicle.VehicleDateTime.ToString() + "  -  " + vehicle.VehicleReg.ToString() + "  -  " + vehicle.VehicleClass.ToString() + "  -  " + vehicle.TripType.ToString() + "  -  " + vehicle.Amount.ToString() + "\n";
                    writer.Write(result);
                }
            }
            MessageBox.Show("Monthly Report Printed");
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var startDate = dateTimePickerFrom.Value;
            var endDate = dateTimePickerTo.Value;
            var vehicleDetails = _service.ViewVehicleDetails(startDate, endDate);
            if (vehicleDetails != null)
            {
                MessageBox.Show("No result found");
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save File";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
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
                    var result = vehicle.VehicleDateTime.ToString() + "  -  " + vehicle.VehicleReg.ToString() + "  -  " + vehicle.VehicleClass.ToString() + "  -  " + vehicle.TripType.ToString() + "  -  " + vehicle.Amount.ToString() + "\n";
                    writer.Write(result);
                }
            }
            MessageBox.Show("Custom Report Printed");
        }
    }      
}
    

