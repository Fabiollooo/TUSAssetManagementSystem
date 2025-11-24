using BusinessEntities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductTracking
{
    public partial class AdminLibraryDashboard : Form
    {
        private readonly IModel Model;
        private formContainer parentForm;

        public AdminLibraryDashboard(formContainer parentForm, IModel model)
        {
            InitializeComponent();
            Model = model;
        }

        private void AdminLibraryDashboard_Load(object sender, EventArgs e)
        {
            
            Model.AutoCancelNoShowBookings();

            RefreshBookingsGrid();

        }
        private void RefreshBookingsGrid()
        {
            Model.populateAllCurrentLibraryBookings();

            dgvLibraryBookings.DataSource = null;
            dgvLibraryBookings.Columns.Clear();
            dgvLibraryBookings.AutoGenerateColumns = false;

            var colBookingId = new DataGridViewTextBoxColumn
            {
                HeaderText = "Booking ID",
                DataPropertyName = "bookingID",
                Name = "bookingID"
            };

            var colRoom = new DataGridViewTextBoxColumn
            {
                HeaderText = "Room",
                Name = "room"
            };

            var colDate = new DataGridViewTextBoxColumn
            {
                HeaderText = "Date",
                DataPropertyName = "date",
                Name = "date"
            };
            colDate.DefaultCellStyle.Format = "dd/MM/yyyy";

            var colStart = new DataGridViewTextBoxColumn
            {
                HeaderText = "Start",
                DataPropertyName = "startTime",
                Name = "startTime"
            };
            colStart.DefaultCellStyle.Format = "HH:mm";

            var colEnd = new DataGridViewTextBoxColumn
            {
                HeaderText = "End",
                DataPropertyName = "endTime",
                Name = "endTime"
            };
            colEnd.DefaultCellStyle.Format = "HH:mm";

            var colCancelled = new DataGridViewCheckBoxColumn
            {
                HeaderText = "Cancelled",
                DataPropertyName = "cancelled",
                Name = "cancelled"
            };

            var colCheckedIn = new DataGridViewCheckBoxColumn
            {
                HeaderText = "Checked In",
                DataPropertyName = "checkedIn",
                Name = "checkedIn"
            };

            dgvLibraryBookings.Columns.AddRange(new DataGridViewColumn[]
            {
        colBookingId,
        colRoom,
        colDate,
        colStart,
        colEnd,
        colCancelled,
        colCheckedIn
            });

            dgvLibraryBookings.DataSource = Model.LibraryRoomBookingsList;

            foreach (DataGridViewRow row in dgvLibraryBookings.Rows)
            {
                var booking = row.DataBoundItem as LibraryRoomBooking;

                if (booking != null && booking.room != null)
                {
                    row.Cells["room"].Value = booking.room.roomNumber;
                }
                else
                {
                    row.Cells["room"].Value = "Unknown";
                }
            }
        }




        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshBookingsGrid();
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (dgvLibraryBookings.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking first.", "No Booking Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bookingId = (int)dgvLibraryBookings.CurrentRow.Cells["bookingID"].Value;

            bool success = Model.CancelLibraryBooking(bookingId);

            if (success)
            {
                MessageBox.Show("Booking has been successfully cancelled.",
                    "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to cancel the booking.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshBookingsGrid();
        }


        private void btnAutoCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "This will automatically cancel all bookings that have NOT been checked in and whose end time has already passed.\n\nDo you want to continue?",
                "Auto-Cancel No-Shows",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            int affected = Model.AutoCancelNoShowBookings();

            MessageBox.Show(
                $"{affected} booking(s) were auto-cancelled due to no check-in.",
                "Auto-Cancel Complete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            RefreshBookingsGrid();
        }


        private void dgvLibraryBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                AdminDashboard dash = new AdminDashboard(parentForm, Model);
                dash.MdiParent = parentForm;
                dash.Dock = DockStyle.Fill;
                dash.Show();

                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error returning to dashboard: " + ex.Message);
            }
        }

    }
}
