namespace TollBoothManagementSystem
{
    partial class frmDashboardPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboardPage));
            this.lblVehicleClass = new System.Windows.Forms.Label();
            this.lblTripType = new System.Windows.Forms.Label();
            this.comboBoxVehicleClass = new System.Windows.Forms.ComboBox();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNameDisplayEmployee = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuStripDashboard = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtxtAmountDisplay = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.txtRegionalTransportAuthority = new System.Windows.Forms.TextBox();
            this.comboBoxStateOrTerritory = new System.Windows.Forms.ComboBox();
            this.txtLetters = new System.Windows.Forms.TextBox();
            this.txtDigits = new System.Windows.Forms.TextBox();
            this.groupBoxDashboard = new System.Windows.Forms.GroupBox();
            this.lblVehicleDetails = new System.Windows.Forms.Label();
            this.comboBoxTripType = new System.Windows.Forms.ComboBox();
            this.menuStripDashboard.SuspendLayout();
            this.groupBoxDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVehicleClass
            // 
            this.lblVehicleClass.AutoSize = true;
            this.lblVehicleClass.Location = new System.Drawing.Point(28, 224);
            this.lblVehicleClass.Name = "lblVehicleClass";
            this.lblVehicleClass.Size = new System.Drawing.Size(88, 18);
            this.lblVehicleClass.TabIndex = 0;
            this.lblVehicleClass.Text = "Vehicle Class";
            // 
            // lblTripType
            // 
            this.lblTripType.AutoSize = true;
            this.lblTripType.Location = new System.Drawing.Point(28, 157);
            this.lblTripType.Name = "lblTripType";
            this.lblTripType.Size = new System.Drawing.Size(63, 18);
            this.lblTripType.TabIndex = 2;
            this.lblTripType.Text = "Trip Type";
            // 
            // comboBoxVehicleClass
            // 
            this.comboBoxVehicleClass.FormattingEnabled = true;
            this.comboBoxVehicleClass.Items.AddRange(new object[] {
            "3 Wheeler",
            "4 Wheeler",
            "6 Wheeler"});
            this.comboBoxVehicleClass.Location = new System.Drawing.Point(191, 221);
            this.comboBoxVehicleClass.Name = "comboBoxVehicleClass";
            this.comboBoxVehicleClass.Size = new System.Drawing.Size(241, 26);
            this.comboBoxVehicleClass.TabIndex = 4;
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.White;
            this.btnProceed.Location = new System.Drawing.Point(265, 328);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(167, 49);
            this.btnProceed.TabIndex = 24;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(31, 328);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(167, 49);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNameDisplayEmployee
            // 
            this.lblNameDisplayEmployee.AutoSize = true;
            this.lblNameDisplayEmployee.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameDisplayEmployee.Location = new System.Drawing.Point(633, 8);
            this.lblNameDisplayEmployee.Name = "lblNameDisplayEmployee";
            this.lblNameDisplayEmployee.Size = new System.Drawing.Size(0, 21);
            this.lblNameDisplayEmployee.TabIndex = 29;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblWelcome.Location = new System.Drawing.Point(561, 8);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(74, 21);
            this.lblWelcome.TabIndex = 28;
            this.lblWelcome.Text = "Welcome";
            // 
            // menuStripDashboard
            // 
            this.menuStripDashboard.Font = new System.Drawing.Font("Calibri", 10F);
            this.menuStripDashboard.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripDashboard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripDashboard.Location = new System.Drawing.Point(0, 0);
            this.menuStripDashboard.Name = "menuStripDashboard";
            this.menuStripDashboard.Size = new System.Drawing.Size(800, 29);
            this.menuStripDashboard.TabIndex = 30;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(139, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // rtxtAmountDisplay
            // 
            this.rtxtAmountDisplay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtxtAmountDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtAmountDisplay.Cursor = System.Windows.Forms.Cursors.No;
            this.rtxtAmountDisplay.Font = new System.Drawing.Font("Calibri", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtAmountDisplay.ForeColor = System.Drawing.Color.DarkRed;
            this.rtxtAmountDisplay.Location = new System.Drawing.Point(474, 47);
            this.rtxtAmountDisplay.Name = "rtxtAmountDisplay";
            this.rtxtAmountDisplay.ReadOnly = true;
            this.rtxtAmountDisplay.Size = new System.Drawing.Size(314, 426);
            this.rtxtAmountDisplay.TabIndex = 32;
            this.rtxtAmountDisplay.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 18);
            this.label7.TabIndex = 39;
            this.label7.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 18);
            this.label8.TabIndex = 38;
            this.label8.Text = "-";
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Location = new System.Drawing.Point(28, 87);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(103, 18);
            this.lblRegNo.TabIndex = 33;
            this.lblRegNo.Text = "Registration No";
            // 
            // txtRegionalTransportAuthority
            // 
            this.txtRegionalTransportAuthority.Location = new System.Drawing.Point(271, 84);
            this.txtRegionalTransportAuthority.Name = "txtRegionalTransportAuthority";
            this.txtRegionalTransportAuthority.Size = new System.Drawing.Size(37, 26);
            this.txtRegionalTransportAuthority.TabIndex = 35;
            // 
            // comboBoxStateOrTerritory
            // 
            this.comboBoxStateOrTerritory.FormattingEnabled = true;
            this.comboBoxStateOrTerritory.Items.AddRange(new object[] {
            "KL",
            "AP",
            "TN"});
            this.comboBoxStateOrTerritory.Location = new System.Drawing.Point(191, 84);
            this.comboBoxStateOrTerritory.Name = "comboBoxStateOrTerritory";
            this.comboBoxStateOrTerritory.Size = new System.Drawing.Size(55, 26);
            this.comboBoxStateOrTerritory.TabIndex = 37;
            // 
            // txtLetters
            // 
            this.txtLetters.Location = new System.Drawing.Point(333, 84);
            this.txtLetters.Name = "txtLetters";
            this.txtLetters.Size = new System.Drawing.Size(37, 26);
            this.txtLetters.TabIndex = 36;
            // 
            // txtDigits
            // 
            this.txtDigits.Location = new System.Drawing.Point(395, 84);
            this.txtDigits.Name = "txtDigits";
            this.txtDigits.Size = new System.Drawing.Size(37, 26);
            this.txtDigits.TabIndex = 34;
            // 
            // groupBoxDashboard
            // 
            this.groupBoxDashboard.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxDashboard.Controls.Add(this.comboBoxTripType);
            this.groupBoxDashboard.Controls.Add(this.lblVehicleDetails);
            this.groupBoxDashboard.Controls.Add(this.label2);
            this.groupBoxDashboard.Controls.Add(this.comboBoxStateOrTerritory);
            this.groupBoxDashboard.Controls.Add(this.label7);
            this.groupBoxDashboard.Controls.Add(this.label8);
            this.groupBoxDashboard.Controls.Add(this.lblRegNo);
            this.groupBoxDashboard.Controls.Add(this.txtRegionalTransportAuthority);
            this.groupBoxDashboard.Controls.Add(this.txtDigits);
            this.groupBoxDashboard.Controls.Add(this.comboBoxVehicleClass);
            this.groupBoxDashboard.Controls.Add(this.txtLetters);
            this.groupBoxDashboard.Controls.Add(this.btnProceed);
            this.groupBoxDashboard.Controls.Add(this.lblVehicleClass);
            this.groupBoxDashboard.Controls.Add(this.lblTripType);
            this.groupBoxDashboard.Controls.Add(this.btnReset);
            this.groupBoxDashboard.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDashboard.Location = new System.Drawing.Point(13, 47);
            this.groupBoxDashboard.Name = "groupBoxDashboard";
            this.groupBoxDashboard.Size = new System.Drawing.Size(455, 426);
            this.groupBoxDashboard.TabIndex = 33;
            this.groupBoxDashboard.TabStop = false;
            // 
            // lblVehicleDetails
            // 
            this.lblVehicleDetails.AutoSize = true;
            this.lblVehicleDetails.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblVehicleDetails.Location = new System.Drawing.Point(18, 22);
            this.lblVehicleDetails.Name = "lblVehicleDetails";
            this.lblVehicleDetails.Size = new System.Drawing.Size(114, 21);
            this.lblVehicleDetails.TabIndex = 41;
            this.lblVehicleDetails.Text = "Vehicle Details";
            // 
            // comboBoxTripType
            // 
            this.comboBoxTripType.FormattingEnabled = true;
            this.comboBoxTripType.Items.AddRange(new object[] {
            "3 Wheeler",
            "4 Wheeler",
            "6 Wheeler"});
            this.comboBoxTripType.Location = new System.Drawing.Point(191, 154);
            this.comboBoxTripType.Name = "comboBoxTripType";
            this.comboBoxTripType.Size = new System.Drawing.Size(241, 26);
            this.comboBoxTripType.TabIndex = 42;
            // 
            // frmDashboardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TollBoothManagementSystem.Properties.Resources.bg_Planae;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.groupBoxDashboard);
            this.Controls.Add(this.rtxtAmountDisplay);
            this.Controls.Add(this.lblNameDisplayEmployee);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.menuStripDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripDashboard;
            this.MaximizeBox = false;
            this.Name = "frmDashboardPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboardPage_Load);
            this.menuStripDashboard.ResumeLayout(false);
            this.menuStripDashboard.PerformLayout();
            this.groupBoxDashboard.ResumeLayout(false);
            this.groupBoxDashboard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVehicleClass;
        private System.Windows.Forms.Label lblTripType;
        private System.Windows.Forms.ComboBox comboBoxVehicleClass;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNameDisplayEmployee;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.MenuStrip menuStripDashboard;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtxtAmountDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.TextBox txtRegionalTransportAuthority;
        private System.Windows.Forms.ComboBox comboBoxStateOrTerritory;
        private System.Windows.Forms.TextBox txtLetters;
        private System.Windows.Forms.TextBox txtDigits;
        private System.Windows.Forms.GroupBox groupBoxDashboard;
        private System.Windows.Forms.Label lblVehicleDetails;
        private System.Windows.Forms.ComboBox comboBoxTripType;
    }
}