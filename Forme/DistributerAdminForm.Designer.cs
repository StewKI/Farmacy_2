namespace Farmacy.Forme
{
    partial class DistributerAdminForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvDistributeri;
        private System.Windows.Forms.Label lblDistributeri;
        private System.Windows.Forms.Button btnDodajNoviDistributer;
        private System.Windows.Forms.Button btnIzmeniDistributer;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelButtons;

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
            dgvDistributeri = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNaziv = new DataGridViewTextBoxColumn();
            colKontakt = new DataGridViewTextBoxColumn();
            lblDistributeri = new Label();
            btnDodajNoviDistributer = new Button();
            btnIzmeniDistributer = new Button();
            panelMain = new Panel();
            panelButtons = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvDistributeri).BeginInit();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(248, 249, 250);
            panelMain.Controls.Add(dgvDistributeri);
            panelMain.Controls.Add(lblDistributeri);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(1000, 600);
            panelMain.TabIndex = 0;
            // 
            // lblDistributeri
            // 
            lblDistributeri.AutoSize = true;
            lblDistributeri.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblDistributeri.ForeColor = Color.FromArgb(33, 37, 41);
            lblDistributeri.Location = new Point(20, 20);
            lblDistributeri.Name = "lblDistributeri";
            lblDistributeri.Size = new Size(200, 41);
            lblDistributeri.TabIndex = 1;
            lblDistributeri.Text = "Distributeri";
            // 
            // dgvDistributeri
            // 
            dgvDistributeri.AllowUserToAddRows = false;
            dgvDistributeri.AllowUserToDeleteRows = false;
            dgvDistributeri.BackgroundColor = Color.White;
            dgvDistributeri.BorderStyle = BorderStyle.None;
            dgvDistributeri.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDistributeri.ColumnHeadersHeight = 50;
            dgvDistributeri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDistributeri.Columns.AddRange(new DataGridViewColumn[] { colId, colNaziv, colKontakt });
            dgvDistributeri.GridColor = Color.FromArgb(233, 236, 239);
            dgvDistributeri.Location = new Point(20, 80);
            dgvDistributeri.MultiSelect = false;
            dgvDistributeri.Name = "dgvDistributeri";
            dgvDistributeri.ReadOnly = true;
            dgvDistributeri.RowHeadersVisible = false;
            dgvDistributeri.RowHeadersWidth = 51;
            dgvDistributeri.RowTemplate.Height = 40;
            dgvDistributeri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDistributeri.Size = new Size(700, 480);
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
            panelButtons.Location = new Point(750, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(20);
            panelButtons.Size = new Size(250, 600);
            panelButtons.TabIndex = 1;
            // 
            // btnDodajNoviDistributer
            // 
            btnDodajNoviDistributer.BackColor = Color.FromArgb(40, 167, 69);
            btnDodajNoviDistributer.FlatAppearance.BorderSize = 0;
            btnDodajNoviDistributer.FlatStyle = FlatStyle.Flat;
            btnDodajNoviDistributer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDodajNoviDistributer.ForeColor = Color.White;
            btnDodajNoviDistributer.Location = new Point(20, 80);
            btnDodajNoviDistributer.Name = "btnDodajNoviDistributer";
            btnDodajNoviDistributer.Size = new Size(210, 50);
            btnDodajNoviDistributer.TabIndex = 2;
            btnDodajNoviDistributer.Text = "➕ Dodaj novi distributer";
            btnDodajNoviDistributer.UseVisualStyleBackColor = false;
            btnDodajNoviDistributer.Click += btnDodajNoviDistributer_Click;
            // 
            // btnIzmeniDistributer
            // 
            btnIzmeniDistributer.BackColor = Color.FromArgb(0, 123, 255);
            btnIzmeniDistributer.FlatAppearance.BorderSize = 0;
            btnIzmeniDistributer.FlatStyle = FlatStyle.Flat;
            btnIzmeniDistributer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIzmeniDistributer.ForeColor = Color.White;
            btnIzmeniDistributer.Location = new Point(20, 150);
            btnIzmeniDistributer.Name = "btnIzmeniDistributer";
            btnIzmeniDistributer.Size = new Size(210, 50);
            btnIzmeniDistributer.TabIndex = 3;
            btnIzmeniDistributer.Text = "✏️ Izmeni distributera";
            btnIzmeniDistributer.UseVisualStyleBackColor = false;
            btnIzmeniDistributer.Click += btnIzmeniDistributer_Click;
            // 
            // DistributerAdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1000, 600);
            Controls.Add(panelButtons);
            Controls.Add(panelMain);
            Name = "DistributerAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administracija distributera";
            Load += DistributerAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDistributeri).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
