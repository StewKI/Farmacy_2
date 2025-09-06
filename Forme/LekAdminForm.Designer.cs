namespace Farmacy.Forme
{
    partial class LekAdminForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvLekovi;
        private System.Windows.Forms.DataGridView dgvPrimarneGrupe;
        private System.Windows.Forms.DataGridView dgvSekundarneGrupe;
        private System.Windows.Forms.Label lblLekovi;
        private System.Windows.Forms.Label lblPrimarneGrupe;
        private System.Windows.Forms.Label lblSekundarneGrupe;
        private System.Windows.Forms.Button btnDodajNoviLek;
        private System.Windows.Forms.Button btnIzmeniLek;
        private System.Windows.Forms.Button btnObrisiLek;
        private System.Windows.Forms.Button btnOblik;
        private System.Windows.Forms.Button btnPrimarnaGrupa;
        private System.Windows.Forms.Button btnRecept;
        private System.Windows.Forms.Button btnSekundarnaGrupa;

        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        //private System.Windows.Forms.DataGridViewTextBoxColumn colHemijskiNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKomercijalniNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDejstvo;
        
        // Primarne grupe columns
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrimarnaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrimarnaNaziv;
        
        // Sekundarne grupe columns
        private System.Windows.Forms.DataGridViewTextBoxColumn colSekundarnaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSekundarnaNaziv;

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
            dgvPrimarneGrupe = new DataGridView();
            colPrimarnaId = new DataGridViewTextBoxColumn();
            colPrimarnaNaziv = new DataGridViewTextBoxColumn();
            dgvSekundarneGrupe = new DataGridView();
            colSekundarnaId = new DataGridViewTextBoxColumn();
            colSekundarnaNaziv = new DataGridViewTextBoxColumn();
            lblLekovi = new Label();
            lblPrimarneGrupe = new Label();
            lblSekundarneGrupe = new Label();
            btnDodajNoviLek = new Button();
            btnIzmeniLek = new Button();
            btnObrisiLek = new Button();
            btnOblik = new Button();
            btnPrimarnaGrupa = new Button();
            btnRecept = new Button();
            btnSekundarnaGrupa = new Button();
            dgvOblik = new DataGridView();
            oblikId = new DataGridViewTextBoxColumn();
            oblikNaziv = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLekovi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrimarneGrupe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSekundarneGrupe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOblik).BeginInit();
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
            dgvLekovi.RowHeadersWidth = 82;
            dgvLekovi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLekovi.Size = new Size(766, 399);
            dgvLekovi.TabIndex = 0;
            dgvLekovi.CellContentClick += dgvLekovi_CellContentClick;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.MinimumWidth = 10;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 60;
            // 
            // colKomercijalniNaziv
            // 
            colKomercijalniNaziv.DataPropertyName = "KomercijalniNaziv";
            colKomercijalniNaziv.HeaderText = "Komercijalni naziv";
            colKomercijalniNaziv.MinimumWidth = 10;
            colKomercijalniNaziv.Name = "colKomercijalniNaziv";
            colKomercijalniNaziv.ReadOnly = true;
            colKomercijalniNaziv.Width = 180;
            // 
            // colDejstvo
            // 
            colDejstvo.DataPropertyName = "Dejstvo";
            colDejstvo.HeaderText = "Dejstvo";
            colDejstvo.MinimumWidth = 10;
            colDejstvo.Name = "colDejstvo";
            colDejstvo.ReadOnly = true;
            colDejstvo.Width = 200;
            // 
            // dgvPrimarneGrupe
            // 
            dgvPrimarneGrupe.AllowUserToAddRows = false;
            dgvPrimarneGrupe.AllowUserToDeleteRows = false;
            dgvPrimarneGrupe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrimarneGrupe.Columns.AddRange(new DataGridViewColumn[] { colPrimarnaId, colPrimarnaNaziv });
            dgvPrimarneGrupe.Location = new Point(12, 494);
            dgvPrimarneGrupe.MultiSelect = false;
            dgvPrimarneGrupe.Name = "dgvPrimarneGrupe";
            dgvPrimarneGrupe.ReadOnly = true;
            dgvPrimarneGrupe.RowHeadersWidth = 82;
            dgvPrimarneGrupe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrimarneGrupe.Size = new Size(344, 150);
            dgvPrimarneGrupe.TabIndex = 14;
            // 
            // colPrimarnaId
            // 
            colPrimarnaId.DataPropertyName = "Id";
            colPrimarnaId.HeaderText = "ID";
            colPrimarnaId.MinimumWidth = 10;
            colPrimarnaId.Name = "colPrimarnaId";
            colPrimarnaId.ReadOnly = true;
            colPrimarnaId.Width = 60;
            // 
            // colPrimarnaNaziv
            // 
            colPrimarnaNaziv.DataPropertyName = "Naziv";
            colPrimarnaNaziv.HeaderText = "Naziv";
            colPrimarnaNaziv.MinimumWidth = 10;
            colPrimarnaNaziv.Name = "colPrimarnaNaziv";
            colPrimarnaNaziv.ReadOnly = true;
            colPrimarnaNaziv.Width = 200;
            // 
            // dgvSekundarneGrupe
            // 
            dgvSekundarneGrupe.AllowUserToAddRows = false;
            dgvSekundarneGrupe.AllowUserToDeleteRows = false;
            dgvSekundarneGrupe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSekundarneGrupe.Columns.AddRange(new DataGridViewColumn[] { colSekundarnaId, colSekundarnaNaziv });
            dgvSekundarneGrupe.Location = new Point(423, 494);
            dgvSekundarneGrupe.MultiSelect = false;
            dgvSekundarneGrupe.Name = "dgvSekundarneGrupe";
            dgvSekundarneGrupe.ReadOnly = true;
            dgvSekundarneGrupe.RowHeadersWidth = 82;
            dgvSekundarneGrupe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSekundarneGrupe.Size = new Size(344, 150);
            dgvSekundarneGrupe.TabIndex = 15;
            // 
            // colSekundarnaId
            // 
            colSekundarnaId.DataPropertyName = "Id";
            colSekundarnaId.HeaderText = "ID";
            colSekundarnaId.MinimumWidth = 10;
            colSekundarnaId.Name = "colSekundarnaId";
            colSekundarnaId.ReadOnly = true;
            colSekundarnaId.Width = 60;
            // 
            // colSekundarnaNaziv
            // 
            colSekundarnaNaziv.DataPropertyName = "Naziv";
            colSekundarnaNaziv.HeaderText = "Naziv";
            colSekundarnaNaziv.MinimumWidth = 10;
            colSekundarnaNaziv.Name = "colSekundarnaNaziv";
            colSekundarnaNaziv.ReadOnly = true;
            colSekundarnaNaziv.Width = 200;
            // 
            // lblLekovi
            // 
            lblLekovi.AutoSize = true;
            lblLekovi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLekovi.Location = new Point(1, 0);
            lblLekovi.Name = "lblLekovi";
            lblLekovi.Size = new Size(101, 37);
            lblLekovi.TabIndex = 16;
            lblLekovi.Text = "Lekovi";
            // 
            // lblPrimarneGrupe
            // 
            lblPrimarneGrupe.AutoSize = true;
            lblPrimarneGrupe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrimarneGrupe.Location = new Point(12, 432);
            lblPrimarneGrupe.Name = "lblPrimarneGrupe";
            lblPrimarneGrupe.Size = new Size(218, 37);
            lblPrimarneGrupe.TabIndex = 17;
            lblPrimarneGrupe.Text = "Primarne grupe";
            // 
            // lblSekundarneGrupe
            // 
            lblSekundarneGrupe.AutoSize = true;
            lblSekundarneGrupe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSekundarneGrupe.Location = new Point(445, 432);
            lblSekundarneGrupe.Name = "lblSekundarneGrupe";
            lblSekundarneGrupe.Size = new Size(251, 37);
            lblSekundarneGrupe.TabIndex = 18;
            lblSekundarneGrupe.Text = "Sekundarne grupe";
            // 
            // btnDodajNoviLek
            // 
            btnDodajNoviLek.Location = new Point(1212, 12);
            btnDodajNoviLek.Name = "btnDodajNoviLek";
            btnDodajNoviLek.Size = new Size(150, 93);
            btnDodajNoviLek.TabIndex = 1;
            btnDodajNoviLek.Text = "Dodaj novi lek";
            btnDodajNoviLek.UseVisualStyleBackColor = true;
            btnDodajNoviLek.Click += btnDodajNoviLek_Click;
            // 
            // btnIzmeniLek
            // 
            btnIzmeniLek.Location = new Point(1212, 111);
            btnIzmeniLek.Name = "btnIzmeniLek";
            btnIzmeniLek.Size = new Size(150, 93);
            btnIzmeniLek.TabIndex = 2;
            btnIzmeniLek.Text = "Izmeni lek";
            btnIzmeniLek.UseVisualStyleBackColor = true;
            btnIzmeniLek.Click += btnIzmeniLek_Click;
            // 
            // btnObrisiLek
            // 
            btnObrisiLek.Location = new Point(1212, 210);
            btnObrisiLek.Name = "btnObrisiLek";
            btnObrisiLek.Size = new Size(150, 93);
            btnObrisiLek.TabIndex = 3;
            btnObrisiLek.Text = "Obriši lek";
            btnObrisiLek.UseVisualStyleBackColor = true;
            btnObrisiLek.Click += btnObrisiLek_Click;
            // 
            // btnOblik
            // 
            btnOblik.Location = new Point(1212, 417);
            btnOblik.Name = "btnOblik";
            btnOblik.Size = new Size(150, 93);
            btnOblik.TabIndex = 6;
            btnOblik.Text = "Oblik";
            btnOblik.UseVisualStyleBackColor = true;
            btnOblik.Click += btnOblik_Click;
            // 
            // btnPrimarnaGrupa
            // 
            btnPrimarnaGrupa.Location = new Point(1212, 318);
            btnPrimarnaGrupa.Name = "btnPrimarnaGrupa";
            btnPrimarnaGrupa.Size = new Size(150, 93);
            btnPrimarnaGrupa.TabIndex = 8;
            btnPrimarnaGrupa.Text = "Primarne grupe";
            btnPrimarnaGrupa.UseVisualStyleBackColor = true;
            btnPrimarnaGrupa.Click += btnPrimarnaGrupa_Click;
            // 
            // btnRecept
            // 
            btnRecept.Location = new Point(1212, 516);
            btnRecept.Name = "btnRecept";
            btnRecept.Size = new Size(150, 93);
            btnRecept.TabIndex = 10;
            btnRecept.Text = "Recept";
            btnRecept.UseVisualStyleBackColor = true;
            btnRecept.Click += btnRecept_Click;
            // 
            // btnSekundarnaGrupa
            // 
            btnSekundarnaGrupa.Location = new Point(1044, 318);
            btnSekundarnaGrupa.Name = "btnSekundarnaGrupa";
            btnSekundarnaGrupa.Size = new Size(150, 93);
            btnSekundarnaGrupa.TabIndex = 11;
            btnSekundarnaGrupa.Text = "Sekundarne grupe";
            btnSekundarnaGrupa.UseVisualStyleBackColor = true;
            btnSekundarnaGrupa.Click += btnSekundarnaGrupa_Click;
            // 
            // dgvOblik
            // 
            dgvOblik.AllowUserToAddRows = false;
            dgvOblik.AllowUserToDeleteRows = false;
            dgvOblik.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOblik.Columns.AddRange(new DataGridViewColumn[] { oblikId, oblikNaziv });
            dgvOblik.Location = new Point(829, 494);
            dgvOblik.MultiSelect = false;
            dgvOblik.Name = "dgvOblik";
            dgvOblik.ReadOnly = true;
            dgvOblik.RowHeadersWidth = 82;
            dgvOblik.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOblik.Size = new Size(324, 150);
            dgvOblik.TabIndex = 12;
            // 
            // oblikId
            // 
            oblikId.DataPropertyName = "Id";
            oblikId.HeaderText = "ID";
            oblikId.MinimumWidth = 10;
            oblikId.Name = "oblikId";
            oblikId.ReadOnly = true;
            oblikId.Width = 60;
            // 
            // oblikNaziv
            // 
            oblikNaziv.DataPropertyName = "HemijskiNaziv";
            oblikNaziv.HeaderText = "Hemijski naziv";
            oblikNaziv.MinimumWidth = 10;
            oblikNaziv.Name = "oblikNaziv";
            oblikNaziv.ReadOnly = true;
            oblikNaziv.Width = 180;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(829, 432);
            label1.Name = "label1";
            label1.Size = new Size(91, 37);
            label1.TabIndex = 19;
            label1.Text = "Oblici";
            label1.Click += label1_Click;
            // 
            // LekAdminForm
            // 
            ClientSize = new Size(1401, 672);
            Controls.Add(label1);
            Controls.Add(lblSekundarneGrupe);
            Controls.Add(lblPrimarneGrupe);
            Controls.Add(lblLekovi);
            Controls.Add(dgvSekundarneGrupe);
            Controls.Add(dgvPrimarneGrupe);
            Controls.Add(dgvOblik);
            Controls.Add(dgvLekovi);
            Controls.Add(btnDodajNoviLek);
            Controls.Add(btnIzmeniLek);
            Controls.Add(btnObrisiLek);
            Controls.Add(btnOblik);
            Controls.Add(btnPrimarnaGrupa);
            Controls.Add(btnRecept);
            Controls.Add(btnSekundarnaGrupa);
            Name = "LekAdminForm";
            Text = "Administracija lekova";
            Load += LekAdminForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvLekovi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrimarneGrupe).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSekundarneGrupe).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOblik).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dgvOblik;
        private DataGridViewTextBoxColumn oblikId;
        private DataGridViewTextBoxColumn oblikNaziv;
        private Label label1;
    }
}
