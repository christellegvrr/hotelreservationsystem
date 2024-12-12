﻿using System;
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
    public partial class admin_dashboard : UserControl
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Marie Christelle\OneDrive\Documents\hotelreservationsystem\hotelreservationsystem\HotelR.mdf"";Integrated Security=True;Connect Timeout=30";
        public admin_dashboard()
        {
            InitializeComponent();

            displayTotalStaff();
            displayAvailableRooms();
            displayProfitToday();
            displayProfitTotal();
            displayAllRooms();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayTotalStaff();
            displayAvailableRooms();
            displayProfitToday();
            displayProfitTotal();
            displayAllRooms();
        }

        public void displayAllRooms()
        {
            roomsData rData = new roomsData();
            List<roomsData> listData = rData.roomsDataList();

            dataGridView2.DataSource = listData;
        }

        public void displayTotalStaff()
        {
            using(SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT COUNT(id) FROM users WHERE role = 'Staff'";

                using(SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if(result != DBNull.Value)
                    {
                        totalStaff.Text = result.ToString();
                    }
                }
            }
        }

        public void displayAvailableRooms()
        {
            using(SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT COUNT(id) FROM rooms WHERE status = 'Active' OR status = 'Available'";
                
                using(SqlCommand cmd = new SqlCommand( selectData, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        AvailableRooms.Text = result.ToString();
                    }
                }
            }
        }

        public void displayProfitToday()
        {
            using(SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT SUM(price) FROM customer WHERE date_book = @dbook";

                using(SqlCommand cmd = new SqlCommand( selectData, connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@dbook", today);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                        {
                        TodaysProfit.Text = "Php" + result.ToString() + ".00";
                        
                    }

                }
            }
        }
        public void displayProfitTotal()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT SUM(price) FROM customer";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        TotalProfit.Text = "Php" + result.ToString() + ".00";
                    }
                }
            }
        }
                        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
