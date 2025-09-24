namespace Farmacy.Forme
{
    partial class ProdajaAdminForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvProdaje;
        private System.Windows.Forms.Label lblProdaje;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnDodajNovuProdaju;
        private System.Windows.Forms.Button btnObrisiProdaju;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelSearch;

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
            lblSubtitle = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnDodajNovuProdaju = new Button();
            btnObrisiProdaju = new Button();
            btnDetalji = new Button();
            panelMain = new Panel();
            panelButtons = new Panel();
            panelHeader = new Panel();
            panelSearch = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvProdaje).BeginInit();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblProdaje);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(20, 20);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(900, 80);
            panelHeader.TabIndex = 4;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.White;
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Controls.Add(lblSearch);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(20, 100);
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new Padding(15);
            panelSearch.Size = new Size(900, 60);
            panelSearch.TabIndex = 5;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(248, 249, 250);
            panelMain.Controls.Add(dgvProdaje);
            panelMain.Controls.Add(panelSearch);
            panelMain.Controls.Add(panelHeader);
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
            lblProdaje.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblProdaje.ForeColor = Color.FromArgb(33, 37, 41);
            lblProdaje.Location = new Point(15, 10);
            lblProdaje.Name = "lblProdaje";
            lblProdaje.Size = new Size(186, 45);
            lblProdaje.TabIndex = 1;
            lblProdaje.Text = "💰 Prodaje";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = Color.FromArgb(108, 117, 125);
            lblSubtitle.Location = new Point(15, 55);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(320, 20);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Upravljanje prodajama i transakcijama";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(33, 37, 41);
            lblSearch.Location = new Point(15, 18);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(68, 19);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "🔍 Pretraga:";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(100, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Pretražite po prodajnoj jedinici, blagajniku...";
            txtSearch.Size = new Size(350, 25);
            txtSearch.TabIndex = 4;
            // 
            // dgvProdaje
            // 
            dgvProdaje.AllowUserToAddRows = false;
            dgvProdaje.AllowUserToDeleteRows = false;
            dgvProdaje.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            dgvProdaje.BackgroundColor = Color.White;
            dgvProdaje.BorderStyle = BorderStyle.None;
            dgvProdaje.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProdaje.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 58, 64);
            dgvProdaje.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvProdaje.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProdaje.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 58, 64);
            dgvProdaje.ColumnHeadersHeight = 50;
            dgvProdaje.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProdaje.Columns.AddRange(new DataGridViewColumn[] { colId, colProdajnaJedinicaNaziv, colDatumVreme, colBlagajnikIme, colUkupnaVrednost, colBrojStavki });
            dgvProdaje.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvProdaje.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 123, 255);
            dgvProdaje.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvProdaje.EnableHeadersVisualStyles = false;
            dgvProdaje.GridColor = Color.FromArgb(233, 236, 239);
            dgvProdaje.Location = new Point(20, 180);
            dgvProdaje.MultiSelect = false;
            dgvProdaje.Name = "dgvProdaje";
            dgvProdaje.ReadOnly = true;
            dgvProdaje.RowHeadersVisible = false;
            dgvProdaje.RowHeadersWidth = 51;
            dgvProdaje.RowTemplate.Height = 45;
            dgvProdaje.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdaje.Size = new Size(900, 400);
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
            panelButtons.BackColor = Color.White;
            panelButtons.Controls.Add(btnDetalji);
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
            btnDodajNovuProdaju.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDodajNovuProdaju.ForeColor = Color.White;
            btnDodajNovuProdaju.Location = new Point(20, 100);
            btnDodajNovuProdaju.Name = "btnDodajNovuProdaju";
            btnDodajNovuProdaju.Size = new Size(210, 55);
            btnDodajNovuProdaju.TabIndex = 2;
            btnDodajNovuProdaju.Text = "➕ Nova prodaja";
            btnDodajNovuProdaju.UseVisualStyleBackColor = false;
            btnDodajNovuProdaju.Click += btnDodajNovuProdaju_Click;
            // 
            // btnDetalji
            // 
            btnDetalji.BackColor = Color.FromArgb(0, 123, 255);
            btnDetalji.FlatAppearance.BorderSize = 0;
            btnDetalji.FlatStyle = FlatStyle.Flat;
            btnDetalji.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDetalji.ForeColor = Color.White;
            btnDetalji.Location = new Point(20, 175);
            btnDetalji.Name = "btnDetalji";
            btnDetalji.Size = new Size(210, 55);
            btnDetalji.TabIndex = 4;
            btnDetalji.Text = "📋 Detalji prodaje";
            btnDetalji.UseVisualStyleBackColor = false;
            btnDetalji.Click += btnDetalji_Click;
            // 
            // btnObrisiProdaju
            // 
            btnObrisiProdaju.BackColor = Color.FromArgb(220, 53, 69);
            btnObrisiProdaju.FlatAppearance.BorderSize = 0;
            btnObrisiProdaju.FlatStyle = FlatStyle.Flat;
            btnObrisiProdaju.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnObrisiProdaju.ForeColor = Color.White;
            btnObrisiProdaju.Location = new Point(20, 250);
            btnObrisiProdaju.Name = "btnObrisiProdaju";
            btnObrisiProdaju.Size = new Size(210, 55);
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
            ClientSize = new Size(1200, 650);
            Controls.Add(panelButtons);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1000, 600);
            Name = "ProdajaAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "💰 Administracija prodaja - Farmacy";
            Load += ProdajaAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdaje).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelMain.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        
    }
}

