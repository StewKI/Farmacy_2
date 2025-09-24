namespace Farmacy.Forme
{
    partial class ProizvodjacEditForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblZemlja;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtZemlja;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
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
            lblZemlja = new Label();
            lblTelefon = new Label();
            lblEmail = new Label();
            txtId = new TextBox();
            txtNaziv = new TextBox();
            txtZemlja = new TextBox();
            txtTelefon = new TextBox();
            txtEmail = new TextBox();
            panelButtons = new Panel();
            btnSave = new Button();
            btnCancel = new Button();
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
            panelHeader.BackColor = Color.FromArgb(41, 128, 185);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(600, 100);
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
            lblTitle.Text = "✏️ IZMENI PROIZVOĐAČA";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(200, 200, 255);
            lblSubtitle.Location = new Point(20, 60);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(400, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Ažuriranje postojećeg proizvođača u sistemu";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(txtEmail);
            panelMain.Controls.Add(lblEmail);
            panelMain.Controls.Add(txtTelefon);
            panelMain.Controls.Add(lblTelefon);
            panelMain.Controls.Add(txtZemlja);
            panelMain.Controls.Add(lblZemlja);
            panelMain.Controls.Add(txtNaziv);
            panelMain.Controls.Add(lblNaziv);
            panelMain.Controls.Add(txtId);
            panelMain.Controls.Add(lblId);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 100);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(600, 300);
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
            lblNaziv.Size = new Size(55, 19);
            lblNaziv.TabIndex = 2;
            lblNaziv.Text = "Naziv:";
            // 
            // lblZemlja
            // 
            lblZemlja.AutoSize = true;
            lblZemlja.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblZemlja.ForeColor = Color.FromArgb(33, 37, 41);
            lblZemlja.Location = new Point(20, 100);
            lblZemlja.Name = "lblZemlja";
            lblZemlja.Size = new Size(70, 19);
            lblZemlja.TabIndex = 4;
            lblZemlja.Text = "Zemlja:";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTelefon.ForeColor = Color.FromArgb(33, 37, 41);
            lblTelefon.Location = new Point(20, 140);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(70, 19);
            lblTelefon.TabIndex = 6;
            lblTelefon.Text = "Telefon:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(33, 37, 41);
            lblEmail.Location = new Point(20, 180);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 19);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
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
            // txtZemlja
            // 
            txtZemlja.BorderStyle = BorderStyle.FixedSingle;
            txtZemlja.Font = new Font("Segoe UI", 10F);
            txtZemlja.Location = new Point(100, 100);
            txtZemlja.Name = "txtZemlja";
            txtZemlja.Size = new Size(300, 25);
            txtZemlja.TabIndex = 2;
            // 
            // txtTelefon
            // 
            txtTelefon.BorderStyle = BorderStyle.FixedSingle;
            txtTelefon.Font = new Font("Segoe UI", 10F);
            txtTelefon.Location = new Point(100, 140);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(300, 25);
            txtTelefon.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(100, 180);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 25);
            txtEmail.TabIndex = 4;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(255, 255, 255);
            panelButtons.Controls.Add(btnCancel);
            panelButtons.Controls.Add(btnSave);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 400);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(20);
            panelButtons.Size = new Size(600, 80);
            panelButtons.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(80, 220, 140);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(20, 15);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 50);
            btnSave.TabIndex = 0;
            btnSave.Text = "💾 Sačuvaj";
            btnSave.TextAlign = ContentAlignment.MiddleCenter;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            btnSave.MouseEnter += Button_MouseEnter;
            btnSave.MouseLeave += Button_MouseLeave;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(250, 120, 100);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(190, 15);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 50);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "❌ Otkaži";
            btnCancel.TextAlign = ContentAlignment.MiddleCenter;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            btnCancel.MouseEnter += Button_MouseEnter;
            btnCancel.MouseLeave += Button_MouseLeave;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(44, 62, 80);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 480);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(600, 30);
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
            lblFooter.Text = "Proizvođači - Ažuriranje postojećeg proizvođača u sistemu";
            // 
            // ProizvodjacEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 510);
            Controls.Add(panelMain);
            Controls.Add(panelButtons);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProizvodjacEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Farmacy System - Izmeni Proizvođača";
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