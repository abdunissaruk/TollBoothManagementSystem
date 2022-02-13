namespace TollBoothManagementSystem
{
    partial class frmLoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginPage));
            this.lblTollBooth = new System.Windows.Forms.Label();
            this.lblLoginId = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBoxLoginPage = new System.Windows.Forms.GroupBox();
            this.groupBoxLoginPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTollBooth
            // 
            this.lblTollBooth.AutoSize = true;
            this.lblTollBooth.BackColor = System.Drawing.Color.Transparent;
            this.lblTollBooth.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTollBooth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(194)))), ((int)(((byte)(200)))));
            this.lblTollBooth.Location = new System.Drawing.Point(54, 35);
            this.lblTollBooth.Name = "lblTollBooth";
            this.lblTollBooth.Size = new System.Drawing.Size(228, 59);
            this.lblTollBooth.TabIndex = 0;
            this.lblTollBooth.Text = "Toll Booth";
            // 
            // lblLoginId
            // 
            this.lblLoginId.AutoSize = true;
            this.lblLoginId.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginId.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginId.ForeColor = System.Drawing.Color.White;
            this.lblLoginId.Location = new System.Drawing.Point(11, 133);
            this.lblLoginId.Name = "lblLoginId";
            this.lblLoginId.Size = new System.Drawing.Size(47, 21);
            this.lblLoginId.TabIndex = 1;
            this.lblLoginId.Text = "Login";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(11, 223);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 21);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // txtLoginId
            // 
            this.txtLoginId.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtLoginId.Location = new System.Drawing.Point(140, 133);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(161, 28);
            this.txtLoginId.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtPassword.Location = new System.Drawing.Point(140, 223);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(161, 28);
            this.txtPassword.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(194)))), ((int)(((byte)(200)))));
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(118, 295);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(95, 37);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBoxLoginPage
            // 
            this.groupBoxLoginPage.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxLoginPage.Controls.Add(this.lblTollBooth);
            this.groupBoxLoginPage.Controls.Add(this.lblLoginId);
            this.groupBoxLoginPage.Controls.Add(this.lblPassword);
            this.groupBoxLoginPage.Controls.Add(this.btnSubmit);
            this.groupBoxLoginPage.Controls.Add(this.txtPassword);
            this.groupBoxLoginPage.Controls.Add(this.txtLoginId);
            this.groupBoxLoginPage.Location = new System.Drawing.Point(420, 62);
            this.groupBoxLoginPage.Name = "groupBoxLoginPage";
            this.groupBoxLoginPage.Size = new System.Drawing.Size(322, 359);
            this.groupBoxLoginPage.TabIndex = 6;
            this.groupBoxLoginPage.TabStop = false;
            // 
            // frmLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(194)))), ((int)(((byte)(200)))));
            this.BackgroundImage = global::TollBoothManagementSystem.Properties.Resources.bg_Planae;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.groupBoxLoginPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.groupBoxLoginPage.ResumeLayout(false);
            this.groupBoxLoginPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTollBooth;
        private System.Windows.Forms.Label lblLoginId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBoxLoginPage;
    }
}

