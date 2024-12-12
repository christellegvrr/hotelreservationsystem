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
using System.Linq.Expressions;

namespace hotelreservationsystem
{
    public partial class admin_rooms : UserControl
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Marie Christelle\OneDrive\Documents\hotelreservationsystem\hotelreservationsystem\HotelR.mdf"";Integrated Security=True;Connect Timeout=30";
        public admin_rooms()
        {
            InitializeComponent();

            displayRoomsData();
        }
        public void refreshData()
        {
            if(InvokeRequired)
            {
                Invoke(new MethodInvoker(refreshData));
                return;
            }
            displayRoomsData();
        }

        public void displayRoomsData()
        {
            roomsData rData = new roomsData();
            List<roomsData> listD = rData.roomsDataList();

            dataGridView1.DataSource = listD;

        }

        public bool isEmpty()
        {
            if (string.IsNullOrEmpty(rooms_Roomid.Text) || string.IsNullOrEmpty(rooms_Roomname.Text)
                || rooms_Type.SelectedIndex == -1 || string.IsNullOrEmpty(rooms_Price.Text)
                || rooms_Status.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void rooms_Addbtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();

                        string checkRoomID = "SELECT room_id FROM rooms WHERE room_id = @roomID";
                        using (SqlCommand checkRID = new SqlCommand(checkRoomID, connect))
                        {
                            checkRID.Parameters.AddWithValue("@roomID", rooms_Roomid.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkRID);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(rooms_Roomid.Text.Trim() + " is existing already"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO rooms (room_id, type, room_name, price, status, date_register)" +
                                    "VALUES(@roomID, @type, @name, @price, @status, @date_reg)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@roomID", rooms_Roomid.Text.Trim());
                                    cmd.Parameters.AddWithValue("@type", rooms_Type.SelectedItem.ToString());
                                    cmd.Parameters.AddWithValue("@name", rooms_Roomname.Text.Trim());
                                    cmd.Parameters.AddWithValue("@price", rooms_Price.Text.Trim());
                                    cmd.Parameters.AddWithValue("@status", rooms_Status.SelectedItem.ToString());

                                    DateTime today = DateTime.Today;
                                    cmd.Parameters.AddWithValue("@date_reg", today);

                                    cmd.ExecuteNonQuery();
                                    clearFields();
                                    displayRoomsData();

                                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something went wrong :3", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void rooms_Updatebtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to UPDATE ID: " + id + "?", "Confirmation Message",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        using (SqlConnection connect = new SqlConnection(conn))
                        {
                            connect.Open();

                            string updatedata = "UPDATE rooms SET room_id = @roomID, type = @type, room_name = @name, price = @price " +
                                ", status = @status, date_update = @update WHERE id =@id";

                            using (SqlCommand cmd = new SqlCommand(updatedata, connect))
                            {
                                cmd.Parameters.AddWithValue("@roomID", rooms_Roomid.Text.Trim());
                                cmd.Parameters.AddWithValue("@type", rooms_Type.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@name", rooms_Roomname.Text.Trim());
                                cmd.Parameters.AddWithValue("@price", rooms_Price.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", rooms_Status.SelectedItem.ToString());

                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@update", today);
                                cmd.Parameters.AddWithValue("@id", id);

                                cmd.ExecuteNonQuery();
                                clearFields();
                                displayRoomsData();

                                MessageBox.Show("Update successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    

        private int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                id = (int)row.Cells[0].Value;
                rooms_Roomid.Text = row.Cells[1].Value.ToString();
                rooms_Type.Text = row.Cells[2].Value.ToString();
                rooms_Roomname.Text = row.Cells[3].Value.ToString();
                rooms_Price.Text = row.Cells[4].Value.ToString();
                rooms_Status.Text = row.Cells[5].Value.ToString();
            }
        }

        public void clearFields()
        {
            rooms_Roomid.Text = "";
            rooms_Type.SelectedIndex = -1;
            rooms_Roomname.Text = "";
            rooms_Price.Text = "";
            rooms_Status.SelectedIndex = -1;
        }
        private void rooms_Clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void rooms_Deletebtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to DELETE ID: " + id + "?", "Confirmation Message",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        using (SqlConnection connect = new SqlConnection(conn))
                        {
                            connect.Open();

                            string updatedata = "UPDATE rooms SET date_delete = @delete WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updatedata, connect))
                            {
                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@delete", today);
                                cmd.Parameters.AddWithValue("@id", id);

                                cmd.ExecuteNonQuery();
                                clearFields();
                                displayRoomsData();

                                MessageBox.Show("Delete successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong :3", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    }
    


