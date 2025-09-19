namespace Farmacy.Forme
{
    partial class SekundarnaGrupaForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dgvSekundarneGrupe;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnNovaSekundarnaGrupa;
        private System.Windows.Forms.Button btnObrisiSekundarnuGrupu;
        private System.Windows.Forms.Button btnIzmeniSekundarnuGrupu;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooter;

        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNaziv;

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
            dgvSekundarneGrupe = new DataGridView();
            panelButtons = new Panel();
            btnNovaSekundarnaGrupa = new Button();
            btnObrisiSekundarnuGrupu = new Button();
            btnIzmeniSekundarnuGrupu = new Button();
            panelFooter = new Panel();
            lblFooter = new Label();
            colId = new DataGridViewTextBoxColumn();
            colNaziv = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSekundarneGrupe).BeginInit();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(255, 220, 80);
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
            lblTitle.Size = new Size(350, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📊 SEKUNDARNE GRUPE";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(255, 240, 150);
            lblSubtitle.Location = new Point(20, 60);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(400, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Upravljanje sekundarnim grupama lekova";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(panelButtons);
            panelMain.Controls.Add(dgvSekundarneGrupe);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 100);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(800, 400);
            panelMain.TabIndex = 1;
            // 
            // dgvSekundarneGrupe
            // 
            dgvSekundarneGrupe.AllowUserToAddRows = false;
            dgvSekundarneGrupe.AllowUserToDeleteRows = false;
            dgvSekundarneGrupe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSekundarneGrupe.BackgroundColor = Color.White;
            dgvSekundarneGrupe.BorderStyle = BorderStyle.None;
            dgvSekundarneGrupe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSekundarneGrupe.ColumnHeadersHeight = 50;
            dgvSekundarneGrupe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSekundarneGrupe.Columns.AddRange(new DataGridViewColumn[] { colId, colNaziv });
            dgvSekundarneGrupe.Dock = DockStyle.Fill;
            dgvSekundarneGrupe.GridColor = Color.FromArgb(233, 236, 239);
            dgvSekundarneGrupe.Location = new Point(20, 20);
            dgvSekundarneGrupe.MultiSelect = false;
            dgvSekundarneGrupe.Name = "dgvSekundarneGrupe";
            dgvSekundarneGrupe.ReadOnly = true;
            dgvSekundarneGrupe.RowHeadersVisible = false;
            dgvSekundarneGrupe.RowHeadersWidth = 51;
            dgvSekundarneGrupe.RowTemplate.Height = 45;
            dgvSekundarneGrupe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSekundarneGrupe.Size = new Size(500, 360);
            dgvSekundarneGrupe.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(255, 255, 255);
            panelButtons.Controls.Add(btnIzmeniSekundarnuGrupu);
            panelButtons.Controls.Add(btnObrisiSekundarnuGrupu);
            panelButtons.Controls.Add(btnNovaSekundarnaGrupa);
            panelButtons.Dock = DockStyle.Right;
            panelButtons.Location = new Point(540, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(20);
            panelButtons.Size = new Size(240, 360);
            panelButtons.TabIndex = 1;
            // 
            // btnNovaSekundarnaGrupa
            // 
            btnNovaSekundarnaGrupa.BackColor = Color.FromArgb(80, 220, 140);
            btnNovaSekundarnaGrupa.FlatAppearance.BorderSize = 0;
            btnNovaSekundarnaGrupa.FlatStyle = FlatStyle.Flat;
            btnNovaSekundarnaGrupa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNovaSekundarnaGrupa.ForeColor = Color.White;
            btnNovaSekundarnaGrupa.Location = new Point(20, 20);
            btnNovaSekundarnaGrupa.Name = "btnNovaSekundarnaGrupa";
            btnNovaSekundarnaGrupa.Size = new Size(200, 50);
            btnNovaSekundarnaGrupa.TabIndex = 0;
            btnNovaSekundarnaGrupa.Text = "➕ Nova sekundarna grupa";
            btnNovaSekundarnaGrupa.TextAlign = ContentAlignment.MiddleCenter;
            btnNovaSekundarnaGrupa.UseVisualStyleBackColor = false;
            btnNovaSekundarnaGrupa.Click += btnNovaSekundarnaGrupa_Click;
            btnNovaSekundarnaGrupa.MouseEnter += Button_MouseEnter;
            btnNovaSekundarnaGrupa.MouseLeave += Button_MouseLeave;
            // 
            // btnObrisiSekundarnuGrupu
            // 
            btnObrisiSekundarnuGrupu.BackColor = Color.FromArgb(250, 120, 100);
            btnObrisiSekundarnuGrupu.FlatAppearance.BorderSize = 0;
            btnObrisiSekundarnuGrupu.FlatStyle = FlatStyle.Flat;
            btnObrisiSekundarnuGrupu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnObrisiSekundarnuGrupu.ForeColor = Color.White;
            btnObrisiSekundarnuGrupu.Location = new Point(20, 90);
            btnObrisiSekundarnuGrupu.Name = "btnObrisiSekundarnuGrupu";
            btnObrisiSekundarnuGrupu.Size = new Size(200, 50);
            btnObrisiSekundarnuGrupu.TabIndex = 1;
            btnObrisiSekundarnuGrupu.Text = "🗑️ Obriši sekundarnu grupu";
            btnObrisiSekundarnuGrupu.TextAlign = ContentAlignment.MiddleCenter;
            btnObrisiSekundarnuGrupu.UseVisualStyleBackColor = false;
            btnObrisiSekundarnuGrupu.Click += btnObrisiSekundarnuGrupu_Click;
            btnObrisiSekundarnuGrupu.MouseEnter += Button_MouseEnter;
            btnObrisiSekundarnuGrupu.MouseLeave += Button_MouseLeave;
            // 
            // btnIzmeniSekundarnuGrupu
            // 
            btnIzmeniSekundarnuGrupu.BackColor = Color.FromArgb(80, 170, 230);
            btnIzmeniSekundarnuGrupu.FlatAppearance.BorderSize = 0;
            btnIzmeniSekundarnuGrupu.FlatStyle = FlatStyle.Flat;
            btnIzmeniSekundarnuGrupu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIzmeniSekundarnuGrupu.ForeColor = Color.White;
            btnIzmeniSekundarnuGrupu.Location = new Point(20, 160);
            btnIzmeniSekundarnuGrupu.Name = "btnIzmeniSekundarnuGrupu";
            btnIzmeniSekundarnuGrupu.Size = new Size(200, 50);
            btnIzmeniSekundarnuGrupu.TabIndex = 2;
            btnIzmeniSekundarnuGrupu.Text = "✏️ Izmeni sekundarnu grupu";
            btnIzmeniSekundarnuGrupu.TextAlign = ContentAlignment.MiddleCenter;
            btnIzmeniSekundarnuGrupu.UseVisualStyleBackColor = false;
            btnIzmeniSekundarnuGrupu.Click += btnIzmeniSekundarnuGrupu_Click;
            btnIzmeniSekundarnuGrupu.MouseEnter += Button_MouseEnter;
            btnIzmeniSekundarnuGrupu.MouseLeave += Button_MouseLeave;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 60;
            // 
            // colNaziv
            // 
            colNaziv.DataPropertyName = "Naziv";
            colNaziv.HeaderText = "Naziv";
            colNaziv.Name = "colNaziv";
            colNaziv.ReadOnly = true;
            colNaziv.Width = 500;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(44, 62, 80);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 500);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(800, 30);
            panelFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 8F);
            lblFooter.ForeColor = Color.FromArgb(189, 195, 199);
            lblFooter.Location = new Point(20, 8);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(250, 13);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Sekundarne grupe - Upravljanje sekundarnim grupama lekova";
            // 
            // SekundarnaGrupaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 530);
            Controls.Add(panelMain);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SekundarnaGrupaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Farmacy System - Sekundarne Grupe";
            ((System.ComponentModel.ISupportInitialize)dgvSekundarneGrupe).EndInit();
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