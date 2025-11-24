namespace ProductTracking
{
    partial class AdminLibraryDashboard
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
            this.dgvLibraryBookings = new System.Windows.Forms.DataGridView();
            this.btnAutoCancel = new System.Windows.Forms.Button();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblAdminBookings = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibraryBookings)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLibraryBookings
            // 
            this.dgvLibraryBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibraryBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibraryBookings.Location = new System.Drawing.Point(66, 70);
            this.dgvLibraryBookings.Name = "dgvLibraryBookings";
            this.dgvLibraryBookings.ReadOnly = true;
            this.dgvLibraryBookings.RowHeadersWidth = 62;
            this.dgvLibraryBookings.RowTemplate.Height = 28;
            this.dgvLibraryBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibraryBookings.Size = new System.Drawing.Size(939, 406);
            this.dgvLibraryBookings.TabIndex = 1;
            this.dgvLibraryBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibraryBookings_CellContentClick);
            // 
            // btnAutoCancel
            // 
            this.btnAutoCancel.Location = new System.Drawing.Point(659, 504);
            this.btnAutoCancel.Name = "btnAutoCancel";
            this.btnAutoCancel.Size = new System.Drawing.Size(171, 36);
            this.btnAutoCancel.TabIndex = 2;
            this.btnAutoCancel.Text = "Auto Cancel no show";
            this.btnAutoCancel.UseVisualStyleBackColor = true;
            this.btnAutoCancel.Click += new System.EventHandler(this.btnAutoCancel_Click);
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Location = new System.Drawing.Point(515, 504);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(92, 36);
            this.btnCancelBooking.TabIndex = 3;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.UseVisualStyleBackColor = true;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(333, 509);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 31);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblAdminBookings
            // 
            this.lblAdminBookings.AutoSize = true;
            this.lblAdminBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminBookings.Location = new System.Drawing.Point(459, 15);
            this.lblAdminBookings.Name = "lblAdminBookings";
            this.lblAdminBookings.Size = new System.Drawing.Size(122, 29);
            this.lblAdminBookings.TabIndex = 5;
            this.lblAdminBookings.Text = "Bookings";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(84, 509);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 31);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.dgvLibraryBookings);
            this.panel1.Controls.Add(this.btnAutoCancel);
            this.panel1.Controls.Add(this.btnCancelBooking);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lblAdminBookings);
            this.panel1.Location = new System.Drawing.Point(83, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 619);
            this.panel1.TabIndex = 7;
            // 
            // AdminLibraryDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 671);
            this.Controls.Add(this.panel1);
            this.Name = "AdminLibraryDashboard";
            this.Text = "AdminLibraryDashboard";
            this.Load += new System.EventHandler(this.AdminLibraryDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibraryBookings)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvLibraryBookings;
        private System.Windows.Forms.Button btnAutoCancel;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblAdminBookings;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
    }
}