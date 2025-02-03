using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelReservationSystem3.Controllers;

namespace HotelReservationSystem3
{
    public partial class ReservationForm : Form
    {
        RoomController room = new RoomController();
        ReservationController reservation = new ReservationController();
        private DateTimePicker dateTimePicker_In;
        private DateTimePicker dateTimePicker_Out;

        public ReservationForm()
        {
            InitializeComponent();
            dateTimePicker_In = new DateTimePicker();
            dateTimePicker_Out = new DateTimePicker();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

        {
            try
            {
                int type = Convert.ToInt32(comboBox_roomType.SelectedValue.ToString());
                comboBox_roomNo.DataSource = reservation.roomByType(type);
                comboBox_roomNo.DisplayMember = "RoomId";
                comboBox_roomNo.ValueMember = "RoomId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        

private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            comboBox_roomType.DataSource = room.getRoomType();
            comboBox_roomType.DisplayMember = "Label";
            comboBox_roomType.ValueMember = "CategoryId";

            int type = Convert.ToInt32(comboBox_roomType.SelectedValue.ToString());
            comboBox_roomNo.DataSource = reservation.roomByType(type);
            comboBox_roomNo.DisplayMember = "RoomId";
            comboBox_roomNo.ValueMember = "RoomId";

            getReservTable();

        }
        public void getReservTable()
        {
            dataGridView_reservation.DataSource = reservation.getReserv();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int customerId = Convert.ToInt32(textBox_customerId.Text);
                int roomNo = Convert.ToInt32(comboBox_roomNo.SelectedValue?.ToString());

                DateTime dateIn = dateTimePicker_In.Value;
                DateTime dateOut = dateTimePicker_Out.Value;

                if (dateIn <= DateTime.Today)
                {
                    MessageBox.Show("Invalid Date In", "Date In Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dateOut <= dateIn)
                {
                    MessageBox.Show("Invalid Date Out", "Date Out Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (reservation.addReservation(customerId, roomNo, dateIn, dateOut) && reservation.setReservRoom(roomNo, "Busy"))
                    {
                        MessageBox.Show("Reservation Added Successfully", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getReservTable();
                    }
                    else
                    {
                        MessageBox.Show("Reservation not Added", "Error Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Reservation Add error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_reservId.Text))
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convert ID to integer
            if (!int.TryParse(textBox_customerId.Text, out int customerId))
            {
                MessageBox.Show("Invalid Customer ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Delete room
                bool deleteRoom = room.removeRoom(customerId);
                if (deleteRoom)
                {
                    MessageBox.Show("Room deleted successfully", "Room Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getReservTable();
                    clearBtn.PerformClick();
                }
                else
                {
                    MessageBox.Show("Error – room not deleted", "An Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBox_reservId.Clear();
            textBox_customerId.Clear();
            comboBox_roomType.SelectedIndex = 0;
            comboBox_roomNo.SelectedIndex = 0;
        }
    }
}
