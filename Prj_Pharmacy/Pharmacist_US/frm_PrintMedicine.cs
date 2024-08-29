using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_Pharmacy.Pharmacist_US
{
    public partial class frm_PrintMedicine : Form
    {
        public frm_PrintMedicine()
        {
            InitializeComponent();
        }

        private void frm_PrintMedicine_Load(object sender, EventArgs e)
        {
            CR cr = new CR();
            string Query = "select * from  Medicines where 1=1";
            int pos = US_Ph_ValidityCheck.pos;
            if(pos==0)
            {
                Query += "and Expired>=getdate()";
                DataSet ds = US_AddUser.membre.GetData(Query);
                cr.SetDataSource(ds.Tables[0]);
                crystalReportViewer.ReportSource = cr;
            }
            if(pos==1)
            {
                Query += "and Expired<=getdate()";
                DataSet ds = US_AddUser.membre.GetData(Query);
                cr.SetDataSource(ds.Tables[0]);
                crystalReportViewer.ReportSource = cr;
            }
            if(pos==2)
            {
                DataSet ds = US_AddUser.membre.GetData(Query);
                cr.SetDataSource(ds.Tables[0]);
                crystalReportViewer.ReportSource = cr;
            }
            
        }
    }
}
