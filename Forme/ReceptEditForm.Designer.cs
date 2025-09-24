namespace Farmacy.Forme
{
    partial class ReceptEditForm
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
            this.lblSerijskiBroj = new System.Windows.Forms.Label();
            this.txtSerijskiBroj = new System.Windows.Forms.TextBox();
            this.lblSifraLekara = new System.Windows.Forms.Label();
            this.txtSifraLekara = new System.Windows.Forms.TextBox();
            this.lblDatumIzd = new System.Windows.Forms.Label();
            this.dtpDatumIzd = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblNazivUstanove = new System.Windows.Forms.Label();
            this.txtNazivUstanove = new System.Windows.Forms.TextBox();
            this.lblRealizovanaProdajnaJedinica = new System.Windows.Forms.Label();
            this.txtRealizovanaProdajnaJedinica = new System.Windows.Forms.TextBox();
            this.lblRealizacijaDatum = new System.Windows.Forms.Label();
            this.dtpRealizacijaDatum = new System.Windows.Forms.DateTimePicker();
            this.lblRealizovaoFarmaceut = new System.Windows.Forms.Label();
            this.txtRealizovaoFarmaceut = new System.Windows.Forms.TextBox();
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
            lblTitle.Text = "✏️ IZMENI RECEPT";
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
            lblSubtitle.Text = "Ažuriranje postojećeg recepta u sistemu";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(this.txtRealizovaoFarmaceut);
            panelMain.Controls.Add(this.lblRealizovaoFarmaceut);
            panelMain.Controls.Add(this.dtpRealizacijaDatum);
            panelMain.Controls.Add(this.lblRealizacijaDatum);
            panelMain.Controls.Add(this.txtRealizovanaProdajnaJedinica);
            panelMain.Controls.Add(this.lblRealizovanaProdajnaJedinica);
            panelMain.Controls.Add(this.txtNazivUstanove);
            panelMain.Controls.Add(this.lblNazivUstanove);
            panelMain.Controls.Add(this.cmbStatus);
            panelMain.Controls.Add(this.lblStatus);
            panelMain.Controls.Add(this.dtpDatumIzd);
            panelMain.Controls.Add(this.lblDatumIzd);
            panelMain.Controls.Add(this.txtSifraLekara);
            panelMain.Controls.Add(this.lblSifraLekara);
            panelMain.Controls.Add(this.txtSerijskiBroj);
            panelMain.Controls.Add(this.lblSerijskiBroj);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 100);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(800, 400);
            panelMain.TabIndex = 1;
            // 
            // lblSerijskiBroj
            // 
            this.lblSerijskiBroj.AutoSize = true;
            this.lblSerijskiBroj.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblSerijskiBroj.ForeColor = Color.FromArgb(33, 37, 41);
            this.lblSerijskiBroj.Location = new Point(20, 20);
            this.lblSerijskiBroj.Name = "lblSerijskiBroj";
            this.lblSerijskiBroj.Size = new Size(100, 19);
            this.lblSerijskiBroj.TabIndex = 0;
            this.lblSerijskiBroj.Text = "Serijski broj:";
            // 
            // txtSerijskiBroj
            // 
            this.txtSerijskiBroj.BorderStyle = BorderStyle.FixedSingle;
            this.txtSerijskiBroj.Font = new Font("Segoe UI", 10F);
            this.txtSerijskiBroj.Location = new Point(200, 20);
            this.txtSerijskiBroj.Name = "txtSerijskiBroj";
            this.txtSerijskiBroj.Size = new Size(300, 25);
            this.txtSerijskiBroj.TabIndex = 1;
            // 
            // lblSifraLekara
            // 
            this.lblSifraLekara.AutoSize = true;
            this.lblSifraLekara.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblSifraLekara.ForeColor = Color.FromArgb(33, 37, 41);
            this.lblSifraLekara.Location = new Point(20, 60);
            this.lblSifraLekara.Name = "lblSifraLekara";
            this.lblSifraLekara.Size = new Size(95, 19);
            this.lblSifraLekara.TabIndex = 2;
            this.lblSifraLekara.Text = "Šifra lekara:";
            // 
            // txtSifraLekara
            // 
            this.txtSifraLekara.BorderStyle = BorderStyle.FixedSingle;
            this.txtSifraLekara.Font = new Font("Segoe UI", 10F);
            this.txtSifraLekara.Location = new Point(200, 60);
            this.txtSifraLekara.Name = "txtSifraLekara";
            this.txtSifraLekara.Size = new Size(300, 25);
            this.txtSifraLekara.TabIndex = 3;
            // 
            // lblDatumIzd
            // 
            this.lblDatumIzd.AutoSize = true;
            this.lblDatumIzd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblDatumIzd.ForeColor = Color.FromArgb(33, 37, 41);
            this.lblDatumIzd.Location = new Point(20, 100);
            this.lblDatumIzd.Name = "lblDatumIzd";
            this.lblDatumIzd.Size = new Size(140, 19);
            this.lblDatumIzd.TabIndex = 4;
            this.lblDatumIzd.Text = "Datum izdavanja:";
            // 
            // dtpDatumIzd
            // 
            this.dtpDatumIzd.Font = new Font("Segoe UI", 10F);
            this.dtpDatumIzd.Format = DateTimePickerFormat.Short;
            this.dtpDatumIzd.Location = new Point(200, 100);
            this.dtpDatumIzd.Name = "dtpDatumIzd";
            this.dtpDatumIzd.Size = new Size(300, 25);
            this.dtpDatumIzd.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblStatus.ForeColor = Color.FromArgb(33, 37, 41);
            this.lblStatus.Location = new Point(20, 140);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(60, 19);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new Font("Segoe UI", 10F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Aktivan",
            "Realizovan",
            "Otkazan"});
            this.cmbStatus.Location = new Point(200, 140);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new Size(300, 25);
            this.cmbStatus.TabIndex = 7;
            // 
            // lblNazivUstanove
            // 
            this.lblNazivUstanove.AutoSize = true;
            this.lblNazivUstanove.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblNazivUstanove.ForeColor = Color.FromArgb(33, 37, 41);
            this.lblNazivUstanove.Location = new Point(20, 180);
            this.lblNazivUstanove.Name = "lblNazivUstanove";
            this.lblNazivUstanove.Size = new Size(130, 19);
            this.lblNazivUstanove.TabIndex = 8;
            this.lblNazivUstanove.Text = "Naziv ustanove:";
            // 
            // txtNazivUstanove
            // 
            this.txtNazivUstanove.BorderStyle = BorderStyle.FixedSingle;
            this.txtNazivUstanove.Font = new Font("Segoe UI", 10F);
            this.txtNazivUstanove.Location = new Point(200, 180);
            this.txtNazivUstanove.Name = "txtNazivUstanove";
            this.txtNazivUstanove.Size = new Size(300, 25);
            this.txtNazivUstanove.TabIndex = 9;
            // 
            // lblRealizovanaProdajnaJedinica
            // 
            this.lblRealizovanaProdajnaJedinica.AutoSize = true;
            this.lblRealizovanaProdajnaJedinica.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblRealizovanaProdajnaJedinica.ForeColor = Color.FromArgb(33, 37, 41);
            this.lblRealizovanaProdajnaJedinica.Location = new Point(20, 220);
            this.lblRealizovanaProdajnaJedinica.Name = "lblRealizovanaProdajnaJedinica";
            this.lblRealizovanaProdajnaJedinica.Size = new Size(240, 19);
            this.lblRealizovanaProdajnaJedinica.TabIndex = 10;
            this.lblRealizovanaProdajnaJedinica.Text = "Realizovana prodajna jedinica:";
            // 
            // txtRealizovanaProdajnaJedinica
            // 
            this.txtRealizovanaProdajnaJedinica.BackColor = Color.FromArgb(233, 236, 239);
            this.txtRealizovanaProdajnaJedinica.BorderStyle = BorderStyle.FixedSingle;
            this.txtRealizovanaProdajnaJedinica.Font = new Font("Segoe UI", 10F);
            this.txtRealizovanaProdajnaJedinica.Location = new Point(200, 220);
            this.txtRealizovanaProdajnaJedinica.Name = "txtRealizovanaProdajnaJedinica";
            this.txtRealizovanaProdajnaJedinica.ReadOnly = true;
            this.txtRealizovanaProdajnaJedinica.Size = new Size(300, 25);
            this.txtRealizovanaProdajnaJedinica.TabIndex = 11;
            // 
            // lblRealizacijaDatum
            // 
            this.lblRealizacijaDatum.AutoSize = true;
            this.lblRealizacijaDatum.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblRealizacijaDatum.ForeColor = Color.FromArgb(33, 37, 41);
            this.lblRealizacijaDatum.Location = new Point(20, 260);
            this.lblRealizacijaDatum.Name = "lblRealizacijaDatum";
            this.lblRealizacijaDatum.Size = new Size(140, 19);
            this.lblRealizacijaDatum.TabIndex = 12;
            this.lblRealizacijaDatum.Text = "Datum realizacije:";
            // 
            // dtpRealizacijaDatum
            // 
            this.dtpRealizacijaDatum.Font = new Font("Segoe UI", 10F);
            this.dtpRealizacijaDatum.Format = DateTimePickerFormat.Short;
            this.dtpRealizacijaDatum.Location = new Point(200, 260);
            this.dtpRealizacijaDatum.Name = "dtpRealizacijaDatum";
            this.dtpRealizacijaDatum.Size = new Size(300, 25);
            this.dtpRealizacijaDatum.TabIndex = 13;
            // 
            // lblRealizovaoFarmaceut
            // 
            this.lblRealizovaoFarmaceut.AutoSize = true;
            this.lblRealizovaoFarmaceut.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblRealizovaoFarmaceut.ForeColor = Color.FromArgb(33, 37, 41);
            this.lblRealizovaoFarmaceut.Location = new Point(20, 300);
            this.lblRealizovaoFarmaceut.Name = "lblRealizovaoFarmaceut";
            this.lblRealizovaoFarmaceut.Size = new Size(180, 19);
            this.lblRealizovaoFarmaceut.TabIndex = 14;
            this.lblRealizovaoFarmaceut.Text = "Realizovao farmaceut:";
            // 
            // txtRealizovaoFarmaceut
            // 
            this.txtRealizovaoFarmaceut.BackColor = Color.FromArgb(233, 236, 239);
            this.txtRealizovaoFarmaceut.BorderStyle = BorderStyle.FixedSingle;
            this.txtRealizovaoFarmaceut.Font = new Font("Segoe UI", 10F);
            this.txtRealizovaoFarmaceut.Location = new Point(200, 300);
            this.txtRealizovaoFarmaceut.Name = "txtRealizovaoFarmaceut";
            this.txtRealizovaoFarmaceut.ReadOnly = true;
            this.txtRealizovaoFarmaceut.Size = new Size(300, 25);
            this.txtRealizovaoFarmaceut.TabIndex = 15;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(255, 255, 255);
            panelButtons.Controls.Add(this.btnCancel);
            panelButtons.Controls.Add(this.btnSave);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 500);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(20);
            panelButtons.Size = new Size(800, 80);
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
            lblFooter.Text = "Recepti - Ažuriranje postojećeg recepta u sistemu";
            // 
            // ReceptEditForm
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(800, 610);
            this.Controls.Add(panelMain);
            this.Controls.Add(panelButtons);
            this.Controls.Add(panelFooter);
            this.Controls.Add(panelHeader);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReceptEditForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Farmacy System - Izmeni Recept";
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

        private System.Windows.Forms.Label lblSerijskiBroj;
        private System.Windows.Forms.TextBox txtSerijskiBroj;
        private System.Windows.Forms.Label lblSifraLekara;
        private System.Windows.Forms.TextBox txtSifraLekara;
        private System.Windows.Forms.Label lblDatumIzd;
        private System.Windows.Forms.DateTimePicker dtpDatumIzd;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
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
