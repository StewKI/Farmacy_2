namespace Farmacy.Forme
{
    partial class PrimarnaGrupaForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dgvPrimarneGrupe;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnNovaPrimarnaGrupa;
        private System.Windows.Forms.Button btnObrisiPrimarnuGrupu;
        private System.Windows.Forms.Button btnIzmeniPrimarnuGrupu;
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
            dgvPrimarneGrupe = new DataGridView();
            panelButtons = new Panel();
            btnNovaPrimarnaGrupa = new Button();
            btnObrisiPrimarnuGrupu = new Button();
            btnIzmeniPrimarnuGrupu = new Button();
            panelFooter = new Panel();
            lblFooter = new Label();
            colId = new DataGridViewTextBoxColumn();
            colNaziv = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPrimarneGrupe).BeginInit();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(250, 160, 80);
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
            lblTitle.Size = new Size(300, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📊 PRIMARNE GRUPE";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(255, 220, 180);
            lblSubtitle.Location = new Point(20, 60);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(400, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Upravljanje primarnim grupama lekova";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(panelButtons);
            panelMain.Controls.Add(dgvPrimarneGrupe);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 100);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(800, 400);
            panelMain.TabIndex = 1;
            // 
            // dgvPrimarneGrupe
            // 
            dgvPrimarneGrupe.AllowUserToAddRows = false;
            dgvPrimarneGrupe.AllowUserToDeleteRows = false;
            dgvPrimarneGrupe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrimarneGrupe.BackgroundColor = Color.White;
            dgvPrimarneGrupe.BorderStyle = BorderStyle.None;
            dgvPrimarneGrupe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPrimarneGrupe.ColumnHeadersHeight = 50;
            dgvPrimarneGrupe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPrimarneGrupe.Columns.AddRange(new DataGridViewColumn[] { colId, colNaziv });
            dgvPrimarneGrupe.Dock = DockStyle.Fill;
            dgvPrimarneGrupe.GridColor = Color.FromArgb(233, 236, 239);
            dgvPrimarneGrupe.Location = new Point(20, 20);
            dgvPrimarneGrupe.MultiSelect = false;
            dgvPrimarneGrupe.Name = "dgvPrimarneGrupe";
            dgvPrimarneGrupe.ReadOnly = true;
            dgvPrimarneGrupe.RowHeadersVisible = false;
            dgvPrimarneGrupe.RowHeadersWidth = 51;
            dgvPrimarneGrupe.RowTemplate.Height = 45;
            dgvPrimarneGrupe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrimarneGrupe.Size = new Size(500, 360);
            dgvPrimarneGrupe.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(255, 255, 255);
            panelButtons.Controls.Add(btnIzmeniPrimarnuGrupu);
            panelButtons.Controls.Add(btnObrisiPrimarnuGrupu);
            panelButtons.Controls.Add(btnNovaPrimarnaGrupa);
            panelButtons.Dock = DockStyle.Right;
            panelButtons.Location = new Point(540, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(20);
            panelButtons.Size = new Size(240, 360);
            panelButtons.TabIndex = 1;
            // 
            // btnNovaPrimarnaGrupa
            // 
            btnNovaPrimarnaGrupa.BackColor = Color.FromArgb(80, 220, 140);
            btnNovaPrimarnaGrupa.FlatAppearance.BorderSize = 0;
            btnNovaPrimarnaGrupa.FlatStyle = FlatStyle.Flat;
            btnNovaPrimarnaGrupa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNovaPrimarnaGrupa.ForeColor = Color.White;
            btnNovaPrimarnaGrupa.Location = new Point(20, 20);
            btnNovaPrimarnaGrupa.Name = "btnNovaPrimarnaGrupa";
            btnNovaPrimarnaGrupa.Size = new Size(200, 50);
            btnNovaPrimarnaGrupa.TabIndex = 0;
            btnNovaPrimarnaGrupa.Text = "➕ Nova primarna grupa";
            btnNovaPrimarnaGrupa.TextAlign = ContentAlignment.MiddleCenter;
            btnNovaPrimarnaGrupa.UseVisualStyleBackColor = false;
            btnNovaPrimarnaGrupa.Click += btnNovaPrimarnaGrupa_Click;
            btnNovaPrimarnaGrupa.MouseEnter += Button_MouseEnter;
            btnNovaPrimarnaGrupa.MouseLeave += Button_MouseLeave;
            // 
            // btnObrisiPrimarnuGrupu
            // 
            btnObrisiPrimarnuGrupu.BackColor = Color.FromArgb(250, 120, 100);
            btnObrisiPrimarnuGrupu.FlatAppearance.BorderSize = 0;
            btnObrisiPrimarnuGrupu.FlatStyle = FlatStyle.Flat;
            btnObrisiPrimarnuGrupu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnObrisiPrimarnuGrupu.ForeColor = Color.White;
            btnObrisiPrimarnuGrupu.Location = new Point(20, 90);
            btnObrisiPrimarnuGrupu.Name = "btnObrisiPrimarnuGrupu";
            btnObrisiPrimarnuGrupu.Size = new Size(200, 50);
            btnObrisiPrimarnuGrupu.TabIndex = 1;
            btnObrisiPrimarnuGrupu.Text = "🗑️ Obriši primarnu grupu";
            btnObrisiPrimarnuGrupu.TextAlign = ContentAlignment.MiddleCenter;
            btnObrisiPrimarnuGrupu.UseVisualStyleBackColor = false;
            btnObrisiPrimarnuGrupu.Click += btnObrisiPrimarnuGrupu_Click;
            btnObrisiPrimarnuGrupu.MouseEnter += Button_MouseEnter;
            btnObrisiPrimarnuGrupu.MouseLeave += Button_MouseLeave;
            // 
            // btnIzmeniPrimarnuGrupu
            // 
            btnIzmeniPrimarnuGrupu.BackColor = Color.FromArgb(80, 170, 230);
            btnIzmeniPrimarnuGrupu.FlatAppearance.BorderSize = 0;
            btnIzmeniPrimarnuGrupu.FlatStyle = FlatStyle.Flat;
            btnIzmeniPrimarnuGrupu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIzmeniPrimarnuGrupu.ForeColor = Color.White;
            btnIzmeniPrimarnuGrupu.Location = new Point(20, 160);
            btnIzmeniPrimarnuGrupu.Name = "btnIzmeniPrimarnuGrupu";
            btnIzmeniPrimarnuGrupu.Size = new Size(200, 50);
            btnIzmeniPrimarnuGrupu.TabIndex = 2;
            btnIzmeniPrimarnuGrupu.Text = "✏️ Izmeni primarnu grupu";
            btnIzmeniPrimarnuGrupu.TextAlign = ContentAlignment.MiddleCenter;
            btnIzmeniPrimarnuGrupu.UseVisualStyleBackColor = false;
            btnIzmeniPrimarnuGrupu.Click += btnIzmeniPrimarnuGrupu_Click;
            btnIzmeniPrimarnuGrupu.MouseEnter += Button_MouseEnter;
            btnIzmeniPrimarnuGrupu.MouseLeave += Button_MouseLeave;
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
            lblFooter.Text = "Primarne grupe - Upravljanje primarnim grupama lekova";
            // 
            // PrimarnaGrupaForm
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
            Name = "PrimarnaGrupaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Farmacy System - Primarne Grupe";
            ((System.ComponentModel.ISupportInitialize)dgvPrimarneGrupe).EndInit();
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
