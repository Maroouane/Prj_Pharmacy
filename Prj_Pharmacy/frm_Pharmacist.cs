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
    public partial class frm_Pharmacist : Form
    {
        public frm_Pharmacist()
        {
            InitializeComponent();
        }

        private void btnLougOut_Click(object sender, EventArgs e)
        {
            frm_SignIn SignIn = new frm_SignIn();
            SignIn.Show();
            this.Hide();
        }

        private void btnDashBord_Click(object sender, EventArgs e)
        {
            uS_Ph_DashBord1.Visible = true;
            uS_Ph_DashBord1.BringToFront();
        }

        private void frm_Pharmacist_Load(object sender, EventArgs e)
        {
            uS_Ph_DashBord1.Visible = true;
            uS_Ph_AddMedicine1.Visible = false;
            uS_Ph_ViewMedicines1.Visible = false;
            uS_Ph_ModifyMedicine1.Visible = false;
            uS_Ph_ValidityCheck1.Visible = false;
            uS_Ph_SellMedicine1.Visible = false;
        }

        private void btnAddMed_Click(object sender, EventArgs e)
        {
            uS_Ph_AddMedicine1.Visible = true;
            uS_Ph_AddMedicine1.BringToFront();
        }

        private void btnViewMed_Click(object sender, EventArgs e)
        {
            uS_Ph_ViewMedicines1.Visible = true;
            uS_Ph_ViewMedicines1.BringToFront();
        }

        private void btnModifyMed_Click(object sender, EventArgs e)
        {
            uS_Ph_ModifyMedicine1.Visible = true;
            uS_Ph_ModifyMedicine1.BringToFront();
        }

        private void btnValidityMed_Click(object sender, EventArgs e)
        {
            uS_Ph_ValidityCheck1.Visible = true;
            uS_Ph_ValidityCheck1.BringToFront();
        }

        private void btnSellMed_Click(object sender, EventArgs e)
        {
            uS_Ph_SellMedicine1.Visible = true;
            uS_Ph_SellMedicine1.BringToFront();
        }

        private void btnPrintMedicine_Click(object sender, EventArgs e)
        {
            //frm_PrintMedicines Print = new frm_PrintMedicines();
            //Print.Show();
        }
    }
}
