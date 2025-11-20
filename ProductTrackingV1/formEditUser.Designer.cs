namespace ProductTracking
{
    partial class formEditUser
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
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonCommit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.lbleditUser = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 20;
            this.listBoxUsers.Location = new System.Drawing.Point(586, 191);
            this.listBoxUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(178, 244);
            this.listBoxUsers.TabIndex = 0;
            this.listBoxUsers.DoubleClick += new System.EventHandler(this.listBoxUsers_DoubleClick);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(17, 96);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(148, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(17, 215);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(148, 26);
            this.textBoxPassword.TabIndex = 2;
            // 
            // buttonCommit
            // 
            this.buttonCommit.Location = new System.Drawing.Point(32, 356);
            this.buttonCommit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCommit.Name = "buttonCommit";
            this.buttonCommit.Size = new System.Drawing.Size(112, 35);
            this.buttonCommit.TabIndex = 3;
            this.buttonCommit.Text = "Commit";
            this.buttonCommit.UseVisualStyleBackColor = true;
            this.buttonCommit.Click += new System.EventHandler(this.buttonCommit_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(13, 57);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(112, 97);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // lbleditUser
            // 
            this.lbleditUser.AutoSize = true;
            this.lbleditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleditUser.Location = new System.Drawing.Point(327, 57);
            this.lbleditUser.Name = "lbleditUser";
            this.lbleditUser.Size = new System.Drawing.Size(162, 32);
            this.lbleditUser.TabIndex = 5;
            this.lbleditUser.Text = "EDIT USER";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Namw";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(13, 190);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.buttonCommit);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Location = new System.Drawing.Point(245, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 431);
            this.panel1.TabIndex = 8;
            // 
            // formEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 769);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbleditUser);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listBoxUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formEditUser";
            this.Text = "EditUser";
            this.Load += new System.EventHandler(this.formEditUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonCommit;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label lbleditUser;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel panel1;
    }
}