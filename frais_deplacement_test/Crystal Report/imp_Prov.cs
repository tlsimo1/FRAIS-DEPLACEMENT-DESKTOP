using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frais_deplacement_test.Crystal_Report
{
    public partial class imp_Prov : Form
    {
        DateTime date1 ;
        DateTime date2;
        public imp_Prov(DateTime date1, DateTime date2)
        {
            InitializeComponent();
            this.date1 = date1;
            this.date2 = date2;
            Get_Prov(date1, date2);
        }
        void Get_Prov(DateTime date1, DateTime date2)
        {
            
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("Get_FraisProv", connection);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@DateSaisi1", date1.ToString("yyyy-MM-dd"));
                    da.SelectCommand.Parameters.AddWithValue("@DateSaisi2", date2.ToString("yyyy-MM-dd"));
                    da.Fill(dt);
                    rpt_EtatProv cryFrais_prov = new rpt_EtatProv();
                    cryFrais_prov.Database.Tables["Get_Prov"].SetDataSource(dt);
                    crv_Prov.ReportSource = cryFrais_prov;
                    crv_Prov.Refresh();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex.Message);
            }
        }
    }
}
