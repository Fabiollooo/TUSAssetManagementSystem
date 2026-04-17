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
    public partial class formAdminAddRoom : Form
    {
        private IModel Model;
        public formAdminAddRoom(IModel model)
        {
            InitializeComponent();

            Model = model;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            string roomNumber = txtRoomNumber.Text;
            int capacity = (int)nudCapacity.Value;
            string resources = txtResources.Text;
            string statusName = cmbStatus.SelectedItem.ToString();
            int statusId = (statusName == "Available" ? 2 : 3);

            string roomType = cmbRoomType.SelectedItem.ToString();
            

            bool success = Model.AddLibraryRoom(roomNumber, capacity, resources, statusId, statusName, roomType);
            if (success)
            {
                MessageBox.Show("Library room added successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add library room.");
            }
        }

        private void btnCancelAddRoom_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblRoomType_Click(object sender, EventArgs e)
        {

        }

        private void formAdminAddRoom_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Not Available");
            cmbRoomType.Items.Clear();
            cmbRoomType.Items.Add("Staff");
            cmbRoomType.Items.Add("Student");
 

        
            if (cmbStatus.Items.Count > 0) cmbStatus.SelectedIndex = 0;
            if (cmbRoomType.Items.Count > 0) cmbRoomType.SelectedIndex = 0;
        }
    }
}
