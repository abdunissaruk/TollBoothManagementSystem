using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TollBoothManagementSystem
{
    public partial class frmDashboardPage : Form
    {
        public frmDashboardPage()
        {
            InitializeComponent();
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
            radioButtonOneWay.Checked = true;
            radioButtonTwoWay.Checked = false;
            comboBoxVehicleClass.Text = "";
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {

        }
    }
}
