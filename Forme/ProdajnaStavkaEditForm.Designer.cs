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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
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
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKontrolisanaKol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProcenatParticip)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(377, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "✏️ IZMENA PRODAJNE STAVKE";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblSubtitle.Location = new System.Drawing.Point(20, 45);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(246, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Izmena postojećih podataka o stavci prodaje";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.panelMain.Controls.Add(this.btnCancel);
            this.panelMain.Controls.Add(this.btnSave);
            this.panelMain.Controls.Add(this.cmbNeophodanIzvestaj);
            this.panelMain.Controls.Add(this.lblNeophodanIzvestaj);
            this.panelMain.Controls.Add(this.numProcenatParticip);
            this.panelMain.Controls.Add(this.lblProcenatParticip);
            this.panelMain.Controls.Add(this.numKontrolisanaKol);
            this.panelMain.Controls.Add(this.lblKontrolisanaKol);
            this.panelMain.Controls.Add(this.txtRecept);
            this.panelMain.Controls.Add(this.lblRecept);
            this.panelMain.Controls.Add(this.numCena);
            this.panelMain.Controls.Add(this.lblCena);
            this.panelMain.Controls.Add(this.numKolicina);
            this.panelMain.Controls.Add(this.lblKolicina);
            this.panelMain.Controls.Add(this.txtPakovanje);
            this.panelMain.Controls.Add(this.lblPakovanje);
            this.panelMain.Controls.Add(this.txtProdaja);
            this.panelMain.Controls.Add(this.lblProdaja);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 80);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(800, 430);
            this.panelMain.TabIndex = 1;
            // 
            // lblProdaja
            // 
            this.lblProdaja.AutoSize = true;
            this.lblProdaja.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProdaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblProdaja.Location = new System.Drawing.Point(50, 30);
            this.lblProdaja.Name = "lblProdaja";
            this.lblProdaja.Size = new System.Drawing.Size(59, 19);
            this.lblProdaja.TabIndex = 0;
            this.lblProdaja.Text = "Prodaja:";
            // 
            // txtProdaja
            // 
            this.txtProdaja.BackColor = System.Drawing.Color.White;
            this.txtProdaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdaja.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProdaja.Location = new System.Drawing.Point(200, 27);
            this.txtProdaja.Name = "txtProdaja";
            this.txtProdaja.ReadOnly = true;
            this.txtProdaja.Size = new System.Drawing.Size(300, 26);
            this.txtProdaja.TabIndex = 1;
            // 
            // lblPakovanje
            // 
            this.lblPakovanje.AutoSize = true;
            this.lblPakovanje.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPakovanje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPakovanje.Location = new System.Drawing.Point(50, 80);
            this.lblPakovanje.Name = "lblPakovanje";
            this.lblPakovanje.Size = new System.Drawing.Size(80, 19);
            this.lblPakovanje.TabIndex = 2;
            this.lblPakovanje.Text = "Pakovanje:";
            // 
            // txtPakovanje
            // 
            this.txtPakovanje.BackColor = System.Drawing.Color.White;
            this.txtPakovanje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPakovanje.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPakovanje.Location = new System.Drawing.Point(200, 77);
            this.txtPakovanje.Name = "txtPakovanje";
            this.txtPakovanje.ReadOnly = true;
            this.txtPakovanje.Size = new System.Drawing.Size(300, 26);
            this.txtPakovanje.TabIndex = 3;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKolicina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblKolicina.Location = new System.Drawing.Point(50, 130);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(64, 19);
            this.lblKolicina.TabIndex = 4;
            this.lblKolicina.Text = "Količina:";
            // 
            // numKolicina
            // 
            this.numKolicina.BackColor = System.Drawing.Color.White;
            this.numKolicina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numKolicina.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numKolicina.Location = new System.Drawing.Point(200, 127);
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
            this.numKolicina.Size = new System.Drawing.Size(150, 26);
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
            this.lblCena.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblCena.Location = new System.Drawing.Point(50, 180);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(44, 19);
            this.lblCena.TabIndex = 6;
            this.lblCena.Text = "Cena:";
            // 
            // numCena
            // 
            this.numCena.BackColor = System.Drawing.Color.White;
            this.numCena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numCena.DecimalPlaces = 2;
            this.numCena.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numCena.Location = new System.Drawing.Point(200, 177);
            this.numCena.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCena.Name = "numCena";
            this.numCena.Size = new System.Drawing.Size(150, 26);
            this.numCena.TabIndex = 7;
            // 
            // lblRecept
            // 
            this.lblRecept.AutoSize = true;
            this.lblRecept.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblRecept.Location = new System.Drawing.Point(450, 30);
            this.lblRecept.Name = "lblRecept";
            this.lblRecept.Size = new System.Drawing.Size(57, 19);
            this.lblRecept.TabIndex = 8;
            this.lblRecept.Text = "Recept:";
            // 
            // txtRecept
            // 
            this.txtRecept.BackColor = System.Drawing.Color.White;
            this.txtRecept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecept.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecept.Location = new System.Drawing.Point(520, 27);
            this.txtRecept.Name = "txtRecept";
            this.txtRecept.ReadOnly = true;
            this.txtRecept.Size = new System.Drawing.Size(200, 26);
            this.txtRecept.TabIndex = 9;
            // 
            // lblKontrolisanaKol
            // 
            this.lblKontrolisanaKol.AutoSize = true;
            this.lblKontrolisanaKol.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKontrolisanaKol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblKontrolisanaKol.Location = new System.Drawing.Point(450, 80);
            this.lblKontrolisanaKol.Name = "lblKontrolisanaKol";
            this.lblKontrolisanaKol.Size = new System.Drawing.Size(114, 19);
            this.lblKontrolisanaKol.TabIndex = 10;
            this.lblKontrolisanaKol.Text = "Kontrolisana kol.:";
            // 
            // numKontrolisanaKol
            // 
            this.numKontrolisanaKol.BackColor = System.Drawing.Color.White;
            this.numKontrolisanaKol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numKontrolisanaKol.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numKontrolisanaKol.Location = new System.Drawing.Point(520, 77);
            this.numKontrolisanaKol.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numKontrolisanaKol.Name = "numKontrolisanaKol";
            this.numKontrolisanaKol.Size = new System.Drawing.Size(150, 26);
            this.numKontrolisanaKol.TabIndex = 11;
            // 
            // lblProcenatParticip
            // 
            this.lblProcenatParticip.AutoSize = true;
            this.lblProcenatParticip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProcenatParticip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblProcenatParticip.Location = new System.Drawing.Point(450, 130);
            this.lblProcenatParticip.Name = "lblProcenatParticip";
            this.lblProcenatParticip.Size = new System.Drawing.Size(114, 19);
            this.lblProcenatParticip.TabIndex = 12;
            this.lblProcenatParticip.Text = "Procenat particip:";
            // 
            // numProcenatParticip
            // 
            this.numProcenatParticip.BackColor = System.Drawing.Color.White;
            this.numProcenatParticip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numProcenatParticip.DecimalPlaces = 2;
            this.numProcenatParticip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numProcenatParticip.Location = new System.Drawing.Point(520, 127);
            this.numProcenatParticip.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numProcenatParticip.Name = "numProcenatParticip";
            this.numProcenatParticip.Size = new System.Drawing.Size(150, 26);
            this.numProcenatParticip.TabIndex = 13;
            // 
            // lblNeophodanIzvestaj
            // 
            this.lblNeophodanIzvestaj.AutoSize = true;
            this.lblNeophodanIzvestaj.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNeophodanIzvestaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblNeophodanIzvestaj.Location = new System.Drawing.Point(450, 180);
            this.lblNeophodanIzvestaj.Name = "lblNeophodanIzvestaj";
            this.lblNeophodanIzvestaj.Size = new System.Drawing.Size(126, 19);
            this.lblNeophodanIzvestaj.TabIndex = 14;
            this.lblNeophodanIzvestaj.Text = "Neophodan izveštaj:";
            // 
            // cmbNeophodanIzvestaj
            // 
            this.cmbNeophodanIzvestaj.BackColor = System.Drawing.Color.White;
            this.cmbNeophodanIzvestaj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNeophodanIzvestaj.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbNeophodanIzvestaj.FormattingEnabled = true;
            this.cmbNeophodanIzvestaj.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cmbNeophodanIzvestaj.Location = new System.Drawing.Point(520, 177);
            this.cmbNeophodanIzvestaj.Name = "cmbNeophodanIzvestaj";
            this.cmbNeophodanIzvestaj.Size = new System.Drawing.Size(100, 25);
            this.cmbNeophodanIzvestaj.TabIndex = 15;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelFooter.Controls.Add(this.lblFooter);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 510);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(800, 30);
            this.panelFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblFooter.Location = new System.Drawing.Point(20, 8);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(210, 13);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "Sistem za upravljanje farmaceutskim podacima";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(300, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "💾 Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(450, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "❌ Otkaži";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ProdajnaStavkaEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProdajnaStavkaEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prodajna Stavka - Izmena";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKontrolisanaKol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProcenatParticip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooter;
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
