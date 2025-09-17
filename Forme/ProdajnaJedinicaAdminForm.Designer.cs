namespace Farmacy.Forme
{
    partial class ProdajnaJedinicaAdminForm
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

        private GroupBox groupBoxLista;
        private DataGridView dgvApoteke;
        private Panel panelDesno;
        private GroupBox grpPodaci;
        private Button btnDodaj;
        private Button btnObrisi;
        private Button btnIzmeni;
        private GroupBox grpServisi;
        private Button btnProdaja;
        private Button btnZalihe;
        private Button btnRadnoVreme;

        // kolone grida
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNaziv;
        private DataGridViewTextBoxColumn colUlica;
        private DataGridViewTextBoxColumn colPostanskiBroj;
        private DataGridViewTextBoxColumn colMesto;


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxLista = new GroupBox();
            dgvApoteke = new DataGridView();
            panelDesno = new Panel();
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
            groupBoxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApoteke).BeginInit();
            panelDesno.SuspendLayout();
            grpZaposleni.SuspendLayout();
            grpServisi.SuspendLayout();
            grpPodaci.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxLista
            // 
            groupBoxLista.Controls.Add(dgvApoteke);
            groupBoxLista.Dock = DockStyle.Fill;
            groupBoxLista.Location = new Point(0, 0);
            groupBoxLista.Margin = new Padding(6);
            groupBoxLista.Name = "groupBoxLista";
            groupBoxLista.Padding = new Padding(19, 21, 19, 21);
            groupBoxLista.Size = new Size(1513, 1474);
            groupBoxLista.TabIndex = 0;
            groupBoxLista.TabStop = false;
            groupBoxLista.Text = "Lista apoteka";
            groupBoxLista.Enter += groupBoxLista_Enter;
            // 
            // dgvApoteke
            // 
            dgvApoteke.AllowUserToAddRows = false;
            dgvApoteke.AllowUserToDeleteRows = false;
            dgvApoteke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvApoteke.ColumnHeadersHeight = 46;
            dgvApoteke.Dock = DockStyle.Fill;
            dgvApoteke.Location = new Point(19, 53);
            dgvApoteke.Margin = new Padding(6);
            dgvApoteke.MultiSelect = false;
            dgvApoteke.Name = "dgvApoteke";
            dgvApoteke.ReadOnly = true;
            dgvApoteke.RowHeadersVisible = false;
            dgvApoteke.RowHeadersWidth = 82;
            dgvApoteke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApoteke.Size = new Size(1475, 1400);
            dgvApoteke.TabIndex = 0;
            // 
            // panelDesno
            // 
            panelDesno.BackColor = Color.FromArgb(245, 208, 168);
            panelDesno.Controls.Add(grpZaposleni);
            panelDesno.Controls.Add(grpServisi);
            panelDesno.Controls.Add(grpPodaci);
            panelDesno.Dock = DockStyle.Right;
            panelDesno.Location = new Point(1513, 0);
            panelDesno.Margin = new Padding(6);
            panelDesno.Name = "panelDesno";
            panelDesno.Padding = new Padding(22, 26, 22, 26);
            panelDesno.Size = new Size(594, 1474);
            panelDesno.TabIndex = 1;
            // 
            // grpZaposleni
            // 
            grpZaposleni.Controls.Add(btnZaposleni);
            grpZaposleni.Dock = DockStyle.Top;
            grpZaposleni.Location = new Point(22, 800);
            grpZaposleni.Margin = new Padding(0, 26, 0, 0);
            grpZaposleni.Name = "grpZaposleni";
            grpZaposleni.Padding = new Padding(22, 26, 22, 26);
            grpZaposleni.Size = new Size(550, 563);
            grpZaposleni.TabIndex = 0;
            grpZaposleni.TabStop = false;
            grpZaposleni.Text = "Zaposleni";
            // 
            // btnZaposleni
            // 
            btnZaposleni.Dock = DockStyle.Top;
            btnZaposleni.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnZaposleni.Location = new Point(22, 58);
            btnZaposleni.Margin = new Padding(6);
            btnZaposleni.Name = "btnZaposleni";
            btnZaposleni.Size = new Size(506, 98);
            btnZaposleni.TabIndex = 0;
            btnZaposleni.Text = "Zaposleni";
            btnZaposleni.Click += btnPrikaziZaposlene_Click;
            // 
            // grpServisi
            // 
            grpServisi.Controls.Add(btnRadnoVreme);
            grpServisi.Controls.Add(btnZalihe);
            grpServisi.Controls.Add(btnProdaja);
            grpServisi.Dock = DockStyle.Top;
            grpServisi.Location = new Point(22, 410);
            grpServisi.Margin = new Padding(0, 26, 0, 0);
            grpServisi.Name = "grpServisi";
            grpServisi.Padding = new Padding(22, 26, 22, 26);
            grpServisi.Size = new Size(550, 390);
            grpServisi.TabIndex = 1;
            grpServisi.TabStop = false;
            grpServisi.Text = "Servisi";
            grpServisi.Enter += grpServisi_Enter;
            // 
            // btnRadnoVreme
            // 
            btnRadnoVreme.Dock = DockStyle.Top;
            btnRadnoVreme.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRadnoVreme.Location = new Point(22, 254);
            btnRadnoVreme.Margin = new Padding(6);
            btnRadnoVreme.Name = "btnRadnoVreme";
            btnRadnoVreme.Size = new Size(506, 98);
            btnRadnoVreme.TabIndex = 0;
            btnRadnoVreme.Text = "Radno vreme";
            btnRadnoVreme.Click += btnRadnoVreme_Click;
            // 
            // btnZalihe
            // 
            btnZalihe.Dock = DockStyle.Top;
            btnZalihe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnZalihe.Location = new Point(22, 156);
            btnZalihe.Margin = new Padding(6);
            btnZalihe.Name = "btnZalihe";
            btnZalihe.Size = new Size(506, 98);
            btnZalihe.TabIndex = 1;
            btnZalihe.Text = "Zalihe";
            btnZalihe.Click += btnZalihe_Click;
            // 
            // btnProdaja
            // 
            btnProdaja.Dock = DockStyle.Top;
            btnProdaja.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnProdaja.Location = new Point(22, 58);
            btnProdaja.Margin = new Padding(6);
            btnProdaja.Name = "btnProdaja";
            btnProdaja.Size = new Size(506, 98);
            btnProdaja.TabIndex = 2;
            btnProdaja.Text = "Prodaja";
            btnProdaja.Click += btnProdaja_Click;
            // 
            // grpPodaci
            // 
            grpPodaci.Controls.Add(btnIzmeni);
            grpPodaci.Controls.Add(btnObrisi);
            grpPodaci.Controls.Add(btnDodaj);
            grpPodaci.Dock = DockStyle.Top;
            grpPodaci.Location = new Point(22, 26);
            grpPodaci.Margin = new Padding(6);
            grpPodaci.Name = "grpPodaci";
            grpPodaci.Padding = new Padding(22, 26, 22, 26);
            grpPodaci.Size = new Size(550, 384);
            grpPodaci.TabIndex = 2;
            grpPodaci.TabStop = false;
            grpPodaci.Text = "Podaci o apoteci";
            // 
            // btnIzmeni
            // 
            btnIzmeni.Dock = DockStyle.Top;
            btnIzmeni.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIzmeni.Location = new Point(22, 254);
            btnIzmeni.Margin = new Padding(11, 13, 11, 13);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(506, 98);
            btnIzmeni.TabIndex = 0;
            btnIzmeni.Text = "Izmeni apoteku";
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Dock = DockStyle.Top;
            btnObrisi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnObrisi.Location = new Point(22, 156);
            btnObrisi.Margin = new Padding(11, 13, 11, 13);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(506, 98);
            btnObrisi.TabIndex = 1;
            btnObrisi.Text = "Obriši apoteku";
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.Dock = DockStyle.Top;
            btnDodaj.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDodaj.Location = new Point(22, 58);
            btnDodaj.Margin = new Padding(11, 13, 11, 13);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(506, 98);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj apoteku";
            btnDodaj.Click += btnDodaj_Click;
            // 
            // ProdajnaJedinicaAdminForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 224, 190);
            ClientSize = new Size(2107, 1474);
            Controls.Add(groupBoxLista);
            Controls.Add(panelDesno);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(6);
            MinimumSize = new Size(1798, 1157);
            Name = "ProdajnaJedinicaAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LISTA APOTEKA";
            Load += ProdajnaJedinicaAdminForm_Load;
            groupBoxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvApoteke).EndInit();
            panelDesno.ResumeLayout(false);
            grpZaposleni.ResumeLayout(false);
            grpServisi.ResumeLayout(false);
            grpPodaci.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpZaposleni;
        private Button button2;
        private Button button1;
        private Button btnSuplementi;
        private Button btnZaposleni;
    }
}