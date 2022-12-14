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
    public partial class Task_List : Form
    {
        public Task_List()
        {
            InitializeComponent();
        }

        private void Task_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagementDBDataSet.PROJECT_TASKS' table. You can move, or remove it, as needed.
            this.pROJECT_TASKSTableAdapter.Fill(this.projectManagementDBDataSet.PROJECT_TASKS);

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
    }
}
