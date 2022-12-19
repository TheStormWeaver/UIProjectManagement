﻿using System;
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
    public partial class User : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        string con = ConfigurationManager.ConnectionStrings["ProjectManagement.Properties.Settings.ProjectManagementDBConnectionString"].ConnectionString;

        public User()
        {
            InitializeComponent();
        }

        private void typecb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void typel_Click(object sender, EventArgs e)
        {

        }

        private void lastnamet_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastnamel_Click(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(con);
            cn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(con);
            cn.Open();

            if (firstnamet.Text != string.Empty || surnamet.Text != string.Empty || lastnamel.Text != string.Empty)
            {
               
                cmd = new SqlCommand("insert into [EXPERTS] values(@firstName,@surName,@lastName,@client,@startDate,@endDate, 1, @pay)", cn);
                cmd.Parameters.AddWithValue("firstName", firstnamet.Text);
                cmd.Parameters.AddWithValue("surName", surnamet.Text);
                cmd.Parameters.AddWithValue("lastName", lastnamel.Text);

                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cn.Close();
            }
        }

        private void surnamet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
