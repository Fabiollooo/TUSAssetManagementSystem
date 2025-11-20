namespace ProductTracking
{
    partial class formAddUser
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCommit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelOuter = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.comboUserType = new System.Windows.Forms.ComboBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.panelOuter.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(37, 77);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(178, 26);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(37, 169);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(178, 26);
            this.textBoxPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // buttonCommit
            // 
            this.buttonCommit.Location = new System.Drawing.Point(37, 520);
            this.buttonCommit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCommit.Name = "buttonCommit";
            this.buttonCommit.Size = new System.Drawing.Size(112, 111);
            this.buttonCommit.TabIndex = 6;
            this.buttonCommit.Text = "Add User";
            this.buttonCommit.UseVisualStyleBackColor = true;
            this.buttonCommit.Click += new System.EventHandler(this.buttonCommit_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(59, 22);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(112, 100);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panelOuter
            // 
            this.panelOuter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelOuter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOuter.Controls.Add(this.lblTitle);
            this.panelOuter.Controls.Add(this.panelForm);
            this.panelOuter.Controls.Add(this.buttonBack);
            this.panelOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOuter.Location = new System.Drawing.Point(0, 0);
            this.panelOuter.Name = "panelOuter";
            this.panelOuter.Size = new System.Drawing.Size(1186, 769);
            this.panelOuter.TabIndex = 8;
            this.panelOuter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOuter_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(500, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(139, 32);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Add User";
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Controls.Add(this.buttonReset);
            this.panelForm.Controls.Add(this.lblRole);
            this.panelForm.Controls.Add(this.comboUserType);
            this.panelForm.Controls.Add(this.lblConfirmPassword);
            this.panelForm.Controls.Add(this.textBoxConfirmPassword);
            this.panelForm.Controls.Add(this.textBoxName);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Controls.Add(this.buttonCommit);
            this.panelForm.Controls.Add(this.textBoxPassword);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Location = new System.Drawing.Point(380, 73);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(408, 671);
            this.panelForm.TabIndex = 8;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(247, 520);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(107, 111);
            this.buttonReset.TabIndex = 13;
            this.buttonReset.Text = "Reset Form";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(33, 299);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(42, 20);
            this.lblRole.TabIndex = 12;
            this.lblRole.Text = "Role";
            // 
            // comboUserType
            // 
            this.comboUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUserType.FormattingEnabled = true;
            this.comboUserType.Items.AddRange(new object[] {
            "Admin",
            "",
            " ",
            "Staff",
            "",
            "",
            "Student"});
            this.comboUserType.Location = new System.Drawing.Point(42, 333);
            this.comboUserType.Name = "comboUserType";
            this.comboUserType.Size = new System.Drawing.Size(128, 28);
            this.comboUserType.TabIndex = 10;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(33, 216);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(137, 20);
            this.lblConfirmPassword.TabIndex = 11;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(37, 239);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(178, 26);
            this.textBoxConfirmPassword.TabIndex = 10;
            // 
            // formAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1186, 769);
            this.ControlBox = false;
            this.Controls.Add(this.panelOuter);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAddUser";
            this.panelOuter.ResumeLayout(false);
            this.panelOuter.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCommit;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panelOuter;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.ComboBox comboUserType;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button buttonReset;
    }
}