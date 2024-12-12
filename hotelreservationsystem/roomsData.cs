﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace hotelreservationsystem
{
    class roomsData
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Marie Christelle\OneDrive\Documents\hotelreservationsystem\hotelreservationsystem\HotelR.mdf"";Integrated Security=True;Connect Timeout=30";

        public int ID { set; get; } // 0
        public string RoomID { set; get; } // 1
        public string RoomType { set; get; } // 2
        public string RoomName { set; get; } // 3
        public string Price { set; get; } // 4
        public string Status { set; get; } // 5
        public string Date {  set; get; } // 6

        public List<roomsData> roomsDataList()
        { 
            List<roomsData> listData = new List<roomsData>();

            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT * FROM rooms WHERE date_delete is NULL";

                using(SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        roomsData rData = new roomsData();

                        rData.ID = (int)reader["id"];
                        rData.RoomID = reader["room_id"].ToString();
                        rData.RoomType = reader["type"].ToString();
                        rData.RoomName = reader["room_name"].ToString();
                        rData.Price = reader["price"].ToString();
                        rData.Status = reader["status"].ToString();
                        rData.Date = reader["date_register"].ToString();

                        listData.Add(rData);

                    }
                    }
                return listData;

            }
        }
    
    }
}
