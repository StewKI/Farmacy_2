namespace Farmacy.Forme
{
    partial class OblikForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dgvOblik;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnNoviOblik;
        private System.Windows.Forms.Button btnObrisiOblik;
        private System.Windows.Forms.Button btnIzmeniOblik;
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
            dgvOblik = new DataGridView();
            panelButtons = new Panel();
            btnNoviOblik = new Button();
            btnObrisiOblik = new Button();
            btnIzmeniOblik = new Button();
            panelFooter = new Panel();
            lblFooter = new Label();
            colId = new DataGridViewTextBoxColumn();
            colNaziv = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvOblik).BeginInit();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(80, 220, 140);
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
            lblTitle.Size = new Size(250, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "💊 OBLICI LEKOVA";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(200, 250, 200);
            lblSubtitle.Location = new Point(20, 60);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(400, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Upravljanje oblicima lekova (tablete, kapsule, sirup, itd.)";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(panelButtons);
            panelMain.Controls.Add(dgvOblik);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 100);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(800, 400);
            panelMain.TabIndex = 1;
            // 
            // dgvOblik
            // 
            dgvOblik.AllowUserToAddRows = false;
            dgvOblik.AllowUserToDeleteRows = false;
            dgvOblik.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOblik.BackgroundColor = Color.White;
            dgvOblik.BorderStyle = BorderStyle.None;
            dgvOblik.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvOblik.ColumnHeadersHeight = 50;
            dgvOblik.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvOblik.Columns.AddRange(new DataGridViewColumn[] { colId, colNaziv });
            dgvOblik.Dock = DockStyle.Fill;
            dgvOblik.GridColor = Color.FromArgb(233, 236, 239);
            dgvOblik.Location = new Point(20, 20);
            dgvOblik.MultiSelect = false;
            dgvOblik.Name = "dgvOblik";
            dgvOblik.ReadOnly = true;
            dgvOblik.RowHeadersVisible = false;
            dgvOblik.RowHeadersWidth = 51;
            dgvOblik.RowTemplate.Height = 45;
            dgvOblik.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOblik.Size = new Size(500, 360);
            dgvOblik.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(255, 255, 255);
            panelButtons.Controls.Add(btnIzmeniOblik);
            panelButtons.Controls.Add(btnObrisiOblik);
            panelButtons.Controls.Add(btnNoviOblik);
            panelButtons.Dock = DockStyle.Right;
            panelButtons.Location = new Point(540, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(20);
            panelButtons.Size = new Size(240, 360);
            panelButtons.TabIndex = 1;
            // 
            // btnNoviOblik
            // 
            btnNoviOblik.BackColor = Color.FromArgb(80, 220, 140);
            btnNoviOblik.FlatAppearance.BorderSize = 0;
            btnNoviOblik.FlatStyle = FlatStyle.Flat;
            btnNoviOblik.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNoviOblik.ForeColor = Color.White;
            btnNoviOblik.Location = new Point(20, 20);
            btnNoviOblik.Name = "btnNoviOblik";
            btnNoviOblik.Size = new Size(200, 50);
            btnNoviOblik.TabIndex = 0;
            btnNoviOblik.Text = "➕ Novi oblik";
            btnNoviOblik.TextAlign = ContentAlignment.MiddleCenter;
            btnNoviOblik.UseVisualStyleBackColor = false;
            btnNoviOblik.Click += btnNoviOblik_Click;
            btnNoviOblik.MouseEnter += Button_MouseEnter;
            btnNoviOblik.MouseLeave += Button_MouseLeave;
            // 
            // btnObrisiOblik
            // 
            btnObrisiOblik.BackColor = Color.FromArgb(250, 120, 100);
            btnObrisiOblik.FlatAppearance.BorderSize = 0;
            btnObrisiOblik.FlatStyle = FlatStyle.Flat;
            btnObrisiOblik.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnObrisiOblik.ForeColor = Color.White;
            btnObrisiOblik.Location = new Point(20, 90);
            btnObrisiOblik.Name = "btnObrisiOblik";
            btnObrisiOblik.Size = new Size(200, 50);
            btnObrisiOblik.TabIndex = 1;
            btnObrisiOblik.Text = "🗑️ Obriši oblik";
            btnObrisiOblik.TextAlign = ContentAlignment.MiddleCenter;
            btnObrisiOblik.UseVisualStyleBackColor = false;
            btnObrisiOblik.Click += btnObrisiOblik_Click;
            btnObrisiOblik.MouseEnter += Button_MouseEnter;
            btnObrisiOblik.MouseLeave += Button_MouseLeave;
            // 
            // btnIzmeniOblik
            // 
            btnIzmeniOblik.BackColor = Color.FromArgb(80, 170, 230);
            btnIzmeniOblik.FlatAppearance.BorderSize = 0;
            btnIzmeniOblik.FlatStyle = FlatStyle.Flat;
            btnIzmeniOblik.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIzmeniOblik.ForeColor = Color.White;
            btnIzmeniOblik.Location = new Point(20, 160);
            btnIzmeniOblik.Name = "btnIzmeniOblik";
            btnIzmeniOblik.Size = new Size(200, 50);
            btnIzmeniOblik.TabIndex = 2;
            btnIzmeniOblik.Text = "✏️ Izmeni oblik";
            btnIzmeniOblik.TextAlign = ContentAlignment.MiddleCenter;
            btnIzmeniOblik.UseVisualStyleBackColor = false;
            btnIzmeniOblik.Click += btnIzmeniOblik_Click;
            btnIzmeniOblik.MouseEnter += Button_MouseEnter;
            btnIzmeniOblik.MouseLeave += Button_MouseLeave;
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
            lblFooter.Text = "Oblici lekova - Upravljanje oblicima lekova";
            // 
            // OblikForm
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
            Name = "OblikForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Farmacy System - Oblici Lekova";
            ((System.ComponentModel.ISupportInitialize)dgvOblik).EndInit();
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