namespace Farmacy_2.Forme
{
    partial class LekEditForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblHemijskiNaziv = new System.Windows.Forms.Label();
            this.txtHemijskiNaziv = new System.Windows.Forms.TextBox();
            this.lblKomercijalniNaziv = new System.Windows.Forms.Label();
            this.txtKomercijalniNaziv = new System.Windows.Forms.TextBox();
            this.lblDejstvo = new System.Windows.Forms.Label();
            this.txtDejstvo = new System.Windows.Forms.TextBox();
            this.lblProizvodjac = new System.Windows.Forms.Label();
            this.txtProizvodjac = new System.Windows.Forms.TextBox();
            this.lblPrimarnaGrupa = new System.Windows.Forms.Label();
            this.txtPrimarnaGrupa = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // Controls setup
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 15);
            this.lblId.Text = "ID:";
            
            this.txtId.Location = new System.Drawing.Point(120, 12);
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(200, 23);
            
            this.lblHemijskiNaziv.AutoSize = true;
            this.lblHemijskiNaziv.Location = new System.Drawing.Point(12, 44);
            this.lblHemijskiNaziv.Text = "Hemijski naziv:";
            
            this.txtHemijskiNaziv.Location = new System.Drawing.Point(120, 41);
            this.txtHemijskiNaziv.Size = new System.Drawing.Size(200, 23);
            
            this.lblKomercijalniNaziv.AutoSize = true;
            this.lblKomercijalniNaziv.Location = new System.Drawing.Point(12, 73);
            this.lblKomercijalniNaziv.Text = "Komercijalni naziv:";
            
            this.txtKomercijalniNaziv.Location = new System.Drawing.Point(120, 70);
            this.txtKomercijalniNaziv.Size = new System.Drawing.Size(200, 23);
            
            this.lblDejstvo.AutoSize = true;
            this.lblDejstvo.Location = new System.Drawing.Point(12, 102);
            this.lblDejstvo.Text = "Dejstvo:";
            
            this.txtDejstvo.Location = new System.Drawing.Point(120, 99);
            this.txtDejstvo.Size = new System.Drawing.Size(200, 23);
            
            this.lblProizvodjac.AutoSize = true;
            this.lblProizvodjac.Location = new System.Drawing.Point(12, 131);
            this.lblProizvodjac.Text = "Proizvođač:";
            
            this.txtProizvodjac.Location = new System.Drawing.Point(120, 128);
            this.txtProizvodjac.ReadOnly = true;
            this.txtProizvodjac.Size = new System.Drawing.Size(200, 23);
            
            this.lblPrimarnaGrupa.AutoSize = true;
            this.lblPrimarnaGrupa.Location = new System.Drawing.Point(12, 160);
            this.lblPrimarnaGrupa.Text = "Primarna grupa:";
            
            this.txtPrimarnaGrupa.Location = new System.Drawing.Point(120, 157);
            this.txtPrimarnaGrupa.ReadOnly = true;
            this.txtPrimarnaGrupa.Size = new System.Drawing.Size(200, 23);
            
            this.btnSave.Location = new System.Drawing.Point(120, 195);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            
            this.btnCancel.Location = new System.Drawing.Point(245, 195);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Text = "Otkaži";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            
            // Form setup
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 236);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izmena leka";
            
            // Add controls
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblId, this.txtId, this.lblHemijskiNaziv, this.txtHemijskiNaziv, this.lblKomercijalniNaziv, this.txtKomercijalniNaziv,
                this.lblDejstvo, this.txtDejstvo, this.lblProizvodjac, this.txtProizvodjac, this.lblPrimarnaGrupa, this.txtPrimarnaGrupa,
                this.btnSave, this.btnCancel
            });
            
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblHemijskiNaziv;
        private System.Windows.Forms.TextBox txtHemijskiNaziv;
        private System.Windows.Forms.Label lblKomercijalniNaziv;
        private System.Windows.Forms.TextBox txtKomercijalniNaziv;
        private System.Windows.Forms.Label lblDejstvo;
        private System.Windows.Forms.TextBox txtDejstvo;
        private System.Windows.Forms.Label lblProizvodjac;
        private System.Windows.Forms.TextBox txtProizvodjac;
        private System.Windows.Forms.Label lblPrimarnaGrupa;
        private System.Windows.Forms.TextBox txtPrimarnaGrupa;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
