namespace UniShare.Forms
{
    partial class RatingsForm
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
            this.dgvCoRiders = new System.Windows.Forms.DataGridView();
            this.cmbStars = new System.Windows.Forms.ComboBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSubmitRating = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoRiders)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(286, 41);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Rate Your Co-Rider";
            // 
            // dgvCoRiders
            // 
            this.dgvCoRiders.AllowUserToAddRows = false;
            this.dgvCoRiders.AllowUserToDeleteRows = false;
            this.dgvCoRiders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCoRiders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgvCoRiders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoRiders.GridColor = System.Drawing.Color.White;
            this.dgvCoRiders.Location = new System.Drawing.Point(30, 70);
            this.dgvCoRiders.MultiSelect = false;
            this.dgvCoRiders.Name = "dgvCoRiders";
            this.dgvCoRiders.ReadOnly = true;
            this.dgvCoRiders.RowHeadersVisible = false;
            this.dgvCoRiders.RowHeadersWidth = 51;
            this.dgvCoRiders.RowTemplate.Height = 24;
            this.dgvCoRiders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCoRiders.Size = new System.Drawing.Size(670, 250);
            this.dgvCoRiders.TabIndex = 4;
            // 
            // cmbStars
            // 
            this.cmbStars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStars.FormattingEnabled = true;
            this.cmbStars.Items.AddRange(new object[] {
            "."});
            this.cmbStars.Location = new System.Drawing.Point(77, 326);
            this.cmbStars.Name = "cmbStars";
            this.cmbStars.Size = new System.Drawing.Size(150, 33);
            this.cmbStars.TabIndex = 11;
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(256, 326);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(400, 80);
            this.txtComment.TabIndex = 12;
            this.txtComment.Text = "Comments";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(97, 423);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSubmitRating
            // 
            this.btnSubmitRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(87)))), ((int)(((byte)(137)))));
            this.btnSubmitRating.FlatAppearance.BorderSize = 0;
            this.btnSubmitRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitRating.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitRating.ForeColor = System.Drawing.Color.White;
            this.btnSubmitRating.Location = new System.Drawing.Point(86, 371);
            this.btnSubmitRating.Name = "btnSubmitRating";
            this.btnSubmitRating.Size = new System.Drawing.Size(123, 35);
            this.btnSubmitRating.TabIndex = 26;
            this.btnSubmitRating.Text = "Submit";
            this.btnSubmitRating.UseVisualStyleBackColor = false;
            this.btnSubmitRating.Click += new System.EventHandler(this.btnSubmitRating_Click);
            // 
            // RatingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(812, 600);
            this.Controls.Add(this.btnSubmitRating);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.cmbStars);
            this.Controls.Add(this.dgvCoRiders);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RatingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ratings Form";
            this.Load += new System.EventHandler(this.RatingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoRiders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvCoRiders;
        private System.Windows.Forms.ComboBox cmbStars;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSubmitRating;
    }
}