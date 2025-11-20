using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLayer;

using BusinessEntities;

namespace ProductTracking
{
    public partial class formLibraryRooms : Form
    {
        private IModel Model;

        public formLibraryRooms(IModel model)
        {
            InitializeComponent();
            Model = model;

            this.Load += formLibraryRooms_Load;
        }

        private void formLibraryRooms_Load(object sender, EventArgs e)
        {
            Model.populateLibraryRooms();
            dgvRooms.DataSource = null;
            dgvRooms.DataSource = Model.LibraryRoomList;

            dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // FIX

            if (dgvRooms.Columns.Count > 0)
            {
                dgvRooms.Columns["LibraryRoomID"].HeaderText = "ID";
                dgvRooms.Columns["RoomNumber"].HeaderText = "Room Number";
                dgvRooms.Columns["Capacity"].HeaderText = "Capacity";
                dgvRooms.Columns["Resources"].HeaderText = "Resources";
                dgvRooms.Columns["RoomStatusID"].HeaderText = "Status ID";

                dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Non functionable yet
        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}


