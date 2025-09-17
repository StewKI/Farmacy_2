namespace Farmacy.Forme
{
    partial class ZaposleniZaProdajnuJedinicuForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvZaposleni = new DataGridView();
            btnZavrsiRad = new Button();
            btnRefresh = new Button();
            btnClose = new Button();
            btnDodajZaposlenog = new Button();
            btnPrikaziDetalje = new Button();
            btnIzmeniZaposlenog = new Button();
            btnRasporedRada = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvZaposleni).BeginInit();
            SuspendLayout();
            // 
            // dgvZaposleni
            // 
            dgvZaposleni.AllowUserToAddRows = false;
            dgvZaposleni.AllowUserToDeleteRows = false;
            dgvZaposleni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvZaposleni.Location = new Point(12, 50);
            dgvZaposleni.Name = "dgvZaposleni";
            dgvZaposleni.ReadOnly = true;
            dgvZaposleni.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvZaposleni.Size = new Size(760, 300);
            dgvZaposleni.TabIndex = 0;
            // 
            // btnZavrsiRad
            // 
            btnZavrsiRad.Location = new Point(12, 370);
            btnZavrsiRad.Name = "btnZavrsiRad";
            btnZavrsiRad.Size = new Size(100, 30);
            btnZavrsiRad.TabIndex = 1;
            btnZavrsiRad.Text = "Završi rad";
            btnZavrsiRad.UseVisualStyleBackColor = true;
            btnZavrsiRad.Click += btnZavrsiRad_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(130, 370);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 30);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Osveži";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDodajZaposlenog
            // 
            btnDodajZaposlenog.Location = new Point(250, 370);
            btnDodajZaposlenog.Name = "btnDodajZaposlenog";
            btnDodajZaposlenog.Size = new Size(120, 30);
            btnDodajZaposlenog.TabIndex = 3;
            btnDodajZaposlenog.Text = "Dodaj zaposlenog";
            btnDodajZaposlenog.UseVisualStyleBackColor = true;
            btnDodajZaposlenog.Click += btnDodajZaposlenog_Click;
            // 
            // btnPrikaziDetalje
            // 
            btnPrikaziDetalje.Location = new Point(390, 370);
            btnPrikaziDetalje.Name = "btnPrikaziDetalje";
            btnPrikaziDetalje.Size = new Size(100, 30);
            btnPrikaziDetalje.TabIndex = 4;
            btnPrikaziDetalje.Text = "Detalji";
            btnPrikaziDetalje.UseVisualStyleBackColor = true;
            btnPrikaziDetalje.Click += btnPrikaziDetalje_Click;
            // 
            // btnIzmeniZaposlenog
            // 
            btnIzmeniZaposlenog.Location = new Point(510, 370);
            btnIzmeniZaposlenog.Name = "btnIzmeniZaposlenog";
            btnIzmeniZaposlenog.Size = new Size(100, 30);
            btnIzmeniZaposlenog.TabIndex = 5;
            btnIzmeniZaposlenog.Text = "Izmeni";
            btnIzmeniZaposlenog.UseVisualStyleBackColor = true;
            btnIzmeniZaposlenog.Click += btnIzmeniZaposlenog_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(630, 370);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 30);
            btnClose.TabIndex = 6;
            btnClose.Text = "Zatvori";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnRasporedRada
            // 
            btnRasporedRada.Location = new Point(420, 370);
            btnRasporedRada.Name = "btnRasporedRada";
            btnRasporedRada.Size = new Size(100, 30);
            btnRasporedRada.TabIndex = 7;
            btnRasporedRada.Text = "Raspored rada";
            btnRasporedRada.UseVisualStyleBackColor = true;
            btnRasporedRada.Click += btnRasporedRada_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(200, 21);
            label1.TabIndex = 4;
            label1.Text = "Zaposleni u prodajnoj jedinici";
            // 
            // ZaposleniZaProdajnuJedinicuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 420);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnRasporedRada);
            Controls.Add(btnIzmeniZaposlenog);
            Controls.Add(btnPrikaziDetalje);
            Controls.Add(btnDodajZaposlenog);
            Controls.Add(btnRefresh);
            Controls.Add(btnZavrsiRad);
            Controls.Add(dgvZaposleni);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ZaposleniZaProdajnuJedinicuForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Zaposleni";
            ((System.ComponentModel.ISupportInitialize)dgvZaposleni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvZaposleni;
        private Button btnZavrsiRad;
        private Button btnRefresh;
        private Button btnClose;
        private Button btnDodajZaposlenog;
        private Button btnPrikaziDetalje;
        private Button btnIzmeniZaposlenog;
        private Button btnRasporedRada;
        private Label label1;
    }
}
