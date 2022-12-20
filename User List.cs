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
    public partial class User_List : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        string con = ConfigurationManager.ConnectionStrings["ProjectManagement.Properties.Settings.ProjectManagementDBConnectionString"].ConnectionString;

        public User_List()
        {
            InitializeComponent();
        }

        private void User_List_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(con);
            cn.Open();
            // TODO: This line of code loads data into the 'projectManagementDBDataSet.PROJECT_TASKS' table. You can move, or remove it, as needed.
            this.pROJECT_TASKSTableAdapter.Fill(this.projectManagementDBDataSet.PROJECT_TASKS);
            // TODO: This line of code loads data into the 'projectManagementDBDataSet.PROJECTS' table. You can move, or remove it, as needed.
            this.pROJECTSTableAdapter.Fill(this.projectManagementDBDataSet.PROJECTS);
            // TODO: This line of code loads data into the 'projectManagementDBDataSet.EXPERTS' table. You can move, or remove it, as needed.
            this.eXPERTSTableAdapter.Fill(this.projectManagementDBDataSet.EXPERTS);
            cmd = new SqlCommand("select * from [EXPERTS]", cn);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cn.Close();
            userListGrid.DataSource = dt;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User frm = new User();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int u = 0;
            User_Details frm = new User_Details(u);
            frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            User frm = new User();
            frm.ShowDialog();
        }

        private void userListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Delete.
            if (userListGrid.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
            {
                if (userListGrid.CurrentCell != null && userListGrid.CurrentCell.Value != null)
                {
                    string projectCode = userListGrid.Rows[userListGrid.CurrentRow.Index].Cells[0].FormattedValue.ToString();
                    deleteUser(projectCode);
                    userListGrid.Refresh();
                    //projectListGrid.DataSource = ;
                }
            }
            //Edit
            if (userListGrid.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                if (userListGrid.CurrentCell != null && userListGrid.CurrentCell.Value != null)
                {
                    string projectCode = userListGrid.Rows[userListGrid.CurrentRow.Index].Cells[0].FormattedValue.ToString();
                    EditUser frm = new EditUser(Int32.Parse(projectCode));
                    frm.ShowDialog();
                }
            }
            //Details
            if (userListGrid.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                if (userListGrid.CurrentCell != null && userListGrid.CurrentCell.Value != null)
                {
                    string projectCode = userListGrid.Rows[userListGrid.CurrentRow.Index].Cells[0].FormattedValue.ToString();
                    User_Details frm = new User_Details(Int32.Parse(projectCode));
                    frm.ShowDialog();
                }
            }
        }

        public void deleteUser(string expertCode)
        {
            cn = new SqlConnection(con);
            cn.Open();

            cmd = new SqlCommand("select * from [EXPERTS] where EXPRET_ID='" + expertCode + "'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                cmd = new SqlCommand("DELETE FROM [EXPERTS]  WHERE EXPRET_ID = '" + expertCode + "'", cn);
                dr = cmd.ExecuteReader();
                dr.Close();
            //    cmd = new SqlCommand("DELETE FROM [PROJECTS]  WHERE PROJECT_ID = '" + projectCode + "'", cn);
            //    dr = cmd.ExecuteReader();
            //    dr.Close();
                MessageBox.Show("Expert Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmd = new SqlCommand("select * from [EXPERTS]", cn);
                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                userListGrid.DataSource = dt;
                userListGrid.Update();
            }
            else
            {
                dr.Close();
                MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr.Close();
            cn.Close();
        }
    }
}
