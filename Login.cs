using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectManagement.Models;

namespace ProjectManagement
{
    public partial class Login : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-9166LMU;Initial Catalog=ProjectManagementDB;Integrated Security=True");
            cn.Open();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != string.Empty || txtUsername.Text != string.Empty)
            {
                string name = null;
                cmd = new SqlCommand("select * from [APP_USER] where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    CurrentUser user = new CurrentUser();
                    name = dr["username"].ToString();
                    user.Name = name;
                    dr.Close();
                    this.Hide();
                    menu home = new menu(user);
                    home.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void regBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registry login = new Registry();
            login.ShowDialog();
        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            if (txtPassword.Text != string.Empty || txtUsername.Text != string.Empty)
            {
                string name = null;
                cmd = new SqlCommand("select * from [APP_USER] where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    CurrentUser user = new CurrentUser();
                    name = dr["username"].ToString();
                    user.Name = name;
                    dr.Close();
                    this.Hide();
                    menu home = new menu(user);
                    home.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
