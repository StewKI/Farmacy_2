namespace Farmacy.Forme
{
    partial class ReceptStavkaForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblReceptInfo;
        private System.Windows.Forms.Label lblLek;
        private System.Windows.Forms.ComboBox cmbLek;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnUpravljajPakovanjima;
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
            lblReceptInfo = new Label();
            lblLek = new Label();
            cmbLek = new ComboBox();
            lblKolicina = new Label();
            txtKolicina = new TextBox();
            panelButtons = new Panel();
            btnDodajStavku = new Button();
            btnZatvori = new Button();
            btnUpravljajPakovanjima = new Button();
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
            panelHeader.BackColor = Color.FromArgb(170, 100, 200);
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
            lblTitle.Text = "➕ DODAJ STAVKU RECEPTA";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(200, 150, 220);
            lblSubtitle.Location = new Point(20, 60);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(400, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Dodavanje nove stavke u postojeći recept";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(txtKolicina);
            panelMain.Controls.Add(lblKolicina);
            panelMain.Controls.Add(cmbLek);
            panelMain.Controls.Add(lblLek);
            panelMain.Controls.Add(lblReceptInfo);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 100);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(600, 200);
            panelMain.TabIndex = 1;
            // 
            // lblReceptInfo
            // 
            lblReceptInfo.AutoSize = true;
            lblReceptInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblReceptInfo.ForeColor = Color.FromArgb(33, 37, 41);
            lblReceptInfo.Location = new Point(20, 20);
            lblReceptInfo.Name = "lblReceptInfo";
            lblReceptInfo.Size = new Size(200, 21);
            lblReceptInfo.TabIndex = 0;
            lblReceptInfo.Text = "Recept: [Serijski broj]";
            // 
            // lblLek
            // 
            lblLek.AutoSize = true;
            lblLek.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLek.ForeColor = Color.FromArgb(33, 37, 41);
            lblLek.Location = new Point(20, 60);
            lblLek.Name = "lblLek";
            lblLek.Size = new Size(40, 19);
            lblLek.TabIndex = 1;
            lblLek.Text = "Lek:";
            // 
            // cmbLek
            // 
            cmbLek.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLek.Font = new Font("Segoe UI", 10F);
            cmbLek.FormattingEnabled = true;
            cmbLek.Location = new Point(100, 60);
            cmbLek.Name = "cmbLek";
            cmbLek.Size = new Size(400, 25);
            cmbLek.TabIndex = 2;
            // 
            // lblKolicina
            // 
            lblKolicina.AutoSize = true;
            lblKolicina.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblKolicina.ForeColor = Color.FromArgb(33, 37, 41);
            lblKolicina.Location = new Point(20, 100);
            lblKolicina.Name = "lblKolicina";
            lblKolicina.Size = new Size(70, 19);
            lblKolicina.TabIndex = 3;
            lblKolicina.Text = "Količina:";
            // 
            // txtKolicina
            // 
            txtKolicina.BorderStyle = BorderStyle.FixedSingle;
            txtKolicina.Font = new Font("Segoe UI", 10F);
            txtKolicina.Location = new Point(100, 100);
            txtKolicina.Name = "txtKolicina";
            txtKolicina.Size = new Size(150, 25);
            txtKolicina.TabIndex = 4;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(255, 255, 255);
            panelButtons.Controls.Add(btnUpravljajPakovanjima);
            panelButtons.Controls.Add(btnZatvori);
            panelButtons.Controls.Add(btnDodajStavku);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 300);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(20);
            panelButtons.Size = new Size(600, 100);
            panelButtons.TabIndex = 2;
            // 
            // btnDodajStavku
            // 
            btnDodajStavku.BackColor = Color.FromArgb(80, 220, 140);
            btnDodajStavku.FlatAppearance.BorderSize = 0;
            btnDodajStavku.FlatStyle = FlatStyle.Flat;
            btnDodajStavku.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDodajStavku.ForeColor = Color.White;
            btnDodajStavku.Location = new Point(20, 15);
            btnDodajStavku.Name = "btnDodajStavku";
            btnDodajStavku.Size = new Size(150, 50);
            btnDodajStavku.TabIndex = 0;
            btnDodajStavku.Text = "➕ Dodaj stavku";
            btnDodajStavku.TextAlign = ContentAlignment.MiddleCenter;
            btnDodajStavku.UseVisualStyleBackColor = false;
            btnDodajStavku.Click += btnDodajStavku_Click;
            btnDodajStavku.MouseEnter += Button_MouseEnter;
            btnDodajStavku.MouseLeave += Button_MouseLeave;
            // 
            // btnZatvori
            // 
            btnZatvori.BackColor = Color.FromArgb(250, 120, 100);
            btnZatvori.FlatAppearance.BorderSize = 0;
            btnZatvori.FlatStyle = FlatStyle.Flat;
            btnZatvori.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnZatvori.ForeColor = Color.White;
            btnZatvori.Location = new Point(190, 15);
            btnZatvori.Name = "btnZatvori";
            btnZatvori.Size = new Size(150, 50);
            btnZatvori.TabIndex = 1;
            btnZatvori.Text = "❌ Zatvori";
            btnZatvori.TextAlign = ContentAlignment.MiddleCenter;
            btnZatvori.UseVisualStyleBackColor = false;
            btnZatvori.Click += btnZatvori_Click;
            btnZatvori.MouseEnter += Button_MouseEnter;
            btnZatvori.MouseLeave += Button_MouseLeave;
            // 
            // btnUpravljajPakovanjima
            // 
            btnUpravljajPakovanjima.BackColor = Color.FromArgb(80, 170, 230);
            btnUpravljajPakovanjima.FlatAppearance.BorderSize = 0;
            btnUpravljajPakovanjima.FlatStyle = FlatStyle.Flat;
            btnUpravljajPakovanjima.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpravljajPakovanjima.ForeColor = Color.White;
            btnUpravljajPakovanjima.Location = new Point(360, 15);
            btnUpravljajPakovanjima.Name = "btnUpravljajPakovanjima";
            btnUpravljajPakovanjima.Size = new Size(200, 50);
            btnUpravljajPakovanjima.TabIndex = 2;
            btnUpravljajPakovanjima.Text = "📦 Upravljaj pakovanjima";
            btnUpravljajPakovanjima.TextAlign = ContentAlignment.MiddleCenter;
            btnUpravljajPakovanjima.UseVisualStyleBackColor = false;
            btnUpravljajPakovanjima.Click += btnUpravljajPakovanjima_Click;
            btnUpravljajPakovanjima.MouseEnter += Button_MouseEnter;
            btnUpravljajPakovanjima.MouseLeave += Button_MouseLeave;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(44, 62, 80);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 400);
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
            lblFooter.Text = "Recepti - Dodavanje nove stavke u postojeći recept";
            // 
            // ReceptStavkaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 430);
            Controls.Add(panelMain);
            Controls.Add(panelButtons);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ReceptStavkaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Farmacy System - Dodaj Stavku Recepta";
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