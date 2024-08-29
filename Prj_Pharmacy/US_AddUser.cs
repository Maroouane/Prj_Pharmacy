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
    public partial class US_AddUser : UserControl
    {
        public static MembreGlobale membre = new MembreGlobale();
        public US_AddUser()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (cmbUserRole.Text == "" || txtNumber.Text == "" || txtName.Text == "" || txtPassword.Text == "" || txtUserName.Text == "" || dtpDateBirth.Value == DateTime.Now || txtEmail.Text == "")
            {
                MessageBox.Show("Please enter all fields", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string Query = "insert into Users(UserRole,Name,DateBirth,Mobile,Email,UserName,Pass) values('" + cmbUserRole.Text + "','" + txtName.Text + "','" + dtpDateBirth.Value + "','" + txtNumber.Text + "','"+txtEmail.Text+"','" + txtUserName.Text + "','" + txtPassword.Text + "')";
                int i = membre.SetData(Query);
                if (i == 1)
                    MessageBox.Show("Sign Up Succesful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("UserName Already existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void US_AddUser_Load(object sender, EventArgs e)
        {
            pbTrue.Visible = false;
            pbFalse.Visible = false;
            cmbUserRole.Items.Add("Administrator");
            cmbUserRole.Items.Add("Pharmacist");
        }
        private void Clear()
        {
            cmbUserRole.Text = "";
            cmbUserRole.SelectedIndex = -1;
            txtName.Clear();
            txtNumber.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            dtpDateBirth.Value = DateTime.Now;
            txtUserName.Clear();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            string Query = "select * from users where UserName='" + txtUserName.Text + "'";
            DataSet ds = membre.GetData(Query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                pbTrue.Location= new Point(672,299);
                pbFalse.Visible = false;
                pbTrue.Visible = true;
            }
            else
            {
                pbFalse.Location = new Point(672, 299);
                pbTrue.Visible = false;
                pbFalse.Visible = true;
            }
        }
    }
    
}
