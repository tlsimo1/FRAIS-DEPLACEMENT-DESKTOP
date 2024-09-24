namespace frais_deplacement_test.Crystal_Report
{
    partial class imp_Etat_ANT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crv_FraisANT = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_FraisANT
            // 
            this.crv_FraisANT.ActiveViewIndex = -1;
            this.crv_FraisANT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_FraisANT.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_FraisANT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_FraisANT.Location = new System.Drawing.Point(0, 0);
            this.crv_FraisANT.Name = "crv_FraisANT";
            this.crv_FraisANT.Size = new System.Drawing.Size(800, 450);
            this.crv_FraisANT.TabIndex = 0;
            // 
            // imp_Etat_ANT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crv_FraisANT);
            this.Name = "imp_Etat_ANT";
            this.Text = "imp_Etat_ANT";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_FraisANT;
    }
}