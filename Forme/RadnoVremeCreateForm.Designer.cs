namespace Farmacy.Forme
{
    partial class RadnoVremeCreateForm
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
            this.grpPodaci = new System.Windows.Forms.GroupBox();
            this.lblProdajnaJedinica = new System.Windows.Forms.Label();
            this.txtProdajnaJedinica = new System.Windows.Forms.TextBox();
            this.lblDan = new System.Windows.Forms.Label();
            this.cboDan = new System.Windows.Forms.ComboBox();
            this.lblVremeOd = new System.Windows.Forms.Label();
            this.dtpVremeOd = new System.Windows.Forms.DateTimePicker();
            this.lblVremeDo = new System.Windows.Forms.Label();
            this.dtpVremeDo = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.grpLista = new System.Windows.Forms.GroupBox();
            this.dgvRadnoVreme = new System.Windows.Forms.DataGridView();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.grpPodaci.SuspendLayout();
            this.grpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadnoVreme)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(600, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(378, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "➕ KREIRANJE RADNOG VREMENA";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblSubtitle.Location = new System.Drawing.Point(20, 45);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(230, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Dodavanje novih podataka o radnom vremenu";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.panelMain.Controls.Add(this.grpLista);
            this.panelMain.Controls.Add(this.grpPodaci);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 80);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(600, 520);
            this.panelMain.TabIndex = 1;
            // 
            // grpPodaci
            // 
            this.grpPodaci.Controls.Add(this.btnObrisi);
            this.grpPodaci.Controls.Add(this.btnDodaj);
            this.grpPodaci.Controls.Add(this.dtpVremeDo);
            this.grpPodaci.Controls.Add(this.lblVremeDo);
            this.grpPodaci.Controls.Add(this.dtpVremeOd);
            this.grpPodaci.Controls.Add(this.lblVremeOd);
            this.grpPodaci.Controls.Add(this.cboDan);
            this.grpPodaci.Controls.Add(this.lblDan);
            this.grpPodaci.Controls.Add(this.txtProdajnaJedinica);
            this.grpPodaci.Controls.Add(this.lblProdajnaJedinica);
            this.grpPodaci.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpPodaci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grpPodaci.Location = new System.Drawing.Point(20, 20);
            this.grpPodaci.Name = "grpPodaci";
            this.grpPodaci.Size = new System.Drawing.Size(560, 220);
            this.grpPodaci.TabIndex = 0;
            this.grpPodaci.TabStop = false;
            this.grpPodaci.Text = "Podaci o radnom vremenu";
            // 
            // lblProdajnaJedinica
            // 
            this.lblProdajnaJedinica.AutoSize = true;
            this.lblProdajnaJedinica.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProdajnaJedinica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblProdajnaJedinica.Location = new System.Drawing.Point(20, 30);
            this.lblProdajnaJedinica.Name = "lblProdajnaJedinica";
            this.lblProdajnaJedinica.Size = new System.Drawing.Size(116, 19);
            this.lblProdajnaJedinica.TabIndex = 0;
            this.lblProdajnaJedinica.Text = "Prodajna jedinica:";
            // 
            // txtProdajnaJedinica
            // 
            this.txtProdajnaJedinica.BackColor = System.Drawing.Color.White;
            this.txtProdajnaJedinica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdajnaJedinica.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProdajnaJedinica.Location = new System.Drawing.Point(150, 27);
            this.txtProdajnaJedinica.Name = "txtProdajnaJedinica";
            this.txtProdajnaJedinica.ReadOnly = true;
            this.txtProdajnaJedinica.Size = new System.Drawing.Size(250, 26);
            this.txtProdajnaJedinica.TabIndex = 1;
            // 
            // lblDan
            // 
            this.lblDan.AutoSize = true;
            this.lblDan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDan.Location = new System.Drawing.Point(20, 60);
            this.lblDan.Name = "lblDan";
            this.lblDan.Size = new System.Drawing.Size(35, 19);
            this.lblDan.TabIndex = 2;
            this.lblDan.Text = "Dan:";
            // 
            // cboDan
            // 
            this.cboDan.BackColor = System.Drawing.Color.White;
            this.cboDan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboDan.FormattingEnabled = true;
            this.cboDan.Location = new System.Drawing.Point(150, 57);
            this.cboDan.Name = "cboDan";
            this.cboDan.Size = new System.Drawing.Size(250, 25);
            this.cboDan.TabIndex = 3;
            // 
            // lblVremeOd
            // 
            this.lblVremeOd.AutoSize = true;
            this.lblVremeOd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVremeOd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblVremeOd.Location = new System.Drawing.Point(20, 90);
            this.lblVremeOd.Name = "lblVremeOd";
            this.lblVremeOd.Size = new System.Drawing.Size(70, 19);
            this.lblVremeOd.TabIndex = 4;
            this.lblVremeOd.Text = "Početak:";
            // 
            // dtpVremeOd
            // 
            this.dtpVremeOd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpVremeOd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVremeOd.Location = new System.Drawing.Point(150, 87);
            this.dtpVremeOd.Name = "dtpVremeOd";
            this.dtpVremeOd.ShowUpDown = true;
            this.dtpVremeOd.Size = new System.Drawing.Size(120, 26);
            this.dtpVremeOd.TabIndex = 5;
            this.dtpVremeOd.Value = new System.DateTime(2024, 1, 1, 8, 0, 0, 0);
            // 
            // lblVremeDo
            // 
            this.lblVremeDo.AutoSize = true;
            this.lblVremeDo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVremeDo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblVremeDo.Location = new System.Drawing.Point(20, 120);
            this.lblVremeDo.Name = "lblVremeDo";
            this.lblVremeDo.Size = new System.Drawing.Size(58, 19);
            this.lblVremeDo.TabIndex = 6;
            this.lblVremeDo.Text = "Kraj:";
            // 
            // dtpVremeDo
            // 
            this.dtpVremeDo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpVremeDo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVremeDo.Location = new System.Drawing.Point(150, 117);
            this.dtpVremeDo.Name = "dtpVremeDo";
            this.dtpVremeDo.ShowUpDown = true;
            this.dtpVremeDo.Size = new System.Drawing.Size(120, 26);
            this.dtpVremeDo.TabIndex = 7;
            this.dtpVremeDo.Value = new System.DateTime(2024, 1, 1, 16, 0, 0, 0);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(20, 160);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 35);
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
            this.btnObrisi.Location = new System.Drawing.Point(140, 160);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(100, 35);
            this.btnObrisi.TabIndex = 9;
            this.btnObrisi.Text = "🗑️ Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // 
            // grpLista
            // 
            this.grpLista.Controls.Add(this.dgvRadnoVreme);
            this.grpLista.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grpLista.Location = new System.Drawing.Point(20, 260);
            this.grpLista.Name = "grpLista";
            this.grpLista.Size = new System.Drawing.Size(560, 240);
            this.grpLista.TabIndex = 1;
            this.grpLista.TabStop = false;
            this.grpLista.Text = "Lista radnog vremena";
            // 
            // dgvRadnoVreme
            // 
            this.dgvRadnoVreme.AllowUserToAddRows = false;
            this.dgvRadnoVreme.AllowUserToDeleteRows = false;
            this.dgvRadnoVreme.BackgroundColor = System.Drawing.Color.White;
            this.dgvRadnoVreme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRadnoVreme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRadnoVreme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRadnoVreme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.dgvRadnoVreme.Location = new System.Drawing.Point(3, 22);
            this.dgvRadnoVreme.Name = "dgvRadnoVreme";
            this.dgvRadnoVreme.ReadOnly = true;
            this.dgvRadnoVreme.RowHeadersVisible = false;
            this.dgvRadnoVreme.RowTemplate.Height = 30;
            this.dgvRadnoVreme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRadnoVreme.Size = new System.Drawing.Size(554, 215);
            this.dgvRadnoVreme.TabIndex = 0;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelFooter.Controls.Add(this.lblFooter);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 600);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(600, 30);
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
            // RadnoVremeCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 630);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RadnoVremeCreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreiranje radnog vremena - Dodavanje novih podataka";
            this.Load += new System.EventHandler(this.RadnoVremeCreateForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.grpPodaci.ResumeLayout(false);
            this.grpPodaci.PerformLayout();
            this.grpLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadnoVreme)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.GroupBox grpPodaci;
        private System.Windows.Forms.Label lblProdajnaJedinica;
        private System.Windows.Forms.TextBox txtProdajnaJedinica;
        private System.Windows.Forms.Label lblDan;
        private System.Windows.Forms.ComboBox cboDan;
        private System.Windows.Forms.Label lblVremeOd;
        private System.Windows.Forms.DateTimePicker dtpVremeOd;
        private System.Windows.Forms.Label lblVremeDo;
        private System.Windows.Forms.DateTimePicker dtpVremeDo;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.GroupBox grpLista;
        private System.Windows.Forms.DataGridView dgvRadnoVreme;
    }
}
