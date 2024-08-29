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
    public partial class US_Ph_ModifyMedicine : UserControl
    {
        public US_Ph_ModifyMedicine()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                MessageBox.Show("Enter the Code Medicine", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;              
            }
            string Query = "Select * from Medicines where Code='" + txtCode.Text + "' ";
            DataSet ds= US_AddUser.membre.GetData(Query);
            if (ds.Tables[0].Rows.Count == 0)
            { 
                MessageBox.Show("Medicine Not Found", "the research", MessageBoxButtons.OK,MessageBoxIcon.Information);
                btnReset_Click(this, null);
                }
            else
            {
                txtCode.Text = ds.Tables[0].Rows[0][1].ToString();
                txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtNumber.Text = ds.Tables[0].Rows[0][3].ToString();
                dtpManufacturing.Value =DateTime.Parse(ds.Tables[0].Rows[0][4].ToString());
                dtpExpire.Value = DateTime.Parse(ds.Tables[0].Rows[0][5].ToString());
                txtAvailableQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
                txtPrice.Text = ds.Tables[0].Rows[0][7].ToString();
                txtAddQuantity.Text = 0.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int i = -1;
            if(txtName.Text == "" || txtNumber.Text == "" || txtPrice.Text == "" || txtAddQuantity.Text=="" || txtAvailableQuantity.Text == "" || dtpExpire.Value == DateTime.Now || dtpManufacturing.Value == DateTime.Now)
            {
                MessageBox.Show("Please enter all fields", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int Quantity = (int.Parse(txtAvailableQuantity.Text) + int.Parse(txtAddQuantity.Text));
                string Query = "update Medicines set Name ='" + txtName.Text + "',Number='" + txtNumber.Text + "',Manufacturing='" + dtpManufacturing.Value + "',Expired='" + dtpExpire.Value + "',Quantity=" + Quantity + ",PriceUnit=" + txtPrice.Text + " where Code='" + txtCode.Text + "'";
                 i = US_AddUser.membre.SetData(Query);
            }
            catch(Exception)
            {
                MessageBox.Show("Enter a number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (i == 1)
                MessageBox.Show("Medicine Updated ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Medicine Not Found", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnReset_Click(this, null);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
            txtName.Text = "";
            txtNumber.Text = "";
            txtPrice.Text = "";
            txtAddQuantity.Text = 0.ToString();
            txtAvailableQuantity.Text = "";
            dtpExpire.Value = DateTime.Now;
            dtpManufacturing.Value = DateTime.Now;
        }
    }
}
