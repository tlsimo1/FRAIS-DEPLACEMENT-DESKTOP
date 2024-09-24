using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frais_deplacement_test.Crystal_Report
{
    public partial class imp_FraisCirculation : Form
    {
        string Etat=string.Empty;
        public imp_FraisCirculation( string etat)
        {
            InitializeComponent();
            this.Etat = etat;
            get_Frais(Etat);
        }
        public imp_FraisCirculation()
        {
            
        }

        void get_Frais(string etat)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("Get_Frais_Circulation", connection);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@Etat", etat);
                    da.Fill(dt);
                    rpt_FraisCirculation cryFrais = new rpt_FraisCirculation();
                    cryFrais.Database.Tables["Get_Frais_Circulation"].SetDataSource(dt);
                    crv_report.ReportSource = cryFrais;
                    crv_report.Refresh(); 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex.Message);
            }
        }

       
    }
}
