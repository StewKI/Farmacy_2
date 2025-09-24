namespace Farmacy.Forme
{
    partial class ProdajaDetaljiForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblProdajaId;
        private System.Windows.Forms.Label lblProdajnaJedinica;
        private System.Windows.Forms.Label lblDatumVreme;
        private System.Windows.Forms.Label lblBlagajnik;
        private System.Windows.Forms.Label lblUkupnaVrednost;
        private System.Windows.Forms.Panel panelStavke;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.Label lblStavke;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnZatvori;

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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelStavke = new System.Windows.Forms.Panel();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.lblStavke = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblUkupnaVrednost = new System.Windows.Forms.Label();
            this.lblBlagajnik = new System.Windows.Forms.Label();
            this.lblDatumVreme = new System.Windows.Forms.Label();
            this.lblProdajnaJedinica = new System.Windows.Forms.Label();
            this.lblProdajaId = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelStavke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📋 DETALJI PRODAJE";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.lblSubtitle.Location = new System.Drawing.Point(20, 45);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(150, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Pregled stavki prodaje";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.panelMain.Controls.Add(this.panelStavke);
            this.panelMain.Controls.Add(this.panelInfo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 80);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(1000, 520);
            this.panelMain.TabIndex = 1;
            // 
            // panelStavke
            // 
            this.panelStavke.Controls.Add(this.dgvStavke);
            this.panelStavke.Controls.Add(this.lblStavke);
            this.panelStavke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStavke.Location = new System.Drawing.Point(20, 120);
            this.panelStavke.Name = "panelStavke";
            this.panelStavke.Size = new System.Drawing.Size(960, 380);
            this.panelStavke.TabIndex = 1;
            // 
            // dgvStavke
            // 
            this.dgvStavke.AllowUserToAddRows = false;
            this.dgvStavke.AllowUserToDeleteRows = false;
            this.dgvStavke.AutoGenerateColumns = true;
            this.dgvStavke.BackgroundColor = System.Drawing.Color.White;
            this.dgvStavke.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStavke.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStavke.ColumnHeadersHeight = 50;
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStavke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStavke.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.dgvStavke.Location = new System.Drawing.Point(0, 30);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.ReadOnly = true;
            this.dgvStavke.RowHeadersVisible = false;
            this.dgvStavke.RowTemplate.Height = 35;
            this.dgvStavke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavke.Size = new System.Drawing.Size(960, 350);
            this.dgvStavke.TabIndex = 1;
            // 
            // lblStavke
            // 
            this.lblStavke.AutoSize = true;
            this.lblStavke.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStavke.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStavke.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblStavke.Location = new System.Drawing.Point(0, 0);
            this.lblStavke.Name = "lblStavke";
            this.lblStavke.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblStavke.Size = new System.Drawing.Size(120, 30);
            this.lblStavke.TabIndex = 0;
            this.lblStavke.Text = "Stavke prodaje:";
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.lblUkupnaVrednost);
            this.panelInfo.Controls.Add(this.lblBlagajnik);
            this.panelInfo.Controls.Add(this.lblDatumVreme);
            this.panelInfo.Controls.Add(this.lblProdajnaJedinica);
            this.panelInfo.Controls.Add(this.lblProdajaId);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(20, 20);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(960, 100);
            this.panelInfo.TabIndex = 0;
            // 
            // lblProdajaId
            // 
            this.lblProdajaId.AutoSize = true;
            this.lblProdajaId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProdajaId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblProdajaId.Location = new System.Drawing.Point(20, 10);
            this.lblProdajaId.Name = "lblProdajaId";
            this.lblProdajaId.Size = new System.Drawing.Size(50, 19);
            this.lblProdajaId.TabIndex = 0;
            this.lblProdajaId.Text = "ID: N/A";
            // 
            // lblProdajnaJedinica
            // 
            this.lblProdajnaJedinica.AutoSize = true;
            this.lblProdajnaJedinica.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProdajnaJedinica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblProdajnaJedinica.Location = new System.Drawing.Point(20, 35);
            this.lblProdajnaJedinica.Name = "lblProdajnaJedinica";
            this.lblProdajnaJedinica.Size = new System.Drawing.Size(150, 19);
            this.lblProdajnaJedinica.TabIndex = 1;
            this.lblProdajnaJedinica.Text = "Prodajna jedinica: N/A";
            // 
            // lblDatumVreme
            // 
            this.lblDatumVreme.AutoSize = true;
            this.lblDatumVreme.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDatumVreme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDatumVreme.Location = new System.Drawing.Point(20, 60);
            this.lblDatumVreme.Name = "lblDatumVreme";
            this.lblDatumVreme.Size = new System.Drawing.Size(120, 19);
            this.lblDatumVreme.TabIndex = 2;
            this.lblDatumVreme.Text = "Datum i vreme: N/A";
            // 
            // lblBlagajnik
            // 
            this.lblBlagajnik.AutoSize = true;
            this.lblBlagajnik.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBlagajnik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblBlagajnik.Location = new System.Drawing.Point(500, 10);
            this.lblBlagajnik.Name = "lblBlagajnik";
            this.lblBlagajnik.Size = new System.Drawing.Size(80, 19);
            this.lblBlagajnik.TabIndex = 3;
            this.lblBlagajnik.Text = "Blagajnik: N/A";
            // 
            // lblUkupnaVrednost
            // 
            this.lblUkupnaVrednost.AutoSize = true;
            this.lblUkupnaVrednost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUkupnaVrednost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblUkupnaVrednost.Location = new System.Drawing.Point(500, 35);
            this.lblUkupnaVrednost.Name = "lblUkupnaVrednost";
            this.lblUkupnaVrednost.Size = new System.Drawing.Size(150, 21);
            this.lblUkupnaVrednost.TabIndex = 4;
            this.lblUkupnaVrednost.Text = "Ukupna vrednost: N/A";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelFooter.Controls.Add(this.btnZatvori);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 580);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(20);
            this.panelFooter.Size = new System.Drawing.Size(1000, 80);
            this.panelFooter.TabIndex = 2;
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnZatvori.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnZatvori.FlatAppearance.BorderSize = 0;
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvori.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnZatvori.ForeColor = System.Drawing.Color.White;
            this.btnZatvori.Location = new System.Drawing.Point(860, 20);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(120, 40);
            this.btnZatvori.TabIndex = 0;
            this.btnZatvori.Text = "❌ Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // ProdajaDetaljiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProdajaDetaljiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalji prodaje - Farmacy System";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelStavke.ResumeLayout(false);
            this.panelStavke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
