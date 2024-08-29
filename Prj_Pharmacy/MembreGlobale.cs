using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Prj_Pharmacy
{
   public class MembreGlobale
    {
        private SqlConnection GetConnection()
        {
            SqlConnection cnx = new SqlConnection("Data Source=.;Initial Catalog=Pharmacy;Integrated Security=True");
            return cnx;
        }
        public DataSet GetData(string Query)
        {
            SqlConnection cnx = this.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter(Query, cnx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        private void TestConx()
        {
            SqlConnection cnx = this.GetConnection();
            if (cnx.State == ConnectionState.Open)
                cnx.Close();
        }
        public int SetData(string Query)
        {
            int i = -1;
            SqlConnection cnx = this.GetConnection();
            SqlCommand cmd = new SqlCommand();
            this.TestConx();
            cmd.Connection = cnx;
            cmd.CommandText = Query;
            cnx.Open();
            i= cmd.ExecuteNonQuery();    
            cnx.Close();
            return i;
        }

        public int Sqalar(string Query)
        {
            int i = -1;
            SqlConnection cnx = this.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = Query;
            cnx.Open();
            i=(int)cmd.ExecuteScalar();
            cnx.Close();
            return i;
        }
    }
}
