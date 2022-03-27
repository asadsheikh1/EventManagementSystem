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
    public partial class FoodDeals : Form
    {
        public FoodDeals()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            try
            {
                textBoxDID.Clear();
                textBoxDName.Clear();
                textBoxDPrice.Clear();
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
                SqlDataAdapter da = new SqlDataAdapter("EXEC SP_VIEW_DEAL;", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewDealInfo.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Clear2()
        {
            try
            {
                comboBoxFID.SelectedIndex = -1;
                textBoxDID2.Clear();
                textBoxQuantity.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Display2()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("EXEC SP_VIEW_FOOD_DEAL;", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewFoodDealInfo.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FoodDeals_Load(object sender, EventArgs e)
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

        private void btnDisplayDeal_Click(object sender, EventArgs e)
        {
        }

        private void btnAddDeal_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteDeal_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        }

        private void dataGridViewDealInfo_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                textBoxDID.Text = dataGridViewDealInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxDName.Text = dataGridViewDealInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxDPrice.Text = dataGridViewDealInfo.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddDeal_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to add a new deal to the database?", "Denko | Event Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("EXEC SP_INSERT_DEAL " + textBoxDID.Text + ", '" + textBoxDName.Text + "', " + textBoxDPrice.Text + ";", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Display();
                    Clear();

                    MessageBox.Show("A new deal is added successfully to the database.", "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisplayDeal_Click_1(object sender, EventArgs e)
        {
            Display();
            Clear();
        }

        private void btnDeleteDeal_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("EXEC SP_DELETE_DEAL @deal_id;", con);
                cmd.Parameters.AddWithValue("@deal_id", textBoxDID.Text);
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

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddDeal2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to add a new food deal to the database?", "Denko | Event Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("EXEC SP_INSERT_FOOD_DEAL " + comboBoxFID.Text + ", " + textBoxDID2.Text + ", " + textBoxQuantity.Text + ";", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Display2();
                    Clear2();

                    MessageBox.Show("A new food deal is added successfully to the database.", "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisplayDeal2_Click(object sender, EventArgs e)
        {
            Display2();
            Clear2();
        }

        private void dataGridViewFoodDealInfo_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                comboBoxFID.Text = dataGridViewFoodDealInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxDID2.Text = dataGridViewFoodDealInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxQuantity.Text = dataGridViewFoodDealInfo.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteDeal2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("EXEC SP_DELETE_FOOD_DEAL @food_id, @deal_id;", con);
                cmd.Parameters.AddWithValue("@food_id", comboBoxFID.SelectedItem);
                cmd.Parameters.AddWithValue("@deal_id", textBoxDID2.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                Display2();
                Clear2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
