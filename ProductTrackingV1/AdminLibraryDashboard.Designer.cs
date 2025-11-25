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
            this.dgvLibraryBookings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLibraryBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibraryBookings.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.dgvLibraryBookings.Location = new System.Drawing.Point(44, 46);
            this.dgvLibraryBookings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLibraryBookings.Name = "dgvLibraryBookings";
            this.dgvLibraryBookings.ReadOnly = true;
            this.dgvLibraryBookings.RowHeadersWidth = 62;
            this.dgvLibraryBookings.RowTemplate.Height = 28;
            this.dgvLibraryBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibraryBookings.Size = new System.Drawing.Size(626, 264);
            this.dgvLibraryBookings.TabIndex = 1;
            this.dgvLibraryBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibraryBookings_CellContentClick);
            // 
            // btnAutoCancel
            // 
            this.btnAutoCancel.Location = new System.Drawing.Point(556, 331);
            this.btnAutoCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAutoCancel.Name = "btnAutoCancel";
            this.btnAutoCancel.Size = new System.Drawing.Size(114, 34);
            this.btnAutoCancel.TabIndex = 2;
            this.btnAutoCancel.Text = "Auto Cancel no show";
            this.btnAutoCancel.UseVisualStyleBackColor = true;
            this.btnAutoCancel.Click += new System.EventHandler(this.btnAutoCancel_Click);
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Location = new System.Drawing.Point(395, 331);
            this.btnCancelBooking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(61, 34);
            this.btnCancelBooking.TabIndex = 3;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.UseVisualStyleBackColor = true;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(212, 331);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(73, 34);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblAdminBookings
            // 
            this.lblAdminBookings.AutoSize = true;
            this.lblAdminBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminBookings.Location = new System.Drawing.Point(306, 10);
            this.lblAdminBookings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminBookings.Name = "lblAdminBookings";
            this.lblAdminBookings.Size = new System.Drawing.Size(83, 20);
            this.lblAdminBookings.TabIndex = 5;
            this.lblAdminBookings.Text = "Bookings";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(56, 331);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 40);
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
            this.panel1.Location = new System.Drawing.Point(55, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 402);
            this.panel1.TabIndex = 7;
            // 
            // AdminLibraryDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 436);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "AdminLibraryDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Bookings";
            this.TopMost = true;
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