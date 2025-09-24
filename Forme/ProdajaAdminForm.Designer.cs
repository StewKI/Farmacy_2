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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            panelSearch = new Panel();
            panelHeader = new Panel();
            panelButtons = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvProdaje).BeginInit();
            panelMain.SuspendLayout();
            panelSearch.SuspendLayout();
            panelHeader.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProdaje
            // 
            dgvProdaje.AllowUserToAddRows = false;
            dgvProdaje.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
            dgvProdaje.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProdaje.BackgroundColor = Color.White;
            dgvProdaje.BorderStyle = BorderStyle.None;
            dgvProdaje.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(52, 58, 64);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 58, 64);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProdaje.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProdaje.ColumnHeadersHeight = 50;
            dgvProdaje.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProdaje.Columns.AddRange(new DataGridViewColumn[] { colId, colProdajnaJedinicaNaziv, colDatumVreme, colBlagajnikIme, colUkupnaVrednost, colBrojStavki });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 123, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProdaje.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProdaje.EnableHeadersVisualStyles = false;
            dgvProdaje.GridColor = Color.FromArgb(233, 236, 239);
            dgvProdaje.Location = new Point(30, 289);
            dgvProdaje.Margin = new Padding(4, 4, 4, 4);
            dgvProdaje.MultiSelect = false;
            dgvProdaje.Name = "dgvProdaje";
            dgvProdaje.ReadOnly = true;
            dgvProdaje.RowHeadersVisible = false;
            dgvProdaje.RowHeadersWidth = 51;
            dgvProdaje.RowTemplate.Height = 45;
            dgvProdaje.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdaje.Size = new Size(1166, 415);
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
            // 
            // lblProdaje
            // 
            lblProdaje.AutoSize = true;
            lblProdaje.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblProdaje.ForeColor = Color.FromArgb(33, 37, 41);
            lblProdaje.Location = new Point(20, 0);
            lblProdaje.Margin = new Padding(4, 0, 4, 0);
            lblProdaje.Name = "lblProdaje";
            lblProdaje.Size = new Size(359, 86);
            lblProdaje.TabIndex = 1;
            lblProdaje.Text = "💰 Prodaje";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = Color.FromArgb(108, 117, 125);
            lblSubtitle.Location = new Point(20, 99);
            lblSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(517, 41);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Upravljanje prodajama i transakcijama";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(251, 42);
            txtSearch.Margin = new Padding(4, 4, 4, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Pretražite po prodajnoj jedinici, blagajniku...";
            txtSearch.Size = new Size(454, 43);
            txtSearch.TabIndex = 4;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(33, 37, 41);
            lblSearch.Location = new Point(39, 42);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(181, 37);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "🔍 Pretraga:";
            // 
            // btnDodajNovuProdaju
            // 
            btnDodajNovuProdaju.BackColor = Color.FromArgb(40, 167, 69);
            btnDodajNovuProdaju.FlatAppearance.BorderSize = 0;
            btnDodajNovuProdaju.FlatStyle = FlatStyle.Flat;
            btnDodajNovuProdaju.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDodajNovuProdaju.ForeColor = Color.White;
            btnDodajNovuProdaju.Location = new Point(26, 128);
            btnDodajNovuProdaju.Margin = new Padding(4, 4, 4, 4);
            btnDodajNovuProdaju.Name = "btnDodajNovuProdaju";
            btnDodajNovuProdaju.Size = new Size(273, 70);
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
            btnObrisiProdaju.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnObrisiProdaju.ForeColor = Color.White;
            btnObrisiProdaju.Location = new Point(26, 320);
            btnObrisiProdaju.Margin = new Padding(4, 4, 4, 4);
            btnObrisiProdaju.Name = "btnObrisiProdaju";
            btnObrisiProdaju.Size = new Size(273, 70);
            btnObrisiProdaju.TabIndex = 3;
            btnObrisiProdaju.Text = "🗑️ Obriši prodaju";
            btnObrisiProdaju.UseVisualStyleBackColor = false;
            btnObrisiProdaju.Click += btnObrisiProdaju_Click;
            // 
            // btnDetalji
            // 
            btnDetalji.BackColor = Color.FromArgb(0, 123, 255);
            btnDetalji.FlatAppearance.BorderSize = 0;
            btnDetalji.FlatStyle = FlatStyle.Flat;
            btnDetalji.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDetalji.ForeColor = Color.White;
            btnDetalji.Location = new Point(26, 224);
            btnDetalji.Margin = new Padding(4, 4, 4, 4);
            btnDetalji.Name = "btnDetalji";
            btnDetalji.Size = new Size(273, 70);
            btnDetalji.TabIndex = 4;
            btnDetalji.Text = "📋 Detalji prodaje";
            btnDetalji.UseVisualStyleBackColor = false;
            btnDetalji.Click += btnDetalji_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(248, 249, 250);
            panelMain.Controls.Add(dgvProdaje);
            panelMain.Controls.Add(panelSearch);
            panelMain.Controls.Add(panelHeader);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Margin = new Padding(4, 4, 4, 4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(26, 26, 26, 26);
            panelMain.Size = new Size(1560, 897);
            panelMain.TabIndex = 0;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.White;
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Controls.Add(lblSearch);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(26, 166);
            panelSearch.Margin = new Padding(4, 4, 4, 4);
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new Padding(20, 19, 20, 19);
            panelSearch.Size = new Size(1508, 96);
            panelSearch.TabIndex = 5;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblProdaje);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(26, 26);
            panelHeader.Margin = new Padding(4, 4, 4, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1508, 140);
            panelHeader.TabIndex = 4;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.White;
            panelButtons.Controls.Add(btnDetalji);
            panelButtons.Controls.Add(btnObrisiProdaju);
            panelButtons.Controls.Add(btnDodajNovuProdaju);
            panelButtons.Dock = DockStyle.Right;
            panelButtons.Location = new Point(1235, 0);
            panelButtons.Margin = new Padding(4, 4, 4, 4);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(26, 26, 26, 26);
            panelButtons.Size = new Size(325, 897);
            panelButtons.TabIndex = 1;
            // 
            // ProdajaAdminForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1560, 897);
            Controls.Add(panelButtons);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(4, 4, 4, 4);
            MinimumSize = new Size(1292, 748);
            Name = "ProdajaAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "💰 Administracija prodaja - Farmacy";
            Load += ProdajaAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdaje).EndInit();
            panelMain.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }


    }
}

