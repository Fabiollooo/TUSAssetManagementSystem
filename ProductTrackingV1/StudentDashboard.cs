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
            dtpBookingDate.Value = DateTime.Now;
            dtpBookingStartTime.Value = DateTime.Now;
            dtpBookingEndTime.Value = DateTime.Now.AddHours(1);
            this.Load += StudentDashboard_Load;
        }

        private void RefreshRooms()
        {
            if (dtpBookingStartTime.Value > dtpBookingEndTime.Value)
                dtpBookingEndTime.Value = dtpBookingStartTime.Value.AddHours(1);

            selectedDate = dtpBookingDate.Value;
            selectedStartTime = dtpBookingStartTime.Value;
            selectedEndTime = dtpBookingEndTime.Value;

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

        private void RefreshMyBookings()
        {
            Model.populateLibraryRoomBookings(Model.CurrentUser);

            lblMyBookingsUpcoming.Text = Model.GetUpcomingBookingsCount(Model.CurrentUser.UserID).ToString();
            lblMyBookingsTotal.Text = Model.CountActiveBookingsForUser(Model.CurrentUser.UserID).ToString();
            lblMyBookingsCancelled.Text = Model.CountCancelledBookingsForUser(Model.CurrentUser.UserID).ToString();
            lblMyBookingsCompleted.Text = Model.CountCompletedBookingsForUser(Model.CurrentUser.UserID).ToString();

            if (dgvMyBookings != null)
            {
                dgvMyBookings.DataSource = null;

                dgvMyBookings.Columns.Clear();
                dgvMyBookings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Room Number", DataPropertyName = "roomNumber" });
                dgvMyBookings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Booking Date", DataPropertyName = "date" });
                dgvMyBookings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Start Time", DataPropertyName = "startTime" });
                dgvMyBookings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "End Time", DataPropertyName = "endTime" });
                dgvMyBookings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cancelled", DataPropertyName = "cancelled" });

                dgvMyBookings.DataSource = Model.LibraryRoomBookingsList.Select(booking => new {
                    booking.room.roomNumber,
                    date = booking.date.ToString("dd:MM:yyyy"),
                    startTime = booking.startTime.ToString("HH:mm"),
                    endTime = booking.endTime.ToString("HH:mm"),
                    cancelled = booking.cancelled ? "True" : "False"
                }).ToList();
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

            RefreshRooms();
            RefreshMyBookings();
        }

        //Book a room button
        private void btn_BookRoom_Click(object sender, EventArgs e)
        {
            tab_dashboard.SelectedTab = tab_browserooms;
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
            RefreshMyBookings();

            button6.Visible = true;
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

        private void dtpBookingDate_ValueChanged(object sender, EventArgs e)
        {
            RefreshRooms();
        }

        private void dtpBookingStartTime_ValueChanged(object sender, EventArgs e)
        {
            RefreshRooms();
        }

        private void dtpBookingEndTime_ValueChanged(object sender, EventArgs e)
        {
            RefreshRooms();
        }
    }
}
