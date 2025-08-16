namespace Farmacy_2.Forme
{
    partial class DistributerEditForm
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
            this.lblKontakt = new System.Windows.Forms.Label();
            this.txtKontakt = new System.Windows.Forms.TextBox();
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
            
            this.lblKontakt.AutoSize = true;
            this.lblKontakt.Location = new System.Drawing.Point(12, 73);
            this.lblKontakt.Text = "Kontakt:";
            
            this.txtKontakt.Location = new System.Drawing.Point(120, 70);
            this.txtKontakt.Size = new System.Drawing.Size(200, 23);
            
            this.btnSave.Location = new System.Drawing.Point(120, 110);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            
            this.btnCancel.Location = new System.Drawing.Point(245, 110);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Text = "Otkaži";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            
            // Form setup
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 151);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izmena distributera";
            
            // Add controls
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblId, this.txtId, this.lblNaziv, this.txtNaziv, this.lblKontakt, this.txtKontakt,
                this.btnSave, this.btnCancel
            });
            
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblKontakt;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
