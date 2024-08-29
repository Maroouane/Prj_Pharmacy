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
    public partial class US_Ph_DashBord : UserControl
    {
        public US_Ph_DashBord()
        {
            InitializeComponent();
        }

        private void US_Ph_DashBord_Load(object sender, EventArgs e)
        {
            FillChart();
        }
        private void FillChart()
        {
            string Query = "select count(*) from Medicines where Expired>=getdate()";
            int count = US_AddUser.membre.Sqalar(Query);
            this.chart.Series["Valid Medicines"].Points.AddXY("Medicine Validity", count);

            Query = "select count (*) from Medicines where Expired<=getdate() ";
            count = US_AddUser.membre.Sqalar(Query);
            this.chart.Series["Expired Medicines"].Points.AddXY("Medicine Validity ", count);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.chart.Series["Valid Medicines"].Points.Clear();
            this.chart.Series["Expired Medicines"].Points.Clear();
            FillChart();
        }
    }
}
