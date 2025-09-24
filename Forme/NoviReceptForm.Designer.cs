namespace Farmacy.Forme
{
    partial class NoviReceptForm
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
            lblSerijskiBroj = new Label();
            txtSerijskiBroj = new TextBox();
            lblSifraLekara = new Label();
            txtSifraLekara = new TextBox();
            lblDatumIzd = new Label();
            dtpDatumIzd = new DateTimePicker();
            lblStatus = new Label();
            cboStatus = new ComboBox();
            lblNazivUstanove = new Label();
            txtNazivUstanove = new TextBox();
            lblRealizovanaProdajnaJedinica = new Label();
            txtRealizovanaProdajnaJedinica = new TextBox();
            lblRealizacijaDatum = new Label();
            dtpRealizacijaDatum = new DateTimePicker();
            lblRealizovaoFarmaceut = new Label();
            txtRealizovaoFarmaceut = new TextBox();
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
            panelHeader.BackColor = Color.FromArgb(170, 100, 200);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 100);
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
            lblTitle.Text = "➕ NOVI RECEPT";
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
            lblSubtitle.Text = "Dodavanje novog recepta u sistem";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(txtRealizovaoFarmaceut);
            panelMain.Controls.Add(lblRealizovaoFarmaceut);
            panelMain.Controls.Add(dtpRealizacijaDatum);
            panelMain.Controls.Add(lblRealizacijaDatum);
            panelMain.Controls.Add(txtRealizovanaProdajnaJedinica);
            panelMain.Controls.Add(lblRealizovanaProdajnaJedinica);
            panelMain.Controls.Add(txtNazivUstanove);
            panelMain.Controls.Add(lblNazivUstanove);
            panelMain.Controls.Add(cboStatus);
            panelMain.Controls.Add(lblStatus);
            panelMain.Controls.Add(dtpDatumIzd);
            panelMain.Controls.Add(lblDatumIzd);
            panelMain.Controls.Add(txtSifraLekara);
            panelMain.Controls.Add(lblSifraLekara);
            panelMain.Controls.Add(txtSerijskiBroj);
            panelMain.Controls.Add(lblSerijskiBroj);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 100);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(800, 400);
            panelMain.TabIndex = 1;
            // 
            // lblSerijskiBroj
            // 
            lblSerijskiBroj.AutoSize = true;
            lblSerijskiBroj.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSerijskiBroj.ForeColor = Color.FromArgb(33, 37, 41);
            lblSerijskiBroj.Location = new Point(20, 20);
            lblSerijskiBroj.Name = "lblSerijskiBroj";
            lblSerijskiBroj.Size = new Size(100, 19);
            lblSerijskiBroj.TabIndex = 0;
            lblSerijskiBroj.Text = "Serijski broj:";
            // 
            // txtSerijskiBroj
            // 
            txtSerijskiBroj.BorderStyle = BorderStyle.FixedSingle;
            txtSerijskiBroj.Font = new Font("Segoe UI", 10F);
            txtSerijskiBroj.Location = new Point(200, 20);
            txtSerijskiBroj.Name = "txtSerijskiBroj";
            txtSerijskiBroj.Size = new Size(300, 25);
            txtSerijskiBroj.TabIndex = 1;
            // 
            // lblSifraLekara
            // 
            lblSifraLekara.AutoSize = true;
            lblSifraLekara.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSifraLekara.ForeColor = Color.FromArgb(33, 37, 41);
            lblSifraLekara.Location = new Point(20, 60);
            lblSifraLekara.Name = "lblSifraLekara";
            lblSifraLekara.Size = new Size(95, 19);
            lblSifraLekara.TabIndex = 2;
            lblSifraLekara.Text = "Šifra lekara:";
            // 
            // txtSifraLekara
            // 
            txtSifraLekara.BorderStyle = BorderStyle.FixedSingle;
            txtSifraLekara.Font = new Font("Segoe UI", 10F);
            txtSifraLekara.Location = new Point(200, 60);
            txtSifraLekara.Name = "txtSifraLekara";
            txtSifraLekara.Size = new Size(300, 25);
            txtSifraLekara.TabIndex = 3;
            // 
            // lblDatumIzd
            // 
            lblDatumIzd.AutoSize = true;
            lblDatumIzd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDatumIzd.ForeColor = Color.FromArgb(33, 37, 41);
            lblDatumIzd.Location = new Point(20, 100);
            lblDatumIzd.Name = "lblDatumIzd";
            lblDatumIzd.Size = new Size(140, 19);
            lblDatumIzd.TabIndex = 4;
            lblDatumIzd.Text = "Datum izdavanja:";
            // 
            // dtpDatumIzd
            // 
            dtpDatumIzd.Font = new Font("Segoe UI", 10F);
            dtpDatumIzd.Format = DateTimePickerFormat.Short;
            dtpDatumIzd.Location = new Point(200, 100);
            dtpDatumIzd.Name = "dtpDatumIzd";
            dtpDatumIzd.Size = new Size(300, 25);
            dtpDatumIzd.TabIndex = 5;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(33, 37, 41);
            lblStatus.Location = new Point(20, 140);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 19);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status:";
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.Font = new Font("Segoe UI", 10F);
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(200, 140);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(300, 25);
            cboStatus.TabIndex = 7;
            // 
            // lblNazivUstanove
            // 
            lblNazivUstanove.AutoSize = true;
            lblNazivUstanove.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNazivUstanove.ForeColor = Color.FromArgb(33, 37, 41);
            lblNazivUstanove.Location = new Point(20, 180);
            lblNazivUstanove.Name = "lblNazivUstanove";
            lblNazivUstanove.Size = new Size(130, 19);
            lblNazivUstanove.TabIndex = 8;
            lblNazivUstanove.Text = "Naziv ustanove:";
            // 
            // txtNazivUstanove
            // 
            txtNazivUstanove.BorderStyle = BorderStyle.FixedSingle;
            txtNazivUstanove.Font = new Font("Segoe UI", 10F);
            txtNazivUstanove.Location = new Point(200, 180);
            txtNazivUstanove.Name = "txtNazivUstanove";
            txtNazivUstanove.Size = new Size(300, 25);
            txtNazivUstanove.TabIndex = 9;
            // 
            // lblRealizovanaProdajnaJedinica
            // 
            lblRealizovanaProdajnaJedinica.AutoSize = true;
            lblRealizovanaProdajnaJedinica.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRealizovanaProdajnaJedinica.ForeColor = Color.FromArgb(33, 37, 41);
            lblRealizovanaProdajnaJedinica.Location = new Point(20, 220);
            lblRealizovanaProdajnaJedinica.Name = "lblRealizovanaProdajnaJedinica";
            lblRealizovanaProdajnaJedinica.Size = new Size(240, 19);
            lblRealizovanaProdajnaJedinica.TabIndex = 10;
            lblRealizovanaProdajnaJedinica.Text = "Realizovana prodajna jedinica:";
            // 
            // txtRealizovanaProdajnaJedinica
            // 
            txtRealizovanaProdajnaJedinica.BackColor = Color.FromArgb(233, 236, 239);
            txtRealizovanaProdajnaJedinica.BorderStyle = BorderStyle.FixedSingle;
            txtRealizovanaProdajnaJedinica.Font = new Font("Segoe UI", 10F);
            txtRealizovanaProdajnaJedinica.Location = new Point(200, 220);
            txtRealizovanaProdajnaJedinica.Name = "txtRealizovanaProdajnaJedinica";
            txtRealizovanaProdajnaJedinica.ReadOnly = true;
            txtRealizovanaProdajnaJedinica.Size = new Size(300, 25);
            txtRealizovanaProdajnaJedinica.TabIndex = 11;
            txtRealizovanaProdajnaJedinica.TabStop = false;
            // 
            // lblRealizacijaDatum
            // 
            lblRealizacijaDatum.AutoSize = true;
            lblRealizacijaDatum.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRealizacijaDatum.ForeColor = Color.FromArgb(33, 37, 41);
            lblRealizacijaDatum.Location = new Point(20, 260);
            lblRealizacijaDatum.Name = "lblRealizacijaDatum";
            lblRealizacijaDatum.Size = new Size(140, 19);
            lblRealizacijaDatum.TabIndex = 12;
            lblRealizacijaDatum.Text = "Datum realizacije:";
            // 
            // dtpRealizacijaDatum
            // 
            dtpRealizacijaDatum.Enabled = false;
            dtpRealizacijaDatum.Font = new Font("Segoe UI", 10F);
            dtpRealizacijaDatum.Format = DateTimePickerFormat.Short;
            dtpRealizacijaDatum.Location = new Point(200, 260);
            dtpRealizacijaDatum.Name = "dtpRealizacijaDatum";
            dtpRealizacijaDatum.Size = new Size(300, 25);
            dtpRealizacijaDatum.TabIndex = 13;
            dtpRealizacijaDatum.ValueChanged += dtpRealizacijaDatum_ValueChanged;
            // 
            // lblRealizovaoFarmaceut
            // 
            lblRealizovaoFarmaceut.AutoSize = true;
            lblRealizovaoFarmaceut.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRealizovaoFarmaceut.ForeColor = Color.FromArgb(33, 37, 41);
            lblRealizovaoFarmaceut.Location = new Point(20, 300);
            lblRealizovaoFarmaceut.Name = "lblRealizovaoFarmaceut";
            lblRealizovaoFarmaceut.Size = new Size(180, 19);
            lblRealizovaoFarmaceut.TabIndex = 14;
            lblRealizovaoFarmaceut.Text = "Realizovao farmaceut:";
            // 
            // txtRealizovaoFarmaceut
            // 
            txtRealizovaoFarmaceut.BackColor = Color.FromArgb(233, 236, 239);
            txtRealizovaoFarmaceut.BorderStyle = BorderStyle.FixedSingle;
            txtRealizovaoFarmaceut.Font = new Font("Segoe UI", 10F);
            txtRealizovaoFarmaceut.Location = new Point(200, 300);
            txtRealizovaoFarmaceut.Name = "txtRealizovaoFarmaceut";
            txtRealizovaoFarmaceut.ReadOnly = true;
            txtRealizovaoFarmaceut.Size = new Size(300, 25);
            txtRealizovaoFarmaceut.TabIndex = 15;
            txtRealizovaoFarmaceut.TabStop = false;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(255, 255, 255);
            panelButtons.Controls.Add(btnCancel);
            panelButtons.Controls.Add(btnSave);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 500);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(20);
            panelButtons.Size = new Size(800, 80);
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
            panelFooter.Location = new Point(0, 580);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(800, 30);
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
            lblFooter.Text = "Recepti - Dodavanje novog recepta u sistem";
            // 
            // NoviReceptForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 610);
            Controls.Add(panelMain);
            Controls.Add(panelButtons);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "NoviReceptForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Farmacy System - Novi Recept";
            Load += NoviReceptForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelButtons.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblSerijskiBroj;
        private System.Windows.Forms.TextBox txtSerijskiBroj;
        private System.Windows.Forms.Label lblSifraLekara;
        private System.Windows.Forms.TextBox txtSifraLekara;
        private System.Windows.Forms.Label lblDatumIzd;
        private System.Windows.Forms.DateTimePicker dtpDatumIzd;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblNazivUstanove;
        private System.Windows.Forms.TextBox txtNazivUstanove;
        private System.Windows.Forms.Label lblRealizovanaProdajnaJedinica;
        private System.Windows.Forms.TextBox txtRealizovanaProdajnaJedinica;
        private System.Windows.Forms.Label lblRealizacijaDatum;
        private System.Windows.Forms.DateTimePicker dtpRealizacijaDatum;
        private System.Windows.Forms.Label lblRealizovaoFarmaceut;
        private System.Windows.Forms.TextBox txtRealizovaoFarmaceut;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
