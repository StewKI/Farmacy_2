namespace Farmacy.Forme
{
    partial class StandardnaApotekaForm
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
            lblNaziv = new Label();
            txtNaziv = new TextBox();
            lblUlica = new Label();
            txtUlica = new TextBox();
            lblBroj = new Label();
            txtBroj = new TextBox();
            lblPostanskiBroj = new Label();
            txtPostanskiBroj = new TextBox();
            lblMesto = new Label();
            txtMesto = new TextBox();
            lblOdgovorniFarmaceut = new Label();
            txtOdgovorniFarmaceut = new TextBox();
            lblNapomena = new Label();
            txtNapomena = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(30, 30);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(150, 27);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(200, 23);
            txtId.TabIndex = 1;
            txtId.TabStop = false;
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(30, 70);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(39, 15);
            lblNaziv.TabIndex = 2;
            lblNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(150, 67);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(200, 23);
            txtNaziv.TabIndex = 3;
            // 
            // lblUlica
            // 
            lblUlica.AutoSize = true;
            lblUlica.Location = new Point(30, 110);
            lblUlica.Name = "lblUlica";
            lblUlica.Size = new Size(36, 15);
            lblUlica.TabIndex = 4;
            lblUlica.Text = "Ulica:";
            // 
            // txtUlica
            // 
            txtUlica.Location = new Point(150, 107);
            txtUlica.Name = "txtUlica";
            txtUlica.Size = new Size(200, 23);
            txtUlica.TabIndex = 5;
            // 
            // lblBroj
            // 
            lblBroj.AutoSize = true;
            lblBroj.Location = new Point(30, 150);
            lblBroj.Name = "lblBroj";
            lblBroj.Size = new Size(31, 15);
            lblBroj.TabIndex = 6;
            lblBroj.Text = "Broj:";
            // 
            // txtBroj
            // 
            txtBroj.Location = new Point(150, 147);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(200, 23);
            txtBroj.TabIndex = 7;
            // 
            // lblPostanskiBroj
            // 
            lblPostanskiBroj.AutoSize = true;
            lblPostanskiBroj.Location = new Point(30, 190);
            lblPostanskiBroj.Name = "lblPostanskiBroj";
            lblPostanskiBroj.Size = new Size(84, 15);
            lblPostanskiBroj.TabIndex = 8;
            lblPostanskiBroj.Text = "Poštanski broj:";
            // 
            // txtPostanskiBroj
            // 
            txtPostanskiBroj.Location = new Point(150, 187);
            txtPostanskiBroj.Name = "txtPostanskiBroj";
            txtPostanskiBroj.Size = new Size(200, 23);
            txtPostanskiBroj.TabIndex = 9;
            // 
            // lblMesto
            // 
            lblMesto.AutoSize = true;
            lblMesto.Location = new Point(30, 230);
            lblMesto.Name = "lblMesto";
            lblMesto.Size = new Size(43, 15);
            lblMesto.TabIndex = 10;
            lblMesto.Text = "Mesto:";
            // 
            // txtMesto
            // 
            txtMesto.Location = new Point(150, 227);
            txtMesto.Name = "txtMesto";
            txtMesto.Size = new Size(200, 23);
            txtMesto.TabIndex = 11;
            // 
            // lblOdgovorniFarmaceut
            // 
            lblOdgovorniFarmaceut.AutoSize = true;
            lblOdgovorniFarmaceut.Location = new Point(30, 270);
            lblOdgovorniFarmaceut.Name = "lblOdgovorniFarmaceut";
            lblOdgovorniFarmaceut.Size = new Size(124, 15);
            lblOdgovorniFarmaceut.TabIndex = 12;
            lblOdgovorniFarmaceut.Text = "Odgovorni farmaceut:";
            // 
            // txtOdgovorniFarmaceut
            // 
            txtOdgovorniFarmaceut.Location = new Point(150, 267);
            txtOdgovorniFarmaceut.Name = "txtOdgovorniFarmaceut";
            txtOdgovorniFarmaceut.Size = new Size(200, 23);
            txtOdgovorniFarmaceut.TabIndex = 13;
            txtOdgovorniFarmaceut.TabStop = false;
            // 
            // lblNapomena
            // 
            lblNapomena.AutoSize = true;
            lblNapomena.Location = new Point(30, 310);
            lblNapomena.Name = "lblNapomena";
            lblNapomena.Size = new Size(69, 15);
            lblNapomena.TabIndex = 14;
            lblNapomena.Text = "Napomena:";
            // 
            // txtNapomena
            // 
            txtNapomena.Location = new Point(150, 307);
            txtNapomena.Multiline = true;
            txtNapomena.Name = "txtNapomena";
            txtNapomena.Size = new Size(200, 60);
            txtNapomena.TabIndex = 15;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(150, 390);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 16;
            btnSave.Text = "Sačuvaj";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(275, 390);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Otkaži";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // StandardnaApotekaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 441);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtNapomena);
            Controls.Add(lblNapomena);
            Controls.Add(txtOdgovorniFarmaceut);
            Controls.Add(lblOdgovorniFarmaceut);
            Controls.Add(txtMesto);
            Controls.Add(lblMesto);
            Controls.Add(txtPostanskiBroj);
            Controls.Add(lblPostanskiBroj);
            Controls.Add(txtBroj);
            Controls.Add(lblBroj);
            Controls.Add(txtUlica);
            Controls.Add(lblUlica);
            Controls.Add(txtNaziv);
            Controls.Add(lblNaziv);
            Controls.Add(txtId);
            Controls.Add(lblId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StandardnaApotekaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Standardna apoteka";
            Load += StandardnaApotekaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblUlica;
        private System.Windows.Forms.TextBox txtUlica;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.Label lblPostanskiBroj;
        private System.Windows.Forms.TextBox txtPostanskiBroj;
        private System.Windows.Forms.Label lblMesto;
        private System.Windows.Forms.TextBox txtMesto;
        private System.Windows.Forms.Label lblOdgovorniFarmaceut;
        private System.Windows.Forms.TextBox txtOdgovorniFarmaceut;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
