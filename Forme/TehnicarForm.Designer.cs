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
            lblMBr = new Label();
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
            btnSave = new Button();
            btnCancel = new Button();
            btnDodajSertifikaciju = new Button();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            cmbSmena = new ComboBox();
            cmbNivo = new ComboBox();
            SuspendLayout();
            // 
            // lblMBr
            // 
            lblMBr.AutoSize = true;
            lblMBr.Location = new Point(30, 30);
            lblMBr.Name = "lblMBr";
            lblMBr.Size = new Size(54, 15);
            lblMBr.TabIndex = 0;
            lblMBr.Text = "Apoteke:";
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Location = new Point(30, 70);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(52, 15);
            lblPrezime.TabIndex = 2;
            lblPrezime.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(159, 67);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(200, 23);
            txtPrezime.TabIndex = 3;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Location = new Point(30, 110);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(30, 15);
            lblIme.TabIndex = 4;
            lblIme.Text = "Ime:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(159, 107);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(200, 23);
            txtIme.TabIndex = 5;
            // 
            // lblDatumRodj
            // 
            lblDatumRodj.AutoSize = true;
            lblDatumRodj.Location = new Point(30, 150);
            lblDatumRodj.Name = "lblDatumRodj";
            lblDatumRodj.Size = new Size(89, 15);
            lblDatumRodj.TabIndex = 6;
            lblDatumRodj.Text = "Datum rođenja:";
            // 
            // dtpDatumRodj
            // 
            dtpDatumRodj.Format = DateTimePickerFormat.Short;
            dtpDatumRodj.Location = new Point(159, 147);
            dtpDatumRodj.Name = "dtpDatumRodj";
            dtpDatumRodj.Size = new Size(200, 23);
            dtpDatumRodj.TabIndex = 7;
            // 
            // lblAdresa
            // 
            lblAdresa.AutoSize = true;
            lblAdresa.Location = new Point(30, 190);
            lblAdresa.Name = "lblAdresa";
            lblAdresa.Size = new Size(46, 15);
            lblAdresa.TabIndex = 8;
            lblAdresa.Text = "Adresa:";
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new Point(159, 187);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(200, 23);
            txtAdresa.TabIndex = 9;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(30, 230);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(49, 15);
            lblTelefon.TabIndex = 10;
            lblTelefon.Text = "Telefon:";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(159, 227);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(200, 23);
            txtTelefon.TabIndex = 11;
            // 
            // lblDatumZaposlenja
            // 
            lblDatumZaposlenja.AutoSize = true;
            lblDatumZaposlenja.Location = new Point(30, 270);
            lblDatumZaposlenja.Name = "lblDatumZaposlenja";
            lblDatumZaposlenja.Size = new Size(104, 15);
            lblDatumZaposlenja.TabIndex = 12;
            lblDatumZaposlenja.Text = "Datum zaposlenja:";
            // 
            // dtpDatumZaposlenja
            // 
            dtpDatumZaposlenja.Format = DateTimePickerFormat.Short;
            dtpDatumZaposlenja.Location = new Point(159, 267);
            dtpDatumZaposlenja.Name = "dtpDatumZaposlenja";
            dtpDatumZaposlenja.Size = new Size(200, 23);
            dtpDatumZaposlenja.TabIndex = 13;
            // 
            // lblNivoObrazovanja
            // 
            lblNivoObrazovanja.AutoSize = true;
            lblNivoObrazovanja.Location = new Point(30, 348);
            lblNivoObrazovanja.Name = "lblNivoObrazovanja";
            lblNivoObrazovanja.Size = new Size(102, 15);
            lblNivoObrazovanja.TabIndex = 14;
            lblNivoObrazovanja.Text = "Nivo obrazovanja:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(171, 429);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 16;
            btnSave.Text = "Sačuvaj";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(275, 429);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Otkaži";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDodajSertifikaciju
            // 
            btnDodajSertifikaciju.Location = new Point(15, 427);
            btnDodajSertifikaciju.Name = "btnDodajSertifikaciju";
            btnDodajSertifikaciju.Size = new Size(104, 39);
            btnDodajSertifikaciju.TabIndex = 18;
            btnDodajSertifikaciju.Text = "Dodaj sertifikaciju";
            btnDodajSertifikaciju.UseVisualStyleBackColor = true;
            btnDodajSertifikaciju.Click += btnDodajSertifikaciju_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(159, 304);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 307);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 19;
            label1.Text = "Datum kraja zaposlenja:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(159, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 389);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 22;
            label2.Text = "Smena rada:";
            // 
            // cmbSmena
            // 
            cmbSmena.FormattingEnabled = true;
            cmbSmena.Location = new Point(159, 389);
            cmbSmena.Name = "cmbSmena";
            cmbSmena.Size = new Size(200, 23);
            cmbSmena.TabIndex = 30;
            // 
            // cmbNivo
            // 
            cmbNivo.FormattingEnabled = true;
            cmbNivo.Location = new Point(159, 348);
            cmbNivo.Name = "cmbNivo";
            cmbNivo.Size = new Size(200, 23);
            cmbNivo.TabIndex = 31;
            // 
            // TehnicarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 478);
            Controls.Add(cmbNivo);
            Controls.Add(cmbSmena);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(btnDodajSertifikaciju);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblNivoObrazovanja);
            Controls.Add(dtpDatumZaposlenja);
            Controls.Add(lblDatumZaposlenja);
            Controls.Add(txtTelefon);
            Controls.Add(lblTelefon);
            Controls.Add(txtAdresa);
            Controls.Add(lblAdresa);
            Controls.Add(dtpDatumRodj);
            Controls.Add(lblDatumRodj);
            Controls.Add(txtIme);
            Controls.Add(lblIme);
            Controls.Add(txtPrezime);
            Controls.Add(lblPrezime);
            Controls.Add(lblMBr);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TehnicarForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tehničar";
            Load += TehnicarForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMBr;
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
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox cmbSmena;
        private ComboBox cmbNivo;
    }
}
