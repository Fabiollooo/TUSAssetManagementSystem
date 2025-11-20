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
    public partial class formAddUser : Form
    {
        #region Instance Attributes
        IModel Model;
        formContainer fc;
        #endregion

        #region Constructors
        public formAddUser(formContainer parent, IModel Model)
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
        /*
         * LINQ (Language Integrated Query) is a Microsoft programming model and methodology that essentially adds formal query capabilities into Microsoft .NET-based programming languages. LINQ offers a 
         * compact, expressive, and intelligible syntax for manipulating data.
         * */
        private void buttonCommit_Click(object sender, EventArgs e)
        {
            // 1. Basic validation
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }

            if (textBoxPassword.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (comboUserType.SelectedIndex == -1)   // or listBoxUserType if you kept it
            {
                MessageBox.Show("You must select a user role.");
                return;
            }

            // 2. Duplicate name check (same as before)
            IUser duplicateUser = Model.UserList
                                       .FirstOrDefault(user => user.Name == textBoxName.Text.Trim());

            if (duplicateUser != null)
            {
                MessageBox.Show("Duplicate user name, enter a different name!");
                // optional debug:
                // MessageBox.Show(duplicateUser.Name + " " + duplicateUser.Password);
                ClearInputs();
                return;
            }

            // 3. Create user via model
            string role = comboUserType.SelectedItem.ToString(); // or listBoxUserType.SelectedItem.ToString()

            if (Model.addNewUser(textBoxName.Text.Trim(),
                                 textBoxPassword.Text,
                                 role))
            {
                MessageBox.Show("User created successfully.");
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Error creating user.");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            
                ClearInputs();
           

        }

        private void ClearInputs()
        {
            textBoxName.Text = "";
            textBoxPassword.Text = "";
            textBoxConfirmPassword.Text = "";
            comboUserType.SelectedIndex = -1;   // or listBoxUserType.ClearSelected();
        }

    }

}
