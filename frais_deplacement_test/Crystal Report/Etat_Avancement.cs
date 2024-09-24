using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frais_deplacement_test.Crystal_Report
{
    public partial class Etat_Avancement : Form
    {
        public Etat_Avancement()
        {
            InitializeComponent();
            get_Frais_Avancement();
        }

        void get_Frais_Avancement()
        {
            DataTable dt2 = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("Get_EtatDesAvances", connection);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dt2);
                    rpt_FraisAvancment cryFraisAvancement = new rpt_FraisAvancment();
                    cryFraisAvancement.Database.Tables["Get_Frais_Avancement"].SetDataSource(dt2);
                    crv_avancement.ReportSource = cryFraisAvancement;
                    crv_avancement.Refresh();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex.Message);
            }
        }
    }
}
