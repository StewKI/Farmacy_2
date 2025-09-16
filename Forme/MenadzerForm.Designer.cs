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
            btnSave = new Button();
            btnCancel = new Button();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            cmbSmena = new ComboBox();
            SuspendLayout();
            // 
            // lblMBr
            // 
            lblMBr.AutoSize = true;
            lblMBr.Location = new Point(14, 17);
            lblMBr.Margin = new Padding(4, 0, 4, 0);
            lblMBr.Name = "lblMBr";
            lblMBr.Size = new Size(54, 15);
            lblMBr.TabIndex = 0;
            lblMBr.Text = "Apoteke:";
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Location = new Point(14, 47);
            lblPrezime.Margin = new Padding(4, 0, 4, 0);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(52, 15);
            lblPrezime.TabIndex = 2;
            lblPrezime.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(148, 44);
            txtPrezime.Margin = new Padding(4, 3, 4, 3);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(174, 23);
            txtPrezime.TabIndex = 3;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Location = new Point(14, 77);
            lblIme.Margin = new Padding(4, 0, 4, 0);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(30, 15);
            lblIme.TabIndex = 4;
            lblIme.Text = "Ime:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(148, 74);
            txtIme.Margin = new Padding(4, 3, 4, 3);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(174, 23);
            txtIme.TabIndex = 5;
            // 
            // lblDatumRodj
            // 
            lblDatumRodj.AutoSize = true;
            lblDatumRodj.Location = new Point(14, 107);
            lblDatumRodj.Margin = new Padding(4, 0, 4, 0);
            lblDatumRodj.Name = "lblDatumRodj";
            lblDatumRodj.Size = new Size(89, 15);
            lblDatumRodj.TabIndex = 6;
            lblDatumRodj.Text = "Datum rođenja:";
            // 
            // dtpDatumRodj
            // 
            dtpDatumRodj.Format = DateTimePickerFormat.Short;
            dtpDatumRodj.Location = new Point(148, 104);
            dtpDatumRodj.Margin = new Padding(4, 3, 4, 3);
            dtpDatumRodj.Name = "dtpDatumRodj";
            dtpDatumRodj.Size = new Size(174, 23);
            dtpDatumRodj.TabIndex = 7;
            // 
            // lblAdresa
            // 
            lblAdresa.AutoSize = true;
            lblAdresa.Location = new Point(13, 137);
            lblAdresa.Margin = new Padding(4, 0, 4, 0);
            lblAdresa.Name = "lblAdresa";
            lblAdresa.Size = new Size(46, 15);
            lblAdresa.TabIndex = 8;
            lblAdresa.Text = "Adresa:";
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new Point(147, 134);
            txtAdresa.Margin = new Padding(4, 3, 4, 3);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(174, 23);
            txtAdresa.TabIndex = 9;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(13, 167);
            lblTelefon.Margin = new Padding(4, 0, 4, 0);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(49, 15);
            lblTelefon.TabIndex = 10;
            lblTelefon.Text = "Telefon:";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(147, 164);
            txtTelefon.Margin = new Padding(4, 3, 4, 3);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(174, 23);
            txtTelefon.TabIndex = 11;
            // 
            // lblDatumZaposlenja
            // 
            lblDatumZaposlenja.AutoSize = true;
            lblDatumZaposlenja.Location = new Point(13, 197);
            lblDatumZaposlenja.Margin = new Padding(4, 0, 4, 0);
            lblDatumZaposlenja.Name = "lblDatumZaposlenja";
            lblDatumZaposlenja.Size = new Size(104, 15);
            lblDatumZaposlenja.TabIndex = 12;
            lblDatumZaposlenja.Text = "Datum zaposlenja:";
            // 
            // dtpDatumZaposlenja
            // 
            dtpDatumZaposlenja.Format = DateTimePickerFormat.Short;
            dtpDatumZaposlenja.Location = new Point(147, 194);
            dtpDatumZaposlenja.Margin = new Padding(4, 3, 4, 3);
            dtpDatumZaposlenja.Name = "dtpDatumZaposlenja";
            dtpDatumZaposlenja.Size = new Size(174, 23);
            dtpDatumZaposlenja.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(147, 296);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 27);
            btnSave.TabIndex = 14;
            btnSave.Text = "Sačuvaj";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(241, 296);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 27);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Otkaži";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(147, 223);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(174, 23);
            dateTimePicker1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 226);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 18;
            label1.Text = "Datum kraja zaposlenja:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(148, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(173, 23);
            comboBox1.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 255);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 21;
            label2.Text = "Smena rada:";
            label2.Click += label2_Click;
            // 
            // cmbSmena
            // 
            cmbSmena.FormattingEnabled = true;
            cmbSmena.Location = new Point(148, 252);
            cmbSmena.Name = "cmbSmena";
            cmbSmena.Size = new Size(173, 23);
            cmbSmena.TabIndex = 29;
            // 
            // MenadzerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 335);
            Controls.Add(cmbSmena);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
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
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MenadzerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Menadžer";
            Load += MenadzerForm_Load;
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox cmbSmena;
    }
}
