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
    public partial class PackageForm : Form
    {
        public PackageForm()
        {
            InitializeComponent();
        }

        private void PackageForm_Load(object sender, EventArgs e)
        {
            PID();
            EID();
            TID();
            FID();
            SID();
            CID();
        }
        private void Clear()
        {
            try
            {
                comboBoxPID.SelectedIndex = -1;
                comboBoxEID.SelectedIndex = -1;
                comboBoxTID.SelectedIndex = -1;
                comboBoxFID.SelectedIndex = -1;
                comboBoxSID.SelectedIndex = -1;
                comboBoxCID.SelectedIndex = -1;
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
                SqlDataAdapter da = new SqlDataAdapter("EXEC SP_VIEW_PACKAGE;", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewPackageInfo.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            comboBoxEID.Items.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT event_id FROM EVENT_MODULE;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBoxEID.Items.Add(dr["event_id"].ToString());
            }
            con.Close();
        }
        private void TID()
        {
            comboBoxTID.Items.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT transport_id FROM TRANSPORT;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBoxTID.Items.Add(dr["transport_id"].ToString());
            }
            con.Close();
        }
        private void FID()
        {
            comboBoxFID.Items.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT food_id FROM FOOD;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBoxFID.Items.Add(dr["food_id"].ToString());
            }
            con.Close();
        }
        private void SID()
        {
            comboBoxSID.Items.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT service_id FROM SERVICE;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBoxSID.Items.Add(dr["service_id"].ToString());
            }
            con.Close();
        }
        private void CID()
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

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to add new package to the database?", "Denko | Event Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("EXEC SP_INSERT_PACKAGE " + comboBoxEID.Text + ", " + comboBoxTID.Text + ", " + comboBoxFID.Text + ", " + comboBoxSID.Text + ", " + comboBoxPID.Text + ", " + comboBoxCID.Text + ";", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Display();
                    Clear();

                    MessageBox.Show("A new package is added successfully to the database.", "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisplayPackage_Click(object sender, EventArgs e)
        {
            Display();
            Clear();
        }

        private void dataGridViewPackageInfo_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                comboBoxPID.Text = dataGridViewPackageInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
                comboBoxCID.Text = dataGridViewPackageInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboBoxEID.Text = dataGridViewPackageInfo.Rows[e.RowIndex].Cells[2].Value.ToString();
                comboBoxTID.Text = dataGridViewPackageInfo.Rows[e.RowIndex].Cells[3].Value.ToString();
                comboBoxFID.Text = dataGridViewPackageInfo.Rows[e.RowIndex].Cells[4].Value.ToString();
                comboBoxSID.Text = dataGridViewPackageInfo.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletePackage_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("EXEC SP_DELETE_PACKAGE @package_id;", con);
                cmd.Parameters.AddWithValue("@package_id", comboBoxPID.Text);
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

        private void btnUpdatePackage_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("EXEC SP_UPDATE_PACKAGE " + comboBoxEID.Text + ", " + comboBoxTID.Text + ", " + comboBoxFID.Text + ", " + comboBoxSID.Text + ", " + comboBoxPID.Text + ", " + comboBoxCID.Text + ";", con);
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
