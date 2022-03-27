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
    public partial class TransportForm : Form
    {
        public TransportForm()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            try
            {
                textBoxTID.Clear();
                textBoxTPrice.Clear();
                textBoxTSeater.Clear();
                textBoxTType.Clear();
                textBoxTQuantity.Clear();
                textBoxMExpense.Clear();
                textBoxFExpense.Clear();
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
                SqlDataAdapter da = new SqlDataAdapter("EXEC SP_VIEW_TRANSPORT;", con);
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

        private void btnDisplayTransport_Click(object sender, EventArgs e)
        {
            Display();
            Clear(); 
        }

        private void btnAddTransport_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to add new transport to the database?", "Denko | Event Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("EXEC SP_INSERT_TRANSPORT " + textBoxTID.Text + ", " + textBoxTPrice.Text + ", " + textBoxTSeater.Text + ", '" + textBoxTType.Text + "', " + textBoxTQuantity.Text + ", " + textBoxMExpense.Text + ", " + textBoxFExpense.Text + ";", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Display();
                    Clear();

                    MessageBox.Show("A new transport is added successfully to the database.", "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                textBoxTID.Text = dataGridViewTransportInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxTPrice.Text = dataGridViewTransportInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxTSeater.Text = dataGridViewTransportInfo.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxTType.Text = dataGridViewTransportInfo.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxTQuantity.Text = dataGridViewTransportInfo.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBoxMExpense.Text = dataGridViewTransportInfo.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBoxFExpense.Text = dataGridViewTransportInfo.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("EXEC SP_DELETE_TRANSPORT @transport_id;", con);
                cmd.Parameters.AddWithValue("@transport_id", textBoxTID.Text);
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

        private void TransportForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
