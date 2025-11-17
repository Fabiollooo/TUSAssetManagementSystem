using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities;
using BusinessLayer;

namespace ProductTracking
{
    public partial class StudentDashboard : Form
    {
        private IModel Model;
        private DateTime selectedDate;
        private DateTime selectedStartTime;
        private DateTime selectedEndTime;

        public StudentDashboard(IModel model)
        {
            InitializeComponent();
            Model = model;
            selectedDate = DateTime.Now;
            selectedStartTime = DateTime.Now;
            selectedEndTime = DateTime.Now.AddHours(1);
            this.Load += StudentDashboard_Load;
        }

        private void RefreshRooms()
        {

            Model.populateLibraryRooms(selectedDate, selectedStartTime, selectedEndTime);

            if (dgvRooms != null)
            {
                dgvRooms.DataSource = null;

                dgvRooms.Columns.Clear();
                dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Room Number", DataPropertyName = "RoomNumber" });
                dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Capacity", DataPropertyName = "Capacity" });
                dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Resources", DataPropertyName = "Resources" });
                dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", DataPropertyName = "StatusName" });

                dgvRooms.DataSource = Model.LibraryRoomList;
            }
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            lblNoActiveBookings.Text = Model.CountActiveBookingsForUser(Model.CurrentUser.UserID).ToString();
            lblHoursBooked.Text = Model.GetHoursBookedThisMonth(Model.CurrentUser.UserID).ToString();
            lblUpcomingNo.Text = Model.GetUpcomingBookingsCount(Model.CurrentUser.UserID).ToString();

            try
            {
                lblWelcome.Text = $"Welcome, {Model.CurrentUser.Name}";
            }
            catch
            {
                lblWelcome.Text = "Welcome!";
            }
        }

        //Book a room button
        private void btn_BookRoom_Click(object sender, EventArgs e)
        {
            tab_dashboard.SelectedTab = tab_browserooms;
        }

        //View Calendar button
        private void btn_ViewCalendar_Click(object sender, EventArgs e)
        {
            tab_dashboard.SelectedTab = tab_calendarview;
        }

        //Manage Bookings button
        private void btn_ManageBookings_Click(object sender, EventArgs e)
        {
            tab_dashboard.SelectedTab = tab_mybookings;
        }








        //Ignore
        private void dgvRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count == 0)
                return;

            DataGridViewRow selectedRow = dgvRooms.SelectedRows[0];
            if (selectedRow.DataBoundItem == null)
                return;

            button6.Visible = false;

            LibraryRoom room = selectedRow.DataBoundItem as LibraryRoom;

            Form bookLibraryRoom = new formBookLibraryRoom(Model, room, Model.CurrentUser, selectedDate, selectedStartTime, selectedEndTime);
            bookLibraryRoom.Dock = DockStyle.Fill;
            bookLibraryRoom.ShowDialog();
            RefreshRooms();

            button6.Visible = true;
        }

        private void btnStudentDashboardRoomsRefresh_Click(object sender, EventArgs e)
        {
            if (dtpBookingStartTime.Value > dtpBookingEndTime.Value)
                dtpBookingEndTime.Value = dtpBookingStartTime.Value.AddHours(1);

            selectedDate = dtpBookingDate.Value;
            selectedStartTime = dtpBookingStartTime.Value;
            selectedEndTime = dtpBookingEndTime.Value;

            RefreshRooms();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            try
            {

                this.Close();
                Application.Restart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error logging out: " + ex.Message);
            }
        }
    }
}
