namespace Farmacy.Forme
{
    partial class ReceptStavkaForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblReceptInfo;
        private System.Windows.Forms.Label lblLek;
        private System.Windows.Forms.ComboBox cmbLek;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnUpravljajPakovanjima;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblReceptInfo = new Label();
            lblLek = new Label();
            cmbLek = new ComboBox();
            lblKolicina = new Label();
            txtKolicina = new TextBox();
            btnDodajStavku = new Button();
            btnZatvori = new Button();
            btnUpravljajPakovanjima = new Button();
            SuspendLayout();
            // 
            // lblReceptInfo
            // 
            lblReceptInfo.AutoSize = true;
            lblReceptInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblReceptInfo.Location = new Point(20, 20);
            lblReceptInfo.Name = "lblReceptInfo";
            lblReceptInfo.Size = new Size(200, 19);
            lblReceptInfo.TabIndex = 0;
            lblReceptInfo.Text = "Recept: [Serijski broj]";
            // 
            // lblLek
            // 
            lblLek.AutoSize = true;
            lblLek.Location = new Point(20, 60);
            lblLek.Name = "lblLek";
            lblLek.Size = new Size(30, 15);
            lblLek.TabIndex = 1;
            lblLek.Text = "Lek:";
            // 
            // cmbLek
            // 
            cmbLek.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLek.FormattingEnabled = true;
            cmbLek.Location = new Point(80, 57);
            cmbLek.Name = "cmbLek";
            cmbLek.Size = new Size(300, 23);
            cmbLek.TabIndex = 2;
            // 
            // lblKolicina
            // 
            lblKolicina.AutoSize = true;
            lblKolicina.Location = new Point(20, 100);
            lblKolicina.Name = "lblKolicina";
            lblKolicina.Size = new Size(55, 15);
            lblKolicina.TabIndex = 3;
            lblKolicina.Text = "Količina:";
            // 
            // txtKolicina
            // 
            txtKolicina.Location = new Point(80, 97);
            txtKolicina.Name = "txtKolicina";
            txtKolicina.Size = new Size(100, 23);
            txtKolicina.TabIndex = 4;
            // 
            // btnDodajStavku
            // 
            btnDodajStavku.Location = new Point(80, 140);
            btnDodajStavku.Name = "btnDodajStavku";
            btnDodajStavku.Size = new Size(120, 30);
            btnDodajStavku.TabIndex = 5;
            btnDodajStavku.Text = "Dodaj stavku";
            btnDodajStavku.UseVisualStyleBackColor = true;
            btnDodajStavku.Click += btnDodajStavku_Click;
            // 
            // btnZatvori
            // 
            btnZatvori.Location = new Point(220, 140);
            btnZatvori.Name = "btnZatvori";
            btnZatvori.Size = new Size(100, 30);
            btnZatvori.TabIndex = 6;
            btnZatvori.Text = "Zatvori";
            btnZatvori.UseVisualStyleBackColor = true;
            btnZatvori.Click += btnZatvori_Click;
            // 
            // btnUpravljajPakovanjima
            // 
            btnUpravljajPakovanjima.Location = new Point(80, 180);
            btnUpravljajPakovanjima.Name = "btnUpravljajPakovanjima";
            btnUpravljajPakovanjima.Size = new Size(160, 30);
            btnUpravljajPakovanjima.TabIndex = 7;
            btnUpravljajPakovanjima.Text = "Upravljaj pakovanjima";
            btnUpravljajPakovanjima.UseVisualStyleBackColor = true;
            btnUpravljajPakovanjima.Click += btnUpravljajPakovanjima_Click;
            // 
            // ReceptStavkaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 230);
            Controls.Add(btnUpravljajPakovanjima);
            Controls.Add(btnZatvori);
            Controls.Add(btnDodajStavku);
            Controls.Add(txtKolicina);
            Controls.Add(lblKolicina);
            Controls.Add(cmbLek);
            Controls.Add(lblLek);
            Controls.Add(lblReceptInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReceptStavkaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj stavku recepta";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}