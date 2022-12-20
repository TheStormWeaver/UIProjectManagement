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
    public partial class Create_Task : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        string con = ConfigurationManager.ConnectionStrings["ProjectManagement.Properties.Settings.ProjectManagementDBConnectionString"].ConnectionString;

        public Create_Task()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(con);
            cn.Open();

            if (taskNamet.Text != string.Empty || taskDescrt.Text != string.Empty || taskStatuscb.Text != string.Empty || taskPrioritycb.Text != string.Empty || taskCommentrt.Text != string.Empty || taskExpertcb.Text != string.Empty || taskHourst.Text != string.Empty || taskProgresst.Text != string.Empty || projectNames.Text != string.Empty)
            {
                cmd = new SqlCommand("select PROJECT_ID from [PROJECTS] where PROJECT_NAME='" + projectNames.Text + "'", cn);
                int projectId = 0;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    projectId = Int32.Parse(dr["PROJECT_ID"].ToString());
                    //MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("This Project does not exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dr.Close();
                }

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

                cmd = new SqlCommand("select TOP 1 TASK_ID from [PROJECT_TASKS] ORDER BY PROJECT_ID DESC", cn);
                int taskId = 0;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    taskId = Int32.Parse(dr["TASK_ID"].ToString()) + 2;
                    dr.Close();
                }
                
                cmd = new SqlCommand("insert into [PROJECT_TASKS] values(@taskId, @projectId, @expertId,@name,@desc,@comm,@startDate,@endDate,@priority,@taskStatustId,@progress, @hours)", cn);
                cmd.Parameters.AddWithValue("taskId", taskId);
                cmd.Parameters.AddWithValue("projectId", projectId);
                cmd.Parameters.AddWithValue("expertId", expertId);
                cmd.Parameters.AddWithValue("name", taskNamet.Text);
                cmd.Parameters.AddWithValue("desc", taskDescrt.Text); 
                cmd.Parameters.AddWithValue("comm", taskCommentrt.Text);
                cmd.Parameters.AddWithValue("priority", taskPrioritycb.Text);
               // cmd.Parameters.AddWithValue("result", taskResultcb.Text);
                cmd.Parameters.AddWithValue("startDate", Convert.ToDateTime(txtStartDate.Value.ToString("yyyy-MM-dd")));
                cmd.Parameters.AddWithValue("endDate", Convert.ToDateTime(txtEndDate.Value.ToString("yyyy-MM-dd")));
                cmd.Parameters.AddWithValue("taskStatustId", taskStatusId);
                cmd.Parameters.AddWithValue("hours", taskHourst.Text);
                cmd.Parameters.AddWithValue("progress", taskProgresst.Text);

                cmd.ExecuteNonQuery();
               
                MessageBox.Show("Your Task is created.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
                cn.Close();
            }
        }

        private void taskNamet_TextChanged(object sender, EventArgs e)
        {

        }

        private void taskDescrt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Create_Task_Load(object sender, EventArgs e)
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

            cmd = new SqlCommand("select c.PROJECT_NAME from [PROJECTS] c", cn);
            List<string> proNames = new List<string>();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                while (dr.Read())
                {
                    string name = null;
                    name = dr["PROJECT_NAME"].ToString();
                    proNames.Add(name);
                }
            }
            dr.Close();

            projectNames.DataSource = proNames;
            cn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
