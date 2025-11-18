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
            this.btnLibraryBookings = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.dgvRecentBookings = new System.Windows.Forms.DataGridView();
            this.lblTotalBookingsTitle = new System.Windows.Forms.Label();
            this.panelStatsRow = new System.Windows.Forms.Panel();
            this.panelTotalBookings = new System.Windows.Forms.Panel();
            this.lblTotalUsersTitle = new System.Windows.Forms.Label();
            this.lblTotalBookingsNumber = new System.Windows.Forms.Label();
            this.panelActiveBookings = new System.Windows.Forms.Panel();
            this.lblActiveBookingsNumber = new System.Windows.Forms.Label();
            this.lblActiveBookingsTitle = new System.Windows.Forms.Label();
            this.lblTotalUsersNumber = new System.Windows.Forms.Label();
            this.panelQuickActions = new System.Windows.Forms.Panel();
            this.lblQuickTitle = new System.Windows.Forms.Label();
            this.panelRecent = new System.Windows.Forms.Panel();
            this.panelTotalUsers = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentBookings)).BeginInit();
            this.panelStatsRow.SuspendLayout();
            this.panelTotalBookings.SuspendLayout();
            this.panelActiveBookings.SuspendLayout();
            this.panelQuickActions.SuspendLayout();
            this.panelRecent.SuspendLayout();
            this.panelTotalUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLibraryBookings
            // 
            this.btnLibraryBookings.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLibraryBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibraryBookings.Location = new System.Drawing.Point(3, 132);
            this.btnLibraryBookings.Name = "btnLibraryBookings";
            this.btnLibraryBookings.Size = new System.Drawing.Size(116, 49);
            this.btnLibraryBookings.TabIndex = 0;
            this.btnLibraryBookings.Text = "Library Booking";
            this.btnLibraryBookings.UseVisualStyleBackColor = false;
            this.btnLibraryBookings.Click += new System.EventHandler(this.btnLibraryBookings_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Location = new System.Drawing.Point(3, 61);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(124, 49);
            this.btnManageUsers.TabIndex = 1;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(855, 538);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(125, 59);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "button3";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(61, 33);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(128, 20);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome Fabian";
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1229, 100);
            this.panelHeader.TabIndex = 4;
            // 
            // dgvRecentBookings
            // 
            this.dgvRecentBookings.AllowUserToAddRows = false;
            this.dgvRecentBookings.AllowUserToDeleteRows = false;
            this.dgvRecentBookings.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRecentBookings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentBookings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRecentBookings.Location = new System.Drawing.Point(0, 67);
            this.dgvRecentBookings.Name = "dgvRecentBookings";
            this.dgvRecentBookings.ReadOnly = true;
            this.dgvRecentBookings.RowHeadersVisible = false;
            this.dgvRecentBookings.RowHeadersWidth = 62;
            this.dgvRecentBookings.RowTemplate.Height = 28;
            this.dgvRecentBookings.Size = new System.Drawing.Size(648, 181);
            this.dgvRecentBookings.TabIndex = 5;
            this.dgvRecentBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecentBookings_CellContentClick);
            // 
            // lblTotalBookingsTitle
            // 
            this.lblTotalBookingsTitle.AutoSize = true;
            this.lblTotalBookingsTitle.Location = new System.Drawing.Point(12, 14);
            this.lblTotalBookingsTitle.Name = "lblTotalBookingsTitle";
            this.lblTotalBookingsTitle.Size = new System.Drawing.Size(114, 20);
            this.lblTotalBookingsTitle.TabIndex = 6;
            this.lblTotalBookingsTitle.Text = "Total Bookings";
            // 
            // panelStatsRow
            // 
            this.panelStatsRow.Controls.Add(this.panelTotalUsers);
            this.panelStatsRow.Controls.Add(this.panelActiveBookings);
            this.panelStatsRow.Controls.Add(this.panelTotalBookings);
            this.panelStatsRow.Location = new System.Drawing.Point(32, 106);
            this.panelStatsRow.Name = "panelStatsRow";
            this.panelStatsRow.Size = new System.Drawing.Size(875, 129);
            this.panelStatsRow.TabIndex = 10;
            // 
            // panelTotalBookings
            // 
            this.panelTotalBookings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalBookings.Controls.Add(this.lblTotalBookingsNumber);
            this.panelTotalBookings.Controls.Add(this.lblTotalBookingsTitle);
            this.panelTotalBookings.Location = new System.Drawing.Point(33, 30);
            this.panelTotalBookings.Name = "panelTotalBookings";
            this.panelTotalBookings.Size = new System.Drawing.Size(177, 80);
            this.panelTotalBookings.TabIndex = 1;
            // 
            // lblTotalUsersTitle
            // 
            this.lblTotalUsersTitle.AutoSize = true;
            this.lblTotalUsersTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsersTitle.Location = new System.Drawing.Point(26, 15);
            this.lblTotalUsersTitle.Name = "lblTotalUsersTitle";
            this.lblTotalUsersTitle.Size = new System.Drawing.Size(112, 25);
            this.lblTotalUsersTitle.TabIndex = 11;
            this.lblTotalUsersTitle.Text = "Total Users";
            this.lblTotalUsersTitle.Click += new System.EventHandler(this.lblTotalUsersTitle_Click);
            // 
            // lblTotalBookingsNumber
            // 
            this.lblTotalBookingsNumber.AutoSize = true;
            this.lblTotalBookingsNumber.Location = new System.Drawing.Point(63, 35);
            this.lblTotalBookingsNumber.Name = "lblTotalBookingsNumber";
            this.lblTotalBookingsNumber.Size = new System.Drawing.Size(18, 20);
            this.lblTotalBookingsNumber.TabIndex = 7;
            this.lblTotalBookingsNumber.Text = "0";
            this.lblTotalBookingsNumber.Click += new System.EventHandler(this.lblTotalBookingsNumber_Click);
            // 
            // panelActiveBookings
            // 
            this.panelActiveBookings.AutoSize = true;
            this.panelActiveBookings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActiveBookings.Controls.Add(this.lblActiveBookingsNumber);
            this.panelActiveBookings.Controls.Add(this.lblActiveBookingsTitle);
            this.panelActiveBookings.Location = new System.Drawing.Point(340, 29);
            this.panelActiveBookings.Name = "panelActiveBookings";
            this.panelActiveBookings.Size = new System.Drawing.Size(157, 71);
            this.panelActiveBookings.TabIndex = 2;
            // 
            // lblActiveBookingsNumber
            // 
            this.lblActiveBookingsNumber.AutoSize = true;
            this.lblActiveBookingsNumber.Location = new System.Drawing.Point(64, 36);
            this.lblActiveBookingsNumber.Name = "lblActiveBookingsNumber";
            this.lblActiveBookingsNumber.Size = new System.Drawing.Size(18, 20);
            this.lblActiveBookingsNumber.TabIndex = 7;
            this.lblActiveBookingsNumber.Text = "0";
            // 
            // lblActiveBookingsTitle
            // 
            this.lblActiveBookingsTitle.AutoSize = true;
            this.lblActiveBookingsTitle.Location = new System.Drawing.Point(12, 14);
            this.lblActiveBookingsTitle.Name = "lblActiveBookingsTitle";
            this.lblActiveBookingsTitle.Size = new System.Drawing.Size(122, 20);
            this.lblActiveBookingsTitle.TabIndex = 6;
            this.lblActiveBookingsTitle.Text = "Active Bookings";
            // 
            // lblTotalUsersNumber
            // 
            this.lblTotalUsersNumber.AutoSize = true;
            this.lblTotalUsersNumber.Location = new System.Drawing.Point(75, 50);
            this.lblTotalUsersNumber.Name = "lblTotalUsersNumber";
            this.lblTotalUsersNumber.Size = new System.Drawing.Size(18, 20);
            this.lblTotalUsersNumber.TabIndex = 12;
            this.lblTotalUsersNumber.Text = "0";
            this.lblTotalUsersNumber.Click += new System.EventHandler(this.lblTotalUsersNumber_Click);
            // 
            // panelQuickActions
            // 
            this.panelQuickActions.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelQuickActions.Controls.Add(this.lblQuickTitle);
            this.panelQuickActions.Controls.Add(this.btnManageUsers);
            this.panelQuickActions.Controls.Add(this.btnLibraryBookings);
            this.panelQuickActions.Location = new System.Drawing.Point(53, 520);
            this.panelQuickActions.Name = "panelQuickActions";
            this.panelQuickActions.Size = new System.Drawing.Size(220, 200);
            this.panelQuickActions.TabIndex = 11;
            this.panelQuickActions.Paint += new System.Windows.Forms.PaintEventHandler(this.panelQuickActions_Paint);
            // 
            // lblQuickTitle
            // 
            this.lblQuickTitle.AutoSize = true;
            this.lblQuickTitle.Location = new System.Drawing.Point(33, 13);
            this.lblQuickTitle.Name = "lblQuickTitle";
            this.lblQuickTitle.Size = new System.Drawing.Size(106, 20);
            this.lblQuickTitle.TabIndex = 12;
            this.lblQuickTitle.Text = "Quick Actions";
            // 
            // panelRecent
            // 
            this.panelRecent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRecent.Controls.Add(this.dgvRecentBookings);
            this.panelRecent.Location = new System.Drawing.Point(32, 252);
            this.panelRecent.Name = "panelRecent";
            this.panelRecent.Size = new System.Drawing.Size(650, 250);
            this.panelRecent.TabIndex = 12;
            // 
            // panelTotalUsers
            // 
            this.panelTotalUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalUsers.Controls.Add(this.lblTotalUsersNumber);
            this.panelTotalUsers.Controls.Add(this.lblTotalUsersTitle);
            this.panelTotalUsers.Location = new System.Drawing.Point(645, 30);
            this.panelTotalUsers.Name = "panelTotalUsers";
            this.panelTotalUsers.Size = new System.Drawing.Size(175, 80);
            this.panelTotalUsers.TabIndex = 13;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 727);
            this.Controls.Add(this.panelRecent);
            this.Controls.Add(this.panelQuickActions);
            this.Controls.Add(this.panelStatsRow);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnLogout);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentBookings)).EndInit();
            this.panelStatsRow.ResumeLayout(false);
            this.panelStatsRow.PerformLayout();
            this.panelTotalBookings.ResumeLayout(false);
            this.panelTotalBookings.PerformLayout();
            this.panelActiveBookings.ResumeLayout(false);
            this.panelActiveBookings.PerformLayout();
            this.panelQuickActions.ResumeLayout(false);
            this.panelQuickActions.PerformLayout();
            this.panelRecent.ResumeLayout(false);
            this.panelTotalUsers.ResumeLayout(false);
            this.panelTotalUsers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLibraryBookings;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.DataGridView dgvRecentBookings;
        private System.Windows.Forms.Label lblTotalBookingsTitle;
        private System.Windows.Forms.Panel panelStatsRow;
        private System.Windows.Forms.Panel panelTotalBookings;
        private System.Windows.Forms.Label lblTotalUsersTitle;
        private System.Windows.Forms.Label lblTotalBookingsNumber;
        private System.Windows.Forms.Panel panelActiveBookings;
        private System.Windows.Forms.Label lblActiveBookingsNumber;
        private System.Windows.Forms.Label lblActiveBookingsTitle;
        private System.Windows.Forms.Label lblTotalUsersNumber;
        private System.Windows.Forms.Panel panelQuickActions;
        private System.Windows.Forms.Label lblQuickTitle;
        private System.Windows.Forms.Panel panelRecent;
        private System.Windows.Forms.Panel panelTotalUsers;
    }
}