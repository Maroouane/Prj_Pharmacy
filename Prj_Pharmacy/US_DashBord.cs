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
    public partial class US_DashBord : UserControl
    {
        public US_DashBord()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.FillLabels();
        }

        private void FillLabels()
        {
            string Query1 = "select count (*) from Users where UserRole='Pharmacist'";
            int i1 = US_AddUser.membre.Sqalar(Query1);
            lblNbPharmacist.Text = i1.ToString();
            string Query2 = "select count (*) from Users where UserRole='Administrator'";
            int i2 = US_AddUser.membre.Sqalar(Query2);
            lblNbAdmin.Text = i2.ToString();
        }

        private void US_DashBord_Load(object sender, EventArgs e)
        {
            this.FillLabels();
        }
    }
}
