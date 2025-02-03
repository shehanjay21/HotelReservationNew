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
using HotelReservationSystem3.Models;
using Org.BouncyCastle.Asn1.BC;

namespace HotelReservationSystem3
{
    public partial class CustomerForm : Form
    {
        CustomerController customer = new CustomerController();
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBox_Id.Clear();
            textBox_fName.Clear();
            textBox_lName.Clear();
            textBox_phone.Clear();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrEmpty(textBox_Id.Text) || string.IsNullOrEmpty(textBox_fName.Text) || string.IsNullOrEmpty(textBox_lName.Text) || string.IsNullOrEmpty(textBox_phone.Text))
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convert ID to integer
            if (!int.TryParse(textBox_Id.Text, out int customerId))
            {
                MessageBox.Show("Invalid Customer ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fname = textBox_fName.Text;
            string lname = textBox_lName.Text;
            string phone = textBox_phone.Text;

            // Insert customer
            bool insertCustomer = customer.InsertCustomer(customerId, fname, lname, phone);
            if (insertCustomer)
            {
                MessageBox.Show("New customer saved successfully", "Customer Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getTable();

                clearBtn.PerformClick();
            }
            else
            {
                MessageBox.Show("Error - customer not entered", "An Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_lName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // Validate input field
            if (string.IsNullOrEmpty(textBox_Id.Text))
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convert ID to integer
            if (!int.TryParse(textBox_Id.Text, out int customerId))
            {
                MessageBox.Show("Invalid Customer ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Delete customer
                bool deleteCustomer = customer.removeCustomer(customerId);
                if (deleteCustomer)
                {
                    MessageBox.Show("Customer deleted successfully", "Customer Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getTable();

                    clearBtn.PerformClick();
                }
                else
                {
                    MessageBox.Show("Error - customer not deleted", "An Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Log the error or handle it as needed
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void getTable()
        {
            dataGridView_customer.DataSource = customer.getCustomer();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Id.Text) || string.IsNullOrEmpty(textBox_fName.Text) || string.IsNullOrEmpty(textBox_lName.Text) || string.IsNullOrEmpty(textBox_phone.Text))
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convert ID to integer
            if (!int.TryParse(textBox_Id.Text, out int customerId))
            {
                MessageBox.Show("Invalid Customer ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fname = textBox_fName.Text;
            string lname = textBox_lName.Text;
            string phone = textBox_phone.Text;

            // Insert customer
            bool editCustomer = customer.editCustomer(customerId, fname, lname, phone);
            if (editCustomer)
            {
                MessageBox.Show("Customer data updated successfully", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getTable();

                clearBtn.PerformClick();
            }
            else
            {
                MessageBox.Show("Error - customer data not updated", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_Id.Text = dataGridView_customer.CurrentRow.Cells[0].Value.ToString();
            textBox_fName.Text = dataGridView_customer.CurrentRow.Cells[1].Value.ToString();
            textBox_lName.Text = dataGridView_customer.CurrentRow.Cells[2].Value.ToString();
            textBox_phone.Text = dataGridView_customer.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridView_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_Id.Text = dataGridView_customer.CurrentRow.Cells[0].Value.ToString();
            textBox_fName.Text = dataGridView_customer.CurrentRow.Cells[1].Value.ToString();
            textBox_lName.Text = dataGridView_customer.CurrentRow.Cells[2].Value.ToString();
            textBox_phone.Text = dataGridView_customer.CurrentRow.Cells[3].Value.ToString();
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Red;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.White;
        }
    }
    
}
