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
using System.Runtime.Remoting.Messaging;

namespace hotelreservationsystem
{
    public partial class admin_Adduser : UserControl
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Marie Christelle\OneDrive\Documents\hotelreservationsystem\hotelreservationsystem\HotelR.mdf"";Integrated Security=True;Connect Timeout=30";
        public admin_Adduser()
        {
            InitializeComponent();

            displayData();
        }

        public void refreshData()
        {
            if(InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayData();
        }

        public void displayData()
        {
            usersData uData = new usersData();
            dataGridView1.DataSource = uData.listUsersData();

            dataGridView1.Columns["Password"].Visible = false;
        }

        private void Adduser_addbtn_Click(object sender, EventArgs e)
        {
            if (Adduser_username.Text == "" || Adduser_password.Text == ""
                || Adduser_role.SelectedIndex == -1 || Adduser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    string checkUsern = "SELECT username FROM users WHERE username = @usern";

                    using (SqlCommand checkU = new SqlCommand(checkUsern, connect))
                    {
                        checkU.Parameters.AddWithValue("@usern", Adduser_username.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkU);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            string tempUsern = Adduser_username.Text.Substring(0, 1).ToUpper() + Adduser_username.Text.Substring(1);

                            MessageBox.Show($"{tempUsern} is existing already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }                         
                                else if (Adduser_password.Text.Length < 8)
                        {
                            MessageBox.Show("Invalid password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users (username, password, role, status, date_register)" +
                                "VALUES (@usern, @pass, @role, @status, @date)";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", Adduser_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", Adduser_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", Adduser_role.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@status", Adduser_status.SelectedItem.ToString());

                                DateTime today = DateTime.Today;

                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();
                                clearFields();

                                MessageBox.Show ("Added successfully!", "Information Message"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                            }
                        }
                    }
                }

        public void clearFields()
        {
            Adduser_username.Text = "";
            Adduser_password.Text = "";
            Adduser_role.SelectedIndex = -1;
            Adduser_status.SelectedIndex = -1;
        }

        private void Adduser_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void Adduser_updatebtn_Click(object sender, EventArgs e)
        {
            if (Adduser_username.Text == "" || Adduser_password.Text == ""
                || Adduser_role.SelectedIndex == -1 || Adduser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update ID: " + getID + "?", "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();

                        string updateDate = "UPDATE users SET password = @pass, role = @role, status = @status WHERE username = @usern";

                        using (SqlCommand cmd = new SqlCommand(updateDate, connect))
                        {
                            cmd.Parameters.AddWithValue("@pass", Adduser_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@role", Adduser_role.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", Adduser_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@usern", Adduser_username.Text.Trim());

                            cmd.ExecuteNonQuery();
                            displayData();

                            MessageBox.Show("Update successfully!", "Information Message", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
            }
        }
        private int getID;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                Adduser_username.Text = row.Cells[1].Value.ToString();
                Adduser_password.Text = row.Cells[2].Value.ToString();
                Adduser_role.Text = row.Cells[3].Value.ToString();
                Adduser_status.Text = row.Cells[4].Value.ToString();
            }
        }

        private void Adduser_deletebtn_Click(object sender, EventArgs e)
        {
            if (Adduser_username.Text == "" || Adduser_password.Text == ""
               || Adduser_role.SelectedIndex == -1 || Adduser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Delete ID: " + getID + "?", "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();

                        string updateDate = "DELETE FROM users WHERE username = @usern";

                        using (SqlCommand cmd = new SqlCommand(updateDate, connect))
                        {
                            cmd.Parameters.AddWithValue("@pass", Adduser_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@role", Adduser_role.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", Adduser_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@usern", Adduser_username.Text.Trim());

                            cmd.ExecuteNonQuery();
                            displayData();

                            MessageBox.Show("Delete successfully!", "Information Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
            }
        }
    }
}
   