namespace Farmacy.Forme
{
    partial class IzmeniPakovanjeForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
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
            lblId = new Label();
            txtId = new TextBox();
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
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(20, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(150, 17);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(200, 23);
            txtId.TabIndex = 1;
            // 
            // lblLek
            // 
            lblLek.AutoSize = true;
            lblLek.Location = new Point(20, 60);
            lblLek.Name = "lblLek";
            lblLek.Size = new Size(30, 15);
            lblLek.TabIndex = 2;
            lblLek.Text = "Lek:";
            // 
            // cmbLek
            // 
            cmbLek.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLek.FormattingEnabled = true;
            cmbLek.Location = new Point(150, 57);
            cmbLek.Name = "cmbLek";
            cmbLek.Size = new Size(200, 23);
            cmbLek.TabIndex = 3;
            // 
            // lblOblik
            // 
            lblOblik.AutoSize = true;
            lblOblik.Location = new Point(20, 100);
            lblOblik.Name = "lblOblik";
            lblOblik.Size = new Size(40, 15);
            lblOblik.TabIndex = 4;
            lblOblik.Text = "Oblik:";
            // 
            // cmbOblik
            // 
            cmbOblik.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOblik.FormattingEnabled = true;
            cmbOblik.Location = new Point(150, 97);
            cmbOblik.Name = "cmbOblik";
            cmbOblik.Size = new Size(200, 23);
            cmbOblik.TabIndex = 5;
            // 
            // lblVelicinaPakovanja
            // 
            lblVelicinaPakovanja.AutoSize = true;
            lblVelicinaPakovanja.Location = new Point(20, 140);
            lblVelicinaPakovanja.Name = "lblVelicinaPakovanja";
            lblVelicinaPakovanja.Size = new Size(100, 15);
            lblVelicinaPakovanja.TabIndex = 6;
            lblVelicinaPakovanja.Text = "Veličina pakovanja:";
            // 
            // txtVelicinaPakovanja
            // 
            txtVelicinaPakovanja.Location = new Point(150, 137);
            txtVelicinaPakovanja.Name = "txtVelicinaPakovanja";
            txtVelicinaPakovanja.Size = new Size(200, 23);
            txtVelicinaPakovanja.TabIndex = 7;
            // 
            // lblKolicinaAktivne
            // 
            lblKolicinaAktivne.AutoSize = true;
            lblKolicinaAktivne.Location = new Point(20, 180);
            lblKolicinaAktivne.Name = "lblKolicinaAktivne";
            lblKolicinaAktivne.Size = new Size(120, 15);
            lblKolicinaAktivne.TabIndex = 8;
            lblKolicinaAktivne.Text = "Količina aktivne supstance:";
            // 
            // txtKolicinaAktivne
            // 
            txtKolicinaAktivne.Location = new Point(150, 177);
            txtKolicinaAktivne.Name = "txtKolicinaAktivne";
            txtKolicinaAktivne.Size = new Size(200, 23);
            txtKolicinaAktivne.TabIndex = 9;
            // 
            // lblJedinicaMere
            // 
            lblJedinicaMere.AutoSize = true;
            lblJedinicaMere.Location = new Point(20, 220);
            lblJedinicaMere.Name = "lblJedinicaMere";
            lblJedinicaMere.Size = new Size(80, 15);
            lblJedinicaMere.TabIndex = 10;
            lblJedinicaMere.Text = "Jedinica mere:";
            // 
            // txtJedinicaMere
            // 
            txtJedinicaMere.Location = new Point(150, 217);
            txtJedinicaMere.Name = "txtJedinicaMere";
            txtJedinicaMere.Size = new Size(200, 23);
            txtJedinicaMere.TabIndex = 11;
            // 
            // lblAmbalaza
            // 
            lblAmbalaza.AutoSize = true;
            lblAmbalaza.Location = new Point(20, 260);
            lblAmbalaza.Name = "lblAmbalaza";
            lblAmbalaza.Size = new Size(60, 15);
            lblAmbalaza.TabIndex = 12;
            lblAmbalaza.Text = "Ambalaza:";
            // 
            // txtAmbalaza
            // 
            txtAmbalaza.Location = new Point(150, 257);
            txtAmbalaza.Name = "txtAmbalaza";
            txtAmbalaza.Size = new Size(200, 23);
            txtAmbalaza.TabIndex = 13;
            // 
            // lblNacinCuvanja
            // 
            lblNacinCuvanja.AutoSize = true;
            lblNacinCuvanja.Location = new Point(20, 300);
            lblNacinCuvanja.Name = "lblNacinCuvanja";
            lblNacinCuvanja.Size = new Size(90, 15);
            lblNacinCuvanja.TabIndex = 14;
            lblNacinCuvanja.Text = "Način čuvanja:";
            // 
            // txtNacinCuvanja
            // 
            txtNacinCuvanja.Location = new Point(150, 297);
            txtNacinCuvanja.Name = "txtNacinCuvanja";
            txtNacinCuvanja.Size = new Size(200, 23);
            txtNacinCuvanja.TabIndex = 15;
            // 
            // lblPreporuceniRokDana
            // 
            lblPreporuceniRokDana.AutoSize = true;
            lblPreporuceniRokDana.Location = new Point(20, 340);
            lblPreporuceniRokDana.Name = "lblPreporuceniRokDana";
            lblPreporuceniRokDana.Size = new Size(120, 15);
            lblPreporuceniRokDana.TabIndex = 16;
            lblPreporuceniRokDana.Text = "Preporučeni rok (dana):";
            // 
            // txtPreporuceniRokDana
            // 
            txtPreporuceniRokDana.Location = new Point(150, 337);
            txtPreporuceniRokDana.Name = "txtPreporuceniRokDana";
            txtPreporuceniRokDana.Size = new Size(200, 23);
            txtPreporuceniRokDana.TabIndex = 17;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(150, 380);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(100, 30);
            btnSacuvaj.TabIndex = 18;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnOtkazi
            // 
            btnOtkazi.Location = new Point(260, 380);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(90, 30);
            btnOtkazi.TabIndex = 19;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.UseVisualStyleBackColor = true;
            btnOtkazi.Click += btnOtkazi_Click;
            // 
            // IzmeniPakovanjeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 440);
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
            Controls.Add(txtId);
            Controls.Add(lblId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "IzmeniPakovanjeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Izmeni pakovanje";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}









