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
    public partial class Details_Project : Form
    {

        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        string con = ConfigurationManager.ConnectionStrings["ProjectManagement.Properties.Settings.ProjectManagementDBConnectionString"].ConnectionString;
        int projectCode;

        public Details_Project(int projectCode)
        {
            InitializeComponent();
            this.projectCode = projectCode;
        }

        private void Details_Project_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(con);
            cn.Open();
            /*
            // TODO: This line of code loads data into the 'projectManagementDBDataSet.PROJECT_TASKS' table. You can move, or remove it, as needed.
            this.pROJECT_TASKSTableAdapter.Fill(this.projectManagementDBDataSet.PROJECT_TASKS);
            // TODO: This line of code loads data into the 'projectManagementDBDataSet.EXPERTS' table. You can move, or remove it, as needed.
            this.eXPERTSTableAdapter.Fill(this.projectManagementDBDataSet.EXPERTS);
            // TODO: This line of code loads data into the 'projectManagementDBDataSet.PROJECTS' table. You can move, or remove it, as needed.
            this.pROJECTSTableAdapter.Fill(this.projectManagementDBDataSet.PROJECTS);
            */
            cmd = new SqlCommand("select * from [Experts]", cn);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            
            eXPERTSDataGridView.DataSource = dt;

            cmd = new SqlCommand("select * from [PROJECT_TASKS] pt WHERE pt.PROJECT_ID = "+projectCode+"", cn);
            dr = cmd.ExecuteReader();
            DataTable dtProj = new DataTable();
            dtProj.Load(dr);
            pROJECT_TASKSDataGridView.DataSource = dtProj;
            dr.Close();

            cmd = new SqlCommand("select p.PROJECT_ID, p.PROJECT_NAME, p.PROJECT_DESCRIPTION, p.PROJECT_CLIENT, p.PROJECT_BEGIN, p.PROJECT_END, ps.PSTATUS_NAME as 'PROJECT_STATUS', p.PROJECT_PAY_PER_HOUR from [PROJECTS] p JOIN [PROJECT_STATUS] ps ON p.PROJECT_STATUS = ps.PSTATUS_ID WHERE p.PROJECT_ID = "+ projectCode+" ", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtName.Text = dr["PROJECT_NAME"].ToString();
                txtDesc.Text = dr["PROJECT_DESCRIPTION"].ToString();
                txtClient.Text = dr["PROJECT_CLIENT"].ToString();
                txtStatus.Text = dr["PROJECT_STATUS"].ToString();
                txtStart.Text = dr["PROJECT_BEGIN"].ToString();
                txtEnd.Text = dr["PROJECT_END"].ToString();
                txtPay.Text = dr["PROJECT_PAY_PER_HOUR"].ToString();
            }
            dr.Close();
            cn.Close();
        }

        private void pROJECTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            /*
            this.pROJECTSBindingSource.EndEdit();
            */
            this.tableAdapterManager.UpdateAll(this.projectManagementDBDataSet);

        }

        private void eXPERTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eXPERTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectManagementDBDataSet);

        }
    }
}
