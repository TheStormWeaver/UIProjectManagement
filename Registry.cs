using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement
{
    public partial class Registry : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public Registry()
        {
            InitializeComponent();
        }

        private void Registry_Load(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["ProjectManagement.Properties.Settings.ProjectManagementDBConnectionString"].ConnectionString;
            cn = new SqlConnection(con);
            cn.Open();
        }

        private void registryBtn_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text != string.Empty || txtPassword.Text != string.Empty || txtUsername.Text != string.Empty || txtFirstname.Text != string.Empty || txtSurname.Text != string.Empty || txtLastname.Text != string.Empty)
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    cmd = new SqlCommand("select * from [APP_USER] where username='" + txtUsername.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into [APP_USER] values(@username,@password, 2)", cn);
                        cmd.Parameters.AddWithValue("username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("password", txtPassword.Text);
                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("select * from [APP_USER] where username='" + txtUsername.Text + "'", cn);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            int id = 0;
                            id = Int32.Parse(dr["Id"].ToString());
                            dr.Close();
                            cmd = new SqlCommand("insert into [EXPERTS] values(" + id + 1 + ", 'E', @firstname, @surname, @lasttname, " + id + ")", cn);
                            cmd.Parameters.AddWithValue("firstname", txtFirstname.Text);
                            cmd.Parameters.AddWithValue("surname", txtSurname.Text);
                            cmd.Parameters.AddWithValue("lasttname", txtLastname.Text);
                            cmd.ExecuteNonQuery();
                            cn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
