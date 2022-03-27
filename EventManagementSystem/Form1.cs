using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EventManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxPass.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-OG406SN\SQLEXPRESS;Initial Catalog=Event_Management_System;Integrated Security=True";
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT username, pass FROM ADMIN_LOGIN WHERE username = '" + textBoxUsername.Text + "' AND pass = '" + textBoxPass.Text + "';", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();

                    textBoxUsername.Clear();
                    textBoxPass.Clear();
                }
                else
                {
                    MessageBox.Show("Unsuccessful login.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Denko | Event Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPass.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPass.UseSystemPasswordChar = true;
            }
        }
    }
}
