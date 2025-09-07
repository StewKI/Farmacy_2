namespace Farmacy.Forme
{
    partial class ZalihaForm
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
            this.lblProdajnaJedinica = new System.Windows.Forms.Label();
            this.cmbProdajnaJedinica = new System.Windows.Forms.ComboBox();
            this.lblPakovanje = new System.Windows.Forms.Label();
            this.cmbPakovanje = new System.Windows.Forms.ComboBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.lblDatumPoslednjeIsporuke = new System.Windows.Forms.Label();
            this.dtpDatumPoslednjeIsporuke = new System.Windows.Forms.DateTimePicker();
            this.lblOdgovorniMagacioner = new System.Windows.Forms.Label();
            this.cmbOdgovorniMagacioner = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProdajnaJedinica
            // 
            this.lblProdajnaJedinica.AutoSize = true;
            this.lblProdajnaJedinica.Location = new System.Drawing.Point(30, 30);
            this.lblProdajnaJedinica.Name = "lblProdajnaJedinica";
            this.lblProdajnaJedinica.Size = new System.Drawing.Size(100, 15);
            this.lblProdajnaJedinica.TabIndex = 0;
            this.lblProdajnaJedinica.Text = "Prodajna jedinica:";
            // 
            // cmbProdajnaJedinica
            // 
            this.cmbProdajnaJedinica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdajnaJedinica.FormattingEnabled = true;
            this.cmbProdajnaJedinica.Location = new System.Drawing.Point(150, 27);
            this.cmbProdajnaJedinica.Name = "cmbProdajnaJedinica";
            this.cmbProdajnaJedinica.Size = new System.Drawing.Size(200, 23);
            this.cmbProdajnaJedinica.TabIndex = 1;
            // 
            // lblPakovanje
            // 
            this.lblPakovanje.AutoSize = true;
            this.lblPakovanje.Location = new System.Drawing.Point(30, 70);
            this.lblPakovanje.Name = "lblPakovanje";
            this.lblPakovanje.Size = new System.Drawing.Size(70, 15);
            this.lblPakovanje.TabIndex = 2;
            this.lblPakovanje.Text = "Pakovanje:";
            // 
            // cmbPakovanje
            // 
            this.cmbPakovanje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPakovanje.FormattingEnabled = true;
            this.cmbPakovanje.Location = new System.Drawing.Point(150, 67);
            this.cmbPakovanje.Name = "cmbPakovanje";
            this.cmbPakovanje.Size = new System.Drawing.Size(200, 23);
            this.cmbPakovanje.TabIndex = 3;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(30, 110);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(55, 15);
            this.lblKolicina.TabIndex = 4;
            this.lblKolicina.Text = "Količina:";
            // 
            // numKolicina
            // 
            this.numKolicina.Location = new System.Drawing.Point(150, 107);
            this.numKolicina.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(200, 23);
            this.numKolicina.TabIndex = 5;
            // 
            // lblDatumPoslednjeIsporuke
            // 
            this.lblDatumPoslednjeIsporuke.AutoSize = true;
            this.lblDatumPoslednjeIsporuke.Location = new System.Drawing.Point(30, 150);
            this.lblDatumPoslednjeIsporuke.Name = "lblDatumPoslednjeIsporuke";
            this.lblDatumPoslednjeIsporuke.Size = new System.Drawing.Size(140, 15);
            this.lblDatumPoslednjeIsporuke.TabIndex = 6;
            this.lblDatumPoslednjeIsporuke.Text = "Datum poslednje isporuke:";
            // 
            // dtpDatumPoslednjeIsporuke
            // 
            this.dtpDatumPoslednjeIsporuke.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumPoslednjeIsporuke.Location = new System.Drawing.Point(150, 147);
            this.dtpDatumPoslednjeIsporuke.Name = "dtpDatumPoslednjeIsporuke";
            this.dtpDatumPoslednjeIsporuke.Size = new System.Drawing.Size(200, 23);
            this.dtpDatumPoslednjeIsporuke.TabIndex = 7;
            // 
            // lblOdgovorniMagacioner
            // 
            this.lblOdgovorniMagacioner.AutoSize = true;
            this.lblOdgovorniMagacioner.Location = new System.Drawing.Point(30, 190);
            this.lblOdgovorniMagacioner.Name = "lblOdgovorniMagacioner";
            this.lblOdgovorniMagacioner.Size = new System.Drawing.Size(130, 15);
            this.lblOdgovorniMagacioner.TabIndex = 8;
            this.lblOdgovorniMagacioner.Text = "Odgovorni magacioner:";
            // 
            // cmbOdgovorniMagacioner
            // 
            this.cmbOdgovorniMagacioner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdgovorniMagacioner.FormattingEnabled = true;
            this.cmbOdgovorniMagacioner.Location = new System.Drawing.Point(150, 187);
            this.cmbOdgovorniMagacioner.Name = "cmbOdgovorniMagacioner";
            this.cmbOdgovorniMagacioner.Size = new System.Drawing.Size(200, 23);
            this.cmbOdgovorniMagacioner.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(275, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Otkaži";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ZalihaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 291);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbOdgovorniMagacioner);
            this.Controls.Add(this.lblOdgovorniMagacioner);
            this.Controls.Add(this.dtpDatumPoslednjeIsporuke);
            this.Controls.Add(this.lblDatumPoslednjeIsporuke);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.cmbPakovanje);
            this.Controls.Add(this.lblPakovanje);
            this.Controls.Add(this.cmbProdajnaJedinica);
            this.Controls.Add(this.lblProdajnaJedinica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ZalihaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zaliha";
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblProdajnaJedinica;
        private System.Windows.Forms.ComboBox cmbProdajnaJedinica;
        private System.Windows.Forms.Label lblPakovanje;
        private System.Windows.Forms.ComboBox cmbPakovanje;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.Label lblDatumPoslednjeIsporuke;
        private System.Windows.Forms.DateTimePicker dtpDatumPoslednjeIsporuke;
        private System.Windows.Forms.Label lblOdgovorniMagacioner;
        private System.Windows.Forms.ComboBox cmbOdgovorniMagacioner;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
