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
    public partial class Create_Project : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        string con = ConfigurationManager.ConnectionStrings["ProjectManagement.Properties.Settings.ProjectManagementDBConnectionString"].ConnectionString;
        public Create_Project()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(con);
            cn.Open();

            if (txtName.Text != string.Empty || txtDesc.Text != string.Empty || txtCode.Text != string.Empty || txtStartDate.Text != string.Empty || txtEndDate.Text != string.Empty || projectClientcb.Text != string.Empty || txtPay.Text != string.Empty)
            {
                cmd = new SqlCommand("select * from [PROJECTS] where PROJECT_NAME='" + txtName.Text + "' AND PROJECT_ID = '" + txtCode.Text + "' ", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into [PROJECTS] values(@code,@name,@desc,@client,@startDate,@endDate, 1, @pay)", cn);
                    cmd.Parameters.AddWithValue("code", txtCode.Text);
                    cmd.Parameters.AddWithValue("name", txtName.Text);
                    cmd.Parameters.AddWithValue("desc", txtDesc.Text);
                    cmd.Parameters.AddWithValue("client", projectClientcb.Text);
                    cmd.Parameters.AddWithValue("startDate", Convert.ToDateTime(txtStartDate.Value.ToString("yyyy-MM-dd")));
                    cmd.Parameters.AddWithValue("endDate", Convert.ToDateTime(txtEndDate.Value.ToString("yyyy-MM-dd")));
                    cmd.Parameters.AddWithValue("pay", txtPay.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Project Created.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    cn.Close();
                    this.Close();
                }
                
               // cn.Close();
            }
        }

        private void Create_Project_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(con);
            cn.Open();

            cmd = new SqlCommand("select c.NAME from [CLIENT] c", cn);
            List<string> list = new List<string>();
            string name = null;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                while (dr.Read())
                {
                    name = dr["NAME"].ToString();
                    list.Add(name);
                }
            }
            cn.Close();
            dr.Close();
            projectClientcb.DataSource = list;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Create_Project_Load_1(object sender, EventArgs e)
        {
            this.projectClientcb.DrawMode = DrawMode.OwnerDrawFixed;
        }

        private void txtPay_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
