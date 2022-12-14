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
    public partial class User_List : Form
    {
        public User_List()
        {
            InitializeComponent();
        }

        private void User_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagementDBDataSet.PROJECT_TASKS' table. You can move, or remove it, as needed.
            this.pROJECT_TASKSTableAdapter.Fill(this.projectManagementDBDataSet.PROJECT_TASKS);
            // TODO: This line of code loads data into the 'projectManagementDBDataSet.PROJECTS' table. You can move, or remove it, as needed.
            this.pROJECTSTableAdapter.Fill(this.projectManagementDBDataSet.PROJECTS);
            // TODO: This line of code loads data into the 'projectManagementDBDataSet.EXPERTS' table. You can move, or remove it, as needed.
            this.eXPERTSTableAdapter.Fill(this.projectManagementDBDataSet.EXPERTS);

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
            User_Details frm = new User_Details();
            frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            User frm = new User();
            frm.ShowDialog();
        }
    }
}
