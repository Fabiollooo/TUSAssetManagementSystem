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

namespace ProductTracking
{
    public partial class StudentDashboard : Form
    {
        private IModel Model;


        public StudentDashboard(IModel model)
        {
            InitializeComponent();
            Model = model;
            this.Load += StudentDashboard_Load;
        }



        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            Model.populateLibraryRooms();

            if (dgvRooms != null)
            {
                dgvRooms.DataSource = null;
                dgvRooms.DataSource = Model.LibraryRoomList;
                dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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
        }

        //Book a room button
        private void btn_BookRoom_Click(object sender, EventArgs e)
        {
            tab_dashboard.SelectedTab = tab_browserooms;
        }

        //View Calendar button
        private void btn_ViewCalendar_Click(object sender, EventArgs e)
        {
            tab_dashboard.SelectedTab = tab_calendarview;
        }

        //Manage Bookings button
        private void btn_ManageBookings_Click(object sender, EventArgs e)
        {
            tab_dashboard.SelectedTab = tab_mybookings;
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


    }
}
