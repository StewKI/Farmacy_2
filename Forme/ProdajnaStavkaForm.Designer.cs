namespace Farmacy.Forme
{
    partial class ProdajnaStavkaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Header panel and labels
        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelMain;
        private Panel panelFooter;
        private Label lblFooter;

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
            lblSubtitle = new Label();
            lblTitle = new Label();
            panelMain = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            cboNeophodanIzvestaj = new ComboBox();
            lblNeophodanIzvestaj = new Label();
            numProcenatParticip = new NumericUpDown();
            lblProcenatParticip = new Label();
            numKontrolisanaKol = new NumericUpDown();
            lblKontrolisanaKol = new Label();
            txtRecept = new TextBox();
            lblRecept = new Label();
            numCena = new NumericUpDown();
            lblCena = new Label();
            numKolicina = new NumericUpDown();
            lblKolicina = new Label();
            txtPakovanje = new TextBox();
            lblPakovanje = new Label();
            txtProdaja = new TextBox();
            lblProdaja = new Label();
            panelFooter = new Panel();
            lblFooter = new Label();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numProcenatParticip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numKontrolisanaKol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCena).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numKolicina).BeginInit();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(230, 126, 34);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(5, 5, 5, 5);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1300, 160);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(255, 240, 200);
            lblSubtitle.Location = new Point(32, 96);
            lblSubtitle.Margin = new Padding(5, 0, 5, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(445, 37);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Dodavanje ili izmena stavke prodaje";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(32, 9);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(617, 72);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "💰 PRODAJNA STAVKA";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(btnCancel);
            panelMain.Controls.Add(btnSave);
            panelMain.Controls.Add(cboNeophodanIzvestaj);
            panelMain.Controls.Add(lblNeophodanIzvestaj);
            panelMain.Controls.Add(numProcenatParticip);
            panelMain.Controls.Add(lblProcenatParticip);
            panelMain.Controls.Add(numKontrolisanaKol);
            panelMain.Controls.Add(lblKontrolisanaKol);
            panelMain.Controls.Add(txtRecept);
            panelMain.Controls.Add(lblRecept);
            panelMain.Controls.Add(numCena);
            panelMain.Controls.Add(lblCena);
            panelMain.Controls.Add(numKolicina);
            panelMain.Controls.Add(lblKolicina);
            panelMain.Controls.Add(txtPakovanje);
            panelMain.Controls.Add(lblPakovanje);
            panelMain.Controls.Add(txtProdaja);
            panelMain.Controls.Add(lblProdaja);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 160);
            panelMain.Margin = new Padding(5, 5, 5, 5);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(49, 48, 49, 48);
            panelMain.Size = new Size(1300, 720);
            panelMain.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(666, 592);
            btnCancel.Margin = new Padding(5, 5, 5, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(228, 72);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "❌ Otkaži";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            btnCancel.MouseEnter += Button_MouseEnter;
            btnCancel.MouseLeave += Button_MouseLeave;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(230, 126, 34);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(406, 592);
            btnSave.Margin = new Padding(5, 5, 5, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(228, 72);
            btnSave.TabIndex = 16;
            btnSave.Text = "💾 Sačuvaj";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            btnSave.MouseEnter += Button_MouseEnter;
            btnSave.MouseLeave += Button_MouseLeave;
            // 
            // cboNeophodanIzvestaj
            // 
            cboNeophodanIzvestaj.BackColor = Color.White;
            cboNeophodanIzvestaj.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNeophodanIzvestaj.Font = new Font("Segoe UI", 10F);
            cboNeophodanIzvestaj.FormattingEnabled = true;
            cboNeophodanIzvestaj.Items.AddRange(new object[] { "Y", "N" });
            cboNeophodanIzvestaj.Location = new Point(406, 491);
            cboNeophodanIzvestaj.Margin = new Padding(5, 5, 5, 5);
            cboNeophodanIzvestaj.Name = "cboNeophodanIzvestaj";
            cboNeophodanIzvestaj.Size = new Size(485, 45);
            cboNeophodanIzvestaj.TabIndex = 15;
            // 
            // lblNeophodanIzvestaj
            // 
            lblNeophodanIzvestaj.AutoSize = true;
            lblNeophodanIzvestaj.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNeophodanIzvestaj.ForeColor = Color.FromArgb(33, 37, 41);
            lblNeophodanIzvestaj.Location = new Point(49, 496);
            lblNeophodanIzvestaj.Margin = new Padding(5, 0, 5, 0);
            lblNeophodanIzvestaj.Name = "lblNeophodanIzvestaj";
            lblNeophodanIzvestaj.Size = new Size(279, 37);
            lblNeophodanIzvestaj.TabIndex = 14;
            lblNeophodanIzvestaj.Text = "Neophodan izveštaj:";
            // 
            // numProcenatParticip
            // 
            numProcenatParticip.DecimalPlaces = 2;
            numProcenatParticip.Font = new Font("Segoe UI", 10F);
            numProcenatParticip.Location = new Point(406, 427);
            numProcenatParticip.Margin = new Padding(5, 5, 5, 5);
            numProcenatParticip.Name = "numProcenatParticip";
            numProcenatParticip.Size = new Size(488, 43);
            numProcenatParticip.TabIndex = 13;
            // 
            // lblProcenatParticip
            // 
            lblProcenatParticip.AutoSize = true;
            lblProcenatParticip.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProcenatParticip.ForeColor = Color.FromArgb(33, 37, 41);
            lblProcenatParticip.Location = new Point(49, 432);
            lblProcenatParticip.Margin = new Padding(5, 0, 5, 0);
            lblProcenatParticip.Name = "lblProcenatParticip";
            lblProcenatParticip.Size = new Size(254, 37);
            lblProcenatParticip.TabIndex = 12;
            lblProcenatParticip.Text = "Procenat particip.:";
            // 
            // numKontrolisanaKol
            // 
            numKontrolisanaKol.Font = new Font("Segoe UI", 10F);
            numKontrolisanaKol.Location = new Point(406, 363);
            numKontrolisanaKol.Margin = new Padding(5, 5, 5, 5);
            numKontrolisanaKol.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numKontrolisanaKol.Name = "numKontrolisanaKol";
            numKontrolisanaKol.Size = new Size(488, 43);
            numKontrolisanaKol.TabIndex = 11;
            // 
            // lblKontrolisanaKol
            // 
            lblKontrolisanaKol.AutoSize = true;
            lblKontrolisanaKol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblKontrolisanaKol.ForeColor = Color.FromArgb(33, 37, 41);
            lblKontrolisanaKol.Location = new Point(49, 368);
            lblKontrolisanaKol.Margin = new Padding(5, 0, 5, 0);
            lblKontrolisanaKol.Name = "lblKontrolisanaKol";
            lblKontrolisanaKol.Size = new Size(242, 37);
            lblKontrolisanaKol.TabIndex = 10;
            lblKontrolisanaKol.Text = "Kontrolisana kol.:";
            // 
            // txtRecept
            // 
            txtRecept.BackColor = Color.FromArgb(248, 249, 250);
            txtRecept.BorderStyle = BorderStyle.FixedSingle;
            txtRecept.Font = new Font("Segoe UI", 10F);
            txtRecept.Location = new Point(406, 299);
            txtRecept.Margin = new Padding(5, 5, 5, 5);
            txtRecept.Name = "txtRecept";
            txtRecept.ReadOnly = true;
            txtRecept.Size = new Size(486, 43);
            txtRecept.TabIndex = 9;
            txtRecept.TabStop = false;
            // 
            // lblRecept
            // 
            lblRecept.AutoSize = true;
            lblRecept.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRecept.ForeColor = Color.FromArgb(33, 37, 41);
            lblRecept.Location = new Point(49, 304);
            lblRecept.Margin = new Padding(5, 0, 5, 0);
            lblRecept.Name = "lblRecept";
            lblRecept.Size = new Size(112, 37);
            lblRecept.TabIndex = 8;
            lblRecept.Text = "Recept:";
            // 
            // numCena
            // 
            numCena.DecimalPlaces = 2;
            numCena.Font = new Font("Segoe UI", 10F);
            numCena.Location = new Point(406, 235);
            numCena.Margin = new Padding(5, 5, 5, 5);
            numCena.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numCena.Name = "numCena";
            numCena.Size = new Size(488, 43);
            numCena.TabIndex = 7;
            // 
            // lblCena
            // 
            lblCena.AutoSize = true;
            lblCena.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCena.ForeColor = Color.FromArgb(33, 37, 41);
            lblCena.Location = new Point(49, 240);
            lblCena.Margin = new Padding(5, 0, 5, 0);
            lblCena.Name = "lblCena";
            lblCena.Size = new Size(87, 37);
            lblCena.TabIndex = 6;
            lblCena.Text = "Cena:";
            // 
            // numKolicina
            // 
            numKolicina.Font = new Font("Segoe UI", 10F);
            numKolicina.Location = new Point(406, 171);
            numKolicina.Margin = new Padding(5, 5, 5, 5);
            numKolicina.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numKolicina.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numKolicina.Name = "numKolicina";
            numKolicina.Size = new Size(488, 43);
            numKolicina.TabIndex = 5;
            numKolicina.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblKolicina
            // 
            lblKolicina.AutoSize = true;
            lblKolicina.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblKolicina.ForeColor = Color.FromArgb(33, 37, 41);
            lblKolicina.Location = new Point(49, 176);
            lblKolicina.Margin = new Padding(5, 0, 5, 0);
            lblKolicina.Name = "lblKolicina";
            lblKolicina.Size = new Size(127, 37);
            lblKolicina.TabIndex = 4;
            lblKolicina.Text = "Količina:";
            // 
            // txtPakovanje
            // 
            txtPakovanje.BackColor = Color.FromArgb(248, 249, 250);
            txtPakovanje.BorderStyle = BorderStyle.FixedSingle;
            txtPakovanje.Font = new Font("Segoe UI", 10F);
            txtPakovanje.Location = new Point(406, 107);
            txtPakovanje.Margin = new Padding(5, 5, 5, 5);
            txtPakovanje.Name = "txtPakovanje";
            txtPakovanje.ReadOnly = true;
            txtPakovanje.Size = new Size(486, 43);
            txtPakovanje.TabIndex = 3;
            txtPakovanje.TabStop = false;
            // 
            // lblPakovanje
            // 
            lblPakovanje.AutoSize = true;
            lblPakovanje.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPakovanje.ForeColor = Color.FromArgb(33, 37, 41);
            lblPakovanje.Location = new Point(49, 112);
            lblPakovanje.Margin = new Padding(5, 0, 5, 0);
            lblPakovanje.Name = "lblPakovanje";
            lblPakovanje.Size = new Size(156, 37);
            lblPakovanje.TabIndex = 2;
            lblPakovanje.Text = "Pakovanje:";
            // 
            // txtProdaja
            // 
            txtProdaja.BackColor = Color.FromArgb(248, 249, 250);
            txtProdaja.BorderStyle = BorderStyle.FixedSingle;
            txtProdaja.Font = new Font("Segoe UI", 10F);
            txtProdaja.Location = new Point(406, 43);
            txtProdaja.Margin = new Padding(5, 5, 5, 5);
            txtProdaja.Name = "txtProdaja";
            txtProdaja.ReadOnly = true;
            txtProdaja.Size = new Size(486, 43);
            txtProdaja.TabIndex = 1;
            txtProdaja.TabStop = false;
            // 
            // lblProdaja
            // 
            lblProdaja.AutoSize = true;
            lblProdaja.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProdaja.ForeColor = Color.FromArgb(33, 37, 41);
            lblProdaja.Location = new Point(49, 48);
            lblProdaja.Margin = new Padding(5, 0, 5, 0);
            lblProdaja.Name = "lblProdaja";
            lblProdaja.Size = new Size(124, 37);
            lblProdaja.TabIndex = 0;
            lblProdaja.Text = "Prodaja:";
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(44, 62, 80);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 880);
            panelFooter.Margin = new Padding(5, 5, 5, 5);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1300, 64);
            panelFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 9F);
            lblFooter.ForeColor = Color.FromArgb(189, 195, 199);
            lblFooter.Location = new Point(49, 19);
            lblFooter.Margin = new Padding(5, 0, 5, 0);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(649, 32);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Prodajna stavka - Upravljanje podacima o stavkama prodaje";
            // 
            // ProdajnaStavkaForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 944);
            Controls.Add(panelMain);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 5, 5, 5);
            MaximizeBox = false;
            Name = "ProdajnaStavkaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farmacy System - Prodajna Stavka";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numProcenatParticip).EndInit();
            ((System.ComponentModel.ISupportInitialize)numKontrolisanaKol).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCena).EndInit();
            ((System.ComponentModel.ISupportInitialize)numKolicina).EndInit();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblProdaja;
        private System.Windows.Forms.TextBox txtProdaja;
        private System.Windows.Forms.Label lblPakovanje;
        private System.Windows.Forms.TextBox txtPakovanje;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.NumericUpDown numCena;
        private System.Windows.Forms.Label lblRecept;
        private System.Windows.Forms.TextBox txtRecept;
        private System.Windows.Forms.Label lblKontrolisanaKol;
        private System.Windows.Forms.NumericUpDown numKontrolisanaKol;
        private System.Windows.Forms.Label lblProcenatParticip;
        private System.Windows.Forms.NumericUpDown numProcenatParticip;
        private System.Windows.Forms.Label lblNeophodanIzvestaj;
        private System.Windows.Forms.ComboBox cboNeophodanIzvestaj;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
