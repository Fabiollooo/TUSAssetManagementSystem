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
        #endregion

        #region Constructors
        public formAddUser(IModel Model)
        {
            InitializeComponent();
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
            {
                string name = textBoxName.Text.Trim();
                string password = textBoxPassword.Text;
                string confirm = textBoxConfirmPassword.Text;
                string userType = comboUserType.SelectedItem == null
                    ? null
                    : comboUserType.SelectedItem.ToString().Trim();

                // Basic validation
                if (string.IsNullOrWhiteSpace(name) ||
                    string.IsNullOrWhiteSpace(password) ||
                    string.IsNullOrWhiteSpace(confirm) ||
                    string.IsNullOrWhiteSpace(userType))
                {
                    MessageBox.Show("Please enter a name, password, confirm it, and select a role.",
                        "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (password != confirm)
                {
                    MessageBox.Show("Passwords do not match.",
                        "Password mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Call the Model → this uses addNewUser in IModel
                bool added = Model.addNewUser(name, password, userType);

                if (added)
                {
                    MessageBox.Show("User added successfully.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Could not add user (maybe the username already exists).",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
