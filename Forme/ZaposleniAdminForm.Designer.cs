namespace Farmacy.Forme
{
    partial class ZaposleniAdminForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dgvZaposleni;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnDodajNovog;
        private System.Windows.Forms.Button btnIzmeniZaposlenog;
        private System.Windows.Forms.Button btnObrisiZaposlenog;
        private System.Windows.Forms.Button btnRasporedRada;
        private System.Windows.Forms.Button btnPrikaziSve;
        private System.Windows.Forms.Button btnPrikaziMenadzere;
        private System.Windows.Forms.Button brnPrikaziTehnicare;
        private System.Windows.Forms.Button brnPrikaziFarmaceute;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooter;

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
            panelHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            panelMain = new Panel();
            dgvZaposleni = new DataGridView();
            panelButtons = new Panel();
            btnDodajNovog = new Button();
            btnIzmeniZaposlenog = new Button();
            btnObrisiZaposlenog = new Button();
            brnPrikaziFarmaceute = new Button();
            brnPrikaziTehnicare = new Button();
            btnPrikaziMenadzere = new Button();
            btnPrikaziSve = new Button();
            btnRasporedRada = new Button();
            panelFooter = new Panel();
            lblFooter = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvZaposleni).BeginInit();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(230, 126, 34);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1700, 120);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(250, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "👥 ZAPOSLENI";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = Color.FromArgb(255, 220, 200);
            lblSubtitle.Location = new Point(30, 75);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(500, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Upravljanje zaposlenima, njihovim radnim vremenom i rasporedima";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(panelButtons);
            panelMain.Controls.Add(dgvZaposleni);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 120);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(30);
            panelMain.Size = new Size(1700, 962);
            panelMain.TabIndex = 1;
            // 
            // dgvZaposleni
            // 
            dgvZaposleni.AllowUserToAddRows = false;
            dgvZaposleni.AllowUserToDeleteRows = false;
            dgvZaposleni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvZaposleni.BackgroundColor = Color.White;
            dgvZaposleni.BorderStyle = BorderStyle.None;
            dgvZaposleni.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvZaposleni.ColumnHeadersHeight = 50;
            dgvZaposleni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvZaposleni.Dock = DockStyle.Fill;
            dgvZaposleni.GridColor = Color.FromArgb(233, 236, 239);
            dgvZaposleni.Location = new Point(30, 30);
            dgvZaposleni.MultiSelect = false;
            dgvZaposleni.Name = "dgvZaposleni";
            dgvZaposleni.ReadOnly = true;
            dgvZaposleni.RowHeadersVisible = false;
            dgvZaposleni.RowHeadersWidth = 51;
            dgvZaposleni.RowTemplate.Height = 45;
            dgvZaposleni.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvZaposleni.Size = new Size(1200, 902);
            dgvZaposleni.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(255, 255, 255);
            panelButtons.Controls.Add(btnRasporedRada);
            panelButtons.Controls.Add(btnPrikaziSve);
            panelButtons.Controls.Add(btnPrikaziMenadzere);
            panelButtons.Controls.Add(brnPrikaziTehnicare);
            panelButtons.Controls.Add(brnPrikaziFarmaceute);
            panelButtons.Controls.Add(btnObrisiZaposlenog);
            panelButtons.Controls.Add(btnIzmeniZaposlenog);
            panelButtons.Controls.Add(btnDodajNovog);
            panelButtons.Dock = DockStyle.Right;
            panelButtons.Location = new Point(1250, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(20);
            panelButtons.Size = new Size(450, 902);
            panelButtons.TabIndex = 1;
            // 
            // btnDodajNovog
            // 
            btnDodajNovog.BackColor = Color.FromArgb(230, 126, 34);
            btnDodajNovog.FlatAppearance.BorderSize = 0;
            btnDodajNovog.FlatStyle = FlatStyle.Flat;
            btnDodajNovog.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDodajNovog.ForeColor = Color.White;
            btnDodajNovog.Location = new Point(20, 20);
            btnDodajNovog.Name = "btnDodajNovog";
            btnDodajNovog.Size = new Size(410, 50);
            btnDodajNovog.TabIndex = 0;
            btnDodajNovog.Text = "➕ Dodaj novog zaposlenog";
            btnDodajNovog.TextAlign = ContentAlignment.MiddleCenter;
            btnDodajNovog.UseVisualStyleBackColor = false;
            btnDodajNovog.Click += btnDodajNovog_Click;
            btnDodajNovog.MouseEnter += Button_MouseEnter;
            btnDodajNovog.MouseLeave += Button_MouseLeave;
            // 
            // btnIzmeniZaposlenog
            // 
            btnIzmeniZaposlenog.BackColor = Color.FromArgb(52, 152, 219);
            btnIzmeniZaposlenog.FlatAppearance.BorderSize = 0;
            btnIzmeniZaposlenog.FlatStyle = FlatStyle.Flat;
            btnIzmeniZaposlenog.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIzmeniZaposlenog.ForeColor = Color.White;
            btnIzmeniZaposlenog.Location = new Point(20, 85);
            btnIzmeniZaposlenog.Name = "btnIzmeniZaposlenog";
            btnIzmeniZaposlenog.Size = new Size(410, 50);
            btnIzmeniZaposlenog.TabIndex = 1;
            btnIzmeniZaposlenog.Text = "✏️ Izmeni zaposlenog";
            btnIzmeniZaposlenog.TextAlign = ContentAlignment.MiddleCenter;
            btnIzmeniZaposlenog.UseVisualStyleBackColor = false;
            btnIzmeniZaposlenog.Click += btnIzmeniZaposlenog_Click;
            btnIzmeniZaposlenog.MouseEnter += Button_MouseEnter;
            btnIzmeniZaposlenog.MouseLeave += Button_MouseLeave;
            // 
            // btnObrisiZaposlenog
            // 
            btnObrisiZaposlenog.BackColor = Color.FromArgb(231, 76, 60);
            btnObrisiZaposlenog.FlatAppearance.BorderSize = 0;
            btnObrisiZaposlenog.FlatStyle = FlatStyle.Flat;
            btnObrisiZaposlenog.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnObrisiZaposlenog.ForeColor = Color.White;
            btnObrisiZaposlenog.Location = new Point(20, 150);
            btnObrisiZaposlenog.Name = "btnObrisiZaposlenog";
            btnObrisiZaposlenog.Size = new Size(410, 50);
            btnObrisiZaposlenog.TabIndex = 2;
            btnObrisiZaposlenog.Text = "🗑️ Obriši zaposlenog";
            btnObrisiZaposlenog.TextAlign = ContentAlignment.MiddleCenter;
            btnObrisiZaposlenog.UseVisualStyleBackColor = false;
            btnObrisiZaposlenog.Click += btnObrisiZaposlenog_Click;
            btnObrisiZaposlenog.MouseEnter += Button_MouseEnter;
            btnObrisiZaposlenog.MouseLeave += Button_MouseLeave;
            // 
            // brnPrikaziFarmaceute
            // 
            brnPrikaziFarmaceute.BackColor = Color.FromArgb(46, 204, 113);
            brnPrikaziFarmaceute.FlatAppearance.BorderSize = 0;
            brnPrikaziFarmaceute.FlatStyle = FlatStyle.Flat;
            brnPrikaziFarmaceute.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            brnPrikaziFarmaceute.ForeColor = Color.White;
            brnPrikaziFarmaceute.Location = new Point(20, 215);
            brnPrikaziFarmaceute.Name = "brnPrikaziFarmaceute";
            brnPrikaziFarmaceute.Size = new Size(410, 50);
            brnPrikaziFarmaceute.TabIndex = 3;
            brnPrikaziFarmaceute.Text = "👨‍⚕️ Prikaži farmaceute";
            brnPrikaziFarmaceute.TextAlign = ContentAlignment.MiddleCenter;
            brnPrikaziFarmaceute.UseVisualStyleBackColor = false;
            brnPrikaziFarmaceute.Click += brnPrikaziFarmaceute_Click;
            brnPrikaziFarmaceute.MouseEnter += Button_MouseEnter;
            brnPrikaziFarmaceute.MouseLeave += Button_MouseLeave;
            // 
            // brnPrikaziTehnicare
            // 
            brnPrikaziTehnicare.BackColor = Color.FromArgb(155, 89, 182);
            brnPrikaziTehnicare.FlatAppearance.BorderSize = 0;
            brnPrikaziTehnicare.FlatStyle = FlatStyle.Flat;
            brnPrikaziTehnicare.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            brnPrikaziTehnicare.ForeColor = Color.White;
            brnPrikaziTehnicare.Location = new Point(20, 280);
            brnPrikaziTehnicare.Name = "brnPrikaziTehnicare";
            brnPrikaziTehnicare.Size = new Size(410, 50);
            brnPrikaziTehnicare.TabIndex = 4;
            brnPrikaziTehnicare.Text = "🔧 Prikaži tehničare";
            brnPrikaziTehnicare.TextAlign = ContentAlignment.MiddleCenter;
            brnPrikaziTehnicare.UseVisualStyleBackColor = false;
            brnPrikaziTehnicare.Click += brnPrikaziTehnicare_Click;
            brnPrikaziTehnicare.MouseEnter += Button_MouseEnter;
            brnPrikaziTehnicare.MouseLeave += Button_MouseLeave;
            // 
            // btnPrikaziMenadzere
            // 
            btnPrikaziMenadzere.BackColor = Color.FromArgb(241, 196, 15);
            btnPrikaziMenadzere.FlatAppearance.BorderSize = 0;
            btnPrikaziMenadzere.FlatStyle = FlatStyle.Flat;
            btnPrikaziMenadzere.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrikaziMenadzere.ForeColor = Color.White;
            btnPrikaziMenadzere.Location = new Point(20, 345);
            btnPrikaziMenadzere.Name = "btnPrikaziMenadzere";
            btnPrikaziMenadzere.Size = new Size(410, 50);
            btnPrikaziMenadzere.TabIndex = 5;
            btnPrikaziMenadzere.Text = "👔 Prikaži menadžere";
            btnPrikaziMenadzere.TextAlign = ContentAlignment.MiddleCenter;
            btnPrikaziMenadzere.UseVisualStyleBackColor = false;
            btnPrikaziMenadzere.Click += btnPrikaziMenadzere_Click;
            btnPrikaziMenadzere.MouseEnter += Button_MouseEnter;
            btnPrikaziMenadzere.MouseLeave += Button_MouseLeave;
            // 
            // btnPrikaziSve
            // 
            btnPrikaziSve.BackColor = Color.FromArgb(142, 68, 173);
            btnPrikaziSve.FlatAppearance.BorderSize = 0;
            btnPrikaziSve.FlatStyle = FlatStyle.Flat;
            btnPrikaziSve.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrikaziSve.ForeColor = Color.White;
            btnPrikaziSve.Location = new Point(20, 410);
            btnPrikaziSve.Name = "btnPrikaziSve";
            btnPrikaziSve.Size = new Size(410, 50);
            btnPrikaziSve.TabIndex = 6;
            btnPrikaziSve.Text = "👥 Prikaži sve";
            btnPrikaziSve.TextAlign = ContentAlignment.MiddleCenter;
            btnPrikaziSve.UseVisualStyleBackColor = false;
            btnPrikaziSve.Click += btnPrikaziSve_Click;
            btnPrikaziSve.MouseEnter += Button_MouseEnter;
            btnPrikaziSve.MouseLeave += Button_MouseLeave;
            // 
            // btnRasporedRada
            // 
            btnRasporedRada.BackColor = Color.FromArgb(39, 174, 96);
            btnRasporedRada.FlatAppearance.BorderSize = 0;
            btnRasporedRada.FlatStyle = FlatStyle.Flat;
            btnRasporedRada.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRasporedRada.ForeColor = Color.White;
            btnRasporedRada.Location = new Point(20, 475);
            btnRasporedRada.Name = "btnRasporedRada";
            btnRasporedRada.Size = new Size(410, 50);
            btnRasporedRada.TabIndex = 0;
            btnRasporedRada.Text = "📅 Raspored rada";
            btnRasporedRada.TextAlign = ContentAlignment.MiddleCenter;
            btnRasporedRada.UseVisualStyleBackColor = false;
            btnRasporedRada.Click += btnRasporedRada_Click;
            btnRasporedRada.MouseEnter += Button_MouseEnter;
            btnRasporedRada.MouseLeave += Button_MouseLeave;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(44, 62, 80);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 1082);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1700, 40);
            panelFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 9F);
            lblFooter.ForeColor = Color.FromArgb(189, 195, 199);
            lblFooter.Location = new Point(30, 12);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(400, 15);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Zaposleni - Upravljanje zaposlenima, radnim vremenom i rasporedima";
            // 
            // ZaposleniAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1700, 1122);
            Controls.Add(panelMain);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ZaposleniAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farmacy System - Zaposleni";
            Load += ZaposleniAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvZaposleni).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colMbr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatumRodj;
    }
}