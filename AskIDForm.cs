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
    public partial class AskIDForm : Form
    {
        public AskIDForm()
        {
            InitializeComponent();
            returnedID = 0;
        }
        private int returnedID;
        public int ReturnedID
        {
            get { return returnedID; }
        }

        private void askIDOkbtn_Click(object sender, EventArgs e)
        {
            returnedID = Convert.ToInt16(askIDt.Text);
            this.Close();
        }

        private void askIDCancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
