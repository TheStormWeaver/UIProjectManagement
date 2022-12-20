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
    public partial class User_Details : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        string con = ConfigurationManager.ConnectionStrings["ProjectManagement.Properties.Settings.ProjectManagementDBConnectionString"].ConnectionString;
        int userId;
        public User_Details(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            
        }

        private void eXPERTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eXPERTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectManagementDBDataSet);

        }

        private void User_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagementDBDataSet.PROJECTS' table. You can move, or remove it, as needed.
            this.pROJECTSTableAdapter.Fill(this.projectManagementDBDataSet.PROJECTS);
            // TODO: This line of code loads data into the 'projectManagementDBDataSet.EXPERTS' table. You can move, or remove it, as needed.
            this.eXPERTSTableAdapter.Fill(this.projectManagementDBDataSet.EXPERTS);
            cn = new SqlConnection(con);
            cn.Open();

            cmd = new SqlCommand("select * from [EXPERTS] where EXPRET_ID = "+ userId + " ", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                

                firstnamet.Text = dr["EXPERT_NAME"].ToString();
                surnamet.Text = dr["EXPERT_SURNAME"].ToString();
                lastnamet.Text = dr["EXPERT_LASTNAME"].ToString();
                typet.Text = dr["EXPERT_TYPE"].ToString();
                dr.Close();
            }
            else
            {

            }
        }
    }
}
