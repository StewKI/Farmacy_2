namespace Farmacy.Forme
{
    partial class ProizvodjacAdminForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dgvProizvodjaci;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnDodajNoviProizvodjac;
        private System.Windows.Forms.Button btnIzmeniProizvodjac;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooter;

        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZemlja;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;

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
            dgvProizvodjaci = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNaziv = new DataGridViewTextBoxColumn();
            colZemlja = new DataGridViewTextBoxColumn();
            colTelefon = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            panelButtons = new Panel();
            btnDodajNoviProizvodjac = new Button();
            btnIzmeniProizvodjac = new Button();
            panelFooter = new Panel();
            lblFooter = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProizvodjaci).BeginInit();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(52, 152, 219);
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
            lblTitle.Size = new Size(350, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🏭 PROIZVOĐAČI";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = Color.FromArgb(200, 220, 255);
            lblSubtitle.Location = new Point(30, 75);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(450, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Upravljanje proizvođačima lekova i njihovim kontakt informacijama";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(panelButtons);
            panelMain.Controls.Add(dgvProizvodjaci);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 120);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(30);
            panelMain.Size = new Size(1200, 480);
            panelMain.TabIndex = 1;
            // 
            // dgvProizvodjaci
            // 
            dgvProizvodjaci.AllowUserToAddRows = false;
            dgvProizvodjaci.AllowUserToDeleteRows = false;
            dgvProizvodjaci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProizvodjaci.BackgroundColor = Color.White;
            dgvProizvodjaci.BorderStyle = BorderStyle.None;
            dgvProizvodjaci.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProizvodjaci.ColumnHeadersHeight = 50;
            dgvProizvodjaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProizvodjaci.Columns.AddRange(new DataGridViewColumn[] { colId, colNaziv, colZemlja, colTelefon, colEmail });
            dgvProizvodjaci.Dock = DockStyle.Fill;
            dgvProizvodjaci.GridColor = Color.FromArgb(233, 236, 239);
            dgvProizvodjaci.Location = new Point(30, 30);
            dgvProizvodjaci.MultiSelect = false;
            dgvProizvodjaci.Name = "dgvProizvodjaci";
            dgvProizvodjaci.ReadOnly = true;
            dgvProizvodjaci.RowHeadersVisible = false;
            dgvProizvodjaci.RowHeadersWidth = 51;
            dgvProizvodjaci.RowTemplate.Height = 45;
            dgvProizvodjaci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProizvodjaci.Size = new Size(840, 420);
            dgvProizvodjaci.TabIndex = 0;
            dgvProizvodjaci.CellContentClick += dgvProizvodjaci_CellContentClick;
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
            colNaziv.Width = 200;
            // 
            // colZemlja
            // 
            colZemlja.DataPropertyName = "Zemlja";
            colZemlja.HeaderText = "Zemlja";
            colZemlja.MinimumWidth = 10;
            colZemlja.Name = "colZemlja";
            colZemlja.ReadOnly = true;
            colZemlja.Width = 120;
            // 
            // colTelefon
            // 
            colTelefon.DataPropertyName = "Telefon";
            colTelefon.HeaderText = "Telefon";
            colTelefon.MinimumWidth = 10;
            colTelefon.Name = "colTelefon";
            colTelefon.ReadOnly = true;
            colTelefon.Width = 150;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 10;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.Width = 200;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(255, 255, 255);
            panelButtons.Controls.Add(btnIzmeniProizvodjac);
            panelButtons.Controls.Add(btnDodajNoviProizvodjac);
            panelButtons.Dock = DockStyle.Right;
            panelButtons.Location = new Point(900, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(20);
            panelButtons.Size = new Size(270, 420);
            panelButtons.TabIndex = 1;
            // 
            // btnDodajNoviProizvodjac
            // 
            btnDodajNoviProizvodjac.BackColor = Color.FromArgb(52, 152, 219);
            btnDodajNoviProizvodjac.FlatAppearance.BorderSize = 0;
            btnDodajNoviProizvodjac.FlatStyle = FlatStyle.Flat;
            btnDodajNoviProizvodjac.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDodajNoviProizvodjac.ForeColor = Color.White;
            btnDodajNoviProizvodjac.Location = new Point(20, 30);
            btnDodajNoviProizvodjac.Name = "btnDodajNoviProizvodjac";
            btnDodajNoviProizvodjac.Size = new Size(230, 60);
            btnDodajNoviProizvodjac.TabIndex = 2;
            btnDodajNoviProizvodjac.Text = "➕ Dodaj novi proizvodjač";
            btnDodajNoviProizvodjac.TextAlign = ContentAlignment.MiddleCenter;
            btnDodajNoviProizvodjac.UseVisualStyleBackColor = false;
            btnDodajNoviProizvodjac.Click += btnDodajNoviProizvodjac_Click;
            btnDodajNoviProizvodjac.MouseEnter += Button_MouseEnter;
            btnDodajNoviProizvodjac.MouseLeave += Button_MouseLeave;
            // 
            // btnIzmeniProizvodjac
            // 
            btnIzmeniProizvodjac.BackColor = Color.FromArgb(46, 204, 113);
            btnIzmeniProizvodjac.FlatAppearance.BorderSize = 0;
            btnIzmeniProizvodjac.FlatStyle = FlatStyle.Flat;
            btnIzmeniProizvodjac.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnIzmeniProizvodjac.ForeColor = Color.White;
            btnIzmeniProizvodjac.Location = new Point(20, 110);
            btnIzmeniProizvodjac.Name = "btnIzmeniProizvodjac";
            btnIzmeniProizvodjac.Size = new Size(230, 60);
            btnIzmeniProizvodjac.TabIndex = 3;
            btnIzmeniProizvodjac.Text = "✏️ Izmeni proizvodjača";
            btnIzmeniProizvodjac.TextAlign = ContentAlignment.MiddleCenter;
            btnIzmeniProizvodjac.UseVisualStyleBackColor = false;
            btnIzmeniProizvodjac.Click += btnIzmeniProizvodjac_Click;
            btnIzmeniProizvodjac.MouseEnter += Button_MouseEnter;
            btnIzmeniProizvodjac.MouseLeave += Button_MouseLeave;
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
            lblFooter.Size = new Size(300, 15);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Proizvođači - Upravljanje kontakt informacijama";
            // 
            // ProizvodjacAdminForm
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
            Name = "ProizvodjacAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farmacy System - Proizvođači";
            Load += ProizvodjacAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProizvodjaci).EndInit();
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