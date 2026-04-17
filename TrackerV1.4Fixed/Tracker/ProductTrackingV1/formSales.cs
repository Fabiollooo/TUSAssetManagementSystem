using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;

namespace ProductTracking
{
    public partial class formSales : Form
    {
        #region Instance Attributes
        private formContainer fc;
        private IModel Model;
        #endregion
        #region Constructors
        public formSales(formContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }
        #endregion

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //if (Model.Con.State.ToString() == "Open")
            //    Model.Con.Close();
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formSales_Load(object sender, EventArgs e)
        {
            //Available Rooms - 
            DataTable rooms = new DataTable();

            rooms.Columns.Add("RoomNumber");
            rooms.Columns.Add("Capacity");
            rooms.Columns.Add("Available");

            rooms.Rows.Add("R101", "4", "Y");
            rooms.Rows.Add("R102", "6", "N");
            rooms.Rows.Add("R103", "2", "Y");
            rooms.Rows.Add("R104", "8", "N");
            rooms.Rows.Add("R105", "3", "Y");

            dataGridViewRooms.DataSource = rooms;
        }
    }
}
