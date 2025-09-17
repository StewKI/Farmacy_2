namespace Farmacy.Forme
{
    partial class RasporedRadaForm
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
            this.lblZaposleni = new System.Windows.Forms.Label();
            this.cmbZaposleni = new System.Windows.Forms.ComboBox();
            this.lblPocetak = new System.Windows.Forms.Label();
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            this.lblKraj = new System.Windows.Forms.Label();
            this.dtpKraj = new System.Windows.Forms.DateTimePicker();
            this.lblSmena = new System.Windows.Forms.Label();
            this.cmbSmena = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnOsvezi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.dgvRaspored = new System.Windows.Forms.DataGridView();
            this.lblRaspored = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).BeginInit();
            this.SuspendLayout();
            // 
            // lblZaposleni
            // 
            this.lblZaposleni.AutoSize = true;
            this.lblZaposleni.Location = new System.Drawing.Point(20, 20);
            this.lblZaposleni.Name = "lblZaposleni";
            this.lblZaposleni.Size = new System.Drawing.Size(60, 15);
            this.lblZaposleni.TabIndex = 0;
            this.lblZaposleni.Text = "Zaposleni:";
            // 
            // cmbZaposleni
            // 
            this.cmbZaposleni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZaposleni.FormattingEnabled = true;
            this.cmbZaposleni.Location = new System.Drawing.Point(100, 17);
            this.cmbZaposleni.Name = "cmbZaposleni";
            this.cmbZaposleni.Size = new System.Drawing.Size(200, 23);
            this.cmbZaposleni.TabIndex = 1;
            // 
            // lblPocetak
            // 
            this.lblPocetak.AutoSize = true;
            this.lblPocetak.Location = new System.Drawing.Point(20, 60);
            this.lblPocetak.Name = "lblPocetak";
            this.lblPocetak.Size = new System.Drawing.Size(50, 15);
            this.lblPocetak.TabIndex = 2;
            this.lblPocetak.Text = "Početak:";
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpPocetak.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPocetak.Location = new System.Drawing.Point(100, 57);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.Size = new System.Drawing.Size(150, 23);
            this.dtpPocetak.TabIndex = 3;
            // 
            // lblKraj
            // 
            this.lblKraj.AutoSize = true;
            this.lblKraj.Location = new System.Drawing.Point(20, 100);
            this.lblKraj.Name = "lblKraj";
            this.lblKraj.Size = new System.Drawing.Size(30, 15);
            this.lblKraj.TabIndex = 4;
            this.lblKraj.Text = "Kraj:";
            // 
            // dtpKraj
            // 
            this.dtpKraj.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpKraj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKraj.Location = new System.Drawing.Point(100, 97);
            this.dtpKraj.Name = "dtpKraj";
            this.dtpKraj.Size = new System.Drawing.Size(150, 23);
            this.dtpKraj.TabIndex = 5;
            // 
            // lblSmena
            // 
            this.lblSmena.AutoSize = true;
            this.lblSmena.Location = new System.Drawing.Point(20, 140);
            this.lblSmena.Name = "lblSmena";
            this.lblSmena.Size = new System.Drawing.Size(45, 15);
            this.lblSmena.TabIndex = 6;
            this.lblSmena.Text = "Smena:";
            // 
            // cmbSmena
            // 
            this.cmbSmena.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSmena.FormattingEnabled = true;
            this.cmbSmena.Items.AddRange(new object[] {
            "Prva smena",
            "Druga smena",
            "Treća smena"});
            this.cmbSmena.Location = new System.Drawing.Point(100, 137);
            this.cmbSmena.Name = "cmbSmena";
            this.cmbSmena.Size = new System.Drawing.Size(150, 23);
            this.cmbSmena.TabIndex = 7;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(20, 180);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 30);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(110, 180);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 30);
            this.btnObrisi.TabIndex = 9;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.Location = new System.Drawing.Point(200, 180);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(75, 30);
            this.btnOsvezi.TabIndex = 10;
            this.btnOsvezi.Text = "Osveži";
            this.btnOsvezi.UseVisualStyleBackColor = true;
            this.btnOsvezi.Click += new System.EventHandler(this.btnOsvezi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(290, 180);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 30);
            this.btnZatvori.TabIndex = 11;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // dgvRaspored
            // 
            this.dgvRaspored.AllowUserToAddRows = false;
            this.dgvRaspored.AllowUserToDeleteRows = false;
            this.dgvRaspored.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaspored.Location = new System.Drawing.Point(20, 230);
            this.dgvRaspored.Name = "dgvRaspored";
            this.dgvRaspored.ReadOnly = true;
            this.dgvRaspored.Size = new System.Drawing.Size(750, 300);
            this.dgvRaspored.TabIndex = 12;
            // 
            // lblRaspored
            // 
            this.lblRaspored.AutoSize = true;
            this.lblRaspored.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRaspored.Location = new System.Drawing.Point(20, 210);
            this.lblRaspored.Name = "lblRaspored";
            this.lblRaspored.Size = new System.Drawing.Size(120, 19);
            this.lblRaspored.TabIndex = 13;
            this.lblRaspored.Text = "Raspored rada:";
            // 
            // RasporedRadaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.lblRaspored);
            this.Controls.Add(this.dgvRaspored);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnOsvezi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbSmena);
            this.Controls.Add(this.lblSmena);
            this.Controls.Add(this.dtpKraj);
            this.Controls.Add(this.lblKraj);
            this.Controls.Add(this.dtpPocetak);
            this.Controls.Add(this.lblPocetak);
            this.Controls.Add(this.cmbZaposleni);
            this.Controls.Add(this.lblZaposleni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RasporedRadaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Upravljanje rasporedom rada";
            this.Load += new System.EventHandler(this.RasporedRadaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblZaposleni;
        private System.Windows.Forms.ComboBox cmbZaposleni;
        private System.Windows.Forms.Label lblPocetak;
        private System.Windows.Forms.DateTimePicker dtpPocetak;
        private System.Windows.Forms.Label lblKraj;
        private System.Windows.Forms.DateTimePicker dtpKraj;
        private System.Windows.Forms.Label lblSmena;
        private System.Windows.Forms.ComboBox cmbSmena;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnOsvezi;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.DataGridView dgvRaspored;
        private System.Windows.Forms.Label lblRaspored;
    }
}
