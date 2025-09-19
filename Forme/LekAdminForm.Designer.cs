namespace Farmacy.Forme
{
    partial class LekAdminForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dgvLekovi;
        private System.Windows.Forms.DataGridView dgvPrimarneGrupe;
        private System.Windows.Forms.DataGridView dgvSekundarneGrupe;
        private System.Windows.Forms.DataGridView dgvOblik;
        private System.Windows.Forms.Label lblLekovi;
        private System.Windows.Forms.Label lblPrimarneGrupe;
        private System.Windows.Forms.Label lblSekundarneGrupe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnDodajNoviLek;
        private System.Windows.Forms.Button btnIzmeniLek;
        private System.Windows.Forms.Button btnObrisiLek;
        private System.Windows.Forms.Button btnOblik;
        private System.Windows.Forms.Button btnPrimarnaGrupa;
        private System.Windows.Forms.Button btnRecept;
        private System.Windows.Forms.Button btnSekundarnaGrupa;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooter;

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
        
        // Oblik columns
        private System.Windows.Forms.DataGridViewTextBoxColumn oblikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn oblikNaziv;

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
            panelHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            panelMain = new Panel();
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
            dgvOblik = new DataGridView();
            oblikId = new DataGridViewTextBoxColumn();
            oblikNaziv = new DataGridViewTextBoxColumn();
            lblLekovi = new Label();
            lblPrimarneGrupe = new Label();
            lblSekundarneGrupe = new Label();
            label1 = new Label();
            panelButtons = new Panel();
            btnDodajNoviLek = new Button();
            btnIzmeniLek = new Button();
            btnObrisiLek = new Button();
            btnOblik = new Button();
            btnPrimarnaGrupa = new Button();
            btnRecept = new Button();
            btnSekundarnaGrupa = new Button();
            panelFooter = new Panel();
            lblFooter = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLekovi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrimarneGrupe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSekundarneGrupe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOblik).BeginInit();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(155, 89, 182);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1400, 120);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "💊 LEKOVI";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = Color.FromArgb(220, 200, 255);
            lblSubtitle.Location = new Point(30, 75);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(500, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Upravljanje lekovima, njihovim oblicima, grupama i receptima";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(panelButtons);
            panelMain.Controls.Add(dgvOblik);
            panelMain.Controls.Add(dgvSekundarneGrupe);
            panelMain.Controls.Add(dgvPrimarneGrupe);
            panelMain.Controls.Add(dgvLekovi);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(lblSekundarneGrupe);
            panelMain.Controls.Add(lblPrimarneGrupe);
            panelMain.Controls.Add(lblLekovi);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 120);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(1400, 552);
            panelMain.TabIndex = 1;
            // 
            // dgvLekovi
            // 
            dgvLekovi.AllowUserToAddRows = false;
            dgvLekovi.AllowUserToDeleteRows = false;
            dgvLekovi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLekovi.BackgroundColor = Color.White;
            dgvLekovi.BorderStyle = BorderStyle.None;
            dgvLekovi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvLekovi.ColumnHeadersHeight = 50;
            dgvLekovi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvLekovi.Columns.AddRange(new DataGridViewColumn[] { colId, colKomercijalniNaziv, colDejstvo });
            dgvLekovi.GridColor = Color.FromArgb(233, 236, 239);
            dgvLekovi.Location = new Point(20, 50);
            dgvLekovi.MultiSelect = false;
            dgvLekovi.Name = "dgvLekovi";
            dgvLekovi.ReadOnly = true;
            dgvLekovi.RowHeadersVisible = false;
            dgvLekovi.RowHeadersWidth = 51;
            dgvLekovi.RowTemplate.Height = 40;
            dgvLekovi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLekovi.Size = new Size(900, 200);
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
            dgvPrimarneGrupe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrimarneGrupe.BackgroundColor = Color.White;
            dgvPrimarneGrupe.BorderStyle = BorderStyle.None;
            dgvPrimarneGrupe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPrimarneGrupe.ColumnHeadersHeight = 40;
            dgvPrimarneGrupe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPrimarneGrupe.Columns.AddRange(new DataGridViewColumn[] { colPrimarnaId, colPrimarnaNaziv });
            dgvPrimarneGrupe.GridColor = Color.FromArgb(233, 236, 239);
            dgvPrimarneGrupe.Location = new Point(20, 320);
            dgvPrimarneGrupe.MultiSelect = false;
            dgvPrimarneGrupe.Name = "dgvPrimarneGrupe";
            dgvPrimarneGrupe.ReadOnly = true;
            dgvPrimarneGrupe.RowHeadersVisible = false;
            dgvPrimarneGrupe.RowHeadersWidth = 51;
            dgvPrimarneGrupe.RowTemplate.Height = 35;
            dgvPrimarneGrupe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrimarneGrupe.Size = new Size(280, 120);
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
            dgvSekundarneGrupe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSekundarneGrupe.BackgroundColor = Color.White;
            dgvSekundarneGrupe.BorderStyle = BorderStyle.None;
            dgvSekundarneGrupe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSekundarneGrupe.ColumnHeadersHeight = 40;
            dgvSekundarneGrupe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSekundarneGrupe.Columns.AddRange(new DataGridViewColumn[] { colSekundarnaId, colSekundarnaNaziv });
            dgvSekundarneGrupe.GridColor = Color.FromArgb(233, 236, 239);
            dgvSekundarneGrupe.Location = new Point(320, 320);
            dgvSekundarneGrupe.MultiSelect = false;
            dgvSekundarneGrupe.Name = "dgvSekundarneGrupe";
            dgvSekundarneGrupe.ReadOnly = true;
            dgvSekundarneGrupe.RowHeadersVisible = false;
            dgvSekundarneGrupe.RowHeadersWidth = 51;
            dgvSekundarneGrupe.RowTemplate.Height = 35;
            dgvSekundarneGrupe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSekundarneGrupe.Size = new Size(280, 120);
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
            lblLekovi.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLekovi.ForeColor = Color.FromArgb(33, 37, 41);
            lblLekovi.Location = new Point(20, 20);
            lblLekovi.Name = "lblLekovi";
            lblLekovi.Size = new Size(80, 25);
            lblLekovi.TabIndex = 16;
            lblLekovi.Text = "Lekovi";
            // 
            // lblPrimarneGrupe
            // 
            lblPrimarneGrupe.AutoSize = true;
            lblPrimarneGrupe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPrimarneGrupe.ForeColor = Color.FromArgb(33, 37, 41);
            lblPrimarneGrupe.Location = new Point(20, 290);
            lblPrimarneGrupe.Name = "lblPrimarneGrupe";
            lblPrimarneGrupe.Size = new Size(130, 21);
            lblPrimarneGrupe.TabIndex = 17;
            lblPrimarneGrupe.Text = "Primarne grupe";
            // 
            // lblSekundarneGrupe
            // 
            lblSekundarneGrupe.AutoSize = true;
            lblSekundarneGrupe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSekundarneGrupe.ForeColor = Color.FromArgb(33, 37, 41);
            lblSekundarneGrupe.Location = new Point(320, 290);
            lblSekundarneGrupe.Name = "lblSekundarneGrupe";
            lblSekundarneGrupe.Size = new Size(150, 21);
            lblSekundarneGrupe.TabIndex = 18;
            lblSekundarneGrupe.Text = "Sekundarne grupe";
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(255, 255, 255);
            panelButtons.Controls.Add(btnSekundarnaGrupa);
            panelButtons.Controls.Add(btnRecept);
            panelButtons.Controls.Add(btnPrimarnaGrupa);
            panelButtons.Controls.Add(btnOblik);
            panelButtons.Controls.Add(btnObrisiLek);
            panelButtons.Controls.Add(btnIzmeniLek);
            panelButtons.Controls.Add(btnDodajNoviLek);
            panelButtons.Dock = DockStyle.Right;
            panelButtons.Location = new Point(950, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(15);
            panelButtons.Size = new Size(430, 512);
            panelButtons.TabIndex = 1;
            // 
            // btnDodajNoviLek
            // 
            btnDodajNoviLek.BackColor = Color.FromArgb(155, 89, 182);
            btnDodajNoviLek.FlatAppearance.BorderSize = 0;
            btnDodajNoviLek.FlatStyle = FlatStyle.Flat;
            btnDodajNoviLek.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDodajNoviLek.ForeColor = Color.White;
            btnDodajNoviLek.Location = new Point(15, 20);
            btnDodajNoviLek.Name = "btnDodajNoviLek";
            btnDodajNoviLek.Size = new Size(200, 50);
            btnDodajNoviLek.TabIndex = 1;
            btnDodajNoviLek.Text = "➕ Dodaj novi lek";
            btnDodajNoviLek.TextAlign = ContentAlignment.MiddleCenter;
            btnDodajNoviLek.UseVisualStyleBackColor = false;
            btnDodajNoviLek.Click += btnDodajNoviLek_Click;
            btnDodajNoviLek.MouseEnter += Button_MouseEnter;
            btnDodajNoviLek.MouseLeave += Button_MouseLeave;
            // 
            // btnIzmeniLek
            // 
            btnIzmeniLek.BackColor = Color.FromArgb(52, 152, 219);
            btnIzmeniLek.FlatAppearance.BorderSize = 0;
            btnIzmeniLek.FlatStyle = FlatStyle.Flat;
            btnIzmeniLek.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIzmeniLek.ForeColor = Color.White;
            btnIzmeniLek.Location = new Point(15, 85);
            btnIzmeniLek.Name = "btnIzmeniLek";
            btnIzmeniLek.Size = new Size(200, 50);
            btnIzmeniLek.TabIndex = 2;
            btnIzmeniLek.Text = "✏️ Izmeni lek";
            btnIzmeniLek.TextAlign = ContentAlignment.MiddleCenter;
            btnIzmeniLek.UseVisualStyleBackColor = false;
            btnIzmeniLek.Click += btnIzmeniLek_Click;
            btnIzmeniLek.MouseEnter += Button_MouseEnter;
            btnIzmeniLek.MouseLeave += Button_MouseLeave;
            // 
            // btnObrisiLek
            // 
            btnObrisiLek.BackColor = Color.FromArgb(231, 76, 60);
            btnObrisiLek.FlatAppearance.BorderSize = 0;
            btnObrisiLek.FlatStyle = FlatStyle.Flat;
            btnObrisiLek.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnObrisiLek.ForeColor = Color.White;
            btnObrisiLek.Location = new Point(15, 150);
            btnObrisiLek.Name = "btnObrisiLek";
            btnObrisiLek.Size = new Size(200, 50);
            btnObrisiLek.TabIndex = 3;
            btnObrisiLek.Text = "🗑️ Obriši lek";
            btnObrisiLek.TextAlign = ContentAlignment.MiddleCenter;
            btnObrisiLek.UseVisualStyleBackColor = false;
            btnObrisiLek.Click += btnObrisiLek_Click;
            btnObrisiLek.MouseEnter += Button_MouseEnter;
            btnObrisiLek.MouseLeave += Button_MouseLeave;
            // 
            // btnOblik
            // 
            btnOblik.BackColor = Color.FromArgb(46, 204, 113);
            btnOblik.FlatAppearance.BorderSize = 0;
            btnOblik.FlatStyle = FlatStyle.Flat;
            btnOblik.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnOblik.ForeColor = Color.White;
            btnOblik.Location = new Point(15, 280);
            btnOblik.Name = "btnOblik";
            btnOblik.Size = new Size(200, 50);
            btnOblik.TabIndex = 6;
            btnOblik.Text = "💊 Oblik";
            btnOblik.TextAlign = ContentAlignment.MiddleCenter;
            btnOblik.UseVisualStyleBackColor = false;
            btnOblik.Click += btnOblik_Click;
            btnOblik.MouseEnter += Button_MouseEnter;
            btnOblik.MouseLeave += Button_MouseLeave;
            // 
            // btnPrimarnaGrupa
            // 
            btnPrimarnaGrupa.BackColor = Color.FromArgb(230, 126, 34);
            btnPrimarnaGrupa.FlatAppearance.BorderSize = 0;
            btnPrimarnaGrupa.FlatStyle = FlatStyle.Flat;
            btnPrimarnaGrupa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrimarnaGrupa.ForeColor = Color.White;
            btnPrimarnaGrupa.Location = new Point(15, 215);
            btnPrimarnaGrupa.Name = "btnPrimarnaGrupa";
            btnPrimarnaGrupa.Size = new Size(200, 50);
            btnPrimarnaGrupa.TabIndex = 8;
            btnPrimarnaGrupa.Text = "📋 Primarne grupe";
            btnPrimarnaGrupa.TextAlign = ContentAlignment.MiddleCenter;
            btnPrimarnaGrupa.UseVisualStyleBackColor = false;
            btnPrimarnaGrupa.Click += btnPrimarnaGrupa_Click;
            btnPrimarnaGrupa.MouseEnter += Button_MouseEnter;
            btnPrimarnaGrupa.MouseLeave += Button_MouseLeave;
            // 
            // btnRecept
            // 
            btnRecept.BackColor = Color.FromArgb(142, 68, 173);
            btnRecept.FlatAppearance.BorderSize = 0;
            btnRecept.FlatStyle = FlatStyle.Flat;
            btnRecept.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRecept.ForeColor = Color.White;
            btnRecept.Location = new Point(15, 410);
            btnRecept.Name = "btnRecept";
            btnRecept.Size = new Size(200, 50);
            btnRecept.TabIndex = 10;
            btnRecept.Text = "📄 Recept";
            btnRecept.TextAlign = ContentAlignment.MiddleCenter;
            btnRecept.UseVisualStyleBackColor = false;
            btnRecept.Click += btnRecept_Click;
            btnRecept.MouseEnter += Button_MouseEnter;
            btnRecept.MouseLeave += Button_MouseLeave;
            // 
            // btnSekundarnaGrupa
            // 
            btnSekundarnaGrupa.BackColor = Color.FromArgb(241, 196, 15);
            btnSekundarnaGrupa.FlatAppearance.BorderSize = 0;
            btnSekundarnaGrupa.FlatStyle = FlatStyle.Flat;
            btnSekundarnaGrupa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSekundarnaGrupa.ForeColor = Color.White;
            btnSekundarnaGrupa.Location = new Point(15, 345);
            btnSekundarnaGrupa.Name = "btnSekundarnaGrupa";
            btnSekundarnaGrupa.Size = new Size(200, 50);
            btnSekundarnaGrupa.TabIndex = 11;
            btnSekundarnaGrupa.Text = "📊 Sekundarne grupe";
            btnSekundarnaGrupa.TextAlign = ContentAlignment.MiddleCenter;
            btnSekundarnaGrupa.UseVisualStyleBackColor = false;
            btnSekundarnaGrupa.Click += btnSekundarnaGrupa_Click;
            btnSekundarnaGrupa.MouseEnter += Button_MouseEnter;
            btnSekundarnaGrupa.MouseLeave += Button_MouseLeave;
            // 
            // dgvOblik
            // 
            dgvOblik.AllowUserToAddRows = false;
            dgvOblik.AllowUserToDeleteRows = false;
            dgvOblik.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOblik.BackgroundColor = Color.White;
            dgvOblik.BorderStyle = BorderStyle.None;
            dgvOblik.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvOblik.ColumnHeadersHeight = 40;
            dgvOblik.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvOblik.Columns.AddRange(new DataGridViewColumn[] { oblikId, oblikNaziv });
            dgvOblik.GridColor = Color.FromArgb(233, 236, 239);
            dgvOblik.Location = new Point(620, 320);
            dgvOblik.MultiSelect = false;
            dgvOblik.Name = "dgvOblik";
            dgvOblik.ReadOnly = true;
            dgvOblik.RowHeadersVisible = false;
            dgvOblik.RowHeadersWidth = 51;
            dgvOblik.RowTemplate.Height = 35;
            dgvOblik.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOblik.Size = new Size(280, 120);
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
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(33, 37, 41);
            label1.Location = new Point(620, 290);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 19;
            label1.Text = "Oblici";
            label1.Click += label1_Click;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(44, 62, 80);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 672);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1400, 40);
            panelFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 9F);
            lblFooter.ForeColor = Color.FromArgb(189, 195, 199);
            lblFooter.Location = new Point(30, 12);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(350, 15);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Lekovi - Upravljanje lekovima, oblicima, grupama i receptima";
            // 
            // LekAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1400, 712);
            Controls.Add(panelMain);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LekAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farmacy System - Lekovi";
            Load += LekAdminForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvLekovi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrimarneGrupe).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSekundarneGrupe).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOblik).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelButtons.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }
    }
}
