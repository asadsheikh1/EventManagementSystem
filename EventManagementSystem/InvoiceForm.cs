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
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            PID();
            EID();
        }
        private void PID()
        {
            comboBoxPID.Items.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT package_id FROM PACKAGE;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBoxPID.Items.Add(dr["package_id"].ToString());
            }
            con.Close();
        }
        private void EID()
        {
            comboBoxCID.Items.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT customer_id FROM CUSTOMER;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBoxCID.Items.Add(dr["customer_id"].ToString());
            }
            con.Close();
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("EXEC SP_FETCH_INVOICE " + comboBoxPID.Text + ", " + comboBoxCID.Text + ";", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    textBoxTotalAmount.Text = sdr.GetValue(0).ToString();
                }
                con.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("EXEC SP_INSERT_INVOICE " + textBoxIID.Text + ", " + comboBoxCID.Text + ", " + comboBoxDay.Text + ", " + comboBoxMonth.Text + ", " + comboBoxYear.Text + ";", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("A new invocie is generated.\nInvoice ID: " + textBoxIID.Text + "\nDay: " + comboBoxDay.Text + " | Month: " + comboBoxMonth.Text + " | Year: " + comboBoxYear.Text + "\nCustomer ID: " + comboBoxCID.Text + "\nPackage ID: " + comboBoxPID.Text + "\nTotal Amount: " + textBoxTotalAmount.Text + "", "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
