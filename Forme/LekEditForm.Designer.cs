namespace Farmacy_2.Forme
{
    partial class LekEditForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooter;

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
            lblId = new Label();
            lblHemijski = new Label();
            lblKomercijalni = new Label();
            lblDejstvo = new Label();
            lblProizvodjac = new Label();
            lblPrimarnaGrupa = new Label();
            lblSekundarneKategorije = new Label();
            txtId = new TextBox();
            txtHemijski = new TextBox();
            txtKomercijalni = new TextBox();
            txtDejstvo = new TextBox();
            cmbProizvodjac = new ComboBox();
            cmbPrimarnaGrupa = new ComboBox();
            chkListSekundarneKategorije = new CheckedListBox();
            panelButtons = new Panel();
            btnSacuvaj = new Button();
            btnOtkazi = new Button();
            panelFooter = new Panel();
            lblFooter = new Label();
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
            panelHeader.Size = new Size(800, 100);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "✏️ IZMENI LEK";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(200, 150, 220);
            lblSubtitle.Location = new Point(20, 60);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(400, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Ažuriranje postojećeg leka u sistemu";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(chkListSekundarneKategorije);
            panelMain.Controls.Add(cmbPrimarnaGrupa);
            panelMain.Controls.Add(cmbProizvodjac);
            panelMain.Controls.Add(txtDejstvo);
            panelMain.Controls.Add(txtKomercijalni);
            panelMain.Controls.Add(txtHemijski);
            panelMain.Controls.Add(txtId);
            panelMain.Controls.Add(lblSekundarneKategorije);
            panelMain.Controls.Add(lblPrimarnaGrupa);
            panelMain.Controls.Add(lblProizvodjac);
            panelMain.Controls.Add(lblDejstvo);
            panelMain.Controls.Add(lblKomercijalni);
            panelMain.Controls.Add(lblHemijski);
            panelMain.Controls.Add(lblId);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 100);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(800, 480);
            panelMain.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblId.ForeColor = Color.FromArgb(33, 37, 41);
            lblId.Location = new Point(20, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(30, 19);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblHemijski
            // 
            lblHemijski.AutoSize = true;
            lblHemijski.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHemijski.ForeColor = Color.FromArgb(33, 37, 41);
            lblHemijski.Location = new Point(20, 60);
            lblHemijski.Name = "lblHemijski";
            lblHemijski.Size = new Size(120, 19);
            lblHemijski.TabIndex = 1;
            lblHemijski.Text = "Hemijski naziv:";
            // 
            // lblKomercijalni
            // 
            lblKomercijalni.AutoSize = true;
            lblKomercijalni.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblKomercijalni.ForeColor = Color.FromArgb(33, 37, 41);
            lblKomercijalni.Location = new Point(20, 100);
            lblKomercijalni.Name = "lblKomercijalni";
            lblKomercijalni.Size = new Size(140, 19);
            lblKomercijalni.TabIndex = 2;
            lblKomercijalni.Text = "Komercijalni naziv:";
            // 
            // lblDejstvo
            // 
            lblDejstvo.AutoSize = true;
            lblDejstvo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDejstvo.ForeColor = Color.FromArgb(33, 37, 41);
            lblDejstvo.Location = new Point(20, 140);
            lblDejstvo.Name = "lblDejstvo";
            lblDejstvo.Size = new Size(70, 19);
            lblDejstvo.TabIndex = 3;
            lblDejstvo.Text = "Dejstvo:";
            // 
            // lblProizvodjac
            // 
            lblProizvodjac.AutoSize = true;
            lblProizvodjac.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProizvodjac.ForeColor = Color.FromArgb(33, 37, 41);
            lblProizvodjac.Location = new Point(20, 180);
            lblProizvodjac.Name = "lblProizvodjac";
            lblProizvodjac.Size = new Size(100, 19);
            lblProizvodjac.TabIndex = 4;
            lblProizvodjac.Text = "Proizvođač:";
            // 
            // lblPrimarnaGrupa
            // 
            lblPrimarnaGrupa.AutoSize = true;
            lblPrimarnaGrupa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrimarnaGrupa.ForeColor = Color.FromArgb(33, 37, 41);
            lblPrimarnaGrupa.Location = new Point(20, 220);
            lblPrimarnaGrupa.Name = "lblPrimarnaGrupa";
            lblPrimarnaGrupa.Size = new Size(130, 19);
            lblPrimarnaGrupa.TabIndex = 5;
            lblPrimarnaGrupa.Text = "Primarna grupa:";
            // 
            // lblSekundarneKategorije
            // 
            lblSekundarneKategorije.AutoSize = true;
            lblSekundarneKategorije.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSekundarneKategorije.ForeColor = Color.FromArgb(33, 37, 41);
            lblSekundarneKategorije.Location = new Point(20, 260);
            lblSekundarneKategorije.Name = "lblSekundarneKategorije";
            lblSekundarneKategorije.Size = new Size(180, 19);
            lblSekundarneKategorije.TabIndex = 6;
            lblSekundarneKategorije.Text = "Sekundarne kategorije:";
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(233, 236, 239);
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Font = new Font("Segoe UI", 10F);
            txtId.Location = new Point(200, 20);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(300, 25);
            txtId.TabIndex = 0;
            txtId.TabStop = false;
            // 
            // txtHemijski
            // 
            txtHemijski.BorderStyle = BorderStyle.FixedSingle;
            txtHemijski.Font = new Font("Segoe UI", 10F);
            txtHemijski.Location = new Point(200, 60);
            txtHemijski.Name = "txtHemijski";
            txtHemijski.Size = new Size(300, 25);
            txtHemijski.TabIndex = 1;
            // 
            // txtKomercijalni
            // 
            txtKomercijalni.BorderStyle = BorderStyle.FixedSingle;
            txtKomercijalni.Font = new Font("Segoe UI", 10F);
            txtKomercijalni.Location = new Point(200, 100);
            txtKomercijalni.Name = "txtKomercijalni";
            txtKomercijalni.Size = new Size(300, 25);
            txtKomercijalni.TabIndex = 2;
            // 
            // txtDejstvo
            // 
            txtDejstvo.BorderStyle = BorderStyle.FixedSingle;
            txtDejstvo.Font = new Font("Segoe UI", 10F);
            txtDejstvo.Location = new Point(200, 140);
            txtDejstvo.Name = "txtDejstvo";
            txtDejstvo.Size = new Size(300, 25);
            txtDejstvo.TabIndex = 3;
            // 
            // cmbProizvodjac
            // 
            cmbProizvodjac.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProizvodjac.Font = new Font("Segoe UI", 10F);
            cmbProizvodjac.FormattingEnabled = true;
            cmbProizvodjac.Location = new Point(200, 180);
            cmbProizvodjac.Name = "cmbProizvodjac";
            cmbProizvodjac.Size = new Size(300, 25);
            cmbProizvodjac.TabIndex = 4;
            cmbProizvodjac.SelectedIndexChanged += cmbProizvodjac_SelectedIndexChanged;
            // 
            // cmbPrimarnaGrupa
            // 
            cmbPrimarnaGrupa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPrimarnaGrupa.Font = new Font("Segoe UI", 10F);
            cmbPrimarnaGrupa.FormattingEnabled = true;
            cmbPrimarnaGrupa.Location = new Point(200, 220);
            cmbPrimarnaGrupa.Name = "cmbPrimarnaGrupa";
            cmbPrimarnaGrupa.Size = new Size(300, 25);
            cmbPrimarnaGrupa.TabIndex = 5;
            // 
            // chkListSekundarneKategorije
            // 
            chkListSekundarneKategorije.CheckOnClick = true;
            chkListSekundarneKategorije.Font = new Font("Segoe UI", 10F);
            chkListSekundarneKategorije.FormattingEnabled = true;
            chkListSekundarneKategorije.Location = new Point(200, 260);
            chkListSekundarneKategorije.Name = "chkListSekundarneKategorije";
            chkListSekundarneKategorije.Size = new Size(300, 100);
            chkListSekundarneKategorije.TabIndex = 6;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(255, 255, 255);
            panelButtons.Controls.Add(btnOtkazi);
            panelButtons.Controls.Add(btnSacuvaj);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 580);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(20);
            panelButtons.Size = new Size(800, 80);
            panelButtons.TabIndex = 2;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.BackColor = Color.FromArgb(80, 220, 140);
            btnSacuvaj.FlatAppearance.BorderSize = 0;
            btnSacuvaj.FlatStyle = FlatStyle.Flat;
            btnSacuvaj.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSacuvaj.ForeColor = Color.White;
            btnSacuvaj.Location = new Point(20, 15);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(150, 50);
            btnSacuvaj.TabIndex = 0;
            btnSacuvaj.Text = "💾 Sačuvaj";
            btnSacuvaj.TextAlign = ContentAlignment.MiddleCenter;
            btnSacuvaj.UseVisualStyleBackColor = false;
            btnSacuvaj.Click += btnSave_Click;
            btnSacuvaj.MouseEnter += Button_MouseEnter;
            btnSacuvaj.MouseLeave += Button_MouseLeave;
            // 
            // btnOtkazi
            // 
            btnOtkazi.BackColor = Color.FromArgb(250, 120, 100);
            btnOtkazi.DialogResult = DialogResult.Cancel;
            btnOtkazi.FlatAppearance.BorderSize = 0;
            btnOtkazi.FlatStyle = FlatStyle.Flat;
            btnOtkazi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnOtkazi.ForeColor = Color.White;
            btnOtkazi.Location = new Point(190, 15);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(150, 50);
            btnOtkazi.TabIndex = 1;
            btnOtkazi.Text = "❌ Otkaži";
            btnOtkazi.TextAlign = ContentAlignment.MiddleCenter;
            btnOtkazi.UseVisualStyleBackColor = false;
            btnOtkazi.MouseEnter += Button_MouseEnter;
            btnOtkazi.MouseLeave += Button_MouseLeave;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(44, 62, 80);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 660);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(800, 30);
            panelFooter.TabIndex = 3;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 8F);
            lblFooter.ForeColor = Color.FromArgb(189, 195, 199);
            lblFooter.Location = new Point(20, 8);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(250, 13);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Lekovi - Ažuriranje postojećeg leka u sistemu";
            // 
            // LekEditForm
            // 
            AcceptButton = btnSacuvaj;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnOtkazi;
            ClientSize = new Size(800, 690);
            Controls.Add(panelMain);
            Controls.Add(panelButtons);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LekEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Farmacy System - Izmeni Lek";
            Load += LekEditForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelButtons.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblHemijski;
        private System.Windows.Forms.Label lblKomercijalni;
        private System.Windows.Forms.Label lblDejstvo;
        private System.Windows.Forms.Label lblProizvodjac;
        private System.Windows.Forms.Label lblPrimarnaGrupa;
        private System.Windows.Forms.Label lblSekundarneKategorije;

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtHemijski;
        private System.Windows.Forms.TextBox txtKomercijalni;
        private System.Windows.Forms.TextBox txtDejstvo;
        private System.Windows.Forms.ComboBox cmbProizvodjac;

        private System.Windows.Forms.ComboBox cmbPrimarnaGrupa;
        private System.Windows.Forms.CheckedListBox chkListSekundarneKategorije;

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnOtkazi;
    }
}
