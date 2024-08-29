using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Prj_Pharmacy
{
    public partial class frm_SignIn : Form
    {
        public frm_SignIn()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUserName.Clear();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtUserName.Text == "")
            {
                MessageBox.Show("Please enter all fields", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frm_Administrator admin = new frm_Administrator(txtUserName.Text);
            frm_Pharmacist pharmacist = new frm_Pharmacist();
            string Query = "select * from Users where UserName='" + txtUserName.Text + "' and Pass='" + txtPassword.Text + "' ";
            DataSet ds = US_AddUser.membre.GetData(Query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                if (ds.Tables[0].Rows[0][1].ToString() == "Administrator")
                {
                    admin.Show();
                    this.Hide();
                    return;
                }
                if (ds.Tables[0].Rows[0][1].ToString() == "Pharmacist")
                {
                    pharmacist.Show();
                    this.Hide();
                    return;
                }
            }
            MessageBox.Show("The password or username is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //frm_Administrator frm = new frm_Administrator(txtUserName.Text);
            //frm.Show();
            //this.Hide();
        }

        private void frm_SignIn_Load(object sender, EventArgs e)
        {
        }
    }
}
