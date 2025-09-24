namespace Farmacy.Forme
{
    partial class ProdajnaJedinicaAdminForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooter;

        private GroupBox groupBoxLista;
        private TabControl tabControlApoteke;
        private TabPage tabOsnovne;
        private TabPage tabSaLab;
        private TabPage tabStandardne;
        private TabPage tabSpecijalizovane;
        private DataGridView dgvOsnovne;
        private DataGridView dgvSaLab;
        private DataGridView dgvStandardne;
        private DataGridView dgvSpecijalizovane;
        private GroupBox grpZaposleni;
        private Button btnZaposleni;
        private GroupBox grpServisi;
        private Button btnRadnoVreme;
        private Button btnZalihe;
        private Button btnProdaja;
        private GroupBox grpPodaci;
        private Button btnIzmeni;
        private Button btnObrisi;
        private Button btnDodaj;

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

        // kolone grida - removed unused columns


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            panelMain = new Panel();
            groupBoxLista = new GroupBox();
            tabControlApoteke = new TabControl();
            tabOsnovne = new TabPage();
            dgvOsnovne = new DataGridView();
            tabSaLab = new TabPage();
            dgvSaLab = new DataGridView();
            tabStandardne = new TabPage();
            dgvStandardne = new DataGridView();
            tabSpecijalizovane = new TabPage();
            dgvSpecijalizovane = new DataGridView();
            panelButtons = new Panel();
            grpZaposleni = new GroupBox();
            btnZaposleni = new Button();
            grpServisi = new GroupBox();
            btnRadnoVreme = new Button();
            btnZalihe = new Button();
            btnProdaja = new Button();
            grpPodaci = new GroupBox();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            btnDodaj = new Button();
            panelFooter = new Panel();
            lblFooter = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOsnovne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaLab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStandardne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSpecijalizovane).BeginInit();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            groupBoxLista.SuspendLayout();
            tabControlApoteke.SuspendLayout();
            tabOsnovne.SuspendLayout();
            tabSaLab.SuspendLayout();
            tabStandardne.SuspendLayout();
            tabSpecijalizovane.SuspendLayout();
            panelButtons.SuspendLayout();
            grpZaposleni.SuspendLayout();
            grpServisi.SuspendLayout();
            grpPodaci.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(46, 204, 113);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1600, 100);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(350, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🏪 PRODAJNE JEDINICE";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(200, 255, 200);
            lblSubtitle.Location = new Point(20, 60);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(500, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Upravljanje prodajnim jedinicama i apotekama";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(panelButtons);
            panelMain.Controls.Add(groupBoxLista);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 100);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(15);
            panelMain.Size = new Size(1600, 860);
            panelMain.TabIndex = 1;
            // 
            // groupBoxLista
            // 
            groupBoxLista.Controls.Add(tabControlApoteke);
            groupBoxLista.Dock = DockStyle.Fill;
            groupBoxLista.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBoxLista.ForeColor = Color.FromArgb(33, 37, 41);
            groupBoxLista.Location = new Point(15, 15);
            groupBoxLista.Name = "groupBoxLista";
            groupBoxLista.Padding = new Padding(15);
            groupBoxLista.Size = new Size(1100, 830);
            groupBoxLista.TabIndex = 0;
            groupBoxLista.TabStop = false;
            groupBoxLista.Text = "Lista apoteka";
            groupBoxLista.Enter += groupBoxLista_Enter;
            // 
            // tabControlApoteke
            // 
            tabControlApoteke.Controls.Add(tabOsnovne);
            tabControlApoteke.Controls.Add(tabSaLab);
            tabControlApoteke.Controls.Add(tabStandardne);
            tabControlApoteke.Controls.Add(tabSpecijalizovane);
            tabControlApoteke.Dock = DockStyle.Fill;
            tabControlApoteke.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tabControlApoteke.Location = new Point(15, 40);
            tabControlApoteke.Name = "tabControlApoteke";
            tabControlApoteke.SelectedIndex = 0;
            tabControlApoteke.Size = new Size(1070, 775);
            tabControlApoteke.TabIndex = 0;
            // 
            // tabOsnovne
            // 
            tabOsnovne.Controls.Add(dgvOsnovne);
            tabOsnovne.Location = new Point(4, 24);
            tabOsnovne.Name = "tabOsnovne";
            tabOsnovne.Padding = new Padding(3);
            tabOsnovne.Size = new Size(1062, 747);
            tabOsnovne.TabIndex = 0;
            tabOsnovne.Text = "🏪 Osnovne";
            tabOsnovne.UseVisualStyleBackColor = true;
            // 
            // dgvOsnovne
            // 
            dgvOsnovne.AllowUserToAddRows = false;
            dgvOsnovne.AllowUserToDeleteRows = false;
            dgvOsnovne.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOsnovne.BackgroundColor = Color.White;
            dgvOsnovne.BorderStyle = BorderStyle.None;
            dgvOsnovne.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvOsnovne.ColumnHeadersHeight = 40;
            dgvOsnovne.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvOsnovne.Dock = DockStyle.Fill;
            dgvOsnovne.GridColor = Color.FromArgb(233, 236, 239);
            dgvOsnovne.Location = new Point(3, 3);
            dgvOsnovne.MultiSelect = false;
            dgvOsnovne.Name = "dgvOsnovne";
            dgvOsnovne.ReadOnly = true;
            dgvOsnovne.RowHeadersVisible = false;
            dgvOsnovne.RowHeadersWidth = 51;
            dgvOsnovne.RowTemplate.Height = 35;
            dgvOsnovne.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOsnovne.Size = new Size(1056, 741);
            dgvOsnovne.TabIndex = 0;
            // 
            // tabSaLab
            // 
            tabSaLab.Controls.Add(dgvSaLab);
            tabSaLab.Location = new Point(4, 24);
            tabSaLab.Name = "tabSaLab";
            tabSaLab.Padding = new Padding(3);
            tabSaLab.Size = new Size(1062, 747);
            tabSaLab.TabIndex = 1;
            tabSaLab.Text = "🧪 Sa Lab";
            tabSaLab.UseVisualStyleBackColor = true;
            // 
            // dgvSaLab
            // 
            dgvSaLab.AllowUserToAddRows = false;
            dgvSaLab.AllowUserToDeleteRows = false;
            dgvSaLab.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSaLab.BackgroundColor = Color.White;
            dgvSaLab.BorderStyle = BorderStyle.None;
            dgvSaLab.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSaLab.ColumnHeadersHeight = 50;
            dgvSaLab.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSaLab.Dock = DockStyle.Fill;
            dgvSaLab.GridColor = Color.FromArgb(233, 236, 239);
            dgvSaLab.Location = new Point(3, 3);
            dgvSaLab.MultiSelect = false;
            dgvSaLab.Name = "dgvSaLab";
            dgvSaLab.ReadOnly = true;
            dgvSaLab.RowHeadersVisible = false;
            dgvSaLab.RowHeadersWidth = 51;
            dgvSaLab.RowTemplate.Height = 45;
            dgvSaLab.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSaLab.Size = new Size(1346, 1210);
            dgvSaLab.TabIndex = 0;
            // 
            // tabStandardne
            // 
            tabStandardne.Controls.Add(dgvStandardne);
            tabStandardne.Location = new Point(4, 24);
            tabStandardne.Name = "tabStandardne";
            tabStandardne.Padding = new Padding(3);
            tabStandardne.Size = new Size(1062, 747);
            tabStandardne.TabIndex = 2;
            tabStandardne.Text = "🏥 Standardne";
            tabStandardne.UseVisualStyleBackColor = true;
            // 
            // dgvStandardne
            // 
            dgvStandardne.AllowUserToAddRows = false;
            dgvStandardne.AllowUserToDeleteRows = false;
            dgvStandardne.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStandardne.BackgroundColor = Color.White;
            dgvStandardne.BorderStyle = BorderStyle.None;
            dgvStandardne.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvStandardne.ColumnHeadersHeight = 50;
            dgvStandardne.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvStandardne.Dock = DockStyle.Fill;
            dgvStandardne.GridColor = Color.FromArgb(233, 236, 239);
            dgvStandardne.Location = new Point(3, 3);
            dgvStandardne.MultiSelect = false;
            dgvStandardne.Name = "dgvStandardne";
            dgvStandardne.ReadOnly = true;
            dgvStandardne.RowHeadersVisible = false;
            dgvStandardne.RowHeadersWidth = 51;
            dgvStandardne.RowTemplate.Height = 45;
            dgvStandardne.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStandardne.Size = new Size(1346, 1210);
            dgvStandardne.TabIndex = 0;
            // 
            // tabSpecijalizovane
            // 
            tabSpecijalizovane.Controls.Add(dgvSpecijalizovane);
            tabSpecijalizovane.Location = new Point(4, 24);
            tabSpecijalizovane.Name = "tabSpecijalizovane";
            tabSpecijalizovane.Padding = new Padding(3);
            tabSpecijalizovane.Size = new Size(1062, 747);
            tabSpecijalizovane.TabIndex = 3;
            tabSpecijalizovane.Text = "⚕️ Specijalizovane";
            tabSpecijalizovane.UseVisualStyleBackColor = true;
            // 
            // dgvSpecijalizovane
            // 
            dgvSpecijalizovane.AllowUserToAddRows = false;
            dgvSpecijalizovane.AllowUserToDeleteRows = false;
            dgvSpecijalizovane.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSpecijalizovane.BackgroundColor = Color.White;
            dgvSpecijalizovane.BorderStyle = BorderStyle.None;
            dgvSpecijalizovane.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSpecijalizovane.ColumnHeadersHeight = 50;
            dgvSpecijalizovane.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSpecijalizovane.Dock = DockStyle.Fill;
            dgvSpecijalizovane.GridColor = Color.FromArgb(233, 236, 239);
            dgvSpecijalizovane.Location = new Point(3, 3);
            dgvSpecijalizovane.MultiSelect = false;
            dgvSpecijalizovane.Name = "dgvSpecijalizovane";
            dgvSpecijalizovane.ReadOnly = true;
            dgvSpecijalizovane.RowHeadersVisible = false;
            dgvSpecijalizovane.RowHeadersWidth = 51;
            dgvSpecijalizovane.RowTemplate.Height = 45;
            dgvSpecijalizovane.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSpecijalizovane.Size = new Size(1346, 1210);
            dgvSpecijalizovane.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(255, 255, 255);
            panelButtons.Controls.Add(grpZaposleni);
            panelButtons.Controls.Add(grpServisi);
            panelButtons.Controls.Add(grpPodaci);
            panelButtons.Dock = DockStyle.Right;
            panelButtons.Location = new Point(1130, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(15);
            panelButtons.Size = new Size(470, 830);
            panelButtons.TabIndex = 1;
            // 
            // grpZaposleni
            // 
            grpZaposleni.Controls.Add(btnZaposleni);
            grpZaposleni.Dock = DockStyle.Top;
            grpZaposleni.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpZaposleni.ForeColor = Color.FromArgb(33, 37, 41);
            grpZaposleni.Location = new Point(15, 600);
            grpZaposleni.Margin = new Padding(0, 15, 0, 0);
            grpZaposleni.Name = "grpZaposleni";
            grpZaposleni.Padding = new Padding(10);
            grpZaposleni.Size = new Size(440, 120);
            grpZaposleni.TabIndex = 0;
            grpZaposleni.TabStop = false;
            grpZaposleni.Text = "👥 Zaposleni";
            // 
            // btnZaposleni
            // 
            btnZaposleni.BackColor = Color.FromArgb(230, 126, 34);
            btnZaposleni.FlatAppearance.BorderSize = 0;
            btnZaposleni.FlatStyle = FlatStyle.Flat;
            btnZaposleni.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnZaposleni.ForeColor = Color.White;
            btnZaposleni.Location = new Point(10, 30);
            btnZaposleni.Name = "btnZaposleni";
            btnZaposleni.Size = new Size(420, 40);
            btnZaposleni.TabIndex = 0;
            btnZaposleni.Text = "👥 Zaposleni";
            btnZaposleni.TextAlign = ContentAlignment.MiddleCenter;
            btnZaposleni.UseVisualStyleBackColor = false;
            btnZaposleni.Click += btnPrikaziZaposlene_Click;
            btnZaposleni.MouseEnter += Button_MouseEnter;
            btnZaposleni.MouseLeave += Button_MouseLeave;
            // 
            // grpServisi
            // 
            grpServisi.Controls.Add(btnRadnoVreme);
            grpServisi.Controls.Add(btnZalihe);
            grpServisi.Controls.Add(btnProdaja);
            grpServisi.Dock = DockStyle.Top;
            grpServisi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpServisi.ForeColor = Color.FromArgb(33, 37, 41);
            grpServisi.Location = new Point(15, 350);
            grpServisi.Margin = new Padding(0, 15, 0, 0);
            grpServisi.Name = "grpServisi";
            grpServisi.Padding = new Padding(10);
            grpServisi.Size = new Size(440, 235);
            grpServisi.TabIndex = 1;
            grpServisi.TabStop = false;
            grpServisi.Text = "🔧 Servisi";
            grpServisi.Enter += grpServisi_Enter;
            // 
            // btnRadnoVreme
            // 
            btnRadnoVreme.BackColor = Color.FromArgb(39, 174, 96);
            btnRadnoVreme.FlatAppearance.BorderSize = 0;
            btnRadnoVreme.FlatStyle = FlatStyle.Flat;
            btnRadnoVreme.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRadnoVreme.ForeColor = Color.White;
            btnRadnoVreme.Location = new Point(15, 150);
            btnRadnoVreme.Name = "btnRadnoVreme";
            btnRadnoVreme.Size = new Size(410, 50);
            btnRadnoVreme.TabIndex = 0;
            btnRadnoVreme.Text = "⏰ Radno vreme";
            btnRadnoVreme.TextAlign = ContentAlignment.MiddleCenter;
            btnRadnoVreme.UseVisualStyleBackColor = false;
            btnRadnoVreme.Click += btnRadnoVreme_Click;
            btnRadnoVreme.MouseEnter += Button_MouseEnter;
            btnRadnoVreme.MouseLeave += Button_MouseLeave;
            // 
            // btnZalihe
            // 
            btnZalihe.BackColor = Color.FromArgb(52, 152, 219);
            btnZalihe.FlatAppearance.BorderSize = 0;
            btnZalihe.FlatStyle = FlatStyle.Flat;
            btnZalihe.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnZalihe.ForeColor = Color.White;
            btnZalihe.Location = new Point(15, 100);
            btnZalihe.Name = "btnZalihe";
            btnZalihe.Size = new Size(410, 50);
            btnZalihe.TabIndex = 1;
            btnZalihe.Text = "📦 Zalihe";
            btnZalihe.TextAlign = ContentAlignment.MiddleCenter;
            btnZalihe.UseVisualStyleBackColor = false;
            btnZalihe.Click += btnZalihe_Click;
            btnZalihe.MouseEnter += Button_MouseEnter;
            btnZalihe.MouseLeave += Button_MouseLeave;
            // 
            // btnProdaja
            // 
            btnProdaja.BackColor = Color.FromArgb(155, 89, 182);
            btnProdaja.FlatAppearance.BorderSize = 0;
            btnProdaja.FlatStyle = FlatStyle.Flat;
            btnProdaja.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnProdaja.ForeColor = Color.White;
            btnProdaja.Location = new Point(15, 50);
            btnProdaja.Name = "btnProdaja";
            btnProdaja.Size = new Size(410, 50);
            btnProdaja.TabIndex = 2;
            btnProdaja.Text = "💰 Prodaja";
            btnProdaja.TextAlign = ContentAlignment.MiddleCenter;
            btnProdaja.UseVisualStyleBackColor = false;
            btnProdaja.Click += btnProdaja_Click;
            btnProdaja.MouseEnter += Button_MouseEnter;
            btnProdaja.MouseLeave += Button_MouseLeave;
            // 
            // grpPodaci
            // 
            grpPodaci.Controls.Add(btnIzmeni);
            grpPodaci.Controls.Add(btnObrisi);
            grpPodaci.Controls.Add(btnDodaj);
            grpPodaci.Dock = DockStyle.Top;
            grpPodaci.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpPodaci.ForeColor = Color.FromArgb(33, 37, 41);
            grpPodaci.Location = new Point(15, 15);
            grpPodaci.Name = "grpPodaci";
            grpPodaci.Padding = new Padding(10);
            grpPodaci.Size = new Size(440, 220);
            grpPodaci.TabIndex = 2;
            grpPodaci.TabStop = false;
            grpPodaci.Text = "📋 Podaci o apoteci";
            // 
            // btnIzmeni
            // 
            btnIzmeni.BackColor = Color.FromArgb(52, 152, 219);
            btnIzmeni.FlatAppearance.BorderSize = 0;
            btnIzmeni.FlatStyle = FlatStyle.Flat;
            btnIzmeni.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnIzmeni.ForeColor = Color.White;
            btnIzmeni.Location = new Point(15, 150);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(410, 50);
            btnIzmeni.TabIndex = 0;
            btnIzmeni.Text = "✏️ Izmeni apoteku";
            btnIzmeni.TextAlign = ContentAlignment.MiddleCenter;
            btnIzmeni.UseVisualStyleBackColor = false;
            btnIzmeni.Click += btnIzmeni_Click;
            btnIzmeni.MouseEnter += Button_MouseEnter;
            btnIzmeni.MouseLeave += Button_MouseLeave;
            // 
            // btnObrisi
            // 
            btnObrisi.BackColor = Color.FromArgb(231, 76, 60);
            btnObrisi.FlatAppearance.BorderSize = 0;
            btnObrisi.FlatStyle = FlatStyle.Flat;
            btnObrisi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnObrisi.ForeColor = Color.White;
            btnObrisi.Location = new Point(15, 100);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(410, 50);
            btnObrisi.TabIndex = 1;
            btnObrisi.Text = "🗑️ Obriši apoteku";
            btnObrisi.TextAlign = ContentAlignment.MiddleCenter;
            btnObrisi.UseVisualStyleBackColor = false;
            btnObrisi.Click += btnObrisi_Click;
            btnObrisi.MouseEnter += Button_MouseEnter;
            btnObrisi.MouseLeave += Button_MouseLeave;
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = Color.FromArgb(46, 204, 113);
            btnDodaj.FlatAppearance.BorderSize = 0;
            btnDodaj.FlatStyle = FlatStyle.Flat;
            btnDodaj.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDodaj.ForeColor = Color.White;
            btnDodaj.Location = new Point(15, 50);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(410, 50);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "➕ Dodaj apoteku";
            btnDodaj.TextAlign = ContentAlignment.MiddleCenter;
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            btnDodaj.MouseEnter += Button_MouseEnter;
            btnDodaj.MouseLeave += Button_MouseLeave;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(44, 62, 80);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 960);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1600, 40);
            panelFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 9F);
            lblFooter.ForeColor = Color.FromArgb(189, 195, 199);
            lblFooter.Location = new Point(30, 12);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(500, 15);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Prodajne jedinice - Upravljanje apotekama, laboratorijama i specijalizovanim apotekama";
            // 
            // ProdajnaJedinicaAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1600, 1000);
            Controls.Add(panelMain);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProdajnaJedinicaAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farmacy System - Prodajne Jedinice";
            Load += ProdajnaJedinicaAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOsnovne).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaLab).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStandardne).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSpecijalizovane).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            groupBoxLista.ResumeLayout(false);
            tabControlApoteke.ResumeLayout(false);
            tabOsnovne.ResumeLayout(false);
            tabSaLab.ResumeLayout(false);
            tabStandardne.ResumeLayout(false);
            tabSpecijalizovane.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            grpZaposleni.ResumeLayout(false);
            grpServisi.ResumeLayout(false);
            grpPodaci.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}