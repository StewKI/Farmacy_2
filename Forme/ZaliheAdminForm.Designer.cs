namespace Farmacy.Forme
{
    partial class ZaliheAdminForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvZalihe;
        private System.Windows.Forms.Label lblZalihe;
        private System.Windows.Forms.Button btnDodajNovuZalihu;
        private System.Windows.Forms.Button btnIzmeniZalihu;
        private System.Windows.Forms.Button btnObrisiZalihu;
        private System.Windows.Forms.Panel panelMain;
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
            dgvZalihe = new DataGridView();
            colProdajnaJedinicaId = new DataGridViewTextBoxColumn();
            colPakovanjeId = new DataGridViewTextBoxColumn();
            colKolicina = new DataGridViewTextBoxColumn();
            colDatumPoslednjeIsporuke = new DataGridViewTextBoxColumn();
            colOdgovorniMagacionerMbr = new DataGridViewTextBoxColumn();
            lblZalihe = new Label();
            btnDodajNovuZalihu = new Button();
            btnIzmeniZalihu = new Button();
            btnObrisiZalihu = new Button();
            panelMain = new Panel();
            panelButtons = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvZalihe).BeginInit();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(248, 249, 250);
            panelMain.Controls.Add(dgvZalihe);
            panelMain.Controls.Add(lblZalihe);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(1200, 600);
            panelMain.TabIndex = 0;
            // 
            // lblZalihe
            // 
            lblZalihe.AutoSize = true;
            lblZalihe.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblZalihe.ForeColor = Color.FromArgb(33, 37, 41);
            lblZalihe.Location = new Point(20, 20);
            lblZalihe.Name = "lblZalihe";
            lblZalihe.Size = new Size(120, 41);
            lblZalihe.TabIndex = 1;
            lblZalihe.Text = "Zalihe";
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
            dgvZalihe.GridColor = Color.FromArgb(233, 236, 239);
            dgvZalihe.Location = new Point(20, 80);
            dgvZalihe.MultiSelect = false;
            dgvZalihe.Name = "dgvZalihe";
            dgvZalihe.ReadOnly = true;
            dgvZalihe.RowHeadersVisible = false;
            dgvZalihe.RowHeadersWidth = 51;
            dgvZalihe.RowTemplate.Height = 40;
            dgvZalihe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvZalihe.Size = new Size(900, 480);
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
            panelButtons.Location = new Point(950, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(20);
            panelButtons.Size = new Size(250, 600);
            panelButtons.TabIndex = 1;
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
            // ZaliheAdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1200, 600);
            Controls.Add(panelButtons);
            Controls.Add(panelMain);
            Name = "ZaliheAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administracija zaliha";
            Load += ZaliheAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvZalihe).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
