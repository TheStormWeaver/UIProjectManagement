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
    public partial class TaskEdit : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        string con = ConfigurationManager.ConnectionStrings["ProjectManagement.Properties.Settings.ProjectManagementDBConnectionString"].ConnectionString;
        int taskCode;

        public TaskEdit(int taskCode)
        {
            InitializeComponent();
            this.taskCode = taskCode;
        }

        private void TaskEdit_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Add("L");
            list.Add("M");
            list.Add("H");

            taskPrioritycb.DataSource = list;

            cn = new SqlConnection(con);
            cn.Open();

            cmd = new SqlCommand("select c.STATUS_NAME from [TASK_STATUS] c", cn);
            List<string> list1 = new List<string>();
            //string name = null;
            DataTable dt = new DataTable();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                while (dr.Read())
                {
                    string name = null;
                    name = dr["STATUS_NAME"].ToString();
                    list1.Add(name);
                }
            }
            dr.Close();
            taskStatuscb.DataSource = list1;

            cmd = new SqlCommand("select c.EXPERT_NAME from [EXPERTS] c", cn);
            List<string> expertNames = new List<string>();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                while (dr.Read())
                {
                    string name = null;
                    name = dr["EXPERT_NAME"].ToString();
                    expertNames.Add(name);
                }
            }
            dr.Close();
            taskExpertcb.DataSource = expertNames;

            cmd = new SqlCommand("select pt.TASK_ID, p.PROJECT_NAME, E.EXPERT_NAME, pt.TASK_NAME, pt.TASK_DESCRIPTION, pt.TAS_DELIVERABLES, pt.TASK_BEGIN, pt.TASK_END, pt.TASK_PRIORITY, ts.STATUS_NAME AS 'TASK_STATUS', pt.TASK_READY, pt.TASK_HOURS from[PROJECT_TASKS] pt JOIN[PROJECTS] p ON pt.PROJECT_ID = p.PROJECT_ID JOIN EXPERTS e ON pt.EXPRET_ID = e.EXPRET_ID Join TASK_STATUS ts on pt.TASK_STATUS = ts.STATUS_ID Where TASK_ID = '" + taskCode + "' ", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                taskNamet.Text = dr["TASK_NAME"].ToString();
                taskDescrt.Text = dr["TASK_DESCRIPTION"].ToString();
                taskStatuscb.Text = dr["TASK_STATUS"].ToString();
                taskPrioritycb.Text = dr["TASK_PRIORITY"].ToString();
                maskedTextBox1.Text = dr["TAS_DELIVERABLES"].ToString();
                taskProgresst.Text = dr["TASK_READY"].ToString();
                taskExpertcb.Text = dr["EXPERT_NAME"].ToString();
                taskHourst.Text = dr["TASK_HOURS"].ToString();
            }

            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(con);
            cn.Open();

            if (taskNamet.Text != string.Empty || taskDescrt.Text != string.Empty || taskStatuscb.Text != string.Empty || taskPrioritycb.Text != string.Empty || taskExpertcb.Text != string.Empty || taskHourst.Text != string.Empty || taskProgresst.Text != string.Empty)
            {
                cmd = new SqlCommand("select EXPRET_ID from [EXPERTS] where EXPERT_NAME='" + taskExpertcb.Text + "'", cn);
                int expertId = 0;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    expertId = Int32.Parse(dr["EXPRET_ID"].ToString());
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("This Expert does not exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dr.Close();
                }

                cmd = new SqlCommand("select STATUS_ID from [TASK_STATUS] where STATUS_NAME='" + taskStatuscb.Text + "'", cn);
                int taskStatusId = 0;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    taskStatusId = Int32.Parse(dr["STATUS_ID"].ToString());
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("This Status does not exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dr.Close();
                }

                cmd = new SqlCommand("select * from [PROJECT_TASKS] where TASK_ID = '" + taskCode + "' ", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    cmd = new SqlCommand("Update [PROJECT_TASKS] Set EXPRET_ID =@expertId, TASK_NAME =@name, TASK_DESCRIPTION =@desc, TAS_DELIVERABLES=@deliv, TASK_STATUS =@statusId, TASK_PRIORITY =@priority, TASK_READY=@progress, TASK_HOURS=@hours  Where TASK_ID = '" + taskCode + "' ", cn);
                    cmd.Parameters.AddWithValue("expertId", expertId);
                    cmd.Parameters.AddWithValue("statusId", taskStatusId);
                    cmd.Parameters.AddWithValue("name", taskNamet.Text);
                    cmd.Parameters.AddWithValue("desc", taskDescrt.Text);
                    cmd.Parameters.AddWithValue("deliv", maskedTextBox1.Text);
                    cmd.Parameters.AddWithValue("priority", taskPrioritycb.Text);
                    cmd.Parameters.AddWithValue("progress", taskProgresst.Text);
                    cmd.Parameters.AddWithValue("hours", taskHourst.Text);
                    cmd.ExecuteNonQuery();
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cn.Close();
                MessageBox.Show("Successfully updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Task_List frm = new Task_List();
                frm.Update();
                this.Close();
            }
        }
    }
}
