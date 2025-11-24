namespace ProductTracking
{
    partial class formLibraryRooms
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Rooms";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(96, 117);
            this.dgvRooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.RowHeadersWidth = 62;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(946, 437);
            this.dgvRooms.TabIndex = 1;
            this.dgvRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(930, 618);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 35);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // formLibraryRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formLibraryRooms";
            this.Text = "Library Rooms";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Button btnRefresh;
    }
}