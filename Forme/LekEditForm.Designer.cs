namespace Farmacy_2.Forme
{
    partial class LekEditForm
    {
        private System.ComponentModel.IContainer components = null;

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
            lblHemijski = new Label();
            lblKomercijalni = new Label();
            lblDejstvo = new Label();
            lblProizvodjac = new Label();
            lblPrimarnaGrupa = new Label();
            lblSekundarneKategorije = new Label();
            txtId = new TextBox();
            txtHemijski = new TextBox();
            txtKomercijalni = new TextBox();
            txtDejstvo = new TextBox();
            cmbProizvodjac = new ComboBox();
            cmbPrimarnaGrupa = new ComboBox();
            chkListSekundarneKategorije = new CheckedListBox();
            btnSacuvaj = new Button();
            btnOtkazi = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(37, 43);
            lblId.Margin = new Padding(6, 0, 6, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(42, 32);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblHemijski
            // 
            lblHemijski.AutoSize = true;
            lblHemijski.Location = new Point(37, 111);
            lblHemijski.Margin = new Padding(6, 0, 6, 0);
            lblHemijski.Name = "lblHemijski";
            lblHemijski.Size = new Size(172, 32);
            lblHemijski.TabIndex = 2;
            lblHemijski.Text = "Hemijski naziv:";
            // 
            // lblKomercijalni
            // 
            lblKomercijalni.AutoSize = true;
            lblKomercijalni.Location = new Point(37, 179);
            lblKomercijalni.Margin = new Padding(6, 0, 6, 0);
            lblKomercijalni.Name = "lblKomercijalni";
            lblKomercijalni.Size = new Size(211, 32);
            lblKomercijalni.TabIndex = 4;
            lblKomercijalni.Text = "Komercijalni naziv:";
            // 
            // lblDejstvo
            // 
            lblDejstvo.AutoSize = true;
            lblDejstvo.Location = new Point(37, 247);
            lblDejstvo.Margin = new Padding(6, 0, 6, 0);
            lblDejstvo.Name = "lblDejstvo";
            lblDejstvo.Size = new Size(99, 32);
            lblDejstvo.TabIndex = 6;
            lblDejstvo.Text = "Dejstvo:";
            // 
            // lblProizvodjac
            // 
            lblProizvodjac.AutoSize = true;
            lblProizvodjac.Location = new Point(37, 316);
            lblProizvodjac.Margin = new Padding(6, 0, 6, 0);
            lblProizvodjac.Name = "lblProizvodjac";
            lblProizvodjac.Size = new Size(134, 32);
            lblProizvodjac.TabIndex = 8;
            lblProizvodjac.Text = "Proizvođač:";
            // 
            // lblPrimarnaGrupa
            // 
            lblPrimarnaGrupa.AutoSize = true;
            lblPrimarnaGrupa.Location = new Point(37, 384);
            lblPrimarnaGrupa.Margin = new Padding(6, 0, 6, 0);
            lblPrimarnaGrupa.Name = "lblPrimarnaGrupa";
            lblPrimarnaGrupa.Size = new Size(182, 32);
            lblPrimarnaGrupa.TabIndex = 10;
            lblPrimarnaGrupa.Text = "Primarna grupa:";
            // 
            // lblSekundarneKategorije
            // 
            lblSekundarneKategorije.AutoSize = true;
            lblSekundarneKategorije.Location = new Point(37, 452);
            lblSekundarneKategorije.Margin = new Padding(6, 0, 6, 0);
            lblSekundarneKategorije.Name = "lblSekundarneKategorije";
            lblSekundarneKategorije.Size = new Size(259, 32);
            lblSekundarneKategorije.TabIndex = 12;
            lblSekundarneKategorije.Text = "Sekundarne kategorije:";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLight;
            txtId.Location = new Point(297, 36);
            txtId.Margin = new Padding(6, 6, 6, 6);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(442, 39);
            txtId.TabIndex = 1;
            txtId.TabStop = false;
            // 
            // txtHemijski
            // 
            txtHemijski.Location = new Point(297, 105);
            txtHemijski.Margin = new Padding(6, 6, 6, 6);
            txtHemijski.Name = "txtHemijski";
            txtHemijski.Size = new Size(442, 39);
            txtHemijski.TabIndex = 3;
            // 
            // txtKomercijalni
            // 
            txtKomercijalni.Location = new Point(297, 173);
            txtKomercijalni.Margin = new Padding(6, 6, 6, 6);
            txtKomercijalni.Name = "txtKomercijalni";
            txtKomercijalni.Size = new Size(442, 39);
            txtKomercijalni.TabIndex = 5;
            // 
            // txtDejstvo
            // 
            txtDejstvo.Location = new Point(297, 241);
            txtDejstvo.Margin = new Padding(6, 6, 6, 6);
            txtDejstvo.Name = "txtDejstvo";
            txtDejstvo.Size = new Size(442, 39);
            txtDejstvo.TabIndex = 7;
            // 
            // cmbProizvodjac
            // 
            cmbProizvodjac.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProizvodjac.FormattingEnabled = true;
            cmbProizvodjac.Location = new Point(297, 309);
            cmbProizvodjac.Margin = new Padding(6, 6, 6, 6);
            cmbProizvodjac.Name = "cmbProizvodjac";
            cmbProizvodjac.Size = new Size(442, 40);
            cmbProizvodjac.TabIndex = 9;
            cmbProizvodjac.SelectedIndexChanged += cmbProizvodjac_SelectedIndexChanged;
            // 
            // cmbPrimarnaGrupa
            // 
            cmbPrimarnaGrupa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPrimarnaGrupa.FormattingEnabled = true;
            cmbPrimarnaGrupa.Location = new Point(297, 378);
            cmbPrimarnaGrupa.Margin = new Padding(6, 6, 6, 6);
            cmbPrimarnaGrupa.Name = "cmbPrimarnaGrupa";
            cmbPrimarnaGrupa.Size = new Size(442, 40);
            cmbPrimarnaGrupa.TabIndex = 11;
            // 
            // chkListSekundarneKategorije
            // 
            chkListSekundarneKategorije.CheckOnClick = true;
            chkListSekundarneKategorije.FormattingEnabled = true;
            chkListSekundarneKategorije.Location = new Point(297, 446);
            chkListSekundarneKategorije.Margin = new Padding(6, 6, 6, 6);
            chkListSekundarneKategorije.Name = "chkListSekundarneKategorije";
            chkListSekundarneKategorije.Size = new Size(442, 184);
            chkListSekundarneKategorije.TabIndex = 13;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(297, 683);
            btnSacuvaj.Margin = new Padding(6, 6, 6, 6);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(167, 60);
            btnSacuvaj.TabIndex = 14;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSave_Click;
            // 
            // btnOtkazi
            // 
            btnOtkazi.DialogResult = DialogResult.Cancel;
            btnOtkazi.Location = new Point(483, 683);
            btnOtkazi.Margin = new Padding(6, 6, 6, 6);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(167, 60);
            btnOtkazi.TabIndex = 15;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.UseVisualStyleBackColor = true;
            // 
            // LekEditForm
            // 
            AcceptButton = btnSacuvaj;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOtkazi;
            ClientSize = new Size(871, 826);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(lblHemijski);
            Controls.Add(txtHemijski);
            Controls.Add(lblKomercijalni);
            Controls.Add(txtKomercijalni);
            Controls.Add(lblDejstvo);
            Controls.Add(txtDejstvo);
            Controls.Add(lblProizvodjac);
            Controls.Add(cmbProizvodjac);
            Controls.Add(lblPrimarnaGrupa);
            Controls.Add(cmbPrimarnaGrupa);
            Controls.Add(lblSekundarneKategorije);
            Controls.Add(chkListSekundarneKategorije);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnOtkazi);
            Margin = new Padding(6, 6, 6, 6);
            MinimumSize = new Size(825, 579);
            Name = "LekEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lek";
            Load += LekEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblHemijski;
        private System.Windows.Forms.Label lblKomercijalni;
        private System.Windows.Forms.Label lblDejstvo;
        private System.Windows.Forms.Label lblProizvodjac;
        private System.Windows.Forms.Label lblPrimarnaGrupa;
        private System.Windows.Forms.Label lblSekundarneKategorije;

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtHemijski;
        private System.Windows.Forms.TextBox txtKomercijalni;
        private System.Windows.Forms.TextBox txtDejstvo;
        private System.Windows.Forms.ComboBox cmbProizvodjac;

        private System.Windows.Forms.ComboBox cmbPrimarnaGrupa;
        private System.Windows.Forms.CheckedListBox chkListSekundarneKategorije;

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnOtkazi;
    }
}
