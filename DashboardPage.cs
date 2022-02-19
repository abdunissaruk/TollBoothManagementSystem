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
        private int _amountToBeCollected = 0;
        private bool _isVehicleClass = false;
        private bool _isTripType = false;

        private bool _isStatetypeComboBoxChanged = false;

        
        public bool returnVehicle = false;
        public bool isReturned = false;
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
            frmSplashScreen.frmLoginPageObj.Show();
            frmLoginPage.frmDashboardPageObj.Dispose();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            comboBoxStateOrTerritory.Text = "";
            txtRegionalTransportAuthority.Text = "";
            txtLetters.Text = "";
            txtDigits.Text = "";
            comboBoxTripType.Text = "";
            comboBoxVehicleClass.Text = "";
            rtxtAmountDisplay.Text = "";
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (!_isStatetypeComboBoxChanged || !_isVehicleClass || !_isTripType ||
                txtRegionalTransportAuthority.Text == "" || txtLetters.Text == "" || txtDigits.Text == "")
                return;
            var vehicleReg = comboBoxStateOrTerritory.SelectedItem.ToString() + "-" + txtRegionalTransportAuthority.Text + "-" + txtLetters.Text + "-" + txtDigits.Text;
            if (!returnVehicle)
            {
                //Checking the vehicle already details available in database
                var vehicleClass = "";
                var tripType = "";
                var vehicleRegToSearch = comboBoxStateOrTerritory.SelectedItem.ToString() + "-" + txtRegionalTransportAuthority.Text + "-" + txtLetters.Text + "-" + txtDigits.Text;
                var vehicleDetailsSearched = _connection.VehicleSearch(vehicleRegToSearch);
                if (vehicleDetailsSearched != null)
                {
                    foreach (var vehicle in vehicleDetailsSearched)
                    {
                        vehicleClass = vehicle.VehicleClass.ToString();
                        tripType = vehicle.TripType.ToString();
                    }
                }

                vehicleClass = comboBoxVehicleClass.SelectedItem.ToString();
                tripType = comboBoxTripType.SelectedItem.ToString();
                var vehicleDetails = new VehicleDetails()
                {
                    VehicleReg = vehicleReg.ToUpper(),
                    VehicleDateTime = DateTime.Now,
                    VehicleClass = vehicleClass,
                    TripType = tripType,
                    Amount = _amountToBeCollected,
                    Returned = 0
                };
                var addOneEntry = _connection.AddOneEntry(vehicleDetails);
                if (addOneEntry > 0)
                    MessageBox.Show("Vehicle details added");
            }
            else//Returned vehicle
            {
                var vehicleClass = "";
                var tripType = "";
                var vehicleRegToSearch = comboBoxStateOrTerritory.SelectedItem.ToString() + "-" + txtRegionalTransportAuthority.Text + "-" + txtLetters.Text + "-" + txtDigits.Text;
                var vehicleDetailsSearched = _connection.VehicleSearch(vehicleRegToSearch);
                if (vehicleDetailsSearched == null)
                    return;
                foreach (var vehicle in vehicleDetailsSearched)
                {
                    vehicleClass = vehicle.VehicleClass.ToString();
                    tripType = vehicle.TripType.ToString();
                }

                var vehicleDetails = new VehicleDetails()
                {
                    VehicleReg = vehicleReg.ToUpper(),
                    VehicleDateTime = DateTime.Now,
                    VehicleClass = vehicleClass,
                    TripType = tripType,
                    Amount = 0,
                    Returned = 1
                };
                var addOneEntry = _connection.AddOneEntry(vehicleDetails);
                if (addOneEntry > 0)
                    MessageBox.Show("Vehicle details added");
            }
            comboBoxVehicleClass.Enabled = true;
            comboBoxTripType.Enabled = true;
        }

        private void comboBoxVehicleClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isVehicleClass = true;
            amount();
        }

        private void comboBoxTripType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isTripType = true;
            amount();
        }
        private void amount()
        {
            if (_isVehicleClass == true && _isTripType == true)
            {
                if (comboBoxVehicleClass.SelectedItem.ToString() == "Three Wheeler")
                    _amountToBeCollected = 50;
                else if (comboBoxVehicleClass.SelectedItem.ToString() == "Four Wheeler")
                    _amountToBeCollected = 80;
                else if (comboBoxVehicleClass.SelectedItem.ToString() == "Six Wheeler")
                    _amountToBeCollected = 100;

                if (comboBoxTripType.SelectedItem.ToString() == "One Way")
                    _amountToBeCollected *= 1;
                else if (comboBoxTripType.SelectedItem.ToString() == "Two Way")
                    _amountToBeCollected *= 2;
                rtxtAmountDisplay.Text = "  Pay \n  " + _amountToBeCollected.ToString();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (!_isStatetypeComboBoxChanged)
                return;

            var vehicleReg = comboBoxStateOrTerritory.SelectedItem.ToString() + "-" + txtRegionalTransportAuthority.Text + "-" + txtLetters.Text + "-" + txtDigits.Text;
            var vehicleDetails = _connection.VehicleSearch(vehicleReg);

            if(vehicleDetails == null)
            {
                comboBoxVehicleClass.Enabled = true;
                comboBoxTripType.Enabled = true;
                return;
            }
            if (vehicleDetails != null)
            {
                comboBoxVehicleClass.Enabled = false;
                comboBoxTripType.Enabled = true;
            }

            var tripType = "";
            var returnedOrNot = 0;
            for (int i = 0; i < 1; i++)
            {
                tripType = vehicleDetails.ElementAt(i).TripType;
                returnedOrNot = vehicleDetails.ElementAt(i).Returned;
            }

            if (tripType == "Two Way" && returnedOrNot == 0)
            {
                comboBoxVehicleClass.Enabled = false;
                comboBoxTripType.Enabled = false;
                rtxtAmountDisplay.Text = "  Pay \n  0";
                returnVehicle = true;
            }
            else if (tripType == "Two Way" && returnedOrNot == 1)
            {
                comboBoxVehicleClass.Enabled = false;
                comboBoxTripType.Enabled = true;
                returnVehicle = false;
            }
        }

        private void comboBoxStateOrTerritory_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isStatetypeComboBoxChanged = true;
        }

        private void frmDashboardPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }   
}


