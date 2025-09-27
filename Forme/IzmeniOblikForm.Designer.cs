namespace Farmacy.Forme
{
    partial class IzmeniOblikForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtId;
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
            lblId = new Label();
            lblNaziv = new Label();
            txtId = new TextBox();
            txtNaziv = new TextBox();
            btnSacuvaj = new Button();
            btnOtkazi = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(20, 30);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(20, 60);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(35, 15);
            lblNaziv.TabIndex = 1;
            lblNaziv.Text = "Naziv:";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLight;
            txtId.Location = new Point(80, 27);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 2;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(80, 57);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(250, 23);
            txtNaziv.TabIndex = 3;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(80, 100);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(100, 30);
            btnSacuvaj.TabIndex = 4;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnOtkazi
            // 
            btnOtkazi.DialogResult = DialogResult.Cancel;
            btnOtkazi.Location = new Point(200, 100);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(100, 30);
            btnOtkazi.TabIndex = 5;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.UseVisualStyleBackColor = true;
            btnOtkazi.Click += btnOtkazi_Click;
            // 
            // IzmeniOblikForm
            // 
            AcceptButton = btnSacuvaj;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOtkazi;
            ClientSize = new Size(350, 150);
            Controls.Add(btnOtkazi);
            Controls.Add(btnSacuvaj);
            Controls.Add(txtNaziv);
            Controls.Add(txtId);
            Controls.Add(lblNaziv);
            Controls.Add(lblId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "IzmeniOblikForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Izmeni oblik";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}









