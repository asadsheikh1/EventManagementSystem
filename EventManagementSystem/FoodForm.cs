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
    public partial class FoodForm : Form
    {
        public FoodForm()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            try
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
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
                SqlDataAdapter da = new SqlDataAdapter("EXEC SP_VIEW_FOOD;", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewFoodInfo.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Display();
            Clear();
        }

        private void dataGridViewFoodInfo_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridViewFoodInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = dataGridViewFoodInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox3.Text = dataGridViewFoodInfo.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox4.Text = dataGridViewFoodInfo.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox5.Text = dataGridViewFoodInfo.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox6.Text = dataGridViewFoodInfo.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to add new food item to the database?", "Denko | Event Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("EXEC SP_INSERT_FOOD " + textBox1.Text + ", " + textBox2.Text + ", '" + textBox3.Text + "', " + textBox4.Text + ", '" + textBox5.Text + "', " + textBox6.Text + ";", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Display();
                    Clear();

                    MessageBox.Show("A new food item is added successfully to the database.", "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("EXEC SP_DELETE_FOOD @food_id;", con);
                cmd.Parameters.AddWithValue("@food_id", textBox1.Text);
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
