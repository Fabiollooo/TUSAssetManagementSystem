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
    public partial class formContainer : Form
    {
        #region Instance Attributes
        private IModel Model;
        #endregion  
        #region Constructors
        public formContainer(IModel _Model) // gets passed a reference to the model object
        {
            InitializeComponent();
            Model = _Model;
        }
        #endregion
        private void formContainer_Shown(object sender, EventArgs e)
        {
            formLogin formLgn = new formLogin(Model);
            formLgn.ShowDialog();

           
            switch (Model.getUserTypeForCurrentuser())
            {
                case "Admin":
                    AdminDashboard dashboard = new AdminDashboard(this, Model);
                    this.Text = this.Text + " - Admin Dashboard";
                    dashboard.Dock = DockStyle.Fill;
                    dashboard.Show();
                    break;

                case "Staff":
                    formSales form2 = new formSales(this, Model);// All forms get passed the formContainer and a reference to the model object. 
                    this.Text = this.Text + "- Staff";
                    form2.Dock = DockStyle.Fill;
                    form2.Show();
                    break;
                case "Student":
                    StudentDashboard studentForm = new StudentDashboard(Model); // All forms get passed the formContainer and a reference to the model object. 
                    this.Text = this.Text + "- Student";
                    studentForm.Dock = DockStyle.Fill;
                    studentForm.Show();
                    break;
            }


        }
    }
}
