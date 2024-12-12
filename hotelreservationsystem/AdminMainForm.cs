using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelreservationsystem
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm Message"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirm Message"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { 
                Form1 loginFOrm = new Form1();
                loginFOrm.Show();

                this.Hide();
            }
        }

        private void admin_Adduser1_Load(object sender, EventArgs e)
        {

        }

        private void admin_rooms1_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = true;
            admin_Adduser1.Visible = false;
            admin_rooms1.Visible = false;
            admin_customers1.Visible = false;   

            admin_dashboard adDashboard = admin_dashboard1 as admin_dashboard;

            if(adDashboard != null)
            {
                adDashboard.refreshData();
            }

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            admin_Adduser1.Visible = false;
            admin_rooms1.Visible = false;
            admin_customers1.Visible = true;

            admin_customers adCustomer = admin_customers1 as admin_customers;

            if(adCustomer != null )
            {
                adCustomer.refreshData();
            }
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            admin_Adduser1.Visible = false;
            admin_rooms1.Visible = true;
            admin_customers1.Visible = false;

            admin_rooms adRooms = admin_rooms1 as admin_rooms;

            if(adRooms != null )
            {
                adRooms.refreshData();
            }
        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            admin_Adduser1.Visible = true;
            admin_rooms1.Visible = false;
            admin_customers1.Visible = false;

            admin_Adduser adUser = admin_Adduser1 as admin_Adduser;

            if(adUser != null )
            {
                adUser.refreshData();
            }
        }
        private void admin_room1_Load (object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            admin_Adduser1.Visible = false;
            admin_rooms1.Visible = true;
            admin_customers1.Visible = false;

            admin_rooms adRooms = admin_rooms1 as admin_rooms;

            if(adRooms != null )
            {
                adRooms.refreshData ();
            }


        }
    }
}
