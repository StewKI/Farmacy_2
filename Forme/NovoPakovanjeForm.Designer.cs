namespace Farmacy.Forme
{
    partial class NovoPakovanjeForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblLek;
        private System.Windows.Forms.ComboBox cmbLek;
        private System.Windows.Forms.Label lblOblik;
        private System.Windows.Forms.ComboBox cmbOblik;
        private System.Windows.Forms.Label lblVelicinaPakovanja;
        private System.Windows.Forms.TextBox txtVelicinaPakovanja;
        private System.Windows.Forms.Label lblKolicinaAktivne;
        private System.Windows.Forms.TextBox txtKolicinaAktivne;
        private System.Windows.Forms.Label lblJedinicaMere;
        private System.Windows.Forms.TextBox txtJedinicaMere;
        private System.Windows.Forms.Label lblAmbalaza;
        private System.Windows.Forms.TextBox txtAmbalaza;
        private System.Windows.Forms.Label lblNacinCuvanja;
        private System.Windows.Forms.TextBox txtNacinCuvanja;
        private System.Windows.Forms.Label lblPreporuceniRokDana;
        private System.Windows.Forms.TextBox txtPreporuceniRokDana;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnOtkazi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblLek = new Label();
            cmbLek = new ComboBox();
            lblOblik = new Label();
            cmbOblik = new ComboBox();
            lblVelicinaPakovanja = new Label();
            txtVelicinaPakovanja = new TextBox();
            lblKolicinaAktivne = new Label();
            txtKolicinaAktivne = new TextBox();
            lblJedinicaMere = new Label();
            txtJedinicaMere = new TextBox();
            lblAmbalaza = new Label();
            txtAmbalaza = new TextBox();
            lblNacinCuvanja = new Label();
            txtNacinCuvanja = new TextBox();
            lblPreporuceniRokDana = new Label();
            txtPreporuceniRokDana = new TextBox();
            btnSacuvaj = new Button();
            btnOtkazi = new Button();
            SuspendLayout();
            // 
            // lblLek
            // 
            lblLek.AutoSize = true;
            lblLek.Location = new Point(20, 20);
            lblLek.Name = "lblLek";
            lblLek.Size = new Size(30, 15);
            lblLek.TabIndex = 0;
            lblLek.Text = "Lek:";
            // 
            // cmbLek
            // 
            cmbLek.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLek.FormattingEnabled = true;
            cmbLek.Location = new Point(150, 17);
            cmbLek.Name = "cmbLek";
            cmbLek.Size = new Size(200, 23);
            cmbLek.TabIndex = 1;
            // 
            // lblOblik
            // 
            lblOblik.AutoSize = true;
            lblOblik.Location = new Point(20, 60);
            lblOblik.Name = "lblOblik";
            lblOblik.Size = new Size(40, 15);
            lblOblik.TabIndex = 2;
            lblOblik.Text = "Oblik:";
            // 
            // cmbOblik
            // 
            cmbOblik.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOblik.FormattingEnabled = true;
            cmbOblik.Location = new Point(150, 57);
            cmbOblik.Name = "cmbOblik";
            cmbOblik.Size = new Size(200, 23);
            cmbOblik.TabIndex = 3;
            // 
            // lblVelicinaPakovanja
            // 
            lblVelicinaPakovanja.AutoSize = true;
            lblVelicinaPakovanja.Location = new Point(20, 100);
            lblVelicinaPakovanja.Name = "lblVelicinaPakovanja";
            lblVelicinaPakovanja.Size = new Size(100, 15);
            lblVelicinaPakovanja.TabIndex = 4;
            lblVelicinaPakovanja.Text = "Veličina pakovanja:";
            // 
            // txtVelicinaPakovanja
            // 
            txtVelicinaPakovanja.Location = new Point(150, 97);
            txtVelicinaPakovanja.Name = "txtVelicinaPakovanja";
            txtVelicinaPakovanja.Size = new Size(200, 23);
            txtVelicinaPakovanja.TabIndex = 5;
            // 
            // lblKolicinaAktivne
            // 
            lblKolicinaAktivne.AutoSize = true;
            lblKolicinaAktivne.Location = new Point(20, 140);
            lblKolicinaAktivne.Name = "lblKolicinaAktivne";
            lblKolicinaAktivne.Size = new Size(120, 15);
            lblKolicinaAktivne.TabIndex = 6;
            lblKolicinaAktivne.Text = "Količina aktivne supstance:";
            // 
            // txtKolicinaAktivne
            // 
            txtKolicinaAktivne.Location = new Point(150, 137);
            txtKolicinaAktivne.Name = "txtKolicinaAktivne";
            txtKolicinaAktivne.Size = new Size(200, 23);
            txtKolicinaAktivne.TabIndex = 7;
            // 
            // lblJedinicaMere
            // 
            lblJedinicaMere.AutoSize = true;
            lblJedinicaMere.Location = new Point(20, 180);
            lblJedinicaMere.Name = "lblJedinicaMere";
            lblJedinicaMere.Size = new Size(80, 15);
            lblJedinicaMere.TabIndex = 8;
            lblJedinicaMere.Text = "Jedinica mere:";
            // 
            // txtJedinicaMere
            // 
            txtJedinicaMere.Location = new Point(150, 177);
            txtJedinicaMere.Name = "txtJedinicaMere";
            txtJedinicaMere.Size = new Size(200, 23);
            txtJedinicaMere.TabIndex = 9;
            // 
            // lblAmbalaza
            // 
            lblAmbalaza.AutoSize = true;
            lblAmbalaza.Location = new Point(20, 220);
            lblAmbalaza.Name = "lblAmbalaza";
            lblAmbalaza.Size = new Size(60, 15);
            lblAmbalaza.TabIndex = 10;
            lblAmbalaza.Text = "Ambalaza:";
            // 
            // txtAmbalaza
            // 
            txtAmbalaza.Location = new Point(150, 217);
            txtAmbalaza.Name = "txtAmbalaza";
            txtAmbalaza.Size = new Size(200, 23);
            txtAmbalaza.TabIndex = 11;
            // 
            // lblNacinCuvanja
            // 
            lblNacinCuvanja.AutoSize = true;
            lblNacinCuvanja.Location = new Point(20, 260);
            lblNacinCuvanja.Name = "lblNacinCuvanja";
            lblNacinCuvanja.Size = new Size(90, 15);
            lblNacinCuvanja.TabIndex = 12;
            lblNacinCuvanja.Text = "Način čuvanja:";
            // 
            // txtNacinCuvanja
            // 
            txtNacinCuvanja.Location = new Point(150, 257);
            txtNacinCuvanja.Name = "txtNacinCuvanja";
            txtNacinCuvanja.Size = new Size(200, 23);
            txtNacinCuvanja.TabIndex = 13;
            // 
            // lblPreporuceniRokDana
            // 
            lblPreporuceniRokDana.AutoSize = true;
            lblPreporuceniRokDana.Location = new Point(20, 300);
            lblPreporuceniRokDana.Name = "lblPreporuceniRokDana";
            lblPreporuceniRokDana.Size = new Size(120, 15);
            lblPreporuceniRokDana.TabIndex = 14;
            lblPreporuceniRokDana.Text = "Preporučeni rok (dana):";
            // 
            // txtPreporuceniRokDana
            // 
            txtPreporuceniRokDana.Location = new Point(150, 297);
            txtPreporuceniRokDana.Name = "txtPreporuceniRokDana";
            txtPreporuceniRokDana.Size = new Size(200, 23);
            txtPreporuceniRokDana.TabIndex = 15;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(150, 340);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(100, 30);
            btnSacuvaj.TabIndex = 16;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnOtkazi
            // 
            btnOtkazi.Location = new Point(260, 340);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(90, 30);
            btnOtkazi.TabIndex = 17;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.UseVisualStyleBackColor = true;
            btnOtkazi.Click += btnOtkazi_Click;
            // 
            // NovoPakovanjeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 400);
            Controls.Add(btnOtkazi);
            Controls.Add(btnSacuvaj);
            Controls.Add(txtPreporuceniRokDana);
            Controls.Add(lblPreporuceniRokDana);
            Controls.Add(txtNacinCuvanja);
            Controls.Add(lblNacinCuvanja);
            Controls.Add(txtAmbalaza);
            Controls.Add(lblAmbalaza);
            Controls.Add(txtJedinicaMere);
            Controls.Add(lblJedinicaMere);
            Controls.Add(txtKolicinaAktivne);
            Controls.Add(lblKolicinaAktivne);
            Controls.Add(txtVelicinaPakovanja);
            Controls.Add(lblVelicinaPakovanja);
            Controls.Add(cmbOblik);
            Controls.Add(lblOblik);
            Controls.Add(cmbLek);
            Controls.Add(lblLek);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NovoPakovanjeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Novo pakovanje";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}







