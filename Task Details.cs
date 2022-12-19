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
    public partial class Task_Details : Form
    {
        public Task_Details()
        {
            InitializeComponent();
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

        }

        private void pROJECT_TASKSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pROJECT_TASKSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectManagementDBDataSet);

        }

    }
}
