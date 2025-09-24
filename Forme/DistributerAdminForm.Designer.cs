namespace Farmacy.Forme
{
    partial class DistributerAdminForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dgvDistributeri;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnDodajNoviDistributer;
        private System.Windows.Forms.Button btnIzmeniDistributer;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooter;

        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKontakt;

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
            dgvDistributeri = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNaziv = new DataGridViewTextBoxColumn();
            colKontakt = new DataGridViewTextBoxColumn();
            panelButtons = new Panel();
            btnDodajNoviDistributer = new Button();
            btnIzmeniDistributer = new Button();
            panelFooter = new Panel();
            lblFooter = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDistributeri).BeginInit();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(46, 204, 113);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1200, 120);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🚚 DISTRIBUTERI";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = Color.FromArgb(200, 255, 200);
            lblSubtitle.Location = new Point(30, 75);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(400, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Upravljanje distributerima i njihovim kontakt informacijama";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(panelButtons);
            panelMain.Controls.Add(dgvDistributeri);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 120);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(30);
            panelMain.Size = new Size(1200, 480);
            panelMain.TabIndex = 1;
            // 
            // dgvDistributeri
            // 
            dgvDistributeri.AllowUserToAddRows = false;
            dgvDistributeri.AllowUserToDeleteRows = false;
            dgvDistributeri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDistributeri.BackgroundColor = Color.White;
            dgvDistributeri.BorderStyle = BorderStyle.None;
            dgvDistributeri.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDistributeri.ColumnHeadersHeight = 50;
            dgvDistributeri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDistributeri.Columns.AddRange(new DataGridViewColumn[] { colId, colNaziv, colKontakt });
            dgvDistributeri.Dock = DockStyle.Fill;
            dgvDistributeri.GridColor = Color.FromArgb(233, 236, 239);
            dgvDistributeri.Location = new Point(30, 30);
            dgvDistributeri.MultiSelect = false;
            dgvDistributeri.Name = "dgvDistributeri";
            dgvDistributeri.ReadOnly = true;
            dgvDistributeri.RowHeadersVisible = false;
            dgvDistributeri.RowHeadersWidth = 51;
            dgvDistributeri.RowTemplate.Height = 45;
            dgvDistributeri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDistributeri.Size = new Size(840, 420);
            dgvDistributeri.TabIndex = 0;
            dgvDistributeri.CellContentClick += dgvDistributeri_CellContentClick;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.MinimumWidth = 10;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 80;
            // 
            // colNaziv
            // 
            colNaziv.DataPropertyName = "Naziv";
            colNaziv.HeaderText = "Naziv";
            colNaziv.MinimumWidth = 10;
            colNaziv.Name = "colNaziv";
            colNaziv.ReadOnly = true;
            colNaziv.Width = 300;
            // 
            // colKontakt
            // 
            colKontakt.DataPropertyName = "Kontakt";
            colKontakt.HeaderText = "Kontakt";
            colKontakt.MinimumWidth = 10;
            colKontakt.Name = "colKontakt";
            colKontakt.ReadOnly = true;
            colKontakt.Width = 320;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(255, 255, 255);
            panelButtons.Controls.Add(btnIzmeniDistributer);
            panelButtons.Controls.Add(btnDodajNoviDistributer);
            panelButtons.Dock = DockStyle.Right;
            panelButtons.Location = new Point(900, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(20);
            panelButtons.Size = new Size(270, 420);
            panelButtons.TabIndex = 1;
            // 
            // btnDodajNoviDistributer
            // 
            btnDodajNoviDistributer.BackColor = Color.FromArgb(46, 204, 113);
            btnDodajNoviDistributer.FlatAppearance.BorderSize = 0;
            btnDodajNoviDistributer.FlatStyle = FlatStyle.Flat;
            btnDodajNoviDistributer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDodajNoviDistributer.ForeColor = Color.White;
            btnDodajNoviDistributer.Location = new Point(20, 30);
            btnDodajNoviDistributer.Name = "btnDodajNoviDistributer";
            btnDodajNoviDistributer.Size = new Size(230, 60);
            btnDodajNoviDistributer.TabIndex = 2;
            btnDodajNoviDistributer.Text = "➕ Dodaj novi distributer";
            btnDodajNoviDistributer.TextAlign = ContentAlignment.MiddleCenter;
            btnDodajNoviDistributer.UseVisualStyleBackColor = false;
            btnDodajNoviDistributer.Click += btnDodajNoviDistributer_Click;
            btnDodajNoviDistributer.MouseEnter += Button_MouseEnter;
            btnDodajNoviDistributer.MouseLeave += Button_MouseLeave;
            // 
            // btnIzmeniDistributer
            // 
            btnIzmeniDistributer.BackColor = Color.FromArgb(52, 152, 219);
            btnIzmeniDistributer.FlatAppearance.BorderSize = 0;
            btnIzmeniDistributer.FlatStyle = FlatStyle.Flat;
            btnIzmeniDistributer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnIzmeniDistributer.ForeColor = Color.White;
            btnIzmeniDistributer.Location = new Point(20, 110);
            btnIzmeniDistributer.Name = "btnIzmeniDistributer";
            btnIzmeniDistributer.Size = new Size(230, 60);
            btnIzmeniDistributer.TabIndex = 3;
            btnIzmeniDistributer.Text = "✏️ Izmeni distributera";
            btnIzmeniDistributer.TextAlign = ContentAlignment.MiddleCenter;
            btnIzmeniDistributer.UseVisualStyleBackColor = false;
            btnIzmeniDistributer.Click += btnIzmeniDistributer_Click;
            btnIzmeniDistributer.MouseEnter += Button_MouseEnter;
            btnIzmeniDistributer.MouseLeave += Button_MouseLeave;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(44, 62, 80);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 600);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1200, 40);
            panelFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 9F);
            lblFooter.ForeColor = Color.FromArgb(189, 195, 199);
            lblFooter.Location = new Point(30, 12);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(250, 15);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Distributeri - Upravljanje kontakt informacijama";
            // 
            // DistributerAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 640);
            Controls.Add(panelMain);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DistributerAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farmacy System - Distributeri";
            Load += DistributerAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDistributeri).EndInit();
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
