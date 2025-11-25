using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProductTracking
{
    public partial class formManager : Form
    {
        #region Instance Attributes
        private IModel Model;
        #endregion

        #region Constructors
        public formManager(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
        }
        #endregion

        private void formManager_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            formAddUser form = new formAddUser(Model);
            form.Dock = DockStyle.Fill;
            form.ShowDialog();

            this.Visible = true;
         }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            formDeleteUser form = new formDeleteUser(Model);
            form.Dock = DockStyle.Fill;
            form.ShowDialog();

            this.Visible = true;
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            formEditUser form = new formEditUser(Model);
            form.Dock = DockStyle.Fill;
            form.ShowDialog();

            this.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
