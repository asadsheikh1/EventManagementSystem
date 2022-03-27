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
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            try
            {
                textBoxEID.Clear();
                textBoxEName.Clear();
                comboBoxEType.SelectedIndex = -1;
                textBoxEDate.Clear();
                textBoxEPrice.Clear();
                textBoxEDescription.Clear();
                textBoxETheme.Clear();
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
                SqlDataAdapter da = new SqlDataAdapter("SELECT EVENT_MODULE.event_id, event_name, event_type, event_date_time, event_price, event_description, event_theme FROM EVENT_MODULE INNER JOIN EVENT_MODULE_EVENT_THEME ON EVENT_MODULE.event_id = EVENT_MODULE_EVENT_THEME.event_id;", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewEventsInfo.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisplayEventPackages_Click(object sender, EventArgs e)
        {
            Display();
            Clear();
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to add new event to the database?", "Denko | Event Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("EXEC SP_INSERT_EVENT " + textBoxEID.Text + ", '" + textBoxEName.Text + "', '" + comboBoxEType.Text + "', '" + textBoxEDate.Text + "', " + textBoxEPrice.Text + ", '" + textBoxEDescription.Text + "', '" + textBoxETheme.Text + "';", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Display();
                    Clear();

                    MessageBox.Show("A new event is added successfully to the database.", "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewEventsInfo_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                textBoxEID.Text = dataGridViewEventsInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxEName.Text = dataGridViewEventsInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboBoxEType.Text = dataGridViewEventsInfo.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxEDate.Text = dataGridViewEventsInfo.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxEPrice.Text = dataGridViewEventsInfo.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBoxEDescription.Text = dataGridViewEventsInfo.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBoxETheme.Text = dataGridViewEventsInfo.Rows[e.RowIndex].Cells[6].Value.ToString();
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
                SqlCommand cmd = new SqlCommand("EXEC SP_DELETE_EVENT @event_id", con);
                cmd.Parameters.AddWithValue("@event_id", textBoxEID.Text);
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
    }
}
