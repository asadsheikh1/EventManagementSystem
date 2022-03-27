using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EventManagementSystem
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            try
            {
                textBoxCID.Clear();
                textBoxFName.Clear();
                textBoxLName.Clear();
                textBoxDOB.Clear();
                textBoxPhone.Clear();
                textBoxBlock.Clear();
                textBoxStreet.Clear();
                textBoxArea.Clear();
                textBoxCity.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Display()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("EXEC SP_VIEW_CUSTOMER;", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewCustomerInfo.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewCustomerInfo_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                textBoxCID.Text = dataGridViewCustomerInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxFName.Text = dataGridViewCustomerInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxLName.Text = dataGridViewCustomerInfo.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxDOB.Text = dataGridViewCustomerInfo.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxPhone.Text = dataGridViewCustomerInfo.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBoxBlock.Text = dataGridViewCustomerInfo.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBoxStreet.Text = dataGridViewCustomerInfo.Rows[e.RowIndex].Cells[7].Value.ToString();
                textBoxArea.Text = dataGridViewCustomerInfo.Rows[e.RowIndex].Cells[8].Value.ToString();
                textBoxCity.Text = dataGridViewCustomerInfo.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisplayCustomer_Click(object sender, EventArgs e)
        {
            Display();
            Clear();
        }

        private void textBoxSearchCustomerName_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to add new customer to the database?", "Denko | Event Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("EXEC SP_INSERT_CUSTOMER " + textBoxCID.Text + ", '" + textBoxDOB.Text + "', '" + textBoxFName.Text + "', '" + textBoxLName.Text + "', " + textBoxPhone.Text + ", '" + textBoxBlock.Text + "', '" + textBoxStreet.Text + "', '" + textBoxArea.Text + "', '" + textBoxCity.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Display();
                    Clear();

                    MessageBox.Show("A new customer is added successfully to the database.", "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("EXEC SP_DELETE_CUSTOMER @customer_id", con);
                cmd.Parameters.AddWithValue("@customer_id", textBoxCID.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                Display();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("EXEC SP_UPDATE_CUSTOMER @customer_id, @dob, @customer_f_name, @customer_l_name, @customer_phone, @block, @street, @area, @city;", con);
                cmd.Parameters.AddWithValue("@customer_id", textBoxCID.Text);
                cmd.Parameters.AddWithValue("@dob", textBoxDOB.Text);
                cmd.Parameters.AddWithValue("@customer_f_name", textBoxFName.Text);
                cmd.Parameters.AddWithValue("@customer_l_name", textBoxLName.Text);
                cmd.Parameters.AddWithValue("@customer_phone", textBoxPhone.Text);
                cmd.Parameters.AddWithValue("@block", textBoxBlock.Text);
                cmd.Parameters.AddWithValue("@street", textBoxStreet.Text);
                cmd.Parameters.AddWithValue("@area", textBoxArea.Text);
                cmd.Parameters.AddWithValue("@city", textBoxCity.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                Display();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
