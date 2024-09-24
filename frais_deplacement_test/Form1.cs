using CrystalDecisions.Windows.Forms;
using frais_deplacement_test.Crystal_Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frais_deplacement_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string etat = comboBox1.Text;
            imp_FraisCirculation nn = new imp_FraisCirculation(etat);
            nn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Etat_Avancement Av = new Etat_Avancement();
            Av.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string modeRegelemnt = cmb_modeReglement.Text;
            Imp_ModReg ModeReg = new Imp_ModReg(modeRegelemnt);
            ModeReg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            imp_fraisANT imp_ant = new imp_fraisANT();
            imp_ant.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            imp_Prov imp_prov = new imp_Prov(date);
            imp_prov.Show();
        }
    }
}
