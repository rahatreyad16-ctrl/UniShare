namespace UniShare.Forms
{
    partial class DashboardForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnSavings = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnScheduledRides = new System.Windows.Forms.Button();
            this.btnRatings = new System.Windows.Forms.Button();
            this.btnTrackRide = new System.Windows.Forms.Button();
            this.btnMatchRide = new System.Windows.Forms.Button();
            this.btnBookRide = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(250, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(932, 80);
            this.panelHeader.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(17, 22);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(321, 38);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, [User Name]";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(250, 80);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(932, 573);
            this.panelMain.TabIndex = 2;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.Transparent;
            this.panelSidebar.BackgroundImage = global::UniShare.Properties.Resources.ChatGPT_Image_May_17__2026__03_57_52_AM;
            this.panelSidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSidebar.Controls.Add(this.btnSavings);
            this.panelSidebar.Controls.Add(this.btnHome);
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnAdminPanel);
            this.panelSidebar.Controls.Add(this.btnNotifications);
            this.panelSidebar.Controls.Add(this.btnScheduledRides);
            this.panelSidebar.Controls.Add(this.btnRatings);
            this.panelSidebar.Controls.Add(this.btnTrackRide);
            this.panelSidebar.Controls.Add(this.btnMatchRide);
            this.panelSidebar.Controls.Add(this.btnBookRide);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(250, 653);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnSavings
            // 
            this.btnSavings.FlatAppearance.BorderSize = 0;
            this.btnSavings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavings.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavings.ForeColor = System.Drawing.Color.White;
            this.btnSavings.Location = new System.Drawing.Point(12, 315);
            this.btnSavings.Name = "btnSavings";
            this.btnSavings.Size = new System.Drawing.Size(221, 45);
            this.btnSavings.TabIndex = 3;
            this.btnSavings.Text = "Total Savings";
            this.btnSavings.UseVisualStyleBackColor = true;
            this.btnSavings.Click += new System.EventHandler(this.btnSavings_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(9, 48);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(187, 32);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(10, 544);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(221, 45);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.FlatAppearance.BorderSize = 0;
            this.btnAdminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminPanel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPanel.ForeColor = System.Drawing.Color.White;
            this.btnAdminPanel.Location = new System.Drawing.Point(12, 482);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(221, 45);
            this.btnAdminPanel.TabIndex = 7;
            this.btnAdminPanel.Text = "Admin Panel";
            this.btnAdminPanel.UseVisualStyleBackColor = true;
            this.btnAdminPanel.Click += new System.EventHandler(this.btnAdminPanel_Click);
            // 
            // btnNotifications
            // 
            this.btnNotifications.FlatAppearance.BorderSize = 0;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifications.ForeColor = System.Drawing.Color.White;
            this.btnNotifications.Location = new System.Drawing.Point(9, 421);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(210, 45);
            this.btnNotifications.TabIndex = 6;
            this.btnNotifications.Text = "Notifications";
            this.btnNotifications.UseVisualStyleBackColor = true;
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // btnScheduledRides
            // 
            this.btnScheduledRides.FlatAppearance.BorderSize = 0;
            this.btnScheduledRides.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduledRides.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduledRides.ForeColor = System.Drawing.Color.White;
            this.btnScheduledRides.Location = new System.Drawing.Point(12, 370);
            this.btnScheduledRides.Name = "btnScheduledRides";
            this.btnScheduledRides.Size = new System.Drawing.Size(221, 45);
            this.btnScheduledRides.TabIndex = 5;
            this.btnScheduledRides.Text = "Scheduled Rides";
            this.btnScheduledRides.UseVisualStyleBackColor = true;
            this.btnScheduledRides.Click += new System.EventHandler(this.btnScheduledRides_Click);
            // 
            // btnRatings
            // 
            this.btnRatings.FlatAppearance.BorderSize = 0;
            this.btnRatings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRatings.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRatings.ForeColor = System.Drawing.Color.White;
            this.btnRatings.Location = new System.Drawing.Point(10, 253);
            this.btnRatings.Name = "btnRatings";
            this.btnRatings.Size = new System.Drawing.Size(209, 56);
            this.btnRatings.TabIndex = 4;
            this.btnRatings.Text = "Ratings";
            this.btnRatings.UseVisualStyleBackColor = true;
            this.btnRatings.Click += new System.EventHandler(this.btnRatings_Click);
            // 
            // btnTrackRide
            // 
            this.btnTrackRide.FlatAppearance.BorderSize = 0;
            this.btnTrackRide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrackRide.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrackRide.ForeColor = System.Drawing.Color.White;
            this.btnTrackRide.Location = new System.Drawing.Point(9, 197);
            this.btnTrackRide.Name = "btnTrackRide";
            this.btnTrackRide.Size = new System.Drawing.Size(236, 50);
            this.btnTrackRide.TabIndex = 2;
            this.btnTrackRide.Text = "Track Ride";
            this.btnTrackRide.UseVisualStyleBackColor = true;
            this.btnTrackRide.Click += new System.EventHandler(this.btnTrackRide_Click);
            // 
            // btnMatchRide
            // 
            this.btnMatchRide.FlatAppearance.BorderSize = 0;
            this.btnMatchRide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatchRide.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatchRide.ForeColor = System.Drawing.Color.White;
            this.btnMatchRide.Location = new System.Drawing.Point(9, 146);
            this.btnMatchRide.Name = "btnMatchRide";
            this.btnMatchRide.Size = new System.Drawing.Size(235, 45);
            this.btnMatchRide.TabIndex = 1;
            this.btnMatchRide.Text = "Match Ride";
            this.btnMatchRide.UseVisualStyleBackColor = true;
            this.btnMatchRide.Click += new System.EventHandler(this.btnMatchRide_Click);
            // 
            // btnBookRide
            // 
            this.btnBookRide.FlatAppearance.BorderSize = 0;
            this.btnBookRide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookRide.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookRide.ForeColor = System.Drawing.Color.White;
            this.btnBookRide.Location = new System.Drawing.Point(12, 95);
            this.btnBookRide.Name = "btnBookRide";
            this.btnBookRide.Size = new System.Drawing.Size(207, 45);
            this.btnBookRide.TabIndex = 0;
            this.btnBookRide.Text = "Book Ride";
            this.btnBookRide.UseVisualStyleBackColor = true;
            this.btnBookRide.Click += new System.EventHandler(this.btnBookRide_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnBookRide;
        private System.Windows.Forms.Button btnScheduledRides;
        private System.Windows.Forms.Button btnRatings;
        private System.Windows.Forms.Button btnSavings;
        private System.Windows.Forms.Button btnTrackRide;
        private System.Windows.Forms.Button btnMatchRide;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAdminPanel;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelMain;
    }
}