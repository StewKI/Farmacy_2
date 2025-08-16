namespace Farmacy_2.Forme
{
    partial class IsporukaEditForm
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
            this.lblDistributer = new System.Windows.Forms.Label();
            this.txtDistributer = new System.Windows.Forms.TextBox();
            this.lblProdajnaJedinica = new System.Windows.Forms.Label();
            this.txtProdajnaJedinica = new System.Windows.Forms.TextBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lblMagacioner = new System.Windows.Forms.Label();
            this.txtMagacioner = new System.Windows.Forms.TextBox();
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
            
            this.lblDistributer.AutoSize = true;
            this.lblDistributer.Location = new System.Drawing.Point(12, 44);
            this.lblDistributer.Text = "Distributer:";
            
            this.txtDistributer.Location = new System.Drawing.Point(120, 41);
            this.txtDistributer.ReadOnly = true;
            this.txtDistributer.Size = new System.Drawing.Size(200, 23);
            
            this.lblProdajnaJedinica.AutoSize = true;
            this.lblProdajnaJedinica.Location = new System.Drawing.Point(12, 73);
            this.lblProdajnaJedinica.Text = "Prodajna jedinica:";
            
            this.txtProdajnaJedinica.Location = new System.Drawing.Point(130, 70);
            this.txtProdajnaJedinica.ReadOnly = true;
            this.txtProdajnaJedinica.Size = new System.Drawing.Size(190, 23);
            
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(12, 102);
            this.lblDatum.Text = "Datum:";
            
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(120, 99);
            this.dtpDatum.Size = new System.Drawing.Size(120, 23);
            
            this.lblMagacioner.AutoSize = true;
            this.lblMagacioner.Location = new System.Drawing.Point(12, 131);
            this.lblMagacioner.Text = "Magacioner:";
            
            this.txtMagacioner.Location = new System.Drawing.Point(120, 128);
            this.txtMagacioner.ReadOnly = true;
            this.txtMagacioner.Size = new System.Drawing.Size(200, 23);
            
            this.btnSave.Location = new System.Drawing.Point(120, 165);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            
            this.btnCancel.Location = new System.Drawing.Point(245, 165);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Text = "Otkaži";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            
            // Form setup
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 206);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izmena isporuke";
            
            // Add controls
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblId, this.txtId, this.lblDistributer, this.txtDistributer, this.lblProdajnaJedinica, this.txtProdajnaJedinica,
                this.lblDatum, this.dtpDatum, this.lblMagacioner, this.txtMagacioner, this.btnSave, this.btnCancel
            });
            
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblDistributer;
        private System.Windows.Forms.TextBox txtDistributer;
        private System.Windows.Forms.Label lblProdajnaJedinica;
        private System.Windows.Forms.TextBox txtProdajnaJedinica;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lblMagacioner;
        private System.Windows.Forms.TextBox txtMagacioner;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
