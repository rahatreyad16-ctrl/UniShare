namespace UniShare.Forms
{
    partial class BookRideForm
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnSubmitRide = new System.Windows.Forms.Button();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.cmbVehicle = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.dtpRideTime = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpRideDate = new System.Windows.Forms.DateTimePicker();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtPickup = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblPickup = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(374, 416);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(31, 23);
            this.lblMessage.TabIndex = 25;
            this.lblMessage.Text = "\" \"";
            // 
            // btnSubmitRide
            // 
            this.btnSubmitRide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(85)))), ((int)(((byte)(137)))));
            this.btnSubmitRide.FlatAppearance.BorderSize = 0;
            this.btnSubmitRide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitRide.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitRide.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmitRide.Location = new System.Drawing.Point(317, 360);
            this.btnSubmitRide.Name = "btnSubmitRide";
            this.btnSubmitRide.Size = new System.Drawing.Size(148, 38);
            this.btnSubmitRide.TabIndex = 24;
            this.btnSubmitRide.Text = "Book Ride";
            this.btnSubmitRide.UseVisualStyleBackColor = false;
            this.btnSubmitRide.Click += new System.EventHandler(this.btnSubmitRide_Click);
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblVehicle.Location = new System.Drawing.Point(241, 288);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(109, 23);
            this.lblVehicle.TabIndex = 23;
            this.lblVehicle.Text = "Vehicle Type";
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
            this.cmbVehicle.Location = new System.Drawing.Point(243, 314);
            this.cmbVehicle.Name = "cmbVehicle";
            this.cmbVehicle.Size = new System.Drawing.Size(300, 25);
            this.cmbVehicle.TabIndex = 22;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTime.Location = new System.Drawing.Point(461, 215);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(91, 23);
            this.lblTime.TabIndex = 21;
            this.lblTime.Text = "Ride Time";
            // 
            // dtpRideTime
            // 
            this.dtpRideTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpRideTime.Location = new System.Drawing.Point(465, 241);
            this.dtpRideTime.Name = "dtpRideTime";
            this.dtpRideTime.Size = new System.Drawing.Size(100, 25);
            this.dtpRideTime.TabIndex = 20;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDate.Location = new System.Drawing.Point(240, 215);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(89, 23);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Ride Date";
            // 
            // dtpRideDate
            // 
            this.dtpRideDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRideDate.Location = new System.Drawing.Point(241, 241);
            this.dtpRideDate.Name = "dtpRideDate";
            this.dtpRideDate.Size = new System.Drawing.Size(200, 25);
            this.dtpRideDate.TabIndex = 18;
            // 
            // txtDestination
            // 
            this.txtDestination.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestination.Location = new System.Drawing.Point(241, 152);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(300, 31);
            this.txtDestination.TabIndex = 17;
            // 
            // txtPickup
            // 
            this.txtPickup.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPickup.Location = new System.Drawing.Point(243, 84);
            this.txtPickup.Name = "txtPickup";
            this.txtPickup.Size = new System.Drawing.Size(300, 31);
            this.txtPickup.TabIndex = 16;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDestination.Location = new System.Drawing.Point(241, 125);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(102, 23);
            this.lblDestination.TabIndex = 15;
            this.lblDestination.Text = "Destination";
            // 
            // lblPickup
            // 
            this.lblPickup.AutoSize = true;
            this.lblPickup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickup.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPickup.Location = new System.Drawing.Point(240, 58);
            this.lblPickup.Name = "lblPickup";
            this.lblPickup.Size = new System.Drawing.Size(137, 23);
            this.lblPickup.TabIndex = 14;
            this.lblPickup.Text = "Pickup Location";
            this.lblPickup.Click += new System.EventHandler(this.lblPickup_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(237, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(256, 45);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Book Your Ride";
            // 
            // BookRideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnSubmitRide);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.cmbVehicle);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dtpRideTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpRideDate);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtPickup);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblPickup);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookRideForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookRideForm1";
            this.Load += new System.EventHandler(this.BookRideForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnSubmitRide;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.ComboBox cmbVehicle;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dtpRideTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpRideDate;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtPickup;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblPickup;
        private System.Windows.Forms.Label lblTitle;
    }
}