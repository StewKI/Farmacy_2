namespace Farmacy.Forme
{
    partial class LekAdminForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvLekovi;
        private System.Windows.Forms.Button btnDodajNoviLek;
        private System.Windows.Forms.Button btnIzmeniLek;
        private System.Windows.Forms.Button btnObrisiLek;
        private System.Windows.Forms.Button btnDistributeri;
        private System.Windows.Forms.Button btnSekundarneKategorije;
        private System.Windows.Forms.Button btnOblik;
        private System.Windows.Forms.Button btnPakovanje;
        private System.Windows.Forms.Button btnPrimarnaGrupa;
        private System.Windows.Forms.Button btnProizvodjac;
        private System.Windows.Forms.Button btnRecept;
        private System.Windows.Forms.Button btnSekundarnaGrupa;

        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHemijskiNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKomercijalniNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDejstvo;

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
            this.dgvLekovi = new System.Windows.Forms.DataGridView();
            this.btnDodajNoviLek = new System.Windows.Forms.Button();
            this.btnIzmeniLek = new System.Windows.Forms.Button();
            this.btnObrisiLek = new System.Windows.Forms.Button();
            this.btnDistributeri = new System.Windows.Forms.Button();
            this.btnSekundarneKategorije = new System.Windows.Forms.Button();
            this.btnOblik = new System.Windows.Forms.Button();
            this.btnPakovanje = new System.Windows.Forms.Button();
            this.btnPrimarnaGrupa = new System.Windows.Forms.Button();
            this.btnProizvodjac = new System.Windows.Forms.Button();
            this.btnRecept = new System.Windows.Forms.Button();
            this.btnSekundarnaGrupa = new System.Windows.Forms.Button();

            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHemijskiNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKomercijalniNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDejstvo = new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.dgvLekovi)).BeginInit();
            this.SuspendLayout();

            // dgvLekovi
            this.dgvLekovi.AllowUserToAddRows = false;
            this.dgvLekovi.AllowUserToDeleteRows = false;
            this.dgvLekovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLekovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colHemijskiNaziv,
            this.colKomercijalniNaziv,
            this.colDejstvo});
            this.dgvLekovi.Location = new System.Drawing.Point(12, 12);
            this.dgvLekovi.MultiSelect = false;
            this.dgvLekovi.Name = "dgvLekovi";
            this.dgvLekovi.ReadOnly = true;
            this.dgvLekovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLekovi.Size = new System.Drawing.Size(700, 300);
            this.dgvLekovi.TabIndex = 0;

            // DataGridView columns
            this.colId.HeaderText = "ID";
            this.colId.DataPropertyName = "Id";
            this.colId.Width = 60;

            this.colHemijskiNaziv.HeaderText = "Hemijski naziv";
            this.colHemijskiNaziv.DataPropertyName = "HemijskiNaziv";
            this.colHemijskiNaziv.Width = 180;

            this.colKomercijalniNaziv.HeaderText = "Komercijalni naziv";
            this.colKomercijalniNaziv.DataPropertyName = "KomercijalniNaziv";
            this.colKomercijalniNaziv.Width = 180;

            this.colDejstvo.HeaderText = "Dejstvo";
            this.colDejstvo.DataPropertyName = "Dejstvo";
            this.colDejstvo.Width = 200;

            // btnDodajNoviLek
            this.btnDodajNoviLek.Location = new System.Drawing.Point(730, 12);
            this.btnDodajNoviLek.Name = "btnDodajNoviLek";
            this.btnDodajNoviLek.Size = new System.Drawing.Size(150, 30);
            this.btnDodajNoviLek.Text = "Dodaj novi lek";
            this.btnDodajNoviLek.UseVisualStyleBackColor = true;
            this.btnDodajNoviLek.Click += new System.EventHandler(this.btnDodajNoviLek_Click);

            // btnIzmeniLek
            this.btnIzmeniLek.Location = new System.Drawing.Point(730, 48);
            this.btnIzmeniLek.Name = "btnIzmeniLek";
            this.btnIzmeniLek.Size = new System.Drawing.Size(150, 30);
            this.btnIzmeniLek.Text = "Izmeni lek";
            this.btnIzmeniLek.UseVisualStyleBackColor = true;
            this.btnIzmeniLek.Click += new System.EventHandler(this.btnIzmeniLek_Click);

            // btnObrisiLek
            this.btnObrisiLek.Location = new System.Drawing.Point(730, 84);
            this.btnObrisiLek.Name = "btnObrisiLek";
            this.btnObrisiLek.Size = new System.Drawing.Size(150, 30);
            this.btnObrisiLek.Text = "Obriši lek";
            this.btnObrisiLek.UseVisualStyleBackColor = true;
            this.btnObrisiLek.Click += new System.EventHandler(this.btnObrisiLek_Click);

            // btnDistributeri
            this.btnDistributeri.Location = new System.Drawing.Point(730, 120);
            this.btnDistributeri.Name = "btnDistributeri";
            this.btnDistributeri.Size = new System.Drawing.Size(150, 30);
            this.btnDistributeri.Text = "Distributeri";
            this.btnDistributeri.UseVisualStyleBackColor = true;
            this.btnDistributeri.Click += new System.EventHandler(this.btnDistributeri_Click);

            // btnSekundarneKategorije
            this.btnSekundarneKategorije.Location = new System.Drawing.Point(730, 156);
            this.btnSekundarneKategorije.Name = "btnSekundarneKategorije";
            this.btnSekundarneKategorije.Size = new System.Drawing.Size(150, 30);
            this.btnSekundarneKategorije.Text = "Sekundarne kategorije";
            this.btnSekundarneKategorije.UseVisualStyleBackColor = true;
            this.btnSekundarneKategorije.Click += new System.EventHandler(this.btnSekundarneKategorije_Click);

            // btnOblik
            this.btnOblik.Location = new System.Drawing.Point(730, 192);
            this.btnOblik.Name = "btnOblik";
            this.btnOblik.Size = new System.Drawing.Size(150, 30);
            this.btnOblik.Text = "Oblik";
            this.btnOblik.UseVisualStyleBackColor = true;
            this.btnOblik.Click += new System.EventHandler(this.btnOblik_Click);

            // btnPakovanje
            this.btnPakovanje.Location = new System.Drawing.Point(730, 228);
            this.btnPakovanje.Name = "btnPakovanje";
            this.btnPakovanje.Size = new System.Drawing.Size(150, 30);
            this.btnPakovanje.Text = "Pakovanje";
            this.btnPakovanje.UseVisualStyleBackColor = true;
            this.btnPakovanje.Click += new System.EventHandler(this.btnPakovanje_Click);

            // btnPrimarnaGrupa
            this.btnPrimarnaGrupa.Location = new System.Drawing.Point(730, 264);
            this.btnPrimarnaGrupa.Name = "btnPrimarnaGrupa";
            this.btnPrimarnaGrupa.Size = new System.Drawing.Size(150, 30);
            this.btnPrimarnaGrupa.Text = "Primarna grupa";
            this.btnPrimarnaGrupa.UseVisualStyleBackColor = true;
            this.btnPrimarnaGrupa.Click += new System.EventHandler(this.btnPrimarnaGrupa_Click);

            // btnProizvodjac
            this.btnProizvodjac.Location = new System.Drawing.Point(730, 300);
            this.btnProizvodjac.Name = "btnProizvodjac";
            this.btnProizvodjac.Size = new System.Drawing.Size(150, 30);
            this.btnProizvodjac.Text = "Proizvođač";
            this.btnProizvodjac.UseVisualStyleBackColor = true;
            this.btnProizvodjac.Click += new System.EventHandler(this.btnProizvodjac_Click);

            // btnRecept
            this.btnRecept.Location = new System.Drawing.Point(730, 336);
            this.btnRecept.Name = "btnRecept";
            this.btnRecept.Size = new System.Drawing.Size(150, 30);
            this.btnRecept.Text = "Recept";
            this.btnRecept.UseVisualStyleBackColor = true;
            this.btnRecept.Click += new System.EventHandler(this.btnRecept_Click);

            // btnSekundarnaGrupa
            this.btnSekundarnaGrupa.Location = new System.Drawing.Point(730, 372);
            this.btnSekundarnaGrupa.Name = "btnSekundarnaGrupa";
            this.btnSekundarnaGrupa.Size = new System.Drawing.Size(150, 30);
            this.btnSekundarnaGrupa.Text = "Sekundarna grupa";
            this.btnSekundarnaGrupa.UseVisualStyleBackColor = true;
            this.btnSekundarnaGrupa.Click += new System.EventHandler(this.btnSekundarnaGrupa_Click);

            // LekAdminForm
            this.ClientSize = new System.Drawing.Size(900, 420);
            this.Controls.Add(this.dgvLekovi);
            this.Controls.Add(this.btnDodajNoviLek);
            this.Controls.Add(this.btnIzmeniLek);
            this.Controls.Add(this.btnObrisiLek);
            this.Controls.Add(this.btnDistributeri);
            this.Controls.Add(this.btnSekundarneKategorije);
            this.Controls.Add(this.btnOblik);
            this.Controls.Add(this.btnPakovanje);
            this.Controls.Add(this.btnPrimarnaGrupa);
            this.Controls.Add(this.btnProizvodjac);
            this.Controls.Add(this.btnRecept);
            this.Controls.Add(this.btnSekundarnaGrupa);

            this.Name = "LekAdminForm";
            this.Text = "Administracija lekova";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLekovi)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
