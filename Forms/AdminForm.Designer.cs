namespace UniShare.Forms
{
    partial class AdminForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.tabRideRequests = new System.Windows.Forms.TabPage();
            this.tabRideGroups = new System.Windows.Forms.TabPage();
            this.tabPopularRoutes = new System.Windows.Forms.TabPage();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.dgvRideRequests = new System.Windows.Forms.DataGridView();
            this.dgvRideGroups = new System.Windows.Forms.DataGridView();
            this.dgvPopularRoutes = new System.Windows.Forms.DataGridView();
            this.tabAdmin.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.tabRideRequests.SuspendLayout();
            this.tabRideGroups.SuspendLayout();
            this.tabPopularRoutes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRideRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRideGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopularRoutes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(196, 41);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Admin Panel";
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabUsers);
            this.tabAdmin.Controls.Add(this.tabRideRequests);
            this.tabAdmin.Controls.Add(this.tabRideGroups);
            this.tabAdmin.Controls.Add(this.tabPopularRoutes);
            this.tabAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tabAdmin.Location = new System.Drawing.Point(37, 64);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(686, 500);
            this.tabAdmin.TabIndex = 13;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.dgvUsers);
            this.tabUsers.Location = new System.Drawing.Point(4, 40);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(678, 456);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // tabRideRequests
            // 
            this.tabRideRequests.Controls.Add(this.dgvRideRequests);
            this.tabRideRequests.Location = new System.Drawing.Point(4, 37);
            this.tabRideRequests.Name = "tabRideRequests";
            this.tabRideRequests.Padding = new System.Windows.Forms.Padding(3);
            this.tabRideRequests.Size = new System.Drawing.Size(645, 459);
            this.tabRideRequests.TabIndex = 1;
            this.tabRideRequests.Text = "Ride Requests";
            this.tabRideRequests.UseVisualStyleBackColor = true;
            // 
            // tabRideGroups
            // 
            this.tabRideGroups.Controls.Add(this.dgvRideGroups);
            this.tabRideGroups.Location = new System.Drawing.Point(4, 37);
            this.tabRideGroups.Name = "tabRideGroups";
            this.tabRideGroups.Size = new System.Drawing.Size(645, 459);
            this.tabRideGroups.TabIndex = 2;
            this.tabRideGroups.Text = "Ride Groups";
            this.tabRideGroups.UseVisualStyleBackColor = true;
            // 
            // tabPopularRoutes
            // 
            this.tabPopularRoutes.Controls.Add(this.dgvPopularRoutes);
            this.tabPopularRoutes.Location = new System.Drawing.Point(4, 37);
            this.tabPopularRoutes.Name = "tabPopularRoutes";
            this.tabPopularRoutes.Size = new System.Drawing.Size(645, 459);
            this.tabPopularRoutes.TabIndex = 3;
            this.tabPopularRoutes.Text = "Popular Routes";
            this.tabPopularRoutes.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(3, 3);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(672, 450);
            this.dgvUsers.TabIndex = 0;
            // 
            // dgvRideRequests
            // 
            this.dgvRideRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRideRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRideRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRideRequests.Location = new System.Drawing.Point(3, 3);
            this.dgvRideRequests.MultiSelect = false;
            this.dgvRideRequests.Name = "dgvRideRequests";
            this.dgvRideRequests.ReadOnly = true;
            this.dgvRideRequests.RowHeadersWidth = 51;
            this.dgvRideRequests.RowTemplate.Height = 24;
            this.dgvRideRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRideRequests.Size = new System.Drawing.Size(639, 453);
            this.dgvRideRequests.TabIndex = 1;
            // 
            // dgvRideGroups
            // 
            this.dgvRideGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRideGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRideGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRideGroups.Location = new System.Drawing.Point(0, 0);
            this.dgvRideGroups.MultiSelect = false;
            this.dgvRideGroups.Name = "dgvRideGroups";
            this.dgvRideGroups.ReadOnly = true;
            this.dgvRideGroups.RowHeadersWidth = 51;
            this.dgvRideGroups.RowTemplate.Height = 24;
            this.dgvRideGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRideGroups.Size = new System.Drawing.Size(645, 459);
            this.dgvRideGroups.TabIndex = 2;
            // 
            // dgvPopularRoutes
            // 
            this.dgvPopularRoutes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPopularRoutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopularRoutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPopularRoutes.Location = new System.Drawing.Point(0, 0);
            this.dgvPopularRoutes.MultiSelect = false;
            this.dgvPopularRoutes.Name = "dgvPopularRoutes";
            this.dgvPopularRoutes.ReadOnly = true;
            this.dgvPopularRoutes.RowHeadersWidth = 51;
            this.dgvPopularRoutes.RowTemplate.Height = 24;
            this.dgvPopularRoutes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopularRoutes.Size = new System.Drawing.Size(645, 459);
            this.dgvPopularRoutes.TabIndex = 3;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.tabAdmin);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabAdmin.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.tabRideRequests.ResumeLayout(false);
            this.tabRideGroups.ResumeLayout(false);
            this.tabPopularRoutes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRideRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRideGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopularRoutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabRideRequests;
        private System.Windows.Forms.TabPage tabRideGroups;
        private System.Windows.Forms.TabPage tabPopularRoutes;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridView dgvRideRequests;
        private System.Windows.Forms.DataGridView dgvRideGroups;
        private System.Windows.Forms.DataGridView dgvPopularRoutes;
    }
}