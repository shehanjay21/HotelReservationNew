using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservationSystem.Models;
using MySql.Data.MySqlClient;
namespace HotelReservationSystem3.Controllers
{
    public class RoomController
    {
        private Database connect = new Database();

        public DataTable getRoomType()
        {
            string selectQuery = "SELECT * FROM `category` ";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public bool addRoom(string no, int type, string phone, string status)
        {
            string insertQuery = "INSERT INTO `room`(`RoomId`, `RoomType`, `RoomPhone`, `RoomStatus`) VALUES (@no,@type,@ph,@sts)";
            MySqlCommand command = new MySqlCommand(insertQuery, connect.GetConnection());

            //@no,@type,@ph,@sts

            command.Parameters.Add("@no", MySqlDbType.VarChar).Value = no;
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@sts", MySqlDbType.VarChar).Value = status;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }
        }

        public DataTable getRoomList()
        {
            string selectQuery = "SELECT * FROM `room` ";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public bool editRoom(string no, int type, string phone, string status)
        {
            string editQuery = "UPDATE `room` SET `RoomId`= @no,`RoomType`= @type,`RoomPhone`= @ph,`RoomStatus`= @sts";
            MySqlCommand command = new MySqlCommand(editQuery, connect.GetConnection());

            //@no,@type,@ph,@sts

            command.Parameters.Add("@no", MySqlDbType.VarChar).Value = no;
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@sts", MySqlDbType.VarChar).Value = status;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }
        }

        public bool removeRoom(int customerId)
        {
            string editQuery = "DELETE FROM `room` WHERE `RoomId` = @id";
            MySqlCommand command = new MySqlCommand(editQuery, connect.GetConnection());

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = customerId;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }
        }

    }
}
