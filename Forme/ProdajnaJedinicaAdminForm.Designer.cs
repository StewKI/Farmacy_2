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
        private Button btnReceptura;
        private Button btnGalenskiLab;
        private GroupBox grpZaposleni;
        private Button btnZaposleni;

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
            button2 = new Button();
            button1 = new Button();
            btnSuplementi = new Button();
            btnZaposleni = new Button();
            grpServisi = new GroupBox();
            btnGalenskiLab = new Button();
            btnReceptura = new Button();
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
            groupBoxLista.Name = "groupBoxLista";
            groupBoxLista.Padding = new Padding(10);
            groupBoxLista.Size = new Size(720, 610);
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
            dgvApoteke.Dock = DockStyle.Fill;
            dgvApoteke.Location = new Point(10, 26);
            dgvApoteke.MultiSelect = false;
            dgvApoteke.Name = "dgvApoteke";
            dgvApoteke.ReadOnly = true;
            dgvApoteke.RowHeadersVisible = false;
            dgvApoteke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApoteke.Size = new Size(700, 574);
            dgvApoteke.TabIndex = 0;
            // 
            // panelDesno
            // 
            panelDesno.BackColor = Color.FromArgb(245, 208, 168);
            panelDesno.Controls.Add(grpZaposleni);
            panelDesno.Controls.Add(grpServisi);
            panelDesno.Controls.Add(grpPodaci);
            panelDesno.Dock = DockStyle.Right;
            panelDesno.Location = new Point(720, 0);
            panelDesno.Name = "panelDesno";
            panelDesno.Padding = new Padding(12);
            panelDesno.Size = new Size(320, 610);
            panelDesno.TabIndex = 1;
            // 
            // grpZaposleni
            // 
            grpZaposleni.Controls.Add(button2);
            grpZaposleni.Controls.Add(button1);
            grpZaposleni.Controls.Add(btnSuplementi);
            grpZaposleni.Controls.Add(btnZaposleni);
            grpZaposleni.Dock = DockStyle.Top;
            grpZaposleni.Location = new Point(12, 337);
            grpZaposleni.Margin = new Padding(0, 12, 0, 0);
            grpZaposleni.Name = "grpZaposleni";
            grpZaposleni.Padding = new Padding(12);
            grpZaposleni.Size = new Size(296, 264);
            grpZaposleni.TabIndex = 0;
            grpZaposleni.TabStop = false;
            grpZaposleni.Text = "Zaposleni";
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.Location = new Point(12, 166);
            button2.Name = "button2";
            button2.Size = new Size(272, 46);
            button2.TabIndex = 3;
            button2.Text = "Izmeni menadzera";
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(12, 120);
            button1.Name = "button1";
            button1.Size = new Size(272, 46);
            button1.TabIndex = 2;
            button1.Text = "Ukloni menadzera";
            button1.Click += button1_Click;
            // 
            // btnSuplementi
            // 
            btnSuplementi.Dock = DockStyle.Top;
            btnSuplementi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSuplementi.Location = new Point(12, 74);
            btnSuplementi.Name = "btnSuplementi";
            btnSuplementi.Size = new Size(272, 46);
            btnSuplementi.TabIndex = 1;
            btnSuplementi.Text = "Dodaj menadzera";
            btnSuplementi.Click += btnSuplementi_Click;
            // 
            // btnZaposleni
            // 
            btnZaposleni.Dock = DockStyle.Top;
            btnZaposleni.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnZaposleni.Location = new Point(12, 28);
            btnZaposleni.Name = "btnZaposleni";
            btnZaposleni.Size = new Size(272, 46);
            btnZaposleni.TabIndex = 0;
            btnZaposleni.Text = "Zaposleni";
            btnZaposleni.Click += btnZaposleni_Click;
            // 
            // grpServisi
            // 
            grpServisi.Controls.Add(btnGalenskiLab);
            grpServisi.Controls.Add(btnReceptura);
            grpServisi.Dock = DockStyle.Top;
            grpServisi.Location = new Point(12, 192);
            grpServisi.Margin = new Padding(0, 12, 0, 0);
            grpServisi.Name = "grpServisi";
            grpServisi.Padding = new Padding(12);
            grpServisi.Size = new Size(296, 145);
            grpServisi.TabIndex = 1;
            grpServisi.TabStop = false;
            grpServisi.Text = "Servisi";
            // 
            // btnGalenskiLab
            // 
            btnGalenskiLab.Dock = DockStyle.Top;
            btnGalenskiLab.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGalenskiLab.Location = new Point(12, 74);
            btnGalenskiLab.Name = "btnGalenskiLab";
            btnGalenskiLab.Size = new Size(272, 46);
            btnGalenskiLab.TabIndex = 1;
            btnGalenskiLab.Text = "Isporuke";
            // 
            // btnReceptura
            // 
            btnReceptura.Dock = DockStyle.Top;
            btnReceptura.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReceptura.Location = new Point(12, 28);
            btnReceptura.Name = "btnReceptura";
            btnReceptura.Size = new Size(272, 46);
            btnReceptura.TabIndex = 2;
            btnReceptura.Text = "Recepti";
            // 
            // grpPodaci
            // 
            grpPodaci.Controls.Add(btnIzmeni);
            grpPodaci.Controls.Add(btnObrisi);
            grpPodaci.Controls.Add(btnDodaj);
            grpPodaci.Dock = DockStyle.Top;
            grpPodaci.Location = new Point(12, 12);
            grpPodaci.Name = "grpPodaci";
            grpPodaci.Padding = new Padding(12);
            grpPodaci.Size = new Size(296, 180);
            grpPodaci.TabIndex = 2;
            grpPodaci.TabStop = false;
            grpPodaci.Text = "Podaci o apoteci";
            // 
            // btnIzmeni
            // 
            btnIzmeni.Dock = DockStyle.Top;
            btnIzmeni.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIzmeni.Location = new Point(12, 120);
            btnIzmeni.Margin = new Padding(6);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(272, 46);
            btnIzmeni.TabIndex = 0;
            btnIzmeni.Text = "Izmeni apoteku";
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Dock = DockStyle.Top;
            btnObrisi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnObrisi.Location = new Point(12, 74);
            btnObrisi.Margin = new Padding(6);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(272, 46);
            btnObrisi.TabIndex = 1;
            btnObrisi.Text = "Obriši apoteku";
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.Dock = DockStyle.Top;
            btnDodaj.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDodaj.Location = new Point(12, 28);
            btnDodaj.Margin = new Padding(6);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(272, 46);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj apoteku";
            btnDodaj.Click += btnDodaj_Click;
            // 
            // ProdajnaJedinicaAdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 224, 190);
            ClientSize = new Size(1040, 610);
            Controls.Add(groupBoxLista);
            Controls.Add(panelDesno);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(980, 580);
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

        private Button btnSuplementi;
        private Button button2;
        private Button button1;
    }
}