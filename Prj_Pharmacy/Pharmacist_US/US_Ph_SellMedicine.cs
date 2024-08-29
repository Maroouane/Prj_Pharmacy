using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace Prj_Pharmacy.Pharmacist_US
{
    public partial class US_Ph_SellMedicine : UserControl
    {
        public US_Ph_SellMedicine()
        {
            InitializeComponent();
        }
        string Query;
        private void US_Ph_SellMedicine_Load(object sender, EventArgs e)
        {
            dgvMedicines.AllowUserToAddRows = false;
            Query = "select Name from Medicines where Expired >= getdate() and Quantity>'0'";
            this.FillListBox(Query);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            US_Ph_SellMedicine_Load(this, null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
             Query = "select Name from Medicines where Name like '" + txtSearch.Text + "%' and Quantity>'0' and Expired >= getdate()";
            this.FillListBox(Query);
        }
        private void FillListBox(string Query)
        {
            DataSet ds = US_AddUser.membre.GetData(Query);
            lstMedicines.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                lstMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
        }

        private void lstMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Name =lstMedicines.GetItemText(lstMedicines.SelectedItem);
            string Query = "select Code,Expired,PriceUnit from Medicines where Name='" + Name + "'";
            DataSet ds = US_AddUser.membre.GetData(Query);
            try {
                txtCode.Text = ds.Tables[0].Rows[0][0].ToString();
                txtName.Text = Name;
                dtpExpire.Value = DateTime.Parse(ds.Tables[0].Rows[0][1].ToString());
                txtPricePerUnit.Text = ds.Tables[0].Rows[0][2].ToString();
                txtNofUnits.Clear();
                txtTotalPrice.Clear();
            }
            catch(Exception)
            {
                MessageBox.Show("Select a Medicine", "alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNofUnits_TextChanged(object sender, EventArgs e)
        {
            if (txtNofUnits.Text != "")
            {
                if (txtPricePerUnit.Text == "")
                {
                    MessageBox.Show("Select a Medicine", "alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNofUnits.Clear();
                }
                else
                    txtTotalPrice.Text = (int.Parse(txtPricePerUnit.Text) * int.Parse(txtNofUnits.Text)).ToString();
            }
            else
                txtTotalPrice.Clear();
        }

        int n, Total = 0;
        int pos;
        string code;
        int Price, NofUnit;
        int Quantity,NewQuantity;

        private void dgvMedicines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = dgvMedicines.CurrentRow.Index;
            Price = int.Parse(dgvMedicines.Rows[pos].Cells[5].Value.ToString());
            code = dgvMedicines.Rows[pos].Cells[0].Value.ToString();
            NofUnit = int.Parse(dgvMedicines.Rows[pos].Cells[4].Value.ToString());
        }

       

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMedicines.Rows.RemoveAt(pos);
                Total = Total - Price;
                Query = "select Quantity from Medicines where Code='" + code + "'";
                DataSet ds = US_AddUser.membre.GetData(Query);
                Quantity = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                NewQuantity = Quantity + NofUnit;

                Query = "Update Medicines set Quantity='" + NewQuantity + "' where Code='" + code + "'";
                US_AddUser.membre.SetData(Query);

                lblResultat.Text = "Results: " + Total.ToString();
                MessageBox.Show("Medicine Removed from Cart", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Information);
                US_Ph_SellMedicine_Load(this, null);
            }
            catch(Exception)
            {
                MessageBox.Show("Select a Row from Table", "alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                Query = "select Quantity from Medicines where code='" + txtCode.Text + "' ";
                DataSet ds = US_AddUser.membre.GetData(Query);
                Quantity = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                if (txtNofUnits.Text != "")
                {
                    NewQuantity = Quantity - int.Parse(txtNofUnits.Text);
                    if (NewQuantity >= 0)
                    {
                        n = dgvMedicines.Rows.Add();
                        dgvMedicines.Rows[n].Cells[0].Value = txtCode.Text;
                        dgvMedicines.Rows[n].Cells[1].Value = txtName.Text;
                        dgvMedicines.Rows[n].Cells[2].Value = dtpExpire.Value;
                        dgvMedicines.Rows[n].Cells[3].Value = txtPricePerUnit.Text;
                        dgvMedicines.Rows[n].Cells[4].Value = txtNofUnits.Text;
                        dgvMedicines.Rows[n].Cells[5].Value = txtTotalPrice.Text;

                        Total += int.Parse(txtTotalPrice.Text);
                        lblResultat.Text = "Results: " + Total.ToString()+" DH";
                        Query = "update Medicines set Quantity='" + NewQuantity + "' where Code='" + txtCode.Text + "'";
                        US_AddUser.membre.SetData(Query);
                        MessageBox.Show("Medicine Added", "add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Medicines Quantity is out of Stock.\n only " + Quantity + " Left");
                }
                else
                    MessageBox.Show("Enter Number of units", "alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Clear();
                US_Ph_SellMedicine_Load(this, null);
            }
            catch (Exception)
            {
                MessageBox.Show("Select a Medicine", "alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }

        private void btnPurchse_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Medicine Bill";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.ToShortDateString());
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Price: " + Total + " DH";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvMedicines);
            Total = 0;
            lblResultat.Text= "Results: 0 DH ";
            dgvMedicines.DataSource = 0;
            
        }

        private void Clear()
        {
            txtCode.Clear();
            txtName.Clear();
            txtNofUnits.Clear();
            dtpExpire.Value = DateTime.Now;
            txtPricePerUnit.Clear();
            txtTotalPrice.Clear();
        }
    }
}
