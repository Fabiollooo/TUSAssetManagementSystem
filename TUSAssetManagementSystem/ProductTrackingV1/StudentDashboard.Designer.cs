using System.Windows.Forms;

namespace ProductTracking
{
    partial class StudentDashboard
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
            this.tab_dashboard = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_ManageBookings = new System.Windows.Forms.Button();
            this.btn_BookRoom = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelRoom3 = new System.Windows.Forms.Panel();
            this.lblID3 = new System.Windows.Forms.Label();
            this.lblTime3 = new System.Windows.Forms.Label();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.panelRoom2 = new System.Windows.Forms.Panel();
            this.lblID2 = new System.Windows.Forms.Label();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelRoom1 = new System.Windows.Forms.Panel();
            this.lblID1 = new System.Windows.Forms.Label();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.lblUpcomingNo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.lblHoursBooked = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNoActiveBookings = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_browserooms = new System.Windows.Forms.TabPage();
            this.dtpBookingEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpBookingStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.tab_mybookings = new System.Windows.Forms.TabPage();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.dgvMyBookings = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblMyBookingsTotal = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblMyBookingsCancelled = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblMyBookingsCompleted = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lblMyBookingsUpcoming = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tab_dashboard.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelRoom3.SuspendLayout();
            this.panelRoom2.SuspendLayout();
            this.panelRoom1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab_browserooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.tab_mybookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyBookings)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_dashboard
            // 
            this.tab_dashboard.Controls.Add(this.tabPage1);
            this.tab_dashboard.Controls.Add(this.tab_browserooms);
            this.tab_dashboard.Controls.Add(this.tab_mybookings);
            this.tab_dashboard.Location = new System.Drawing.Point(12, 12);
            this.tab_dashboard.Name = "tab_dashboard";
            this.tab_dashboard.SelectedIndex = 0;
            this.tab_dashboard.Size = new System.Drawing.Size(1075, 690);
            this.tab_dashboard.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLogOut);
            this.tabPage1.Controls.Add(this.lblWelcome);
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1067, 664);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(927, 48);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(84, 34);
            this.btnLogOut.TabIndex = 12;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(768, 48);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(138, 17);
            this.lblWelcome.TabIndex = 11;
            this.lblWelcome.Text = "Welcoming message";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.btn_ManageBookings);
            this.panel6.Controls.Add(this.btn_BookRoom);
            this.panel6.Location = new System.Drawing.Point(688, 258);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(340, 233);
            this.panel6.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Quick Actions";
            // 
            // btn_ManageBookings
            // 
            this.btn_ManageBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageBookings.Location = new System.Drawing.Point(22, 139);
            this.btn_ManageBookings.Name = "btn_ManageBookings";
            this.btn_ManageBookings.Size = new System.Drawing.Size(299, 38);
            this.btn_ManageBookings.TabIndex = 2;
            this.btn_ManageBookings.Text = "Manage Bookings";
            this.btn_ManageBookings.UseVisualStyleBackColor = true;
            this.btn_ManageBookings.Click += new System.EventHandler(this.btn_ManageBookings_Click);
            // 
            // btn_BookRoom
            // 
            this.btn_BookRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BookRoom.Location = new System.Drawing.Point(22, 64);
            this.btn_BookRoom.Name = "btn_BookRoom";
            this.btn_BookRoom.Size = new System.Drawing.Size(299, 38);
            this.btn_BookRoom.TabIndex = 0;
            this.btn_BookRoom.Text = "Book a Room";
            this.btn_BookRoom.UseVisualStyleBackColor = true;
            this.btn_BookRoom.Click += new System.EventHandler(this.btn_BookRoom_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.panelRoom3);
            this.panel5.Controls.Add(this.panelRoom2);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.panelRoom1);
            this.panel5.Location = new System.Drawing.Point(25, 258);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(643, 322);
            this.panel5.TabIndex = 8;
            // 
            // panelRoom3
            // 
            this.panelRoom3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRoom3.Controls.Add(this.lblID3);
            this.panelRoom3.Controls.Add(this.lblTime3);
            this.panelRoom3.Controls.Add(this.lblTitle3);
            this.panelRoom3.Location = new System.Drawing.Point(17, 219);
            this.panelRoom3.Name = "panelRoom3";
            this.panelRoom3.Size = new System.Drawing.Size(594, 82);
            this.panelRoom3.TabIndex = 3;
            // 
            // lblID3
            // 
            this.lblID3.AutoSize = true;
            this.lblID3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID3.Location = new System.Drawing.Point(10, 58);
            this.lblID3.Name = "lblID3";
            this.lblID3.Size = new System.Drawing.Size(43, 17);
            this.lblID3.TabIndex = 2;
            this.lblID3.Text = "lblID3";
            // 
            // lblTime3
            // 
            this.lblTime3.AutoSize = true;
            this.lblTime3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime3.Location = new System.Drawing.Point(10, 35);
            this.lblTime3.Name = "lblTime3";
            this.lblTime3.Size = new System.Drawing.Size(61, 17);
            this.lblTime3.TabIndex = 1;
            this.lblTime3.Text = "lblTime3";
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle3.Location = new System.Drawing.Point(9, 5);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(74, 24);
            this.lblTitle3.TabIndex = 0;
            this.lblTitle3.Text = "lblTitle3";
            // 
            // panelRoom2
            // 
            this.panelRoom2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRoom2.Controls.Add(this.lblID2);
            this.panelRoom2.Controls.Add(this.lblTime2);
            this.panelRoom2.Controls.Add(this.lblTitle2);
            this.panelRoom2.Location = new System.Drawing.Point(17, 131);
            this.panelRoom2.Name = "panelRoom2";
            this.panelRoom2.Size = new System.Drawing.Size(594, 82);
            this.panelRoom2.TabIndex = 3;
            // 
            // lblID2
            // 
            this.lblID2.AutoSize = true;
            this.lblID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID2.Location = new System.Drawing.Point(10, 58);
            this.lblID2.Name = "lblID2";
            this.lblID2.Size = new System.Drawing.Size(43, 17);
            this.lblID2.TabIndex = 2;
            this.lblID2.Text = "lblID2";
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime2.Location = new System.Drawing.Point(10, 35);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(61, 17);
            this.lblTime2.TabIndex = 1;
            this.lblTime2.Text = "lblTime2";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.Location = new System.Drawing.Point(9, 5);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(74, 24);
            this.lblTitle2.TabIndex = 0;
            this.lblTitle2.Text = "lblTitle2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Upcoming Bookings";
            // 
            // panelRoom1
            // 
            this.panelRoom1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRoom1.Controls.Add(this.lblID1);
            this.panelRoom1.Controls.Add(this.lblTime1);
            this.panelRoom1.Controls.Add(this.lblTitle1);
            this.panelRoom1.Location = new System.Drawing.Point(17, 43);
            this.panelRoom1.Name = "panelRoom1";
            this.panelRoom1.Size = new System.Drawing.Size(594, 82);
            this.panelRoom1.TabIndex = 0;
            // 
            // lblID1
            // 
            this.lblID1.AutoSize = true;
            this.lblID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID1.Location = new System.Drawing.Point(10, 58);
            this.lblID1.Name = "lblID1";
            this.lblID1.Size = new System.Drawing.Size(43, 17);
            this.lblID1.TabIndex = 2;
            this.lblID1.Text = "lblID1";
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime1.Location = new System.Drawing.Point(10, 35);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(61, 17);
            this.lblTime1.TabIndex = 1;
            this.lblTime1.Text = "lblTime1";
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.Location = new System.Drawing.Point(9, 5);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(74, 24);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "lblTitle1";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.lblUpcomingNo);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(828, 132);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(13, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Next 7 days";
            // 
            // lblUpcomingNo
            // 
            this.lblUpcomingNo.AutoSize = true;
            this.lblUpcomingNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpcomingNo.Location = new System.Drawing.Point(12, 43);
            this.lblUpcomingNo.Name = "lblUpcomingNo";
            this.lblUpcomingNo.Size = new System.Drawing.Size(16, 17);
            this.lblUpcomingNo.TabIndex = 10;
            this.lblUpcomingNo.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Upcoming";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.lblHoursBooked);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(565, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(12, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "This month";
            // 
            // lblHoursBooked
            // 
            this.lblHoursBooked.AutoSize = true;
            this.lblHoursBooked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursBooked.Location = new System.Drawing.Point(12, 43);
            this.lblHoursBooked.Name = "lblHoursBooked";
            this.lblHoursBooked.Size = new System.Drawing.Size(16, 17);
            this.lblHoursBooked.TabIndex = 9;
            this.lblHoursBooked.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Hours Booked";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(295, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(15, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Right Now";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Available Rooms";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblNoActiveBookings);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(25, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 2;
            // 
            // lblNoActiveBookings
            // 
            this.lblNoActiveBookings.AutoSize = true;
            this.lblNoActiveBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoActiveBookings.Location = new System.Drawing.Point(13, 43);
            this.lblNoActiveBookings.Name = "lblNoActiveBookings";
            this.lblNoActiveBookings.Size = new System.Drawing.Size(16, 17);
            this.lblNoActiveBookings.TabIndex = 7;
            this.lblNoActiveBookings.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Active Bookings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome back! Here\'s an overview of you bookings";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tab_browserooms
            // 
            this.tab_browserooms.Controls.Add(this.dtpBookingEndTime);
            this.tab_browserooms.Controls.Add(this.dtpBookingStartTime);
            this.tab_browserooms.Controls.Add(this.dtpBookingDate);
            this.tab_browserooms.Controls.Add(this.button6);
            this.tab_browserooms.Controls.Add(this.button5);
            this.tab_browserooms.Controls.Add(this.label17);
            this.tab_browserooms.Controls.Add(this.label18);
            this.tab_browserooms.Controls.Add(this.dgvRooms);
            this.tab_browserooms.Location = new System.Drawing.Point(4, 22);
            this.tab_browserooms.Name = "tab_browserooms";
            this.tab_browserooms.Padding = new System.Windows.Forms.Padding(3);
            this.tab_browserooms.Size = new System.Drawing.Size(1067, 664);
            this.tab_browserooms.TabIndex = 1;
            this.tab_browserooms.Text = "Browse Rooms";
            this.tab_browserooms.UseVisualStyleBackColor = true;
            this.tab_browserooms.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dtpBookingEndTime
            // 
            this.dtpBookingEndTime.CustomFormat = "HH:mm";
            this.dtpBookingEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookingEndTime.Location = new System.Drawing.Point(293, 109);
            this.dtpBookingEndTime.Name = "dtpBookingEndTime";
            this.dtpBookingEndTime.ShowUpDown = true;
            this.dtpBookingEndTime.Size = new System.Drawing.Size(110, 20);
            this.dtpBookingEndTime.TabIndex = 12;
            this.dtpBookingEndTime.ValueChanged += new System.EventHandler(this.dtpBookingEndTime_ValueChanged);
            // 
            // dtpBookingStartTime
            // 
            this.dtpBookingStartTime.CustomFormat = "HH:mm";
            this.dtpBookingStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookingStartTime.Location = new System.Drawing.Point(177, 109);
            this.dtpBookingStartTime.Name = "dtpBookingStartTime";
            this.dtpBookingStartTime.ShowUpDown = true;
            this.dtpBookingStartTime.Size = new System.Drawing.Size(110, 20);
            this.dtpBookingStartTime.TabIndex = 11;
            this.dtpBookingStartTime.Value = new System.DateTime(2025, 11, 16, 0, 0, 0, 0);
            this.dtpBookingStartTime.ValueChanged += new System.EventHandler(this.dtpBookingStartTime_ValueChanged);
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.CustomFormat = "";
            this.dtpBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBookingDate.Location = new System.Drawing.Point(53, 109);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(118, 20);
            this.dtpBookingDate.TabIndex = 10;
            this.dtpBookingDate.Value = new System.DateTime(2025, 11, 16, 20, 37, 27, 0);
            this.dtpBookingDate.ValueChanged += new System.EventHandler(this.dtpBookingDate_ValueChanged);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(877, 543);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 36);
            this.button6.TabIndex = 9;
            this.button6.Text = "Book room";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(817, 106);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Apply Filter";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(19, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(343, 20);
            this.label17.TabIndex = 5;
            this.label17.Text = "Find and book the perfect space for your needs";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(17, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(610, 45);
            this.label18.TabIndex = 4;
            this.label18.Text = "Browse Rooms and Resource";
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.AllowUserToResizeColumns = false;
            this.dgvRooms.AllowUserToResizeRows = false;
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(45, 157);
            this.dgvRooms.MultiSelect = false;
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(942, 355);
            this.dgvRooms.TabIndex = 2;
            this.dgvRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellContentClick);
            // 
            // tab_mybookings
            // 
            this.tab_mybookings.Controls.Add(this.btnCheckIn);
            this.tab_mybookings.Controls.Add(this.label24);
            this.tab_mybookings.Controls.Add(this.dgvMyBookings);
            this.tab_mybookings.Controls.Add(this.panel9);
            this.tab_mybookings.Controls.Add(this.label21);
            this.tab_mybookings.Controls.Add(this.label22);
            this.tab_mybookings.Controls.Add(this.panel10);
            this.tab_mybookings.Controls.Add(this.panel11);
            this.tab_mybookings.Controls.Add(this.panel12);
            this.tab_mybookings.Location = new System.Drawing.Point(4, 22);
            this.tab_mybookings.Name = "tab_mybookings";
            this.tab_mybookings.Padding = new System.Windows.Forms.Padding(3);
            this.tab_mybookings.Size = new System.Drawing.Size(1067, 664);
            this.tab_mybookings.TabIndex = 3;
            this.tab_mybookings.Text = "My Bookings";
            this.tab_mybookings.UseVisualStyleBackColor = true;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(937, 251);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(90, 35);
            this.btnCheckIn.TabIndex = 19;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(21, 266);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(99, 20);
            this.label24.TabIndex = 18;
            this.label24.Text = "My Bookings";
            // 
            // dgvMyBookings
            // 
            this.dgvMyBookings.AllowUserToAddRows = false;
            this.dgvMyBookings.AllowUserToDeleteRows = false;
            this.dgvMyBookings.AllowUserToResizeColumns = false;
            this.dgvMyBookings.AllowUserToResizeRows = false;
            this.dgvMyBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyBookings.Location = new System.Drawing.Point(24, 301);
            this.dgvMyBookings.MultiSelect = false;
            this.dgvMyBookings.Name = "dgvMyBookings";
            this.dgvMyBookings.ReadOnly = true;
            this.dgvMyBookings.RowHeadersVisible = false;
            this.dgvMyBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyBookings.Size = new System.Drawing.Size(1003, 340);
            this.dgvMyBookings.TabIndex = 17;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.lblMyBookingsTotal);
            this.panel9.Controls.Add(this.label20);
            this.panel9.Location = new System.Drawing.Point(24, 125);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 100);
            this.panel9.TabIndex = 13;
            // 
            // lblMyBookingsTotal
            // 
            this.lblMyBookingsTotal.AutoSize = true;
            this.lblMyBookingsTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyBookingsTotal.Location = new System.Drawing.Point(13, 43);
            this.lblMyBookingsTotal.Name = "lblMyBookingsTotal";
            this.lblMyBookingsTotal.Size = new System.Drawing.Size(16, 17);
            this.lblMyBookingsTotal.TabIndex = 7;
            this.lblMyBookingsTotal.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(13, 12);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(114, 20);
            this.label20.TabIndex = 6;
            this.label20.Text = "Total Bookings";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(20, 58);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(300, 20);
            this.label21.TabIndex = 12;
            this.label21.Text = "View and manage your room reservations";
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(18, 13);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(267, 45);
            this.label22.TabIndex = 11;
            this.label22.Text = "My Bookings";
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel10.Controls.Add(this.lblMyBookingsCancelled);
            this.panel10.Controls.Add(this.label26);
            this.panel10.Location = new System.Drawing.Point(827, 125);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 100);
            this.panel10.TabIndex = 16;
            // 
            // lblMyBookingsCancelled
            // 
            this.lblMyBookingsCancelled.AutoSize = true;
            this.lblMyBookingsCancelled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyBookingsCancelled.Location = new System.Drawing.Point(12, 43);
            this.lblMyBookingsCancelled.Name = "lblMyBookingsCancelled";
            this.lblMyBookingsCancelled.Size = new System.Drawing.Size(16, 17);
            this.lblMyBookingsCancelled.TabIndex = 10;
            this.lblMyBookingsCancelled.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(12, 12);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(79, 20);
            this.label26.TabIndex = 9;
            this.label26.Text = "Cancelled";
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Controls.Add(this.lblMyBookingsCompleted);
            this.panel11.Controls.Add(this.label29);
            this.panel11.Location = new System.Drawing.Point(564, 125);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(200, 100);
            this.panel11.TabIndex = 15;
            // 
            // lblMyBookingsCompleted
            // 
            this.lblMyBookingsCompleted.AutoSize = true;
            this.lblMyBookingsCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyBookingsCompleted.Location = new System.Drawing.Point(12, 43);
            this.lblMyBookingsCompleted.Name = "lblMyBookingsCompleted";
            this.lblMyBookingsCompleted.Size = new System.Drawing.Size(16, 17);
            this.lblMyBookingsCompleted.TabIndex = 9;
            this.lblMyBookingsCompleted.Text = "0";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(12, 12);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(86, 20);
            this.label29.TabIndex = 9;
            this.label29.Text = "Completed";
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel12.Controls.Add(this.lblMyBookingsUpcoming);
            this.panel12.Controls.Add(this.label23);
            this.panel12.Location = new System.Drawing.Point(294, 125);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 100);
            this.panel12.TabIndex = 14;
            // 
            // lblMyBookingsUpcoming
            // 
            this.lblMyBookingsUpcoming.AutoSize = true;
            this.lblMyBookingsUpcoming.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyBookingsUpcoming.Location = new System.Drawing.Point(14, 43);
            this.lblMyBookingsUpcoming.Name = "lblMyBookingsUpcoming";
            this.lblMyBookingsUpcoming.Size = new System.Drawing.Size(16, 17);
            this.lblMyBookingsUpcoming.TabIndex = 8;
            this.lblMyBookingsUpcoming.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(14, 12);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(81, 20);
            this.label23.TabIndex = 8;
            this.label23.Text = "Upcoming";
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 712);
            this.Controls.Add(this.tab_dashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StudentDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Dashboard";
            this.tab_dashboard.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelRoom3.ResumeLayout(false);
            this.panelRoom3.PerformLayout();
            this.panelRoom2.ResumeLayout(false);
            this.panelRoom2.PerformLayout();
            this.panelRoom1.ResumeLayout(false);
            this.panelRoom1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab_browserooms.ResumeLayout(false);
            this.tab_browserooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.tab_mybookings.ResumeLayout(false);
            this.tab_mybookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyBookings)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_dashboard;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tab_browserooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tab_mybookings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblUpcomingNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblHoursBooked;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_ManageBookings;
        private System.Windows.Forms.Button btn_BookRoom;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNoActiveBookings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblMyBookingsTotal;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblMyBookingsCancelled;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lblMyBookingsCompleted;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lblMyBookingsUpcoming;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView dgvMyBookings;
        private DateTimePicker dtpBookingDate;
        private DateTimePicker dtpBookingEndTime;
        private DateTimePicker dtpBookingStartTime;
        private Label lblWelcome;
        private Button btnLogOut;
        private Label label4;
        private Panel panelRoom1;
        private Label lblID1;
        private Label lblTime1;
        private Label lblTitle1;
        private Panel panelRoom3;
        private Label lblID3;
        private Label lblTime3;
        private Label lblTitle3;
        private Panel panelRoom2;
        private Label lblID2;
        private Label lblTime2;
        private Label lblTitle2;
        private Button btnCheckIn;
    }
}