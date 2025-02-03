using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelReservationSystem3.Models;

namespace HotelReservationSystem3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_slide.Height = dashboardBtn.Height;
            panel_slide.Top=dashboardBtn.Top;

            panel_main.Controls.Clear();
            MainForm main = new MainForm();
            main.TopLevel = false;
            main.Dock = DockStyle.Fill;
            main.FormBorderStyle = FormBorderStyle.None;
            panel_cover.Controls.Add(main);
            main.Show();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            panel_slide.Height = customerBtn.Height;
            panel_slide.Top = customerBtn.Top;

            panel_main.Controls.Clear();
            CustomerForm customer = new CustomerForm();
            customer.TopLevel = false;
            customer.Dock = DockStyle.Fill;
            customer.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(customer);
            customer.Show();
        }

        private void reservationBtn_Click(object sender, EventArgs e)
        {
            panel_slide.Height = reservationBtn.Height;
            panel_slide.Top = reservationBtn.Top;

            panel_main.Controls.Clear();
            ReservationForm reserve = new ReservationForm();
            reserve.TopLevel = false;
            reserve.Dock = DockStyle.Fill;
            reserve.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(reserve);
            reserve.Show();
        }

        private void roomsBtn_Click(object sender, EventArgs e)
        {
            panel_slide.Height = roomsBtn.Height;
            panel_slide.Top = roomsBtn.Top;

            panel_main.Controls.Clear();
            RoomForm room = new RoomForm();
            room.TopLevel = false;
            room.Dock = DockStyle.Fill;
            room.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(room);
            room.Show();      
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            panel_slide.Height = logoutBtn.Height;
            panel_slide.Top = logoutBtn.Top;
        }

        private void panel_cover_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
