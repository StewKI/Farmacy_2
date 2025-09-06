namespace Farmacy.Forme
{
    partial class ProizvodjacEditForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Label lblTitle;
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

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
            panelMain = new Panel();
            panelForm = new Panel();
            lblTitle = new Label();
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
            panelMain.SuspendLayout();
            panelForm.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(248, 249, 250);
            panelMain.Controls.Add(panelButtons);
            panelMain.Controls.Add(panelForm);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(500, 500);
            panelMain.TabIndex = 0;
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(txtEmail);
            panelForm.Controls.Add(txtTelefon);
            panelForm.Controls.Add(txtZemlja);
            panelForm.Controls.Add(txtNaziv);
            panelForm.Controls.Add(txtId);
            panelForm.Controls.Add(lblEmail);
            panelForm.Controls.Add(lblTelefon);
            panelForm.Controls.Add(lblZemlja);
            panelForm.Controls.Add(lblNaziv);
            panelForm.Controls.Add(lblId);
            panelForm.Controls.Add(lblTitle);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 0);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(30);
            panelForm.Size = new Size(500, 420);
            panelForm.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitle.Location = new Point(30, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(250, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Izmeni proizvodjača";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblId.ForeColor = Color.FromArgb(73, 80, 87);
            lblId.Location = new Point(30, 90);
            lblId.Name = "lblId";
            lblId.Size = new Size(30, 23);
            lblId.TabIndex = 1;
            lblId.Text = "ID:";
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNaziv.ForeColor = Color.FromArgb(73, 80, 87);
            lblNaziv.Location = new Point(30, 140);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(60, 23);
            lblNaziv.TabIndex = 2;
            lblNaziv.Text = "Naziv:";
            // 
            // lblZemlja
            // 
            lblZemlja.AutoSize = true;
            lblZemlja.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblZemlja.ForeColor = Color.FromArgb(73, 80, 87);
            lblZemlja.Location = new Point(30, 190);
            lblZemlja.Name = "lblZemlja";
            lblZemlja.Size = new Size(70, 23);
            lblZemlja.TabIndex = 3;
            lblZemlja.Text = "Zemlja:";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTelefon.ForeColor = Color.FromArgb(73, 80, 87);
            lblTelefon.Location = new Point(30, 240);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(80, 23);
            lblTelefon.TabIndex = 4;
            lblTelefon.Text = "Telefon:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(73, 80, 87);
            lblEmail.Location = new Point(30, 290);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 23);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(248, 249, 250);
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Font = new Font("Segoe UI", 10F);
            txtId.Location = new Point(120, 87);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(320, 30);
            txtId.TabIndex = 6;
            // 
            // txtNaziv
            // 
            txtNaziv.BorderStyle = BorderStyle.FixedSingle;
            txtNaziv.Font = new Font("Segoe UI", 10F);
            txtNaziv.Location = new Point(120, 137);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(320, 30);
            txtNaziv.TabIndex = 7;
            // 
            // txtZemlja
            // 
            txtZemlja.BorderStyle = BorderStyle.FixedSingle;
            txtZemlja.Font = new Font("Segoe UI", 10F);
            txtZemlja.Location = new Point(120, 187);
            txtZemlja.Name = "txtZemlja";
            txtZemlja.Size = new Size(320, 30);
            txtZemlja.TabIndex = 8;
            // 
            // txtTelefon
            // 
            txtTelefon.BorderStyle = BorderStyle.FixedSingle;
            txtTelefon.Font = new Font("Segoe UI", 10F);
            txtTelefon.Location = new Point(120, 237);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(320, 30);
            txtTelefon.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(120, 287);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(320, 30);
            txtEmail.TabIndex = 10;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(255, 255, 255);
            panelButtons.Controls.Add(btnCancel);
            panelButtons.Controls.Add(btnSave);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 420);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(30, 20, 30, 20);
            panelButtons.Size = new Size(500, 80);
            panelButtons.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(40, 167, 69);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(200, 20);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 40);
            btnSave.TabIndex = 0;
            btnSave.Text = "💾 Sačuvaj";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(108, 117, 125);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(330, 20);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "❌ Otkaži";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // ProizvodjacEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(500, 500);
            Controls.Add(panelMain);
            Name = "ProizvodjacEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Izmeni proizvodjača";
            panelMain.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}