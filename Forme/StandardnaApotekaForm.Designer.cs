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
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblUlica = new System.Windows.Forms.Label();
            this.txtUlica = new System.Windows.Forms.TextBox();
            this.lblBroj = new System.Windows.Forms.Label();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.lblPostanskiBroj = new System.Windows.Forms.Label();
            this.txtPostanskiBroj = new System.Windows.Forms.TextBox();
            this.lblMesto = new System.Windows.Forms.Label();
            this.txtMesto = new System.Windows.Forms.TextBox();
            this.lblOdgovorniFarmaceut = new System.Windows.Forms.Label();
            this.txtOdgovorniFarmaceut = new System.Windows.Forms.TextBox();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(30, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(150, 27);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(200, 23);
            this.txtId.TabIndex = 1;
            this.txtId.TabStop = false;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(30, 70);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(43, 15);
            this.lblNaziv.TabIndex = 2;
            this.lblNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(150, 67);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(200, 23);
            this.txtNaziv.TabIndex = 3;
            // 
            // lblUlica
            // 
            this.lblUlica.AutoSize = true;
            this.lblUlica.Location = new System.Drawing.Point(30, 110);
            this.lblUlica.Name = "lblUlica";
            this.lblUlica.Size = new System.Drawing.Size(38, 15);
            this.lblUlica.TabIndex = 4;
            this.lblUlica.Text = "Ulica:";
            // 
            // txtUlica
            // 
            this.txtUlica.Location = new System.Drawing.Point(150, 107);
            this.txtUlica.Name = "txtUlica";
            this.txtUlica.Size = new System.Drawing.Size(200, 23);
            this.txtUlica.TabIndex = 5;
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.Location = new System.Drawing.Point(30, 150);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(33, 15);
            this.lblBroj.TabIndex = 6;
            this.lblBroj.Text = "Broj:";
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(150, 147);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(200, 23);
            this.txtBroj.TabIndex = 7;
            // 
            // lblPostanskiBroj
            // 
            this.lblPostanskiBroj.AutoSize = true;
            this.lblPostanskiBroj.Location = new System.Drawing.Point(30, 190);
            this.lblPostanskiBroj.Name = "lblPostanskiBroj";
            this.lblPostanskiBroj.Size = new System.Drawing.Size(89, 15);
            this.lblPostanskiBroj.TabIndex = 8;
            this.lblPostanskiBroj.Text = "Poštanski broj:";
            // 
            // txtPostanskiBroj
            // 
            this.txtPostanskiBroj.Location = new System.Drawing.Point(150, 187);
            this.txtPostanskiBroj.Name = "txtPostanskiBroj";
            this.txtPostanskiBroj.Size = new System.Drawing.Size(200, 23);
            this.txtPostanskiBroj.TabIndex = 9;
            // 
            // lblMesto
            // 
            this.lblMesto.AutoSize = true;
            this.lblMesto.Location = new System.Drawing.Point(30, 230);
            this.lblMesto.Name = "lblMesto";
            this.lblMesto.Size = new System.Drawing.Size(44, 15);
            this.lblMesto.TabIndex = 10;
            this.lblMesto.Text = "Mesto:";
            // 
            // txtMesto
            // 
            this.txtMesto.Location = new System.Drawing.Point(150, 227);
            this.txtMesto.Name = "txtMesto";
            this.txtMesto.Size = new System.Drawing.Size(200, 23);
            this.txtMesto.TabIndex = 11;
            // 
            // lblOdgovorniFarmaceut
            // 
            this.lblOdgovorniFarmaceut.AutoSize = true;
            this.lblOdgovorniFarmaceut.Location = new System.Drawing.Point(30, 270);
            this.lblOdgovorniFarmaceut.Name = "lblOdgovorniFarmaceut";
            this.lblOdgovorniFarmaceut.Size = new System.Drawing.Size(120, 15);
            this.lblOdgovorniFarmaceut.TabIndex = 12;
            this.lblOdgovorniFarmaceut.Text = "Odgovorni farmaceut:";
            // 
            // txtOdgovorniFarmaceut
            // 
            this.txtOdgovorniFarmaceut.Location = new System.Drawing.Point(150, 267);
            this.txtOdgovorniFarmaceut.Name = "txtOdgovorniFarmaceut";
            this.txtOdgovorniFarmaceut.ReadOnly = true;
            this.txtOdgovorniFarmaceut.Size = new System.Drawing.Size(200, 23);
            this.txtOdgovorniFarmaceut.TabIndex = 13;
            this.txtOdgovorniFarmaceut.TabStop = false;
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(30, 310);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(72, 15);
            this.lblNapomena.TabIndex = 14;
            this.lblNapomena.Text = "Napomena:";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(150, 307);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(200, 60);
            this.txtNapomena.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 390);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(275, 390);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Otkaži";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // StandardnaApotekaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 441);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.lblNapomena);
            this.Controls.Add(this.txtOdgovorniFarmaceut);
            this.Controls.Add(this.lblOdgovorniFarmaceut);
            this.Controls.Add(this.txtMesto);
            this.Controls.Add(this.lblMesto);
            this.Controls.Add(this.txtPostanskiBroj);
            this.Controls.Add(this.lblPostanskiBroj);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.lblBroj);
            this.Controls.Add(this.txtUlica);
            this.Controls.Add(this.lblUlica);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StandardnaApotekaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Standardna apoteka";
            this.ResumeLayout(false);
            this.PerformLayout();
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
