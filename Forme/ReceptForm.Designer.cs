namespace Farmacy.Forme
{
    partial class ReceptForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dgvRecepti;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnNoviRecept;
        private System.Windows.Forms.Button btnObrisiRecept;
        private System.Windows.Forms.Button btnIzmeniRecept;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.Button btnRealizujRecept;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooter;

        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerijskiBroj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSifraLekara;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatumIzd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNazivUstanove;

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
            dgvRecepti = new DataGridView();
            panelButtons = new Panel();
            btnNoviRecept = new Button();
            btnObrisiRecept = new Button();
            btnIzmeniRecept = new Button();
            btnDodajStavku = new Button();
            btnRealizujRecept = new Button();
            panelFooter = new Panel();
            lblFooter = new Label();
            colId = new DataGridViewTextBoxColumn();
            colSerijskiBroj = new DataGridViewTextBoxColumn();
            colSifraLekara = new DataGridViewTextBoxColumn();
            colDatumIzd = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colNazivUstanove = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRecepti).BeginInit();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(170, 100, 200);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1000, 100);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📄 RECEPTI";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(200, 150, 220);
            lblSubtitle.Location = new Point(20, 60);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(400, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Upravljanje receptima i njihovim stavkama";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(panelButtons);
            panelMain.Controls.Add(dgvRecepti);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 100);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(1000, 500);
            panelMain.TabIndex = 1;
            // 
            // dgvRecepti
            // 
            dgvRecepti.AllowUserToAddRows = false;
            dgvRecepti.AllowUserToDeleteRows = false;
            dgvRecepti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecepti.BackgroundColor = Color.White;
            dgvRecepti.BorderStyle = BorderStyle.None;
            dgvRecepti.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRecepti.ColumnHeadersHeight = 50;
            dgvRecepti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRecepti.Columns.AddRange(new DataGridViewColumn[] { colId, colSerijskiBroj, colSifraLekara, colDatumIzd, colStatus, colNazivUstanove });
            dgvRecepti.Dock = DockStyle.Fill;
            dgvRecepti.GridColor = Color.FromArgb(233, 236, 239);
            dgvRecepti.Location = new Point(20, 20);
            dgvRecepti.MultiSelect = false;
            dgvRecepti.Name = "dgvRecepti";
            dgvRecepti.ReadOnly = true;
            dgvRecepti.RowHeadersVisible = false;
            dgvRecepti.RowHeadersWidth = 51;
            dgvRecepti.RowTemplate.Height = 45;
            dgvRecepti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecepti.Size = new Size(700, 460);
            dgvRecepti.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(255, 255, 255);
            panelButtons.Controls.Add(btnRealizujRecept);
            panelButtons.Controls.Add(btnDodajStavku);
            panelButtons.Controls.Add(btnIzmeniRecept);
            panelButtons.Controls.Add(btnObrisiRecept);
            panelButtons.Controls.Add(btnNoviRecept);
            panelButtons.Dock = DockStyle.Right;
            panelButtons.Location = new Point(740, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(20);
            panelButtons.Size = new Size(240, 460);
            panelButtons.TabIndex = 1;
            // 
            // btnNoviRecept
            // 
            btnNoviRecept.BackColor = Color.FromArgb(80, 220, 140);
            btnNoviRecept.FlatAppearance.BorderSize = 0;
            btnNoviRecept.FlatStyle = FlatStyle.Flat;
            btnNoviRecept.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNoviRecept.ForeColor = Color.White;
            btnNoviRecept.Location = new Point(20, 20);
            btnNoviRecept.Name = "btnNoviRecept";
            btnNoviRecept.Size = new Size(200, 50);
            btnNoviRecept.TabIndex = 0;
            btnNoviRecept.Text = "➕ Novi recept";
            btnNoviRecept.TextAlign = ContentAlignment.MiddleCenter;
            btnNoviRecept.UseVisualStyleBackColor = false;
            btnNoviRecept.Click += btnNoviRecept_Click;
            btnNoviRecept.MouseEnter += Button_MouseEnter;
            btnNoviRecept.MouseLeave += Button_MouseLeave;
            // 
            // btnObrisiRecept
            // 
            btnObrisiRecept.BackColor = Color.FromArgb(250, 120, 100);
            btnObrisiRecept.FlatAppearance.BorderSize = 0;
            btnObrisiRecept.FlatStyle = FlatStyle.Flat;
            btnObrisiRecept.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnObrisiRecept.ForeColor = Color.White;
            btnObrisiRecept.Location = new Point(20, 90);
            btnObrisiRecept.Name = "btnObrisiRecept";
            btnObrisiRecept.Size = new Size(200, 50);
            btnObrisiRecept.TabIndex = 1;
            btnObrisiRecept.Text = "🗑️ Obriši recept";
            btnObrisiRecept.TextAlign = ContentAlignment.MiddleCenter;
            btnObrisiRecept.UseVisualStyleBackColor = false;
            btnObrisiRecept.Click += btnObrisiRecept_Click;
            btnObrisiRecept.MouseEnter += Button_MouseEnter;
            btnObrisiRecept.MouseLeave += Button_MouseLeave;
            // 
            // btnIzmeniRecept
            // 
            btnIzmeniRecept.BackColor = Color.FromArgb(80, 170, 230);
            btnIzmeniRecept.FlatAppearance.BorderSize = 0;
            btnIzmeniRecept.FlatStyle = FlatStyle.Flat;
            btnIzmeniRecept.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIzmeniRecept.ForeColor = Color.White;
            btnIzmeniRecept.Location = new Point(20, 160);
            btnIzmeniRecept.Name = "btnIzmeniRecept";
            btnIzmeniRecept.Size = new Size(200, 50);
            btnIzmeniRecept.TabIndex = 2;
            btnIzmeniRecept.Text = "✏️ Izmeni recept";
            btnIzmeniRecept.TextAlign = ContentAlignment.MiddleCenter;
            btnIzmeniRecept.UseVisualStyleBackColor = false;
            btnIzmeniRecept.Click += btnIzmeniRecept_Click;
            btnIzmeniRecept.MouseEnter += Button_MouseEnter;
            btnIzmeniRecept.MouseLeave += Button_MouseLeave;
            // 
            // btnDodajStavku
            // 
            btnDodajStavku.BackColor = Color.FromArgb(250, 160, 80);
            btnDodajStavku.FlatAppearance.BorderSize = 0;
            btnDodajStavku.FlatStyle = FlatStyle.Flat;
            btnDodajStavku.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDodajStavku.ForeColor = Color.White;
            btnDodajStavku.Location = new Point(20, 230);
            btnDodajStavku.Name = "btnDodajStavku";
            btnDodajStavku.Size = new Size(200, 50);
            btnDodajStavku.TabIndex = 3;
            btnDodajStavku.Text = "➕ Dodaj stavku";
            btnDodajStavku.TextAlign = ContentAlignment.MiddleCenter;
            btnDodajStavku.UseVisualStyleBackColor = false;
            btnDodajStavku.Click += btnDodajStavku_Click;
            btnDodajStavku.MouseEnter += Button_MouseEnter;
            btnDodajStavku.MouseLeave += Button_MouseLeave;
            // 
            // btnRealizujRecept
            // 
            btnRealizujRecept.BackColor = Color.FromArgb(46, 204, 113);
            btnRealizujRecept.FlatAppearance.BorderSize = 0;
            btnRealizujRecept.FlatStyle = FlatStyle.Flat;
            btnRealizujRecept.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRealizujRecept.ForeColor = Color.White;
            btnRealizujRecept.Location = new Point(20, 300);
            btnRealizujRecept.Name = "btnRealizujRecept";
            btnRealizujRecept.Size = new Size(200, 50);
            btnRealizujRecept.TabIndex = 4;
            btnRealizujRecept.Text = "✅ Realizuj recept";
            btnRealizujRecept.TextAlign = ContentAlignment.MiddleCenter;
            btnRealizujRecept.UseVisualStyleBackColor = false;
            btnRealizujRecept.Click += btnRealizujRecept_Click;
            btnRealizujRecept.MouseEnter += Button_MouseEnter;
            btnRealizujRecept.MouseLeave += Button_MouseLeave;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 60;
            // 
            // colSerijskiBroj
            // 
            colSerijskiBroj.DataPropertyName = "SerijskiBroj";
            colSerijskiBroj.HeaderText = "Serijski broj";
            colSerijskiBroj.Name = "colSerijskiBroj";
            colSerijskiBroj.ReadOnly = true;
            colSerijskiBroj.Width = 120;
            // 
            // colSifraLekara
            // 
            colSifraLekara.DataPropertyName = "SifraLekara";
            colSifraLekara.HeaderText = "Šifra lekara";
            colSifraLekara.Name = "colSifraLekara";
            colSifraLekara.ReadOnly = true;
            colSifraLekara.Width = 100;
            // 
            // colDatumIzd
            // 
            colDatumIzd.DataPropertyName = "DatumIzd";
            colDatumIzd.HeaderText = "Datum izdavanja";
            colDatumIzd.Name = "colDatumIzd";
            colDatumIzd.ReadOnly = true;
            colDatumIzd.Width = 120;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 80;
            // 
            // colNazivUstanove
            // 
            colNazivUstanove.DataPropertyName = "NazivUstanove";
            colNazivUstanove.HeaderText = "Naziv ustanove";
            colNazivUstanove.Name = "colNazivUstanove";
            colNazivUstanove.ReadOnly = true;
            colNazivUstanove.Width = 200;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(44, 62, 80);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 600);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1000, 30);
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
            lblFooter.Text = "Recepti - Upravljanje receptima i njihovim stavkama";
            // 
            // ReceptForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 630);
            Controls.Add(panelMain);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ReceptForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Farmacy System - Recepti";
            ((System.ComponentModel.ISupportInitialize)dgvRecepti).EndInit();
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






