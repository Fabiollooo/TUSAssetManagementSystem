namespace ProductTracking
{
    partial class AdminDashboard
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
            this.lblWelcomeLong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dgvRecentBookings = new System.Windows.Forms.DataGridView();
            this.panelQuickActions = new System.Windows.Forms.Panel();
            this.btnlibrary = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLibraryBookings = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTotalUsers = new System.Windows.Forms.Panel();
            this.lblTotalUsersNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlActiveBookings = new System.Windows.Forms.Panel();
            this.lblActiveBookingsNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTotalBookings = new System.Windows.Forms.Panel();
            this.lblTotalBookingsNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentBookings)).BeginInit();
            this.panelQuickActions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTotalUsers.SuspendLayout();
            this.pnlActiveBookings.SuspendLayout();
            this.pnlTotalBookings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcomeLong
            // 
            this.lblWelcomeLong.AutoSize = true;
            this.lblWelcomeLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeLong.Location = new System.Drawing.Point(21, 52);
            this.lblWelcomeLong.Name = "lblWelcomeLong";
            this.lblWelcomeLong.Size = new System.Drawing.Size(257, 20);
            this.lblWelcomeLong.TabIndex = 15;
            this.lblWelcomeLong.Text = "Welcome back! Here\'s an overview!";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 35);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dashboard";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(900, 21);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(104, 34);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dgvRecentBookings
            // 
            this.dgvRecentBookings.AllowUserToAddRows = false;
            this.dgvRecentBookings.AllowUserToDeleteRows = false;
            this.dgvRecentBookings.AllowUserToResizeColumns = false;
            this.dgvRecentBookings.AllowUserToResizeRows = false;
            this.dgvRecentBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentBookings.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRecentBookings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRecentBookings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRecentBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecentBookings.Location = new System.Drawing.Point(20, 266);
            this.dgvRecentBookings.Margin = new System.Windows.Forms.Padding(20);
            this.dgvRecentBookings.MultiSelect = false;
            this.dgvRecentBookings.Name = "dgvRecentBookings";
            this.dgvRecentBookings.ReadOnly = true;
            this.dgvRecentBookings.RowHeadersVisible = false;
            this.dgvRecentBookings.RowHeadersWidth = 62;
            this.dgvRecentBookings.RowTemplate.Height = 28;
            this.dgvRecentBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentBookings.Size = new System.Drawing.Size(747, 315);
            this.dgvRecentBookings.TabIndex = 5;
            // 
            // panelQuickActions
            // 
            this.panelQuickActions.BackColor = System.Drawing.SystemColors.Control;
            this.panelQuickActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQuickActions.Controls.Add(this.btnlibrary);
            this.panelQuickActions.Controls.Add(this.button1);
            this.panelQuickActions.Controls.Add(this.btnLibraryBookings);
            this.panelQuickActions.Controls.Add(this.btnManageUsers);
            this.panelQuickActions.Controls.Add(this.label13);
            this.panelQuickActions.Location = new System.Drawing.Point(795, 379);
            this.panelQuickActions.Margin = new System.Windows.Forms.Padding(20);
            this.panelQuickActions.Name = "panelQuickActions";
            this.panelQuickActions.Size = new System.Drawing.Size(233, 202);
            this.panelQuickActions.TabIndex = 11;
            this.panelQuickActions.Paint += new System.Windows.Forms.PaintEventHandler(this.panelQuickActions_Paint);
            // 
            // btnlibrary
            // 
            this.btnlibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlibrary.Location = new System.Drawing.Point(9, 150);
            this.btnlibrary.Name = "btnlibrary";
            this.btnlibrary.Size = new System.Drawing.Size(212, 38);
            this.btnlibrary.TabIndex = 17;
            this.btnlibrary.Text = "Manage Bookings";
            this.btnlibrary.UseVisualStyleBackColor = true;
            this.btnlibrary.Click += new System.EventHandler(this.btnlibrary_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(9, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 38);
            this.button1.TabIndex = 16;
            this.button1.Text = "Manage Rooms";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnLibraryBookings_Click);
            // 
            // btnLibraryBookings
            // 
            this.btnLibraryBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibraryBookings.Location = new System.Drawing.Point(10, 95);
            this.btnLibraryBookings.Name = "btnLibraryBookings";
            this.btnLibraryBookings.Size = new System.Drawing.Size(212, 38);
            this.btnLibraryBookings.TabIndex = 16;
            this.btnLibraryBookings.Text = "Manage Rooms";
            this.btnLibraryBookings.UseVisualStyleBackColor = true;
            this.btnLibraryBookings.Click += new System.EventHandler(this.btnLibraryBookings_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.Location = new System.Drawing.Point(9, 42);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(212, 38);
            this.btnManageUsers.TabIndex = 15;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label13.Location = new System.Drawing.Point(5, 5);
            this.label13.Margin = new System.Windows.Forms.Padding(5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(221, 29);
            this.label13.TabIndex = 14;
            this.label13.Text = "Quick Actions";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvRecentBookings);
            this.panel1.Controls.Add(this.pnlTotalUsers);
            this.panel1.Controls.Add(this.pnlActiveBookings);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.panelQuickActions);
            this.panel1.Controls.Add(this.lblWelcomeLong);
            this.panel1.Controls.Add(this.pnlTotalBookings);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 601);
            this.panel1.TabIndex = 13;
            // 
            // pnlTotalUsers
            // 
            this.pnlTotalUsers.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTotalUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTotalUsers.Controls.Add(this.lblTotalUsersNumber);
            this.pnlTotalUsers.Controls.Add(this.label4);
            this.pnlTotalUsers.Location = new System.Drawing.Point(567, 125);
            this.pnlTotalUsers.Name = "pnlTotalUsers";
            this.pnlTotalUsers.Size = new System.Drawing.Size(200, 100);
            this.pnlTotalUsers.TabIndex = 17;
            // 
            // lblTotalUsersNumber
            // 
            this.lblTotalUsersNumber.AutoSize = true;
            this.lblTotalUsersNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsersNumber.Location = new System.Drawing.Point(13, 43);
            this.lblTotalUsersNumber.Name = "lblTotalUsersNumber";
            this.lblTotalUsersNumber.Size = new System.Drawing.Size(16, 17);
            this.lblTotalUsersNumber.TabIndex = 7;
            this.lblTotalUsersNumber.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Users";
            // 
            // pnlActiveBookings
            // 
            this.pnlActiveBookings.BackColor = System.Drawing.SystemColors.Control;
            this.pnlActiveBookings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlActiveBookings.Controls.Add(this.lblActiveBookingsNumber);
            this.pnlActiveBookings.Controls.Add(this.label2);
            this.pnlActiveBookings.Location = new System.Drawing.Point(296, 125);
            this.pnlActiveBookings.Name = "pnlActiveBookings";
            this.pnlActiveBookings.Size = new System.Drawing.Size(200, 100);
            this.pnlActiveBookings.TabIndex = 16;
            // 
            // lblActiveBookingsNumber
            // 
            this.lblActiveBookingsNumber.AutoSize = true;
            this.lblActiveBookingsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveBookingsNumber.Location = new System.Drawing.Point(13, 43);
            this.lblActiveBookingsNumber.Name = "lblActiveBookingsNumber";
            this.lblActiveBookingsNumber.Size = new System.Drawing.Size(16, 17);
            this.lblActiveBookingsNumber.TabIndex = 7;
            this.lblActiveBookingsNumber.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Active Bookings";
            // 
            // pnlTotalBookings
            // 
            this.pnlTotalBookings.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTotalBookings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTotalBookings.Controls.Add(this.lblTotalBookingsNumber);
            this.pnlTotalBookings.Controls.Add(this.label5);
            this.pnlTotalBookings.Location = new System.Drawing.Point(20, 125);
            this.pnlTotalBookings.Name = "pnlTotalBookings";
            this.pnlTotalBookings.Size = new System.Drawing.Size(200, 100);
            this.pnlTotalBookings.TabIndex = 3;
            // 
            // lblTotalBookingsNumber
            // 
            this.lblTotalBookingsNumber.AutoSize = true;
            this.lblTotalBookingsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBookingsNumber.Location = new System.Drawing.Point(13, 43);
            this.lblTotalBookingsNumber.Name = "lblTotalBookingsNumber";
            this.lblTotalBookingsNumber.Size = new System.Drawing.Size(16, 17);
            this.lblTotalBookingsNumber.TabIndex = 7;
            this.lblTotalBookingsNumber.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Bookings";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 649);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentBookings)).EndInit();
            this.panelQuickActions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTotalUsers.ResumeLayout(false);
            this.pnlTotalUsers.PerformLayout();
            this.pnlActiveBookings.ResumeLayout(false);
            this.pnlActiveBookings.PerformLayout();
            this.pnlTotalBookings.ResumeLayout(false);
            this.pnlTotalBookings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRecentBookings;
        private System.Windows.Forms.Panel panelQuickActions;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcomeLong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlTotalBookings;
        private System.Windows.Forms.Label lblTotalBookingsNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlActiveBookings;
        private System.Windows.Forms.Label lblActiveBookingsNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlTotalUsers;
        private System.Windows.Forms.Label lblTotalUsersNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnLibraryBookings;
        private System.Windows.Forms.Button btnlibrary;
        private System.Windows.Forms.Button button1;
    }
}