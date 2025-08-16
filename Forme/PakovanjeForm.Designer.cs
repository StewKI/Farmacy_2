namespace Farmacy.Forme
{
    partial class PakovanjeForm
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblLekId = new System.Windows.Forms.Label();
            this.txtLekId = new System.Windows.Forms.TextBox();
            this.lblOblikId = new System.Windows.Forms.Label();
            this.txtOblikId = new System.Windows.Forms.TextBox();
            this.lblVelicinaPakovanja = new System.Windows.Forms.Label();
            this.txtVelicinaPakovanja = new System.Windows.Forms.TextBox();
            this.lblKolicinaAktivne = new System.Windows.Forms.Label();
            this.numKolicinaAktivne = new System.Windows.Forms.NumericUpDown();
            this.lblJedinicaMere = new System.Windows.Forms.Label();
            this.txtJedinicaMere = new System.Windows.Forms.TextBox();
            this.lblAmbalaza = new System.Windows.Forms.Label();
            this.txtAmbalaza = new System.Windows.Forms.TextBox();
            this.lblNacinCuvanja = new System.Windows.Forms.Label();
            this.txtNacinCuvanja = new System.Windows.Forms.TextBox();
            this.lblPreporuceniRokDana = new System.Windows.Forms.Label();
            this.numPreporuceniRokDana = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicinaAktivne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreporuceniRokDana)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(120, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(150, 20);
            this.txtId.TabIndex = 1;
            // 
            // lblLekId
            // 
            this.lblLekId.AutoSize = true;
            this.lblLekId.Location = new System.Drawing.Point(12, 41);
            this.lblLekId.Name = "lblLekId";
            this.lblLekId.Size = new System.Drawing.Size(45, 13);
            this.lblLekId.TabIndex = 2;
            this.lblLekId.Text = "ID Leka:";
            // 
            // txtLekId
            // 
            this.txtLekId.Location = new System.Drawing.Point(120, 38);
            this.txtLekId.Name = "txtLekId";
            this.txtLekId.Size = new System.Drawing.Size(150, 20);
            this.txtLekId.TabIndex = 3;
            // 
            // lblOblikId
            // 
            this.lblOblikId.AutoSize = true;
            this.lblOblikId.Location = new System.Drawing.Point(12, 67);
            this.lblOblikId.Name = "lblOblikId";
            this.lblOblikId.Size = new System.Drawing.Size(52, 13);
            this.lblOblikId.TabIndex = 4;
            this.lblOblikId.Text = "ID Oblika:";
            // 
            // txtOblikId
            // 
            this.txtOblikId.Location = new System.Drawing.Point(120, 64);
            this.txtOblikId.Name = "txtOblikId";
            this.txtOblikId.Size = new System.Drawing.Size(150, 20);
            this.txtOblikId.TabIndex = 5;
            // 
            // lblVelicinaPakovanja
            // 
            this.lblVelicinaPakovanja.AutoSize = true;
            this.lblVelicinaPakovanja.Location = new System.Drawing.Point(12, 93);
            this.lblVelicinaPakovanja.Name = "lblVelicinaPakovanja";
            this.lblVelicinaPakovanja.Size = new System.Drawing.Size(95, 13);
            this.lblVelicinaPakovanja.TabIndex = 6;
            this.lblVelicinaPakovanja.Text = "Veličina pakovanja:";
            // 
            // txtVelicinaPakovanja
            // 
            this.txtVelicinaPakovanja.Location = new System.Drawing.Point(120, 90);
            this.txtVelicinaPakovanja.Name = "txtVelicinaPakovanja";
            this.txtVelicinaPakovanja.Size = new System.Drawing.Size(150, 20);
            this.txtVelicinaPakovanja.TabIndex = 7;
            // 
            // lblKolicinaAktivne
            // 
            this.lblKolicinaAktivne.AutoSize = true;
            this.lblKolicinaAktivne.Location = new System.Drawing.Point(12, 119);
            this.lblKolicinaAktivne.Name = "lblKolicinaAktivne";
            this.lblKolicinaAktivne.Size = new System.Drawing.Size(89, 13);
            this.lblKolicinaAktivne.TabIndex = 8;
            this.lblKolicinaAktivne.Text = "Količina aktivne:";
            // 
            // numKolicinaAktivne
            // 
            this.numKolicinaAktivne.DecimalPlaces = 2;
            this.numKolicinaAktivne.Location = new System.Drawing.Point(120, 116);
            this.numKolicinaAktivne.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numKolicinaAktivne.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKolicinaAktivne.Name = "numKolicinaAktivne";
            this.numKolicinaAktivne.Size = new System.Drawing.Size(150, 20);
            this.numKolicinaAktivne.TabIndex = 9;
            this.numKolicinaAktivne.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblJedinicaMere
            // 
            this.lblJedinicaMere.AutoSize = true;
            this.lblJedinicaMere.Location = new System.Drawing.Point(12, 145);
            this.lblJedinicaMere.Name = "lblJedinicaMere";
            this.lblJedinicaMere.Size = new System.Drawing.Size(75, 13);
            this.lblJedinicaMere.TabIndex = 10;
            this.lblJedinicaMere.Text = "Jedinica mere:";
            // 
            // txtJedinicaMere
            // 
            this.txtJedinicaMere.Location = new System.Drawing.Point(120, 142);
            this.txtJedinicaMere.Name = "txtJedinicaMere";
            this.txtJedinicaMere.Size = new System.Drawing.Size(150, 20);
            this.txtJedinicaMere.TabIndex = 11;
            // 
            // lblAmbalaza
            // 
            this.lblAmbalaza.AutoSize = true;
            this.lblAmbalaza.Location = new System.Drawing.Point(12, 171);
            this.lblAmbalaza.Name = "lblAmbalaza";
            this.lblAmbalaza.Size = new System.Drawing.Size(55, 13);
            this.lblAmbalaza.TabIndex = 12;
            this.lblAmbalaza.Text = "Ambalaza:";
            // 
            // txtAmbalaza
            // 
            this.txtAmbalaza.Location = new System.Drawing.Point(120, 168);
            this.txtAmbalaza.Name = "txtAmbalaza";
            this.txtAmbalaza.Size = new System.Drawing.Size(150, 20);
            this.txtAmbalaza.TabIndex = 13;
            // 
            // lblNacinCuvanja
            // 
            this.lblNacinCuvanja.AutoSize = true;
            this.lblNacinCuvanja.Location = new System.Drawing.Point(12, 197);
            this.lblNacinCuvanja.Name = "lblNacinCuvanja";
            this.lblNacinCuvanja.Size = new System.Drawing.Size(82, 13);
            this.lblNacinCuvanja.TabIndex = 14;
            this.lblNacinCuvanja.Text = "Način čuvanja:";
            // 
            // txtNacinCuvanja
            // 
            this.txtNacinCuvanja.Location = new System.Drawing.Point(120, 194);
            this.txtNacinCuvanja.Name = "txtNacinCuvanja";
            this.txtNacinCuvanja.Size = new System.Drawing.Size(150, 20);
            this.txtNacinCuvanja.TabIndex = 15;
            // 
            // lblPreporuceniRokDana
            // 
            this.lblPreporuceniRokDana.AutoSize = true;
            this.lblPreporuceniRokDana.Location = new System.Drawing.Point(12, 223);
            this.lblPreporuceniRokDana.Name = "lblPreporuceniRokDana";
            this.lblPreporuceniRokDana.Size = new System.Drawing.Size(105, 13);
            this.lblPreporuceniRokDana.TabIndex = 16;
            this.lblPreporuceniRokDana.Text = "Preporučeni rok (d):";
            // 
            // numPreporuceniRokDana
            // 
            this.numPreporuceniRokDana.Location = new System.Drawing.Point(120, 220);
            this.numPreporuceniRokDana.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numPreporuceniRokDana.Name = "numPreporuceniRokDana";
            this.numPreporuceniRokDana.Size = new System.Drawing.Size(150, 20);
            this.numPreporuceniRokDana.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(201, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Otkaži";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PakovanjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 291);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numPreporuceniRokDana);
            this.Controls.Add(this.lblPreporuceniRokDana);
            this.Controls.Add(this.txtNacinCuvanja);
            this.Controls.Add(this.lblNacinCuvanja);
            this.Controls.Add(this.txtAmbalaza);
            this.Controls.Add(this.lblAmbalaza);
            this.Controls.Add(this.txtJedinicaMere);
            this.Controls.Add(this.lblJedinicaMere);
            this.Controls.Add(this.numKolicinaAktivne);
            this.Controls.Add(this.lblKolicinaAktivne);
            this.Controls.Add(this.txtVelicinaPakovanja);
            this.Controls.Add(this.lblVelicinaPakovanja);
            this.Controls.Add(this.txtOblikId);
            this.Controls.Add(this.lblOblikId);
            this.Controls.Add(this.txtLekId);
            this.Controls.Add(this.lblLekId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PakovanjeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pakovanje";
            ((System.ComponentModel.ISupportInitialize)(this.numKolicinaAktivne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreporuceniRokDana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblLekId;
        private System.Windows.Forms.TextBox txtLekId;
        private System.Windows.Forms.Label lblOblikId;
        private System.Windows.Forms.TextBox txtOblikId;
        private System.Windows.Forms.Label lblVelicinaPakovanja;
        private System.Windows.Forms.TextBox txtVelicinaPakovanja;
        private System.Windows.Forms.Label lblKolicinaAktivne;
        private System.Windows.Forms.NumericUpDown numKolicinaAktivne;
        private System.Windows.Forms.Label lblJedinicaMere;
        private System.Windows.Forms.TextBox txtJedinicaMere;
        private System.Windows.Forms.Label lblAmbalaza;
        private System.Windows.Forms.TextBox txtAmbalaza;
        private System.Windows.Forms.Label lblNacinCuvanja;
        private System.Windows.Forms.TextBox txtNacinCuvanja;
        private System.Windows.Forms.Label lblPreporuceniRokDana;
        private System.Windows.Forms.NumericUpDown numPreporuceniRokDana;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
