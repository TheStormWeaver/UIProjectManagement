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
    public partial class Task_Details : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        string con = ConfigurationManager.ConnectionStrings["ProjectManagement.Properties.Settings.ProjectManagementDBConnectionString"].ConnectionString;
        int taskCode;

        public Task_Details(int taskCode)
        {
            InitializeComponent();
            this.taskCode = taskCode;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Task_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagementDBDataSet.PROJECTS' table. You can move, or remove it, as needed.
            this.pROJECTSTableAdapter.Fill(this.projectManagementDBDataSet.PROJECTS);
            // TODO: This line of code loads data into the 'projectManagementDBDataSet.PROJECT_TASKS' table. You can move, or remove it, as needed.
            this.pROJECT_TASKSTableAdapter.Fill(this.projectManagementDBDataSet.PROJECT_TASKS);

            cn = new SqlConnection(con);
            cn.Open();

            cmd = new SqlCommand("select pt.TASK_ID, p.PROJECT_NAME, E.EXPERT_NAME, pt.TASK_NAME, pt.TASK_DESCRIPTION, pt.TAS_DELIVERABLES, pt.TASK_BEGIN, pt.TASK_END, pt.TASK_PRIORITY, ts.STATUS_NAME AS 'TASK_STATUS', pt.TASK_READY, pt.TASK_HOURS from[PROJECT_TASKS] pt JOIN[PROJECTS] p ON pt.PROJECT_ID = p.PROJECT_ID JOIN EXPERTS e ON pt.EXPRET_ID = e.EXPRET_ID Join TASK_STATUS ts on pt.TASK_STATUS = ts.STATUS_ID Where TASK_ID = '" + taskCode + "' ", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                taskNamet.Text = dr["TASK_NAME"].ToString();
                taskDescrt.Text = dr["TASK_DESCRIPTION"].ToString();
                taskStatuscb.Text = dr["TASK_STATUS"].ToString();
                taskPrioritycb.Text = dr["TASK_PRIORITY"].ToString();
                taskCommentrt.Text = dr["TAS_DELIVERABLES"].ToString();
                taskProgresst.Text = dr["TASK_READY"].ToString();
                taskExpertcb.Text = dr["EXPERT_NAME"].ToString();
                taskHourst.Text = dr["TASK_HOURS"].ToString();
                projectNames.Text = dr["PROJECT_NAME"].ToString();
                txtStartDate.Text = dr["TASK_BEGIN"].ToString();
                txtEndDate.Text = dr["TASK_END"].ToString();
            }
            else
            {
                MessageBox.Show("Something went wrong! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cn.Close();

        }

        private void pROJECT_TASKSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pROJECT_TASKSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectManagementDBDataSet);

        }

    }
}
