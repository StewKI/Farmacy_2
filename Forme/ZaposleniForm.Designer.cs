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
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // lblMBr
            // 
            lblMBr.AutoSize = true;
            lblMBr.Location = new Point(30, 38);
            lblMBr.Name = "lblMBr";
            lblMBr.Size = new Size(51, 15);
            lblMBr.TabIndex = 0;
            lblMBr.Text = "Apoteka";
            lblMBr.Click += lblMBr_Click;
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
            txtPrezime.Location = new Point(165, 70);
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
            txtIme.Location = new Point(165, 110);
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
            dtpDatumRodj.Location = new Point(165, 150);
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
            txtAdresa.Location = new Point(165, 190);
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
            txtTelefon.Location = new Point(165, 230);
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
            dtpDatumZaposlenja.Location = new Point(165, 270);
            dtpDatumZaposlenja.Name = "dtpDatumZaposlenja";
            dtpDatumZaposlenja.Size = new Size(200, 23);
            dtpDatumZaposlenja.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(165, 368);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 14;
            btnSave.Text = "Sačuvaj";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(290, 368);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Otkaži";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 316);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 16;
            label1.Text = "Datum kraja zaposlenja";
            label1.Click += label1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(165, 310);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(165, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 18;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ZaposleniForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 404);
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
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ZaposleniForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Zaposleni";
            Load += ZaposleniForm_Load;
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
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
    }
}
