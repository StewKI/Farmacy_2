namespace Farmacy.Forme
{
    partial class FarmaceutForm
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
            lblTitle = new Label();
            panelMain = new Panel();
            panelHeader = new Panel();
            panelForm = new Panel();
            panelButtons = new Panel();
            grpLicni = new GroupBox();
            grpProfesionalni = new GroupBox();
            Apoteka = new Label();
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
            panelMain.SuspendLayout();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            panelButtons.SuspendLayout();
            grpLicni.SuspendLayout();
            grpProfesionalni.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(248, 249, 250);
            panelMain.Controls.Add(panelButtons);
            panelMain.Controls.Add(panelForm);
            panelMain.Controls.Add(panelHeader);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(600, 700);
            panelMain.TabIndex = 24;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(20);
            panelHeader.Size = new Size(600, 80);
            panelHeader.TabIndex = 25;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(230, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "💊 Novi farmaceut";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.FromArgb(248, 249, 250);
            panelForm.Controls.Add(grpProfesionalni);
            panelForm.Controls.Add(grpLicni);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 80);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(20);
            panelForm.Size = new Size(600, 540);
            panelForm.TabIndex = 26;
            // 
            // grpLicni
            // 
            grpLicni.BackColor = Color.White;
            grpLicni.Controls.Add(dtpDatumZaposlenja);
            grpLicni.Controls.Add(lblDatumZaposlenja);
            grpLicni.Controls.Add(txtTelefon);
            grpLicni.Controls.Add(lblTelefon);
            grpLicni.Controls.Add(txtAdresa);
            grpLicni.Controls.Add(lblAdresa);
            grpLicni.Controls.Add(dtpDatumRodj);
            grpLicni.Controls.Add(lblDatumRodj);
            grpLicni.Controls.Add(txtIme);
            grpLicni.Controls.Add(lblIme);
            grpLicni.Controls.Add(txtPrezime);
            grpLicni.Controls.Add(lblPrezime);
            grpLicni.Controls.Add(Apoteka);
            grpLicni.Dock = DockStyle.Top;
            grpLicni.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpLicni.ForeColor = Color.FromArgb(33, 37, 41);
            grpLicni.Location = new Point(20, 20);
            grpLicni.Name = "grpLicni";
            grpLicni.Padding = new Padding(15);
            grpLicni.Size = new Size(560, 280);
            grpLicni.TabIndex = 27;
            grpLicni.TabStop = false;
            grpLicni.Text = "👤 Lični podaci";
            // 
            // grpProfesionalni
            // 
            grpProfesionalni.BackColor = Color.White;
            grpProfesionalni.Controls.Add(txtSpecijalnost);
            grpProfesionalni.Controls.Add(lblSpecijalnost);
            grpProfesionalni.Controls.Add(dtpDatumPoslObnoveLicence);
            grpProfesionalni.Controls.Add(lblDatumPoslObnoveLicence);
            grpProfesionalni.Controls.Add(txtBrLicence);
            grpProfesionalni.Controls.Add(lblBrLicence);
            grpProfesionalni.Controls.Add(dtpDatumDiplomiranja);
            grpProfesionalni.Controls.Add(lblDatumDiplomiranja);
            grpProfesionalni.Dock = DockStyle.Top;
            grpProfesionalni.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpProfesionalni.ForeColor = Color.FromArgb(33, 37, 41);
            grpProfesionalni.Location = new Point(20, 300);
            grpProfesionalni.Name = "grpProfesionalni";
            grpProfesionalni.Padding = new Padding(15);
            grpProfesionalni.Size = new Size(560, 220);
            grpProfesionalni.TabIndex = 28;
            grpProfesionalni.TabStop = false;
            grpProfesionalni.Text = "🎓 Profesionalni podaci";
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(248, 249, 250);
            panelButtons.Controls.Add(btnCancel);
            panelButtons.Controls.Add(btnSave);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 620);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(30, 15, 30, 15);
            panelButtons.Size = new Size(600, 80);
            panelButtons.TabIndex = 29;
            // 
            // Apoteka
            // 
            Apoteka.AutoSize = true;
            Apoteka.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Apoteka.ForeColor = Color.FromArgb(108, 117, 125);
            Apoteka.Location = new Point(20, 30);
            Apoteka.Name = "Apoteka";
            Apoteka.Size = new Size(150, 19);
            Apoteka.TabIndex = 0;
            Apoteka.Text = "Osnovne informacije:";
            Apoteka.Click += lblMBr_Click;
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrezime.ForeColor = Color.FromArgb(33, 37, 41);
            lblPrezime.Location = new Point(20, 70);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(62, 19);
            lblPrezime.TabIndex = 2;
            lblPrezime.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            txtPrezime.BackColor = Color.White;
            txtPrezime.BorderStyle = BorderStyle.FixedSingle;
            txtPrezime.Font = new Font("Segoe UI", 10F);
            txtPrezime.Location = new Point(200, 67);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(340, 25);
            txtPrezime.TabIndex = 3;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblIme.ForeColor = Color.FromArgb(33, 37, 41);
            lblIme.Location = new Point(20, 110);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(37, 19);
            lblIme.TabIndex = 4;
            lblIme.Text = "Ime:";
            // 
            // txtIme
            // 
            txtIme.BackColor = Color.White;
            txtIme.BorderStyle = BorderStyle.FixedSingle;
            txtIme.Font = new Font("Segoe UI", 10F);
            txtIme.Location = new Point(200, 107);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(340, 25);
            txtIme.TabIndex = 5;
            // 
            // lblDatumRodj
            // 
            lblDatumRodj.AutoSize = true;
            lblDatumRodj.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDatumRodj.ForeColor = Color.FromArgb(33, 37, 41);
            lblDatumRodj.Location = new Point(20, 150);
            lblDatumRodj.Name = "lblDatumRodj";
            lblDatumRodj.Size = new Size(106, 19);
            lblDatumRodj.TabIndex = 6;
            lblDatumRodj.Text = "Datum rođenja:";
            // 
            // dtpDatumRodj
            // 
            dtpDatumRodj.Font = new Font("Segoe UI", 10F);
            dtpDatumRodj.Format = DateTimePickerFormat.Short;
            dtpDatumRodj.Location = new Point(200, 147);
            dtpDatumRodj.Name = "dtpDatumRodj";
            dtpDatumRodj.Size = new Size(340, 25);
            dtpDatumRodj.TabIndex = 7;
            // 
            // lblAdresa
            // 
            lblAdresa.AutoSize = true;
            lblAdresa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAdresa.ForeColor = Color.FromArgb(33, 37, 41);
            lblAdresa.Location = new Point(20, 190);
            lblAdresa.Name = "lblAdresa";
            lblAdresa.Size = new Size(56, 19);
            lblAdresa.TabIndex = 8;
            lblAdresa.Text = "Adresa:";
            // 
            // txtAdresa
            // 
            txtAdresa.BackColor = Color.White;
            txtAdresa.BorderStyle = BorderStyle.FixedSingle;
            txtAdresa.Font = new Font("Segoe UI", 10F);
            txtAdresa.Location = new Point(200, 187);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(340, 25);
            txtAdresa.TabIndex = 9;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTelefon.ForeColor = Color.FromArgb(33, 37, 41);
            lblTelefon.Location = new Point(20, 230);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(61, 19);
            lblTelefon.TabIndex = 10;
            lblTelefon.Text = "Telefon:";
            // 
            // txtTelefon
            // 
            txtTelefon.BackColor = Color.White;
            txtTelefon.BorderStyle = BorderStyle.FixedSingle;
            txtTelefon.Font = new Font("Segoe UI", 10F);
            txtTelefon.Location = new Point(200, 227);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(340, 25);
            txtTelefon.TabIndex = 11;
            // 
            // lblDatumZaposlenja
            // 
            lblDatumZaposlenja.AutoSize = true;
            lblDatumZaposlenja.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDatumZaposlenja.ForeColor = Color.FromArgb(33, 37, 41);
            lblDatumZaposlenja.Location = new Point(20, 270);
            lblDatumZaposlenja.Name = "lblDatumZaposlenja";
            lblDatumZaposlenja.Size = new Size(125, 19);
            lblDatumZaposlenja.TabIndex = 12;
            lblDatumZaposlenja.Text = "Datum zaposlenja:";
            // 
            // dtpDatumZaposlenja
            // 
            dtpDatumZaposlenja.Font = new Font("Segoe UI", 10F);
            dtpDatumZaposlenja.Format = DateTimePickerFormat.Short;
            dtpDatumZaposlenja.Location = new Point(200, 267);
            dtpDatumZaposlenja.Name = "dtpDatumZaposlenja";
            dtpDatumZaposlenja.Size = new Size(340, 25);
            dtpDatumZaposlenja.TabIndex = 13;
            // 
            // lblDatumDiplomiranja
            // 
            lblDatumDiplomiranja.AutoSize = true;
            lblDatumDiplomiranja.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDatumDiplomiranja.ForeColor = Color.FromArgb(33, 37, 41);
            lblDatumDiplomiranja.Location = new Point(20, 40);
            lblDatumDiplomiranja.Name = "lblDatumDiplomiranja";
            lblDatumDiplomiranja.Size = new Size(139, 19);
            lblDatumDiplomiranja.TabIndex = 14;
            lblDatumDiplomiranja.Text = "Datum diplomiranja:";
            // 
            // dtpDatumDiplomiranja
            // 
            dtpDatumDiplomiranja.Font = new Font("Segoe UI", 10F);
            dtpDatumDiplomiranja.Format = DateTimePickerFormat.Short;
            dtpDatumDiplomiranja.Location = new Point(200, 37);
            dtpDatumDiplomiranja.Name = "dtpDatumDiplomiranja";
            dtpDatumDiplomiranja.Size = new Size(340, 25);
            dtpDatumDiplomiranja.TabIndex = 15;
            // 
            // lblBrLicence
            // 
            lblBrLicence.AutoSize = true;
            lblBrLicence.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBrLicence.ForeColor = Color.FromArgb(33, 37, 41);
            lblBrLicence.Location = new Point(20, 80);
            lblBrLicence.Name = "lblBrLicence";
            lblBrLicence.Size = new Size(86, 19);
            lblBrLicence.TabIndex = 16;
            lblBrLicence.Text = "Broj licence:";
            // 
            // txtBrLicence
            // 
            txtBrLicence.BackColor = Color.White;
            txtBrLicence.BorderStyle = BorderStyle.FixedSingle;
            txtBrLicence.Font = new Font("Segoe UI", 10F);
            txtBrLicence.Location = new Point(200, 77);
            txtBrLicence.Name = "txtBrLicence";
            txtBrLicence.Size = new Size(340, 25);
            txtBrLicence.TabIndex = 17;
            // 
            // lblDatumPoslObnoveLicence
            // 
            lblDatumPoslObnoveLicence.AutoSize = true;
            lblDatumPoslObnoveLicence.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDatumPoslObnoveLicence.ForeColor = Color.FromArgb(33, 37, 41);
            lblDatumPoslObnoveLicence.Location = new Point(20, 120);
            lblDatumPoslObnoveLicence.Name = "lblDatumPoslObnoveLicence";
            lblDatumPoslObnoveLicence.Size = new Size(172, 19);
            lblDatumPoslObnoveLicence.TabIndex = 18;
            lblDatumPoslObnoveLicence.Text = "Poslednja obnova licence:";
            // 
            // dtpDatumPoslObnoveLicence
            // 
            dtpDatumPoslObnoveLicence.Font = new Font("Segoe UI", 10F);
            dtpDatumPoslObnoveLicence.Format = DateTimePickerFormat.Short;
            dtpDatumPoslObnoveLicence.Location = new Point(200, 117);
            dtpDatumPoslObnoveLicence.Name = "dtpDatumPoslObnoveLicence";
            dtpDatumPoslObnoveLicence.Size = new Size(340, 25);
            dtpDatumPoslObnoveLicence.TabIndex = 19;
            // 
            // lblSpecijalnost
            // 
            lblSpecijalnost.AutoSize = true;
            lblSpecijalnost.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSpecijalnost.ForeColor = Color.FromArgb(33, 37, 41);
            lblSpecijalnost.Location = new Point(20, 160);
            lblSpecijalnost.Name = "lblSpecijalnost";
            lblSpecijalnost.Size = new Size(88, 19);
            lblSpecijalnost.TabIndex = 20;
            lblSpecijalnost.Text = "Specijalnost:";
            // 
            // txtSpecijalnost
            // 
            txtSpecijalnost.BackColor = Color.White;
            txtSpecijalnost.BorderStyle = BorderStyle.FixedSingle;
            txtSpecijalnost.Font = new Font("Segoe UI", 10F);
            txtSpecijalnost.Location = new Point(200, 157);
            txtSpecijalnost.Name = "txtSpecijalnost";
            txtSpecijalnost.Size = new Size(340, 25);
            txtSpecijalnost.TabIndex = 21;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(40, 167, 69);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(350, 15);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 50);
            btnSave.TabIndex = 22;
            btnSave.Text = "✓ Sačuvaj";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(108, 117, 125);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(490, 15);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 50);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "✖ Otkaži";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // FarmaceutForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            CancelButton = btnCancel;
            ClientSize = new Size(600, 700);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FarmaceutForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "💊 Dodavanje farmaceuta";
            Load += FarmaceutForm_Load;
            panelMain.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            grpLicni.ResumeLayout(false);
            grpLicni.PerformLayout();
            grpProfesionalni.ResumeLayout(false);
            grpProfesionalni.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.GroupBox grpLicni;
        private System.Windows.Forms.GroupBox grpProfesionalni;
        private System.Windows.Forms.Label Apoteka;
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
