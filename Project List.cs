using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement
{
    public partial class Project_List : Form
    {
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
            this.pROJECTSTableAdapter.FillByProjectIDSearch(this.projectManagementDBDataSet.PROJECTS, Convert.ToDecimal(projectIDSearcht.Text));
            this.pROJECTSTableAdapter.FillByProjectDateSearch(this.projectManagementDBDataSet.PROJECTS, projectStartDateSearcht.Text, projectEndDateSearcht.Text);
            this.pROJECTSTableAdapter.FillByPorjectClientSearch(this.projectManagementDBDataSet.PROJECTS, projectUserSearchcb.Text);
            this.pROJECTSTableAdapter.FillByProjectNameSearch(this.projectManagementDBDataSet.PROJECTS, projectNameSearcht.Text);
            this.pROJECTSTableAdapter.FillByProjectStatusSearch(this.projectManagementDBDataSet.PROJECTS, Convert.ToDecimal(projectStatusSearchcb.Text));
        }

        private void projectListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && projectListGrid.Columns[e.ColumnIndex].Name.Equals("editProjectStatus"))
            {
                Edit_Project_Status frm = new Edit_Project_Status(true,
               Convert.ToInt32(projectListGrid.CurrentRow.Cells[0].Value));

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
    }
}
