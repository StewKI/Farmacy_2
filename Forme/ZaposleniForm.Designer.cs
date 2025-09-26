namespace Farmacy.Forme
{
    partial class ZaposleniForm
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
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            cmbSmena = new ComboBox();
            panelFooter = new Panel();
            lblFooter = new Label();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(230, 126, 34);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(700, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(280, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "👤 NOVI ZAPOSLENI";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(255, 220, 200);
            lblSubtitle.Location = new Point(20, 45);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(280, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Dodavanje novog zaposlenog u sistem";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(cmbSmena);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(dateTimePicker1);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(btnCancel);
            panelMain.Controls.Add(btnSave);
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
            panelMain.Controls.Add(txtMatBr);
            panelMain.Controls.Add(lblMatBr);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 80);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(700, 520);
            panelMain.TabIndex = 1;
            // 
            // lblMatBr
            // 
            lblMatBr.AutoSize = true;
            lblMatBr.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMatBr.ForeColor = Color.FromArgb(44, 62, 80);
            lblMatBr.Location = new Point(50, 30);
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
            txtMatBr.Location = new Point(200, 27);
            txtMatBr.Name = "txtMatBr";
            txtMatBr.Size = new Size(250, 26);
            txtMatBr.TabIndex = 2;
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrezime.ForeColor = Color.FromArgb(44, 62, 80);
            lblPrezime.Location = new Point(50, 70);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(64, 19);
            lblPrezime.TabIndex = 3;
            lblPrezime.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            txtPrezime.BackColor = Color.White;
            txtPrezime.BorderStyle = BorderStyle.FixedSingle;
            txtPrezime.Font = new Font("Segoe UI", 10F);
            txtPrezime.Location = new Point(200, 67);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(250, 26);
            txtPrezime.TabIndex = 4;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblIme.ForeColor = Color.FromArgb(44, 62, 80);
            lblIme.Location = new Point(50, 110);
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
            txtIme.Size = new Size(250, 26);
            txtIme.TabIndex = 5;
            // 
            // lblDatumRodj
            // 
            lblDatumRodj.AutoSize = true;
            lblDatumRodj.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDatumRodj.ForeColor = Color.FromArgb(44, 62, 80);
            lblDatumRodj.Location = new Point(50, 150);
            lblDatumRodj.Name = "lblDatumRodj";
            lblDatumRodj.Size = new Size(109, 19);
            lblDatumRodj.TabIndex = 6;
            lblDatumRodj.Text = "Datum rođenja:";
            // 
            // dtpDatumRodj
            // 
            dtpDatumRodj.Font = new Font("Segoe UI", 10F);
            dtpDatumRodj.Format = DateTimePickerFormat.Short;
            dtpDatumRodj.Location = new Point(200, 147);
            dtpDatumRodj.Name = "dtpDatumRodj";
            dtpDatumRodj.Size = new Size(150, 26);
            dtpDatumRodj.TabIndex = 7;
            // 
            // lblAdresa
            // 
            lblAdresa.AutoSize = true;
            lblAdresa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAdresa.ForeColor = Color.FromArgb(44, 62, 80);
            lblAdresa.Location = new Point(50, 190);
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
            txtAdresa.Size = new Size(250, 26);
            txtAdresa.TabIndex = 9;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTelefon.ForeColor = Color.FromArgb(44, 62, 80);
            lblTelefon.Location = new Point(50, 230);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(60, 19);
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
            txtTelefon.Size = new Size(250, 26);
            txtTelefon.TabIndex = 11;
            // 
            // lblDatumZaposlenja
            // 
            lblDatumZaposlenja.AutoSize = true;
            lblDatumZaposlenja.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDatumZaposlenja.ForeColor = Color.FromArgb(44, 62, 80);
            lblDatumZaposlenja.Location = new Point(50, 270);
            lblDatumZaposlenja.Name = "lblDatumZaposlenja";
            lblDatumZaposlenja.Size = new Size(128, 19);
            lblDatumZaposlenja.TabIndex = 12;
            lblDatumZaposlenja.Text = "Datum zaposlenja:";
            // 
            // dtpDatumZaposlenja
            // 
            dtpDatumZaposlenja.Font = new Font("Segoe UI", 10F);
            dtpDatumZaposlenja.Format = DateTimePickerFormat.Short;
            dtpDatumZaposlenja.Location = new Point(200, 267);
            dtpDatumZaposlenja.Name = "dtpDatumZaposlenja";
            dtpDatumZaposlenja.Size = new Size(150, 26);
            dtpDatumZaposlenja.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 204, 113);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(200, 390);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 40);
            btnSave.TabIndex = 14;
            btnSave.Text = "💾 Sačuvaj";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(330, 390);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "❌ Otkaži";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(50, 270);
            label1.Name = "label1";
            label1.Size = new Size(159, 19);
            label1.TabIndex = 16;
            label1.Text = "Datum kraja zaposlenja";
            label1.Click += label1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(200, 267);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(150, 26);
            dateTimePicker1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(44, 62, 80);
            label2.Location = new Point(50, 310);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 19;
            label2.Text = "Smena rada:";
            // 
            // cmbSmena
            // 
            cmbSmena.BackColor = Color.White;
            cmbSmena.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSmena.FlatStyle = FlatStyle.Flat;
            cmbSmena.Font = new Font("Segoe UI", 10F);
            cmbSmena.FormattingEnabled = true;
            cmbSmena.Location = new Point(200, 307);
            cmbSmena.Name = "cmbSmena";
            cmbSmena.Size = new Size(250, 25);
            cmbSmena.TabIndex = 30;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(44, 62, 80);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 600);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(700, 30);
            panelFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 8F);
            lblFooter.ForeColor = Color.FromArgb(189, 195, 199);
            lblFooter.Location = new Point(20, 8);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(210, 13);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Sistem za upravljanje farmaceutskim podacima";
            // 
            // ZaposleniForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 630);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Controls.Add(panelFooter);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ZaposleniForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novi zaposleni - Dodavanje zaposlenog u sistem";
            Load += ZaposleniForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooter;
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
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private ComboBox cmbSmena;
    }
}
