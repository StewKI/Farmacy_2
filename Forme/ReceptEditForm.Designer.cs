namespace Farmacy.Forme
{
    partial class ReceptEditForm
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
            this.lblSerijskiBroj = new System.Windows.Forms.Label();
            this.txtSerijskiBroj = new System.Windows.Forms.TextBox();
            this.lblSifraLekara = new System.Windows.Forms.Label();
            this.txtSifraLekara = new System.Windows.Forms.TextBox();
            this.lblDatumIzd = new System.Windows.Forms.Label();
            this.dtpDatumIzd = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblNazivUstanove = new System.Windows.Forms.Label();
            this.txtNazivUstanove = new System.Windows.Forms.TextBox();
            this.lblRealizovanaProdajnaJedinica = new System.Windows.Forms.Label();
            this.txtRealizovanaProdajnaJedinica = new System.Windows.Forms.TextBox();
            this.lblRealizacijaDatum = new System.Windows.Forms.Label();
            this.dtpRealizacijaDatum = new System.Windows.Forms.DateTimePicker();
            this.lblRealizovaoFarmaceut = new System.Windows.Forms.Label();
            this.txtRealizovaoFarmaceut = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSerijskiBroj
            // 
            this.lblSerijskiBroj.AutoSize = true;
            this.lblSerijskiBroj.Location = new System.Drawing.Point(12, 15);
            this.lblSerijskiBroj.Name = "lblSerijskiBroj";
            this.lblSerijskiBroj.Size = new System.Drawing.Size(73, 13);
            this.lblSerijskiBroj.TabIndex = 0;
            this.lblSerijskiBroj.Text = "Serijski broj:";
            // 
            // txtSerijskiBroj
            // 
            this.txtSerijskiBroj.Location = new System.Drawing.Point(120, 12);
            this.txtSerijskiBroj.Name = "txtSerijskiBroj";
            this.txtSerijskiBroj.Size = new System.Drawing.Size(200, 20);
            this.txtSerijskiBroj.TabIndex = 1;
            // 
            // lblSifraLekara
            // 
            this.lblSifraLekara.AutoSize = true;
            this.lblSifraLekara.Location = new System.Drawing.Point(12, 41);
            this.lblSifraLekara.Name = "lblSifraLekara";
            this.lblSifraLekara.Size = new System.Drawing.Size(67, 13);
            this.lblSifraLekara.TabIndex = 2;
            this.lblSifraLekara.Text = "Šifra lekara:";
            // 
            // txtSifraLekara
            // 
            this.txtSifraLekara.Location = new System.Drawing.Point(120, 38);
            this.txtSifraLekara.Name = "txtSifraLekara";
            this.txtSifraLekara.Size = new System.Drawing.Size(200, 20);
            this.txtSifraLekara.TabIndex = 3;
            // 
            // lblDatumIzd
            // 
            this.lblDatumIzd.AutoSize = true;
            this.lblDatumIzd.Location = new System.Drawing.Point(12, 67);
            this.lblDatumIzd.Name = "lblDatumIzd";
            this.lblDatumIzd.Size = new System.Drawing.Size(67, 13);
            this.lblDatumIzd.TabIndex = 4;
            this.lblDatumIzd.Text = "Datum izd:";
            // 
            // dtpDatumIzd
            // 
            this.dtpDatumIzd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumIzd.Location = new System.Drawing.Point(120, 64);
            this.dtpDatumIzd.Name = "dtpDatumIzd";
            this.dtpDatumIzd.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumIzd.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 93);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Aktivan",
            "Realizovan",
            "Otkazan"});
            this.cmbStatus.Location = new System.Drawing.Point(120, 90);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 7;
            // 
            // lblNazivUstanove
            // 
            this.lblNazivUstanove.AutoSize = true;
            this.lblNazivUstanove.Location = new System.Drawing.Point(12, 119);
            this.lblNazivUstanove.Name = "lblNazivUstanove";
            this.lblNazivUstanove.Size = new System.Drawing.Size(82, 13);
            this.lblNazivUstanove.TabIndex = 8;
            this.lblNazivUstanove.Text = "Naziv ustanove:";
            // 
            // txtNazivUstanove
            // 
            this.txtNazivUstanove.Location = new System.Drawing.Point(120, 116);
            this.txtNazivUstanove.Name = "txtNazivUstanove";
            this.txtNazivUstanove.Size = new System.Drawing.Size(200, 20);
            this.txtNazivUstanove.TabIndex = 9;
            // 
            // lblRealizovanaProdajnaJedinica
            // 
            this.lblRealizovanaProdajnaJedinica.AutoSize = true;
            this.lblRealizovanaProdajnaJedinica.Location = new System.Drawing.Point(12, 145);
            this.lblRealizovanaProdajnaJedinica.Name = "lblRealizovanaProdajnaJedinica";
            this.lblRealizovanaProdajnaJedinica.Size = new System.Drawing.Size(147, 13);
            this.lblRealizovanaProdajnaJedinica.TabIndex = 10;
            this.lblRealizovanaProdajnaJedinica.Text = "Realizovana prodajna jedinica:";
            // 
            // txtRealizovanaProdajnaJedinica
            // 
            this.txtRealizovanaProdajnaJedinica.Location = new System.Drawing.Point(120, 142);
            this.txtRealizovanaProdajnaJedinica.Name = "txtRealizovanaProdajnaJedinica";
            this.txtRealizovanaProdajnaJedinica.ReadOnly = true;
            this.txtRealizovanaProdajnaJedinica.Size = new System.Drawing.Size(200, 20);
            this.txtRealizovanaProdajnaJedinica.TabIndex = 11;
            // 
            // lblRealizacijaDatum
            // 
            this.lblRealizacijaDatum.AutoSize = true;
            this.lblRealizacijaDatum.Location = new System.Drawing.Point(12, 171);
            this.lblRealizacijaDatum.Name = "lblRealizacijaDatum";
            this.lblRealizacijaDatum.Size = new System.Drawing.Size(89, 13);
            this.lblRealizacijaDatum.TabIndex = 12;
            this.lblRealizacijaDatum.Text = "Realizacija datum:";
            // 
            // dtpRealizacijaDatum
            // 
            this.dtpRealizacijaDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRealizacijaDatum.Location = new System.Drawing.Point(120, 168);
            this.dtpRealizacijaDatum.Name = "dtpRealizacijaDatum";
            this.dtpRealizacijaDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpRealizacijaDatum.TabIndex = 13;
            // 
            // lblRealizovaoFarmaceut
            // 
            this.lblRealizovaoFarmaceut.AutoSize = true;
            this.lblRealizovaoFarmaceut.Location = new System.Drawing.Point(12, 197);
            this.lblRealizovaoFarmaceut.Name = "lblRealizovaoFarmaceut";
            this.lblRealizovaoFarmaceut.Size = new System.Drawing.Size(108, 13);
            this.lblRealizovaoFarmaceut.TabIndex = 14;
            this.lblRealizovaoFarmaceut.Text = "Realizovao farmaceut:";
            // 
            // txtRealizovaoFarmaceut
            // 
            this.txtRealizovaoFarmaceut.Location = new System.Drawing.Point(120, 194);
            this.txtRealizovaoFarmaceut.Name = "txtRealizovaoFarmaceut";
            this.txtRealizovaoFarmaceut.ReadOnly = true;
            this.txtRealizovaoFarmaceut.Size = new System.Drawing.Size(200, 20);
            this.txtRealizovaoFarmaceut.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(245, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Otkaži";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ReceptEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 265);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRealizovaoFarmaceut);
            this.Controls.Add(this.lblRealizovaoFarmaceut);
            this.Controls.Add(this.dtpRealizacijaDatum);
            this.Controls.Add(this.lblRealizacijaDatum);
            this.Controls.Add(this.txtRealizovanaProdajnaJedinica);
            this.Controls.Add(this.lblRealizovanaProdajnaJedinica);
            this.Controls.Add(this.txtNazivUstanove);
            this.Controls.Add(this.lblNazivUstanove);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dtpDatumIzd);
            this.Controls.Add(this.lblDatumIzd);
            this.Controls.Add(this.txtSifraLekara);
            this.Controls.Add(this.lblSifraLekara);
            this.Controls.Add(this.txtSerijskiBroj);
            this.Controls.Add(this.lblSerijskiBroj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReceptEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Uredi Recept";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSerijskiBroj;
        private System.Windows.Forms.TextBox txtSerijskiBroj;
        private System.Windows.Forms.Label lblSifraLekara;
        private System.Windows.Forms.TextBox txtSifraLekara;
        private System.Windows.Forms.Label lblDatumIzd;
        private System.Windows.Forms.DateTimePicker dtpDatumIzd;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
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
