namespace Farmacy.Forme
{
    partial class RasporedRadaForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.grpInputControls = new System.Windows.Forms.GroupBox();
            this.lblZaposleni = new System.Windows.Forms.Label();
            this.cmbZaposleni = new System.Windows.Forms.ComboBox();
            this.lblPocetak = new System.Windows.Forms.Label();
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            this.lblKraj = new System.Windows.Forms.Label();
            this.dtpKraj = new System.Windows.Forms.DateTimePicker();
            this.lblSmena = new System.Windows.Forms.Label();
            this.cmbSmena = new System.Windows.Forms.ComboBox();
            this.lblProdajnaJedinica = new System.Windows.Forms.Label();
            this.cmbProdajnaJedinica = new System.Windows.Forms.ComboBox();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnOsvezi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.grpRaspored = new System.Windows.Forms.GroupBox();
            this.dgvRaspored = new System.Windows.Forms.DataGridView();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.grpInputControls.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.grpRaspored.SuspendLayout();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📅 RASPORED RADA";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.lblSubtitle.Location = new System.Drawing.Point(20, 45);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(320, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Upravljanje rasporedom rada zaposlenih";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.panelMain.Controls.Add(this.grpRaspored);
            this.panelMain.Controls.Add(this.grpActions);
            this.panelMain.Controls.Add(this.grpInputControls);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 80);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(1000, 520);
            this.panelMain.TabIndex = 1;
            // 
            // grpInputControls
            // 
            this.grpInputControls.Controls.Add(this.btnFiltriraj);
            this.grpInputControls.Controls.Add(this.cmbProdajnaJedinica);
            this.grpInputControls.Controls.Add(this.lblProdajnaJedinica);
            this.grpInputControls.Controls.Add(this.cmbSmena);
            this.grpInputControls.Controls.Add(this.lblSmena);
            this.grpInputControls.Controls.Add(this.dtpKraj);
            this.grpInputControls.Controls.Add(this.lblKraj);
            this.grpInputControls.Controls.Add(this.dtpPocetak);
            this.grpInputControls.Controls.Add(this.lblPocetak);
            this.grpInputControls.Controls.Add(this.cmbZaposleni);
            this.grpInputControls.Controls.Add(this.lblZaposleni);
            this.grpInputControls.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpInputControls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grpInputControls.Location = new System.Drawing.Point(20, 20);
            this.grpInputControls.Name = "grpInputControls";
            this.grpInputControls.Padding = new System.Windows.Forms.Padding(20);
            this.grpInputControls.Size = new System.Drawing.Size(960, 180);
            this.grpInputControls.TabIndex = 0;
            this.grpInputControls.TabStop = false;
            this.grpInputControls.Text = "Unos podataka o rasporedu rada";
            // 
            // lblZaposleni
            // 
            this.lblZaposleni.AutoSize = true;
            this.lblZaposleni.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblZaposleni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblZaposleni.Location = new System.Drawing.Point(30, 30);
            this.lblZaposleni.Name = "lblZaposleni";
            this.lblZaposleni.Size = new System.Drawing.Size(74, 19);
            this.lblZaposleni.TabIndex = 0;
            this.lblZaposleni.Text = "Zaposleni:";
            // 
            // cmbZaposleni
            // 
            this.cmbZaposleni.BackColor = System.Drawing.Color.White;
            this.cmbZaposleni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZaposleni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbZaposleni.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbZaposleni.FormattingEnabled = true;
            this.cmbZaposleni.Location = new System.Drawing.Point(150, 27);
            this.cmbZaposleni.Name = "cmbZaposleni";
            this.cmbZaposleni.Size = new System.Drawing.Size(200, 25);
            this.cmbZaposleni.TabIndex = 1;
            // 
            // lblPocetak
            // 
            this.lblPocetak.AutoSize = true;
            this.lblPocetak.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPocetak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPocetak.Location = new System.Drawing.Point(30, 70);
            this.lblPocetak.Name = "lblPocetak";
            this.lblPocetak.Size = new System.Drawing.Size(62, 19);
            this.lblPocetak.TabIndex = 2;
            this.lblPocetak.Text = "Početak:";
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpPocetak.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpPocetak.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPocetak.Location = new System.Drawing.Point(150, 67);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.Size = new System.Drawing.Size(150, 26);
            this.dtpPocetak.TabIndex = 3;
            // 
            // lblKraj
            // 
            this.lblKraj.AutoSize = true;
            this.lblKraj.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKraj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblKraj.Location = new System.Drawing.Point(30, 110);
            this.lblKraj.Name = "lblKraj";
            this.lblKraj.Size = new System.Drawing.Size(37, 19);
            this.lblKraj.TabIndex = 4;
            this.lblKraj.Text = "Kraj:";
            // 
            // dtpKraj
            // 
            this.dtpKraj.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpKraj.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpKraj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKraj.Location = new System.Drawing.Point(150, 107);
            this.dtpKraj.Name = "dtpKraj";
            this.dtpKraj.Size = new System.Drawing.Size(150, 26);
            this.dtpKraj.TabIndex = 5;
            // 
            // lblSmena
            // 
            this.lblSmena.AutoSize = true;
            this.lblSmena.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSmena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSmena.Location = new System.Drawing.Point(400, 30);
            this.lblSmena.Name = "lblSmena";
            this.lblSmena.Size = new System.Drawing.Size(56, 19);
            this.lblSmena.TabIndex = 6;
            this.lblSmena.Text = "Smena:";
            // 
            // cmbSmena
            // 
            this.cmbSmena.BackColor = System.Drawing.Color.White;
            this.cmbSmena.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSmena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSmena.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSmena.FormattingEnabled = true;
            this.cmbSmena.Items.AddRange(new object[] {
            "Prva smena",
            "Druga smena",
            "Treća smena"});
            this.cmbSmena.Location = new System.Drawing.Point(500, 27);
            this.cmbSmena.Name = "cmbSmena";
            this.cmbSmena.Size = new System.Drawing.Size(150, 25);
            this.cmbSmena.TabIndex = 7;
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.btnZatvori);
            this.grpActions.Controls.Add(this.btnOsvezi);
            this.grpActions.Controls.Add(this.btnObrisi);
            this.grpActions.Controls.Add(this.btnDodaj);
            this.grpActions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grpActions.Location = new System.Drawing.Point(20, 220);
            this.grpActions.Name = "grpActions";
            this.grpActions.Padding = new System.Windows.Forms.Padding(20);
            this.grpActions.Size = new System.Drawing.Size(960, 80);
            this.grpActions.TabIndex = 1;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Akcije";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(30, 30);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(120, 35);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "➕ Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnObrisi.FlatAppearance.BorderSize = 0;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnObrisi.ForeColor = System.Drawing.Color.White;
            this.btnObrisi.Location = new System.Drawing.Point(170, 30);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(120, 35);
            this.btnObrisi.TabIndex = 9;
            this.btnObrisi.Text = "🗑️ Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnOsvezi.FlatAppearance.BorderSize = 0;
            this.btnOsvezi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOsvezi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOsvezi.ForeColor = System.Drawing.Color.White;
            this.btnOsvezi.Location = new System.Drawing.Point(310, 30);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(120, 35);
            this.btnOsvezi.TabIndex = 10;
            this.btnOsvezi.Text = "🔄 Osveži";
            this.btnOsvezi.UseVisualStyleBackColor = false;
            this.btnOsvezi.Click += new System.EventHandler(this.btnOsvezi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnZatvori.FlatAppearance.BorderSize = 0;
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvori.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnZatvori.ForeColor = System.Drawing.Color.White;
            this.btnZatvori.Location = new System.Drawing.Point(450, 30);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(120, 35);
            this.btnZatvori.TabIndex = 11;
            this.btnZatvori.Text = "❌ Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // grpRaspored
            // 
            this.grpRaspored.Controls.Add(this.dgvRaspored);
            this.grpRaspored.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRaspored.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpRaspored.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grpRaspored.Location = new System.Drawing.Point(20, 320);
            this.grpRaspored.Name = "grpRaspored";
            this.grpRaspored.Padding = new System.Windows.Forms.Padding(20);
            this.grpRaspored.Size = new System.Drawing.Size(960, 180);
            this.grpRaspored.TabIndex = 2;
            this.grpRaspored.TabStop = false;
            this.grpRaspored.Text = "Raspored rada";
            // 
            // dgvRaspored
            // 
            this.dgvRaspored.AllowUserToAddRows = false;
            this.dgvRaspored.AllowUserToDeleteRows = false;
            this.dgvRaspored.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRaspored.BackgroundColor = System.Drawing.Color.White;
            this.dgvRaspored.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRaspored.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRaspored.ColumnHeadersHeight = 50;
            this.dgvRaspored.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRaspored.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRaspored.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.dgvRaspored.Location = new System.Drawing.Point(20, 22);
            this.dgvRaspored.Name = "dgvRaspored";
            this.dgvRaspored.ReadOnly = true;
            this.dgvRaspored.RowHeadersVisible = false;
            this.dgvRaspored.RowTemplate.Height = 35;
            this.dgvRaspored.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRaspored.Size = new System.Drawing.Size(920, 138);
            this.dgvRaspored.TabIndex = 12;
            // 
            // lblProdajnaJedinica
            // 
            this.lblProdajnaJedinica.AutoSize = true;
            this.lblProdajnaJedinica.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProdajnaJedinica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblProdajnaJedinica.Location = new System.Drawing.Point(400, 70);
            this.lblProdajnaJedinica.Name = "lblProdajnaJedinica";
            this.lblProdajnaJedinica.Size = new System.Drawing.Size(123, 19);
            this.lblProdajnaJedinica.TabIndex = 14;
            this.lblProdajnaJedinica.Text = "Prodajna jedinica:";
            // 
            // cmbProdajnaJedinica
            // 
            this.cmbProdajnaJedinica.BackColor = System.Drawing.Color.White;
            this.cmbProdajnaJedinica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdajnaJedinica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProdajnaJedinica.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbProdajnaJedinica.FormattingEnabled = true;
            this.cmbProdajnaJedinica.Location = new System.Drawing.Point(500, 67);
            this.cmbProdajnaJedinica.Name = "cmbProdajnaJedinica";
            this.cmbProdajnaJedinica.Size = new System.Drawing.Size(200, 25);
            this.cmbProdajnaJedinica.TabIndex = 15;
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnFiltriraj.FlatAppearance.BorderSize = 0;
            this.btnFiltriraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltriraj.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFiltriraj.ForeColor = System.Drawing.Color.White;
            this.btnFiltriraj.Location = new System.Drawing.Point(500, 110);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(120, 35);
            this.btnFiltriraj.TabIndex = 16;
            this.btnFiltriraj.Text = "🔍 Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = false;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelFooter.Controls.Add(this.lblFooter);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 600);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1000, 30);
            this.panelFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblFooter.Location = new System.Drawing.Point(20, 8);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(210, 13);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "Sistem za upravljanje farmaceutskim podacima";
            // 
            // RasporedRadaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RasporedRadaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raspored rada - Upravljanje rasporedom rada zaposlenih";
            this.Load += new System.EventHandler(this.RasporedRadaForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.grpInputControls.ResumeLayout(false);
            this.grpInputControls.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpRaspored.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.GroupBox grpInputControls;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.GroupBox grpRaspored;
        private System.Windows.Forms.Label lblZaposleni;
        private System.Windows.Forms.ComboBox cmbZaposleni;
        private System.Windows.Forms.Label lblPocetak;
        private System.Windows.Forms.DateTimePicker dtpPocetak;
        private System.Windows.Forms.Label lblKraj;
        private System.Windows.Forms.DateTimePicker dtpKraj;
        private System.Windows.Forms.Label lblSmena;
        private System.Windows.Forms.ComboBox cmbSmena;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnOsvezi;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.DataGridView dgvRaspored;
        private System.Windows.Forms.Label lblProdajnaJedinica;
        private System.Windows.Forms.ComboBox cmbProdajnaJedinica;
        private System.Windows.Forms.Button btnFiltriraj;
    }
}
