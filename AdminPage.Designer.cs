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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dialyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weeklyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblAdminNameDisplay = new System.Windows.Forms.Label();
            this.cbStateOrTerritory = new System.Windows.Forms.ComboBox();
            this.txtLetters = new System.Windows.Forms.TextBox();
            this.txtRegionalTransportAuthority = new System.Windows.Forms.TextBox();
            this.txtDigits = new System.Windows.Forms.TextBox();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.dataGridViewDisplay = new System.Windows.Forms.DataGridView();
            this.pnlReportView = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.btnMonthlyReportView = new System.Windows.Forms.Button();
            this.btnWeeklyReportView = new System.Windows.Forms.Button();
            this.btnDialyReportView = new System.Windows.Forms.Button();
            this.pnlVehicleSearch = new System.Windows.Forms.Panel();
            this.btnVehicleSearch = new System.Windows.Forms.Button();
            this.lblVehicleSearch = new System.Windows.Forms.Label();
            this.employeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAdminPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).BeginInit();
            this.pnlReportView.SuspendLayout();
            this.pnlVehicleSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripAdminPage
            // 
            this.menuStripAdminPage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripAdminPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripAdminPage.Location = new System.Drawing.Point(0, 0);
            this.menuStripAdminPage.Name = "menuStripAdminPage";
            this.menuStripAdminPage.Size = new System.Drawing.Size(800, 28);
            this.menuStripAdminPage.TabIndex = 0;
            this.menuStripAdminPage.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeDetailsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dialyToolStripMenuItem,
            this.weeklyToolStripMenuItem,
            this.monthlyToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.reportToolStripMenuItem.Text = "Print Report";
            // 
            // dialyToolStripMenuItem
            // 
            this.dialyToolStripMenuItem.Name = "dialyToolStripMenuItem";
            this.dialyToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.dialyToolStripMenuItem.Text = "Dialy";
            // 
            // weeklyToolStripMenuItem
            // 
            this.weeklyToolStripMenuItem.Name = "weeklyToolStripMenuItem";
            this.weeklyToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.weeklyToolStripMenuItem.Text = "Weekly";
            // 
            // monthlyToolStripMenuItem
            // 
            this.monthlyToolStripMenuItem.Name = "monthlyToolStripMenuItem";
            this.monthlyToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.monthlyToolStripMenuItem.Text = "Monthly";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(575, 11);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(66, 17);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome";
            // 
            // lblAdminNameDisplay
            // 
            this.lblAdminNameDisplay.AutoSize = true;
            this.lblAdminNameDisplay.Location = new System.Drawing.Point(647, 11);
            this.lblAdminNameDisplay.Name = "lblAdminNameDisplay";
            this.lblAdminNameDisplay.Size = new System.Drawing.Size(86, 17);
            this.lblAdminNameDisplay.TabIndex = 2;
            this.lblAdminNameDisplay.Text = "Admin name";
            // 
            // cbStateOrTerritory
            // 
            this.cbStateOrTerritory.FormattingEnabled = true;
            this.cbStateOrTerritory.Location = new System.Drawing.Point(148, 43);
            this.cbStateOrTerritory.Name = "cbStateOrTerritory";
            this.cbStateOrTerritory.Size = new System.Drawing.Size(41, 24);
            this.cbStateOrTerritory.TabIndex = 26;
            // 
            // txtLetters
            // 
            this.txtLetters.Location = new System.Drawing.Point(250, 45);
            this.txtLetters.Name = "txtLetters";
            this.txtLetters.Size = new System.Drawing.Size(37, 22);
            this.txtLetters.TabIndex = 25;
            // 
            // txtRegionalTransportAuthority
            // 
            this.txtRegionalTransportAuthority.Location = new System.Drawing.Point(206, 45);
            this.txtRegionalTransportAuthority.Name = "txtRegionalTransportAuthority";
            this.txtRegionalTransportAuthority.Size = new System.Drawing.Size(37, 22);
            this.txtRegionalTransportAuthority.TabIndex = 24;
            // 
            // txtDigits
            // 
            this.txtDigits.Location = new System.Drawing.Point(307, 43);
            this.txtDigits.Name = "txtDigits";
            this.txtDigits.Size = new System.Drawing.Size(37, 22);
            this.txtDigits.TabIndex = 23;
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Location = new System.Drawing.Point(19, 43);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(110, 17);
            this.lblRegNo.TabIndex = 22;
            this.lblRegNo.Text = "Registration No.";
            // 
            // dataGridViewDisplay
            // 
            this.dataGridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplay.Location = new System.Drawing.Point(15, 215);
            this.dataGridViewDisplay.Name = "dataGridViewDisplay";
            this.dataGridViewDisplay.RowHeadersWidth = 51;
            this.dataGridViewDisplay.RowTemplate.Height = 24;
            this.dataGridViewDisplay.Size = new System.Drawing.Size(773, 261);
            this.dataGridViewDisplay.TabIndex = 27;
            // 
            // pnlReportView
            // 
            this.pnlReportView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReportView.Controls.Add(this.label6);
            this.pnlReportView.Controls.Add(this.lblToDate);
            this.pnlReportView.Controls.Add(this.lblFromDate);
            this.pnlReportView.Controls.Add(this.dateTimePickerTo);
            this.pnlReportView.Controls.Add(this.dateTimePickerFrom);
            this.pnlReportView.Controls.Add(this.btnMonthlyReportView);
            this.pnlReportView.Controls.Add(this.btnWeeklyReportView);
            this.pnlReportView.Controls.Add(this.btnDialyReportView);
            this.pnlReportView.Location = new System.Drawing.Point(406, 40);
            this.pnlReportView.Name = "pnlReportView";
            this.pnlReportView.Size = new System.Drawing.Size(382, 169);
            this.pnlReportView.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Report";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(22, 136);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(49, 17);
            this.lblToDate.TabIndex = 6;
            this.lblToDate.Text = "To     :";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(22, 108);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(48, 17);
            this.lblFromDate.TabIndex = 5;
            this.lblFromDate.Text = "From :";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(171, 131);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTo.TabIndex = 4;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(171, 103);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFrom.TabIndex = 3;
            // 
            // btnMonthlyReportView
            // 
            this.btnMonthlyReportView.Location = new System.Drawing.Point(274, 43);
            this.btnMonthlyReportView.Name = "btnMonthlyReportView";
            this.btnMonthlyReportView.Size = new System.Drawing.Size(97, 54);
            this.btnMonthlyReportView.TabIndex = 2;
            this.btnMonthlyReportView.Text = "Month";
            this.btnMonthlyReportView.UseVisualStyleBackColor = true;
            // 
            // btnWeeklyReportView
            // 
            this.btnWeeklyReportView.Location = new System.Drawing.Point(149, 43);
            this.btnWeeklyReportView.Name = "btnWeeklyReportView";
            this.btnWeeklyReportView.Size = new System.Drawing.Size(97, 54);
            this.btnWeeklyReportView.TabIndex = 1;
            this.btnWeeklyReportView.Text = "Week";
            this.btnWeeklyReportView.UseVisualStyleBackColor = true;
            // 
            // btnDialyReportView
            // 
            this.btnDialyReportView.Location = new System.Drawing.Point(25, 43);
            this.btnDialyReportView.Name = "btnDialyReportView";
            this.btnDialyReportView.Size = new System.Drawing.Size(97, 54);
            this.btnDialyReportView.TabIndex = 0;
            this.btnDialyReportView.Text = "Day";
            this.btnDialyReportView.UseVisualStyleBackColor = true;
            // 
            // pnlVehicleSearch
            // 
            this.pnlVehicleSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVehicleSearch.Controls.Add(this.btnVehicleSearch);
            this.pnlVehicleSearch.Controls.Add(this.lblVehicleSearch);
            this.pnlVehicleSearch.Controls.Add(this.lblRegNo);
            this.pnlVehicleSearch.Controls.Add(this.txtDigits);
            this.pnlVehicleSearch.Controls.Add(this.txtLetters);
            this.pnlVehicleSearch.Controls.Add(this.cbStateOrTerritory);
            this.pnlVehicleSearch.Controls.Add(this.txtRegionalTransportAuthority);
            this.pnlVehicleSearch.Location = new System.Drawing.Point(15, 40);
            this.pnlVehicleSearch.Name = "pnlVehicleSearch";
            this.pnlVehicleSearch.Size = new System.Drawing.Size(385, 169);
            this.pnlVehicleSearch.TabIndex = 29;
            // 
            // btnVehicleSearch
            // 
            this.btnVehicleSearch.Location = new System.Drawing.Point(247, 99);
            this.btnVehicleSearch.Name = "btnVehicleSearch";
            this.btnVehicleSearch.Size = new System.Drawing.Size(97, 54);
            this.btnVehicleSearch.TabIndex = 28;
            this.btnVehicleSearch.Text = "Search";
            this.btnVehicleSearch.UseVisualStyleBackColor = true;
            // 
            // lblVehicleSearch
            // 
            this.lblVehicleSearch.AutoSize = true;
            this.lblVehicleSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleSearch.Location = new System.Drawing.Point(19, 4);
            this.lblVehicleSearch.Name = "lblVehicleSearch";
            this.lblVehicleSearch.Size = new System.Drawing.Size(103, 17);
            this.lblVehicleSearch.TabIndex = 27;
            this.lblVehicleSearch.Text = "Search Vehicle";
            // 
            // employeeDetailsToolStripMenuItem
            // 
            this.employeeDetailsToolStripMenuItem.Name = "employeeDetailsToolStripMenuItem";
            this.employeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.employeeDetailsToolStripMenuItem.Text = "Employee Details";
            this.employeeDetailsToolStripMenuItem.Click += new System.EventHandler(this.employeeDetailsToolStripMenuItem_Click);
            // 
            // frmAdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.pnlVehicleSearch);
            this.Controls.Add(this.pnlReportView);
            this.Controls.Add(this.dataGridViewDisplay);
            this.Controls.Add(this.lblAdminNameDisplay);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.menuStripAdminPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripAdminPage;
            this.Name = "frmAdminPage";
            this.Text = "Admin Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripAdminPage.ResumeLayout(false);
            this.menuStripAdminPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).EndInit();
            this.pnlReportView.ResumeLayout(false);
            this.pnlReportView.PerformLayout();
            this.pnlVehicleSearch.ResumeLayout(false);
            this.pnlVehicleSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripAdminPage;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dialyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weeklyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblAdminNameDisplay;
        private System.Windows.Forms.ComboBox cbStateOrTerritory;
        private System.Windows.Forms.TextBox txtLetters;
        private System.Windows.Forms.TextBox txtRegionalTransportAuthority;
        private System.Windows.Forms.TextBox txtDigits;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.DataGridView dataGridViewDisplay;
        private System.Windows.Forms.Panel pnlReportView;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button btnMonthlyReportView;
        private System.Windows.Forms.Button btnWeeklyReportView;
        private System.Windows.Forms.Button btnDialyReportView;
        private System.Windows.Forms.Panel pnlVehicleSearch;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblVehicleSearch;
        private System.Windows.Forms.Button btnVehicleSearch;
        private System.Windows.Forms.ToolStripMenuItem employeeDetailsToolStripMenuItem;
    }
}