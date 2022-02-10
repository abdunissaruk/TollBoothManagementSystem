namespace TollBoothManagementSystem
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TxtRegi = new System.Windows.Forms.TextBox();
            this.TxtFare = new System.Windows.Forms.TextBox();
            this.CbFine = new System.Windows.Forms.CheckBox();
            this.CbSingle = new System.Windows.Forms.CheckBox();
            this.CbDouble = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBPayment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTAnount = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registration No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fare (₹)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(193, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // TxtRegi
            // 
            this.TxtRegi.Location = new System.Drawing.Point(193, 144);
            this.TxtRegi.Name = "TxtRegi";
            this.TxtRegi.Size = new System.Drawing.Size(196, 22);
            this.TxtRegi.TabIndex = 5;
            // 
            // TxtFare
            // 
            this.TxtFare.Location = new System.Drawing.Point(193, 237);
            this.TxtFare.Name = "TxtFare";
            this.TxtFare.Size = new System.Drawing.Size(196, 22);
            this.TxtFare.TabIndex = 7;
            // 
            // CbFine
            // 
            this.CbFine.AutoSize = true;
            this.CbFine.Location = new System.Drawing.Point(193, 276);
            this.CbFine.Name = "CbFine";
            this.CbFine.Size = new System.Drawing.Size(138, 21);
            this.CbFine.TabIndex = 10;
            this.CbFine.Text = "Fine      (Fare x2)";
            this.CbFine.UseVisualStyleBackColor = true;
            // 
            // CbSingle
            // 
            this.CbSingle.AutoSize = true;
            this.CbSingle.Location = new System.Drawing.Point(193, 199);
            this.CbSingle.Name = "CbSingle";
            this.CbSingle.Size = new System.Drawing.Size(69, 21);
            this.CbSingle.TabIndex = 11;
            this.CbSingle.Text = "Single";
            this.CbSingle.UseVisualStyleBackColor = true;
            // 
            // CbDouble
            // 
            this.CbDouble.AutoSize = true;
            this.CbDouble.Location = new System.Drawing.Point(289, 199);
            this.CbDouble.Name = "CbDouble";
            this.CbDouble.Size = new System.Drawing.Size(75, 21);
            this.CbDouble.TabIndex = 12;
            this.CbDouble.Text = "Double";
            this.CbDouble.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(335, 276);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 21);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Vehicle Overload";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mode of Payment";
            // 
            // CBPayment
            // 
            this.CBPayment.FormattingEnabled = true;
            this.CBPayment.Location = new System.Drawing.Point(193, 357);
            this.CBPayment.Name = "CBPayment";
            this.CBPayment.Size = new System.Drawing.Size(196, 24);
            this.CBPayment.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Total Amount";
            // 
            // TxtTAnount
            // 
            this.TxtTAnount.Location = new System.Drawing.Point(193, 306);
            this.TxtTAnount.Name = "TxtTAnount";
            this.TxtTAnount.Size = new System.Drawing.Size(196, 22);
            this.TxtTAnount.TabIndex = 17;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Use as Screen or maybe ",
            "Receipt Preview"});
            this.listBox1.Location = new System.Drawing.Point(548, 82);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(199, 308);
            this.listBox1.TabIndex = 18;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TxtTAnount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CBPayment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.CbDouble);
            this.Controls.Add(this.CbSingle);
            this.Controls.Add(this.CbFine);
            this.Controls.Add(this.TxtFare);
            this.Controls.Add(this.TxtRegi);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox TxtRegi;
        private System.Windows.Forms.TextBox TxtFare;
        private System.Windows.Forms.CheckBox CbFine;
        private System.Windows.Forms.CheckBox CbSingle;
        private System.Windows.Forms.CheckBox CbDouble;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTAnount;
        private System.Windows.Forms.ListBox listBox1;
    }
}