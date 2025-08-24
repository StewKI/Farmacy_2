namespace Farmacy_2.Forme
{
    partial class FarmaceutEditForm
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
            SuspendLayout();
            // 
            // lblMBr
            // 
            lblMBr.AutoSize = true;
            lblMBr.Location = new Point(12, 15);
            lblMBr.Name = "lblMBr";
            lblMBr.Size = new Size(35, 15);
            lblMBr.TabIndex = 0;
            lblMBr.Text = "M.Br:";
            // 
            // txtMBr
            // 
            txtMBr.Location = new Point(120, 12);
            txtMBr.Name = "txtMBr";
            txtMBr.ReadOnly = true;
            txtMBr.Size = new Size(200, 23);
            txtMBr.TabIndex = 1;
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Location = new Point(12, 44);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(52, 15);
            lblPrezime.TabIndex = 2;
            lblPrezime.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(120, 41);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(200, 23);
            txtPrezime.TabIndex = 3;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Location = new Point(12, 73);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(30, 15);
            lblIme.TabIndex = 4;
            lblIme.Text = "Ime:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(120, 70);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(200, 23);
            txtIme.TabIndex = 5;
            // 
            // lblDatumRodj
            // 
            lblDatumRodj.AutoSize = true;
            lblDatumRodj.Location = new Point(12, 102);
            lblDatumRodj.Name = "lblDatumRodj";
            lblDatumRodj.Size = new Size(89, 15);
            lblDatumRodj.TabIndex = 6;
            lblDatumRodj.Text = "Datum rođenja:";
            // 
            // dtpDatumRodj
            // 
            dtpDatumRodj.Format = DateTimePickerFormat.Short;
            dtpDatumRodj.Location = new Point(120, 99);
            dtpDatumRodj.Name = "dtpDatumRodj";
            dtpDatumRodj.Size = new Size(120, 23);
            dtpDatumRodj.TabIndex = 7;
            // 
            // lblAdresa
            // 
            lblAdresa.AutoSize = true;
            lblAdresa.Location = new Point(12, 131);
            lblAdresa.Name = "lblAdresa";
            lblAdresa.Size = new Size(46, 15);
            lblAdresa.TabIndex = 8;
            lblAdresa.Text = "Adresa:";
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new Point(120, 128);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(200, 23);
            txtAdresa.TabIndex = 9;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(12, 160);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(49, 15);
            lblTelefon.TabIndex = 10;
            lblTelefon.Text = "Telefon:";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(120, 157);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(200, 23);
            txtTelefon.TabIndex = 11;
            // 
            // lblDatumZaposlenja
            // 
            lblDatumZaposlenja.AutoSize = true;
            lblDatumZaposlenja.Location = new Point(12, 189);
            lblDatumZaposlenja.Name = "lblDatumZaposlenja";
            lblDatumZaposlenja.Size = new Size(104, 15);
            lblDatumZaposlenja.TabIndex = 12;
            lblDatumZaposlenja.Text = "Datum zaposlenja:";
            // 
            // dtpDatumZaposlenja
            // 
            dtpDatumZaposlenja.Format = DateTimePickerFormat.Short;
            dtpDatumZaposlenja.Location = new Point(120, 186);
            dtpDatumZaposlenja.Name = "dtpDatumZaposlenja";
            dtpDatumZaposlenja.Size = new Size(120, 23);
            dtpDatumZaposlenja.TabIndex = 13;
            // 
            // lblDatumDiplomiranja
            // 
            lblDatumDiplomiranja.AutoSize = true;
            lblDatumDiplomiranja.Location = new Point(12, 218);
            lblDatumDiplomiranja.Name = "lblDatumDiplomiranja";
            lblDatumDiplomiranja.Size = new Size(116, 15);
            lblDatumDiplomiranja.TabIndex = 14;
            lblDatumDiplomiranja.Text = "Datum diplomiranja:";
            // 
            // dtpDatumDiplomiranja
            // 
            dtpDatumDiplomiranja.Format = DateTimePickerFormat.Short;
            dtpDatumDiplomiranja.Location = new Point(130, 215);
            dtpDatumDiplomiranja.Name = "dtpDatumDiplomiranja";
            dtpDatumDiplomiranja.Size = new Size(120, 23);
            dtpDatumDiplomiranja.TabIndex = 15;
            // 
            // lblBrLicence
            // 
            lblBrLicence.AutoSize = true;
            lblBrLicence.Location = new Point(12, 247);
            lblBrLicence.Name = "lblBrLicence";
            lblBrLicence.Size = new Size(71, 15);
            lblBrLicence.TabIndex = 16;
            lblBrLicence.Text = "Broj licence:";
            // 
            // txtBrLicence
            // 
            txtBrLicence.Location = new Point(120, 244);
            txtBrLicence.Name = "txtBrLicence";
            txtBrLicence.Size = new Size(200, 23);
            txtBrLicence.TabIndex = 17;
            // 
            // lblDatumPoslObnoveLicence
            // 
            lblDatumPoslObnoveLicence.AutoSize = true;
            lblDatumPoslObnoveLicence.Location = new Point(12, 276);
            lblDatumPoslObnoveLicence.Name = "lblDatumPoslObnoveLicence";
            lblDatumPoslObnoveLicence.Size = new Size(157, 15);
            lblDatumPoslObnoveLicence.TabIndex = 18;
            lblDatumPoslObnoveLicence.Text = "Datum posl. obnove licence:";
            // 
            // dtpDatumPoslObnoveLicence
            // 
            dtpDatumPoslObnoveLicence.Format = DateTimePickerFormat.Short;
            dtpDatumPoslObnoveLicence.Location = new Point(170, 273);
            dtpDatumPoslObnoveLicence.Name = "dtpDatumPoslObnoveLicence";
            dtpDatumPoslObnoveLicence.Size = new Size(120, 23);
            dtpDatumPoslObnoveLicence.TabIndex = 19;
            // 
            // lblSpecijalnost
            // 
            lblSpecijalnost.AutoSize = true;
            lblSpecijalnost.Location = new Point(12, 305);
            lblSpecijalnost.Name = "lblSpecijalnost";
            lblSpecijalnost.Size = new Size(73, 15);
            lblSpecijalnost.TabIndex = 20;
            lblSpecijalnost.Text = "Specijalnost:";
            // 
            // txtSpecijalnost
            // 
            txtSpecijalnost.Location = new Point(120, 302);
            txtSpecijalnost.Name = "txtSpecijalnost";
            txtSpecijalnost.Size = new Size(200, 23);
            txtSpecijalnost.TabIndex = 21;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(120, 340);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 22;
            btnSave.Text = "Sačuvaj";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(245, 340);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Otkaži";
            btnCancel.Click += btnCancel_Click;
            // 
            // FarmaceutEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 381);
            Controls.Add(lblMBr);
            Controls.Add(txtMBr);
            Controls.Add(lblPrezime);
            Controls.Add(txtPrezime);
            Controls.Add(lblIme);
            Controls.Add(txtIme);
            Controls.Add(lblDatumRodj);
            Controls.Add(dtpDatumRodj);
            Controls.Add(lblAdresa);
            Controls.Add(txtAdresa);
            Controls.Add(lblTelefon);
            Controls.Add(txtTelefon);
            Controls.Add(lblDatumZaposlenja);
            Controls.Add(dtpDatumZaposlenja);
            Controls.Add(lblDatumDiplomiranja);
            Controls.Add(dtpDatumDiplomiranja);
            Controls.Add(lblBrLicence);
            Controls.Add(txtBrLicence);
            Controls.Add(lblDatumPoslObnoveLicence);
            Controls.Add(dtpDatumPoslObnoveLicence);
            Controls.Add(lblSpecijalnost);
            Controls.Add(txtSpecijalnost);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FarmaceutEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Izmena farmaceuta";
            Load += FarmaceutEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
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
