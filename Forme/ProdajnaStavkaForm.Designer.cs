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
            lblTitle = new Label();
            lblSubtitle = new Label();
            panelMain = new Panel();
            this.lblProdaja = new System.Windows.Forms.Label();
            this.txtProdaja = new System.Windows.Forms.TextBox();
            this.lblPakovanje = new System.Windows.Forms.Label();
            this.txtPakovanje = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.lblCena = new System.Windows.Forms.Label();
            this.numCena = new System.Windows.Forms.NumericUpDown();
            this.lblRecept = new System.Windows.Forms.Label();
            this.txtRecept = new System.Windows.Forms.TextBox();
            this.lblKontrolisanaKol = new System.Windows.Forms.Label();
            this.numKontrolisanaKol = new System.Windows.Forms.NumericUpDown();
            this.lblProcenatParticip = new System.Windows.Forms.Label();
            this.numProcenatParticip = new System.Windows.Forms.NumericUpDown();
            this.lblNeophodanIzvestaj = new System.Windows.Forms.Label();
            this.cboNeophodanIzvestaj = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            panelFooter = new Panel();
            lblFooter = new Label();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKontrolisanaKol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProcenatParticip)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(230, 126, 34);
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
            lblTitle.Size = new Size(380, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "💰 PRODAJNA STAVKA";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(255, 240, 200);
            lblSubtitle.Location = new Point(20, 60);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(320, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Dodavanje ili izmena stavke prodaje";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(this.btnCancel);
            panelMain.Controls.Add(this.btnSave);
            panelMain.Controls.Add(this.cboNeophodanIzvestaj);
            panelMain.Controls.Add(this.lblNeophodanIzvestaj);
            panelMain.Controls.Add(this.numProcenatParticip);
            panelMain.Controls.Add(this.lblProcenatParticip);
            panelMain.Controls.Add(this.numKontrolisanaKol);
            panelMain.Controls.Add(this.lblKontrolisanaKol);
            panelMain.Controls.Add(this.txtRecept);
            panelMain.Controls.Add(this.lblRecept);
            panelMain.Controls.Add(this.numCena);
            panelMain.Controls.Add(this.lblCena);
            panelMain.Controls.Add(this.numKolicina);
            panelMain.Controls.Add(this.lblKolicina);
            panelMain.Controls.Add(this.txtPakovanje);
            panelMain.Controls.Add(this.lblPakovanje);
            panelMain.Controls.Add(this.txtProdaja);
            panelMain.Controls.Add(this.lblProdaja);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 100);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(30);
            panelMain.Size = new Size(800, 450);
            panelMain.TabIndex = 1;
            // 
            // lblProdaja
            // 
            this.lblProdaja.AutoSize = true;
            this.lblProdaja.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblProdaja.ForeColor = Color.FromArgb(33, 37, 41);
            this.lblProdaja.Location = new Point(30, 30);
            this.lblProdaja.Name = "lblProdaja";
            this.lblProdaja.Size = new Size(69, 19);
            this.lblProdaja.TabIndex = 0;
            this.lblProdaja.Text = "Prodaja:";
            // 
            // txtProdaja
            // 
            this.txtProdaja.BackColor = Color.FromArgb(248, 249, 250);
            this.txtProdaja.BorderStyle = BorderStyle.FixedSingle;
            this.txtProdaja.Font = new Font("Segoe UI", 10F);
            this.txtProdaja.Location = new Point(250, 27);
            this.txtProdaja.Name = "txtProdaja";
            this.txtProdaja.ReadOnly = true;
            this.txtProdaja.Size = new Size(300, 25);
            this.txtProdaja.TabIndex = 1;
            this.txtProdaja.TabStop = false;
            // 
            // lblPakovanje
            // 
            this.lblPakovanje.AutoSize = true;
            this.lblPakovanje.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblPakovanje.ForeColor = Color.FromArgb(33, 37, 41);
            this.lblPakovanje.Location = new Point(30, 70);
            this.lblPakovanje.Name = "lblPakovanje";
            this.lblPakovanje.Size = new Size(93, 19);
            this.lblPakovanje.TabIndex = 2;
            this.lblPakovanje.Text = "Pakovanje:";
            // 
            // txtPakovanje
            // 
            this.txtPakovanje.BackColor = Color.FromArgb(248, 249, 250);
            this.txtPakovanje.BorderStyle = BorderStyle.FixedSingle;
            this.txtPakovanje.Font = new Font("Segoe UI", 10F);
            this.txtPakovanje.Location = new Point(250, 67);
            this.txtPakovanje.Name = "txtPakovanje";
            this.txtPakovanje.ReadOnly = true;
            this.txtPakovanje.Size = new Size(300, 25);
            this.txtPakovanje.TabIndex = 3;
            this.txtPakovanje.TabStop = false;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblKolicina.ForeColor = Color.FromArgb(33, 37, 41);
            this.lblKolicina.Location = new Point(30, 110);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new Size(73, 19);
            this.lblKolicina.TabIndex = 4;
            this.lblKolicina.Text = "Količina:";
            // 
            // numKolicina
            // 
            this.numKolicina.Font = new Font("Segoe UI", 10F);
            this.numKolicina.Location = new Point(250, 107);
            this.numKolicina.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new Size(300, 25);
            this.numKolicina.TabIndex = 5;
            this.numKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblCena.ForeColor = Color.FromArgb(33, 37, 41);
            this.lblCena.Location = new Point(30, 150);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new Size(53, 19);
            this.lblCena.TabIndex = 6;
            this.lblCena.Text = "Cena:";
            // 
            // numCena
            // 
            this.numCena.DecimalPlaces = 2;
            this.numCena.Font = new Font("Segoe UI", 10F);
            this.numCena.Location = new Point(250, 147);
            this.numCena.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCena.Name = "numCena";
            this.numCena.Size = new Size(300, 25);
            this.numCena.TabIndex = 7;
            // 
            // lblRecept
            // 
            this.lblRecept.AutoSize = true;
            this.lblRecept.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblRecept.ForeColor = Color.FromArgb(33, 37, 41);
            this.lblRecept.Location = new Point(30, 190);
            this.lblRecept.Name = "lblRecept";
            this.lblRecept.Size = new Size(66, 19);
            this.lblRecept.TabIndex = 8;
            this.lblRecept.Text = "Recept:";
            // 
            // txtRecept
            // 
            this.txtRecept.BackColor = Color.FromArgb(248, 249, 250);
            this.txtRecept.BorderStyle = BorderStyle.FixedSingle;
            this.txtRecept.Font = new Font("Segoe UI", 10F);
            this.txtRecept.Location = new Point(250, 187);
            this.txtRecept.Name = "txtRecept";
            this.txtRecept.ReadOnly = true;
            this.txtRecept.Size = new Size(300, 25);
            this.txtRecept.TabIndex = 9;
            this.txtRecept.TabStop = false;
            // 
            // lblKontrolisanaKol
            // 
            this.lblKontrolisanaKol.AutoSize = true;
            this.lblKontrolisanaKol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblKontrolisanaKol.ForeColor = Color.FromArgb(33, 37, 41);
            this.lblKontrolisanaKol.Location = new Point(30, 230);
            this.lblKontrolisanaKol.Name = "lblKontrolisanaKol";
            this.lblKontrolisanaKol.Size = new Size(133, 19);
            this.lblKontrolisanaKol.TabIndex = 10;
            this.lblKontrolisanaKol.Text = "Kontrolisana kol.:";
            // 
            // numKontrolisanaKol
            // 
            this.numKontrolisanaKol.Font = new Font("Segoe UI", 10F);
            this.numKontrolisanaKol.Location = new Point(250, 227);
            this.numKontrolisanaKol.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numKontrolisanaKol.Name = "numKontrolisanaKol";
            this.numKontrolisanaKol.Size = new Size(300, 25);
            this.numKontrolisanaKol.TabIndex = 11;
            // 
            // lblProcenatParticip
            // 
            this.lblProcenatParticip.AutoSize = true;
            this.lblProcenatParticip.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblProcenatParticip.ForeColor = Color.FromArgb(33, 37, 41);
            this.lblProcenatParticip.Location = new Point(30, 270);
            this.lblProcenatParticip.Name = "lblProcenatParticip";
            this.lblProcenatParticip.Size = new Size(146, 19);
            this.lblProcenatParticip.TabIndex = 12;
            this.lblProcenatParticip.Text = "Procenat particip.:";
            // 
            // numProcenatParticip
            // 
            this.numProcenatParticip.DecimalPlaces = 2;
            this.numProcenatParticip.Font = new Font("Segoe UI", 10F);
            this.numProcenatParticip.Location = new Point(250, 267);
            this.numProcenatParticip.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numProcenatParticip.Name = "numProcenatParticip";
            this.numProcenatParticip.Size = new Size(300, 25);
            this.numProcenatParticip.TabIndex = 13;
            // 
            // lblNeophodanIzvestaj
            // 
            this.lblNeophodanIzvestaj.AutoSize = true;
            this.lblNeophodanIzvestaj.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblNeophodanIzvestaj.ForeColor = Color.FromArgb(33, 37, 41);
            this.lblNeophodanIzvestaj.Location = new Point(30, 310);
            this.lblNeophodanIzvestaj.Name = "lblNeophodanIzvestaj";
            this.lblNeophodanIzvestaj.Size = new Size(146, 19);
            this.lblNeophodanIzvestaj.TabIndex = 14;
            this.lblNeophodanIzvestaj.Text = "Neophodan izveštaj:";
            // 
            // cboNeophodanIzvestaj
            // 
            this.cboNeophodanIzvestaj.BackColor = Color.White;
            this.cboNeophodanIzvestaj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNeophodanIzvestaj.Font = new Font("Segoe UI", 10F);
            this.cboNeophodanIzvestaj.FormattingEnabled = true;
            this.cboNeophodanIzvestaj.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cboNeophodanIzvestaj.Location = new Point(250, 307);
            this.cboNeophodanIzvestaj.Name = "cboNeophodanIzvestaj";
            this.cboNeophodanIzvestaj.Size = new Size(300, 25);
            this.cboNeophodanIzvestaj.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = Color.FromArgb(230, 126, 34);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnSave.ForeColor = Color.White;
            this.btnSave.Location = new Point(250, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new Size(140, 45);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "💾 Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += Button_MouseEnter;
            this.btnSave.MouseLeave += Button_MouseLeave;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnCancel.ForeColor = Color.White;
            this.btnCancel.Location = new Point(410, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(140, 45);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "❌ Otkaži";
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
            panelFooter.Location = new Point(0, 550);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(800, 40);
            panelFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 9F);
            lblFooter.ForeColor = Color.FromArgb(189, 195, 199);
            lblFooter.Location = new Point(30, 12);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(350, 15);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Prodajna stavka - Upravljanje podacima o stavkama prodaje";
            // 
            // ProdajnaStavkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(panelMain);
            this.Controls.Add(panelFooter);
            this.Controls.Add(panelHeader);
            this.Font = new Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProdajnaStavkaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmacy System - Prodajna Stavka";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKontrolisanaKol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProcenatParticip)).EndInit();
            this.ResumeLayout(false);
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
