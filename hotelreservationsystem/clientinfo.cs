using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace hotelreservationsystem
{
    public partial class clientinfo : Form
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Marie Christelle\OneDrive\Documents\hotelreservationsystem\hotelreservationsystem\HotelR.mdf"";Integrated Security=True;Connect Timeout=30";

        
        public clientinfo()
        {
            InitializeComponent();
            displayBookID();
        }

        private void rooms_Checkroombtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to book now?",
                "Confirmation Message", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)== DialogResult.Yes)
            {
                if (client_Fullname.Text == "" || client_Gender.SelectedIndex == -1 || client_Address.Text == ""
                || client_Email.Text == "" || client_Contact.Text == "" || hotelData.roomID == "")
                {
                    MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();

                        string insertData = "INSERT INTO customer " +
                            "(book_id, full_name, email, contact, gender, address, room_id, price, status_payment, status" +
                            ", date_from, date_to, date_book)" +
                            "VALUES(@bookID, @fullname, @email, @contact, @gender, @address, @roomID, @price, @statusP" +
                            ", @status, @dateForm, @dateTo, @dateBook)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@bookID", client_bookid.Text);
                            cmd.Parameters.AddWithValue("@fullname", client_Fullname.Text);
                            cmd.Parameters.AddWithValue("@email", client_Email.Text);
                            cmd.Parameters.AddWithValue("@contact", client_Contact.Text);
                            cmd.Parameters.AddWithValue("@gender", client_Gender.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@address", client_Address.Text);
                            cmd.Parameters.AddWithValue("@roomID", hotelData.roomID);
                            cmd.Parameters.AddWithValue("@price", hotelData.price);
                            cmd.Parameters.AddWithValue("@statusP", "Paid");
                            cmd.Parameters.AddWithValue("@status", "Checked In");
                            cmd.Parameters.AddWithValue("@dateForm", hotelData.fromDate);
                            cmd.Parameters.AddWithValue("@dateTo", hotelData.toDate);
                            DateTime today = DateTime.Today;

                            cmd.Parameters.AddWithValue("@dateBook", today);

                            cmd.ExecuteNonQuery();

                            updateRoomStatus();

                            MessageBox.Show("Booked successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();
                        }
                    }
                }
            
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void displayBookID()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                int getBookID = 0;

                string selectBID = "SELECT COUNT(id) FROM customer";

                using (SqlCommand cmd = new SqlCommand(selectBID, connect))
                {
                    getBookID = Convert.ToInt32(cmd.ExecuteScalar());

                    if (getBookID == 0)
                    {
                        getBookID += 1;
                    }

                    else
                    {
                        getBookID += 1;
                    }
                }
                client_bookid.Text = $"BID-{getBookID}";
            }
        }

        public void updateRoomStatus()
        {
            using(SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string updateStatus = "UPDATE rooms SET status = @status WHERE room_id = @roomID";

                using(SqlCommand cmd = new SqlCommand(updateStatus, connect))
                {
                    cmd.Parameters.AddWithValue("@status", "Unavailable");
                    cmd.Parameters.AddWithValue("@roomID", hotelData.roomID);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void client_clearbtn_Click(object sender, EventArgs e)
        {
            client_Fullname.Text = "";
            client_Email.Text = "";
            client_Contact.Text = "";
            client_Gender.SelectedIndex = -1;
            client_Address.Text = "";
        }
    }
}
