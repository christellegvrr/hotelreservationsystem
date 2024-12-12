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
using System.Drawing.Drawing2D;
using System.Runtime.Remoting.Contexts;
using System.Windows.Media;

namespace hotelreservationsystem
{
    public partial class FrmRegistration : Form
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Marie Christelle\OneDrive\Documents\hotelreservationsystem\hotelreservationsystem\HotelR.mdf"";Integrated Security=True;Connect Timeout=30";
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }

        private void registerShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            registerPassword.PasswordChar = registerShowPassword.Checked ? '\0' : '*';
            registerConfirmPassword.PasswordChar = registerShowPassword.Checked ? '\0' : '*';
        }

        private void registerConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (registerUsername.Text == "" || registerPassword.Text == "" || registerConfirmPassword.Text == "")
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
                        checkU.Parameters.AddWithValue("@usern", registerUsername.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkU);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count != 0)
                        {
                            string tempEmail = registerUsername.Text.Substring(0, 1).ToUpper() + registerUsername.Text.Substring(1);
                            MessageBox.Show($"{tempEmail} is existing already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else if (registerPassword.Text.Length < 8)
                        {
                            MessageBox.Show("Invalid Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (registerPassword.Text != registerConfirmPassword.Text)
                        {
                            MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string query = "INSERT INTO users (username, password, role, status, date_register)" +
                                "VALUES(@usern, @pass, @role, @status, @regDate)";

                            using (SqlCommand cmd = new SqlCommand(query, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", registerUsername.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", registerPassword.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", "Staff");
                                cmd.Parameters.AddWithValue("@status", "Active");

                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@regDate", today);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Registered Successfully", "Information Message"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Form1 loginForm = new Form1();
                                loginForm.Show();

                                this.Hide();

                            }
                        }
                    }
                }
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
        
    

