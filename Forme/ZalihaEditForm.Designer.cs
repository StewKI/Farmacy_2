namespace Farmacy.Forme
{
    partial class ZalihaEditForm
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
            txtOdgovorniMagacioner = new TextBox();
            lblOdgovorniMagacioner = new Label();
            dtpDatumPoslednjeIsporuke = new DateTimePicker();
            lblDatumPoslednjeIsporuke = new Label();
            numKolicina = new NumericUpDown();
            lblKolicina = new Label();
            txtPakovanje = new TextBox();
            lblPakovanje = new Label();
            txtProdajnaJedinica = new TextBox();
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
            panelHeader.Size = new Size(856, 87);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(425, 59);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "✏️ IZMENA ZALIHE";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(189, 195, 199);
            lblSubtitle.Location = new Point(410, 47);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(443, 37);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Izmena postojećih podataka o zalihi";
            lblSubtitle.Click += lblSubtitle_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(btnCancel);
            panelMain.Controls.Add(btnSave);
            panelMain.Controls.Add(txtOdgovorniMagacioner);
            panelMain.Controls.Add(lblOdgovorniMagacioner);
            panelMain.Controls.Add(dtpDatumPoslednjeIsporuke);
            panelMain.Controls.Add(lblDatumPoslednjeIsporuke);
            panelMain.Controls.Add(numKolicina);
            panelMain.Controls.Add(lblKolicina);
            panelMain.Controls.Add(txtPakovanje);
            panelMain.Controls.Add(lblPakovanje);
            panelMain.Controls.Add(txtProdajnaJedinica);
            panelMain.Controls.Add(lblProdajnaJedinica);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 87);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(856, 433);
            panelMain.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(350, 300);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 58);
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
            btnSave.Location = new Point(200, 300);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 58);
            btnSave.TabIndex = 10;
            btnSave.Text = "💾 Sačuvaj";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtOdgovorniMagacioner
            // 
            txtOdgovorniMagacioner.BackColor = Color.White;
            txtOdgovorniMagacioner.BorderStyle = BorderStyle.FixedSingle;
            txtOdgovorniMagacioner.Font = new Font("Segoe UI", 10F);
            txtOdgovorniMagacioner.Location = new Point(540, 224);
            txtOdgovorniMagacioner.Name = "txtOdgovorniMagacioner";
            txtOdgovorniMagacioner.ReadOnly = true;
            txtOdgovorniMagacioner.Size = new Size(200, 43);
            txtOdgovorniMagacioner.TabIndex = 9;
            // 
            // lblOdgovorniMagacioner
            // 
            lblOdgovorniMagacioner.AutoSize = true;
            lblOdgovorniMagacioner.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOdgovorniMagacioner.ForeColor = Color.FromArgb(44, 62, 80);
            lblOdgovorniMagacioner.Location = new Point(50, 230);
            lblOdgovorniMagacioner.Name = "lblOdgovorniMagacioner";
            lblOdgovorniMagacioner.Size = new Size(322, 37);
            lblOdgovorniMagacioner.TabIndex = 8;
            lblOdgovorniMagacioner.Text = "Odgovorni magacioner:";
            // 
            // dtpDatumPoslednjeIsporuke
            // 
            dtpDatumPoslednjeIsporuke.Font = new Font("Segoe UI", 10F);
            dtpDatumPoslednjeIsporuke.Format = DateTimePickerFormat.Short;
            dtpDatumPoslednjeIsporuke.Location = new Point(540, 174);
            dtpDatumPoslednjeIsporuke.Name = "dtpDatumPoslednjeIsporuke";
            dtpDatumPoslednjeIsporuke.Size = new Size(150, 43);
            dtpDatumPoslednjeIsporuke.TabIndex = 7;
            // 
            // lblDatumPoslednjeIsporuke
            // 
            lblDatumPoslednjeIsporuke.AutoSize = true;
            lblDatumPoslednjeIsporuke.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDatumPoslednjeIsporuke.ForeColor = Color.FromArgb(44, 62, 80);
            lblDatumPoslednjeIsporuke.Location = new Point(50, 180);
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
            numKolicina.Location = new Point(540, 124);
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
            lblKolicina.Location = new Point(50, 130);
            lblKolicina.Name = "lblKolicina";
            lblKolicina.Size = new Size(127, 37);
            lblKolicina.TabIndex = 4;
            lblKolicina.Text = "Količina:";
            // 
            // txtPakovanje
            // 
            txtPakovanje.BackColor = Color.White;
            txtPakovanje.BorderStyle = BorderStyle.FixedSingle;
            txtPakovanje.Font = new Font("Segoe UI", 10F);
            txtPakovanje.Location = new Point(540, 74);
            txtPakovanje.Name = "txtPakovanje";
            txtPakovanje.ReadOnly = true;
            txtPakovanje.Size = new Size(300, 43);
            txtPakovanje.TabIndex = 3;
            // 
            // lblPakovanje
            // 
            lblPakovanje.AutoSize = true;
            lblPakovanje.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPakovanje.ForeColor = Color.FromArgb(44, 62, 80);
            lblPakovanje.Location = new Point(50, 80);
            lblPakovanje.Name = "lblPakovanje";
            lblPakovanje.Size = new Size(156, 37);
            lblPakovanje.TabIndex = 2;
            lblPakovanje.Text = "Pakovanje:";
            // 
            // txtProdajnaJedinica
            // 
            txtProdajnaJedinica.BackColor = Color.White;
            txtProdajnaJedinica.BorderStyle = BorderStyle.FixedSingle;
            txtProdajnaJedinica.Font = new Font("Segoe UI", 10F);
            txtProdajnaJedinica.Location = new Point(540, 23);
            txtProdajnaJedinica.Name = "txtProdajnaJedinica";
            txtProdajnaJedinica.ReadOnly = true;
            txtProdajnaJedinica.Size = new Size(300, 43);
            txtProdajnaJedinica.TabIndex = 1;
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
            panelFooter.Location = new Point(0, 520);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(856, 49);
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
            // ZalihaEditForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(856, 569);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Controls.Add(panelFooter);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ZalihaEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zaliha - Izmena";
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
        private System.Windows.Forms.TextBox txtProdajnaJedinica;
        private System.Windows.Forms.Label lblPakovanje;
        private System.Windows.Forms.TextBox txtPakovanje;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.Label lblDatumPoslednjeIsporuke;
        private System.Windows.Forms.DateTimePicker dtpDatumPoslednjeIsporuke;
        private System.Windows.Forms.Label lblOdgovorniMagacioner;
        private System.Windows.Forms.TextBox txtOdgovorniMagacioner;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
