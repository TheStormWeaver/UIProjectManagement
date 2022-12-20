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
    public partial class ProjectEdit : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        string con = ConfigurationManager.ConnectionStrings["ProjectManagement.Properties.Settings.ProjectManagementDBConnectionString"].ConnectionString;
        int projectCode;

        public ProjectEdit(int projectCode)
        {
            InitializeComponent();
            this.projectCode = projectCode;

/* this.projectCode = projectCode;
[21:59]
private void ProjectEdit_Load(object sender, EventArgs e)
{
cn = new SqlConnection(con);
cn.Open();

cmd = new SqlCommand("select * from [PROJECTS] where PROJECT_ID='" + projectCode + "'", cn);
dr = cmd.ExecuteReader();
if (dr.Read())
{
    txtTitle.Text = dr["PROJECT_NAME"].ToString();
    txtDescription.Text = dr["PROJECT_DESCRIPTION"].ToString();
    txtEndDate.Text = dr["PROJECT_END"].ToString();
//     txtPrice = dr["PROJECT_PEY_PER_HOUR"].ToString();
}
cn.Close();
}

private void button1_Click(object sender, EventArgs e)
{
cn = new SqlConnection(con);
cn.Open();

if (txtTitle.Text != string.Empty||txtDescription.Tex!= string.Empty||txtEndDate.Text != string.Empty)
{
    cmd = new SqlCommand("select * from [PROJECTS] where PROJECT_ID = '" + projectCode + "' ", cn);
    dr = cmd.ExecuteReader();
    if (dr.Read())
    {
        dr.Close();
        cmd = new SqlCommand("Update [PROJECTS] Set PROJECT_NAME =@name, PROJECT_DESCRIPTION =@desc Where PROJECT_ID = '" + projectCode + "' ", cn);
        cmd.Parameters.AddWithValue("name", txtTitle.Text);
        cmd.Parameters.AddWithValue("desc", txtDescription.Text);
        cmd.ExecuteNonQuery();
        dr.Close();
    }
    else
    {

    }
    MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

    cn.Close();
}
}*/
        }

        private void ProjectEdit_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(con);
            cn.Open();

            cmd = new SqlCommand("select * from [PROJECTS] where PROJECT_ID='" + projectCode + "'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtName.Text = dr["PROJECT_NAME"].ToString();
                txtDesc.Text = dr["PROJECT_DESCRIPTION"].ToString();
                txtEndDate.Text = dr["PROJECT_END"].ToString();
                txtPay.Text = dr["PROJECT_PAY_PER_HOUR"].ToString();
                //     txtPrice = dr["PROJECT_PEY_PER_HOUR"].ToString();

            }
            dr.Close();


            cmd = new SqlCommand("select c.PSTATUS_NAME from [PROJECT_STATUS] c", cn);
            List<string> list1 = new List<string>();
            //string name = null;

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                while (dr.Read())
                {
                    string name = null;
                    name = dr["PSTATUS_NAME"].ToString();
                    list1.Add(name);
                }
            }
            dr.Close();
            projectStatuscb.DataSource = list1;
            cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(con);
            cn.Open();

            if (txtName.Text != string.Empty || txtDesc.Text != string.Empty || txtEndDate.Text != string.Empty)
            {
                cmd = new SqlCommand("select * from [PROJECTS] where PROJECT_ID = '" + projectCode + "' ", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    int statusId = 0;
                    cmd = new SqlCommand("select * from [PROJECT_STATUS] where PSTATUS_NAME = '"+projectStatuscb.Text+"' ", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        statusId = Int32.Parse(dr["PSTATUS_ID"].ToString());
                        dr.Close();
                    }
                    else
                    {
                        MessageBox.Show("This Status does not exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dr.Close();
                    }


                    cmd = new SqlCommand("Update [PROJECTS] Set PROJECT_NAME =@name, PROJECT_DESCRIPTION =@desc, PROJECT_END =@endDate, PROJECT_STATUS=@statusId, PROJECT_PAY_PER_HOUR =@pay, PROJECT_CLIENT=@client Where PROJECT_ID = '" + projectCode + "' ", cn);
                    cmd.Parameters.AddWithValue("name", txtName.Text);
                    cmd.Parameters.AddWithValue("desc", txtDesc.Text);
                    cmd.Parameters.AddWithValue("endDate", Convert.ToDateTime(txtEndDate.Value.ToString("yyyy-MM-dd")));
                    cmd.Parameters.AddWithValue("statusId", statusId);
                    cmd.Parameters.AddWithValue("pay", txtPay.Text);
                    cmd.Parameters.AddWithValue("client", projectClientcb.Text);
                    cmd.ExecuteNonQuery();
                    dr.Close();
                    MessageBox.Show("Successfully updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    cn.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong!", "ERORR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
               
            }
        }

        private void txtEndDate_ValueChanged(object sender, EventArgs e)
        {

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
