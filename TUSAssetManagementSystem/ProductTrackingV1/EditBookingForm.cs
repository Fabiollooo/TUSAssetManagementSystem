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
        private IRoom room;

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
            room = booking.room;

            // load current values
            dtpBookingDate.Value = _booking.date.Date;
            dtpBookingStartTime.Value = _booking.startTime;
            dtpBookingEndTime.Value = _booking.endTime;

            LoadRooms();
        }

        private void LoadRooms()
        {
            _model.populateLibraryRooms(dtpBookingDate.Value, dtpBookingStartTime.Value, dtpBookingEndTime.Value);

            //cboRoom.DataSource = null;
            //cboRoom.DataSource = _model.LibraryRoomList;
            //cboRoom.DisplayMember = "roomNumber";
           // cboRoom.ValueMember = "roomID";

            var current = _model.LibraryRoomList
                                .FirstOrDefault(r => r.roomID == _booking.room.roomID);
            room = current;
            if (current != null)
            {
                cboRoom.Items.Clear();
                cboRoom.Items.Add(current.roomNumber);
                cboRoom.SelectedItem = current.roomNumber;
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
            _booking.date = dtpBookingDate.Value.Date;
            _booking.startTime = dtpBookingStartTime.Value;
            _booking.endTime = dtpBookingEndTime.Value;
            _booking.room = room;

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

        private void EditBookingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
