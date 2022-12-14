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
    public partial class Edit_Project_Status : Form
    {
        int ID = 0;
        bool edit = false;
        public Edit_Project_Status()
        {
            InitializeComponent();
        }
        public Edit_Project_Status(bool param_edit, int? param_ID)
        {
            InitializeComponent();
            edit = param_edit;
            if (param_ID.HasValue)
            {
                ID = param_ID.Value;
            }
        }
        private void ProjectEditStatus_Load(object sender, EventArgs e)
        {
            if (edit)
            {
                if (ID == 0)
                {
                    AskIDForm f = new AskIDForm();
                    f.ShowDialog();
                    ID = f.ReturnedID;
                    f.Close();
                    if (ID != 0)
                    {
                        this.Text = "Продажба " + ID.ToString();
                    }
                    else if (ID == 0)
                    {
                        this.BeginInvoke(new MethodInvoker(this.Close));
                    }
                }

                this.pROJECT_STATUSTableAdapter.FillByProjectStatusSearch(this.projectManagementDBDataSet.PROJECT_STATUS, ID);
            }
            else
            {
                //load empty form for creating a new sale
            }
        }


        private void pROJECT_STATUSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pROJECT_STATUSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectManagementDBDataSet);

        }

        private void Edit_Project_Status_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagementDBDataSet.PROJECT_STATUS' table. You can move, or remove it, as needed.
            this.pROJECT_STATUSTableAdapter.Fill(this.projectManagementDBDataSet.PROJECT_STATUS);

        }

        private void projectStatusSavebtn_Click(object sender, EventArgs e)
        {
            /*
            if (pSTATUS_IDTextBox.Text.Equals("") && !pSTATUS_NAMETextBox.Text.Equals(""))
            {
                pROJECT_STATUSTableAdapter.Insert(pSTATUS_NAMETextBox.Text);
            }
            this.Validate();
            this.pROJECT_STATUSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectManagementDBDataSet);
            */
        }

        private void projectStatusCancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
