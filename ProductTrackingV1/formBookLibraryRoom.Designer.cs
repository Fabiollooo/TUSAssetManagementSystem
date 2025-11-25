namespace ProductTracking
{
    partial class formBookLibraryRoom
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
            this.labelBookRoomRoomNumber = new System.Windows.Forms.Label();
            this.labelBookRoomStartTime = new System.Windows.Forms.Label();
            this.labelBookRoomEndTime = new System.Windows.Forms.Label();
            this.labelBookRoomDate = new System.Windows.Forms.Label();
            this.btnBookRoomConfirm = new System.Windows.Forms.Button();
            this.btnBookRoomCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBookRoomRoomNumber
            // 
            this.labelBookRoomRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookRoomRoomNumber.Location = new System.Drawing.Point(12, 9);
            this.labelBookRoomRoomNumber.Name = "labelBookRoomRoomNumber";
            this.labelBookRoomRoomNumber.Size = new System.Drawing.Size(181, 23);
            this.labelBookRoomRoomNumber.TabIndex = 0;
            this.labelBookRoomRoomNumber.Text = "Room: RoomNumber";
            this.labelBookRoomRoomNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBookRoomStartTime
            // 
            this.labelBookRoomStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookRoomStartTime.Location = new System.Drawing.Point(12, 55);
            this.labelBookRoomStartTime.Name = "labelBookRoomStartTime";
            this.labelBookRoomStartTime.Size = new System.Drawing.Size(181, 23);
            this.labelBookRoomStartTime.TabIndex = 1;
            this.labelBookRoomStartTime.Text = "Start Time: x/x/x";
            this.labelBookRoomStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBookRoomEndTime
            // 
            this.labelBookRoomEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookRoomEndTime.Location = new System.Drawing.Point(12, 78);
            this.labelBookRoomEndTime.Name = "labelBookRoomEndTime";
            this.labelBookRoomEndTime.Size = new System.Drawing.Size(181, 23);
            this.labelBookRoomEndTime.TabIndex = 2;
            this.labelBookRoomEndTime.Text = "End Time: x/x/x";
            this.labelBookRoomEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBookRoomDate
            // 
            this.labelBookRoomDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookRoomDate.Location = new System.Drawing.Point(12, 32);
            this.labelBookRoomDate.Name = "labelBookRoomDate";
            this.labelBookRoomDate.Size = new System.Drawing.Size(181, 23);
            this.labelBookRoomDate.TabIndex = 3;
            this.labelBookRoomDate.Text = "Date: x/x/x";
            this.labelBookRoomDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBookRoomConfirm
            // 
            this.btnBookRoomConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookRoomConfirm.Location = new System.Drawing.Point(35, 146);
            this.btnBookRoomConfirm.Name = "btnBookRoomConfirm";
            this.btnBookRoomConfirm.Size = new System.Drawing.Size(141, 36);
            this.btnBookRoomConfirm.TabIndex = 4;
            this.btnBookRoomConfirm.Text = "Confirm";
            this.btnBookRoomConfirm.UseVisualStyleBackColor = true;
            this.btnBookRoomConfirm.Click += new System.EventHandler(this.btnBookRoomConfirm_Click);
            // 
            // btnBookRoomCancel
            // 
            this.btnBookRoomCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookRoomCancel.Location = new System.Drawing.Point(35, 188);
            this.btnBookRoomCancel.Name = "btnBookRoomCancel";
            this.btnBookRoomCancel.Size = new System.Drawing.Size(141, 38);
            this.btnBookRoomCancel.TabIndex = 5;
            this.btnBookRoomCancel.Text = "Cancel";
            this.btnBookRoomCancel.UseVisualStyleBackColor = true;
            this.btnBookRoomCancel.Click += new System.EventHandler(this.btnBookRoomCancel_Click);
            // 
            // formBookLibraryRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 238);
            this.Controls.Add(this.btnBookRoomCancel);
            this.Controls.Add(this.btnBookRoomConfirm);
            this.Controls.Add(this.labelBookRoomDate);
            this.Controls.Add(this.labelBookRoomEndTime);
            this.Controls.Add(this.labelBookRoomStartTime);
            this.Controls.Add(this.labelBookRoomRoomNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formBookLibraryRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Book A Room";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBookRoomRoomNumber;
        private System.Windows.Forms.Label labelBookRoomStartTime;
        private System.Windows.Forms.Label labelBookRoomEndTime;
        private System.Windows.Forms.Label labelBookRoomDate;
        private System.Windows.Forms.Button btnBookRoomConfirm;
        private System.Windows.Forms.Button btnBookRoomCancel;
    }
}