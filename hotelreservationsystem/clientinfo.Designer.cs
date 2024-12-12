namespace hotelreservationsystem
{
    partial class clientinfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.client_clearbtn = new System.Windows.Forms.Button();
            this.client_bookbtn = new System.Windows.Forms.Button();
            this.client_Address = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.client_Gender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.client_Contact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.client_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.client_Fullname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.client_bookid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepPink;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 59);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(921, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Client\'s Information";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(1174, 19);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(22, 23);
            this.lblClose.TabIndex = 10;
            this.lblClose.Text = "X";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.client_clearbtn);
            this.panel2.Controls.Add(this.client_bookbtn);
            this.panel2.Controls.Add(this.client_Address);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.client_Gender);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.client_Contact);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.client_Email);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.client_Fullname);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.client_bookid);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(13, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 530);
            this.panel2.TabIndex = 3;
            // 
            // client_clearbtn
            // 
            this.client_clearbtn.BackColor = System.Drawing.Color.DeepPink;
            this.client_clearbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_clearbtn.Location = new System.Drawing.Point(579, 355);
            this.client_clearbtn.Name = "client_clearbtn";
            this.client_clearbtn.Size = new System.Drawing.Size(234, 46);
            this.client_clearbtn.TabIndex = 17;
            this.client_clearbtn.Text = "Clear";
            this.client_clearbtn.UseVisualStyleBackColor = false;
            this.client_clearbtn.Click += new System.EventHandler(this.client_clearbtn_Click);
            // 
            // client_bookbtn
            // 
            this.client_bookbtn.BackColor = System.Drawing.Color.DeepPink;
            this.client_bookbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_bookbtn.Location = new System.Drawing.Point(88, 355);
            this.client_bookbtn.Name = "client_bookbtn";
            this.client_bookbtn.Size = new System.Drawing.Size(234, 46);
            this.client_bookbtn.TabIndex = 16;
            this.client_bookbtn.Text = "Book Now";
            this.client_bookbtn.UseVisualStyleBackColor = false;
            this.client_bookbtn.Click += new System.EventHandler(this.rooms_Checkroombtn_Click);
            // 
            // client_Address
            // 
            this.client_Address.Location = new System.Drawing.Point(623, 193);
            this.client_Address.Multiline = true;
            this.client_Address.Name = "client_Address";
            this.client_Address.Size = new System.Drawing.Size(231, 78);
            this.client_Address.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(521, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Address: ";
            // 
            // client_Gender
            // 
            this.client_Gender.FormattingEnabled = true;
            this.client_Gender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Others"});
            this.client_Gender.Location = new System.Drawing.Point(623, 140);
            this.client_Gender.Name = "client_Gender";
            this.client_Gender.Size = new System.Drawing.Size(190, 24);
            this.client_Gender.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(521, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Gender: ";
            // 
            // client_Contact
            // 
            this.client_Contact.Location = new System.Drawing.Point(245, 246);
            this.client_Contact.Name = "client_Contact";
            this.client_Contact.Size = new System.Drawing.Size(231, 22);
            this.client_Contact.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Contact Number: ";
            // 
            // client_Email
            // 
            this.client_Email.Location = new System.Drawing.Point(245, 193);
            this.client_Email.Name = "client_Email";
            this.client_Email.Size = new System.Drawing.Size(231, 22);
            this.client_Email.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email Address: ";
            // 
            // client_Fullname
            // 
            this.client_Fullname.Location = new System.Drawing.Point(245, 144);
            this.client_Fullname.Name = "client_Fullname";
            this.client_Fullname.Size = new System.Drawing.Size(231, 22);
            this.client_Fullname.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Full Name: ";
            // 
            // client_bookid
            // 
            this.client_bookid.AutoSize = true;
            this.client_bookid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_bookid.Location = new System.Drawing.Point(240, 91);
            this.client_bookid.Name = "client_bookid";
            this.client_bookid.Size = new System.Drawing.Size(82, 25);
            this.client_bookid.TabIndex = 1;
            this.client_bookid.Text = "BookID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "BookID: ";
            // 
            // clientinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "clientinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clientinfo";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox client_Gender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox client_Contact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox client_Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox client_Fullname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label client_bookid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox client_Address;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button client_bookbtn;
        private System.Windows.Forms.Button client_clearbtn;
    }
}