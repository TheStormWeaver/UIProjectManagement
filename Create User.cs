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
                cmd = new SqlCommand("select TOP 1 EXPRET_ID from [EXPERTS] ORDER BY EXPRET_ID DESC", cn);
                int expertId = 0;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    expertId = Int32.Parse(dr["EXPRET_ID"].ToString()) + 1;
                    dr.Close();
                }

                cmd = new SqlCommand("insert into [EXPERTS] values(@exertId, 'I', @firstName, @surName, @lastName, null )", cn);
                cmd.Parameters.AddWithValue("exertId", expertId);
                cmd.Parameters.AddWithValue("firstName", firstnamet.Text);
                cmd.Parameters.AddWithValue("surName", surnamet.Text);
                cmd.Parameters.AddWithValue("lastName", lastnamel.Text);

                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Expert is created.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cn.Close();
            }
        }

        private void surnamet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
