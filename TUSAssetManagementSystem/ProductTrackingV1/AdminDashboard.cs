using BusinessLayer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProductTracking
{
    public partial class AdminDashboard : Form
    {
        private IModel Model;
        private formContainer parentForm;

        public AdminDashboard(formContainer parent, IModel model)
        {
            InitializeComponent();

            this.parentForm = parent;
            this.Model = model;

          
            try
            {
                if (Model != null && Model.CurrentUser != null)
                {
                    lblWelcome.Text = $"Welcome, {Model.CurrentUser.Name}";
                }
            }
            catch
            {
                
            }
        }

       
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadStats();
            LoadRecentBookings();
        }

        /// <summary>
        /// Loads the 4 dashboard numbers:
        /// Total Bookings, Active Bookings, Completed Bookings, Total Users.
        /// </summary>
        private void LoadStats()
        {
            try { Model.populateOrders(); } catch { }
            int activeBookings = 0;
            int totalUsers = 0;

            if (Model != null && Model.OrderList != null)
            {
                activeBookings = Model.OrderList.Count(o => !o.Complete);
            }

           
            if (Model != null && Model.UserList != null)
            {
                totalUsers = Model.UserList.Count;
            }

           
            lblTotalBookingsNumber.Text = Model.CountTotalBookings(null).ToString();
            lblActiveBookingsNumber.Text = activeBookings.ToString();
            lblTotalUsersNumber.Text = totalUsers.ToString();


     
        }


        /// <summary>
        /// Fills the Recent Bookings grid with the 5 most recent orders.
        /// </summary>

        private void LoadRecentBookings()
        {
          
            Model.populateAllCurrentLibraryBookings();

            dgvRecentBookings.Rows.Clear();
            dgvRecentBookings.Columns.Clear();

           
            dgvRecentBookings.Columns.Add("BookingID", "Booking ID");
            dgvRecentBookings.Columns.Add("Room", "Room");
            dgvRecentBookings.Columns.Add("Date", "Date");
            dgvRecentBookings.Columns.Add("StartTime", "Start");
            dgvRecentBookings.Columns.Add("EndTime", "End");
            dgvRecentBookings.Columns.Add("Status", "Status");

            var recentBookings = Model.LibraryRoomBookingsList
                                      .OrderByDescending(b => b.date)
                                      .ThenByDescending(b => b.startTime)
                                      .Take(5)
                                      .ToList();

            foreach (var booking in recentBookings)
            {
                string status;

                if (booking.cancelled)
                    status = "Cancelled";
                else if (booking.checkedIn)
                    status = "Checked In";
                else
                    status = "Active";

                dgvRecentBookings.Rows.Add(
                    booking.bookingID,
                    booking.room?.roomNumber ?? "Unknown",
                    booking.date.ToShortDateString(),
                    booking.startTime.ToString("HH:mm"),
                    booking.endTime.ToString("HH:mm"),
                    status
                );
            }
        }


        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            try
            {
                var manageUsersForm = new formManager(parentForm, Model);
                manageUsersForm.MdiParent = parentForm;
                manageUsersForm.Dock = DockStyle.Fill;
                manageUsersForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Manage Users form: " + ex.Message);
            }
        }

        private void btnLibraryBookings_Click(object sender, EventArgs e)
        {

            using (formAdminManageRooms manageRoomsForm = new formAdminManageRooms(Model))
            {
                this.Hide(); 
                manageRoomsForm.ShowDialog();
                this.Show(); 
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
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

        private void dgvRecentBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void panelQuickActions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTotalUsersNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalBookingsNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalUsersTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnlibrary_Click(object sender, EventArgs e)
        {
            try
            {
            
                AdminLibraryDashboard libForm = new AdminLibraryDashboard(parentForm, Model);

             
                libForm.MdiParent = parentForm;
                libForm.Dock = DockStyle.Fill;
                libForm.Show();

            
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Library Bookings form: " + ex.Message);
            }
        }
    }
}
