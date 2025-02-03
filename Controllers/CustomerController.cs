using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservationSystem.Models;
using MySql.Data.MySqlClient;

namespace HotelReservationSystem3.Controllers
{
    using System.Data;
    using HotelReservationSystem3.Models;
    using System.Windows.Forms;
    using MySql.Data.MySqlClient;
    using Mysqlx.Crud;

    public class CustomerController
    {
        private Database connect = new Database();

        public bool InsertCustomer(int customerId, string firstName, string lastName, string phone)
        {
            string insertQuery = "INSERT INTO `customers` (`CustomerId`, `FirstName`, `LastName`, `Phone`) VALUES (@id, @fname, @lname, @ph);";
            MySqlCommand command = new MySqlCommand(insertQuery, connect.GetConnection());

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = customerId;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = firstName;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lastName;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;

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

        public DataTable getCustomer()
        {
            string selectQuery = "SELECT * FROM `customers`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public bool editCustomer(int customerId, string firstName, string lastName, string phone)
        {
            string editQuery = "UPDATE 'customers' SET 'FirstName'=@fname,'LastName'=@lname,'Phone'=@ph WHERE 'CustomerId'=@id";
            MySqlCommand command = new MySqlCommand(editQuery, connect.GetConnection());

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = customerId;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = firstName;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lastName;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon() ;
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }
        }
        public bool removeCustomer(int customerId)
        {
            string editQuery = "DELETE FROM `customers` WHERE `CustomerId` = @customerId";
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
    

