namespace ProductTracking
{
    partial class formDeleteUser
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.lblDeleteUsers = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 20;
            this.listBoxUsers.Location = new System.Drawing.Point(170, 21);
            this.listBoxUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(451, 304);
            this.listBoxUsers.TabIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(253, 376);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(112, 35);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(472, 376);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(112, 35);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // lblDeleteUsers
            // 
            this.lblDeleteUsers.AutoSize = true;
            this.lblDeleteUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteUsers.Location = new System.Drawing.Point(516, 106);
            this.lblDeleteUsers.Name = "lblDeleteUsers";
            this.lblDeleteUsers.Size = new System.Drawing.Size(153, 29);
            this.lblDeleteUsers.TabIndex = 3;
            this.lblDeleteUsers.Text = "Delete Users";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.listBoxUsers);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Location = new System.Drawing.Point(238, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 471);
            this.panel1.TabIndex = 4;
            // 
            // formDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 702);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDeleteUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formDeleteUser";
            this.Text = "formDeleteUser";
            this.Load += new System.EventHandler(this.formDeleteUser_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label lblDeleteUsers;
        private System.Windows.Forms.Panel panel1;
    }
}