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
    public partial class Details_Project : Form
    {
        public Details_Project()
        {
            InitializeComponent();
        }

        private void Details_Project_Load(object sender, EventArgs e)
        {
            /*
            // TODO: This line of code loads data into the 'projectManagementDBDataSet.PROJECT_TASKS' table. You can move, or remove it, as needed.
            this.pROJECT_TASKSTableAdapter.Fill(this.projectManagementDBDataSet.PROJECT_TASKS);
            // TODO: This line of code loads data into the 'projectManagementDBDataSet.EXPERTS' table. You can move, or remove it, as needed.
            this.eXPERTSTableAdapter.Fill(this.projectManagementDBDataSet.EXPERTS);
            // TODO: This line of code loads data into the 'projectManagementDBDataSet.PROJECTS' table. You can move, or remove it, as needed.
            this.pROJECTSTableAdapter.Fill(this.projectManagementDBDataSet.PROJECTS);
            */

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
