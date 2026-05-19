namespace UniShare.Forms
{
    partial class TrackingForm
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
            this.components = new System.ComponentModel.Container();
            this.progressBarRide = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.timerRide = new System.Windows.Forms.Timer(this.components);
            this.btnStartRide = new System.Windows.Forms.Button();
            this.lblETA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBarRide
            // 
            this.progressBarRide.Location = new System.Drawing.Point(149, 148);
            this.progressBarRide.Name = "progressBarRide";
            this.progressBarRide.Size = new System.Drawing.Size(514, 40);
            this.progressBarRide.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStatus.Location = new System.Drawing.Point(323, 66);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(161, 25);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Ride Not Started";
            // 
            // timerRide
            // 
            this.timerRide.Interval = 1000;
            this.timerRide.Tick += new System.EventHandler(this.timerRide_Tick);
            // 
            // btnStartRide
            // 
            this.btnStartRide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(87)))), ((int)(((byte)(137)))));
            this.btnStartRide.FlatAppearance.BorderSize = 0;
            this.btnStartRide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartRide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartRide.ForeColor = System.Drawing.Color.White;
            this.btnStartRide.Location = new System.Drawing.Point(337, 210);
            this.btnStartRide.Name = "btnStartRide";
            this.btnStartRide.Size = new System.Drawing.Size(100, 40);
            this.btnStartRide.TabIndex = 23;
            this.btnStartRide.Text = "Start Ride";
            this.btnStartRide.UseVisualStyleBackColor = false;
            this.btnStartRide.Click += new System.EventHandler(this.btnStartRide_Click);
            // 
            // lblETA
            // 
            this.lblETA.AutoSize = true;
            this.lblETA.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblETA.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblETA.Location = new System.Drawing.Point(323, 111);
            this.lblETA.Name = "lblETA";
            this.lblETA.Size = new System.Drawing.Size(134, 25);
            this.lblETA.TabIndex = 24;
            this.lblETA.Text = "ETA: 0 second";
            // 
            // TrackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.lblETA);
            this.Controls.Add(this.btnStartRide);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBarRide);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TrackingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ride Tracking";
            this.Load += new System.EventHandler(this.TrackingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarRide;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timerRide;
        private System.Windows.Forms.Button btnStartRide;
        private System.Windows.Forms.Label lblETA;
    }
}