using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using HotelReservationSystem.Models;

namespace HotelReservationSystem3
{
    public partial class Login : Form
    {
        Database connect = new Database();
        public Login()
        {
            InitializeComponent();
        }

        private void close_click1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_registerBtn1_Click(object sender, EventArgs e)
        {
           
        }
            private void login_loginBtn1_Click(object sender, EventArgs e)
            {
            
                if (string.IsNullOrWhiteSpace(login_username1.Text) || string.IsNullOrWhiteSpace(login_password1.Text))
                {
                    MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    DataTable table = new DataTable();

              
                    string selectquery = "SELECT * FROM user WHERE Username = @usn AND Password = @pass";

                    using (MySqlCommand command = new MySqlCommand(selectquery, connect.GetConnection()))
                    {
                        command.Parameters.AddWithValue("@usn", login_username1.Text.Trim());
                        command.Parameters.AddWithValue("@pass", login_password1.Text.Trim());

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(table);
                        }
                    }

                    if (table.Rows.Count > 0)
                    {
                        this.Hide();
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred:\n" + ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void login_showPassword1_CheckedChanged(object sender, EventArgs e)
            {
                login_password1.UseSystemPasswordChar = !login_showPassword1.Checked;
            }

        private void login_username1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
    

