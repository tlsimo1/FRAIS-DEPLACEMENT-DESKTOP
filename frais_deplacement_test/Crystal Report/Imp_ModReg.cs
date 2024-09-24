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

namespace frais_deplacement_test
{
    public partial class Imp_ModReg : Form
    {
        public Imp_ModReg()
        {
            InitializeComponent();
        }
        string Mode=string.Empty;
        public Imp_ModReg(string Mod)
        {
            InitializeComponent();
            this.Mode = Mod;
            Get_Etat(Mode);
        }

        void Get_Etat(string mode)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("Get_EtatParMod", connection);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@Mode", mode);
                    da.Fill(dt);
                    rpt_ModReg rpt_Reglement = new rpt_ModReg();
                    rpt_Reglement.Database.Tables["Get_EtatParVirement"].SetDataSource(dt);
                    crv_modReg.ReportSource = rpt_Reglement;
                    crv_modReg.Refresh();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex.Message);
            }
        }
    }
}
