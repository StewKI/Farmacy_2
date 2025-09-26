namespace Farmacy.Forme
{
    partial class MenadzerForm
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
            panelButtons = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            panelForm = new Panel();
            dtpDatumZaposlenja = new DateTimePicker();
            lblDatumZaposlenja = new Label();
            txtTelefon = new TextBox();
            lblTelefon = new Label();
            txtAdresa = new TextBox();
            lblAdresa = new Label();
            dtpDatumRodj = new DateTimePicker();
            lblDatumRodj = new Label();
            txtIme = new TextBox();
            lblIme = new Label();
            txtPrezime = new TextBox();
            lblPrezime = new Label();
            txtMatBr = new TextBox();
            lblMatBr = new Label();
            lblMBr = new Label();
            panelHeader = new Panel();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
            panelForm.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitle.Location = new Point(29, 33);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(335, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "👔 Novi menadžer";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(248, 249, 250);
            panelMain.Controls.Add(panelButtons);
            panelMain.Controls.Add(panelForm);
            panelMain.Controls.Add(panelHeader);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Margin = new Padding(4, 5, 4, 5);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(714, 750);
            panelMain.TabIndex = 16;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(248, 249, 250);
            panelButtons.Controls.Add(btnCancel);
            panelButtons.Controls.Add(btnSave);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 617);
            panelButtons.Margin = new Padding(4, 5, 4, 5);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(43, 25, 43, 25);
            panelButtons.Size = new Size(714, 133);
            panelButtons.TabIndex = 19;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(108, 117, 125);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(557, 25);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(171, 83);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "✖ Otkaži";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(40, 167, 69);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(357, 25);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(171, 83);
            btnSave.TabIndex = 14;
            btnSave.Text = "✓ Sačuvaj";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(dtpDatumZaposlenja);
            panelForm.Controls.Add(lblDatumZaposlenja);
            panelForm.Controls.Add(txtTelefon);
            panelForm.Controls.Add(lblTelefon);
            panelForm.Controls.Add(txtAdresa);
            panelForm.Controls.Add(lblAdresa);
            panelForm.Controls.Add(dtpDatumRodj);
            panelForm.Controls.Add(lblDatumRodj);
            panelForm.Controls.Add(txtIme);
            panelForm.Controls.Add(lblIme);
            panelForm.Controls.Add(txtPrezime);
            panelForm.Controls.Add(lblPrezime);
            panelForm.Controls.Add(txtMatBr);
            panelForm.Controls.Add(lblMatBr);
            panelForm.Controls.Add(lblMBr);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 133);
            panelForm.Margin = new Padding(4, 5, 4, 5);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(43, 33, 43, 33);
            panelForm.Size = new Size(714, 617);
            panelForm.TabIndex = 18;
            // 
            // dtpDatumZaposlenja
            // 
            dtpDatumZaposlenja.Font = new Font("Segoe UI", 10F);
            dtpDatumZaposlenja.Format = DateTimePickerFormat.Short;
            dtpDatumZaposlenja.Location = new Point(257, 428);
            dtpDatumZaposlenja.Margin = new Padding(4, 5, 4, 5);
            dtpDatumZaposlenja.Name = "dtpDatumZaposlenja";
            dtpDatumZaposlenja.Size = new Size(370, 34);
            dtpDatumZaposlenja.TabIndex = 13;
            // 
            // lblDatumZaposlenja
            // 
            lblDatumZaposlenja.AutoSize = true;
            lblDatumZaposlenja.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDatumZaposlenja.ForeColor = Color.FromArgb(33, 37, 41);
            lblDatumZaposlenja.Location = new Point(43, 433);
            lblDatumZaposlenja.Margin = new Padding(4, 0, 4, 0);
            lblDatumZaposlenja.Name = "lblDatumZaposlenja";
            lblDatumZaposlenja.Size = new Size(187, 28);
            lblDatumZaposlenja.TabIndex = 12;
            lblDatumZaposlenja.Text = "Datum zaposlenja:";
            // 
            // txtTelefon
            // 
            txtTelefon.BackColor = Color.White;
            txtTelefon.BorderStyle = BorderStyle.FixedSingle;
            txtTelefon.Font = new Font("Segoe UI", 10F);
            txtTelefon.Location = new Point(257, 362);
            txtTelefon.Margin = new Padding(4, 5, 4, 5);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(371, 34);
            txtTelefon.TabIndex = 11;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTelefon.ForeColor = Color.FromArgb(33, 37, 41);
            lblTelefon.Location = new Point(43, 367);
            lblTelefon.Margin = new Padding(4, 0, 4, 0);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(87, 28);
            lblTelefon.TabIndex = 10;
            lblTelefon.Text = "Telefon:";
            // 
            // txtAdresa
            // 
            txtAdresa.BackColor = Color.White;
            txtAdresa.BorderStyle = BorderStyle.FixedSingle;
            txtAdresa.Font = new Font("Segoe UI", 10F);
            txtAdresa.Location = new Point(257, 295);
            txtAdresa.Margin = new Padding(4, 5, 4, 5);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(371, 34);
            txtAdresa.TabIndex = 9;
            // 
            // lblAdresa
            // 
            lblAdresa.AutoSize = true;
            lblAdresa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAdresa.ForeColor = Color.FromArgb(33, 37, 41);
            lblAdresa.Location = new Point(43, 300);
            lblAdresa.Margin = new Padding(4, 0, 4, 0);
            lblAdresa.Name = "lblAdresa";
            lblAdresa.Size = new Size(82, 28);
            lblAdresa.TabIndex = 8;
            lblAdresa.Text = "Adresa:";
            // 
            // dtpDatumRodj
            // 
            dtpDatumRodj.Font = new Font("Segoe UI", 10F);
            dtpDatumRodj.Format = DateTimePickerFormat.Short;
            dtpDatumRodj.Location = new Point(257, 228);
            dtpDatumRodj.Margin = new Padding(4, 5, 4, 5);
            dtpDatumRodj.Name = "dtpDatumRodj";
            dtpDatumRodj.Size = new Size(370, 34);
            dtpDatumRodj.TabIndex = 7;
            // 
            // lblDatumRodj
            // 
            lblDatumRodj.AutoSize = true;
            lblDatumRodj.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDatumRodj.ForeColor = Color.FromArgb(33, 37, 41);
            lblDatumRodj.Location = new Point(43, 300);
            lblDatumRodj.Margin = new Padding(4, 0, 4, 0);
            lblDatumRodj.Name = "lblDatumRodj";
            lblDatumRodj.Size = new Size(160, 28);
            lblDatumRodj.TabIndex = 6;
            lblDatumRodj.Text = "Datum rođenja:";
            // 
            // txtIme
            // 
            txtIme.BackColor = Color.White;
            txtIme.BorderStyle = BorderStyle.FixedSingle;
            txtIme.Font = new Font("Segoe UI", 10F);
            txtIme.Location = new Point(257, 228);
            txtIme.Margin = new Padding(4, 5, 4, 5);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(371, 34);
            txtIme.TabIndex = 5;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblIme.ForeColor = Color.FromArgb(33, 37, 41);
            lblIme.Location = new Point(43, 233);
            lblIme.Margin = new Padding(4, 0, 4, 0);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(52, 28);
            lblIme.TabIndex = 4;
            lblIme.Text = "Ime:";
            // 
            // txtPrezime
            // 
            txtPrezime.BackColor = Color.White;
            txtPrezime.BorderStyle = BorderStyle.FixedSingle;
            txtPrezime.Font = new Font("Segoe UI", 10F);
            txtPrezime.Location = new Point(257, 162);
            txtPrezime.Margin = new Padding(4, 5, 4, 5);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(371, 34);
            txtPrezime.TabIndex = 4;
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrezime.ForeColor = Color.FromArgb(33, 37, 41);
            lblPrezime.Location = new Point(43, 162);
            lblPrezime.Margin = new Padding(4, 0, 4, 0);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(93, 28);
            lblPrezime.TabIndex = 2;
            lblPrezime.Text = "Prezime:";
            // 
            // txtMatBr
            // 
            txtMatBr.BackColor = Color.White;
            txtMatBr.BorderStyle = BorderStyle.FixedSingle;
            txtMatBr.Font = new Font("Segoe UI", 10F);
            txtMatBr.Location = new Point(257, 95);
            txtMatBr.Margin = new Padding(4, 5, 4, 5);
            txtMatBr.Name = "txtMatBr";
            txtMatBr.Size = new Size(371, 34);
            txtMatBr.TabIndex = 2;
            // 
            // lblMatBr
            // 
            lblMatBr.AutoSize = true;
            lblMatBr.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMatBr.ForeColor = Color.FromArgb(33, 37, 41);
            lblMatBr.Location = new Point(43, 95);
            lblMatBr.Margin = new Padding(4, 0, 4, 0);
            lblMatBr.Name = "lblMatBr";
            lblMatBr.Size = new Size(133, 28);
            lblMatBr.TabIndex = 1;
            lblMatBr.Text = "Matični broj:";
            lblMatBr.Click += lblMatBr_Click;
            // 
            // lblMBr
            // 
            lblMBr.AutoSize = true;
            lblMBr.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMBr.ForeColor = Color.FromArgb(108, 117, 125);
            lblMBr.Location = new Point(43, 33);
            lblMBr.Margin = new Padding(4, 0, 4, 0);
            lblMBr.Name = "lblMBr";
            lblMBr.Size = new Size(263, 30);
            lblMBr.TabIndex = 0;
            lblMBr.Text = "Lični podaci menadžera:";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4, 5, 4, 5);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(29, 33, 29, 33);
            panelHeader.Size = new Size(714, 133);
            panelHeader.TabIndex = 17;
            // 
            // MenadzerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(714, 750);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MenadzerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "👔 Dodavanje menadžera";
            Load += MenadzerForm_Load;
            panelMain.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelButtons;
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
