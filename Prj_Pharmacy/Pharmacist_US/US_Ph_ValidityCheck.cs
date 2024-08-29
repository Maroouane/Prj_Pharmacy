using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_Pharmacy.Pharmacist_US
{
    public partial class US_Ph_ValidityCheck : UserControl
    {
        public static int pos = 0;
        public US_Ph_ValidityCheck()
        {
            InitializeComponent();
        }

        private void US_Ph_ValidityCheck_Load(object sender, EventArgs e)
        {
            cmbCheck.Items.Add("Valid Medicines");
            cmbCheck.Items.Add("Exipired Medicines");
            cmbCheck.Items.Add("View All Medicines");
            lblMedicinesState.Visible = false;
        }

        private void cmbCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMedicinesState.Visible = true;
            string Query = "select * from  Medicines where 1=1";
            string Text = cmbCheck.Text;
            if (Text == "View All Medicines")
            {
                this.SetDatagridView("Valid Medicines", Query);
            }
            if (Text == "Valid Medicines")
            {
                Query += "and Expired>=getdate()";
                this.SetDatagridView("Valid Medicines", Query);
            }
            if (Text == "Exipired Medicines")
            {
                Query += "and Expired<=getdate()";
                this.SetDatagridView("Expired Medicines", Query);
            }
        }

        private void SetDatagridView(string State,string Query)
        {
            lblMedicinesState.Text = State;
            DataSet ds = US_AddUser.membre.GetData(Query);
            dgvMedicines.DataSource = ds.Tables[0];
        }

        private void btnPrintMedicines_Click(object sender, EventArgs e)
        {
            pos = cmbCheck.SelectedIndex;
            frm_PrintMedicine frm = new frm_PrintMedicine();
            frm.Show();
        }
    }
}
