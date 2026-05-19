namespace UniShare.Forms
{
    partial class MatchRideForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.btnJoinRide = new System.Windows.Forms.Button();
            this.lblPickup = new System.Windows.Forms.Label();
            this.txtPickupFilter = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.txtDestinationFilter = new System.Windows.Forms.TextBox();
            this.cmbVehicleFilter = new System.Windows.Forms.ComboBox();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.dtpMatchTime = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnTrackRide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(380, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(276, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Match Your Ride";
            // 
            // dgvMatches
            // 
            this.dgvMatches.AllowUserToAddRows = false;
            this.dgvMatches.AllowUserToDeleteRows = false;
            this.dgvMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatches.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatches.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMatches.GridColor = System.Drawing.Color.White;
            this.dgvMatches.Location = new System.Drawing.Point(339, 69);
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatches.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMatches.RowHeadersWidth = 51;
            this.dgvMatches.RowTemplate.Height = 24;
            this.dgvMatches.Size = new System.Drawing.Size(636, 400);
            this.dgvMatches.TabIndex = 2;
            // 
            // btnJoinRide
            // 
            this.btnJoinRide.BackColor = System.Drawing.Color.Lime;
            this.btnJoinRide.FlatAppearance.BorderSize = 0;
            this.btnJoinRide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinRide.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinRide.ForeColor = System.Drawing.Color.Black;
            this.btnJoinRide.Location = new System.Drawing.Point(480, 475);
            this.btnJoinRide.Name = "btnJoinRide";
            this.btnJoinRide.Size = new System.Drawing.Size(176, 36);
            this.btnJoinRide.TabIndex = 12;
            this.btnJoinRide.Text = "Join Selected Ride";
            this.btnJoinRide.UseVisualStyleBackColor = false;
            this.btnJoinRide.Click += new System.EventHandler(this.btnJoinRide_Click);
            // 
            // lblPickup
            // 
            this.lblPickup.AutoSize = true;
            this.lblPickup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickup.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPickup.Location = new System.Drawing.Point(12, 69);
            this.lblPickup.Name = "lblPickup";
            this.lblPickup.Size = new System.Drawing.Size(137, 23);
            this.lblPickup.TabIndex = 13;
            this.lblPickup.Text = "Pickup Location";
            // 
            // txtPickupFilter
            // 
            this.txtPickupFilter.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPickupFilter.Location = new System.Drawing.Point(16, 95);
            this.txtPickupFilter.Name = "txtPickupFilter";
            this.txtPickupFilter.Size = new System.Drawing.Size(284, 31);
            this.txtPickupFilter.TabIndex = 14;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDestination.Location = new System.Drawing.Point(12, 142);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(102, 23);
            this.lblDestination.TabIndex = 15;
            this.lblDestination.Text = "Destination";
            // 
            // txtDestinationFilter
            // 
            this.txtDestinationFilter.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinationFilter.Location = new System.Drawing.Point(16, 168);
            this.txtDestinationFilter.Name = "txtDestinationFilter";
            this.txtDestinationFilter.Size = new System.Drawing.Size(284, 31);
            this.txtDestinationFilter.TabIndex = 16;
            // 
            // cmbVehicleFilter
            // 
            this.cmbVehicleFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicleFilter.FormattingEnabled = true;
            this.cmbVehicleFilter.Items.AddRange(new object[] {
            "Bike",
            "",
            "CNG",
            "",
            "Car",
            "",
            "SharePool"});
            this.cmbVehicleFilter.Location = new System.Drawing.Point(16, 254);
            this.cmbVehicleFilter.Name = "cmbVehicleFilter";
            this.cmbVehicleFilter.Size = new System.Drawing.Size(300, 24);
            this.cmbVehicleFilter.TabIndex = 18;
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblVehicle.Location = new System.Drawing.Point(12, 217);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(109, 23);
            this.lblVehicle.TabIndex = 19;
            this.lblVehicle.Text = "Vehicle Type";
            // 
            // dtpMatchTime
            // 
            this.dtpMatchTime.CustomFormat = "dd MMM yyy hh:mm tt";
            this.dtpMatchTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMatchTime.Location = new System.Drawing.Point(16, 336);
            this.dtpMatchTime.Name = "dtpMatchTime";
            this.dtpMatchTime.Size = new System.Drawing.Size(200, 22);
            this.dtpMatchTime.TabIndex = 20;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDate.Location = new System.Drawing.Point(12, 310);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(169, 23);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "Ride Date and Time";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(87)))), ((int)(((byte)(137)))));
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(31, 384);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(168, 37);
            this.btnFilter.TabIndex = 22;
            this.btnFilter.Text = "Filter Matches";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(51, 446);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 23);
            this.lblMessage.TabIndex = 23;
            // 
            // btnTrackRide
            // 
            this.btnTrackRide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(87)))), ((int)(((byte)(137)))));
            this.btnTrackRide.FlatAppearance.BorderSize = 0;
            this.btnTrackRide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrackRide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrackRide.ForeColor = System.Drawing.Color.White;
            this.btnTrackRide.Location = new System.Drawing.Point(748, 474);
            this.btnTrackRide.Name = "btnTrackRide";
            this.btnTrackRide.Size = new System.Drawing.Size(100, 36);
            this.btnTrackRide.TabIndex = 24;
            this.btnTrackRide.Text = "Track Ride";
            this.btnTrackRide.UseVisualStyleBackColor = false;
            this.btnTrackRide.Click += new System.EventHandler(this.btnTrackRide_Click);
            // 
            // MatchRideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1135, 600);
            this.Controls.Add(this.btnTrackRide);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpMatchTime);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.cmbVehicleFilter);
            this.Controls.Add(this.txtDestinationFilter);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.txtPickupFilter);
            this.Controls.Add(this.lblPickup);
            this.Controls.Add(this.btnJoinRide);
            this.Controls.Add(this.dgvMatches);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MatchRideForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Match Ride Form";
            this.Load += new System.EventHandler(this.MatchRideForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvMatches;
        private System.Windows.Forms.Button btnJoinRide;
        private System.Windows.Forms.Label lblPickup;
        private System.Windows.Forms.TextBox txtPickupFilter;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtDestinationFilter;
        private System.Windows.Forms.ComboBox cmbVehicleFilter;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.DateTimePicker dtpMatchTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnTrackRide;
    }
}