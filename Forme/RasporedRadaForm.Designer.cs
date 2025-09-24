namespace Farmacy.Forme
{
    partial class RasporedRadaForm
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

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            panelMain = new Panel();
            grpRaspored = new GroupBox();
            dgvRaspored = new DataGridView();
            grpActions = new GroupBox();
            btnStampaj = new Button();
            btnExport = new Button();
            btnOcisti = new Button();
            btnZatvori = new Button();
            btnOsvezi = new Button();
            btnObrisi = new Button();
            btnIzmeni = new Button();
            btnDodaj = new Button();
            grpInputControls = new GroupBox();
            btnFiltriraj = new Button();
            cmbProdajnaJedinica = new ComboBox();
            lblProdajnaJedinica = new Label();
            cmbSmena = new ComboBox();
            lblSmena = new Label();
            dtpKraj = new DateTimePicker();
            lblKraj = new Label();
            dtpPocetak = new DateTimePicker();
            lblPocetak = new Label();
            cmbZaposleni = new ComboBox();
            lblZaposleni = new Label();
            panelFooter = new Panel();
            lblFooter = new Label();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            grpRaspored.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRaspored).BeginInit();
            grpActions.SuspendLayout();
            grpInputControls.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(39, 174, 96);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1616, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(449, 59);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📅 RASPORED RADA";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(200, 255, 200);
            lblSubtitle.Location = new Point(20, 45);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(497, 37);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Upravljanje rasporedom rada zaposlenih";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(grpRaspored);
            panelMain.Controls.Add(grpActions);
            panelMain.Controls.Add(grpInputControls);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 80);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(1616, 981);
            panelMain.TabIndex = 1;
            // 
            // grpRaspored
            // 
            grpRaspored.Controls.Add(dgvRaspored);
            grpRaspored.Dock = DockStyle.Fill;
            grpRaspored.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpRaspored.ForeColor = Color.FromArgb(44, 62, 80);
            grpRaspored.Location = new Point(20, 445);
            grpRaspored.Name = "grpRaspored";
            grpRaspored.Padding = new Padding(20);
            grpRaspored.Size = new Size(1576, 516);
            grpRaspored.TabIndex = 2;
            grpRaspored.TabStop = false;
            grpRaspored.Text = "Raspored rada";
            // 
            // dgvRaspored
            // 
            dgvRaspored.AllowUserToAddRows = false;
            dgvRaspored.AllowUserToDeleteRows = false;
            dgvRaspored.BackgroundColor = Color.White;
            dgvRaspored.BorderStyle = BorderStyle.None;
            dgvRaspored.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRaspored.ColumnHeadersHeight = 50;
            dgvRaspored.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRaspored.Dock = DockStyle.Fill;
            dgvRaspored.GridColor = Color.FromArgb(233, 236, 239);
            dgvRaspored.Location = new Point(20, 56);
            dgvRaspored.Name = "dgvRaspored";
            dgvRaspored.ReadOnly = true;
            dgvRaspored.RowHeadersVisible = false;
            dgvRaspored.RowHeadersWidth = 82;
            dgvRaspored.RowTemplate.Height = 35;
            dgvRaspored.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRaspored.Size = new Size(1536, 440);
            dgvRaspored.TabIndex = 12;
            // 
            // grpActions
            // 
            grpActions.Controls.Add(btnStampaj);
            grpActions.Controls.Add(btnExport);
            grpActions.Controls.Add(btnOcisti);
            grpActions.Controls.Add(btnZatvori);
            grpActions.Controls.Add(btnOsvezi);
            grpActions.Controls.Add(btnObrisi);
            grpActions.Controls.Add(btnIzmeni);
            grpActions.Controls.Add(btnDodaj);
            grpActions.Dock = DockStyle.Top;
            grpActions.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpActions.ForeColor = Color.FromArgb(44, 62, 80);
            grpActions.Location = new Point(20, 294);
            grpActions.Name = "grpActions";
            grpActions.Padding = new Padding(20);
            grpActions.Size = new Size(1576, 151);
            grpActions.TabIndex = 1;
            grpActions.TabStop = false;
            grpActions.Text = "Akcije";
            // 
            // btnStampaj
            // 
            btnStampaj.BackColor = Color.FromArgb(230, 126, 34);
            btnStampaj.FlatAppearance.BorderSize = 0;
            btnStampaj.FlatStyle = FlatStyle.Flat;
            btnStampaj.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnStampaj.ForeColor = Color.White;
            btnStampaj.Location = new Point(590, 30);
            btnStampaj.Name = "btnStampaj";
            btnStampaj.Size = new Size(120, 98);
            btnStampaj.TabIndex = 15;
            btnStampaj.Text = "🖨️ Štampaj";
            btnStampaj.UseVisualStyleBackColor = false;
            btnStampaj.Click += btnStampaj_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(155, 89, 182);
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(450, 30);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(120, 98);
            btnExport.TabIndex = 14;
            btnExport.Text = "📤 Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnOcisti
            // 
            btnOcisti.BackColor = Color.FromArgb(149, 165, 166);
            btnOcisti.FlatAppearance.BorderSize = 0;
            btnOcisti.FlatStyle = FlatStyle.Flat;
            btnOcisti.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnOcisti.ForeColor = Color.White;
            btnOcisti.Location = new Point(310, 30);
            btnOcisti.Name = "btnOcisti";
            btnOcisti.Size = new Size(120, 98);
            btnOcisti.TabIndex = 13;
            btnOcisti.Text = "\U0001f9f9 Očisti";
            btnOcisti.UseVisualStyleBackColor = false;
            btnOcisti.Click += btnOcisti_Click;
            // 
            // btnZatvori
            // 
            btnZatvori.BackColor = Color.FromArgb(230, 126, 34);
            btnZatvori.FlatAppearance.BorderSize = 0;
            btnZatvori.FlatStyle = FlatStyle.Flat;
            btnZatvori.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnZatvori.ForeColor = Color.White;
            btnZatvori.Location = new Point(1010, 30);
            btnZatvori.Name = "btnZatvori";
            btnZatvori.Size = new Size(120, 98);
            btnZatvori.TabIndex = 11;
            btnZatvori.Text = "❌ Zatvori";
            btnZatvori.UseVisualStyleBackColor = false;
            btnZatvori.Click += btnZatvori_Click;
            // 
            // btnOsvezi
            // 
            btnOsvezi.BackColor = Color.FromArgb(155, 89, 182);
            btnOsvezi.FlatAppearance.BorderSize = 0;
            btnOsvezi.FlatStyle = FlatStyle.Flat;
            btnOsvezi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnOsvezi.ForeColor = Color.White;
            btnOsvezi.Location = new Point(870, 30);
            btnOsvezi.Name = "btnOsvezi";
            btnOsvezi.Size = new Size(120, 98);
            btnOsvezi.TabIndex = 10;
            btnOsvezi.Text = "🔄 Osveži";
            btnOsvezi.UseVisualStyleBackColor = false;
            btnOsvezi.Click += btnOsvezi_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.BackColor = Color.FromArgb(231, 76, 60);
            btnObrisi.FlatAppearance.BorderSize = 0;
            btnObrisi.FlatStyle = FlatStyle.Flat;
            btnObrisi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnObrisi.ForeColor = Color.White;
            btnObrisi.Location = new Point(730, 30);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(120, 98);
            btnObrisi.TabIndex = 9;
            btnObrisi.Text = "🗑️ Obriši";
            btnObrisi.UseVisualStyleBackColor = false;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.BackColor = Color.FromArgb(52, 152, 219);
            btnIzmeni.FlatAppearance.BorderSize = 0;
            btnIzmeni.FlatStyle = FlatStyle.Flat;
            btnIzmeni.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIzmeni.ForeColor = Color.White;
            btnIzmeni.Location = new Point(170, 30);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(120, 98);
            btnIzmeni.TabIndex = 12;
            btnIzmeni.Text = "✏️ Izmeni";
            btnIzmeni.UseVisualStyleBackColor = false;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = Color.FromArgb(46, 204, 113);
            btnDodaj.FlatAppearance.BorderSize = 0;
            btnDodaj.FlatStyle = FlatStyle.Flat;
            btnDodaj.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDodaj.ForeColor = Color.White;
            btnDodaj.Location = new Point(30, 30);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(120, 98);
            btnDodaj.TabIndex = 8;
            btnDodaj.Text = "➕ Dodaj";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // grpInputControls
            // 
            grpInputControls.Controls.Add(btnFiltriraj);
            grpInputControls.Controls.Add(cmbProdajnaJedinica);
            grpInputControls.Controls.Add(lblProdajnaJedinica);
            grpInputControls.Controls.Add(cmbSmena);
            grpInputControls.Controls.Add(lblSmena);
            grpInputControls.Controls.Add(dtpKraj);
            grpInputControls.Controls.Add(lblKraj);
            grpInputControls.Controls.Add(dtpPocetak);
            grpInputControls.Controls.Add(lblPocetak);
            grpInputControls.Controls.Add(cmbZaposleni);
            grpInputControls.Controls.Add(lblZaposleni);
            grpInputControls.Dock = DockStyle.Top;
            grpInputControls.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpInputControls.ForeColor = Color.FromArgb(44, 62, 80);
            grpInputControls.Location = new Point(20, 20);
            grpInputControls.Name = "grpInputControls";
            grpInputControls.Padding = new Padding(20);
            grpInputControls.Size = new Size(1576, 274);
            grpInputControls.TabIndex = 0;
            grpInputControls.TabStop = false;
            grpInputControls.Text = "Unos podataka o rasporedu rada";
            // 
            // btnFiltriraj
            // 
            btnFiltriraj.BackColor = Color.FromArgb(52, 152, 219);
            btnFiltriraj.FlatAppearance.BorderSize = 0;
            btnFiltriraj.FlatStyle = FlatStyle.Flat;
            btnFiltriraj.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFiltriraj.ForeColor = Color.White;
            btnFiltriraj.Location = new Point(697, 183);
            btnFiltriraj.Name = "btnFiltriraj";
            btnFiltriraj.Size = new Size(120, 35);
            btnFiltriraj.TabIndex = 16;
            btnFiltriraj.Text = "🔍 Filtriraj";
            btnFiltriraj.UseVisualStyleBackColor = false;
            btnFiltriraj.Click += btnFiltriraj_Click;
            // 
            // cmbProdajnaJedinica
            // 
            cmbProdajnaJedinica.BackColor = Color.White;
            cmbProdajnaJedinica.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProdajnaJedinica.FlatStyle = FlatStyle.Flat;
            cmbProdajnaJedinica.Font = new Font("Segoe UI", 10F);
            cmbProdajnaJedinica.FormattingEnabled = true;
            cmbProdajnaJedinica.Location = new Point(807, 90);
            cmbProdajnaJedinica.Name = "cmbProdajnaJedinica";
            cmbProdajnaJedinica.Size = new Size(200, 45);
            cmbProdajnaJedinica.TabIndex = 15;
            // 
            // lblProdajnaJedinica
            // 
            lblProdajnaJedinica.AutoSize = true;
            lblProdajnaJedinica.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProdajnaJedinica.ForeColor = Color.FromArgb(44, 62, 80);
            lblProdajnaJedinica.Location = new Point(496, 93);
            lblProdajnaJedinica.Name = "lblProdajnaJedinica";
            lblProdajnaJedinica.Size = new Size(247, 37);
            lblProdajnaJedinica.TabIndex = 14;
            lblProdajnaJedinica.Text = "Prodajna jedinica:";
            // 
            // cmbSmena
            // 
            cmbSmena.BackColor = Color.White;
            cmbSmena.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSmena.FlatStyle = FlatStyle.Flat;
            cmbSmena.Font = new Font("Segoe UI", 10F);
            cmbSmena.FormattingEnabled = true;
            cmbSmena.Items.AddRange(new object[] { "Prva smena", "Druga smena", "Treća smena" });
            cmbSmena.Location = new Point(807, 30);
            cmbSmena.Name = "cmbSmena";
            cmbSmena.Size = new Size(200, 45);
            cmbSmena.TabIndex = 7;
            // 
            // lblSmena
            // 
            lblSmena.AutoSize = true;
            lblSmena.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSmena.ForeColor = Color.FromArgb(44, 62, 80);
            lblSmena.Location = new Point(496, 38);
            lblSmena.Name = "lblSmena";
            lblSmena.Size = new Size(110, 37);
            lblSmena.TabIndex = 6;
            lblSmena.Text = "Smena:";
            // 
            // dtpKraj
            // 
            dtpKraj.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpKraj.Format = DateTimePickerFormat.Custom;
            dtpKraj.Location = new Point(199, 184);
            dtpKraj.Name = "dtpKraj";
            dtpKraj.Size = new Size(250, 43);
            dtpKraj.TabIndex = 5;
            // 
            // lblKraj
            // 
            lblKraj.AutoSize = true;
            lblKraj.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblKraj.ForeColor = Color.FromArgb(44, 62, 80);
            lblKraj.Location = new Point(30, 189);
            lblKraj.Name = "lblKraj";
            lblKraj.Size = new Size(76, 37);
            lblKraj.TabIndex = 4;
            lblKraj.Text = "Kraj:";
            // 
            // dtpPocetak
            // 
            dtpPocetak.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpPocetak.Format = DateTimePickerFormat.Custom;
            dtpPocetak.Location = new Point(199, 110);
            dtpPocetak.Name = "dtpPocetak";
            dtpPocetak.Size = new Size(250, 43);
            dtpPocetak.TabIndex = 3;
            // 
            // lblPocetak
            // 
            lblPocetak.AutoSize = true;
            lblPocetak.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPocetak.ForeColor = Color.FromArgb(44, 62, 80);
            lblPocetak.Location = new Point(30, 116);
            lblPocetak.Name = "lblPocetak";
            lblPocetak.Size = new Size(127, 37);
            lblPocetak.TabIndex = 2;
            lblPocetak.Text = "Početak:";
            // 
            // cmbZaposleni
            // 
            cmbZaposleni.BackColor = Color.White;
            cmbZaposleni.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbZaposleni.FlatStyle = FlatStyle.Flat;
            cmbZaposleni.Font = new Font("Segoe UI", 10F);
            cmbZaposleni.FormattingEnabled = true;
            cmbZaposleni.Location = new Point(199, 38);
            cmbZaposleni.Name = "cmbZaposleni";
            cmbZaposleni.Size = new Size(250, 45);
            cmbZaposleni.TabIndex = 1;
            // 
            // lblZaposleni
            // 
            lblZaposleni.AutoSize = true;
            lblZaposleni.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblZaposleni.ForeColor = Color.FromArgb(44, 62, 80);
            lblZaposleni.Location = new Point(30, 41);
            lblZaposleni.Name = "lblZaposleni";
            lblZaposleni.Size = new Size(148, 37);
            lblZaposleni.TabIndex = 0;
            lblZaposleni.Text = "Zaposleni:";
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(39, 174, 96);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 1061);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1616, 40);
            panelFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblFooter.ForeColor = Color.White;
            lblFooter.Location = new Point(20, 10);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(475, 32);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Farmacy - Sistem za upravljanje farmacijom";
            // 
            // RasporedRadaForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1616, 1101);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Controls.Add(panelFooter);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RasporedRadaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Raspored rada - Farmacy";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            grpRaspored.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRaspored).EndInit();
            grpActions.ResumeLayout(false);
            grpInputControls.ResumeLayout(false);
            grpInputControls.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelMain;
        private GroupBox grpInputControls;
        private ComboBox cmbSmena;
        private Label lblSmena;
        private DateTimePicker dtpKraj;
        private Label lblKraj;
        private DateTimePicker dtpPocetak;
        private Label lblPocetak;
        private ComboBox cmbZaposleni;
        private Label lblZaposleni;
        private GroupBox grpActions;
        private Button btnZatvori;
        private Button btnOsvezi;
        private Button btnObrisi;
        private Button btnDodaj;
        private GroupBox grpRaspored;
        private DataGridView dgvRaspored;
        private Panel panelFooter;
        private Label lblFooter;
        private Button btnIzmeni;
        private Button btnStampaj;
        private Button btnExport;
        private Button btnOcisti;
        private ComboBox cmbProdajnaJedinica;
        private Label lblProdajnaJedinica;
        private Button btnFiltriraj;
    }
}
