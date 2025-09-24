namespace Farmacy.Forme
{
    partial class ZalihaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            btnCancel = new Button();
            btnSave = new Button();
            cmbOdgovorniMagacioner = new ComboBox();
            lblOdgovorniMagacioner = new Label();
            dtpDatumPoslednjeIsporuke = new DateTimePicker();
            lblDatumPoslednjeIsporuke = new Label();
            numKolicina = new NumericUpDown();
            lblKolicina = new Label();
            cmbPakovanje = new ComboBox();
            lblPakovanje = new Label();
            cmbProdajnaJedinica = new ComboBox();
            lblProdajnaJedinica = new Label();
            panelFooter = new Panel();
            lblFooter = new Label();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numKolicina).BeginInit();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(41, 128, 185);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(252, 59);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📦 ZALIHA";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(189, 195, 199);
            lblSubtitle.Location = new Point(20, 45);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(486, 37);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Dodavanje ili izmena zalihe u magacinu";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(btnCancel);
            panelMain.Controls.Add(btnSave);
            panelMain.Controls.Add(cmbOdgovorniMagacioner);
            panelMain.Controls.Add(lblOdgovorniMagacioner);
            panelMain.Controls.Add(dtpDatumPoslednjeIsporuke);
            panelMain.Controls.Add(lblDatumPoslednjeIsporuke);
            panelMain.Controls.Add(numKolicina);
            panelMain.Controls.Add(lblKolicina);
            panelMain.Controls.Add(cmbPakovanje);
            panelMain.Controls.Add(lblPakovanje);
            panelMain.Controls.Add(cmbProdajnaJedinica);
            panelMain.Controls.Add(lblProdajnaJedinica);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 80);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(800, 500);
            panelMain.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(350, 350);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 60);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "❌ Otkaži";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(41, 128, 185);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(200, 350);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 60);
            btnSave.TabIndex = 10;
            btnSave.Text = "💾 Sačuvaj";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cmbOdgovorniMagacioner
            // 
            cmbOdgovorniMagacioner.BackColor = Color.White;
            cmbOdgovorniMagacioner.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOdgovorniMagacioner.Font = new Font("Segoe UI", 10F);
            cmbOdgovorniMagacioner.FormattingEnabled = true;
            cmbOdgovorniMagacioner.Location = new Point(451, 270);
            cmbOdgovorniMagacioner.Name = "cmbOdgovorniMagacioner";
            cmbOdgovorniMagacioner.Size = new Size(300, 45);
            cmbOdgovorniMagacioner.TabIndex = 9;
            // 
            // lblOdgovorniMagacioner
            // 
            lblOdgovorniMagacioner.AutoSize = true;
            lblOdgovorniMagacioner.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOdgovorniMagacioner.ForeColor = Color.FromArgb(44, 62, 80);
            lblOdgovorniMagacioner.Location = new Point(50, 270);
            lblOdgovorniMagacioner.Name = "lblOdgovorniMagacioner";
            lblOdgovorniMagacioner.Size = new Size(322, 37);
            lblOdgovorniMagacioner.TabIndex = 8;
            lblOdgovorniMagacioner.Text = "Odgovorni magacioner:";
            // 
            // dtpDatumPoslednjeIsporuke
            // 
            dtpDatumPoslednjeIsporuke.Font = new Font("Segoe UI", 10F);
            dtpDatumPoslednjeIsporuke.Format = DateTimePickerFormat.Short;
            dtpDatumPoslednjeIsporuke.Location = new Point(451, 204);
            dtpDatumPoslednjeIsporuke.Name = "dtpDatumPoslednjeIsporuke";
            dtpDatumPoslednjeIsporuke.Size = new Size(150, 43);
            dtpDatumPoslednjeIsporuke.TabIndex = 7;
            // 
            // lblDatumPoslednjeIsporuke
            // 
            lblDatumPoslednjeIsporuke.AutoSize = true;
            lblDatumPoslednjeIsporuke.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDatumPoslednjeIsporuke.ForeColor = Color.FromArgb(44, 62, 80);
            lblDatumPoslednjeIsporuke.Location = new Point(50, 210);
            lblDatumPoslednjeIsporuke.Name = "lblDatumPoslednjeIsporuke";
            lblDatumPoslednjeIsporuke.Size = new Size(361, 37);
            lblDatumPoslednjeIsporuke.TabIndex = 6;
            lblDatumPoslednjeIsporuke.Text = "Datum poslednje isporuke:";
            // 
            // numKolicina
            // 
            numKolicina.BackColor = Color.White;
            numKolicina.BorderStyle = BorderStyle.FixedSingle;
            numKolicina.Font = new Font("Segoe UI", 10F);
            numKolicina.Location = new Point(451, 144);
            numKolicina.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numKolicina.Name = "numKolicina";
            numKolicina.Size = new Size(150, 43);
            numKolicina.TabIndex = 5;
            // 
            // lblKolicina
            // 
            lblKolicina.AutoSize = true;
            lblKolicina.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblKolicina.ForeColor = Color.FromArgb(44, 62, 80);
            lblKolicina.Location = new Point(50, 150);
            lblKolicina.Name = "lblKolicina";
            lblKolicina.Size = new Size(127, 37);
            lblKolicina.TabIndex = 4;
            lblKolicina.Text = "Količina:";
            // 
            // cmbPakovanje
            // 
            cmbPakovanje.BackColor = Color.White;
            cmbPakovanje.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPakovanje.Font = new Font("Segoe UI", 10F);
            cmbPakovanje.FormattingEnabled = true;
            cmbPakovanje.Location = new Point(451, 82);
            cmbPakovanje.Name = "cmbPakovanje";
            cmbPakovanje.Size = new Size(300, 45);
            cmbPakovanje.TabIndex = 3;
            // 
            // lblPakovanje
            // 
            lblPakovanje.AutoSize = true;
            lblPakovanje.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPakovanje.ForeColor = Color.FromArgb(44, 62, 80);
            lblPakovanje.Location = new Point(50, 90);
            lblPakovanje.Name = "lblPakovanje";
            lblPakovanje.Size = new Size(156, 37);
            lblPakovanje.TabIndex = 2;
            lblPakovanje.Text = "Pakovanje:";
            // 
            // cmbProdajnaJedinica
            // 
            cmbProdajnaJedinica.BackColor = Color.White;
            cmbProdajnaJedinica.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProdajnaJedinica.Font = new Font("Segoe UI", 10F);
            cmbProdajnaJedinica.FormattingEnabled = true;
            cmbProdajnaJedinica.Location = new Point(451, 23);
            cmbProdajnaJedinica.Name = "cmbProdajnaJedinica";
            cmbProdajnaJedinica.Size = new Size(300, 45);
            cmbProdajnaJedinica.TabIndex = 1;
            // 
            // lblProdajnaJedinica
            // 
            lblProdajnaJedinica.AutoSize = true;
            lblProdajnaJedinica.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProdajnaJedinica.ForeColor = Color.FromArgb(44, 62, 80);
            lblProdajnaJedinica.Location = new Point(50, 30);
            lblProdajnaJedinica.Name = "lblProdajnaJedinica";
            lblProdajnaJedinica.Size = new Size(247, 37);
            lblProdajnaJedinica.TabIndex = 0;
            lblProdajnaJedinica.Text = "Prodajna jedinica:";
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(44, 62, 80);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 580);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(800, 30);
            panelFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 8F);
            lblFooter.ForeColor = Color.FromArgb(189, 195, 199);
            lblFooter.Location = new Point(20, 8);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(463, 30);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Sistem za upravljanje farmaceutskim podacima";
            // 
            // ZalihaForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 610);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Controls.Add(panelFooter);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ZalihaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zaliha - Dodavanje/Izmena";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numKolicina).EndInit();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label lblProdajnaJedinica;
        private System.Windows.Forms.ComboBox cmbProdajnaJedinica;
        private System.Windows.Forms.Label lblPakovanje;
        private System.Windows.Forms.ComboBox cmbPakovanje;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.Label lblDatumPoslednjeIsporuke;
        private System.Windows.Forms.DateTimePicker dtpDatumPoslednjeIsporuke;
        private System.Windows.Forms.Label lblOdgovorniMagacioner;
        private System.Windows.Forms.ComboBox cmbOdgovorniMagacioner;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
