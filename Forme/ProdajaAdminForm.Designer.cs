namespace Farmacy.Forme
{
    partial class ProdajaAdminForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvProdaje;
        private System.Windows.Forms.Label lblProdaje;
        private System.Windows.Forms.Button btnDodajNovuProdaju;
        private System.Windows.Forms.Button btnObrisiProdaju;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelButtons;

        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdajnaJedinicaNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatumVreme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBlagajnikIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUkupnaVrednost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrojStavki;

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
            dgvProdaje = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colProdajnaJedinicaNaziv = new DataGridViewTextBoxColumn();
            colDatumVreme = new DataGridViewTextBoxColumn();
            colBlagajnikIme = new DataGridViewTextBoxColumn();
            colUkupnaVrednost = new DataGridViewTextBoxColumn();
            colBrojStavki = new DataGridViewTextBoxColumn();
            lblProdaje = new Label();
            btnDodajNovuProdaju = new Button();
            btnObrisiProdaju = new Button();
            panelMain = new Panel();
            panelButtons = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvProdaje).BeginInit();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(248, 249, 250);
            panelMain.Controls.Add(dgvProdaje);
            panelMain.Controls.Add(lblProdaje);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(1200, 600);
            panelMain.TabIndex = 0;
            // 
            // lblProdaje
            // 
            lblProdaje.AutoSize = true;
            lblProdaje.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblProdaje.ForeColor = Color.FromArgb(33, 37, 41);
            lblProdaje.Location = new Point(20, 20);
            lblProdaje.Name = "lblProdaje";
            lblProdaje.Size = new Size(120, 41);
            lblProdaje.TabIndex = 1;
            lblProdaje.Text = "Prodaje";
            // 
            // dgvProdaje
            // 
            dgvProdaje.AllowUserToAddRows = false;
            dgvProdaje.AllowUserToDeleteRows = false;
            dgvProdaje.BackgroundColor = Color.White;
            dgvProdaje.BorderStyle = BorderStyle.None;
            dgvProdaje.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProdaje.ColumnHeadersHeight = 50;
            dgvProdaje.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProdaje.Columns.AddRange(new DataGridViewColumn[] { colId, colProdajnaJedinicaNaziv, colDatumVreme, colBlagajnikIme, colUkupnaVrednost, colBrojStavki });
            dgvProdaje.GridColor = Color.FromArgb(233, 236, 239);
            dgvProdaje.Location = new Point(20, 80);
            dgvProdaje.MultiSelect = false;
            dgvProdaje.Name = "dgvProdaje";
            dgvProdaje.ReadOnly = true;
            dgvProdaje.RowHeadersVisible = false;
            dgvProdaje.RowHeadersWidth = 51;
            dgvProdaje.RowTemplate.Height = 40;
            dgvProdaje.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdaje.Size = new Size(900, 480);
            dgvProdaje.TabIndex = 0;
            dgvProdaje.CellContentClick += dgvProdaje_CellContentClick;
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
            // colProdajnaJedinicaNaziv
            // 
            colProdajnaJedinicaNaziv.DataPropertyName = "ProdajnaJedinicaNaziv";
            colProdajnaJedinicaNaziv.HeaderText = "Prodajna Jedinica";
            colProdajnaJedinicaNaziv.MinimumWidth = 10;
            colProdajnaJedinicaNaziv.Name = "colProdajnaJedinicaNaziv";
            colProdajnaJedinicaNaziv.ReadOnly = true;
            colProdajnaJedinicaNaziv.Width = 150;
            // 
            // colDatumVreme
            // 
            colDatumVreme.DataPropertyName = "DatumVreme";
            colDatumVreme.HeaderText = "Datum i Vreme";
            colDatumVreme.MinimumWidth = 10;
            colDatumVreme.Name = "colDatumVreme";
            colDatumVreme.ReadOnly = true;
            colDatumVreme.Width = 150;
            // 
            // colBlagajnikIme
            // 
            colBlagajnikIme.DataPropertyName = "BlagajnikIme";
            colBlagajnikIme.HeaderText = "Blagajnik";
            colBlagajnikIme.MinimumWidth = 10;
            colBlagajnikIme.Name = "colBlagajnikIme";
            colBlagajnikIme.ReadOnly = true;
            colBlagajnikIme.Width = 150;
            // 
            // colUkupnaVrednost
            // 
            colUkupnaVrednost.DataPropertyName = "UkupnaVrednost";
            colUkupnaVrednost.HeaderText = "Ukupna Vrednost";
            colUkupnaVrednost.MinimumWidth = 10;
            colUkupnaVrednost.Name = "colUkupnaVrednost";
            colUkupnaVrednost.ReadOnly = true;
            colUkupnaVrednost.Width = 120;
            // 
            // colBrojStavki
            // 
            colBrojStavki.DataPropertyName = "BrojStavki";
            colBrojStavki.HeaderText = "Broj Stavki";
            colBrojStavki.MinimumWidth = 10;
            colBrojStavki.Name = "colBrojStavki";
            colBrojStavki.ReadOnly = true;
            colBrojStavki.Width = 100;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(255, 255, 255);
            panelButtons.Controls.Add(btnObrisiProdaju);
            panelButtons.Controls.Add(btnDodajNovuProdaju);
            panelButtons.Dock = DockStyle.Right;
            panelButtons.Location = new Point(950, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(20);
            panelButtons.Size = new Size(250, 600);
            panelButtons.TabIndex = 1;
            // 
            // btnDodajNovuProdaju
            // 
            btnDodajNovuProdaju.BackColor = Color.FromArgb(40, 167, 69);
            btnDodajNovuProdaju.FlatAppearance.BorderSize = 0;
            btnDodajNovuProdaju.FlatStyle = FlatStyle.Flat;
            btnDodajNovuProdaju.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDodajNovuProdaju.ForeColor = Color.White;
            btnDodajNovuProdaju.Location = new Point(20, 80);
            btnDodajNovuProdaju.Name = "btnDodajNovuProdaju";
            btnDodajNovuProdaju.Size = new Size(210, 50);
            btnDodajNovuProdaju.TabIndex = 2;
            btnDodajNovuProdaju.Text = "➕ Nova prodaja";
            btnDodajNovuProdaju.UseVisualStyleBackColor = false;
            btnDodajNovuProdaju.Click += btnDodajNovuProdaju_Click;
            // 
            // btnObrisiProdaju
            // 
            btnObrisiProdaju.BackColor = Color.FromArgb(220, 53, 69);
            btnObrisiProdaju.FlatAppearance.BorderSize = 0;
            btnObrisiProdaju.FlatStyle = FlatStyle.Flat;
            btnObrisiProdaju.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnObrisiProdaju.ForeColor = Color.White;
            btnObrisiProdaju.Location = new Point(20, 150);
            btnObrisiProdaju.Name = "btnObrisiProdaju";
            btnObrisiProdaju.Size = new Size(210, 50);
            btnObrisiProdaju.TabIndex = 3;
            btnObrisiProdaju.Text = "🗑️ Obriši prodaju";
            btnObrisiProdaju.UseVisualStyleBackColor = false;
            btnObrisiProdaju.Click += btnObrisiProdaju_Click;
            // 
            // ProdajaAdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1200, 600);
            Controls.Add(panelButtons);
            Controls.Add(panelMain);
            Name = "ProdajaAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administracija prodaja";
            Load += ProdajaAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdaje).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        
    }
}
