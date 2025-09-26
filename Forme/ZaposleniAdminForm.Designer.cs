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
            lblSubtitle = new Label();
            lblTitle = new Label();
            panelMain = new Panel();
            panelButtons = new Panel();
            btnRasporedRada = new Button();
            btnPrikaziSve = new Button();
            btnPrikaziMenadzere = new Button();
            brnPrikaziTehnicare = new Button();
            brnPrikaziFarmaceute = new Button();
            btnObrisiZaposlenog = new Button();
            btnIzmeniZaposlenog = new Button();
            btnDodajNovog = new Button();
            dgvZaposleni = new DataGridView();
            panelFooter = new Panel();
            lblFooter = new Label();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvZaposleni).BeginInit();
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
            panelHeader.Margin = new Padding(4, 4, 4, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(2125, 150);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = Color.FromArgb(255, 220, 200);
            lblSubtitle.Location = new Point(38, 94);
            lblSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(665, 30);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Upravljanje zaposlenima, njihovim radnim vremenom i rasporedima";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(38, 31);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(367, 65);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "👥 ZAPOSLENI";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(panelButtons);
            panelMain.Controls.Add(dgvZaposleni);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 150);
            panelMain.Margin = new Padding(4, 4, 4, 4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(38, 38, 38, 38);
            panelMain.Size = new Size(2125, 1202);
            panelMain.TabIndex = 1;
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
            panelButtons.Location = new Point(1525, 38);
            panelButtons.Margin = new Padding(4, 4, 4, 4);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(25, 25, 25, 25);
            panelButtons.Size = new Size(562, 1126);
            panelButtons.TabIndex = 1;
            // 
            // btnRasporedRada
            // 
            btnRasporedRada.BackColor = Color.FromArgb(39, 174, 96);
            btnRasporedRada.FlatAppearance.BorderSize = 0;
            btnRasporedRada.FlatStyle = FlatStyle.Flat;
            btnRasporedRada.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRasporedRada.ForeColor = Color.White;
            btnRasporedRada.Location = new Point(25, 594);
            btnRasporedRada.Margin = new Padding(4, 4, 4, 4);
            btnRasporedRada.Name = "btnRasporedRada";
            btnRasporedRada.Size = new Size(512, 62);
            btnRasporedRada.TabIndex = 0;
            btnRasporedRada.Text = "📅 Raspored rada";
            btnRasporedRada.UseVisualStyleBackColor = false;
            btnRasporedRada.Click += btnRasporedRada_Click;
            btnRasporedRada.MouseEnter += Button_MouseEnter;
            btnRasporedRada.MouseLeave += Button_MouseLeave;
            // 
            // btnPrikaziSve
            // 
            btnPrikaziSve.BackColor = Color.FromArgb(142, 68, 173);
            btnPrikaziSve.FlatAppearance.BorderSize = 0;
            btnPrikaziSve.FlatStyle = FlatStyle.Flat;
            btnPrikaziSve.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrikaziSve.ForeColor = Color.White;
            btnPrikaziSve.Location = new Point(25, 512);
            btnPrikaziSve.Margin = new Padding(4, 4, 4, 4);
            btnPrikaziSve.Name = "btnPrikaziSve";
            btnPrikaziSve.Size = new Size(512, 62);
            btnPrikaziSve.TabIndex = 6;
            btnPrikaziSve.Text = "👥 Prikaži sve";
            btnPrikaziSve.UseVisualStyleBackColor = false;
            btnPrikaziSve.Click += btnPrikaziSve_Click;
            btnPrikaziSve.MouseEnter += Button_MouseEnter;
            btnPrikaziSve.MouseLeave += Button_MouseLeave;
            // 
            // btnPrikaziMenadzere
            // 
            btnPrikaziMenadzere.BackColor = Color.FromArgb(241, 196, 15);
            btnPrikaziMenadzere.FlatAppearance.BorderSize = 0;
            btnPrikaziMenadzere.FlatStyle = FlatStyle.Flat;
            btnPrikaziMenadzere.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrikaziMenadzere.ForeColor = Color.White;
            btnPrikaziMenadzere.Location = new Point(25, 431);
            btnPrikaziMenadzere.Margin = new Padding(4, 4, 4, 4);
            btnPrikaziMenadzere.Name = "btnPrikaziMenadzere";
            btnPrikaziMenadzere.Size = new Size(512, 62);
            btnPrikaziMenadzere.TabIndex = 5;
            btnPrikaziMenadzere.Text = "👔 Prikaži menadžere";
            btnPrikaziMenadzere.UseVisualStyleBackColor = false;
            btnPrikaziMenadzere.Click += btnPrikaziMenadzere_Click;
            btnPrikaziMenadzere.MouseEnter += Button_MouseEnter;
            btnPrikaziMenadzere.MouseLeave += Button_MouseLeave;
            // 
            // brnPrikaziTehnicare
            // 
            brnPrikaziTehnicare.BackColor = Color.FromArgb(155, 89, 182);
            brnPrikaziTehnicare.FlatAppearance.BorderSize = 0;
            brnPrikaziTehnicare.FlatStyle = FlatStyle.Flat;
            brnPrikaziTehnicare.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            brnPrikaziTehnicare.ForeColor = Color.White;
            brnPrikaziTehnicare.Location = new Point(25, 350);
            brnPrikaziTehnicare.Margin = new Padding(4, 4, 4, 4);
            brnPrikaziTehnicare.Name = "brnPrikaziTehnicare";
            brnPrikaziTehnicare.Size = new Size(512, 62);
            brnPrikaziTehnicare.TabIndex = 4;
            brnPrikaziTehnicare.Text = "🔧 Prikaži tehničare";
            brnPrikaziTehnicare.UseVisualStyleBackColor = false;
            brnPrikaziTehnicare.Click += brnPrikaziTehnicare_Click;
            brnPrikaziTehnicare.MouseEnter += Button_MouseEnter;
            brnPrikaziTehnicare.MouseLeave += Button_MouseLeave;
            // 
            // brnPrikaziFarmaceute
            // 
            brnPrikaziFarmaceute.BackColor = Color.FromArgb(46, 204, 113);
            brnPrikaziFarmaceute.FlatAppearance.BorderSize = 0;
            brnPrikaziFarmaceute.FlatStyle = FlatStyle.Flat;
            brnPrikaziFarmaceute.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            brnPrikaziFarmaceute.ForeColor = Color.White;
            brnPrikaziFarmaceute.Location = new Point(25, 269);
            brnPrikaziFarmaceute.Margin = new Padding(4, 4, 4, 4);
            brnPrikaziFarmaceute.Name = "brnPrikaziFarmaceute";
            brnPrikaziFarmaceute.Size = new Size(512, 62);
            brnPrikaziFarmaceute.TabIndex = 3;
            brnPrikaziFarmaceute.Text = "👨‍⚕️ Prikaži farmaceute";
            brnPrikaziFarmaceute.UseVisualStyleBackColor = false;
            brnPrikaziFarmaceute.Click += brnPrikaziFarmaceute_Click;
            brnPrikaziFarmaceute.MouseEnter += Button_MouseEnter;
            brnPrikaziFarmaceute.MouseLeave += Button_MouseLeave;
            // 
            // btnObrisiZaposlenog
            // 
            btnObrisiZaposlenog.BackColor = Color.FromArgb(231, 76, 60);
            btnObrisiZaposlenog.FlatAppearance.BorderSize = 0;
            btnObrisiZaposlenog.FlatStyle = FlatStyle.Flat;
            btnObrisiZaposlenog.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnObrisiZaposlenog.ForeColor = Color.White;
            btnObrisiZaposlenog.Location = new Point(25, 188);
            btnObrisiZaposlenog.Margin = new Padding(4, 4, 4, 4);
            btnObrisiZaposlenog.Name = "btnObrisiZaposlenog";
            btnObrisiZaposlenog.Size = new Size(512, 62);
            btnObrisiZaposlenog.TabIndex = 2;
            btnObrisiZaposlenog.Text = "🗑️ Obriši zaposlenog";
            btnObrisiZaposlenog.UseVisualStyleBackColor = false;
            btnObrisiZaposlenog.Click += btnObrisiZaposlenog_Click;
            btnObrisiZaposlenog.MouseEnter += Button_MouseEnter;
            btnObrisiZaposlenog.MouseLeave += Button_MouseLeave;
            // 
            // btnIzmeniZaposlenog
            // 
            btnIzmeniZaposlenog.BackColor = Color.FromArgb(52, 152, 219);
            btnIzmeniZaposlenog.FlatAppearance.BorderSize = 0;
            btnIzmeniZaposlenog.FlatStyle = FlatStyle.Flat;
            btnIzmeniZaposlenog.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIzmeniZaposlenog.ForeColor = Color.White;
            btnIzmeniZaposlenog.Location = new Point(25, 106);
            btnIzmeniZaposlenog.Margin = new Padding(4, 4, 4, 4);
            btnIzmeniZaposlenog.Name = "btnIzmeniZaposlenog";
            btnIzmeniZaposlenog.Size = new Size(512, 62);
            btnIzmeniZaposlenog.TabIndex = 1;
            btnIzmeniZaposlenog.Text = "✏️ Izmeni zaposlenog";
            btnIzmeniZaposlenog.UseVisualStyleBackColor = false;
            btnIzmeniZaposlenog.Click += btnIzmeniZaposlenog_Click;
            btnIzmeniZaposlenog.MouseEnter += Button_MouseEnter;
            btnIzmeniZaposlenog.MouseLeave += Button_MouseLeave;
            // 
            // btnDodajNovog
            // 
            btnDodajNovog.BackColor = Color.FromArgb(230, 126, 34);
            btnDodajNovog.FlatAppearance.BorderSize = 0;
            btnDodajNovog.FlatStyle = FlatStyle.Flat;
            btnDodajNovog.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDodajNovog.ForeColor = Color.White;
            btnDodajNovog.Location = new Point(25, 25);
            btnDodajNovog.Margin = new Padding(4, 4, 4, 4);
            btnDodajNovog.Name = "btnDodajNovog";
            btnDodajNovog.Size = new Size(512, 62);
            btnDodajNovog.TabIndex = 0;
            btnDodajNovog.Text = "➕ Dodaj novog zaposlenog";
            btnDodajNovog.UseVisualStyleBackColor = false;
            btnDodajNovog.Click += btnDodajNovog_Click;
            btnDodajNovog.MouseEnter += Button_MouseEnter;
            btnDodajNovog.MouseLeave += Button_MouseLeave;
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
            dgvZaposleni.Location = new Point(38, 38);
            dgvZaposleni.Margin = new Padding(4, 4, 4, 4);
            dgvZaposleni.MultiSelect = false;
            dgvZaposleni.Name = "dgvZaposleni";
            dgvZaposleni.ReadOnly = true;
            dgvZaposleni.RowHeadersVisible = false;
            dgvZaposleni.RowHeadersWidth = 51;
            dgvZaposleni.RowTemplate.Height = 45;
            dgvZaposleni.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvZaposleni.Size = new Size(2049, 1126);
            dgvZaposleni.TabIndex = 0;
            dgvZaposleni.CellContentClick += dgvZaposleni_CellContentClick;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(44, 62, 80);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 1352);
            panelFooter.Margin = new Padding(4, 4, 4, 4);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(2125, 50);
            panelFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 9F);
            lblFooter.ForeColor = Color.FromArgb(189, 195, 199);
            lblFooter.Location = new Point(38, 15);
            lblFooter.Margin = new Padding(4, 0, 4, 0);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(566, 25);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Zaposleni - Upravljanje zaposlenima, radnim vremenom i rasporedima";
            // 
            // ZaposleniAdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2125, 1402);
            Controls.Add(panelMain);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "ZaposleniAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farmacy System - Zaposleni";
            Load += ZaposleniAdminForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvZaposleni).EndInit();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // removed unused column fields
    }
}