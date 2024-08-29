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
    public partial class frm_Administrator : Form
    {

        string User = "";//pour stoker la valeur Username saisi dans la page Signin
        public frm_Administrator()
        {
            InitializeComponent();
        }
        //Constructeur d'inisialisation pour afficher le nom d'adminidtarateur avec qui en a entrer dans un label

        public frm_Administrator(string UserName)
        {
            InitializeComponent();
            lblUserName.Text = UserName;
            User = UserName;
            uS_ViewUser1.ID=User;//pour envoyer la valeur a la propriete dans la page uS_ViewUser1
            uS_UpdateProfile1.ID = User;
        }
        public string Id
        {
            
            get { return User.ToString(); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frm_SignIn Signin = new frm_SignIn();
            Signin.Show();
            this.Hide();
        }


        private void frm_Administrator_Load(object sender, EventArgs e)
        {
            uS_DashBord1.Visible = true;
            uS_AddUser1.Visible = false;
            uS_ViewUser1.Visible = false;
            uS_UpdateProfile1.Visible = false;
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            uS_DashBord1.Visible = true;
            uS_DashBord1.BringToFront();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            uS_AddUser1.Visible = true;
            uS_AddUser1.BringToFront();
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            uS_ViewUser1.Visible = true;
            uS_ViewUser1.BringToFront();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            uS_UpdateProfile1.Visible = true;
            uS_UpdateProfile1.BringToFront();
        }
    }
}
