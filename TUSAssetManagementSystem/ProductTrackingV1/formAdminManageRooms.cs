using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

using Microsoft.VisualBasic;

namespace ProductTracking
{
    public partial class formAdminManageRooms : Form
    {
        private IModel Model;
        public formAdminManageRooms(IModel model)
        {
            InitializeComponent();
            Model = model;
        }

        private void formAdminManageRooms_Load(object sender, EventArgs e)
        {
            RefreshRooms();
        }

        private void RefreshRooms()
        {
            // Load all rooms (not filtered by availability like student dashboard)
            Model.populateLibraryRooms();

            if (dgvRooms != null)
            {
                dgvRooms.DataSource = null;
                dgvRooms.Columns.Clear();

                //This line hides the other two columns (roomID & roomStatusID)
                //dgvRooms.AutoGenerateColumns = false;

                dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Room Number", DataPropertyName = "roomNumber" });
                dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Capacity", DataPropertyName = "capacity" });
                dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Resources", DataPropertyName = "resources" });
                dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", DataPropertyName = "statusName" });

                dgvRooms.DataSource = Model.LibraryRoomList;
            }
        }

        private void dgvRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a room to edit.");
                return;
            }

            
            var selectedRoom = Model.LibraryRoomList[dgvRooms.SelectedRows[0].Index];
            using (formAdminEditRoom editForm = new formAdminEditRoom(Model, selectedRoom))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                   
                    RefreshRooms();
                    
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

      

        private void btnRemoveRoom_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a room to delete.");
                return;
            }

            var selectedRoom = Model.LibraryRoomList[dgvRooms.SelectedRows[0].Index];


            DialogResult result = MessageBox.Show($"Are you sure you want to delete room {selectedRoom.roomNumber}?", "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                bool success = Model.DeleteLibraryRoom(selectedRoom.roomID);

                if (success)
                {
                    MessageBox.Show("Room deleted successfully!");
                    RefreshRooms();
                }
                else
                {
                    MessageBox.Show("Failed to delete room. It may have existing bookings.");
                }
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a room to edit.");
                return;
            }

            var selectedRoom = Model.LibraryRoomList[dgvRooms.SelectedRows[0].Index];
            Form addForm = new formAdminAddRoom(Model);
            addForm.ShowDialog();

            RefreshRooms();
        }
    }
}
