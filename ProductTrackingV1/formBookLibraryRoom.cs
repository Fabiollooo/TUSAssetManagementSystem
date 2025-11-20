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
    public partial class formBookLibraryRoom : Form
    {
        IModel Model;
        LibraryRoom room;
        LibraryRoomBooking booking;

        private void RefreshInfo()
        {
            labelBookRoomRoomNumber.Text = "Room: " + room.RoomNumber;
            labelBookRoomDate.Text = "Date: " + booking.Date.ToShortDateString();
            labelBookRoomStartTime.Text = "Start Time: " + booking.StartTime.ToShortTimeString();
            labelBookRoomEndTime.Text = "End Time: " + booking.EndTime.ToShortTimeString();
        }

        public formBookLibraryRoom(IModel model, LibraryRoom selectedRoom, IUser user, DateTime date, DateTime startTime, DateTime endTime)
        {
            Model = model;
            room = selectedRoom;
            booking = new LibraryRoomBooking(user.UserID, room.LibraryRoomID, date, startTime, endTime, false);

            InitializeComponent();
            RefreshInfo();
        }

        private void btnBookRoomCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBookRoomConfirm_Click(object sender, EventArgs e)
        {
            String message = "";
            if (Model.AddNewLibraryBooking(booking))
                message = "Booking was successful!";
            else
                message = "Failed to make this booking.";

            MessageBox.Show(message, "Book A Room", MessageBoxButtons.OK);
            Close();
        }
    }
}
