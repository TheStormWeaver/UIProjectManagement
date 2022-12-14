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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User frm = new User();
            frm.ShowDialog();
        }

        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_List frm = new User_List();
            frm.TopLevel = false;
            this.Controls.Add(frm);
            frm.SetBounds(10, 30, 850, 280);
            frm.Show();
        }

        private void viewTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task_List frm = new Task_List();
            frm.TopLevel = false;
            this.Controls.Add(frm);
            frm.SetBounds(10, 30, 1400, 420);
            frm.Show();
        }

        private void viewProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project_List frm = new Project_List();
            frm.TopLevel = false;
            this.Controls.Add(frm);
            frm.SetBounds(10, 30, 1520, 330);
            frm.Show();
        }

        private void createProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_Project frm = new Create_Project();
            frm.ShowDialog();
        }

        private void editTaskToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Create_Task frm2 = new Create_Task();
            frm2.ShowDialog();
        }

        private void tasksToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_List frm = new User_List();
            frm.TopLevel = false;
            this.Controls.Add(frm);
            frm.SetBounds(10, 30, 930, 320);
            frm.Show();
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project_List frm = new Project_List();
            frm.TopLevel = false;
            this.Controls.Add(frm);
            frm.SetBounds(10, 30, 1400, 390);
            frm.Show();
        }

        private void tasksToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Task_List frm = new Task_List();
            frm.TopLevel = false;
            this.Controls.Add(frm);
            frm.SetBounds(10, 30, 1520, 410);
            frm.Show();
        }
    }
}
