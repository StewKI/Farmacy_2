namespace Farmacy.Forme
{
    partial class TehnicarForm
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
            panelHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            panelMain = new Panel();
            panelForm = new Panel();
            panelButtons = new Panel();
            grpLicni = new GroupBox();
            grpProfesionalni = new GroupBox();
            lblMBr = new Label();
            lblMatBr = new Label();
            txtMatBr = new TextBox();
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
            lblNivoObrazovanja = new Label();
            cmbNivo = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            btnDodajSertifikaciju = new Button();
            panelFooter = new Panel();
            lblFooter = new Label();
            panelMain.SuspendLayout();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            panelButtons.SuspendLayout();
            grpLicni.SuspendLayout();
            grpProfesionalni.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(panelFooter);
            panelMain.Controls.Add(panelButtons);
            panelMain.Controls.Add(panelForm);
            panelMain.Controls.Add(panelHeader);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(800, 700);
            panelMain.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(46, 204, 113);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 100);
            panelHeader.TabIndex = 1;
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
            lblTitle.Text = "🔧 DODAVANJE TEHNIČARA";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(200, 255, 200);
            lblSubtitle.Location = new Point(20, 60);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(400, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Unos novih podataka o tehničaru u sistem";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.FromArgb(245, 248, 250);
            panelForm.Controls.Add(grpProfesionalni);
            panelForm.Controls.Add(grpLicni);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 100);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(30);
            panelForm.Size = new Size(800, 500);
            panelForm.TabIndex = 2;
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
            grpLicni.Controls.Add(txtMatBr);
            grpLicni.Controls.Add(lblMatBr);
            grpLicni.Controls.Add(lblMBr);
            grpLicni.Dock = DockStyle.Top;
            grpLicni.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpLicni.ForeColor = Color.FromArgb(33, 37, 41);
            grpLicni.Location = new Point(30, 30);
            grpLicni.Name = "grpLicni";
            grpLicni.Padding = new Padding(15);
            grpLicni.Size = new Size(740, 280);
            grpLicni.TabIndex = 3;
            grpLicni.TabStop = false;
            grpLicni.Text = "👤 Lični podaci";
            // 
            // grpProfesionalni
            // 
            grpProfesionalni.BackColor = Color.White;
            grpProfesionalni.Controls.Add(cmbNivo);
            grpProfesionalni.Controls.Add(lblNivoObrazovanja);
            grpProfesionalni.Dock = DockStyle.Top;
            grpProfesionalni.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpProfesionalni.ForeColor = Color.FromArgb(33, 37, 41);
            grpProfesionalni.Location = new Point(30, 320);
            grpProfesionalni.Name = "grpProfesionalni";
            grpProfesionalni.Padding = new Padding(15);
            grpProfesionalni.Size = new Size(740, 120);
            grpProfesionalni.TabIndex = 4;
            grpProfesionalni.TabStop = false;
            grpProfesionalni.Text = "🎓 Profesionalni podaci";
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(245, 248, 250);
            panelButtons.Controls.Add(btnDodajSertifikaciju);
            panelButtons.Controls.Add(btnCancel);
            panelButtons.Controls.Add(btnSave);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 600);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(30, 15, 30, 15);
            panelButtons.Size = new Size(800, 100);
            panelButtons.TabIndex = 5;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(44, 62, 80);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 700);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(800, 40);
            panelFooter.TabIndex = 6;
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
            lblFooter.Text = "Dodavanje tehničara - Upravljanje podacima o tehničarima u sistemu";
            // 
            // lblMBr
            // 
            lblMBr.AutoSize = true;
            lblMBr.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMBr.ForeColor = Color.FromArgb(108, 117, 125);
            lblMBr.Location = new Point(20, 30);
            lblMBr.Name = "lblMBr";
            lblMBr.Size = new Size(150, 19);
            lblMBr.TabIndex = 0;
            lblMBr.Text = "Osnovne informacije:";
            // 
            // lblMatBr
            // 
            lblMatBr.AutoSize = true;
            lblMatBr.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMatBr.ForeColor = Color.FromArgb(33, 37, 41);
            lblMatBr.Location = new Point(20, 50);
            lblMatBr.Name = "lblMatBr";
            lblMatBr.Size = new Size(95, 19);
            lblMatBr.TabIndex = 1;
            lblMatBr.Text = "Matični broj:";
            // 
            // txtMatBr
            // 
            txtMatBr.BackColor = Color.White;
            txtMatBr.BorderStyle = BorderStyle.FixedSingle;
            txtMatBr.Font = new Font("Segoe UI", 10F);
            txtMatBr.Location = new Point(200, 47);
            txtMatBr.Name = "txtMatBr";
            txtMatBr.Size = new Size(340, 25);
            txtMatBr.TabIndex = 2;
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrezime.ForeColor = Color.FromArgb(33, 37, 41);
            lblPrezime.Location = new Point(20, 90);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(62, 19);
            lblPrezime.TabIndex = 3;
            lblPrezime.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            txtPrezime.BackColor = Color.White;
            txtPrezime.BorderStyle = BorderStyle.FixedSingle;
            txtPrezime.Font = new Font("Segoe UI", 10F);
            txtPrezime.Location = new Point(200, 87);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(340, 25);
            txtPrezime.TabIndex = 3;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblIme.ForeColor = Color.FromArgb(33, 37, 41);
            lblIme.Location = new Point(20, 130);
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
            txtIme.Location = new Point(200, 127);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(340, 25);
            txtIme.TabIndex = 5;
            // 
            // lblDatumRodj
            // 
            lblDatumRodj.AutoSize = true;
            lblDatumRodj.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDatumRodj.ForeColor = Color.FromArgb(33, 37, 41);
            lblDatumRodj.Location = new Point(20, 170);
            lblDatumRodj.Name = "lblDatumRodj";
            lblDatumRodj.Size = new Size(106, 19);
            lblDatumRodj.TabIndex = 6;
            lblDatumRodj.Text = "Datum rođenja:";
            // 
            // dtpDatumRodj
            // 
            dtpDatumRodj.Font = new Font("Segoe UI", 10F);
            dtpDatumRodj.Format = DateTimePickerFormat.Short;
            dtpDatumRodj.Location = new Point(200, 167);
            dtpDatumRodj.Name = "dtpDatumRodj";
            dtpDatumRodj.Size = new Size(340, 25);
            dtpDatumRodj.TabIndex = 7;
            // 
            // lblAdresa
            // 
            lblAdresa.AutoSize = true;
            lblAdresa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAdresa.ForeColor = Color.FromArgb(33, 37, 41);
            lblAdresa.Location = new Point(20, 210);
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
            txtAdresa.Location = new Point(200, 207);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(340, 25);
            txtAdresa.TabIndex = 9;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTelefon.ForeColor = Color.FromArgb(33, 37, 41);
            lblTelefon.Location = new Point(20, 250);
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
            txtTelefon.Location = new Point(200, 247);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(340, 25);
            txtTelefon.TabIndex = 11;
            // 
            // lblDatumZaposlenja
            // 
            lblDatumZaposlenja.AutoSize = true;
            lblDatumZaposlenja.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDatumZaposlenja.ForeColor = Color.FromArgb(33, 37, 41);
            lblDatumZaposlenja.Location = new Point(20, 290);
            lblDatumZaposlenja.Name = "lblDatumZaposlenja";
            lblDatumZaposlenja.Size = new Size(125, 19);
            lblDatumZaposlenja.TabIndex = 12;
            lblDatumZaposlenja.Text = "Datum zaposlenja:";
            // 
            // dtpDatumZaposlenja
            // 
            dtpDatumZaposlenja.Font = new Font("Segoe UI", 10F);
            dtpDatumZaposlenja.Format = DateTimePickerFormat.Short;
            dtpDatumZaposlenja.Location = new Point(200, 287);
            dtpDatumZaposlenja.Name = "dtpDatumZaposlenja";
            dtpDatumZaposlenja.Size = new Size(340, 25);
            dtpDatumZaposlenja.TabIndex = 13;
            // 
            // lblNivoObrazovanja
            // 
            lblNivoObrazovanja.AutoSize = true;
            lblNivoObrazovanja.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNivoObrazovanja.ForeColor = Color.FromArgb(33, 37, 41);
            lblNivoObrazovanja.Location = new Point(20, 50);
            lblNivoObrazovanja.Name = "lblNivoObrazovanja";
            lblNivoObrazovanja.Size = new Size(130, 19);
            lblNivoObrazovanja.TabIndex = 14;
            lblNivoObrazovanja.Text = "Nivo obrazovanja:";
            // 
            // cmbNivo
            // 
            cmbNivo.BackColor = Color.White;
            cmbNivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivo.Font = new Font("Segoe UI", 10F);
            cmbNivo.FormattingEnabled = true;
            cmbNivo.Location = new Point(200, 47);
            cmbNivo.Name = "cmbNivo";
            cmbNivo.Size = new Size(340, 25);
            cmbNivo.TabIndex = 15;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 204, 113);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(450, 25);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 50);
            btnSave.TabIndex = 16;
            btnSave.Text = "💾 Sačuvaj";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(610, 25);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 50);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "❌ Otkaži";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDodajSertifikaciju
            // 
            btnDodajSertifikaciju.BackColor = Color.FromArgb(52, 152, 219);
            btnDodajSertifikaciju.FlatAppearance.BorderSize = 0;
            btnDodajSertifikaciju.FlatStyle = FlatStyle.Flat;
            btnDodajSertifikaciju.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDodajSertifikaciju.ForeColor = Color.White;
            btnDodajSertifikaciju.Location = new Point(30, 25);
            btnDodajSertifikaciju.Name = "btnDodajSertifikaciju";
            btnDodajSertifikaciju.Size = new Size(180, 50);
            btnDodajSertifikaciju.TabIndex = 18;
            btnDodajSertifikaciju.Text = "📜 Dodaj sertifikaciju";
            btnDodajSertifikaciju.UseVisualStyleBackColor = false;
            btnDodajSertifikaciju.Click += btnDodajSertifikaciju_Click;
            // 
            // TehnicarForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(800, 740);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TehnicarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farmacy System - Dodavanje Tehničara";
            Load += TehnicarForm_Load;
            panelMain.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            grpLicni.ResumeLayout(false);
            grpLicni.PerformLayout();
            grpProfesionalni.ResumeLayout(false);
            grpProfesionalni.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblMBr;
        private System.Windows.Forms.Label lblMatBr;
        private System.Windows.Forms.TextBox txtMatBr;
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
        private System.Windows.Forms.Label lblNivoObrazovanja;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private Button btnDodajSertifikaciju;
        private ComboBox cmbNivo;
        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelMain;
        private Panel panelForm;
        private Panel panelButtons;
        private Panel panelFooter;
        private Label lblFooter;
        private GroupBox grpLicni;
        private GroupBox grpProfesionalni;
    }
}
