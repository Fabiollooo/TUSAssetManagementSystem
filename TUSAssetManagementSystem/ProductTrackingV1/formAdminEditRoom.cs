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
    public partial class formAdminEditRoom : Form
    {
        private IModel Model;
        private LibraryRoom room;


        public formAdminEditRoom(IModel model, LibraryRoom selectedRoom)
        {
            InitializeComponent();

            Model = model;
            room = selectedRoom;

           
            txtRoomNumber.Text = room.roomNumber;
            UpDownCapacity.Value = room.capacity;
            txtResources.Text = room.resources;

            
            comboStatus.Items.Add("1 - Unknown");
            comboStatus.Items.Add("2 - Available");
            comboStatus.Items.Add("3 - Unavailable");
            comboStatus.Items.Add("4 - In Use");
            comboStatus.Items.Add("5 - Booked");

            comboStatus.SelectedIndex = room.roomStatusID - 1;
        }

        private void formAdminEditRoom_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            room.roomNumber = txtRoomNumber.Text;
            room.capacity = (int)UpDownCapacity.Value;
            room.resources = txtResources.Text;
            room.roomStatusID = comboStatus.SelectedIndex + 1; 

            bool success = Model.UpdateLibraryRoom(room);

            if (success)
            {
                MessageBox.Show("Room updated successfully!");
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update room.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; 
            this.Close();
        }
    }
}
