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
    public partial class EditUser : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        string con = ConfigurationManager.ConnectionStrings["ProjectManagement.Properties.Settings.ProjectManagementDBConnectionString"].ConnectionString;
        int userId;

        public EditUser(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(con);
            cn.Open();

            cmd = new SqlCommand("select * from [EXPERTS] where EXPRET_ID = "+ userId + " ", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                

                firstnamet.Text = dr["EXPERT_NAME"].ToString();
                surnamet.Text = dr["EXPERT_SURNAME"].ToString();
                lastnamet.Text = dr["EXPERT_LASTNAME"].ToString();

                dr.Close();
            }
            else
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (firstnamet.Text != string.Empty || surnamet.Text != string.Empty || lastnamet.Text != string.Empty )
            {
                cmd = new SqlCommand("select * from [EXPERTS] where EXPRET_ID = " + userId + " ", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    cmd = new SqlCommand("Update [EXPERTS] Set EXPERT_NAME =@name, EXPERT_SURNAME =@surname, EXPERT_LASTNAME =@lasrname Where EXPRET_ID = '" + userId + "' ", cn);
                    cmd.Parameters.AddWithValue("name", firstnamet.Text);
                    cmd.Parameters.AddWithValue("surname", surnamet.Text);
                    cmd.Parameters.AddWithValue("lasrname", lastnamet.Text);
                    cmd.ExecuteNonQuery();
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cn.Close();
                MessageBox.Show("Successfully updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            
            }
        }
    }
}
