namespace TollBoothManagementSystem
{
    partial class frmAdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminPage));
            this.menuStripAdminPage = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weeklyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNameDisplayAdmin = new System.Windows.Forms.Label();
            this.comboBoxStateOrTerritory = new System.Windows.Forms.ComboBox();
            this.txtLetters = new System.Windows.Forms.TextBox();
            this.txtRegionalTransportAuthority = new System.Windows.Forms.TextBox();
            this.txtDigits = new System.Windows.Forms.TextBox();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.dataGridViewDisplay = new System.Windows.Forms.DataGridView();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.btnMonthlyReportView = new System.Windows.Forms.Button();
            this.btnWeeklyReportView = new System.Windows.Forms.Button();
            this.btnDailyReportView = new System.Windows.Forms.Button();
            this.btnVehicleSearch = new System.Windows.Forms.Button();
            this.groupBoxVehicleSearch = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVehicleSearch = new System.Windows.Forms.Label();
            this.groupBoxViewReport = new System.Windows.Forms.GroupBox();
            this.btnCustom = new System.Windows.Forms.Button();
            this.lblViewReport = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuStripAdminPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).BeginInit();
            this.groupBoxVehicleSearch.SuspendLayout();
            this.groupBoxViewReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripAdminPage
            // 
            this.menuStripAdminPage.Font = new System.Drawing.Font("Calibri", 10F);
            this.menuStripAdminPage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripAdminPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStripAdminPage.Location = new System.Drawing.Point(0, 0);
            this.menuStripAdminPage.Name = "menuStripAdminPage";
            this.menuStripAdminPage.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStripAdminPage.Size = new System.Drawing.Size(800, 29);
            this.menuStripAdminPage.TabIndex = 0;
            this.menuStripAdminPage.Text = "menuStripAdminPage";
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
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeDetailsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(51, 25);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // employeeDetailsToolStripMenuItem
            // 
            this.employeeDetailsToolStripMenuItem.Name = "employeeDetailsToolStripMenuItem";
            this.employeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.employeeDetailsToolStripMenuItem.Text = "Employee Details";
            this.employeeDetailsToolStripMenuItem.Click += new System.EventHandler(this.employeeDetailsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(58, 25);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyToolStripMenuItem,
            this.weeklyToolStripMenuItem,
            this.monthlyToolStripMenuItem,
            this.customToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reportToolStripMenuItem.Text = "Print Report";
            // 
            // dailyToolStripMenuItem
            // 
            this.dailyToolStripMenuItem.Name = "dailyToolStripMenuItem";
            this.dailyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dailyToolStripMenuItem.Text = "Daily";
            this.dailyToolStripMenuItem.Click += new System.EventHandler(this.dailyToolStripMenuItem_Click);
            // 
            // weeklyToolStripMenuItem
            // 
            this.weeklyToolStripMenuItem.Name = "weeklyToolStripMenuItem";
            this.weeklyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.weeklyToolStripMenuItem.Text = "Weekly";
            this.weeklyToolStripMenuItem.Click += new System.EventHandler(this.weeklyToolStripMenuItem_Click);
            // 
            // monthlyToolStripMenuItem
            // 
            this.monthlyToolStripMenuItem.Name = "monthlyToolStripMenuItem";
            this.monthlyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.monthlyToolStripMenuItem.Text = "Monthly";
            this.monthlyToolStripMenuItem.Click += new System.EventHandler(this.monthlyToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.customToolStripMenuItem.Text = "Custom";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // lblNameDisplayAdmin
            // 
            this.lblNameDisplayAdmin.AutoSize = true;
            this.lblNameDisplayAdmin.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblNameDisplayAdmin.Location = new System.Drawing.Point(629, 5);
            this.lblNameDisplayAdmin.Name = "lblNameDisplayAdmin";
            this.lblNameDisplayAdmin.Size = new System.Drawing.Size(0, 21);
            this.lblNameDisplayAdmin.TabIndex = 2;
            // 
            // comboBoxStateOrTerritory
            // 
            this.comboBoxStateOrTerritory.FormattingEnabled = true;
            this.comboBoxStateOrTerritory.Items.AddRange(new object[] {
            "kl"});
            this.comboBoxStateOrTerritory.Location = new System.Drawing.Point(132, 62);
            this.comboBoxStateOrTerritory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxStateOrTerritory.Name = "comboBoxStateOrTerritory";
            this.comboBoxStateOrTerritory.Size = new System.Drawing.Size(55, 26);
            this.comboBoxStateOrTerritory.TabIndex = 26;
            // 
            // txtLetters
            // 
            this.txtLetters.Location = new System.Drawing.Point(275, 62);
            this.txtLetters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLetters.Name = "txtLetters";
            this.txtLetters.Size = new System.Drawing.Size(37, 26);
            this.txtLetters.TabIndex = 25;
            // 
            // txtRegionalTransportAuthority
            // 
            this.txtRegionalTransportAuthority.Location = new System.Drawing.Point(212, 62);
            this.txtRegionalTransportAuthority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegionalTransportAuthority.Name = "txtRegionalTransportAuthority";
            this.txtRegionalTransportAuthority.Size = new System.Drawing.Size(37, 26);
            this.txtRegionalTransportAuthority.TabIndex = 24;
            // 
            // txtDigits
            // 
            this.txtDigits.Location = new System.Drawing.Point(336, 62);
            this.txtDigits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDigits.Name = "txtDigits";
            this.txtDigits.Size = new System.Drawing.Size(37, 26);
            this.txtDigits.TabIndex = 23;
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Location = new System.Drawing.Point(5, 64);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(107, 18);
            this.lblRegNo.TabIndex = 22;
            this.lblRegNo.Text = "Registration No.";
            // 
            // dataGridViewDisplay
            // 
            this.dataGridViewDisplay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridViewDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplay.Location = new System.Drawing.Point(12, 215);
            this.dataGridViewDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDisplay.Name = "dataGridViewDisplay";
            this.dataGridViewDisplay.RowHeadersWidth = 51;
            this.dataGridViewDisplay.RowTemplate.Height = 24;
            this.dataGridViewDisplay.Size = new System.Drawing.Size(773, 261);
            this.dataGridViewDisplay.TabIndex = 27;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(23, 140);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(41, 18);
            this.lblToDate.TabIndex = 6;
            this.lblToDate.Text = "To     :";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(23, 112);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(47, 18);
            this.lblFromDate.TabIndex = 5;
            this.lblFromDate.Text = "From :";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(85, 134);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerTo.TabIndex = 4;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(85, 106);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerFrom.TabIndex = 3;
            // 
            // btnMonthlyReportView
            // 
            this.btnMonthlyReportView.Location = new System.Drawing.Point(275, 46);
            this.btnMonthlyReportView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMonthlyReportView.Name = "btnMonthlyReportView";
            this.btnMonthlyReportView.Size = new System.Drawing.Size(97, 54);
            this.btnMonthlyReportView.TabIndex = 2;
            this.btnMonthlyReportView.Text = "Month";
            this.btnMonthlyReportView.UseVisualStyleBackColor = true;
            this.btnMonthlyReportView.Click += new System.EventHandler(this.btnMonthlyReportView_Click);
            // 
            // btnWeeklyReportView
            // 
            this.btnWeeklyReportView.Location = new System.Drawing.Point(149, 46);
            this.btnWeeklyReportView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWeeklyReportView.Name = "btnWeeklyReportView";
            this.btnWeeklyReportView.Size = new System.Drawing.Size(97, 54);
            this.btnWeeklyReportView.TabIndex = 1;
            this.btnWeeklyReportView.Text = "Week";
            this.btnWeeklyReportView.UseVisualStyleBackColor = true;
            this.btnWeeklyReportView.Click += new System.EventHandler(this.btnWeeklyReportView_Click);
            // 
            // btnDailyReportView
            // 
            this.btnDailyReportView.Location = new System.Drawing.Point(27, 46);
            this.btnDailyReportView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDailyReportView.Name = "btnDailyReportView";
            this.btnDailyReportView.Size = new System.Drawing.Size(97, 54);
            this.btnDailyReportView.TabIndex = 0;
            this.btnDailyReportView.Text = "Day";
            this.btnDailyReportView.UseVisualStyleBackColor = true;
            this.btnDailyReportView.Click += new System.EventHandler(this.btnDailyReportView_Click);
            // 
            // btnVehicleSearch
            // 
            this.btnVehicleSearch.Location = new System.Drawing.Point(277, 102);
            this.btnVehicleSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVehicleSearch.Name = "btnVehicleSearch";
            this.btnVehicleSearch.Size = new System.Drawing.Size(97, 54);
            this.btnVehicleSearch.TabIndex = 28;
            this.btnVehicleSearch.Text = "Search";
            this.btnVehicleSearch.UseVisualStyleBackColor = true;
            this.btnVehicleSearch.Click += new System.EventHandler(this.btnVehicleSearch_Click);
            // 
            // groupBoxVehicleSearch
            // 
            this.groupBoxVehicleSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupBoxVehicleSearch.Controls.Add(this.btnClear);
            this.groupBoxVehicleSearch.Controls.Add(this.label3);
            this.groupBoxVehicleSearch.Controls.Add(this.label2);
            this.groupBoxVehicleSearch.Controls.Add(this.label1);
            this.groupBoxVehicleSearch.Controls.Add(this.lblVehicleSearch);
            this.groupBoxVehicleSearch.Controls.Add(this.btnVehicleSearch);
            this.groupBoxVehicleSearch.Controls.Add(this.lblRegNo);
            this.groupBoxVehicleSearch.Controls.Add(this.txtRegionalTransportAuthority);
            this.groupBoxVehicleSearch.Controls.Add(this.comboBoxStateOrTerritory);
            this.groupBoxVehicleSearch.Controls.Add(this.txtDigits);
            this.groupBoxVehicleSearch.Controls.Add(this.txtLetters);
            this.groupBoxVehicleSearch.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxVehicleSearch.Location = new System.Drawing.Point(12, 39);
            this.groupBoxVehicleSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxVehicleSearch.Name = "groupBoxVehicleSearch";
            this.groupBoxVehicleSearch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxVehicleSearch.Size = new System.Drawing.Size(385, 169);
            this.groupBoxVehicleSearch.TabIndex = 30;
            this.groupBoxVehicleSearch.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(149, 102);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 54);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "-";
            // 
            // lblVehicleSearch
            // 
            this.lblVehicleSearch.AutoSize = true;
            this.lblVehicleSearch.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblVehicleSearch.Location = new System.Drawing.Point(7, 12);
            this.lblVehicleSearch.Name = "lblVehicleSearch";
            this.lblVehicleSearch.Size = new System.Drawing.Size(112, 21);
            this.lblVehicleSearch.TabIndex = 29;
            this.lblVehicleSearch.Text = "Vehicle Search";
            // 
            // groupBoxViewReport
            // 
            this.groupBoxViewReport.Controls.Add(this.btnCustom);
            this.groupBoxViewReport.Controls.Add(this.lblViewReport);
            this.groupBoxViewReport.Controls.Add(this.btnWeeklyReportView);
            this.groupBoxViewReport.Controls.Add(this.lblToDate);
            this.groupBoxViewReport.Controls.Add(this.btnDailyReportView);
            this.groupBoxViewReport.Controls.Add(this.lblFromDate);
            this.groupBoxViewReport.Controls.Add(this.btnMonthlyReportView);
            this.groupBoxViewReport.Controls.Add(this.dateTimePickerTo);
            this.groupBoxViewReport.Controls.Add(this.dateTimePickerFrom);
            this.groupBoxViewReport.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxViewReport.Location = new System.Drawing.Point(403, 39);
            this.groupBoxViewReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxViewReport.Name = "groupBoxViewReport";
            this.groupBoxViewReport.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxViewReport.Size = new System.Drawing.Size(381, 169);
            this.groupBoxViewReport.TabIndex = 31;
            this.groupBoxViewReport.TabStop = false;
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(292, 106);
            this.btnCustom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(80, 54);
            this.btnCustom.TabIndex = 31;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // lblViewReport
            // 
            this.lblViewReport.AutoSize = true;
            this.lblViewReport.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblViewReport.Location = new System.Drawing.Point(5, 12);
            this.lblViewReport.Name = "lblViewReport";
            this.lblViewReport.Size = new System.Drawing.Size(99, 21);
            this.lblViewReport.TabIndex = 30;
            this.lblViewReport.Text = "View Report";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblWelcome.Location = new System.Drawing.Point(549, 5);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(74, 21);
            this.lblWelcome.TabIndex = 31;
            this.lblWelcome.Text = "Welcome";
            // 
            // frmAdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TollBoothManagementSystem.Properties.Resources.bg_Planae;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.groupBoxViewReport);
            this.Controls.Add(this.groupBoxVehicleSearch);
            this.Controls.Add(this.lblNameDisplayAdmin);
            this.Controls.Add(this.dataGridViewDisplay);
            this.Controls.Add(this.menuStripAdminPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripAdminPage;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmAdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.frmAdminPage_Load);
            this.menuStripAdminPage.ResumeLayout(false);
            this.menuStripAdminPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).EndInit();
            this.groupBoxVehicleSearch.ResumeLayout(false);
            this.groupBoxVehicleSearch.PerformLayout();
            this.groupBoxViewReport.ResumeLayout(false);
            this.groupBoxViewReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripAdminPage;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weeklyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblNameDisplayAdmin;
        private System.Windows.Forms.ComboBox comboBoxStateOrTerritory;
        private System.Windows.Forms.TextBox txtLetters;
        private System.Windows.Forms.TextBox txtRegionalTransportAuthority;
        private System.Windows.Forms.TextBox txtDigits;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.DataGridView dataGridViewDisplay;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button btnMonthlyReportView;
        private System.Windows.Forms.Button btnWeeklyReportView;
        private System.Windows.Forms.Button btnDailyReportView;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Button btnVehicleSearch;
        private System.Windows.Forms.ToolStripMenuItem employeeDetailsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxVehicleSearch;
        private System.Windows.Forms.Label lblVehicleSearch;
        private System.Windows.Forms.GroupBox groupBoxViewReport;
        private System.Windows.Forms.Label lblViewReport;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripMenuItem dailyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.Button btnCustom;
    }
}