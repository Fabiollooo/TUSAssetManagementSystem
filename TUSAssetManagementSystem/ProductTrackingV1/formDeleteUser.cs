using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessLayer;
using BusinessEntities;


namespace ProductTracking
{
    public partial class formDeleteUser : Form
    {
        #region Instance Attributes
        IModel Model;
        formContainer fc;
        #endregion 

       #region Constructors
        public formDeleteUser(formContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;        
        }
        #endregion

        private void buttonDelete_Click(object sender, EventArgs e)
        {
        
            if (listBoxUsers.SelectedItem == null)
            {
                MessageBox.Show("Please select a user to delete first.",
                                "No user selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string selectedName = listBoxUsers.SelectedItem.ToString();

            DialogResult result = MessageBox.Show(
                "Delete " + selectedName + " ?",
                "Are you sure?",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Cancel)
                return;

            User userToDelete = null;

            foreach (User user in Model.UserList)
            {
                if (user.Name == selectedName)
                {
                    userToDelete = user;
                    break;
                }
            }

            if (userToDelete == null)
            {
                MessageBox.Show("Could not find that user in the system.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            
            Model.deleteUser(userToDelete);
            listBoxUsers.Items.Remove(selectedName);
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formDeleteUser_Load(object sender, EventArgs e)
        {
            foreach (User user in Model.UserList)
            {
                listBoxUsers.Items.Add(user.Name);
            }
        
        }
    }
}
