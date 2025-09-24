namespace Farmacy_2.Forme
{
    partial class FarmaceutEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Header panel and labels
        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelMain;
        private Panel panelFooter;
        private Label lblFooter;

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
            panelHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            panelMain = new Panel();
            lblMBr = new Label();
            txtMBr = new TextBox();
            lblPrezime = new Label();
            txtPrezime = new TextBox();
            lblIme = new Label();
            txtIme = new TextBox();
            lblDatumRodj = new Label();
            dtpDatumRodj = new DateTimePicker();
            lblAdresa = new Label();
            txtAdresa = new TextBox();
            lblTelefon = new Label();
            txtTelefon = new TextBox();
            lblDatumZaposlenja = new Label();
            dtpDatumZaposlenja = new DateTimePicker();
            lblDatumDiplomiranja = new Label();
            dtpDatumDiplomiranja = new DateTimePicker();
            lblBrLicence = new Label();
            txtBrLicence = new TextBox();
            lblDatumPoslObnoveLicence = new Label();
            dtpDatumPoslObnoveLicence = new DateTimePicker();
            lblSpecijalnost = new Label();
            txtSpecijalnost = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            panelFooter = new Panel();
            lblFooter = new Label();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(52, 152, 219);
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
            lblTitle.Size = new Size(400, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "✏️ IZMENA FARMACEUTA";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(200, 200, 255);
            lblSubtitle.Location = new Point(20, 60);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(400, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Ažuriranje postojećih podataka o farmaceutu";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(btnCancel);
            panelMain.Controls.Add(btnSave);
            panelMain.Controls.Add(txtSpecijalnost);
            panelMain.Controls.Add(lblSpecijalnost);
            panelMain.Controls.Add(dtpDatumPoslObnoveLicence);
            panelMain.Controls.Add(lblDatumPoslObnoveLicence);
            panelMain.Controls.Add(txtBrLicence);
            panelMain.Controls.Add(lblBrLicence);
            panelMain.Controls.Add(dtpDatumDiplomiranja);
            panelMain.Controls.Add(lblDatumDiplomiranja);
            panelMain.Controls.Add(dtpDatumZaposlenja);
            panelMain.Controls.Add(lblDatumZaposlenja);
            panelMain.Controls.Add(txtTelefon);
            panelMain.Controls.Add(lblTelefon);
            panelMain.Controls.Add(txtAdresa);
            panelMain.Controls.Add(lblAdresa);
            panelMain.Controls.Add(dtpDatumRodj);
            panelMain.Controls.Add(lblDatumRodj);
            panelMain.Controls.Add(txtIme);
            panelMain.Controls.Add(lblIme);
            panelMain.Controls.Add(txtPrezime);
            panelMain.Controls.Add(lblPrezime);
            panelMain.Controls.Add(txtMBr);
            panelMain.Controls.Add(lblMBr);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 100);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(30);
            panelMain.Size = new Size(800, 500);
            panelMain.TabIndex = 1;
            // 
            // lblMBr
            // 
            lblMBr.AutoSize = true;
            lblMBr.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMBr.ForeColor = Color.FromArgb(33, 37, 41);
            lblMBr.Location = new Point(30, 30);
            lblMBr.Name = "lblMBr";
            lblMBr.Size = new Size(50, 19);
            lblMBr.TabIndex = 0;
            lblMBr.Text = "M.Br:";
            // 
            // txtMBr
            // 
            txtMBr.BackColor = Color.FromArgb(248, 249, 250);
            txtMBr.BorderStyle = BorderStyle.FixedSingle;
            txtMBr.Font = new Font("Segoe UI", 10F);
            txtMBr.Location = new Point(250, 27);
            txtMBr.Name = "txtMBr";
            txtMBr.ReadOnly = true;
            txtMBr.Size = new Size(300, 25);
            txtMBr.TabIndex = 1;
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrezime.ForeColor = Color.FromArgb(33, 37, 41);
            lblPrezime.Location = new Point(30, 70);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(70, 19);
            lblPrezime.TabIndex = 2;
            lblPrezime.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            txtPrezime.BackColor = Color.White;
            txtPrezime.BorderStyle = BorderStyle.FixedSingle;
            txtPrezime.Font = new Font("Segoe UI", 10F);
            txtPrezime.Location = new Point(250, 67);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(300, 25);
            txtPrezime.TabIndex = 3;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblIme.ForeColor = Color.FromArgb(33, 37, 41);
            lblIme.Location = new Point(30, 110);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(40, 19);
            lblIme.TabIndex = 4;
            lblIme.Text = "Ime:";
            // 
            // txtIme
            // 
            txtIme.BackColor = Color.White;
            txtIme.BorderStyle = BorderStyle.FixedSingle;
            txtIme.Font = new Font("Segoe UI", 10F);
            txtIme.Location = new Point(250, 107);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(300, 25);
            txtIme.TabIndex = 5;
            // 
            // lblDatumRodj
            // 
            lblDatumRodj.AutoSize = true;
            lblDatumRodj.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDatumRodj.ForeColor = Color.FromArgb(33, 37, 41);
            lblDatumRodj.Location = new Point(30, 150);
            lblDatumRodj.Name = "lblDatumRodj";
            lblDatumRodj.Size = new Size(120, 19);
            lblDatumRodj.TabIndex = 6;
            lblDatumRodj.Text = "Datum rođenja:";
            // 
            // dtpDatumRodj
            // 
            dtpDatumRodj.Font = new Font("Segoe UI", 10F);
            dtpDatumRodj.Format = DateTimePickerFormat.Short;
            dtpDatumRodj.Location = new Point(250, 147);
            dtpDatumRodj.Name = "dtpDatumRodj";
            dtpDatumRodj.Size = new Size(300, 25);
            dtpDatumRodj.TabIndex = 7;
            // 
            // lblAdresa
            // 
            lblAdresa.AutoSize = true;
            lblAdresa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAdresa.ForeColor = Color.FromArgb(33, 37, 41);
            lblAdresa.Location = new Point(30, 190);
            lblAdresa.Name = "lblAdresa";
            lblAdresa.Size = new Size(60, 19);
            lblAdresa.TabIndex = 8;
            lblAdresa.Text = "Adresa:";
            // 
            // txtAdresa
            // 
            txtAdresa.BackColor = Color.White;
            txtAdresa.BorderStyle = BorderStyle.FixedSingle;
            txtAdresa.Font = new Font("Segoe UI", 10F);
            txtAdresa.Location = new Point(250, 187);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(300, 25);
            txtAdresa.TabIndex = 9;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTelefon.ForeColor = Color.FromArgb(33, 37, 41);
            lblTelefon.Location = new Point(30, 230);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(65, 19);
            lblTelefon.TabIndex = 10;
            lblTelefon.Text = "Telefon:";
            // 
            // txtTelefon
            // 
            txtTelefon.BackColor = Color.White;
            txtTelefon.BorderStyle = BorderStyle.FixedSingle;
            txtTelefon.Font = new Font("Segoe UI", 10F);
            txtTelefon.Location = new Point(250, 227);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(300, 25);
            txtTelefon.TabIndex = 11;
            // 
            // lblDatumZaposlenja
            // 
            lblDatumZaposlenja.AutoSize = true;
            lblDatumZaposlenja.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDatumZaposlenja.ForeColor = Color.FromArgb(33, 37, 41);
            lblDatumZaposlenja.Location = new Point(30, 270);
            lblDatumZaposlenja.Name = "lblDatumZaposlenja";
            lblDatumZaposlenja.Size = new Size(140, 19);
            lblDatumZaposlenja.TabIndex = 12;
            lblDatumZaposlenja.Text = "Datum zaposlenja:";
            // 
            // dtpDatumZaposlenja
            // 
            dtpDatumZaposlenja.Font = new Font("Segoe UI", 10F);
            dtpDatumZaposlenja.Format = DateTimePickerFormat.Short;
            dtpDatumZaposlenja.Location = new Point(250, 267);
            dtpDatumZaposlenja.Name = "dtpDatumZaposlenja";
            dtpDatumZaposlenja.Size = new Size(300, 25);
            dtpDatumZaposlenja.TabIndex = 13;
            // 
            // lblDatumDiplomiranja
            // 
            lblDatumDiplomiranja.AutoSize = true;
            lblDatumDiplomiranja.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDatumDiplomiranja.ForeColor = Color.FromArgb(33, 37, 41);
            lblDatumDiplomiranja.Location = new Point(30, 310);
            lblDatumDiplomiranja.Name = "lblDatumDiplomiranja";
            lblDatumDiplomiranja.Size = new Size(150, 19);
            lblDatumDiplomiranja.TabIndex = 14;
            lblDatumDiplomiranja.Text = "Datum diplomiranja:";
            // 
            // dtpDatumDiplomiranja
            // 
            dtpDatumDiplomiranja.Font = new Font("Segoe UI", 10F);
            dtpDatumDiplomiranja.Format = DateTimePickerFormat.Short;
            dtpDatumDiplomiranja.Location = new Point(250, 307);
            dtpDatumDiplomiranja.Name = "dtpDatumDiplomiranja";
            dtpDatumDiplomiranja.Size = new Size(300, 25);
            dtpDatumDiplomiranja.TabIndex = 15;
            // 
            // lblBrLicence
            // 
            lblBrLicence.AutoSize = true;
            lblBrLicence.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBrLicence.ForeColor = Color.FromArgb(33, 37, 41);
            lblBrLicence.Location = new Point(30, 350);
            lblBrLicence.Name = "lblBrLicence";
            lblBrLicence.Size = new Size(95, 19);
            lblBrLicence.TabIndex = 16;
            lblBrLicence.Text = "Broj licence:";
            // 
            // txtBrLicence
            // 
            txtBrLicence.BackColor = Color.White;
            txtBrLicence.BorderStyle = BorderStyle.FixedSingle;
            txtBrLicence.Font = new Font("Segoe UI", 10F);
            txtBrLicence.Location = new Point(250, 347);
            txtBrLicence.Name = "txtBrLicence";
            txtBrLicence.Size = new Size(300, 25);
            txtBrLicence.TabIndex = 17;
            // 
            // lblDatumPoslObnoveLicence
            // 
            lblDatumPoslObnoveLicence.AutoSize = true;
            lblDatumPoslObnoveLicence.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDatumPoslObnoveLicence.ForeColor = Color.FromArgb(33, 37, 41);
            lblDatumPoslObnoveLicence.Location = new Point(30, 390);
            lblDatumPoslObnoveLicence.Name = "lblDatumPoslObnoveLicence";
            lblDatumPoslObnoveLicence.Size = new Size(200, 19);
            lblDatumPoslObnoveLicence.TabIndex = 18;
            lblDatumPoslObnoveLicence.Text = "Datum posl. obnove licence:";
            // 
            // dtpDatumPoslObnoveLicence
            // 
            dtpDatumPoslObnoveLicence.Font = new Font("Segoe UI", 10F);
            dtpDatumPoslObnoveLicence.Format = DateTimePickerFormat.Short;
            dtpDatumPoslObnoveLicence.Location = new Point(250, 387);
            dtpDatumPoslObnoveLicence.Name = "dtpDatumPoslObnoveLicence";
            dtpDatumPoslObnoveLicence.Size = new Size(300, 25);
            dtpDatumPoslObnoveLicence.TabIndex = 19;
            // 
            // lblSpecijalnost
            // 
            lblSpecijalnost.AutoSize = true;
            lblSpecijalnost.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSpecijalnost.ForeColor = Color.FromArgb(33, 37, 41);
            lblSpecijalnost.Location = new Point(30, 430);
            lblSpecijalnost.Name = "lblSpecijalnost";
            lblSpecijalnost.Size = new Size(95, 19);
            lblSpecijalnost.TabIndex = 20;
            lblSpecijalnost.Text = "Specijalnost:";
            // 
            // txtSpecijalnost
            // 
            txtSpecijalnost.BackColor = Color.White;
            txtSpecijalnost.BorderStyle = BorderStyle.FixedSingle;
            txtSpecijalnost.Font = new Font("Segoe UI", 10F);
            txtSpecijalnost.Location = new Point(250, 427);
            txtSpecijalnost.Name = "txtSpecijalnost";
            txtSpecijalnost.Size = new Size(300, 25);
            txtSpecijalnost.TabIndex = 21;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(52, 152, 219);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(250, 470);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 45);
            btnSave.TabIndex = 22;
            btnSave.Text = "💾 Sačuvaj";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            btnSave.MouseEnter += Button_MouseEnter;
            btnSave.MouseLeave += Button_MouseLeave;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(410, 470);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 45);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "❌ Otkaži";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            btnCancel.MouseEnter += Button_MouseEnter;
            btnCancel.MouseLeave += Button_MouseLeave;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(44, 62, 80);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 600);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(800, 40);
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
            lblFooter.Text = "Izmena farmaceuta - Upravljanje podacima o farmaceutima u sistemu";
            // 
            // FarmaceutEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 640);
            Controls.Add(panelMain);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FarmaceutEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farmacy System - Izmena Farmaceuta";
            Load += FarmaceutEditForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblMBr;
        private System.Windows.Forms.TextBox txtMBr;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblDatumRodj;
        private System.Windows.Forms.DateTimePicker dtpDatumRodj;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblDatumZaposlenja;
        private System.Windows.Forms.DateTimePicker dtpDatumZaposlenja;
        private System.Windows.Forms.Label lblDatumDiplomiranja;
        private System.Windows.Forms.DateTimePicker dtpDatumDiplomiranja;
        private System.Windows.Forms.Label lblBrLicence;
        private System.Windows.Forms.TextBox txtBrLicence;
        private System.Windows.Forms.Label lblDatumPoslObnoveLicence;
        private System.Windows.Forms.DateTimePicker dtpDatumPoslObnoveLicence;
        private System.Windows.Forms.Label lblSpecijalnost;
        private System.Windows.Forms.TextBox txtSpecijalnost;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
