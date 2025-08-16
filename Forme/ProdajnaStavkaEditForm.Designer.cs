namespace Farmacy_2.Forme
{
    partial class ProdajnaStavkaEditForm
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
            this.lblProdaja = new System.Windows.Forms.Label();
            this.txtProdaja = new System.Windows.Forms.TextBox();
            this.lblPakovanje = new System.Windows.Forms.Label();
            this.txtPakovanje = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.lblCena = new System.Windows.Forms.Label();
            this.numCena = new System.Windows.Forms.NumericUpDown();
            this.lblRecept = new System.Windows.Forms.Label();
            this.txtRecept = new System.Windows.Forms.TextBox();
            this.lblKontrolisanaKol = new System.Windows.Forms.Label();
            this.numKontrolisanaKol = new System.Windows.Forms.NumericUpDown();
            this.lblProcenatParticip = new System.Windows.Forms.Label();
            this.numProcenatParticip = new System.Windows.Forms.NumericUpDown();
            this.lblNeophodanIzvestaj = new System.Windows.Forms.Label();
            this.cmbNeophodanIzvestaj = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKontrolisanaKol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProcenatParticip)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProdaja
            // 
            this.lblProdaja.AutoSize = true;
            this.lblProdaja.Location = new System.Drawing.Point(12, 15);
            this.lblProdaja.Name = "lblProdaja";
            this.lblProdaja.Size = new System.Drawing.Size(52, 15);
            this.lblProdaja.TabIndex = 0;
            this.lblProdaja.Text = "Prodaja:";
            // 
            // txtProdaja
            // 
            this.txtProdaja.Location = new System.Drawing.Point(120, 12);
            this.txtProdaja.Name = "txtProdaja";
            this.txtProdaja.ReadOnly = true;
            this.txtProdaja.Size = new System.Drawing.Size(200, 23);
            this.txtProdaja.TabIndex = 1;
            // 
            // lblPakovanje
            // 
            this.lblPakovanje.AutoSize = true;
            this.lblPakovanje.Location = new System.Drawing.Point(12, 44);
            this.lblPakovanje.Name = "lblPakovanje";
            this.lblPakovanje.Size = new System.Drawing.Size(70, 15);
            this.lblPakovanje.TabIndex = 2;
            this.lblPakovanje.Text = "Pakovanje:";
            // 
            // txtPakovanje
            // 
            this.txtPakovanje.Location = new System.Drawing.Point(120, 41);
            this.txtPakovanje.Name = "txtPakovanje";
            this.txtPakovanje.ReadOnly = true;
            this.txtPakovanje.Size = new System.Drawing.Size(200, 23);
            this.txtPakovanje.TabIndex = 3;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(12, 73);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(54, 15);
            this.lblKolicina.TabIndex = 4;
            this.lblKolicina.Text = "Količina:";
            // 
            // numKolicina
            // 
            this.numKolicina.Location = new System.Drawing.Point(120, 70);
            this.numKolicina.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(120, 23);
            this.numKolicina.TabIndex = 5;
            this.numKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(12, 102);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(38, 15);
            this.lblCena.TabIndex = 6;
            this.lblCena.Text = "Cena:";
            // 
            // numCena
            // 
            this.numCena.DecimalPlaces = 2;
            this.numCena.Location = new System.Drawing.Point(120, 99);
            this.numCena.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCena.Name = "numCena";
            this.numCena.Size = new System.Drawing.Size(120, 23);
            this.numCena.TabIndex = 7;
            // 
            // lblRecept
            // 
            this.lblRecept.AutoSize = true;
            this.lblRecept.Location = new System.Drawing.Point(12, 131);
            this.lblRecept.Name = "lblRecept";
            this.lblRecept.Size = new System.Drawing.Size(50, 15);
            this.lblRecept.TabIndex = 8;
            this.lblRecept.Text = "Recept:";
            // 
            // txtRecept
            // 
            this.txtRecept.Location = new System.Drawing.Point(120, 128);
            this.txtRecept.Name = "txtRecept";
            this.txtRecept.ReadOnly = true;
            this.txtRecept.Size = new System.Drawing.Size(200, 23);
            this.txtRecept.TabIndex = 9;
            // 
            // lblKontrolisanaKol
            // 
            this.lblKontrolisanaKol.AutoSize = true;
            this.lblKontrolisanaKol.Location = new System.Drawing.Point(12, 160);
            this.lblKontrolisanaKol.Name = "lblKontrolisanaKol";
            this.lblKontrolisanaKol.Size = new System.Drawing.Size(100, 15);
            this.lblKontrolisanaKol.TabIndex = 10;
            this.lblKontrolisanaKol.Text = "Kontrolisana kol.:";
            // 
            // numKontrolisanaKol
            // 
            this.numKontrolisanaKol.Location = new System.Drawing.Point(120, 157);
            this.numKontrolisanaKol.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numKontrolisanaKol.Name = "numKontrolisanaKol";
            this.numKontrolisanaKol.Size = new System.Drawing.Size(120, 23);
            this.numKontrolisanaKol.TabIndex = 11;
            // 
            // lblProcenatParticip
            // 
            this.lblProcenatParticip.AutoSize = true;
            this.lblProcenatParticip.Location = new System.Drawing.Point(12, 189);
            this.lblProcenatParticip.Name = "lblProcenatParticip";
            this.lblProcenatParticip.Size = new System.Drawing.Size(100, 15);
            this.lblProcenatParticip.TabIndex = 12;
            this.lblProcenatParticip.Text = "Procenat particip:";
            // 
            // numProcenatParticip
            // 
            this.numProcenatParticip.DecimalPlaces = 2;
            this.numProcenatParticip.Location = new System.Drawing.Point(120, 186);
            this.numProcenatParticip.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numProcenatParticip.Name = "numProcenatParticip";
            this.numProcenatParticip.Size = new System.Drawing.Size(120, 23);
            this.numProcenatParticip.TabIndex = 13;
            // 
            // lblNeophodanIzvestaj
            // 
            this.lblNeophodanIzvestaj.AutoSize = true;
            this.lblNeophodanIzvestaj.Location = new System.Drawing.Point(12, 218);
            this.lblNeophodanIzvestaj.Name = "lblNeophodanIzvestaj";
            this.lblNeophodanIzvestaj.Size = new System.Drawing.Size(110, 15);
            this.lblNeophodanIzvestaj.TabIndex = 14;
            this.lblNeophodanIzvestaj.Text = "Neophodan izveštaj:";
            // 
            // cmbNeophodanIzvestaj
            // 
            this.cmbNeophodanIzvestaj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNeophodanIzvestaj.FormattingEnabled = true;
            this.cmbNeophodanIzvestaj.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cmbNeophodanIzvestaj.Location = new System.Drawing.Point(130, 215);
            this.cmbNeophodanIzvestaj.Name = "cmbNeophodanIzvestaj";
            this.cmbNeophodanIzvestaj.Size = new System.Drawing.Size(110, 23);
            this.cmbNeophodanIzvestaj.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(245, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Otkaži";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ProdajnaStavkaEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 295);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbNeophodanIzvestaj);
            this.Controls.Add(this.lblNeophodanIzvestaj);
            this.Controls.Add(this.numProcenatParticip);
            this.Controls.Add(this.lblProcenatParticip);
            this.Controls.Add(this.numKontrolisanaKol);
            this.Controls.Add(this.lblKontrolisanaKol);
            this.Controls.Add(this.txtRecept);
            this.Controls.Add(this.lblRecept);
            this.Controls.Add(this.numCena);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.txtPakovanje);
            this.Controls.Add(this.lblPakovanje);
            this.Controls.Add(this.txtProdaja);
            this.Controls.Add(this.lblProdaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProdajnaStavkaEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izmena prodajne stavke";
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKontrolisanaKol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProcenatParticip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProdaja;
        private System.Windows.Forms.TextBox txtProdaja;
        private System.Windows.Forms.Label lblPakovanje;
        private System.Windows.Forms.TextBox txtPakovanje;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.NumericUpDown numCena;
        private System.Windows.Forms.Label lblRecept;
        private System.Windows.Forms.TextBox txtRecept;
        private System.Windows.Forms.Label lblKontrolisanaKol;
        private System.Windows.Forms.NumericUpDown numKontrolisanaKol;
        private System.Windows.Forms.Label lblProcenatParticip;
        private System.Windows.Forms.NumericUpDown numProcenatParticip;
        private System.Windows.Forms.Label lblNeophodanIzvestaj;
        private System.Windows.Forms.ComboBox cmbNeophodanIzvestaj;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
