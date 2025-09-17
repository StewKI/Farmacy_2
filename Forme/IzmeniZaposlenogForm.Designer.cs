namespace Farmacy.Forme
{
    partial class IzmeniZaposlenogForm
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
            txtIme = new TextBox();
            txtPrezime = new TextBox();
            dtpDatumRodj = new DateTimePicker();
            txtAdresa = new TextBox();
            txtTelefon = new TextBox();
            dtpDatumZaposlenja = new DateTimePicker();
            pnlFarmaceut = new Panel();
            txtSpecijalnost = new TextBox();
            txtBrLicence = new TextBox();
            dtpDatumDiplomiranja = new DateTimePicker();
            dtpDatumPoslObnoveLicence = new DateTimePicker();
            lblSpecijalnost = new Label();
            lblBrLicence = new Label();
            lblDatumDiplomiranja = new Label();
            lblDatumPoslObnoveLicence = new Label();
            pnlTehnicar = new Panel();
            cmbNivo = new ComboBox();
            lblNivoObrazovanja = new Label();
            pnlMenadzer = new Panel();
            lblIme = new Label();
            lblPrezime = new Label();
            lblDatumRodj = new Label();
            lblAdresa = new Label();
            lblTelefon = new Label();
            lblDatumZaposlenja = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            pnlFarmaceut.SuspendLayout();
            pnlTehnicar.SuspendLayout();
            pnlMenadzer.SuspendLayout();
            SuspendLayout();
            // 
            // txtIme
            // 
            txtIme.Location = new Point(150, 20);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(200, 23);
            txtIme.TabIndex = 0;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(150, 50);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(200, 23);
            txtPrezime.TabIndex = 1;
            // 
            // dtpDatumRodj
            // 
            dtpDatumRodj.Location = new Point(150, 80);
            dtpDatumRodj.Name = "dtpDatumRodj";
            dtpDatumRodj.Size = new Size(200, 23);
            dtpDatumRodj.TabIndex = 2;
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new Point(150, 110);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(200, 23);
            txtAdresa.TabIndex = 3;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(150, 140);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(200, 23);
            txtTelefon.TabIndex = 4;
            // 
            // dtpDatumZaposlenja
            // 
            dtpDatumZaposlenja.Location = new Point(150, 170);
            dtpDatumZaposlenja.Name = "dtpDatumZaposlenja";
            dtpDatumZaposlenja.Size = new Size(200, 23);
            dtpDatumZaposlenja.TabIndex = 5;
            // 
            // pnlFarmaceut
            // 
            pnlFarmaceut.Controls.Add(txtSpecijalnost);
            pnlFarmaceut.Controls.Add(txtBrLicence);
            pnlFarmaceut.Controls.Add(dtpDatumDiplomiranja);
            pnlFarmaceut.Controls.Add(dtpDatumPoslObnoveLicence);
            pnlFarmaceut.Controls.Add(lblSpecijalnost);
            pnlFarmaceut.Controls.Add(lblBrLicence);
            pnlFarmaceut.Controls.Add(lblDatumDiplomiranja);
            pnlFarmaceut.Controls.Add(lblDatumPoslObnoveLicence);
            pnlFarmaceut.Location = new Point(20, 220);
            pnlFarmaceut.Name = "pnlFarmaceut";
            pnlFarmaceut.Size = new Size(500, 150);
            pnlFarmaceut.TabIndex = 6;
            // 
            // txtSpecijalnost
            // 
            txtSpecijalnost.Location = new Point(150, 10);
            txtSpecijalnost.Name = "txtSpecijalnost";
            txtSpecijalnost.Size = new Size(200, 23);
            txtSpecijalnost.TabIndex = 0;
            // 
            // txtBrLicence
            // 
            txtBrLicence.Location = new Point(150, 40);
            txtBrLicence.Name = "txtBrLicence";
            txtBrLicence.Size = new Size(200, 23);
            txtBrLicence.TabIndex = 1;
            // 
            // dtpDatumDiplomiranja
            // 
            dtpDatumDiplomiranja.Location = new Point(150, 70);
            dtpDatumDiplomiranja.Name = "dtpDatumDiplomiranja";
            dtpDatumDiplomiranja.Size = new Size(200, 23);
            dtpDatumDiplomiranja.TabIndex = 2;
            // 
            // dtpDatumPoslObnoveLicence
            // 
            dtpDatumPoslObnoveLicence.Location = new Point(150, 100);
            dtpDatumPoslObnoveLicence.Name = "dtpDatumPoslObnoveLicence";
            dtpDatumPoslObnoveLicence.Size = new Size(200, 23);
            dtpDatumPoslObnoveLicence.TabIndex = 3;
            // 
            // lblSpecijalnost
            // 
            lblSpecijalnost.AutoSize = true;
            lblSpecijalnost.Location = new Point(10, 13);
            lblSpecijalnost.Name = "lblSpecijalnost";
            lblSpecijalnost.Size = new Size(70, 15);
            lblSpecijalnost.TabIndex = 4;
            lblSpecijalnost.Text = "Specijalnost:";
            // 
            // lblBrLicence
            // 
            lblBrLicence.AutoSize = true;
            lblBrLicence.Location = new Point(10, 43);
            lblBrLicence.Name = "lblBrLicence";
            lblBrLicence.Size = new Size(70, 15);
            lblBrLicence.TabIndex = 5;
            lblBrLicence.Text = "Broj licence:";
            // 
            // lblDatumDiplomiranja
            // 
            lblDatumDiplomiranja.AutoSize = true;
            lblDatumDiplomiranja.Location = new Point(10, 73);
            lblDatumDiplomiranja.Name = "lblDatumDiplomiranja";
            lblDatumDiplomiranja.Size = new Size(105, 15);
            lblDatumDiplomiranja.TabIndex = 6;
            lblDatumDiplomiranja.Text = "Datum diplomiranja:";
            // 
            // lblDatumPoslObnoveLicence
            // 
            lblDatumPoslObnoveLicence.AutoSize = true;
            lblDatumPoslObnoveLicence.Location = new Point(10, 103);
            lblDatumPoslObnoveLicence.Name = "lblDatumPoslObnoveLicence";
            lblDatumPoslObnoveLicence.Size = new Size(130, 15);
            lblDatumPoslObnoveLicence.TabIndex = 7;
            lblDatumPoslObnoveLicence.Text = "Datum poslednje obnove:";
            // 
            // pnlTehnicar
            // 
            pnlTehnicar.Controls.Add(cmbNivo);
            pnlTehnicar.Controls.Add(lblNivoObrazovanja);
            pnlTehnicar.Location = new Point(20, 220);
            pnlTehnicar.Name = "pnlTehnicar";
            pnlTehnicar.Size = new Size(500, 60);
            pnlTehnicar.TabIndex = 7;
            // 
            // cmbNivo
            // 
            cmbNivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivo.FormattingEnabled = true;
            cmbNivo.Items.AddRange(new object[] { "VISI", "SREDNJI" });
            cmbNivo.Location = new Point(150, 20);
            cmbNivo.Name = "cmbNivo";
            cmbNivo.Size = new Size(200, 23);
            cmbNivo.TabIndex = 0;
            // 
            // lblNivoObrazovanja
            // 
            lblNivoObrazovanja.AutoSize = true;
            lblNivoObrazovanja.Location = new Point(10, 23);
            lblNivoObrazovanja.Name = "lblNivoObrazovanja";
            lblNivoObrazovanja.Size = new Size(100, 15);
            lblNivoObrazovanja.TabIndex = 1;
            lblNivoObrazovanja.Text = "Nivo obrazovanja:";
            // 
            // pnlMenadzer
            // 
            pnlMenadzer.Location = new Point(20, 220);
            pnlMenadzer.Name = "pnlMenadzer";
            pnlMenadzer.Size = new Size(500, 60);
            pnlMenadzer.TabIndex = 8;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Location = new Point(20, 23);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(30, 15);
            lblIme.TabIndex = 9;
            lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Location = new Point(20, 53);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(55, 15);
            lblPrezime.TabIndex = 10;
            lblPrezime.Text = "Prezime:";
            // 
            // lblDatumRodj
            // 
            lblDatumRodj.AutoSize = true;
            lblDatumRodj.Location = new Point(20, 83);
            lblDatumRodj.Name = "lblDatumRodj";
            lblDatumRodj.Size = new Size(85, 15);
            lblDatumRodj.TabIndex = 11;
            lblDatumRodj.Text = "Datum rođenja:";
            // 
            // lblAdresa
            // 
            lblAdresa.AutoSize = true;
            lblAdresa.Location = new Point(20, 113);
            lblAdresa.Name = "lblAdresa";
            lblAdresa.Size = new Size(45, 15);
            lblAdresa.TabIndex = 12;
            lblAdresa.Text = "Adresa:";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(20, 143);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(50, 15);
            lblTelefon.TabIndex = 13;
            lblTelefon.Text = "Telefon:";
            // 
            // lblDatumZaposlenja
            // 
            lblDatumZaposlenja.AutoSize = true;
            lblDatumZaposlenja.Location = new Point(20, 173);
            lblDatumZaposlenja.Name = "lblDatumZaposlenja";
            lblDatumZaposlenja.Size = new Size(95, 15);
            lblDatumZaposlenja.TabIndex = 14;
            lblDatumZaposlenja.Text = "Datum zaposlenja:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(200, 400);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 15;
            btnSave.Text = "Sačuvaj";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(320, 400);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 30);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Otkaži";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // IzmeniZaposlenogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblDatumZaposlenja);
            Controls.Add(lblTelefon);
            Controls.Add(lblAdresa);
            Controls.Add(lblDatumRodj);
            Controls.Add(lblPrezime);
            Controls.Add(lblIme);
            Controls.Add(pnlMenadzer);
            Controls.Add(pnlTehnicar);
            Controls.Add(pnlFarmaceut);
            Controls.Add(dtpDatumZaposlenja);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdresa);
            Controls.Add(dtpDatumRodj);
            Controls.Add(txtPrezime);
            Controls.Add(txtIme);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "IzmeniZaposlenogForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Izmeni zaposlenog";
            pnlFarmaceut.ResumeLayout(false);
            pnlFarmaceut.PerformLayout();
            pnlTehnicar.ResumeLayout(false);
            pnlTehnicar.PerformLayout();
            pnlMenadzer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIme;
        private TextBox txtPrezime;
        private DateTimePicker dtpDatumRodj;
        private TextBox txtAdresa;
        private TextBox txtTelefon;
        private DateTimePicker dtpDatumZaposlenja;
        private Panel pnlFarmaceut;
        private TextBox txtSpecijalnost;
        private TextBox txtBrLicence;
        private DateTimePicker dtpDatumDiplomiranja;
        private DateTimePicker dtpDatumPoslObnoveLicence;
        private Label lblSpecijalnost;
        private Label lblBrLicence;
        private Label lblDatumDiplomiranja;
        private Label lblDatumPoslObnoveLicence;
        private Panel pnlTehnicar;
        private ComboBox cmbNivo;
        private Label lblNivoObrazovanja;
        private Panel pnlMenadzer;
        private Label lblIme;
        private Label lblPrezime;
        private Label lblDatumRodj;
        private Label lblAdresa;
        private Label lblTelefon;
        private Label lblDatumZaposlenja;
        private Button btnSave;
        private Button btnCancel;
    }
}