namespace ProductTracking
{
    partial class formManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.LblUserManagement = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(55, 443);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 40);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(46, 85);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(452, 61);
            this.buttonAddUser.TabIndex = 1;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(46, 215);
            this.buttonDeleteUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(452, 69);
            this.buttonDeleteUser.TabIndex = 2;
            this.buttonDeleteUser.Text = "DeleteUser";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Location = new System.Drawing.Point(46, 332);
            this.buttonEditUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(452, 78);
            this.buttonEditUser.TabIndex = 3;
            this.buttonEditUser.Text = "Edit User";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            this.buttonEditUser.Click += new System.EventHandler(this.buttonEditUser_Click);
            // 
            // LblUserManagement
            // 
            this.LblUserManagement.AutoSize = true;
            this.LblUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserManagement.Location = new System.Drawing.Point(404, 87);
            this.LblUserManagement.Name = "LblUserManagement";
            this.LblUserManagement.Size = new System.Drawing.Size(210, 29);
            this.LblUserManagement.TabIndex = 4;
            this.LblUserManagement.Text = "User Managment";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonAddUser);
            this.panel1.Controls.Add(this.buttonEditUser);
            this.panel1.Controls.Add(this.buttonDeleteUser);
            this.panel1.Location = new System.Drawing.Point(216, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 527);
            this.panel1.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(84, 105);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 36);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // formManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(967, 769);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblUserManagement);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formManager";
            this.Text = "Manager";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.Label LblUserManagement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
    }
}