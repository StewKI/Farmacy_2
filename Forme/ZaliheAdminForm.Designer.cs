namespace Farmacy.Forme
{
    partial class ZaliheAdminForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.DataGridView dgvZalihe;
        private System.Windows.Forms.Button btnDodajNovuZalihu;
        private System.Windows.Forms.Button btnIzmeniZalihu;
        private System.Windows.Forms.Button btnObrisiZalihu;
        private System.Windows.Forms.Panel panelButtons;

        private System.Windows.Forms.DataGridViewTextBoxColumn colProdajnaJedinicaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPakovanjeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatumPoslednjeIsporuke;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOdgovorniMagacionerMbr;

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
            dgvZalihe = new DataGridView();
            colProdajnaJedinicaId = new DataGridViewTextBoxColumn();
            colPakovanjeId = new DataGridViewTextBoxColumn();
            colKolicina = new DataGridViewTextBoxColumn();
            colDatumPoslednjeIsporuke = new DataGridViewTextBoxColumn();
            colOdgovorniMagacionerMbr = new DataGridViewTextBoxColumn();
            panelButtons = new Panel();
            btnDodajNovuZalihu = new Button();
            btnIzmeniZalihu = new Button();
            btnObrisiZalihu = new Button();
            panelFooter = new Panel();
            lblFooter = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvZalihe).BeginInit();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
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
            panelHeader.Size = new Size(1200, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(275, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📦 ADMINISTRACIJA ZALIHA";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(189, 195, 199);
            lblSubtitle.Location = new Point(20, 45);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(280, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Upravljanje zalihe u magacinu - pregled i izmena";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(dgvZalihe);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 80);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(950, 470);
            panelMain.TabIndex = 1;
            // 
            // dgvZalihe
            // 
            dgvZalihe.AllowUserToAddRows = false;
            dgvZalihe.AllowUserToDeleteRows = false;
            dgvZalihe.BackgroundColor = Color.White;
            dgvZalihe.BorderStyle = BorderStyle.None;
            dgvZalihe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvZalihe.ColumnHeadersHeight = 50;
            dgvZalihe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvZalihe.Columns.AddRange(new DataGridViewColumn[] { colProdajnaJedinicaId, colPakovanjeId, colKolicina, colDatumPoslednjeIsporuke, colOdgovorniMagacionerMbr });
            dgvZalihe.Dock = DockStyle.Fill;
            dgvZalihe.GridColor = Color.FromArgb(233, 236, 239);
            dgvZalihe.MultiSelect = false;
            dgvZalihe.Name = "dgvZalihe";
            dgvZalihe.ReadOnly = true;
            dgvZalihe.RowHeadersVisible = false;
            dgvZalihe.RowHeadersWidth = 51;
            dgvZalihe.RowTemplate.Height = 40;
            dgvZalihe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvZalihe.Size = new Size(910, 430);
            dgvZalihe.TabIndex = 0;
            dgvZalihe.CellContentClick += dgvZalihe_CellContentClick;
            // 
            // colProdajnaJedinicaId
            // 
            colProdajnaJedinicaId.DataPropertyName = "ProdajnaJedinicaId";
            colProdajnaJedinicaId.HeaderText = "Prodajna Jedinica ID";
            colProdajnaJedinicaId.MinimumWidth = 10;
            colProdajnaJedinicaId.Name = "colProdajnaJedinicaId";
            colProdajnaJedinicaId.ReadOnly = true;
            colProdajnaJedinicaId.Width = 150;
            // 
            // colPakovanjeId
            // 
            colPakovanjeId.DataPropertyName = "PakovanjeId";
            colPakovanjeId.HeaderText = "Pakovanje ID";
            colPakovanjeId.MinimumWidth = 10;
            colPakovanjeId.Name = "colPakovanjeId";
            colPakovanjeId.ReadOnly = true;
            colPakovanjeId.Width = 120;
            // 
            // colKolicina
            // 
            colKolicina.DataPropertyName = "Kolicina";
            colKolicina.HeaderText = "Količina";
            colKolicina.MinimumWidth = 10;
            colKolicina.Name = "colKolicina";
            colKolicina.ReadOnly = true;
            colKolicina.Width = 100;
            // 
            // colDatumPoslednjeIsporuke
            // 
            colDatumPoslednjeIsporuke.DataPropertyName = "DatumPoslednjeIsporuke";
            colDatumPoslednjeIsporuke.HeaderText = "Datum poslednje isporuke";
            colDatumPoslednjeIsporuke.MinimumWidth = 10;
            colDatumPoslednjeIsporuke.Name = "colDatumPoslednjeIsporuke";
            colDatumPoslednjeIsporuke.ReadOnly = true;
            colDatumPoslednjeIsporuke.Width = 180;
            // 
            // colOdgovorniMagacionerMbr
            // 
            colOdgovorniMagacionerMbr.DataPropertyName = "OdgovorniMagacionerMbr";
            colOdgovorniMagacionerMbr.HeaderText = "Magacioner MBR";
            colOdgovorniMagacionerMbr.MinimumWidth = 10;
            colOdgovorniMagacionerMbr.Name = "colOdgovorniMagacionerMbr";
            colOdgovorniMagacionerMbr.ReadOnly = true;
            colOdgovorniMagacionerMbr.Width = 150;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(255, 255, 255);
            panelButtons.Controls.Add(btnObrisiZalihu);
            panelButtons.Controls.Add(btnIzmeniZalihu);
            panelButtons.Controls.Add(btnDodajNovuZalihu);
            panelButtons.Dock = DockStyle.Right;
            panelButtons.Location = new Point(950, 80);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(20);
            panelButtons.Size = new Size(250, 470);
            panelButtons.TabIndex = 2;
            // 
            // btnDodajNovuZalihu
            // 
            btnDodajNovuZalihu.BackColor = Color.FromArgb(40, 167, 69);
            btnDodajNovuZalihu.FlatAppearance.BorderSize = 0;
            btnDodajNovuZalihu.FlatStyle = FlatStyle.Flat;
            btnDodajNovuZalihu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDodajNovuZalihu.ForeColor = Color.White;
            btnDodajNovuZalihu.Location = new Point(20, 80);
            btnDodajNovuZalihu.Name = "btnDodajNovuZalihu";
            btnDodajNovuZalihu.Size = new Size(210, 50);
            btnDodajNovuZalihu.TabIndex = 2;
            btnDodajNovuZalihu.Text = "➕ Dodaj novu zalihe";
            btnDodajNovuZalihu.UseVisualStyleBackColor = false;
            btnDodajNovuZalihu.Click += btnDodajNovuZalihu_Click;
            // 
            // btnIzmeniZalihu
            // 
            btnIzmeniZalihu.BackColor = Color.FromArgb(0, 123, 255);
            btnIzmeniZalihu.FlatAppearance.BorderSize = 0;
            btnIzmeniZalihu.FlatStyle = FlatStyle.Flat;
            btnIzmeniZalihu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIzmeniZalihu.ForeColor = Color.White;
            btnIzmeniZalihu.Location = new Point(20, 150);
            btnIzmeniZalihu.Name = "btnIzmeniZalihu";
            btnIzmeniZalihu.Size = new Size(210, 50);
            btnIzmeniZalihu.TabIndex = 3;
            btnIzmeniZalihu.Text = "✏️ Izmeni zalihe";
            btnIzmeniZalihu.UseVisualStyleBackColor = false;
            // 
            // btnObrisiZalihu
            // 
            btnObrisiZalihu.BackColor = Color.FromArgb(220, 53, 69);
            btnObrisiZalihu.FlatAppearance.BorderSize = 0;
            btnObrisiZalihu.FlatStyle = FlatStyle.Flat;
            btnObrisiZalihu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnObrisiZalihu.ForeColor = Color.White;
            btnObrisiZalihu.Location = new Point(20, 220);
            btnObrisiZalihu.Name = "btnObrisiZalihu";
            btnObrisiZalihu.Size = new Size(210, 50);
            btnObrisiZalihu.TabIndex = 4;
            btnObrisiZalihu.Text = "🗑️ Obriši zalihe";
            btnObrisiZalihu.UseVisualStyleBackColor = false;
            btnObrisiZalihu.Click += btnObrisiZalihu_Click;
            btnIzmeniZalihu.Click += btnIzmeniZalihu_Click;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(44, 62, 80);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 550);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1200, 30);
            panelFooter.TabIndex = 3;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 8F);
            lblFooter.ForeColor = Color.FromArgb(189, 195, 199);
            lblFooter.Location = new Point(20, 8);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(210, 13);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Sistem za upravljanje farmaceutskim podacima";
            // 
            // ZaliheAdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1200, 580);
            Controls.Add(panelButtons);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Controls.Add(panelFooter);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ZaliheAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administracija zaliha - Upravljanje zalihe";
            Load += ZaliheAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvZalihe).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }
    }
}
