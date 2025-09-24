namespace Farmacy.Forme
{
    partial class LekForm
    {
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
            lblId = new Label();
            lblHemijski = new Label();
            lblKomercijalni = new Label();
            lblDejstvo = new Label();
            lblProizvodjac = new Label();
            lblPrimarnaGrupa = new Label();
            lblSekundarneKategorije = new Label();
            txtId = new TextBox();
            txtHemijski = new TextBox();
            txtKomercijalni = new TextBox();
            txtDejstvo = new TextBox();
            cmbProizvodjac = new ComboBox();
            cmbPrimarnaGrupa = new ComboBox();
            chkListSekundarneKategorije = new CheckedListBox();
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
            panelHeader.BackColor = Color.FromArgb(155, 89, 182);
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
            lblTitle.Size = new Size(200, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "💊 NOVI LEK";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(200, 180, 220);
            lblSubtitle.Location = new Point(20, 60);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(300, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Dodavanje novog leka u sistem";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(chkListSekundarneKategorije);
            panelMain.Controls.Add(cmbPrimarnaGrupa);
            panelMain.Controls.Add(cmbProizvodjac);
            panelMain.Controls.Add(txtDejstvo);
            panelMain.Controls.Add(txtKomercijalni);
            panelMain.Controls.Add(txtHemijski);
            panelMain.Controls.Add(txtId);
            panelMain.Controls.Add(lblSekundarneKategorije);
            panelMain.Controls.Add(lblPrimarnaGrupa);
            panelMain.Controls.Add(lblProizvodjac);
            panelMain.Controls.Add(lblDejstvo);
            panelMain.Controls.Add(lblKomercijalni);
            panelMain.Controls.Add(lblHemijski);
            panelMain.Controls.Add(lblId);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 100);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(800, 400);
            panelMain.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblId.ForeColor = Color.FromArgb(33, 37, 41);
            lblId.Location = new Point(20, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblHemijski
            // 
            lblHemijski.AutoSize = true;
            lblHemijski.Location = new Point(20, 52);
            lblHemijski.Name = "lblHemijski";
            lblHemijski.Size = new Size(86, 15);
            lblHemijski.TabIndex = 2;
            lblHemijski.Text = "Hemijski naziv:";
            // 
            // lblKomercijalni
            // 
            lblKomercijalni.AutoSize = true;
            lblKomercijalni.Location = new Point(20, 84);
            lblKomercijalni.Name = "lblKomercijalni";
            lblKomercijalni.Size = new Size(106, 15);
            lblKomercijalni.TabIndex = 4;
            lblKomercijalni.Text = "Komercijalni naziv:";
            // 
            // lblDejstvo
            // 
            lblDejstvo.AutoSize = true;
            lblDejstvo.Location = new Point(20, 116);
            lblDejstvo.Name = "lblDejstvo";
            lblDejstvo.Size = new Size(49, 15);
            lblDejstvo.TabIndex = 6;
            lblDejstvo.Text = "Dejstvo:";
            // 
            // lblProizvodjac
            // 
            lblProizvodjac.AutoSize = true;
            lblProizvodjac.Location = new Point(20, 148);
            lblProizvodjac.Name = "lblProizvodjac";
            lblProizvodjac.Size = new Size(68, 15);
            lblProizvodjac.TabIndex = 8;
            lblProizvodjac.Text = "Proizvođač:";
            // 
            // lblPrimarnaGrupa
            // 
            lblPrimarnaGrupa.AutoSize = true;
            lblPrimarnaGrupa.Location = new Point(20, 180);
            lblPrimarnaGrupa.Name = "lblPrimarnaGrupa";
            lblPrimarnaGrupa.Size = new Size(92, 15);
            lblPrimarnaGrupa.TabIndex = 10;
            lblPrimarnaGrupa.Text = "Primarna grupa:";
            // 
            // lblSekundarneKategorije
            // 
            lblSekundarneKategorije.AutoSize = true;
            lblSekundarneKategorije.Location = new Point(20, 212);
            lblSekundarneKategorije.Name = "lblSekundarneKategorije";
            lblSekundarneKategorije.Size = new Size(120, 15);
            lblSekundarneKategorije.TabIndex = 12;
            lblSekundarneKategorije.Text = "Sekundarne kategorije:";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLight;
            txtId.Location = new Point(160, 17);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(240, 23);
            txtId.TabIndex = 1;
            txtId.TabStop = false;
            // 
            // txtHemijski
            // 
            txtHemijski.Location = new Point(160, 49);
            txtHemijski.Name = "txtHemijski";
            txtHemijski.Size = new Size(240, 23);
            txtHemijski.TabIndex = 3;
            // 
            // txtKomercijalni
            // 
            txtKomercijalni.Location = new Point(160, 81);
            txtKomercijalni.Name = "txtKomercijalni";
            txtKomercijalni.Size = new Size(240, 23);
            txtKomercijalni.TabIndex = 5;
            // 
            // txtDejstvo
            // 
            txtDejstvo.Location = new Point(160, 113);
            txtDejstvo.Name = "txtDejstvo";
            txtDejstvo.Size = new Size(240, 23);
            txtDejstvo.TabIndex = 7;
            // 
            // cmbProizvodjac
            // 
            cmbProizvodjac.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProizvodjac.FormattingEnabled = true;
            cmbProizvodjac.Location = new Point(160, 145);
            cmbProizvodjac.Name = "cmbProizvodjac";
            cmbProizvodjac.Size = new Size(240, 23);
            cmbProizvodjac.TabIndex = 9;
            cmbProizvodjac.SelectedIndexChanged += cmbProizvodjac_SelectedIndexChanged;
            // 
            // cmbPrimarnaGrupa
            // 
            cmbPrimarnaGrupa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPrimarnaGrupa.FormattingEnabled = true;
            cmbPrimarnaGrupa.Location = new Point(160, 177);
            cmbPrimarnaGrupa.Name = "cmbPrimarnaGrupa";
            cmbPrimarnaGrupa.Size = new Size(240, 23);
            cmbPrimarnaGrupa.TabIndex = 11;
            cmbPrimarnaGrupa.SelectedIndexChanged += cmbPrimarnaGrupa_SelectedIndexChanged;
            // 
            // chkListSekundarneKategorije
            // 
            chkListSekundarneKategorije.CheckOnClick = true;
            chkListSekundarneKategorije.FormattingEnabled = true;
            chkListSekundarneKategorije.Location = new Point(160, 209);
            chkListSekundarneKategorije.Name = "chkListSekundarneKategorije";
            chkListSekundarneKategorije.Size = new Size(240, 100);
            chkListSekundarneKategorije.TabIndex = 13;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(255, 255, 255);
            panelButtons.Controls.Add(btnOtkazi);
            panelButtons.Controls.Add(btnSacuvaj);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 500);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(20);
            panelButtons.Size = new Size(800, 80);
            panelButtons.TabIndex = 2;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.BackColor = Color.FromArgb(80, 220, 140);
            btnSacuvaj.FlatAppearance.BorderSize = 0;
            btnSacuvaj.FlatStyle = FlatStyle.Flat;
            btnSacuvaj.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSacuvaj.ForeColor = Color.White;
            btnSacuvaj.Location = new Point(20, 20);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(120, 40);
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
            btnOtkazi.Location = new Point(160, 20);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(120, 40);
            btnOtkazi.TabIndex = 1;
            btnOtkazi.Text = "❌ Otkaži";
            btnOtkazi.TextAlign = ContentAlignment.MiddleCenter;
            btnOtkazi.UseVisualStyleBackColor = false;
            btnOtkazi.MouseEnter += Button_MouseEnter;
            btnOtkazi.MouseLeave += Button_MouseLeave;
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
            lblFooter.Size = new Size(200, 13);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Lekovi - Dodavanje novog leka u sistem";
            // 
            // LekForm
            // 
            AcceptButton = btnSacuvaj;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnOtkazi;
            ClientSize = new Size(800, 610);
            Controls.Add(panelMain);
            Controls.Add(panelButtons);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LekForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Farmacy System - Novi Lek";
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



        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblHemijski;
        private System.Windows.Forms.Label lblKomercijalni;
        private System.Windows.Forms.Label lblDejstvo;
        private System.Windows.Forms.Label lblProizvodjac;
        private System.Windows.Forms.Label lblPrimarnaGrupa;
        private System.Windows.Forms.Label lblSekundarneKategorije;

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtHemijski;
        private System.Windows.Forms.TextBox txtKomercijalni;
        private System.Windows.Forms.TextBox txtDejstvo;
        private System.Windows.Forms.ComboBox cmbProizvodjac;

        private System.Windows.Forms.ComboBox cmbPrimarnaGrupa;
        private System.Windows.Forms.CheckedListBox chkListSekundarneKategorije;

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnOtkazi;


    }
}
