namespace TollBoothManagementSystem
{
    partial class FrmEmployeeDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployeeDetails));
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeEmail = new System.Windows.Forms.Label();
            this.lblEmployeeMobileNumber = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.lblEmployeePassord = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeePassword = new System.Windows.Forms.TextBox();
            this.txtEmployeeMobileNumber = new System.Windows.Forms.TextBox();
            this.txtEmployeeEmail = new System.Windows.Forms.TextBox();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.checkBoxAdminPrivilege = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStripEmployeeDetails = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBoxEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridViewEmployeeDetails = new System.Windows.Forms.DataGridView();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminPrivilege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripEmployeeDetails.SuspendLayout();
            this.groupBoxEmployeeDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(71, 69);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(44, 16);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Text = "Name";
            // 
            // lblEmployeeEmail
            // 
            this.lblEmployeeEmail.AutoSize = true;
            this.lblEmployeeEmail.Location = new System.Drawing.Point(71, 118);
            this.lblEmployeeEmail.Name = "lblEmployeeEmail";
            this.lblEmployeeEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmployeeEmail.TabIndex = 1;
            this.lblEmployeeEmail.Text = "E-Mail";
            // 
            // lblEmployeeMobileNumber
            // 
            this.lblEmployeeMobileNumber.AutoSize = true;
            this.lblEmployeeMobileNumber.Location = new System.Drawing.Point(71, 168);
            this.lblEmployeeMobileNumber.Name = "lblEmployeeMobileNumber";
            this.lblEmployeeMobileNumber.Size = new System.Drawing.Size(99, 16);
            this.lblEmployeeMobileNumber.TabIndex = 2;
            this.lblEmployeeMobileNumber.Text = "Mobile Number";
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(71, 20);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(85, 16);
            this.lblEmployeeId.TabIndex = 3;
            this.lblEmployeeId.Text = "Employee ID";
            // 
            // lblEmployeePassord
            // 
            this.lblEmployeePassord.AutoSize = true;
            this.lblEmployeePassord.Location = new System.Drawing.Point(71, 217);
            this.lblEmployeePassord.Name = "lblEmployeePassord";
            this.lblEmployeePassord.Size = new System.Drawing.Size(67, 16);
            this.lblEmployeePassord.TabIndex = 4;
            this.lblEmployeePassord.Text = "Password";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(249, 64);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(123, 22);
            this.txtEmployeeName.TabIndex = 1;
            // 
            // txtEmployeePassword
            // 
            this.txtEmployeePassword.Location = new System.Drawing.Point(249, 212);
            this.txtEmployeePassword.Name = "txtEmployeePassword";
            this.txtEmployeePassword.Size = new System.Drawing.Size(123, 22);
            this.txtEmployeePassword.TabIndex = 5;
            // 
            // txtEmployeeMobileNumber
            // 
            this.txtEmployeeMobileNumber.Location = new System.Drawing.Point(249, 163);
            this.txtEmployeeMobileNumber.Name = "txtEmployeeMobileNumber";
            this.txtEmployeeMobileNumber.Size = new System.Drawing.Size(123, 22);
            this.txtEmployeeMobileNumber.TabIndex = 4;
            // 
            // txtEmployeeEmail
            // 
            this.txtEmployeeEmail.Location = new System.Drawing.Point(249, 113);
            this.txtEmployeeEmail.Name = "txtEmployeeEmail";
            this.txtEmployeeEmail.Size = new System.Drawing.Size(123, 22);
            this.txtEmployeeEmail.TabIndex = 3;
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(249, 15);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(123, 22);
            this.txtEmployeeId.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(728, 159);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(121, 75);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // checkBoxAdminPrivilege
            // 
            this.checkBoxAdminPrivilege.AutoSize = true;
            this.checkBoxAdminPrivilege.Location = new System.Drawing.Point(249, 253);
            this.checkBoxAdminPrivilege.Name = "checkBoxAdminPrivilege";
            this.checkBoxAdminPrivilege.Size = new System.Drawing.Size(123, 20);
            this.checkBoxAdminPrivilege.TabIndex = 6;
            this.checkBoxAdminPrivilege.Text = "Admin Privilege";
            this.checkBoxAdminPrivilege.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(578, 159);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 75);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // menuStripEmployeeDetails
            // 
            this.menuStripEmployeeDetails.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripEmployeeDetails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripEmployeeDetails.Location = new System.Drawing.Point(0, 0);
            this.menuStripEmployeeDetails.Name = "menuStripEmployeeDetails";
            this.menuStripEmployeeDetails.Size = new System.Drawing.Size(953, 30);
            this.menuStripEmployeeDetails.TabIndex = 17;
            this.menuStripEmployeeDetails.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(728, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 75);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBoxEmployeeDetails
            // 
            this.groupBoxEmployeeDetails.Controls.Add(this.btnDelete);
            this.groupBoxEmployeeDetails.Controls.Add(this.lblEmployeeId);
            this.groupBoxEmployeeDetails.Controls.Add(this.btnSearch);
            this.groupBoxEmployeeDetails.Controls.Add(this.lblEmployeeName);
            this.groupBoxEmployeeDetails.Controls.Add(this.btnClear);
            this.groupBoxEmployeeDetails.Controls.Add(this.lblEmployeeEmail);
            this.groupBoxEmployeeDetails.Controls.Add(this.checkBoxAdminPrivilege);
            this.groupBoxEmployeeDetails.Controls.Add(this.lblEmployeeMobileNumber);
            this.groupBoxEmployeeDetails.Controls.Add(this.btnSubmit);
            this.groupBoxEmployeeDetails.Controls.Add(this.lblEmployeePassord);
            this.groupBoxEmployeeDetails.Controls.Add(this.txtEmployeeId);
            this.groupBoxEmployeeDetails.Controls.Add(this.txtEmployeeName);
            this.groupBoxEmployeeDetails.Controls.Add(this.txtEmployeeEmail);
            this.groupBoxEmployeeDetails.Controls.Add(this.txtEmployeePassword);
            this.groupBoxEmployeeDetails.Controls.Add(this.txtEmployeeMobileNumber);
            this.groupBoxEmployeeDetails.Location = new System.Drawing.Point(12, 42);
            this.groupBoxEmployeeDetails.Name = "groupBoxEmployeeDetails";
            this.groupBoxEmployeeDetails.Size = new System.Drawing.Size(929, 289);
            this.groupBoxEmployeeDetails.TabIndex = 19;
            this.groupBoxEmployeeDetails.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(578, 60);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 75);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridViewEmployeeDetails
            // 
            this.dataGridViewEmployeeDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridViewEmployeeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.name,
            this.email,
            this.mobile,
            this.password,
            this.adminPrivilege});
            this.dataGridViewEmployeeDetails.Location = new System.Drawing.Point(12, 337);
            this.dataGridViewEmployeeDetails.Name = "dataGridViewEmployeeDetails";
            this.dataGridViewEmployeeDetails.RowHeadersWidth = 51;
            this.dataGridViewEmployeeDetails.RowTemplate.Height = 24;
            this.dataGridViewEmployeeDetails.Size = new System.Drawing.Size(929, 217);
            this.dataGridViewEmployeeDetails.TabIndex = 20;
            // 
            // EmployeeId
            // 
            this.EmployeeId.Frozen = true;
            this.EmployeeId.HeaderText = "ID";
            this.EmployeeId.MinimumWidth = 6;
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Width = 125;
            // 
            // name
            // 
            this.name.Frozen = true;
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // email
            // 
            this.email.Frozen = true;
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // mobile
            // 
            this.mobile.Frozen = true;
            this.mobile.HeaderText = "Mobile";
            this.mobile.MinimumWidth = 6;
            this.mobile.Name = "mobile";
            this.mobile.Width = 125;
            // 
            // password
            // 
            this.password.Frozen = true;
            this.password.HeaderText = "Password";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.Width = 125;
            // 
            // adminPrivilege
            // 
            this.adminPrivilege.Frozen = true;
            this.adminPrivilege.HeaderText = "Admin Privilege";
            this.adminPrivilege.MinimumWidth = 6;
            this.adminPrivilege.Name = "adminPrivilege";
            this.adminPrivilege.Width = 125;
            // 
            // frmEmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TollBoothManagementSystem.Properties.Resources.bg_Planae;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(953, 566);
            this.Controls.Add(this.dataGridViewEmployeeDetails);
            this.Controls.Add(this.groupBoxEmployeeDetails);
            this.Controls.Add(this.menuStripEmployeeDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripEmployeeDetails;
            this.MaximizeBox = false;
            this.Name = "frmEmployeeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Details";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEmployeeDetails_FormClosed);
            this.Load += new System.EventHandler(this.FrmEmployeeDetails_Load);
            this.menuStripEmployeeDetails.ResumeLayout(false);
            this.menuStripEmployeeDetails.PerformLayout();
            this.groupBoxEmployeeDetails.ResumeLayout(false);
            this.groupBoxEmployeeDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeEmail;
        private System.Windows.Forms.Label lblEmployeeMobileNumber;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblEmployeePassord;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeePassword;
        private System.Windows.Forms.TextBox txtEmployeeMobileNumber;
        private System.Windows.Forms.TextBox txtEmployeeEmail;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox checkBoxAdminPrivilege;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip menuStripEmployeeDetails;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBoxEmployeeDetails;
        private System.Windows.Forms.DataGridView dataGridViewEmployeeDetails;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminPrivilege;
    }
}