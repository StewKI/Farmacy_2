namespace Farmacy.Forme
{
    partial class RadnoVremeCreateForm
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
            this.lblProdajnaJedinica = new System.Windows.Forms.Label();
            this.txtProdajnaJedinica = new System.Windows.Forms.TextBox();
            this.lblDan = new System.Windows.Forms.Label();
            this.cboDan = new System.Windows.Forms.ComboBox();
            this.lblVremeOd = new System.Windows.Forms.Label();
            this.dtpVremeOd = new System.Windows.Forms.DateTimePicker();
            this.lblVremeDo = new System.Windows.Forms.Label();
            this.dtpVremeDo = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.dgvRadnoVreme = new System.Windows.Forms.DataGridView();
            this.grpPodaci = new System.Windows.Forms.GroupBox();
            this.grpLista = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadnoVreme)).BeginInit();
            this.grpPodaci.SuspendLayout();
            this.grpLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProdajnaJedinica
            // 
            this.lblProdajnaJedinica.AutoSize = true;
            this.lblProdajnaJedinica.Location = new System.Drawing.Point(15, 25);
            this.lblProdajnaJedinica.Name = "lblProdajnaJedinica";
            this.lblProdajnaJedinica.Size = new System.Drawing.Size(95, 13);
            this.lblProdajnaJedinica.TabIndex = 0;
            this.lblProdajnaJedinica.Text = "Prodajna jedinica:";
            // 
            // txtProdajnaJedinica
            // 
            this.txtProdajnaJedinica.Location = new System.Drawing.Point(120, 22);
            this.txtProdajnaJedinica.Name = "txtProdajnaJedinica";
            this.txtProdajnaJedinica.ReadOnly = true;
            this.txtProdajnaJedinica.Size = new System.Drawing.Size(200, 20);
            this.txtProdajnaJedinica.TabIndex = 1;
            // 
            // lblDan
            // 
            this.lblDan.AutoSize = true;
            this.lblDan.Location = new System.Drawing.Point(15, 55);
            this.lblDan.Name = "lblDan";
            this.lblDan.Size = new System.Drawing.Size(28, 13);
            this.lblDan.TabIndex = 2;
            this.lblDan.Text = "Dan:";
            // 
            // cboDan
            // 
            this.cboDan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDan.FormattingEnabled = true;
            this.cboDan.Location = new System.Drawing.Point(120, 52);
            this.cboDan.Name = "cboDan";
            this.cboDan.Size = new System.Drawing.Size(200, 21);
            this.cboDan.TabIndex = 3;
            // 
            // lblVremeOd
            // 
            this.lblVremeOd.AutoSize = true;
            this.lblVremeOd.Location = new System.Drawing.Point(15, 85);
            this.lblVremeOd.Name = "lblVremeOd";
            this.lblVremeOd.Size = new System.Drawing.Size(58, 13);
            this.lblVremeOd.TabIndex = 4;
            this.lblVremeOd.Text = "Početak:";
            // 
            // dtpVremeOd
            // 
            this.dtpVremeOd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVremeOd.Location = new System.Drawing.Point(120, 82);
            this.dtpVremeOd.Name = "dtpVremeOd";
            this.dtpVremeOd.ShowUpDown = true;
            this.dtpVremeOd.Size = new System.Drawing.Size(100, 20);
            this.dtpVremeOd.TabIndex = 5;
            this.dtpVremeOd.Value = new System.DateTime(2024, 1, 1, 8, 0, 0, 0);
            // 
            // lblVremeDo
            // 
            this.lblVremeDo.AutoSize = true;
            this.lblVremeDo.Location = new System.Drawing.Point(15, 115);
            this.lblVremeDo.Name = "lblVremeDo";
            this.lblVremeDo.Size = new System.Drawing.Size(50, 13);
            this.lblVremeDo.TabIndex = 6;
            this.lblVremeDo.Text = "Kraj:";
            // 
            // dtpVremeDo
            // 
            this.dtpVremeDo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVremeDo.Location = new System.Drawing.Point(120, 112);
            this.dtpVremeDo.Name = "dtpVremeDo";
            this.dtpVremeDo.ShowUpDown = true;
            this.dtpVremeDo.Size = new System.Drawing.Size(100, 20);
            this.dtpVremeDo.TabIndex = 7;
            this.dtpVremeDo.Value = new System.DateTime(2024, 1, 1, 16, 0, 0, 0);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(15, 150);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(105, 150);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 9;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(195, 150);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 10;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // dgvRadnoVreme
            // 
            this.dgvRadnoVreme.AllowUserToAddRows = false;
            this.dgvRadnoVreme.AllowUserToDeleteRows = false;
            this.dgvRadnoVreme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRadnoVreme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRadnoVreme.Location = new System.Drawing.Point(3, 16);
            this.dgvRadnoVreme.Name = "dgvRadnoVreme";
            this.dgvRadnoVreme.ReadOnly = true;
            this.dgvRadnoVreme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRadnoVreme.Size = new System.Drawing.Size(394, 200);
            this.dgvRadnoVreme.TabIndex = 0;
            // 
            // grpPodaci
            // 
            this.grpPodaci.Controls.Add(this.lblProdajnaJedinica);
            this.grpPodaci.Controls.Add(this.txtProdajnaJedinica);
            this.grpPodaci.Controls.Add(this.lblDan);
            this.grpPodaci.Controls.Add(this.cboDan);
            this.grpPodaci.Controls.Add(this.lblVremeOd);
            this.grpPodaci.Controls.Add(this.dtpVremeOd);
            this.grpPodaci.Controls.Add(this.lblVremeDo);
            this.grpPodaci.Controls.Add(this.dtpVremeDo);
            this.grpPodaci.Controls.Add(this.btnDodaj);
            this.grpPodaci.Controls.Add(this.btnObrisi);
            this.grpPodaci.Controls.Add(this.btnZatvori);
            this.grpPodaci.Location = new System.Drawing.Point(12, 12);
            this.grpPodaci.Name = "grpPodaci";
            this.grpPodaci.Size = new System.Drawing.Size(400, 190);
            this.grpPodaci.TabIndex = 0;
            this.grpPodaci.TabStop = false;
            this.grpPodaci.Text = "Podaci o radnom vremenu";
            // 
            // grpLista
            // 
            this.grpLista.Controls.Add(this.dgvRadnoVreme);
            this.grpLista.Location = new System.Drawing.Point(12, 220);
            this.grpLista.Name = "grpLista";
            this.grpLista.Size = new System.Drawing.Size(400, 219);
            this.grpLista.TabIndex = 1;
            this.grpLista.TabStop = false;
            this.grpLista.Text = "Lista radnog vremena";
            // 
            // RadnoVremeCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 451);
            this.Controls.Add(this.grpLista);
            this.Controls.Add(this.grpPodaci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RadnoVremeCreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kreiranje radnog vremena";
            this.Load += new System.EventHandler(this.RadnoVremeCreateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadnoVreme)).EndInit();
            this.grpPodaci.ResumeLayout(false);
            this.grpPodaci.PerformLayout();
            this.grpLista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProdajnaJedinica;
        private System.Windows.Forms.TextBox txtProdajnaJedinica;
        private System.Windows.Forms.Label lblDan;
        private System.Windows.Forms.ComboBox cboDan;
        private System.Windows.Forms.Label lblVremeOd;
        private System.Windows.Forms.DateTimePicker dtpVremeOd;
        private System.Windows.Forms.Label lblVremeDo;
        private System.Windows.Forms.DateTimePicker dtpVremeDo;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.DataGridView dgvRadnoVreme;
        private System.Windows.Forms.GroupBox grpPodaci;
        private System.Windows.Forms.GroupBox grpLista;
    }
}
