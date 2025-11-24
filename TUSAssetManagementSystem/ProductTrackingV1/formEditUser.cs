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
    public partial class formEditUser : Form
    {
         #region Instance Attributes
        IModel Model;
        formContainer fc;
        #endregion 

       #region Constructors
        public formEditUser(formContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;        
        }
       #endregion

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCommit_Click(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedItem == null)
            {
                MessageBox.Show("Please select a user to edit.");
                return;
            }

            string originalName = listBoxUsers.SelectedItem.ToString();
            string newName = textBoxName.Text.Trim();
            string newPassword = textBoxPassword.Text;
            string newUserType = comboUserType.SelectedItem == null
                ? null
                : comboUserType.SelectedItem.ToString().Trim();

            if (string.IsNullOrWhiteSpace(newName) ||
                string.IsNullOrWhiteSpace(newPassword) ||
                string.IsNullOrWhiteSpace(newUserType))
            {
                MessageBox.Show("Name, password and role are required.");
                return;
            }

            User selectedUser = null;

            foreach (User user in Model.UserList)
            {
                if (user.Name == originalName)
                {
                    selectedUser = user;
                    break;
                }
            }

            if (selectedUser == null)
            {
                MessageBox.Show("Could not find the selected user in the model.");
                return;
            }

            // Create a fresh user object with updated values
            BusinessEntities.IUser updatedUser =
                UserFactory.GetUser(newName, newPassword, newUserType, selectedUser.UserID);

            Model.editUser(updatedUser);

            MessageBox.Show("User updated successfully.");

            // Refresh UI
            textBoxName.Text = "";
            textBoxPassword.Text = "";
            comboUserType.SelectedIndex = -1;

            listBoxUsers.Items.Clear();
            foreach (User user in Model.UserList)
            {
                listBoxUsers.Items.Add(user.Name);
            }


        }

        private void formEditUser_Load(object sender, EventArgs e)
        {
            comboUserType.Items.Clear();
            comboUserType.Items.Add("Admin");
            comboUserType.Items.Add("Staff");
            comboUserType.Items.Add("Student");

            listBoxUsers.Items.Clear();
            foreach (User user in Model.UserList)
            {
                listBoxUsers.Items.Add(user.Name);
            }
        }

        private void listBoxUsers_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedItem == null) return;

            string selectedName = listBoxUsers.SelectedItem.ToString();

            foreach (User user in Model.UserList)
            {
                if (user.Name == selectedName)
                {
                    textBoxName.Text = user.Name;
                    textBoxPassword.Text = user.Password;
                    comboUserType.SelectedItem = user.UserType;
                    break;
                }

            }
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
