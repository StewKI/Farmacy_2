namespace Farmacy.Forme
{
    partial class NoviReceptForm
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
            lblSerijskiBroj = new Label();
            txtSerijskiBroj = new TextBox();
            lblSifraLekara = new Label();
            txtSifraLekara = new TextBox();
            lblDatumIzd = new Label();
            dtpDatumIzd = new DateTimePicker();
            lblStatus = new Label();
            cboStatus = new ComboBox();
            lblNazivUstanove = new Label();
            txtNazivUstanove = new TextBox();
            lblRealizovanaProdajnaJedinica = new Label();
            txtRealizovanaProdajnaJedinica = new TextBox();
            lblRealizacijaDatum = new Label();
            dtpRealizacijaDatum = new DateTimePicker();
            lblRealizovaoFarmaceut = new Label();
            txtRealizovaoFarmaceut = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblSerijskiBroj
            // 
            lblSerijskiBroj.AutoSize = true;
            lblSerijskiBroj.Location = new Point(30, 30);
            lblSerijskiBroj.Name = "lblSerijskiBroj";
            lblSerijskiBroj.Size = new Size(70, 15);
            lblSerijskiBroj.TabIndex = 0;
            lblSerijskiBroj.Text = "Serijski broj:";
            // 
            // txtSerijskiBroj
            // 
            txtSerijskiBroj.Location = new Point(150, 27);
            txtSerijskiBroj.Name = "txtSerijskiBroj";
            txtSerijskiBroj.Size = new Size(200, 23);
            txtSerijskiBroj.TabIndex = 1;
            // 
            // lblSifraLekara
            // 
            lblSifraLekara.AutoSize = true;
            lblSifraLekara.Location = new Point(30, 70);
            lblSifraLekara.Name = "lblSifraLekara";
            lblSifraLekara.Size = new Size(67, 15);
            lblSifraLekara.TabIndex = 2;
            lblSifraLekara.Text = "Šifra lekara:";
            // 
            // txtSifraLekara
            // 
            txtSifraLekara.Location = new Point(150, 67);
            txtSifraLekara.Name = "txtSifraLekara";
            txtSifraLekara.Size = new Size(200, 23);
            txtSifraLekara.TabIndex = 3;
            // 
            // lblDatumIzd
            // 
            lblDatumIzd.AutoSize = true;
            lblDatumIzd.Location = new Point(30, 110);
            lblDatumIzd.Name = "lblDatumIzd";
            lblDatumIzd.Size = new Size(98, 15);
            lblDatumIzd.TabIndex = 4;
            lblDatumIzd.Text = "Datum izdavanja:";
            // 
            // dtpDatumIzd
            // 
            dtpDatumIzd.Format = DateTimePickerFormat.Short;
            dtpDatumIzd.Location = new Point(150, 107);
            dtpDatumIzd.Name = "dtpDatumIzd";
            dtpDatumIzd.Size = new Size(200, 23);
            dtpDatumIzd.TabIndex = 5;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(30, 150);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status:";
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(150, 147);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(200, 23);
            cboStatus.TabIndex = 7;
            // 
            // lblNazivUstanove
            // 
            lblNazivUstanove.AutoSize = true;
            lblNazivUstanove.Location = new Point(30, 190);
            lblNazivUstanove.Name = "lblNazivUstanove";
            lblNazivUstanove.Size = new Size(90, 15);
            lblNazivUstanove.TabIndex = 8;
            lblNazivUstanove.Text = "Naziv ustanove:";
            // 
            // txtNazivUstanove
            // 
            txtNazivUstanove.Location = new Point(150, 187);
            txtNazivUstanove.Name = "txtNazivUstanove";
            txtNazivUstanove.Size = new Size(200, 23);
            txtNazivUstanove.TabIndex = 9;
            // 
            // lblRealizovanaProdajnaJedinica
            // 
            lblRealizovanaProdajnaJedinica.AutoSize = true;
            lblRealizovanaProdajnaJedinica.Location = new Point(30, 230);
            lblRealizovanaProdajnaJedinica.Name = "lblRealizovanaProdajnaJedinica";
            lblRealizovanaProdajnaJedinica.Size = new Size(166, 15);
            lblRealizovanaProdajnaJedinica.TabIndex = 10;
            lblRealizovanaProdajnaJedinica.Text = "Realizovana prodajna jedinica:";
            // 
            // txtRealizovanaProdajnaJedinica
            // 
            txtRealizovanaProdajnaJedinica.Location = new Point(200, 227);
            txtRealizovanaProdajnaJedinica.Name = "txtRealizovanaProdajnaJedinica";
            txtRealizovanaProdajnaJedinica.ReadOnly = true;
            txtRealizovanaProdajnaJedinica.Size = new Size(150, 23);
            txtRealizovanaProdajnaJedinica.TabIndex = 11;
            txtRealizovanaProdajnaJedinica.TabStop = false;
            // 
            // lblRealizacijaDatum
            // 
            lblRealizacijaDatum.AutoSize = true;
            lblRealizacijaDatum.Location = new Point(30, 270);
            lblRealizacijaDatum.Name = "lblRealizacijaDatum";
            lblRealizacijaDatum.Size = new Size(100, 15);
            lblRealizacijaDatum.TabIndex = 12;
            lblRealizacijaDatum.Text = "Datum realizacije:";
            // 
            // dtpRealizacijaDatum
            // 
            dtpRealizacijaDatum.Enabled = false;
            dtpRealizacijaDatum.Format = DateTimePickerFormat.Short;
            dtpRealizacijaDatum.Location = new Point(150, 267);
            dtpRealizacijaDatum.Name = "dtpRealizacijaDatum";
            dtpRealizacijaDatum.Size = new Size(200, 23);
            dtpRealizacijaDatum.TabIndex = 13;
            dtpRealizacijaDatum.ValueChanged += dtpRealizacijaDatum_ValueChanged;
            // 
            // lblRealizovaoFarmaceut
            // 
            lblRealizovaoFarmaceut.AutoSize = true;
            lblRealizovaoFarmaceut.Location = new Point(30, 310);
            lblRealizovaoFarmaceut.Name = "lblRealizovaoFarmaceut";
            lblRealizovaoFarmaceut.Size = new Size(123, 15);
            lblRealizovaoFarmaceut.TabIndex = 14;
            lblRealizovaoFarmaceut.Text = "Realizovao farmaceut:";
            // 
            // txtRealizovaoFarmaceut
            // 
            txtRealizovaoFarmaceut.Location = new Point(160, 307);
            txtRealizovaoFarmaceut.Name = "txtRealizovaoFarmaceut";
            txtRealizovaoFarmaceut.ReadOnly = true;
            txtRealizovaoFarmaceut.Size = new Size(190, 23);
            txtRealizovaoFarmaceut.TabIndex = 15;
            txtRealizovaoFarmaceut.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(150, 360);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 16;
            btnSave.Text = "Sačuvaj";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(275, 360);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Otkaži";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ReceptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 411);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtRealizovaoFarmaceut);
            Controls.Add(lblRealizovaoFarmaceut);
            Controls.Add(dtpRealizacijaDatum);
            Controls.Add(lblRealizacijaDatum);
            Controls.Add(txtRealizovanaProdajnaJedinica);
            Controls.Add(lblRealizovanaProdajnaJedinica);
            Controls.Add(txtNazivUstanove);
            Controls.Add(lblNazivUstanove);
            Controls.Add(cboStatus);
            Controls.Add(lblStatus);
            Controls.Add(dtpDatumIzd);
            Controls.Add(lblDatumIzd);
            Controls.Add(txtSifraLekara);
            Controls.Add(lblSifraLekara);
            Controls.Add(txtSerijskiBroj);
            Controls.Add(lblSerijskiBroj);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NoviReceptForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Recept";
            Load += NoviReceptForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSerijskiBroj;
        private System.Windows.Forms.TextBox txtSerijskiBroj;
        private System.Windows.Forms.Label lblSifraLekara;
        private System.Windows.Forms.TextBox txtSifraLekara;
        private System.Windows.Forms.Label lblDatumIzd;
        private System.Windows.Forms.DateTimePicker dtpDatumIzd;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblNazivUstanove;
        private System.Windows.Forms.TextBox txtNazivUstanove;
        private System.Windows.Forms.Label lblRealizovanaProdajnaJedinica;
        private System.Windows.Forms.TextBox txtRealizovanaProdajnaJedinica;
        private System.Windows.Forms.Label lblRealizacijaDatum;
        private System.Windows.Forms.DateTimePicker dtpRealizacijaDatum;
        private System.Windows.Forms.Label lblRealizovaoFarmaceut;
        private System.Windows.Forms.TextBox txtRealizovaoFarmaceut;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
