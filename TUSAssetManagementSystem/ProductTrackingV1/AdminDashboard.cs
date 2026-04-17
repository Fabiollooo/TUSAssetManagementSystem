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
   //test// m
        public partial class AdminDashboard : Form
        {
           
            private IModel Model;
            private formContainer parentForm;

           
            public AdminDashboard(formContainer parent, IModel model)
            {
                InitializeComponent();
                this.parentForm = parent;
                this.Model = model;

               
                try
                {
                    lblWelcome.Text = $"Welcome, {Model.CurrentUser.Name}";
                }
                catch
                {
                   
                }
            }

       
            private void btnManageUsers_Click(object sender, EventArgs e)
            {
                try
                {
                   
                    formManager manageUsersForm = new formManager(parentForm, Model);
                    manageUsersForm.MdiParent = parentForm;
                    manageUsersForm.Dock = DockStyle.Fill;
                    manageUsersForm.Show();

                    
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening Manage Users form: " + ex.Message);
                }
            }

          
            private void btnLibraryBookings_Click(object sender, EventArgs e)
            {
               
                MessageBox.Show("Library Bookings feature coming soon!",
                    "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

         
            private void btnLogout_Click(object sender, EventArgs e)
            {
                try
                {
                   
                    this.Close();
                    Application.Restart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error logging out: " + ex.Message);
                }
            }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }
    }
    }