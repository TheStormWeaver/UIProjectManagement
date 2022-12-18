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

        }
    }
}
