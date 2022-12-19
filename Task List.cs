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
    public partial class Task_List : Form
    {

        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        string con = ConfigurationManager.ConnectionStrings["ProjectManagement.Properties.Settings.ProjectManagementDBConnectionString"].ConnectionString;

        public Task_List()
        {
            InitializeComponent();
        }

        private void Task_List_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(con);
            cn.Open();
            // TODO: This line of code loads data into the 'projectManagementDBDataSet.PROJECT_TASKS' table. You can move, or remove it, as needed.
            this.pROJECT_TASKSTableAdapter.Fill(this.projectManagementDBDataSet.PROJECT_TASKS);
            cmd = new SqlCommand("select pt.TASK_ID, p.PROJECT_NAME, E.EXPERT_NAME, pt.TASK_NAME, pt.TASK_DESCRIPTION, pt.TAS_DELIVERABLES, pt.TASK_BEGIN, pt.TASK_END, pt.TASK_PRIORITY, ts.STATUS_NAME AS 'TASK_STATUS', pt.TASK_READY, pt.TASK_HOURS from[PROJECT_TASKS] pt JOIN[PROJECTS] p ON pt.PROJECT_ID = p.PROJECT_ID JOIN EXPERTS e ON pt.EXPRET_ID = e.EXPRET_ID Join TASK_STATUS ts on pt.TASK_STATUS = ts.STATUS_ID", cn);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cn.Close();
            taskListGrid.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create_Task frm = new Create_Task();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Task_Details frm = new Task_Details();
            frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Create_Task frm = new Create_Task();
            frm.ShowDialog();
        }

        private void taskListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string taskCode;
            //Delete.
            if (taskListGrid.CurrentCell.ColumnIndex.Equals(14) && e.RowIndex != -1)
            {
                if (taskListGrid.CurrentCell != null && taskListGrid.CurrentCell.Value != null)
                {
                    taskCode = taskListGrid.Rows[taskListGrid.CurrentRow.Index].Cells[0].FormattedValue.ToString();
                    deleteTask(taskCode);
                    taskListGrid.Refresh();
                    //projectListGrid.DataSource = ;
                }
            }
            //Edit
            if (taskListGrid.CurrentCell.ColumnIndex.Equals(13) && e.RowIndex != -1)
            {
                if (taskListGrid.CurrentCell != null && taskListGrid.CurrentCell.Value != null)
                {
                    taskCode = taskListGrid.Rows[taskListGrid.CurrentRow.Index].Cells[0].FormattedValue.ToString();
                    TaskEdit frm = new TaskEdit(Int32.Parse(taskCode));
                    frm.ShowDialog();
                }
            }
            //Details
            if (taskListGrid.CurrentCell.ColumnIndex.Equals(12) && e.RowIndex != -1)
            {
                if (taskListGrid.CurrentCell != null && taskListGrid.CurrentCell.Value != null)
                {
                    taskCode = taskListGrid.Rows[taskListGrid.CurrentRow.Index].Cells[0].FormattedValue.ToString();
                    Details_Project frm = new Details_Project(Int32.Parse(taskCode));
                    frm.ShowDialog();
                }
            }
        }

        public void deleteTask(string projectCode)
        {
            cn = new SqlConnection(con);
            cn.Open();

            cmd = new SqlCommand("select * from [PROJECT_TASKS]  WHERE TASK_ID ='" + projectCode + "'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
               
                cmd = new SqlCommand("DELETE FROM [PROJECT_TASKS]  WHERE TASK_ID = '" + projectCode + "'", cn);
                dr = cmd.ExecuteReader();
                dr.Close();
                MessageBox.Show("Deleted Task", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmd = new SqlCommand("select pt.TASK_ID, p.PROJECT_NAME, E.EXPERT_NAME, pt.TASK_NAME, pt.TASK_DESCRIPTION, pt.TAS_DELIVERABLES, pt.TASK_BEGIN, pt.TASK_END, pt.TASK_PRIORITY, ts.STATUS_NAME AS 'TASK_STATUS', pt.TASK_READY, pt.TASK_HOURS from[PROJECT_TASKS] pt JOIN[PROJECTS] p ON pt.PROJECT_ID = p.PROJECT_ID JOIN EXPERTS e ON pt.EXPRET_ID = e.EXPRET_ID Join TASK_STATUS ts on pt.TASK_STATUS = ts.STATUS_ID", cn);
                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                taskListGrid.DataSource = dt;
                taskListGrid.Update();
            }
            else
            {
                dr.Close();
                MessageBox.Show("Task does not exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr.Close();
            cn.Close();
        }
    }
}
