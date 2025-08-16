namespace Farmacy_2.Forme
{
    partial class ApotekaSaLabEditForm
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblUlica = new System.Windows.Forms.Label();
            this.txtUlica = new System.Windows.Forms.TextBox();
            this.lblBroj = new System.Windows.Forms.Label();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.lblPostanskiBroj = new System.Windows.Forms.Label();
            this.txtPostanskiBroj = new System.Windows.Forms.TextBox();
            this.lblMesto = new System.Windows.Forms.Label();
            this.txtMesto = new System.Windows.Forms.TextBox();
            this.lblOdgovorniFarmaceut = new System.Windows.Forms.Label();
            this.txtOdgovorniFarmaceut = new System.Windows.Forms.TextBox();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.TextBox();
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
            
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 44);
            this.lblNaziv.Text = "Naziv:";
            
            this.txtNaziv.Location = new System.Drawing.Point(120, 41);
            this.txtNaziv.Size = new System.Drawing.Size(200, 23);
            
            this.lblUlica.AutoSize = true;
            this.lblUlica.Location = new System.Drawing.Point(12, 73);
            this.lblUlica.Text = "Ulica:";
            
            this.txtUlica.Location = new System.Drawing.Point(120, 70);
            this.txtUlica.Size = new System.Drawing.Size(200, 23);
            
            this.lblBroj.AutoSize = true;
            this.lblBroj.Location = new System.Drawing.Point(12, 102);
            this.lblBroj.Text = "Broj:";
            
            this.txtBroj.Location = new System.Drawing.Point(120, 99);
            this.txtBroj.Size = new System.Drawing.Size(200, 23);
            
            this.lblPostanskiBroj.AutoSize = true;
            this.lblPostanskiBroj.Location = new System.Drawing.Point(12, 131);
            this.lblPostanskiBroj.Text = "Poštanski broj:";
            
            this.txtPostanskiBroj.Location = new System.Drawing.Point(120, 128);
            this.txtPostanskiBroj.Size = new System.Drawing.Size(200, 23);
            
            this.lblMesto.AutoSize = true;
            this.lblMesto.Location = new System.Drawing.Point(12, 160);
            this.lblMesto.Text = "Mesto:";
            
            this.txtMesto.Location = new System.Drawing.Point(120, 157);
            this.txtMesto.Size = new System.Drawing.Size(200, 23);
            
            this.lblOdgovorniFarmaceut.AutoSize = true;
            this.lblOdgovorniFarmaceut.Location = new System.Drawing.Point(12, 189);
            this.lblOdgovorniFarmaceut.Text = "Odgovorni farmaceut:";
            
            this.txtOdgovorniFarmaceut.Location = new System.Drawing.Point(140, 186);
            this.txtOdgovorniFarmaceut.ReadOnly = true;
            this.txtOdgovorniFarmaceut.Size = new System.Drawing.Size(180, 23);
            
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(12, 218);
            this.lblNapomena.Text = "Napomena:";
            
            this.txtNapomena.Location = new System.Drawing.Point(120, 215);
            this.txtNapomena.Size = new System.Drawing.Size(200, 23);
            
            this.btnSave.Location = new System.Drawing.Point(120, 254);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            
            this.btnCancel.Location = new System.Drawing.Point(245, 254);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Text = "Otkaži";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            
            // Form setup
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 295);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izmena apoteke sa laboratorijom";
            
            // Add controls
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblId, this.txtId, this.lblNaziv, this.txtNaziv, this.lblUlica, this.txtUlica, this.lblBroj, this.txtBroj,
                this.lblPostanskiBroj, this.txtPostanskiBroj, this.lblMesto, this.txtMesto, this.lblOdgovorniFarmaceut, this.txtOdgovorniFarmaceut,
                this.lblNapomena, this.txtNapomena, this.btnSave, this.btnCancel
            });
            
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblUlica;
        private System.Windows.Forms.TextBox txtUlica;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.Label lblPostanskiBroj;
        private System.Windows.Forms.TextBox txtPostanskiBroj;
        private System.Windows.Forms.Label lblMesto;
        private System.Windows.Forms.TextBox txtMesto;
        private System.Windows.Forms.Label lblOdgovorniFarmaceut;
        private System.Windows.Forms.TextBox txtOdgovorniFarmaceut;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
