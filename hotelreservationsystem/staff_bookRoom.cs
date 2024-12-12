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
    public partial class staff_bookRoom : UserControl
    {

        public delegate void RoomBookedEventHandler(string roomId, DateTime fromDate, DateTime toDate, decimal price);
        public event RoomBookedEventHandler OnRoomBooked;
        public staff_bookRoom()
        {
            InitializeComponent();
            displayRooms();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayRooms();
        }
        public void displayRooms()
        {
            roomsData rData = new roomsData();

            List<roomsData> listData = rData.roomsDataList();

            dataGridView1.DataSource = listData;
           
        }
        private int getID = 0;

        private decimal regprice = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                try
                {
                    getID = (int)row.Cells[0].Value;
                    bookroom_Roomid.Text = row.Cells[1].Value.ToString();
                    bookroom_Roomtype.Text = row.Cells[2].Value.ToString();
                    bookroom_Roomname.Text = row.Cells[3].Value.ToString();
                    bookroom_regprice.Text = Convert.ToDecimal(row.Cells[4].Value).ToString("0.00");

                    regprice = Convert.ToDecimal(row.Cells[4].Value);
                    bookroom_Status.Text = row.Cells[5].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting room: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bookroom_scheduleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fromDate = bookroom_from.Value;
                DateTime toDate = bookroom_to.Value;
                TimeSpan countDays = toDate - fromDate;

                int days = countDays.Days;
                decimal totalPrice = days * regprice;

                if (totalPrice < 0)
                {
                    throw new InvalidOperationException("Invalid date range selected.");
                }

                bookroom_total.Text = (totalPrice == 0 ? regprice : totalPrice).ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bookroom_total.Text = "0.00";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bookroom_Bookbtn_Click(object sender, EventArgs e)
        {
            if (regprice == 0 || bookroom_total.Text == "0.00")
            {
                MessageBox.Show("Please fill all info correctly", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (bookroom_Status.Text != "Active")
            {
                MessageBox.Show("The room is unavailable", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                hotelData.roomID = bookroom_Roomid.Text;
                hotelData.fromDate = bookroom_from.Value;
                hotelData.toDate = bookroom_to.Value;
                hotelData.price = bookroom_total.Text;

                Form formbg = new Form();

                using (clientinfo ciform = new clientinfo())
                {
                    ciform.Owner = formbg;
                    ciform.ShowDialog();

                    OnRoomBooked?.Invoke(bookroom_Roomid.Text, bookroom_from.Value, bookroom_to.Value, Convert.ToDecimal(bookroom_total.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during booking: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clearFields()
        {
            bookroom_Roomid.Text = "----------";
            bookroom_Roomtype.Text = "----------";
            bookroom_Roomname.Text = "----------";
            bookroom_Status.Text = "----------";
            bookroom_total.Text = "0.00";
            bookroom_regprice.Text = "0.00";
        }
        private void bookroom_Bookclear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void rooms_Checkroombtn_Click(object sender, EventArgs e)
        {

        }
    }
}
