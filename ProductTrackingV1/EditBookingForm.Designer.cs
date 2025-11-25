namespace ProductTracking
{
    partial class EditBookingForm
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
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBookingEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpBookingStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboRoom
            // 
            this.cboRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(176, 2);
            this.cboRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(156, 24);
            this.cboRoom.TabIndex = 3;
            this.cboRoom.SelectedIndexChanged += new System.EventHandler(this.cboRoom_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 235);
            this.btnSave.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 41);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(205, 235);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 41);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(8, 161);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "End Time";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(8, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Start Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpBookingEndTime
            // 
            this.dtpBookingEndTime.CustomFormat = "HH:00";
            this.dtpBookingEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookingEndTime.Location = new System.Drawing.Point(176, 161);
            this.dtpBookingEndTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBookingEndTime.Name = "dtpBookingEndTime";
            this.dtpBookingEndTime.ShowUpDown = true;
            this.dtpBookingEndTime.Size = new System.Drawing.Size(156, 22);
            this.dtpBookingEndTime.TabIndex = 18;
            this.dtpBookingEndTime.Value = new System.DateTime(2025, 11, 22, 18, 0, 0, 0);
            // 
            // dtpBookingStartTime
            // 
            this.dtpBookingStartTime.CustomFormat = "HH:00";
            this.dtpBookingStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookingStartTime.Location = new System.Drawing.Point(176, 106);
            this.dtpBookingStartTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBookingStartTime.Name = "dtpBookingStartTime";
            this.dtpBookingStartTime.ShowUpDown = true;
            this.dtpBookingStartTime.Size = new System.Drawing.Size(156, 22);
            this.dtpBookingStartTime.TabIndex = 17;
            this.dtpBookingStartTime.Value = new System.DateTime(2025, 11, 22, 9, 0, 0, 0);
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingDate.CustomFormat = "";
            this.dtpBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBookingDate.Location = new System.Drawing.Point(176, 53);
            this.dtpBookingDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(156, 22);
            this.dtpBookingDate.TabIndex = 16;
            this.dtpBookingDate.Value = new System.DateTime(2025, 11, 16, 20, 37, 27, 0);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.btnCancel);
            this.panelContainer.Controls.Add(this.labelRoomNumber);
            this.panelContainer.Controls.Add(this.btnSave);
            this.panelContainer.Controls.Add(this.label6);
            this.panelContainer.Controls.Add(this.dtpBookingDate);
            this.panelContainer.Controls.Add(this.cboRoom);
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.dtpBookingEndTime);
            this.panelContainer.Controls.Add(this.dtpBookingStartTime);
            this.panelContainer.Location = new System.Drawing.Point(39, 36);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(347, 288);
            this.panelContainer.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(8, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelRoomNumber.Location = new System.Drawing.Point(4, 2);
            this.labelRoomNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(152, 26);
            this.labelRoomNumber.TabIndex = 22;
            this.labelRoomNumber.Text = "Room Number";
            this.labelRoomNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EditBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 366);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "EditBookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Library Booking";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EditBookingForm_Load);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBookingEndTime;
        private System.Windows.Forms.DateTimePicker dtpBookingStartTime;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.Label label1;
    }
}