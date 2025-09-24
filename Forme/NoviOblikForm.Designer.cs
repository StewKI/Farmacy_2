namespace Farmacy.Forme
{
    partial class NoviOblikForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnOtkazi;

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
            lblNaziv = new Label();
            txtNaziv = new TextBox();
            btnSacuvaj = new Button();
            btnOtkazi = new Button();
            SuspendLayout();
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(20, 30);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(35, 15);
            lblNaziv.TabIndex = 0;
            lblNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(80, 27);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(250, 23);
            txtNaziv.TabIndex = 1;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(80, 70);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(100, 30);
            btnSacuvaj.TabIndex = 2;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnOtkazi
            // 
            btnOtkazi.DialogResult = DialogResult.Cancel;
            btnOtkazi.Location = new Point(200, 70);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(100, 30);
            btnOtkazi.TabIndex = 3;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.UseVisualStyleBackColor = true;
            btnOtkazi.Click += btnOtkazi_Click;
            // 
            // NoviOblikForm
            // 
            AcceptButton = btnSacuvaj;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOtkazi;
            ClientSize = new Size(350, 120);
            Controls.Add(btnOtkazi);
            Controls.Add(btnSacuvaj);
            Controls.Add(txtNaziv);
            Controls.Add(lblNaziv);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NoviOblikForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Novi oblik";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}






