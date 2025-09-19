namespace Farmacy.Forme
{
    partial class ProizvodjacForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooter;

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
            panelHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            panelMain = new Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblZemlja = new System.Windows.Forms.Label();
            this.txtZemlja = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            panelButtons = new Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            panelFooter = new Panel();
            lblFooter = new Label();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
            panelFooter.SuspendLayout();
            this.SuspendLayout();
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
            lblTitle.Text = "➕ NOVI PROIZVOĐAČ";
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
            lblSubtitle.Text = "Dodavanje novog proizvođača u sistem";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(this.txtEmail);
            panelMain.Controls.Add(this.lblEmail);
            panelMain.Controls.Add(this.txtTelefon);
            panelMain.Controls.Add(this.lblTelefon);
            panelMain.Controls.Add(this.txtZemlja);
            panelMain.Controls.Add(this.lblZemlja);
            panelMain.Controls.Add(this.txtNaziv);
            panelMain.Controls.Add(this.lblNaziv);
            panelMain.Controls.Add(this.txtId);
            panelMain.Controls.Add(this.lblId);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 100);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(600, 300);
            panelMain.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblId.ForeColor = Color.FromArgb(33, 37, 41);
            this.lblId.Location = new Point(20, 20);
            this.lblId.Name = "lblId";
            this.lblId.Size = new Size(30, 19);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.BackColor = Color.FromArgb(233, 236, 239);
            this.txtId.BorderStyle = BorderStyle.FixedSingle;
            this.txtId.Font = new Font("Segoe UI", 10F);
            this.txtId.Location = new Point(100, 20);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new Size(200, 25);
            this.txtId.TabIndex = 0;
            this.txtId.TabStop = false;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblNaziv.ForeColor = Color.FromArgb(33, 37, 41);
            this.lblNaziv.Location = new Point(20, 60);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new Size(55, 19);
            this.lblNaziv.TabIndex = 2;
            this.lblNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.BorderStyle = BorderStyle.FixedSingle;
            this.txtNaziv.Font = new Font("Segoe UI", 10F);
            this.txtNaziv.Location = new Point(100, 60);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new Size(300, 25);
            this.txtNaziv.TabIndex = 1;
            // 
            // lblZemlja
            // 
            this.lblZemlja.AutoSize = true;
            this.lblZemlja.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblZemlja.ForeColor = Color.FromArgb(33, 37, 41);
            this.lblZemlja.Location = new Point(20, 100);
            this.lblZemlja.Name = "lblZemlja";
            this.lblZemlja.Size = new Size(70, 19);
            this.lblZemlja.TabIndex = 4;
            this.lblZemlja.Text = "Zemlja:";
            // 
            // txtZemlja
            // 
            this.txtZemlja.BorderStyle = BorderStyle.FixedSingle;
            this.txtZemlja.Font = new Font("Segoe UI", 10F);
            this.txtZemlja.Location = new Point(100, 100);
            this.txtZemlja.Name = "txtZemlja";
            this.txtZemlja.Size = new Size(300, 25);
            this.txtZemlja.TabIndex = 2;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblTelefon.ForeColor = Color.FromArgb(33, 37, 41);
            this.lblTelefon.Location = new Point(20, 140);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new Size(70, 19);
            this.lblTelefon.TabIndex = 6;
            this.lblTelefon.Text = "Telefon:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.BorderStyle = BorderStyle.FixedSingle;
            this.txtTelefon.Font = new Font("Segoe UI", 10F);
            this.txtTelefon.Location = new Point(100, 140);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new Size(300, 25);
            this.txtTelefon.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblEmail.ForeColor = Color.FromArgb(33, 37, 41);
            this.lblEmail.Location = new Point(20, 180);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new Size(60, 19);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = BorderStyle.FixedSingle;
            this.txtEmail.Font = new Font("Segoe UI", 10F);
            this.txtEmail.Location = new Point(100, 180);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(300, 25);
            this.txtEmail.TabIndex = 4;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(255, 255, 255);
            panelButtons.Controls.Add(this.btnCancel);
            panelButtons.Controls.Add(this.btnSave);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 400);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(20);
            panelButtons.Size = new Size(600, 80);
            panelButtons.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = Color.FromArgb(80, 220, 140);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSave.ForeColor = Color.White;
            this.btnSave.Location = new Point(20, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new Size(150, 50);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "💾 Sačuvaj";
            this.btnSave.TextAlign = ContentAlignment.MiddleCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += Button_MouseEnter;
            this.btnSave.MouseLeave += Button_MouseLeave;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = Color.FromArgb(250, 120, 100);
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCancel.ForeColor = Color.White;
            this.btnCancel.Location = new Point(190, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(150, 50);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "❌ Otkaži";
            this.btnCancel.TextAlign = ContentAlignment.MiddleCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += Button_MouseEnter;
            this.btnCancel.MouseLeave += Button_MouseLeave;
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
            lblFooter.Text = "Proizvođači - Dodavanje novog proizvođača u sistem";
            // 
            // ProizvodjacForm
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(600, 510);
            this.Controls.Add(panelMain);
            this.Controls.Add(panelButtons);
            this.Controls.Add(panelFooter);
            this.Controls.Add(panelHeader);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProizvodjacForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Farmacy System - Novi Proizvođač";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelButtons.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblZemlja;
        private System.Windows.Forms.TextBox txtZemlja;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
