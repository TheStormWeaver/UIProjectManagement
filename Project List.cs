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
    public partial class Project_List : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        string con = ConfigurationManager.ConnectionStrings["ProjectManagement.Properties.Settings.ProjectManagementDBConnectionString"].ConnectionString;

        public Project_List()
        {
            InitializeComponent();
        }

        private void Project_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagementDBDataSet.EXPERTS' table. You can move, or remove it, as needed.
            this.eXPERTSTableAdapter.Fill(this.projectManagementDBDataSet.EXPERTS);
            // TODO: This line of code loads data into the 'projectManagementDBDataSet.PROJECTS' table. You can move, or remove it, as needed.
            this.pROJECTSTableAdapter.Fill(this.projectManagementDBDataSet.PROJECTS);

        }

        private void searchProjectbtn_Click(object sender, EventArgs e)
        {
            /*
            this.pROJECTSTableAdapter.FillByProjectIDSearch(this.projectManagementDBDataSet.PROJECTS, Convert.ToDecimal(projectIDSearcht.Text));
            this.pROJECTSTableAdapter.FillByProjectDateSearch(this.projectManagementDBDataSet.PROJECTS, projectStartDateSearcht.Text, projectEndDateSearcht.Text);
            this.pROJECTSTableAdapter.FillByPorjectClientSearch(this.projectManagementDBDataSet.PROJECTS, projectUserSearchcb.Text);
            this.pROJECTSTableAdapter.FillByProjectNameSearch(this.projectManagementDBDataSet.PROJECTS, projectNameSearcht.Text);
            this.pROJECTSTableAdapter.FillByProjectStatusSearch(this.projectManagementDBDataSet.PROJECTS, Convert.ToDecimal(projectStatusSearchcb.Text));
            */
        }

        private void projectListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && projectListGrid.Columns[e.ColumnIndex].Name.Equals("editProjectStatus"))
            {
                Edit_Project_Status frm = new Edit_Project_Status(true,
               Convert.ToInt32(projectListGrid.CurrentRow.Cells[0].Value));

            }

            //Details.
            if (projectListGrid.CurrentCell.ColumnIndex.Equals(11) && e.RowIndex != -1)
            {
                if (projectListGrid.CurrentCell != null && projectListGrid.CurrentCell.Value != null)
                {
                    string projectCode = projectListGrid.Rows[projectListGrid.CurrentRow.Index].Cells[0].FormattedValue.ToString();
                    deleteProject(projectCode);
                    projectListGrid.Refresh();
                    //projectListGrid.DataSource = ;
                }
            }
            if (projectListGrid.CurrentCell.ColumnIndex.Equals(10) && e.RowIndex != -1)
            {
                if (projectListGrid.CurrentCell != null && projectListGrid.CurrentCell.Value != null)
                {
                    string projectCode = projectListGrid.Rows[projectListGrid.CurrentRow.Index].Cells[0].FormattedValue.ToString();
                    ProjectEdit frm = new ProjectEdit(Int32.Parse(projectCode));
                    frm.ShowDialog();
                }
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pROJECTSTableAdapter.FillBy(this.projectManagementDBDataSet.PROJECTS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create_Project frm = new Create_Project();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Details_Project frm = new Details_Project();
            frm.ShowDialog();
        }

        public void deleteProject(string projectCode)
        {
            cn = new SqlConnection(con);
            cn.Open();

            cmd = new SqlCommand("select * from [PROJECTS] where PROJECT_ID='" + projectCode + "'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                cmd = new SqlCommand("DELETE FROM [PROJECT_TASKS]  WHERE PROJECT_ID = '" + projectCode + "'", cn);
                dr = cmd.ExecuteReader();
                dr.Close();
                cmd = new SqlCommand("DELETE FROM [PROJECTS]  WHERE PROJECT_ID = '" + projectCode + "'", cn);
                dr = cmd.ExecuteReader();

                MessageBox.Show("Deleted Project", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
