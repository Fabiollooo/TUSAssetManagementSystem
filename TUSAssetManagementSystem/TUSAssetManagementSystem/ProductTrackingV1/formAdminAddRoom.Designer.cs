namespace ProductTracking
{
    partial class formAdminAddRoom
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.txtResources = new System.Windows.Forms.TextBox();
            this.btnCancelAddRoom = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbRoomType);
            this.panel1.Controls.Add(this.lblRoomType);
            this.panel1.Controls.Add(this.txtResources);
            this.panel1.Controls.Add(this.btnCancelAddRoom);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nudCapacity);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Controls.Add(this.txtRoomNumber);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 355);
            this.panel1.TabIndex = 11;
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.cmbRoomType.Location = new System.Drawing.Point(94, 270);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(157, 21);
            this.cmbRoomType.TabIndex = 14;
            this.cmbRoomType.SelectedIndexChanged += new System.EventHandler(this.cmbRoomType_SelectedIndexChanged);
            // 
            // lblRoomType
            // 
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(10, 236);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(328, 31);
            this.lblRoomType.TabIndex = 13;
            this.lblRoomType.Text = "RoomType";
            this.lblRoomType.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtResources
            // 
            this.txtResources.Location = new System.Drawing.Point(94, 155);
            this.txtResources.Name = "txtResources";
            this.txtResources.Size = new System.Drawing.Size(157, 20);
            this.txtResources.TabIndex = 12;
            // 
            // btnCancelAddRoom
            // 
            this.btnCancelAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddRoom.Location = new System.Drawing.Point(188, 314);
            this.btnCancelAddRoom.Name = "btnCancelAddRoom";
            this.btnCancelAddRoom.Size = new System.Drawing.Size(150, 29);
            this.btnCancelAddRoom.TabIndex = 11;
            this.btnCancelAddRoom.Text = "Cancel";
            this.btnCancelAddRoom.UseVisualStyleBackColor = true;
            this.btnCancelAddRoom.Click += new System.EventHandler(this.btnCancelAddRoom_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.cmbStatus.Location = new System.Drawing.Point(94, 212);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(157, 21);
            this.cmbStatus.TabIndex = 10;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(328, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Resources";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // nudCapacity
            // 
            this.nudCapacity.Location = new System.Drawing.Point(94, 98);
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(157, 20);
            this.nudCapacity.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.Location = new System.Drawing.Point(20, 314);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(150, 29);
            this.btnAddRoom.TabIndex = 4;
            this.btnAddRoom.Text = "Add";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(94, 41);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(157, 20);
            this.txtRoomNumber.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Capacity";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Room Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, -16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 64);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add New Library Room";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formAdminAddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 388);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formAdminAddRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Library Room";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtResources;
        private System.Windows.Forms.Button btnCancelAddRoom;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.Label lblRoomType;
    }
}