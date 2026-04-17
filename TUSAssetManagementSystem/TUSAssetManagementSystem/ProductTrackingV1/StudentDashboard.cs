using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            lblNoActiveBookings.Text = Model.CountActiveBookingsForUser(Model.CurrentUser.UserID).ToString();
            lblHoursBooked.Text = Model.GetHoursBookedThisMonth(Model.CurrentUser.UserID).ToString();
            lblUpcomingNo.Text = Model.GetUpcomingBookingsCount(Model.CurrentUser.UserID).ToString();
            lblAvailableRooms.Text = Model.GetAvailableRoomsCount(Model.CurrentUser.UserID).ToString();

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


            LoadUpcomingBookings();
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
                dgvRooms.AutoGenerateColumns = false;

                dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Room Number", DataPropertyName = "roomNumber" });
                dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Capacity", DataPropertyName = "capacity" });
                dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Resources", DataPropertyName = "resources" });
                dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", DataPropertyName = "statusName" });


                string userType = Model.CurrentUser.UserType;
                var filteredRooms = Model.LibraryRoomList.Where(room =>
                    room.roomType == userType || room.roomType == "Both"
                ).ToList();

                dgvRooms.DataSource = filteredRooms;
            }
        }

        private void RefreshMyBookings()
        {
            Model.populateLibraryRoomBookings(Model.CurrentUser);

            lblMyBookingsUpcoming.Text = Model.GetUpcomingBookingsCount(Model.CurrentUser.UserID).ToString();
            lblMyBookingsTotal.Text = Model.CountTotalBookings(Model.CurrentUser.UserID).ToString();
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
                dgvMyBookings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Checked In", DataPropertyName = "checkedIn" });

                dgvMyBookings.DataSource = Model.LibraryRoomBookingsList.Select(booking => new
                {
                    booking.room.roomNumber,
                    date = booking.date.ToString("dd:MM:yyyy"),
                    startTime = booking.startTime.ToString("HH:mm"),
                    endTime = booking.endTime.ToString("HH:mm"),
                    cancelled = booking.cancelled ? "True" : "False",
                    checkedIn = booking.checkedIn ? "Yes" : "No"
                }).ToList();
            }
        }

        private void RefreshDashboardStats()
        {
            try
            {

                lblNoActiveBookings.Text = Model.CountActiveBookingsForUser(Model.CurrentUser.UserID).ToString();
                lblHoursBooked.Text = Model.GetHoursBookedThisMonth(Model.CurrentUser.UserID).ToString();
                lblUpcomingNo.Text = Model.GetUpcomingBookingsCount(Model.CurrentUser.UserID).ToString();


                LoadUpcomingBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing stats: " + ex.Message);
            }
        }




        private void LoadUpcomingBookings()
        {
            try
            {

                List<LibraryRoomBooking> bookings = Model.GetTop3UpcomingBookings(Model.CurrentUser.UserID);
                DisplayBookings(bookings);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error loading upcoming bookings: " + ex.Message);
            }
        }

        private void DisplayBookings(List<LibraryRoomBooking> bookings)
        {

            panelRoom1.Visible = false;
            panelRoom2.Visible = false;
            panelRoom3.Visible = false;


            if (bookings.Count >= 1)
            {
                DisplayBooking(bookings[0], panelRoom1, lblTitle1, lblTime1, lblID1);
                panelRoom1.Visible = true;
            }
            if (bookings.Count >= 2)
            {
                DisplayBooking(bookings[1], panelRoom2, lblTitle2, lblTime2, lblID2);
                panelRoom2.Visible = true;
            }
            if (bookings.Count >= 3)
            {
                DisplayBooking(bookings[2], panelRoom3, lblTitle3, lblTime3, lblID3);
                panelRoom3.Visible = true;
            }
        }

        private void DisplayBooking(LibraryRoomBooking booking, Panel panel, Label title, Label time, Label id)
        {
            title.Text = $"Room {booking.room.roomNumber}";
            time.Text = $"{booking.date:ddd dd/MM}: {booking.startTime:HH:mm} - {booking.endTime:HH:mm}";
            id.Text = $"Booking ID: {booking.room.roomID}";
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
            RefreshDashboardStats();

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


        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (dgvMyBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to check in.");
                return;
            }

            var selectedBooking = Model.LibraryRoomBookingsList[dgvMyBookings.SelectedRows[0].Index];

            if (selectedBooking.checkedIn)
            {
                MessageBox.Show("This booking is already checked in.");
                return;
            }

            DateTime earliestCheckInTime = selectedBooking.startTime.AddMinutes(-10);
            DateTime latestCheckInTime = selectedBooking.startTime.AddMinutes(10);

            if (selectedBooking.date.Date != DateTime.Today)
            {
                MessageBox.Show("You can only check in on the day of your booking.");
                return;
            }

            if (DateTime.Now < earliestCheckInTime)
            {
                TimeSpan timeLeft = earliestCheckInTime - DateTime.Now;
                MessageBox.Show($"You can check in in {timeLeft:mm\\:ss} minutes.");
                return;
            }

            if (DateTime.Now > latestCheckInTime)
            {
                MessageBox.Show("Check-in period has expired. You can only check in up to 10 minutes after your booking start time.");
                return;
            }


            string randomCode = GenerateRandomCode();


            using (Form inputForm = new Form())
            {
                inputForm.Text = "Check-In Verification";
                inputForm.Size = new Size(350, 200);
                inputForm.StartPosition = FormStartPosition.CenterScreen;

                Label codeLabel = new Label() { Text = $"Your check-in code is: {randomCode}", Location = new Point(20, 20), AutoSize = true };
                Label instructionLabel = new Label() { Text = "Please enter the code below:", Location = new Point(20, 50), AutoSize = true };
                TextBox codeTextBox = new TextBox() { Location = new Point(20, 80), Size = new Size(200, 20) };
                Button submitButton = new Button() { Text = "Verify", Location = new Point(20, 110), DialogResult = DialogResult.OK };
                Button cancelButton = new Button() { Text = "Cancel", Location = new Point(100, 110), DialogResult = DialogResult.Cancel };

                inputForm.Controls.AddRange(new Control[] { codeLabel, instructionLabel, codeTextBox, submitButton, cancelButton });


                DialogResult result = inputForm.ShowDialog();

                if (result == DialogResult.OK && codeTextBox.Text == randomCode)
                {

                    bool success = Model.UpdateBookingCheckInStatus(selectedBooking.bookingID, true);

                    if (success)
                    {

                        selectedBooking.checkedIn = true;
                        RefreshMyBookings();
                        MessageBox.Show("Successfully checked in!", "Check-In Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update check-in status in database.", "Check-In Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Check-in cancelled.", "Check-In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid code. Check-in failed.", "Check-In Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GenerateRandomCode()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 6)
                .Select(s => s[random.Next(s.Length)]).ToArray());
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

        private void StudentDashboard_Load_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void tab_mybookings_Click(object sender, EventArgs e)
        {

        }

      




       

        private void btnEditBooking_Click_1(object sender, EventArgs e)
        {
            if (dgvMyBookings.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking to edit.");
                return;
            }

            int rowIndex = dgvMyBookings.CurrentRow.Index;

            if (rowIndex < 0 || rowIndex >= Model.LibraryRoomBookingsList.Count)
            {
                MessageBox.Show("Could not read the selected booking.");
                return;
            }

            var booking = Model.LibraryRoomBookingsList[rowIndex];

            using (var editForm = new EditBookingForm(Model, booking))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadUpcomingBookings();
                    Model.populateLibraryRoomBookings(Model.CurrentUser);
                    RefreshRooms();
                    RefreshMyBookings();


                    LoadUpcomingBookings();


                }
            }
        }
    }
}
    





    

