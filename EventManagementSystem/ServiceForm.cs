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
    public partial class ServiceForm : Form
    {
        public ServiceForm()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            try
            {
                textBoxSID.Clear();
                textBoxSType.Clear();
                textBoxSPrice.Clear();
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
                SqlDataAdapter da = new SqlDataAdapter("EXEC SP_VIEW_SERVICE;", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewTransportInfo.DataSource = dt;
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

        private void btnAddService_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to add new service to the database?", "Denko | Event Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("EXEC SP_INSERT_SERVICE " + textBoxSID.Text + ", '" + textBoxSType.Text + "', " + textBoxSPrice.Text + ";", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Display();
                    Clear();

                    MessageBox.Show("A new service is added successfully to the database.", "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisplayService_Click(object sender, EventArgs e)
        {
            Display();
            Clear();
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("EXEC SP_DELETE_SERVICE @service_id;", con);
                cmd.Parameters.AddWithValue("@service_id", textBoxSID.Text);
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

        private void dataGridViewTransportInfo_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                textBoxSID.Text = dataGridViewTransportInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxSType.Text = dataGridViewTransportInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxSPrice.Text = dataGridViewTransportInfo.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
