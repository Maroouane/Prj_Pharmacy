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
    public partial class frm_First : Form
    {
        public frm_First()
        {
            InitializeComponent();
        }
        int StartPoint = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            StartPoint +=1;
            Cp.Value = StartPoint;
            if(Cp.Value==100)
            {
                Cp.Value = 0;
                timer.Stop();
                frm_SignIn SignIn = new frm_SignIn();
                SignIn.Show();
                this.Hide();
            }
        }

        private void frm_First_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
