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
        //private System.Windows.Forms.DataGridViewTextBoxColumn colHemijskiNaziv;
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
            dgvLekovi = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colKomercijalniNaziv = new DataGridViewTextBoxColumn();
            colDejstvo = new DataGridViewTextBoxColumn();
            btnDodajNoviLek = new Button();
            btnIzmeniLek = new Button();
            btnObrisiLek = new Button();
            btnDistributeri = new Button();
            btnSekundarneKategorije = new Button();
            btnOblik = new Button();
            btnPakovanje = new Button();
            btnPrimarnaGrupa = new Button();
            btnProizvodjac = new Button();
            btnRecept = new Button();
            btnSekundarnaGrupa = new Button();
            dgvOblik = new DataGridView();
            oblikId = new DataGridViewTextBoxColumn();
            oblikNaziv = new DataGridViewTextBoxColumn();
            dgvDistributer = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvLekovi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOblik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDistributer).BeginInit();
            SuspendLayout();
            // 
            // dgvLekovi
            // 
            dgvLekovi.AllowUserToAddRows = false;
            dgvLekovi.AllowUserToDeleteRows = false;
            dgvLekovi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLekovi.Columns.AddRange(new DataGridViewColumn[] { colId, colKomercijalniNaziv, colDejstvo });
            dgvLekovi.Location = new Point(1, 12);
            dgvLekovi.MultiSelect = false;
            dgvLekovi.Name = "dgvLekovi";
            dgvLekovi.ReadOnly = true;
            dgvLekovi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLekovi.Size = new Size(423, 399);
            dgvLekovi.TabIndex = 0;
            dgvLekovi.CellContentClick += dgvLekovi_CellContentClick;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 60;
            // 
            // colKomercijalniNaziv
            // 
            colKomercijalniNaziv.DataPropertyName = "KomercijalniNaziv";
            colKomercijalniNaziv.HeaderText = "Komercijalni naziv";
            colKomercijalniNaziv.Name = "colKomercijalniNaziv";
            colKomercijalniNaziv.ReadOnly = true;
            colKomercijalniNaziv.Width = 180;
            // 
            // colDejstvo
            // 
            colDejstvo.DataPropertyName = "Dejstvo";
            colDejstvo.HeaderText = "Dejstvo";
            colDejstvo.Name = "colDejstvo";
            colDejstvo.ReadOnly = true;
            colDejstvo.Width = 200;
            // 
            // btnDodajNoviLek
            // 
            btnDodajNoviLek.Location = new Point(808, 21);
            btnDodajNoviLek.Name = "btnDodajNoviLek";
            btnDodajNoviLek.Size = new Size(150, 30);
            btnDodajNoviLek.TabIndex = 1;
            btnDodajNoviLek.Text = "Dodaj novi lek";
            btnDodajNoviLek.UseVisualStyleBackColor = true;
            btnDodajNoviLek.Click += btnDodajNoviLek_Click;
            // 
            // btnIzmeniLek
            // 
            btnIzmeniLek.Location = new Point(808, 57);
            btnIzmeniLek.Name = "btnIzmeniLek";
            btnIzmeniLek.Size = new Size(150, 30);
            btnIzmeniLek.TabIndex = 2;
            btnIzmeniLek.Text = "Izmeni lek";
            btnIzmeniLek.UseVisualStyleBackColor = true;
            btnIzmeniLek.Click += btnIzmeniLek_Click;
            // 
            // btnObrisiLek
            // 
            btnObrisiLek.Location = new Point(808, 93);
            btnObrisiLek.Name = "btnObrisiLek";
            btnObrisiLek.Size = new Size(150, 30);
            btnObrisiLek.TabIndex = 3;
            btnObrisiLek.Text = "Obriši lek";
            btnObrisiLek.UseVisualStyleBackColor = true;
            btnObrisiLek.Click += btnObrisiLek_Click;
            // 
            // btnDistributeri
            // 
            btnDistributeri.Location = new Point(808, 129);
            btnDistributeri.Name = "btnDistributeri";
            btnDistributeri.Size = new Size(150, 30);
            btnDistributeri.TabIndex = 4;
            btnDistributeri.Text = "Distributeri";
            btnDistributeri.UseVisualStyleBackColor = true;
            btnDistributeri.Click += btnDistributeri_Click;
            // 
            // btnSekundarneKategorije
            // 
            btnSekundarneKategorije.Location = new Point(808, 165);
            btnSekundarneKategorije.Name = "btnSekundarneKategorije";
            btnSekundarneKategorije.Size = new Size(150, 30);
            btnSekundarneKategorije.TabIndex = 5;
            btnSekundarneKategorije.Text = "Sekundarne kategorije";
            btnSekundarneKategorije.UseVisualStyleBackColor = true;
            btnSekundarneKategorije.Click += btnSekundarneKategorije_Click;
            // 
            // btnOblik
            // 
            btnOblik.Location = new Point(808, 201);
            btnOblik.Name = "btnOblik";
            btnOblik.Size = new Size(150, 30);
            btnOblik.TabIndex = 6;
            btnOblik.Text = "Oblik";
            btnOblik.UseVisualStyleBackColor = true;
            btnOblik.Click += btnOblik_Click;
            // 
            // btnPakovanje
            // 
            btnPakovanje.Location = new Point(808, 237);
            btnPakovanje.Name = "btnPakovanje";
            btnPakovanje.Size = new Size(150, 30);
            btnPakovanje.TabIndex = 7;
            btnPakovanje.Text = "Pakovanje";
            btnPakovanje.UseVisualStyleBackColor = true;
            btnPakovanje.Click += btnPakovanje_Click;
            // 
            // btnPrimarnaGrupa
            // 
            btnPrimarnaGrupa.Location = new Point(808, 273);
            btnPrimarnaGrupa.Name = "btnPrimarnaGrupa";
            btnPrimarnaGrupa.Size = new Size(150, 30);
            btnPrimarnaGrupa.TabIndex = 8;
            btnPrimarnaGrupa.Text = "Primarna grupa";
            btnPrimarnaGrupa.UseVisualStyleBackColor = true;
            btnPrimarnaGrupa.Click += btnPrimarnaGrupa_Click;
            // 
            // btnProizvodjac
            // 
            btnProizvodjac.Location = new Point(808, 309);
            btnProizvodjac.Name = "btnProizvodjac";
            btnProizvodjac.Size = new Size(150, 30);
            btnProizvodjac.TabIndex = 9;
            btnProizvodjac.Text = "Proizvođač";
            btnProizvodjac.UseVisualStyleBackColor = true;
            btnProizvodjac.Click += btnProizvodjac_Click;
            // 
            // btnRecept
            // 
            btnRecept.Location = new Point(808, 345);
            btnRecept.Name = "btnRecept";
            btnRecept.Size = new Size(150, 30);
            btnRecept.TabIndex = 10;
            btnRecept.Text = "Recept";
            btnRecept.UseVisualStyleBackColor = true;
            btnRecept.Click += btnRecept_Click;
            // 
            // btnSekundarnaGrupa
            // 
            btnSekundarnaGrupa.Location = new Point(808, 381);
            btnSekundarnaGrupa.Name = "btnSekundarnaGrupa";
            btnSekundarnaGrupa.Size = new Size(150, 30);
            btnSekundarnaGrupa.TabIndex = 11;
            btnSekundarnaGrupa.Text = "Sekundarna grupa";
            btnSekundarnaGrupa.UseVisualStyleBackColor = true;
            btnSekundarnaGrupa.Click += btnSekundarnaGrupa_Click;
            // 
            // dgvOblik
            // 
            dgvOblik.AllowUserToAddRows = false;
            dgvOblik.AllowUserToDeleteRows = false;
            dgvOblik.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOblik.Columns.AddRange(new DataGridViewColumn[] { oblikId, oblikNaziv });
            dgvOblik.Location = new Point(440, 12);
            dgvOblik.MultiSelect = false;
            dgvOblik.Name = "dgvOblik";
            dgvOblik.ReadOnly = true;
            dgvOblik.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOblik.Size = new Size(362, 188);
            dgvOblik.TabIndex = 12;
            // 
            // oblikId
            // 
            oblikId.DataPropertyName = "Id";
            oblikId.HeaderText = "ID";
            oblikId.Name = "oblikId";
            oblikId.ReadOnly = true;
            oblikId.Width = 60;
            // 
            // oblikNaziv
            // 
            oblikNaziv.DataPropertyName = "HemijskiNaziv";
            oblikNaziv.HeaderText = "Hemijski naziv";
            oblikNaziv.Name = "oblikNaziv";
            oblikNaziv.ReadOnly = true;
            oblikNaziv.Width = 180;
            // 
            // dgvDistributer
            // 
            dgvDistributer.AllowUserToAddRows = false;
            dgvDistributer.AllowUserToDeleteRows = false;
            dgvDistributer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDistributer.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dgvDistributer.Location = new Point(440, 206);
            dgvDistributer.MultiSelect = false;
            dgvDistributer.Name = "dgvDistributer";
            dgvDistributer.ReadOnly = true;
            dgvDistributer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDistributer.Size = new Size(362, 205);
            dgvDistributer.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Id";
            dataGridViewTextBoxColumn5.HeaderText = "ID";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 60;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "HemijskiNaziv";
            dataGridViewTextBoxColumn6.HeaderText = "Hemijski naziv";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 180;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "KomercijalniNaziv";
            dataGridViewTextBoxColumn7.HeaderText = "Komercijalni naziv";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 180;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "Dejstvo";
            dataGridViewTextBoxColumn8.HeaderText = "Dejstvo";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 200;
            // 
            // LekAdminForm
            // 
            ClientSize = new Size(970, 462);
            Controls.Add(dgvDistributer);
            Controls.Add(dgvOblik);
            Controls.Add(dgvLekovi);
            Controls.Add(btnDodajNoviLek);
            Controls.Add(btnIzmeniLek);
            Controls.Add(btnObrisiLek);
            Controls.Add(btnDistributeri);
            Controls.Add(btnSekundarneKategorije);
            Controls.Add(btnOblik);
            Controls.Add(btnPakovanje);
            Controls.Add(btnPrimarnaGrupa);
            Controls.Add(btnProizvodjac);
            Controls.Add(btnRecept);
            Controls.Add(btnSekundarnaGrupa);
            Name = "LekAdminForm";
            Text = "Administracija lekova";
            Load += LekAdminForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvLekovi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOblik).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDistributer).EndInit();
            ResumeLayout(false);
        }

        private DataGridView dgvOblik;
        private DataGridViewTextBoxColumn oblikId;
        private DataGridViewTextBoxColumn oblikNaziv;
       
        private DataGridView dgvDistributer;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}
