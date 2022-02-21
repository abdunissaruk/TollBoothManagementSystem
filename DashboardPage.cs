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
    public partial class FrmDashboardPage : Form
    {
        //Connnection
        private readonly VehicleDetailsServices _connection;
        private int _amountToBeCollected = 0;

        //To check class ant trip type combo box index changed
        private bool _isVehicleClassComboBoxIndexChanged = false;
        private bool _isTripTypeComboBoxIndexChanged = false;
        //To check state list combo box index changed
        private bool _isStateComboBoxIndexChanged = false;

        private bool _isViewClicked = false;

        //To identify returning vehicle or not
        private bool _returningVehicle = false;
        //To identify vehicle returned or not
        private bool _isReturned = false;

        private bool _isVehicleExist = false;

        private string _vehicleClass = "";


        public FrmDashboardPage()
        {
            InitializeComponent();
            _connection = new VehicleDetailsServices();
        }

        private void FrmDashboardPage_Load(object sender, EventArgs e)
        {
            //Display current logged user name
            lblNameDisplayEmployee.Text = FrmLoginPage.loggedUser;
        }

        //Logout tool strip menu
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSplashScreen.frmLoginPageObj.Show();
            FrmLoginPage.frmDashboardPageObj.Dispose();
        }

        //Exit tool strip menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //Form close event
        private void FrmDashboardPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        //State combo box index value change event
        private void comboBoxStateOrTerritory_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isStateComboBoxIndexChanged = true;
        }

        //VehicleClass combo box index value change event
        private void comboBoxVehicleClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isVehicleClassComboBoxIndexChanged = true;//true if index changed
            amountCalculatorForNotExisting();
            rtxtAmountDisplay.Text = "  Pay \n  " + _amountToBeCollected.ToString();
        }

        //TripType combo box index value change event
        private void comboBoxTripType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isTripTypeComboBoxIndexChanged = true;// true if index changed
            amountCalculatorForNotExisting();

            if (_isVehicleExist)
                amountCalculatorForExisting(_vehicleClass);

            rtxtAmountDisplay.Text = "  Pay \n  " + _amountToBeCollected.ToString();

        }

        //reset all fields
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

        //To calculate total amount based on selected vehicle class and trip type
        private void amountCalculatorForNotExisting()
        {
            //Return if both vehicle class and trip type combo box index changed
            if (!_isVehicleClassComboBoxIndexChanged || !_isTripTypeComboBoxIndexChanged)
                return; 

            //Trip type combo box value checking
            if (comboBoxVehicleClass.SelectedItem.ToString() == "Three Wheeler")
                _amountToBeCollected = 50;
            else if (comboBoxVehicleClass.SelectedItem.ToString() == "Four Wheeler")
                _amountToBeCollected = 80;
            else if (comboBoxVehicleClass.SelectedItem.ToString() == "Six Wheeler")
                _amountToBeCollected = 100;

            //Trip type combo box value checking
            if (comboBoxTripType.SelectedItem.ToString() == "One Way")
                _amountToBeCollected *= 1;
            else if (comboBoxTripType.SelectedItem.ToString() == "Two Way")
                _amountToBeCollected *= 2;

            //Display Amount in text box
            rtxtAmountDisplay.Text = "  Pay \n  " + _amountToBeCollected.ToString();
        }

        private void amountCalculatorForExisting(string vehicleClass)
        {
            //Return if both vehicle class and trip type combo box index changed
            if (!_isTripTypeComboBoxIndexChanged)
                return;

            //Trip type combo box value checking
            if (vehicleClass == "Three Wheeler")
                _amountToBeCollected = 50;
            else if (vehicleClass == "Four Wheeler")
                _amountToBeCollected = 80;
            else if (vehicleClass == "Six Wheeler")
                _amountToBeCollected = 100;

            //Trip type combo box value checking
            if (comboBoxTripType.SelectedItem.ToString() == "One Way")
                _amountToBeCollected *= 1;
            else if (comboBoxTripType.SelectedItem.ToString() == "Two Way")
                _amountToBeCollected *= 2;

            //if (_returningVehicle)
            //    _amountToBeCollected = 0;
            //Display Amount in text box
            rtxtAmountDisplay.Text = "  Pay \n  " + _amountToBeCollected.ToString();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            _isViewClicked = true;
            _returningVehicle = false;

            //return if state combo box index not changed
            if (!_isStateComboBoxIndexChanged)
                return;

            var vehicleReg = comboBoxStateOrTerritory.SelectedItem.ToString() + "-" + txtRegionalTransportAuthority.Text + "-" + txtLetters.Text + "-" + txtDigits.Text;
            var vehicleDetails = _connection.VehicleSearch(vehicleReg);

            comboBoxVehicleClass.Enabled = true;
            comboBoxTripType.Enabled = true;

            //To enable both vehicle class and trip type combo box for new vehicle
            if (vehicleDetails == null)
            {
                comboBoxVehicleClass.Enabled = true;
                comboBoxTripType.Enabled = true;
                return;
            }

            
            var tripType = "";
            var returnedOrNot = 0;

            //if vehicle details exist in database
            if (vehicleDetails != null)
            {
                _isVehicleExist = true;
                //To disable vehicle class and enable trip type combo box
                comboBoxVehicleClass.Enabled = false;
                comboBoxTripType.Enabled = true;

                //Accesing latest vehicle deatils
                for (int i = 0; i < 1; i++)
                {
                    _vehicleClass = vehicleDetails.ElementAt(i).VehicleClass;
                    tripType = vehicleDetails.ElementAt(i).TripType;
                    returnedOrNot = vehicleDetails.ElementAt(i).Returned;
                }

                if (tripType == "Two Way" && returnedOrNot == 0)
                {
                    //To desable both vehicle class and trip type combo box
                    comboBoxVehicleClass.Enabled = false;
                    comboBoxTripType.Enabled = false;
                    _amountToBeCollected = 0;//Returning vehicle
                    _returningVehicle = true;
                }
                else if (tripType == "Two Way" && returnedOrNot == 1)
                    _returningVehicle = false;
                rtxtAmountDisplay.Text = "  Pay \n  " + _amountToBeCollected.ToString();
            }
            
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            //return if state combo box, vehicle class and trip type index not changed and empty fields
            if (!_isStateComboBoxIndexChanged)
                return;

            if (!_isViewClicked)
            {
                MessageBox.Show("Click view to submit", "Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                

            //|| !_isVehicleClassComboBoxIndexChanged || !_isTripTypeComboBoxIndexChanged ||
            //    txtRegionalTransportAuthority.Text == "" || txtLetters.Text == "" || txtDigits.Text == ""
            var vehicleReg = comboBoxStateOrTerritory.SelectedItem.ToString() + "-" + txtRegionalTransportAuthority.Text + "-" + txtLetters.Text + "-" + txtDigits.Text;
            var vehicleDetailsSearched = _connection.VehicleSearch(vehicleReg);

            
            string tripType = "";

            
            if (vehicleDetailsSearched != null)
            {
                if (txtRegionalTransportAuthority.Text == "" || txtLetters.Text == "" || txtDigits.Text == "")
                    return;

                _isVehicleExist = true;
                foreach (var vehicle in vehicleDetailsSearched)
                {
                    _vehicleClass = vehicle.VehicleClass.ToString();
                }
            }

            if (vehicleDetailsSearched == null)
            {
                if (!_isVehicleClassComboBoxIndexChanged || !_isTripTypeComboBoxIndexChanged ||
                txtRegionalTransportAuthority.Text == "" || txtLetters.Text == "" || txtDigits.Text == "")
                    return;

                _vehicleClass = comboBoxVehicleClass.SelectedItem.ToString();
            }
                
            if (!_returningVehicle)//if not a returning vehicle
            {
                if (_isVehicleExist)
                    amountCalculatorForExisting(_vehicleClass);

                tripType = comboBoxTripType.SelectedItem.ToString();

                var vehicleDetails = new VehicleDetails()
                {
                    VehicleReg = vehicleReg.ToUpper(),
                    VehicleDateTime = DateTime.Now,
                    VehicleClass = _vehicleClass,
                    TripType = tripType,
                    Amount = _amountToBeCollected,
                    Returned = 0
                };
                var addOneEntry = _connection.AddOneEntry(vehicleDetails);
                if (addOneEntry > 0)
                    MessageBox.Show("Vehicle details added", "Added",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else//Returning vehicle
            {
                for (int i = 0; i < 1; i++)
                {
                    tripType = vehicleDetailsSearched.ElementAt(i).TripType;
                }

                var vehicleDetails = new VehicleDetails()
                {
                    VehicleReg = vehicleReg.ToUpper(),
                    VehicleDateTime = DateTime.Now,
                    VehicleClass = _vehicleClass,
                    TripType = tripType,
                    Amount = 0,
                    Returned = 1
                };
                var addOneEntry = _connection.AddOneEntry(vehicleDetails);
                if (addOneEntry > 0)
                    MessageBox.Show("Vehicle details added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            comboBoxVehicleClass.Enabled = false;
            comboBoxTripType.Enabled = false;
            _isVehicleExist = false;
            _returningVehicle = false;
            _amountToBeCollected = 0;
            _isViewClicked = false;
            _vehicleClass = "";
    }
    }   
}


