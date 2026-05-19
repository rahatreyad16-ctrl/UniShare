namespace UniShare.Forms
{
    partial class ScheduledRideForm
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
            this.lblPickup = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.txtPickup = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.cmbVehicle = new System.Windows.Forms.ComboBox();
            this.chkFri = new System.Windows.Forms.CheckBox();
            this.chkSat = new System.Windows.Forms.CheckBox();
            this.chkSun = new System.Windows.Forms.CheckBox();
            this.chkMon = new System.Windows.Forms.CheckBox();
            this.chkWed = new System.Windows.Forms.CheckBox();
            this.chkThu = new System.Windows.Forms.CheckBox();
            this.chkTue = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveSchedule = new System.Windows.Forms.Button();
            this.lblRideDateTime = new System.Windows.Forms.Label();
            this.dtpRideDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblPickup
            // 
            this.lblPickup.AutoSize = true;
            this.lblPickup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickup.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPickup.Location = new System.Drawing.Point(30, 80);
            this.lblPickup.Name = "lblPickup";
            this.lblPickup.Size = new System.Drawing.Size(137, 23);
            this.lblPickup.TabIndex = 2;
            this.lblPickup.Text = "Pickup Location";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDestination.Location = new System.Drawing.Point(30, 129);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(102, 23);
            this.lblDestination.TabIndex = 3;
            this.lblDestination.Text = "Destination";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(362, 41);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Schedule Recurring Ride";
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblVehicle.Location = new System.Drawing.Point(30, 184);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(109, 23);
            this.lblVehicle.TabIndex = 11;
            this.lblVehicle.Text = "Vehicle Type";
            // 
            // txtPickup
            // 
            this.txtPickup.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPickup.Location = new System.Drawing.Point(173, 80);
            this.txtPickup.Name = "txtPickup";
            this.txtPickup.Size = new System.Drawing.Size(284, 31);
            this.txtPickup.TabIndex = 15;
            // 
            // txtDestination
            // 
            this.txtDestination.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestination.Location = new System.Drawing.Point(173, 129);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(284, 31);
            this.txtDestination.TabIndex = 17;
            // 
            // cmbVehicle
            // 
            this.cmbVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicle.FormattingEnabled = true;
            this.cmbVehicle.Items.AddRange(new object[] {
            "Bike",
            "",
            "CNG",
            "",
            "Car",
            "",
            "SharePool"});
            this.cmbVehicle.Location = new System.Drawing.Point(173, 179);
            this.cmbVehicle.Name = "cmbVehicle";
            this.cmbVehicle.Size = new System.Drawing.Size(300, 33);
            this.cmbVehicle.TabIndex = 19;
            // 
            // chkFri
            // 
            this.chkFri.AutoSize = true;
            this.chkFri.ForeColor = System.Drawing.Color.LightBlue;
            this.chkFri.Location = new System.Drawing.Point(30, 280);
            this.chkFri.Name = "chkFri";
            this.chkFri.Size = new System.Drawing.Size(86, 29);
            this.chkFri.TabIndex = 22;
            this.chkFri.Text = "Friday";
            this.chkFri.UseVisualStyleBackColor = true;
            // 
            // chkSat
            // 
            this.chkSat.AutoSize = true;
            this.chkSat.ForeColor = System.Drawing.Color.LightBlue;
            this.chkSat.Location = new System.Drawing.Point(30, 315);
            this.chkSat.Name = "chkSat";
            this.chkSat.Size = new System.Drawing.Size(110, 29);
            this.chkSat.TabIndex = 23;
            this.chkSat.Text = "Saturday";
            this.chkSat.UseVisualStyleBackColor = true;
            // 
            // chkSun
            // 
            this.chkSun.AutoSize = true;
            this.chkSun.ForeColor = System.Drawing.Color.LightBlue;
            this.chkSun.Location = new System.Drawing.Point(30, 350);
            this.chkSun.Name = "chkSun";
            this.chkSun.Size = new System.Drawing.Size(97, 29);
            this.chkSun.TabIndex = 24;
            this.chkSun.Text = "Sunday";
            this.chkSun.UseVisualStyleBackColor = true;
            // 
            // chkMon
            // 
            this.chkMon.AutoSize = true;
            this.chkMon.ForeColor = System.Drawing.Color.LightBlue;
            this.chkMon.Location = new System.Drawing.Point(30, 385);
            this.chkMon.Name = "chkMon";
            this.chkMon.Size = new System.Drawing.Size(104, 29);
            this.chkMon.TabIndex = 25;
            this.chkMon.Text = "Monday";
            this.chkMon.UseVisualStyleBackColor = true;
            // 
            // chkWed
            // 
            this.chkWed.AutoSize = true;
            this.chkWed.ForeColor = System.Drawing.Color.LightBlue;
            this.chkWed.Location = new System.Drawing.Point(146, 280);
            this.chkWed.Name = "chkWed";
            this.chkWed.Size = new System.Drawing.Size(133, 29);
            this.chkWed.TabIndex = 26;
            this.chkWed.Text = "Wednesday";
            this.chkWed.UseVisualStyleBackColor = true;
            // 
            // chkThu
            // 
            this.chkThu.AutoSize = true;
            this.chkThu.ForeColor = System.Drawing.Color.LightBlue;
            this.chkThu.Location = new System.Drawing.Point(146, 315);
            this.chkThu.Name = "chkThu";
            this.chkThu.Size = new System.Drawing.Size(113, 29);
            this.chkThu.TabIndex = 27;
            this.chkThu.Text = "Thursday";
            this.chkThu.UseVisualStyleBackColor = true;
            // 
            // chkTue
            // 
            this.chkTue.AutoSize = true;
            this.chkTue.ForeColor = System.Drawing.Color.LightBlue;
            this.chkTue.Location = new System.Drawing.Point(30, 420);
            this.chkTue.Name = "chkTue";
            this.chkTue.Size = new System.Drawing.Size(104, 29);
            this.chkTue.TabIndex = 28;
            this.chkTue.Text = "Tuesday";
            this.chkTue.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(324, 380);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 35);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveSchedule
            // 
            this.btnSaveSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveSchedule.FlatAppearance.BorderSize = 0;
            this.btnSaveSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSaveSchedule.Location = new System.Drawing.Point(204, 379);
            this.btnSaveSchedule.Name = "btnSaveSchedule";
            this.btnSaveSchedule.Size = new System.Drawing.Size(87, 35);
            this.btnSaveSchedule.TabIndex = 30;
            this.btnSaveSchedule.Text = "Save";
            this.btnSaveSchedule.UseVisualStyleBackColor = false;
            this.btnSaveSchedule.Click += new System.EventHandler(this.btnSaveSchedule_Click);
            // 
            // lblRideDateTime
            // 
            this.lblRideDateTime.AutoSize = true;
            this.lblRideDateTime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRideDateTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRideDateTime.Location = new System.Drawing.Point(33, 235);
            this.lblRideDateTime.Name = "lblRideDateTime";
            this.lblRideDateTime.Size = new System.Drawing.Size(169, 23);
            this.lblRideDateTime.TabIndex = 31;
            this.lblRideDateTime.Text = "Ride Date and Time";
            // 
            // dtpRideDateTime
            // 
            this.dtpRideDateTime.CustomFormat = "dd MMM yyy hh:mm tt";
            this.dtpRideDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRideDateTime.Location = new System.Drawing.Point(208, 228);
            this.dtpRideDateTime.Name = "dtpRideDateTime";
            this.dtpRideDateTime.Size = new System.Drawing.Size(200, 31);
            this.dtpRideDateTime.TabIndex = 32;
            // 
            // ScheduledRideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dtpRideDateTime);
            this.Controls.Add(this.lblRideDateTime);
            this.Controls.Add(this.btnSaveSchedule);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chkTue);
            this.Controls.Add(this.chkThu);
            this.Controls.Add(this.chkWed);
            this.Controls.Add(this.chkMon);
            this.Controls.Add(this.chkSun);
            this.Controls.Add(this.chkSat);
            this.Controls.Add(this.chkFri);
            this.Controls.Add(this.cmbVehicle);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtPickup);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblPickup);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ScheduledRideForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scheduled Rides";
            this.Load += new System.EventHandler(this.ScheduledRideForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPickup;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.TextBox txtPickup;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.ComboBox cmbVehicle;
        private System.Windows.Forms.CheckBox chkFri;
        private System.Windows.Forms.CheckBox chkSat;
        private System.Windows.Forms.CheckBox chkSun;
        private System.Windows.Forms.CheckBox chkMon;
        private System.Windows.Forms.CheckBox chkWed;
        private System.Windows.Forms.CheckBox chkThu;
        private System.Windows.Forms.CheckBox chkTue;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveSchedule;
        private System.Windows.Forms.Label lblRideDateTime;
        private System.Windows.Forms.DateTimePicker dtpRideDateTime;
    }
}