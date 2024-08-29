using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_Pharmacy
{
    public partial class US_UpdateProfile : UserControl
    {
        string user = "";
        public US_UpdateProfile()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Fillfields();
        }

        public string ID
        {
            set { user = value; }
        }

        private void US_UpdateProfile_Load(object sender, EventArgs e)
        {
            cmbUserRole.Items.Add("Administrator");
            cmbUserRole.Items.Add("Pharmacist");
            lblUserName.Text = user;
            Fillfields();
        }

        private void Fillfields()
        {
            string Query = "select * from Users where UserName='" + user + "'";
            DataSet ds = US_AddUser.membre.GetData(Query);
            if (ds.Tables[0].Rows.Count == 1)
            {
                cmbUserRole.Text = ds.Tables[0].Rows[0][1].ToString();
                txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                dtpDateBirth.Value = DateTime.Parse(ds.Tables[0].Rows[0][3].ToString());
                txtNumber.Text = ds.Tables[0].Rows[0][4].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
                txtPassword.Text = ds.Tables[0].Rows[0][7].ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Query = "update Users set UserRole='"+cmbUserRole.Text+"' ,Name='" + txtName.Text + "' ,DateBirth='" + dtpDateBirth.Value + "',Mobile='" + txtNumber.Text + "',Email='" + txtEmail.Text + "',Pass='" + txtPassword.Text + "' where UserName='" + user + "' ";
            int i= US_AddUser.membre.SetData(Query);
            if (i == 1)
                MessageBox.Show("Profile Updated Successful");
        }
    }
}
