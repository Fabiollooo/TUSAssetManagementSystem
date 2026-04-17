using System;
using System.Linq;
using System.Windows.Forms;
using BusinessLayer;
using BusinessEntities;

namespace ProductTracking
{
    public partial class EditBookingForm : Form
    {
        private readonly IModel _model;
        private readonly LibraryRoomBooking _booking;

        // default ctor – only for designer
        public EditBookingForm()
        {
            InitializeComponent();
        }

        // ctor used from StudentDashboard
        public EditBookingForm(IModel model, LibraryRoomBooking booking)
        {
            InitializeComponent();

            _model = model;
            _booking = booking;

            // make sure the date is fully editable
            dtpDate.Enabled = true;
            dtpDate.ShowUpDown = false;
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dddd dd MMMM yyyy";

            dtpDate.MinDate = DateTimePicker.MinimumDateTime;
            dtpDate.MaxDate = DateTimePicker.MaximumDateTime;

            // load current values
            dtpDate.Value = _booking.date.Date;
            dtpStart.Value = _booking.startTime;
            dtpEnd.Value = _booking.endTime;

            LoadRooms();
        }

        private void LoadRooms()
        {
            _model.populateLibraryRooms(dtpDate.Value, dtpStart.Value, dtpEnd.Value);

            cboRoom.DataSource = null;
            cboRoom.DataSource = _model.LibraryRoomList;
            cboRoom.DisplayMember = "roomNumber";
            cboRoom.ValueMember = "roomID";

            var current = _model.LibraryRoomList
                                .FirstOrDefault(r => r.roomID == _booking.room.roomID);

            if (current != null)
            {
                cboRoom.SelectedItem = current;
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadRooms();
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            LoadRooms();
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            LoadRooms();
        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            // nothing needed here yet
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _booking.date = dtpDate.Value.Date;
            _booking.startTime = dtpStart.Value;
            _booking.endTime = dtpEnd.Value;
            _booking.room = (LibraryRoom)cboRoom.SelectedItem;

            if (_model.UpdateLibraryRoomBooking(_booking))
            {
                MessageBox.Show("Booking updated successfully.",
                                "Updated",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Failed to update booking.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
