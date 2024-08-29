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
    public partial class US_Ph_AddMedicine : UserControl
    {
        public US_Ph_AddMedicine()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "" || txtName.Text == "" || txtNumber.Text == "" || txtPrice.Text == "" || txtQuantity.Text == "" || dtpManufacturing.Value == DateTime.Now || dtpExpire.Value == DateTime.Now)
            {
                MessageBox.Show("Please enter all fields", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string Query= "insert into Medicines (Code,Name,Number,Manufacturing,Expired,Quantity,PriceUnit) values('"+txtCode.Text+"','"+txtName.Text+"','"+txtNumber.Text+"','"+dtpManufacturing.Value+"','"+dtpExpire.Value+"'," + txtQuantity.Text + "," + txtPrice.Text + " )";
            int i= US_AddUser.membre.SetData(Query);
            if (i == 1)
                MessageBox.Show("Ajouter avec succes");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
                if (c is TextBox)
                    ((TextBox)c).Clear();
            dtpExpire.Value= DateTime.Now; ;
            dtpManufacturing.Value= DateTime.Now;

        }

        private void US_Ph_AddMedicine_Load(object sender, EventArgs e)
        {

        }
    }
}
