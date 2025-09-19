namespace Farmacy.Forme
{
    partial class IzmeniSekundarnuGrupuForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooter;

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
            panelHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            panelMain = new Panel();
            lblId = new Label();
            lblNaziv = new Label();
            txtId = new TextBox();
            txtNaziv = new TextBox();
            panelButtons = new Panel();
            btnSacuvaj = new Button();
            btnOtkazi = new Button();
            panelFooter = new Panel();
            lblFooter = new Label();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(255, 220, 80);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(500, 100);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "✏️ IZMENI SEKUNDARNU GRUPU";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(255, 240, 150);
            lblSubtitle.Location = new Point(20, 60);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(400, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Ažuriranje podataka o sekundarnoj grupi lekova";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(txtNaziv);
            panelMain.Controls.Add(txtId);
            panelMain.Controls.Add(lblNaziv);
            panelMain.Controls.Add(lblId);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 100);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(500, 200);
            panelMain.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblId.ForeColor = Color.FromArgb(33, 37, 41);
            lblId.Location = new Point(20, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(30, 19);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNaziv.ForeColor = Color.FromArgb(33, 37, 41);
            lblNaziv.Location = new Point(20, 60);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(50, 19);
            lblNaziv.TabIndex = 1;
            lblNaziv.Text = "Naziv:";
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(233, 236, 239);
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Font = new Font("Segoe UI", 10F);
            txtId.Location = new Point(100, 20);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(200, 25);
            txtId.TabIndex = 0;
            txtId.TabStop = false;
            // 
            // txtNaziv
            // 
            txtNaziv.BorderStyle = BorderStyle.FixedSingle;
            txtNaziv.Font = new Font("Segoe UI", 10F);
            txtNaziv.Location = new Point(100, 60);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(300, 25);
            txtNaziv.TabIndex = 1;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(255, 255, 255);
            panelButtons.Controls.Add(btnOtkazi);
            panelButtons.Controls.Add(btnSacuvaj);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 300);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(20);
            panelButtons.Size = new Size(500, 80);
            panelButtons.TabIndex = 2;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.BackColor = Color.FromArgb(80, 220, 140);
            btnSacuvaj.FlatAppearance.BorderSize = 0;
            btnSacuvaj.FlatStyle = FlatStyle.Flat;
            btnSacuvaj.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSacuvaj.ForeColor = Color.White;
            btnSacuvaj.Location = new Point(20, 15);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(150, 50);
            btnSacuvaj.TabIndex = 0;
            btnSacuvaj.Text = "💾 Sačuvaj";
            btnSacuvaj.TextAlign = ContentAlignment.MiddleCenter;
            btnSacuvaj.UseVisualStyleBackColor = false;
            btnSacuvaj.Click += btnSacuvaj_Click;
            btnSacuvaj.MouseEnter += Button_MouseEnter;
            btnSacuvaj.MouseLeave += Button_MouseLeave;
            // 
            // btnOtkazi
            // 
            btnOtkazi.BackColor = Color.FromArgb(250, 120, 100);
            btnOtkazi.DialogResult = DialogResult.Cancel;
            btnOtkazi.FlatAppearance.BorderSize = 0;
            btnOtkazi.FlatStyle = FlatStyle.Flat;
            btnOtkazi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnOtkazi.ForeColor = Color.White;
            btnOtkazi.Location = new Point(190, 15);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(150, 50);
            btnOtkazi.TabIndex = 1;
            btnOtkazi.Text = "❌ Otkaži";
            btnOtkazi.TextAlign = ContentAlignment.MiddleCenter;
            btnOtkazi.UseVisualStyleBackColor = false;
            btnOtkazi.Click += btnOtkazi_Click;
            btnOtkazi.MouseEnter += Button_MouseEnter;
            btnOtkazi.MouseLeave += Button_MouseLeave;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(44, 62, 80);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 380);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(500, 30);
            panelFooter.TabIndex = 3;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 8F);
            lblFooter.ForeColor = Color.FromArgb(189, 195, 199);
            lblFooter.Location = new Point(20, 8);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(250, 13);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Sekundarne grupe - Ažuriranje podataka o sekundarnoj grupi";
            // 
            // IzmeniSekundarnuGrupuForm
            // 
            AcceptButton = btnSacuvaj;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnOtkazi;
            ClientSize = new Size(500, 410);
            Controls.Add(panelMain);
            Controls.Add(panelButtons);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "IzmeniSekundarnuGrupuForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Farmacy System - Izmeni Sekundarnu Grupu";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelButtons.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }
    }
}



