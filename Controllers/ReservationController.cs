using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using HotelReservationSystem.Models;
using System.Data;

namespace HotelReservationSystem3.Controllers
{
    
    public class ReservationController
    {
        Database connect = new Database();

        public DataTable roomByType(int roomType)
        {
            string selectQuery = "SELECT * FROM `room` WHERE `RoomType` = @type AND `RoomStatus` = 'Free'";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = roomType;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table; 
        }

        public DataTable getReserv()
        {
            string selectQuery = "SELECT * FROM `reservations` ";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public bool serReservRoom(string rno, string sts)
        {
            string updateQuery = "UPDATE `room` SET `RoomStatus`= @sts WHERE `RoomId` = rno";
            MySqlCommand command = new MySqlCommand(updateQuery, connect.GetConnection());

            command.Parameters.Add("@rno", MySqlDbType.VarChar).Value = rno;
            command.Parameters.Add("@sts", MySqlDbType.VarChar).Value = sts;

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

        public bool addReservation(int roomNo, int customerId, DateTime dateIn, DateTime dateOut)
        {
            string insertQuery = "INSERT INTO `reservations` (`CustomerId`, `RoomNo`, `DateIn`, `DateOut`) VALUES (@CId, @RNo, @Din, @Dout)";
            MySqlCommand command = new MySqlCommand(insertQuery, connect.GetConnection());

            command.Parameters.Add("@CId", MySqlDbType.Int32).Value = customerId;
            command.Parameters.Add("@RNo", MySqlDbType.Int32).Value = roomNo; // Ensure roomNo corresponds to an existing CategoryId in rooms table
            command.Parameters.Add("@Din", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@Dout", MySqlDbType.Date).Value = dateOut;

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

        internal bool setReservRoom(int roomNo, string v)
        {
            throw new NotImplementedException();
        }
    }

    
}
