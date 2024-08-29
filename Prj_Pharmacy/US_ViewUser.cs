using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prj_Pharmacy
{
    public partial class US_ViewUser : UserControl
    {
        DataSet ds;
        string Query;
        int pos;
        string user = "";

        public US_ViewUser()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { user = value; }
        }

        private void US_ViewUser_Load(object sender, EventArgs e)
        {
            dgvAllUser.AllowUserToAddRows = false;
            Query = "select * from Users";
            ds=US_AddUser.membre.GetData(Query);
            this.FillDataGridView();
        }

        private void FillDataGridView()
        {
            dgvAllUser.DataSource = ds.Tables[0];
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            Query = "select * from USers where UserName like '" + txtUserName.Text + "%'";
            ds = US_AddUser.membre.GetData(Query);
            this.FillDataGridView();
        }

        private void dgvAllUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = dgvAllUser.CurrentRow.Index;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string UserName = "";
            try
            {
                UserName = dgvAllUser.Rows[pos].Cells[6].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Select a Medicine");
                return;
            }
            if (user == UserName)
            {
                MessageBox.Show("You are trying to delete your own profile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Query = "delete from Users where UserName='" + UserName + "'";
                DialogResult Resultat = MessageBox.Show("Are you sure", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Resultat == DialogResult.Yes)
                {
                    int i = US_AddUser.membre.SetData(Query);
                    if (i == 0)
                        MessageBox.Show("User does not exist");
                    else
                        MessageBox.Show("User Deleted");
                }
                US_ViewUser_Load(this, null);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            US_ViewUser_Load(this, null);
        }

    }
}
