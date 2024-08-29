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
    public partial class US_Ph_ViewMedicines : UserControl
    {
        int pos = 0;
        string Query;
        public US_Ph_ViewMedicines()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name="";
            int i = -1;
            try
            {
                 name = dgvMedicines.Rows[pos].Cells[2].Value.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Select a Medicine");
                return;
            }
            Query = "delete from MEdicines where Name='" + name + "'";
            DialogResult Resultat = MessageBox.Show("Are you sure", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultat == DialogResult.Yes)
            {
                i = US_AddUser.membre.SetData(Query);
                if (i == 0)
                    MessageBox.Show("Medicine does not exist");
                else
                    MessageBox.Show("Medicine Deleted");
            }
            FillDataGridview();
        }

        private void dgvMedicines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = dgvMedicines.CurrentRow.Index;
        }

        private void US_Ph_ViewMedicines_Load(object sender, EventArgs e)
        {
            FillDataGridview();
            dgvMedicines.AllowUserToAddRows = false;
        }

        private void FillDataGridview()
        {
            Query = "select * from Medicines";
            DataSet ds = US_AddUser.membre.GetData(Query);
            dgvMedicines.DataSource = ds.Tables[0];
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Query = "select * from Medicines where Name like '" + txtName.Text + "%'";
            DataSet ds = US_AddUser.membre.GetData(Query);
            dgvMedicines.DataSource = ds.Tables[0];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillDataGridview();
        }
    }
}
