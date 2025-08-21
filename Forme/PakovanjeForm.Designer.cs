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
            lblId = new Label();
            txtId = new TextBox();
            lblLekId = new Label();
            txtLekId = new TextBox();
            lblOblikId = new Label();
            txtOblikId = new TextBox();
            lblVelicinaPakovanja = new Label();
            txtVelicinaPakovanja = new TextBox();
            lblKolicinaAktivne = new Label();
            numKolicinaAktivne = new NumericUpDown();
            lblJedinicaMere = new Label();
            txtJedinicaMere = new TextBox();
            lblAmbalaza = new Label();
            txtAmbalaza = new TextBox();
            lblNacinCuvanja = new Label();
            txtNacinCuvanja = new TextBox();
            lblPreporuceniRokDana = new Label();
            numPreporuceniRokDana = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numKolicinaAktivne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPreporuceniRokDana).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(14, 17);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(140, 14);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(174, 23);
            txtId.TabIndex = 1;
            // 
            // lblLekId
            // 
            lblLekId.AutoSize = true;
            lblLekId.Location = new Point(14, 47);
            lblLekId.Margin = new Padding(4, 0, 4, 0);
            lblLekId.Name = "lblLekId";
            lblLekId.Size = new Size(48, 15);
            lblLekId.TabIndex = 2;
            lblLekId.Text = "ID Leka:";
            // 
            // txtLekId
            // 
            txtLekId.Location = new Point(140, 44);
            txtLekId.Margin = new Padding(4, 3, 4, 3);
            txtLekId.Name = "txtLekId";
            txtLekId.ReadOnly = true;
            txtLekId.Size = new Size(174, 23);
            txtLekId.TabIndex = 3;
            // 
            // lblOblikId
            // 
            lblOblikId.AutoSize = true;
            lblOblikId.Location = new Point(14, 77);
            lblOblikId.Margin = new Padding(4, 0, 4, 0);
            lblOblikId.Name = "lblOblikId";
            lblOblikId.Size = new Size(58, 15);
            lblOblikId.TabIndex = 4;
            lblOblikId.Text = "ID Oblika:";
            // 
            // txtOblikId
            // 
            txtOblikId.Location = new Point(140, 74);
            txtOblikId.Margin = new Padding(4, 3, 4, 3);
            txtOblikId.Name = "txtOblikId";
            txtOblikId.ReadOnly = true;
            txtOblikId.Size = new Size(174, 23);
            txtOblikId.TabIndex = 5;
            // 
            // lblVelicinaPakovanja
            // 
            lblVelicinaPakovanja.AutoSize = true;
            lblVelicinaPakovanja.Location = new Point(14, 107);
            lblVelicinaPakovanja.Margin = new Padding(4, 0, 4, 0);
            lblVelicinaPakovanja.Name = "lblVelicinaPakovanja";
            lblVelicinaPakovanja.Size = new Size(107, 15);
            lblVelicinaPakovanja.TabIndex = 6;
            lblVelicinaPakovanja.Text = "Veličina pakovanja:";
            // 
            // txtVelicinaPakovanja
            // 
            txtVelicinaPakovanja.Location = new Point(140, 104);
            txtVelicinaPakovanja.Margin = new Padding(4, 3, 4, 3);
            txtVelicinaPakovanja.Name = "txtVelicinaPakovanja";
            txtVelicinaPakovanja.Size = new Size(174, 23);
            txtVelicinaPakovanja.TabIndex = 7;
            // 
            // lblKolicinaAktivne
            // 
            lblKolicinaAktivne.AutoSize = true;
            lblKolicinaAktivne.Location = new Point(14, 137);
            lblKolicinaAktivne.Margin = new Padding(4, 0, 4, 0);
            lblKolicinaAktivne.Name = "lblKolicinaAktivne";
            lblKolicinaAktivne.Size = new Size(93, 15);
            lblKolicinaAktivne.TabIndex = 8;
            lblKolicinaAktivne.Text = "Količina aktivne:";
            // 
            // numKolicinaAktivne
            // 
            numKolicinaAktivne.DecimalPlaces = 2;
            numKolicinaAktivne.Location = new Point(140, 134);
            numKolicinaAktivne.Margin = new Padding(4, 3, 4, 3);
            numKolicinaAktivne.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numKolicinaAktivne.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numKolicinaAktivne.Name = "numKolicinaAktivne";
            numKolicinaAktivne.Size = new Size(175, 23);
            numKolicinaAktivne.TabIndex = 9;
            numKolicinaAktivne.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblJedinicaMere
            // 
            lblJedinicaMere.AutoSize = true;
            lblJedinicaMere.Location = new Point(14, 167);
            lblJedinicaMere.Margin = new Padding(4, 0, 4, 0);
            lblJedinicaMere.Name = "lblJedinicaMere";
            lblJedinicaMere.Size = new Size(82, 15);
            lblJedinicaMere.TabIndex = 10;
            lblJedinicaMere.Text = "Jedinica mere:";
            // 
            // txtJedinicaMere
            // 
            txtJedinicaMere.Location = new Point(140, 164);
            txtJedinicaMere.Margin = new Padding(4, 3, 4, 3);
            txtJedinicaMere.Name = "txtJedinicaMere";
            txtJedinicaMere.Size = new Size(174, 23);
            txtJedinicaMere.TabIndex = 11;
            // 
            // lblAmbalaza
            // 
            lblAmbalaza.AutoSize = true;
            lblAmbalaza.Location = new Point(14, 197);
            lblAmbalaza.Margin = new Padding(4, 0, 4, 0);
            lblAmbalaza.Name = "lblAmbalaza";
            lblAmbalaza.Size = new Size(62, 15);
            lblAmbalaza.TabIndex = 12;
            lblAmbalaza.Text = "Ambalaza:";
            // 
            // txtAmbalaza
            // 
            txtAmbalaza.Location = new Point(140, 194);
            txtAmbalaza.Margin = new Padding(4, 3, 4, 3);
            txtAmbalaza.Name = "txtAmbalaza";
            txtAmbalaza.Size = new Size(174, 23);
            txtAmbalaza.TabIndex = 13;
            // 
            // lblNacinCuvanja
            // 
            lblNacinCuvanja.AutoSize = true;
            lblNacinCuvanja.Location = new Point(14, 227);
            lblNacinCuvanja.Margin = new Padding(4, 0, 4, 0);
            lblNacinCuvanja.Name = "lblNacinCuvanja";
            lblNacinCuvanja.Size = new Size(85, 15);
            lblNacinCuvanja.TabIndex = 14;
            lblNacinCuvanja.Text = "Način čuvanja:";
            // 
            // txtNacinCuvanja
            // 
            txtNacinCuvanja.Location = new Point(140, 224);
            txtNacinCuvanja.Margin = new Padding(4, 3, 4, 3);
            txtNacinCuvanja.Name = "txtNacinCuvanja";
            txtNacinCuvanja.Size = new Size(174, 23);
            txtNacinCuvanja.TabIndex = 15;
            // 
            // lblPreporuceniRokDana
            // 
            lblPreporuceniRokDana.AutoSize = true;
            lblPreporuceniRokDana.Location = new Point(14, 257);
            lblPreporuceniRokDana.Margin = new Padding(4, 0, 4, 0);
            lblPreporuceniRokDana.Name = "lblPreporuceniRokDana";
            lblPreporuceniRokDana.Size = new Size(112, 15);
            lblPreporuceniRokDana.TabIndex = 16;
            lblPreporuceniRokDana.Text = "Preporučeni rok (d):";
            // 
            // numPreporuceniRokDana
            // 
            numPreporuceniRokDana.Location = new Point(140, 254);
            numPreporuceniRokDana.Margin = new Padding(4, 3, 4, 3);
            numPreporuceniRokDana.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numPreporuceniRokDana.Name = "numPreporuceniRokDana";
            numPreporuceniRokDana.Size = new Size(175, 23);
            numPreporuceniRokDana.TabIndex = 17;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(140, 295);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 27);
            btnSave.TabIndex = 18;
            btnSave.Text = "Sačuvaj";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(234, 295);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 27);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Otkaži";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // PakovanjeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 336);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(numPreporuceniRokDana);
            Controls.Add(lblPreporuceniRokDana);
            Controls.Add(txtNacinCuvanja);
            Controls.Add(lblNacinCuvanja);
            Controls.Add(txtAmbalaza);
            Controls.Add(lblAmbalaza);
            Controls.Add(txtJedinicaMere);
            Controls.Add(lblJedinicaMere);
            Controls.Add(numKolicinaAktivne);
            Controls.Add(lblKolicinaAktivne);
            Controls.Add(txtVelicinaPakovanja);
            Controls.Add(lblVelicinaPakovanja);
            Controls.Add(txtOblikId);
            Controls.Add(lblOblikId);
            Controls.Add(txtLekId);
            Controls.Add(lblLekId);
            Controls.Add(txtId);
            Controls.Add(lblId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PakovanjeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pakovanje";
            ((System.ComponentModel.ISupportInitialize)numKolicinaAktivne).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPreporuceniRokDana).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
