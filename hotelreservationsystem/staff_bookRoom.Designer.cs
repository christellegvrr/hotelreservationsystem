namespace hotelreservationsystem
{
    partial class staff_bookRoom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bookroom_regprice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookroom_Bookclear = new System.Windows.Forms.Button();
            this.bookroom_Bookbtn = new System.Windows.Forms.Button();
            this.bookroom_total = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.bookroom_scheduleBtn = new System.Windows.Forms.Button();
            this.bookroom_to = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.bookroom_from = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.bookroom_Status = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bookroom_Roomname = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bookroom_Roomtype = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bookroom_Roomid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(920, 733);
            this.panel5.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(10, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(562, 717);
            this.panel4.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(18, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(525, 647);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Available Rooms";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.bookroom_regprice);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.bookroom_Bookclear);
            this.panel3.Controls.Add(this.bookroom_Bookbtn);
            this.panel3.Controls.Add(this.bookroom_total);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.bookroom_scheduleBtn);
            this.panel3.Controls.Add(this.bookroom_to);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.bookroom_from);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.bookroom_Status);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.bookroom_Roomname);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.bookroom_Roomtype);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.bookroom_Roomid);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(589, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 717);
            this.panel3.TabIndex = 3;
            // 
            // bookroom_regprice
            // 
            this.bookroom_regprice.AutoSize = true;
            this.bookroom_regprice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookroom_regprice.Location = new System.Drawing.Point(165, 201);
            this.bookroom_regprice.Name = "bookroom_regprice";
            this.bookroom_regprice.Size = new System.Drawing.Size(52, 23);
            this.bookroom_regprice.TabIndex = 35;
            this.bookroom_regprice.Text = "0.00";
            this.bookroom_regprice.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "Regular Price:";
            // 
            // bookroom_Bookclear
            // 
            this.bookroom_Bookclear.BackColor = System.Drawing.Color.DeepPink;
            this.bookroom_Bookclear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookroom_Bookclear.Location = new System.Drawing.Point(50, 647);
            this.bookroom_Bookclear.Name = "bookroom_Bookclear";
            this.bookroom_Bookclear.Size = new System.Drawing.Size(234, 46);
            this.bookroom_Bookclear.TabIndex = 33;
            this.bookroom_Bookclear.Text = "Clear";
            this.bookroom_Bookclear.UseVisualStyleBackColor = false;
            this.bookroom_Bookclear.Click += new System.EventHandler(this.bookroom_Bookclear_Click);
            // 
            // bookroom_Bookbtn
            // 
            this.bookroom_Bookbtn.BackColor = System.Drawing.Color.DeepPink;
            this.bookroom_Bookbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookroom_Bookbtn.Location = new System.Drawing.Point(50, 577);
            this.bookroom_Bookbtn.Name = "bookroom_Bookbtn";
            this.bookroom_Bookbtn.Size = new System.Drawing.Size(234, 46);
            this.bookroom_Bookbtn.TabIndex = 31;
            this.bookroom_Bookbtn.Text = "Book";
            this.bookroom_Bookbtn.UseVisualStyleBackColor = false;
            this.bookroom_Bookbtn.Click += new System.EventHandler(this.bookroom_Bookbtn_Click);
            // 
            // bookroom_total
            // 
            this.bookroom_total.AutoSize = true;
            this.bookroom_total.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookroom_total.Location = new System.Drawing.Point(193, 528);
            this.bookroom_total.Name = "bookroom_total";
            this.bookroom_total.Size = new System.Drawing.Size(52, 23);
            this.bookroom_total.TabIndex = 30;
            this.bookroom_total.Text = "0.00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(61, 528);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 23);
            this.label15.TabIndex = 29;
            this.label15.Text = "Total Price:";
            // 
            // bookroom_scheduleBtn
            // 
            this.bookroom_scheduleBtn.BackColor = System.Drawing.Color.DeepPink;
            this.bookroom_scheduleBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookroom_scheduleBtn.Location = new System.Drawing.Point(39, 433);
            this.bookroom_scheduleBtn.Name = "bookroom_scheduleBtn";
            this.bookroom_scheduleBtn.Size = new System.Drawing.Size(234, 46);
            this.bookroom_scheduleBtn.TabIndex = 16;
            this.bookroom_scheduleBtn.Text = "Schedule Now";
            this.bookroom_scheduleBtn.UseVisualStyleBackColor = false;
            this.bookroom_scheduleBtn.Click += new System.EventHandler(this.bookroom_scheduleBtn_Click);
            // 
            // bookroom_to
            // 
            this.bookroom_to.Location = new System.Drawing.Point(16, 392);
            this.bookroom_to.Name = "bookroom_to";
            this.bookroom_to.Size = new System.Drawing.Size(268, 22);
            this.bookroom_to.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 355);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 23);
            this.label13.TabIndex = 27;
            this.label13.Text = "To Schedule:";
            // 
            // bookroom_from
            // 
            this.bookroom_from.Location = new System.Drawing.Point(16, 309);
            this.bookroom_from.Name = "bookroom_from";
            this.bookroom_from.Size = new System.Drawing.Size(268, 22);
            this.bookroom_from.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 23);
            this.label10.TabIndex = 25;
            this.label10.Text = "From Schedule:";
            // 
            // bookroom_Status
            // 
            this.bookroom_Status.AutoSize = true;
            this.bookroom_Status.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookroom_Status.Location = new System.Drawing.Point(166, 161);
            this.bookroom_Status.Name = "bookroom_Status";
            this.bookroom_Status.Size = new System.Drawing.Size(80, 23);
            this.bookroom_Status.TabIndex = 24;
            this.bookroom_Status.Text = "----------";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 23);
            this.label11.TabIndex = 22;
            this.label11.Text = "Status:";
            // 
            // bookroom_Roomname
            // 
            this.bookroom_Roomname.AutoSize = true;
            this.bookroom_Roomname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookroom_Roomname.Location = new System.Drawing.Point(166, 121);
            this.bookroom_Roomname.Name = "bookroom_Roomname";
            this.bookroom_Roomname.Size = new System.Drawing.Size(80, 23);
            this.bookroom_Roomname.TabIndex = 21;
            this.bookroom_Roomname.Text = "----------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "Room Name:";
            // 
            // bookroom_Roomtype
            // 
            this.bookroom_Roomtype.AutoSize = true;
            this.bookroom_Roomtype.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookroom_Roomtype.Location = new System.Drawing.Point(166, 79);
            this.bookroom_Roomtype.Name = "bookroom_Roomtype";
            this.bookroom_Roomtype.Size = new System.Drawing.Size(80, 23);
            this.bookroom_Roomtype.TabIndex = 19;
            this.bookroom_Roomtype.Text = "----------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Room Type:";
            // 
            // bookroom_Roomid
            // 
            this.bookroom_Roomid.AutoSize = true;
            this.bookroom_Roomid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookroom_Roomid.Location = new System.Drawing.Point(166, 36);
            this.bookroom_Roomid.Name = "bookroom_Roomid";
            this.bookroom_Roomid.Size = new System.Drawing.Size(80, 23);
            this.bookroom_Roomid.TabIndex = 17;
            this.bookroom_Roomid.Text = "----------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Room ID:";
            // 
            // staff_bookRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Name = "staff_bookRoom";
            this.Size = new System.Drawing.Size(920, 733);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bookroom_Bookclear;
        private System.Windows.Forms.Button bookroom_Bookbtn;
        private System.Windows.Forms.Label bookroom_total;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button bookroom_scheduleBtn;
        private System.Windows.Forms.DateTimePicker bookroom_to;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker bookroom_from;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label bookroom_Status;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label bookroom_Roomname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label bookroom_Roomtype;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label bookroom_Roomid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bookroom_regprice;
        private System.Windows.Forms.Label label1;
    }
}
