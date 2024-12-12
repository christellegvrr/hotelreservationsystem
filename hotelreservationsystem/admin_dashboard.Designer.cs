namespace hotelreservationsystem
{
    partial class admin_dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.TotalProfit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TodaysProfit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.totalStaff = new System.Windows.Forms.Label();
            this.AvailableRooms = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Location = new System.Drawing.Point(18, 238);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(877, 469);
            this.panel4.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(18, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(877, 197);
            this.panel3.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Pink;
            this.panel8.Controls.Add(this.TotalProfit);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(662, 31);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 142);
            this.panel8.TabIndex = 1;
            // 
            // TotalProfit
            // 
            this.TotalProfit.AutoSize = true;
            this.TotalProfit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalProfit.Location = new System.Drawing.Point(15, 89);
            this.TotalProfit.Name = "TotalProfit";
            this.TotalProfit.Size = new System.Drawing.Size(96, 27);
            this.TotalProfit.TabIndex = 4;
            this.TotalProfit.Text = "Php 0.0";
            this.TotalProfit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Profit";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Pink;
            this.panel7.Controls.Add(this.TodaysProfit);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(448, 31);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 142);
            this.panel7.TabIndex = 1;
            // 
            // TodaysProfit
            // 
            this.TodaysProfit.AutoSize = true;
            this.TodaysProfit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodaysProfit.Location = new System.Drawing.Point(16, 89);
            this.TodaysProfit.Name = "TodaysProfit";
            this.TodaysProfit.Size = new System.Drawing.Size(96, 27);
            this.TodaysProfit.TabIndex = 3;
            this.TodaysProfit.Text = "Php 0.0";
            this.TodaysProfit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Today\'s Profit";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Pink;
            this.panel6.Controls.Add(this.AvailableRooms);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(232, 31);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 142);
            this.panel6.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Available Rooms";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Pink;
            this.panel5.Controls.Add(this.totalStaff);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(19, 31);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 142);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Staff";
            // 
            // totalStaff
            // 
            this.totalStaff.AutoSize = true;
            this.totalStaff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStaff.Location = new System.Drawing.Point(81, 89);
            this.totalStaff.Name = "totalStaff";
            this.totalStaff.Size = new System.Drawing.Size(26, 27);
            this.totalStaff.TabIndex = 4;
            this.totalStaff.Text = "0";
            this.totalStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AvailableRooms
            // 
            this.AvailableRooms.AutoSize = true;
            this.AvailableRooms.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableRooms.Location = new System.Drawing.Point(86, 89);
            this.AvailableRooms.Name = "AvailableRooms";
            this.AvailableRooms.Size = new System.Drawing.Size(26, 27);
            this.AvailableRooms.TabIndex = 5;
            this.AvailableRooms.Text = "0";
            this.AvailableRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(17, 54);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(843, 394);
            this.dataGridView2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "All Rooms";
            // 
            // admin_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "admin_dashboard";
            this.Size = new System.Drawing.Size(916, 725);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalProfit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TodaysProfit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AvailableRooms;
        private System.Windows.Forms.Label totalStaff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
