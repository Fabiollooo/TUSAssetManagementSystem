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

            int totalBookings = 0;
            int activeBookings = 0;
            int totalUsers = 0;

            if (Model != null && Model.OrderList != null)
            {
                totalBookings = Model.OrderList.Count;
                activeBookings = Model.OrderList.Count(o => !o.Complete);
            }

        
            if (Model != null && Model.UserList != null)
            {
                totalUsers = Model.UserList.Count;
            }

         
            lblTotalBookingsNumber.Text = totalBookings.ToString();
            lblActiveBookingsNumber.Text = activeBookings.ToString();
            lblTotalUsersNumber.Text = totalUsers.ToString();


     
        }


        /// <summary>
        /// Fills the Recent Bookings grid with the 5 most recent orders.
        /// </summary>
        private void LoadRecentBookings()
        {
            if (Model.OrderList == null)
            {
                try { Model.populateOrders(); } catch { }
            }

            dgvRecentBookings.Rows.Clear();
            dgvRecentBookings.Columns.Clear();

       
            dgvRecentBookings.Columns.Add("BookingId", "Booking ID");
            dgvRecentBookings.Columns.Add("LibraryRoom", "Library Room");
            dgvRecentBookings.Columns.Add("Date", "Date");
            dgvRecentBookings.Columns.Add("Time", "Time");
            dgvRecentBookings.Columns.Add("Status", "Status");

            if (Model.OrderList == null || Model.OrderList.Count == 0)
                return;

            var recent = Model.OrderList
                              .OrderByDescending(o => o.OrderDate)
                              .Take(5)
                              .ToList();

            foreach (var order in recent)
            {
                string status = order.Complete ? "complete" : "active";

                dgvRecentBookings.Rows.Add(
                    order.OrderCode,                          
                    order.CustomerCode,                      
                    order.OrderDate.ToShortDateString(),      
                    order.OrderDate.ToString("HH:mm"),        
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
            MessageBox.Show(
                "Library Bookings feature coming soon!",
                "Coming Soon",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
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
    }
}
