namespace Farmacy.Forme
{
    partial class LekForm
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
            lblId.Location = new Point(20, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblHemijski
            // 
            lblHemijski.AutoSize = true;
            lblHemijski.Location = new Point(20, 52);
            lblHemijski.Name = "lblHemijski";
            lblHemijski.Size = new Size(86, 15);
            lblHemijski.TabIndex = 2;
            lblHemijski.Text = "Hemijski naziv:";
            // 
            // lblKomercijalni
            // 
            lblKomercijalni.AutoSize = true;
            lblKomercijalni.Location = new Point(20, 84);
            lblKomercijalni.Name = "lblKomercijalni";
            lblKomercijalni.Size = new Size(106, 15);
            lblKomercijalni.TabIndex = 4;
            lblKomercijalni.Text = "Komercijalni naziv:";
            // 
            // lblDejstvo
            // 
            lblDejstvo.AutoSize = true;
            lblDejstvo.Location = new Point(20, 116);
            lblDejstvo.Name = "lblDejstvo";
            lblDejstvo.Size = new Size(49, 15);
            lblDejstvo.TabIndex = 6;
            lblDejstvo.Text = "Dejstvo:";
            // 
            // lblProizvodjac
            // 
            lblProizvodjac.AutoSize = true;
            lblProizvodjac.Location = new Point(20, 148);
            lblProizvodjac.Name = "lblProizvodjac";
            lblProizvodjac.Size = new Size(68, 15);
            lblProizvodjac.TabIndex = 8;
            lblProizvodjac.Text = "Proizvođač:";
            // 
            // lblPrimarnaGrupa
            // 
            lblPrimarnaGrupa.AutoSize = true;
            lblPrimarnaGrupa.Location = new Point(20, 180);
            lblPrimarnaGrupa.Name = "lblPrimarnaGrupa";
            lblPrimarnaGrupa.Size = new Size(92, 15);
            lblPrimarnaGrupa.TabIndex = 10;
            lblPrimarnaGrupa.Text = "Primarna grupa:";
            // 
            // lblSekundarneKategorije
            // 
            lblSekundarneKategorije.AutoSize = true;
            lblSekundarneKategorije.Location = new Point(20, 212);
            lblSekundarneKategorije.Name = "lblSekundarneKategorije";
            lblSekundarneKategorije.Size = new Size(120, 15);
            lblSekundarneKategorije.TabIndex = 12;
            lblSekundarneKategorije.Text = "Sekundarne kategorije:";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLight;
            txtId.Location = new Point(160, 17);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(240, 23);
            txtId.TabIndex = 1;
            txtId.TabStop = false;
            // 
            // txtHemijski
            // 
            txtHemijski.Location = new Point(160, 49);
            txtHemijski.Name = "txtHemijski";
            txtHemijski.Size = new Size(240, 23);
            txtHemijski.TabIndex = 3;
            // 
            // txtKomercijalni
            // 
            txtKomercijalni.Location = new Point(160, 81);
            txtKomercijalni.Name = "txtKomercijalni";
            txtKomercijalni.Size = new Size(240, 23);
            txtKomercijalni.TabIndex = 5;
            // 
            // txtDejstvo
            // 
            txtDejstvo.Location = new Point(160, 113);
            txtDejstvo.Name = "txtDejstvo";
            txtDejstvo.Size = new Size(240, 23);
            txtDejstvo.TabIndex = 7;
            // 
            // cmbProizvodjac
            // 
            cmbProizvodjac.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProizvodjac.FormattingEnabled = true;
            cmbProizvodjac.Location = new Point(160, 145);
            cmbProizvodjac.Name = "cmbProizvodjac";
            cmbProizvodjac.Size = new Size(240, 23);
            cmbProizvodjac.TabIndex = 9;
            cmbProizvodjac.SelectedIndexChanged += cmbProizvodjac_SelectedIndexChanged;
            // 
            // cmbPrimarnaGrupa
            // 
            cmbPrimarnaGrupa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPrimarnaGrupa.FormattingEnabled = true;
            cmbPrimarnaGrupa.Location = new Point(160, 177);
            cmbPrimarnaGrupa.Name = "cmbPrimarnaGrupa";
            cmbPrimarnaGrupa.Size = new Size(240, 23);
            cmbPrimarnaGrupa.TabIndex = 11;
            cmbPrimarnaGrupa.SelectedIndexChanged += cmbPrimarnaGrupa_SelectedIndexChanged;
            // 
            // chkListSekundarneKategorije
            // 
            chkListSekundarneKategorije.CheckOnClick = true;
            chkListSekundarneKategorije.FormattingEnabled = true;
            chkListSekundarneKategorije.Location = new Point(160, 209);
            chkListSekundarneKategorije.Name = "chkListSekundarneKategorije";
            chkListSekundarneKategorije.Size = new Size(240, 100);
            chkListSekundarneKategorije.TabIndex = 13;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(160, 320);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(90, 28);
            btnSacuvaj.TabIndex = 14;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnOtkazi
            // 
            btnOtkazi.DialogResult = DialogResult.Cancel;
            btnOtkazi.Location = new Point(260, 320);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(90, 28);
            btnOtkazi.TabIndex = 15;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.UseVisualStyleBackColor = true;
            // 
            // LekForm
            // 
            AcceptButton = btnSacuvaj;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOtkazi;
            ClientSize = new Size(440, 370);
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
            MinimumSize = new Size(456, 309);
            Name = "LekForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lek";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion



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
