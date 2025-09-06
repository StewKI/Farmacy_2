namespace Farmacy.Forme
{
    partial class ProizvodjacAdminForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvProizvodjaci;
        private System.Windows.Forms.Label lblProizvodjaci;
        private System.Windows.Forms.Button btnDodajNoviProizvodjac;
        private System.Windows.Forms.Button btnIzmeniProizvodjac;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelButtons;

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
            dgvProizvodjaci = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNaziv = new DataGridViewTextBoxColumn();
            colZemlja = new DataGridViewTextBoxColumn();
            colTelefon = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            lblProizvodjaci = new Label();
            btnDodajNoviProizvodjac = new Button();
            btnIzmeniProizvodjac = new Button();
            panelMain = new Panel();
            panelButtons = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvProizvodjaci).BeginInit();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(248, 249, 250);
            panelMain.Controls.Add(dgvProizvodjaci);
            panelMain.Controls.Add(lblProizvodjaci);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(1200, 600);
            panelMain.TabIndex = 0;
            // 
            // lblProizvodjaci
            // 
            lblProizvodjaci.AutoSize = true;
            lblProizvodjaci.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblProizvodjaci.ForeColor = Color.FromArgb(33, 37, 41);
            lblProizvodjaci.Location = new Point(20, 20);
            lblProizvodjaci.Name = "lblProizvodjaci";
            lblProizvodjaci.Size = new Size(250, 41);
            lblProizvodjaci.TabIndex = 1;
            lblProizvodjaci.Text = "Proizvodjači";
            // 
            // dgvProizvodjaci
            // 
            dgvProizvodjaci.AllowUserToAddRows = false;
            dgvProizvodjaci.AllowUserToDeleteRows = false;
            dgvProizvodjaci.BackgroundColor = Color.White;
            dgvProizvodjaci.BorderStyle = BorderStyle.None;
            dgvProizvodjaci.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProizvodjaci.ColumnHeadersHeight = 50;
            dgvProizvodjaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProizvodjaci.Columns.AddRange(new DataGridViewColumn[] { colId, colNaziv, colZemlja, colTelefon, colEmail });
            dgvProizvodjaci.GridColor = Color.FromArgb(233, 236, 239);
            dgvProizvodjaci.Location = new Point(20, 80);
            dgvProizvodjaci.MultiSelect = false;
            dgvProizvodjaci.Name = "dgvProizvodjaci";
            dgvProizvodjaci.ReadOnly = true;
            dgvProizvodjaci.RowHeadersVisible = false;
            dgvProizvodjaci.RowHeadersWidth = 51;
            dgvProizvodjaci.RowTemplate.Height = 40;
            dgvProizvodjaci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProizvodjaci.Size = new Size(900, 480);
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
            panelButtons.Location = new Point(950, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(20);
            panelButtons.Size = new Size(250, 600);
            panelButtons.TabIndex = 1;
            // 
            // btnDodajNoviProizvodjac
            // 
            btnDodajNoviProizvodjac.BackColor = Color.FromArgb(40, 167, 69);
            btnDodajNoviProizvodjac.FlatAppearance.BorderSize = 0;
            btnDodajNoviProizvodjac.FlatStyle = FlatStyle.Flat;
            btnDodajNoviProizvodjac.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDodajNoviProizvodjac.ForeColor = Color.White;
            btnDodajNoviProizvodjac.Location = new Point(20, 80);
            btnDodajNoviProizvodjac.Name = "btnDodajNoviProizvodjac";
            btnDodajNoviProizvodjac.Size = new Size(210, 50);
            btnDodajNoviProizvodjac.TabIndex = 2;
            btnDodajNoviProizvodjac.Text = "➕ Dodaj novi proizvodjač";
            btnDodajNoviProizvodjac.UseVisualStyleBackColor = false;
            btnDodajNoviProizvodjac.Click += btnDodajNoviProizvodjac_Click;
            // 
            // btnIzmeniProizvodjac
            // 
            btnIzmeniProizvodjac.BackColor = Color.FromArgb(0, 123, 255);
            btnIzmeniProizvodjac.FlatAppearance.BorderSize = 0;
            btnIzmeniProizvodjac.FlatStyle = FlatStyle.Flat;
            btnIzmeniProizvodjac.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIzmeniProizvodjac.ForeColor = Color.White;
            btnIzmeniProizvodjac.Location = new Point(20, 150);
            btnIzmeniProizvodjac.Name = "btnIzmeniProizvodjac";
            btnIzmeniProizvodjac.Size = new Size(210, 50);
            btnIzmeniProizvodjac.TabIndex = 3;
            btnIzmeniProizvodjac.Text = "✏️ Izmeni proizvodjača";
            btnIzmeniProizvodjac.UseVisualStyleBackColor = false;
            btnIzmeniProizvodjac.Click += btnIzmeniProizvodjac_Click;
            // 
            // ProizvodjacAdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1200, 600);
            Controls.Add(panelButtons);
            Controls.Add(panelMain);
            Name = "ProizvodjacAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administracija proizvodjača";
            Load += ProizvodjacAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProizvodjaci).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}