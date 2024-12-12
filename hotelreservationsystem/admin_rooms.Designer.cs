namespace hotelreservationsystem
{
    partial class admin_rooms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rooms_Clearbtn = new System.Windows.Forms.Button();
            this.rooms_Deletebtn = new System.Windows.Forms.Button();
            this.rooms_Updatebtn = new System.Windows.Forms.Button();
            this.rooms_Addbtn = new System.Windows.Forms.Button();
            this.rooms_Status = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rooms_Price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rooms_Roomname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rooms_Type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rooms_Roomid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 407);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Room\'s Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(14, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(858, 337);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.rooms_Clearbtn);
            this.panel3.Controls.Add(this.rooms_Deletebtn);
            this.panel3.Controls.Add(this.rooms_Updatebtn);
            this.panel3.Controls.Add(this.rooms_Addbtn);
            this.panel3.Controls.Add(this.rooms_Status);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.rooms_Price);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.rooms_Roomname);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.rooms_Type);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.rooms_Roomid);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(12, 427);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(889, 289);
            this.panel3.TabIndex = 2;
            // 
            // rooms_Clearbtn
            // 
            this.rooms_Clearbtn.BackColor = System.Drawing.Color.DeepPink;
            this.rooms_Clearbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_Clearbtn.Location = new System.Drawing.Point(617, 201);
            this.rooms_Clearbtn.Name = "rooms_Clearbtn";
            this.rooms_Clearbtn.Size = new System.Drawing.Size(106, 46);
            this.rooms_Clearbtn.TabIndex = 17;
            this.rooms_Clearbtn.Text = "Clear";
            this.rooms_Clearbtn.UseVisualStyleBackColor = false;
            this.rooms_Clearbtn.Click += new System.EventHandler(this.rooms_Clearbtn_Click);
            // 
            // rooms_Deletebtn
            // 
            this.rooms_Deletebtn.BackColor = System.Drawing.Color.DeepPink;
            this.rooms_Deletebtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_Deletebtn.Location = new System.Drawing.Point(465, 201);
            this.rooms_Deletebtn.Name = "rooms_Deletebtn";
            this.rooms_Deletebtn.Size = new System.Drawing.Size(106, 46);
            this.rooms_Deletebtn.TabIndex = 16;
            this.rooms_Deletebtn.Text = "Delete";
            this.rooms_Deletebtn.UseVisualStyleBackColor = false;
            this.rooms_Deletebtn.Click += new System.EventHandler(this.rooms_Deletebtn_Click);
            // 
            // rooms_Updatebtn
            // 
            this.rooms_Updatebtn.BackColor = System.Drawing.Color.DeepPink;
            this.rooms_Updatebtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_Updatebtn.Location = new System.Drawing.Point(306, 201);
            this.rooms_Updatebtn.Name = "rooms_Updatebtn";
            this.rooms_Updatebtn.Size = new System.Drawing.Size(106, 46);
            this.rooms_Updatebtn.TabIndex = 15;
            this.rooms_Updatebtn.Text = "Update";
            this.rooms_Updatebtn.UseVisualStyleBackColor = false;
            this.rooms_Updatebtn.Click += new System.EventHandler(this.rooms_Updatebtn_Click);
            // 
            // rooms_Addbtn
            // 
            this.rooms_Addbtn.BackColor = System.Drawing.Color.DeepPink;
            this.rooms_Addbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_Addbtn.Location = new System.Drawing.Point(154, 201);
            this.rooms_Addbtn.Name = "rooms_Addbtn";
            this.rooms_Addbtn.Size = new System.Drawing.Size(106, 46);
            this.rooms_Addbtn.TabIndex = 14;
            this.rooms_Addbtn.Text = "Add";
            this.rooms_Addbtn.UseVisualStyleBackColor = false;
            this.rooms_Addbtn.Click += new System.EventHandler(this.rooms_Addbtn_Click);
            // 
            // rooms_Status
            // 
            this.rooms_Status.FormattingEnabled = true;
            this.rooms_Status.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Occupied"});
            this.rooms_Status.Location = new System.Drawing.Point(549, 80);
            this.rooms_Status.Name = "rooms_Status";
            this.rooms_Status.Size = new System.Drawing.Size(205, 24);
            this.rooms_Status.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(465, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Status:";
            // 
            // rooms_Price
            // 
            this.rooms_Price.Location = new System.Drawing.Point(549, 36);
            this.rooms_Price.Name = "rooms_Price";
            this.rooms_Price.Size = new System.Drawing.Size(205, 22);
            this.rooms_Price.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(465, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price:";
            // 
            // rooms_Roomname
            // 
            this.rooms_Roomname.Location = new System.Drawing.Point(201, 129);
            this.rooms_Roomname.Name = "rooms_Roomname";
            this.rooms_Roomname.Size = new System.Drawing.Size(205, 22);
            this.rooms_Roomname.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Room Name:";
            // 
            // rooms_Type
            // 
            this.rooms_Type.FormattingEnabled = true;
            this.rooms_Type.Items.AddRange(new object[] {
            "Single Room",
            "Double Room"});
            this.rooms_Type.Location = new System.Drawing.Point(201, 80);
            this.rooms_Type.Name = "rooms_Type";
            this.rooms_Type.Size = new System.Drawing.Size(205, 24);
            this.rooms_Type.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type:";
            // 
            // rooms_Roomid
            // 
            this.rooms_Roomid.Location = new System.Drawing.Point(201, 33);
            this.rooms_Roomid.Name = "rooms_Roomid";
            this.rooms_Roomid.Size = new System.Drawing.Size(205, 22);
            this.rooms_Roomid.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Room ID:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 368);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(881, 362);
            this.panel4.TabIndex = 1;
            // 
            // admin_rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "admin_rooms";
            this.Size = new System.Drawing.Size(916, 725);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox rooms_Status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rooms_Price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rooms_Roomname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox rooms_Type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rooms_Roomid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rooms_Addbtn;
        private System.Windows.Forms.Button rooms_Clearbtn;
        private System.Windows.Forms.Button rooms_Deletebtn;
        private System.Windows.Forms.Button rooms_Updatebtn;
    }
}
