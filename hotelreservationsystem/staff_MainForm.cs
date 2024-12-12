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
    public partial class staff_MainForm : Form
    {

        public delegate void NavigationEventHandler(string section);
        public event NavigationEventHandler OnSectionChanged;
        public staff_MainForm()
        {
            InitializeComponent();

            this.OnSectionChanged += Staff_MainForm_OnSectionChanged;
        }

        private void Staff_MainForm_OnSectionChanged(string section)
        {
            MessageBox.Show($"Navigated to: {section}", "Navigation Update");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            staff_bookRoom1.Visible = false;
            admin_customers1.Visible = true;

            OnSectionChanged?.Invoke("Customers");

            admin_customers adCustomers = admin_customers1 as admin_customers;

            if (adCustomers != null)
            {
                adCustomers.refreshData();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = true;
            staff_bookRoom1.Visible = false;
            admin_customers1.Visible = false;

            OnSectionChanged?.Invoke("Dashboard");

            admin_dashboard adDashboard = admin_dashboard1 as admin_dashboard;

            if (adDashboard != null)
            {
                adDashboard.refreshData();
            }
        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            staff_bookRoom1.Visible = true;
            admin_customers1.Visible = false;

            OnSectionChanged?.Invoke("Book Room");

            staff_bookRoom adBookRoom = staff_bookRoom1 as staff_bookRoom;

            if (adBookRoom != null)
            {
                adBookRoom.refreshData();
            }
        }
    }
}