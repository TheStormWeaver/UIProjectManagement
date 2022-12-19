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
    public partial class Details_Project : Form
    {

        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        string con = ConfigurationManager.ConnectionStrings["ProjectManagement.Properties.Settings.ProjectManagementDBConnectionString"].ConnectionString;

        public Details_Project()
        {
            InitializeComponent();
        }

        private void Details_Project_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(con);
            cn.Open();
            /*
            // TODO: This line of code loads data into the 'projectManagementDBDataSet.PROJECT_TASKS' table. You can move, or remove it, as needed.
            this.pROJECT_TASKSTableAdapter.Fill(this.projectManagementDBDataSet.PROJECT_TASKS);
            // TODO: This line of code loads data into the 'projectManagementDBDataSet.EXPERTS' table. You can move, or remove it, as needed.
            this.eXPERTSTableAdapter.Fill(this.projectManagementDBDataSet.EXPERTS);
            // TODO: This line of code loads data into the 'projectManagementDBDataSet.PROJECTS' table. You can move, or remove it, as needed.
            this.pROJECTSTableAdapter.Fill(this.projectManagementDBDataSet.PROJECTS);
            */
            cmd = new SqlCommand("select * from [Experts]", cn);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            
            eXPERTSDataGridView.DataSource = dt;

            cmd = new SqlCommand("select * from [PROJECT_TASKS]", cn);
            dr = cmd.ExecuteReader();
            DataTable dtProj = new DataTable();
            dtProj.Load(dr);
            pROJECT_TASKSDataGridView.DataSource = dtProj;
            dr.Close();

            cmd = new SqlCommand("", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox6.Text = dr["Name"].ToString();
                richTextBox2.Text = dr["Description"].ToString();
                textBox5.Text = dr["Client"].ToString();
                comboBox2.Text = dr[""].ToString();
                dateTimePicker3.Text = dr[""].ToString();
                dateTimePicker4.Text = dr[""].ToString();
                textBox2.Text = dr[""].ToString();
            }

            cn.Close();
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
