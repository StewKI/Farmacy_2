namespace Farmacy.Forme
{
    partial class ZaposleniAdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxZaposleni = new GroupBox();
            dgvZaposleni = new DataGridView();
            panelDesno = new Panel();
            btnRasporedRada = new Button();
            btnPrikaziSve = new Button();
            btnPrikaziMenadzere = new Button();
            brnPrikaziTehnicare = new Button();
            brnPrikaziFarmaceute = new Button();
            btnObrisiZaposlenog = new Button();
            btnIzmeniZaposlenog = new Button();
            btnDodajNovog = new Button();
            groupBoxZaposleni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvZaposleni).BeginInit();
            panelDesno.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxZaposleni
            // 
            groupBoxZaposleni.Controls.Add(dgvZaposleni);
            groupBoxZaposleni.Dock = DockStyle.Left;
            groupBoxZaposleni.Font = new Font("Segoe UI", 9F);
            groupBoxZaposleni.Location = new Point(0, 0);
            groupBoxZaposleni.Margin = new Padding(6, 6, 6, 6);
            groupBoxZaposleni.Name = "groupBoxZaposleni";
            groupBoxZaposleni.Padding = new Padding(19, 21, 19, 21);
            groupBoxZaposleni.Size = new Size(1244, 1082);
            groupBoxZaposleni.TabIndex = 0;
            groupBoxZaposleni.TabStop = false;
            groupBoxZaposleni.Text = "Zaposleni";
            groupBoxZaposleni.Enter += groupBoxZaposleni_Enter;
            // 
            // dgvZaposleni
            // 
            dgvZaposleni.AllowUserToAddRows = false;
            dgvZaposleni.AllowUserToDeleteRows = false;
            dgvZaposleni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvZaposleni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvZaposleni.Dock = DockStyle.Fill;
            dgvZaposleni.Location = new Point(19, 53);
            dgvZaposleni.Margin = new Padding(6, 6, 6, 6);
            dgvZaposleni.MultiSelect = false;
            dgvZaposleni.Name = "dgvZaposleni";
            dgvZaposleni.ReadOnly = true;
            dgvZaposleni.RowHeadersVisible = false;
            dgvZaposleni.RowHeadersWidth = 82;
            dgvZaposleni.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvZaposleni.Size = new Size(1206, 1008);
            dgvZaposleni.TabIndex = 0;
            // 
            // panelDesno
            // 
            panelDesno.Controls.Add(btnRasporedRada);
            panelDesno.Controls.Add(btnPrikaziSve);
            panelDesno.Controls.Add(btnPrikaziMenadzere);
            panelDesno.Controls.Add(brnPrikaziTehnicare);
            panelDesno.Controls.Add(brnPrikaziFarmaceute);
            panelDesno.Controls.Add(btnObrisiZaposlenog);
            panelDesno.Controls.Add(btnIzmeniZaposlenog);
            panelDesno.Controls.Add(btnDodajNovog);
            panelDesno.Dock = DockStyle.Right;
            panelDesno.Location = new Point(1280, 0);
            panelDesno.Margin = new Padding(6, 6, 6, 6);
            panelDesno.Name = "panelDesno";
            panelDesno.Padding = new Padding(28, 32, 28, 32);
            panelDesno.Size = new Size(427, 1082);
            panelDesno.TabIndex = 1;
            // 
            // btnRasporedRada
            // 
            btnRasporedRada.Dock = DockStyle.Top;
            btnRasporedRada.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRasporedRada.Location = new Point(28, 928);
            btnRasporedRada.Margin = new Padding(0, 21, 0, 0);
            btnRasporedRada.Name = "btnRasporedRada";
            btnRasporedRada.Padding = new Padding(7, 9, 7, 9);
            btnRasporedRada.Size = new Size(371, 128);
            btnRasporedRada.TabIndex = 0;
            btnRasporedRada.Text = "Raspored rada";
            btnRasporedRada.UseVisualStyleBackColor = true;
            btnRasporedRada.Click += btnRasporedRada_Click;
            // 
            // btnPrikaziSve
            // 
            btnPrikaziSve.Dock = DockStyle.Top;
            btnPrikaziSve.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrikaziSve.Location = new Point(28, 800);
            btnPrikaziSve.Margin = new Padding(0, 21, 0, 0);
            btnPrikaziSve.Name = "btnPrikaziSve";
            btnPrikaziSve.Padding = new Padding(7, 9, 7, 9);
            btnPrikaziSve.Size = new Size(371, 128);
            btnPrikaziSve.TabIndex = 6;
            btnPrikaziSve.Text = "Prikazi sve";
            btnPrikaziSve.UseVisualStyleBackColor = true;
            btnPrikaziSve.Click += btnPrikaziSve_Click;
            // 
            // btnPrikaziMenadzere
            // 
            btnPrikaziMenadzere.Dock = DockStyle.Top;
            btnPrikaziMenadzere.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrikaziMenadzere.Location = new Point(28, 672);
            btnPrikaziMenadzere.Margin = new Padding(0, 21, 0, 0);
            btnPrikaziMenadzere.Name = "btnPrikaziMenadzere";
            btnPrikaziMenadzere.Padding = new Padding(7, 9, 7, 9);
            btnPrikaziMenadzere.Size = new Size(371, 128);
            btnPrikaziMenadzere.TabIndex = 5;
            btnPrikaziMenadzere.Text = "Prikazi Menadzere";
            btnPrikaziMenadzere.UseVisualStyleBackColor = true;
            btnPrikaziMenadzere.Click += btnPrikaziMenadzere_Click;
            // 
            // brnPrikaziTehnicare
            // 
            brnPrikaziTehnicare.Dock = DockStyle.Top;
            brnPrikaziTehnicare.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            brnPrikaziTehnicare.Location = new Point(28, 544);
            brnPrikaziTehnicare.Margin = new Padding(0, 21, 0, 0);
            brnPrikaziTehnicare.Name = "brnPrikaziTehnicare";
            brnPrikaziTehnicare.Padding = new Padding(7, 9, 7, 9);
            brnPrikaziTehnicare.Size = new Size(371, 128);
            brnPrikaziTehnicare.TabIndex = 4;
            brnPrikaziTehnicare.Text = "Prikazi tehnicare";
            brnPrikaziTehnicare.UseVisualStyleBackColor = true;
            brnPrikaziTehnicare.Click += brnPrikaziTehnicare_Click;
            // 
            // brnPrikaziFarmaceute
            // 
            brnPrikaziFarmaceute.Dock = DockStyle.Top;
            brnPrikaziFarmaceute.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            brnPrikaziFarmaceute.Location = new Point(28, 416);
            brnPrikaziFarmaceute.Margin = new Padding(0, 21, 0, 0);
            brnPrikaziFarmaceute.Name = "brnPrikaziFarmaceute";
            brnPrikaziFarmaceute.Padding = new Padding(7, 9, 7, 9);
            brnPrikaziFarmaceute.Size = new Size(371, 128);
            brnPrikaziFarmaceute.TabIndex = 3;
            brnPrikaziFarmaceute.Text = "Prikazi farmaceute";
            brnPrikaziFarmaceute.UseVisualStyleBackColor = true;
            brnPrikaziFarmaceute.Click += brnPrikaziFarmaceute_Click;
            // 
            // btnObrisiZaposlenog
            // 
            btnObrisiZaposlenog.Dock = DockStyle.Top;
            btnObrisiZaposlenog.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnObrisiZaposlenog.Location = new Point(28, 288);
            btnObrisiZaposlenog.Margin = new Padding(0, 21, 0, 0);
            btnObrisiZaposlenog.Name = "btnObrisiZaposlenog";
            btnObrisiZaposlenog.Padding = new Padding(7, 9, 7, 9);
            btnObrisiZaposlenog.Size = new Size(371, 128);
            btnObrisiZaposlenog.TabIndex = 2;
            btnObrisiZaposlenog.Text = "Obriši zaposlenog";
            btnObrisiZaposlenog.UseVisualStyleBackColor = true;
            btnObrisiZaposlenog.Click += btnObrisiZaposlenog_Click;
            // 
            // btnIzmeniZaposlenog
            // 
            btnIzmeniZaposlenog.Dock = DockStyle.Top;
            btnIzmeniZaposlenog.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIzmeniZaposlenog.Location = new Point(28, 160);
            btnIzmeniZaposlenog.Margin = new Padding(0, 21, 0, 0);
            btnIzmeniZaposlenog.Name = "btnIzmeniZaposlenog";
            btnIzmeniZaposlenog.Padding = new Padding(7, 9, 7, 9);
            btnIzmeniZaposlenog.Size = new Size(371, 128);
            btnIzmeniZaposlenog.TabIndex = 1;
            btnIzmeniZaposlenog.Text = "Izmeni zaposlenog";
            btnIzmeniZaposlenog.UseVisualStyleBackColor = true;
            btnIzmeniZaposlenog.Click += btnIzmeniZaposlenog_Click;
            // 
            // btnDodajNovog
            // 
            btnDodajNovog.Dock = DockStyle.Top;
            btnDodajNovog.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDodajNovog.Location = new Point(28, 32);
            btnDodajNovog.Margin = new Padding(0, 21, 0, 0);
            btnDodajNovog.Name = "btnDodajNovog";
            btnDodajNovog.Padding = new Padding(7, 9, 7, 9);
            btnDodajNovog.Size = new Size(371, 128);
            btnDodajNovog.TabIndex = 0;
            btnDodajNovog.Text = "Dodaj novog zaposlenog";
            btnDodajNovog.UseVisualStyleBackColor = true;
            btnDodajNovog.Click += btnDodajNovog_Click;
            // 
            // ZaposleniAdminForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 224, 190);
            ClientSize = new Size(1707, 1082);
            Controls.Add(panelDesno);
            Controls.Add(groupBoxZaposleni);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(6, 6, 6, 6);
            MinimumSize = new Size(1686, 986);
            Name = "ZaposleniAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Apoteka";
            Load += ZaposleniAdminForm_Load;
            groupBoxZaposleni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvZaposleni).EndInit();
            panelDesno.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxZaposleni;
        private System.Windows.Forms.DataGridView dgvZaposleni;
        private System.Windows.Forms.Panel panelDesno;
        private System.Windows.Forms.Button btnDodajNovog;
        private System.Windows.Forms.Button btnIzmeniZaposlenog;
        private System.Windows.Forms.Button btnObrisiZaposlenog;
        private System.Windows.Forms.Button btnRasporedRada;

  
        private System.Windows.Forms.DataGridViewTextBoxColumn colMbr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatumRodj;
        private Button btnPrikaziSve;
        private Button btnPrikaziMenadzere;
        private Button brnPrikaziTehnicare;
        private Button brnPrikaziFarmaceute;
    }
}