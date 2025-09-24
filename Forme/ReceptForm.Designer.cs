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
            lblSubtitle = new Label();
            lblTitle = new Label();
            panelMain = new Panel();
            panelButtons = new Panel();
            btnRealizujRecept = new Button();
            btnDodajStavku = new Button();
            btnIzmeniRecept = new Button();
            btnObrisiRecept = new Button();
            btnNoviRecept = new Button();
            dgvRecepti = new DataGridView();
            colSerijskiBroj = new DataGridViewTextBoxColumn();
            colSifraLekara = new DataGridViewTextBoxColumn();
            colDatumIzd = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colNazivUstanove = new DataGridViewTextBoxColumn();
            panelFooter = new Panel();
            lblFooter = new Label();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecepti).BeginInit();
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
            panelHeader.Margin = new Padding(5);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(2294, 160);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(200, 150, 220);
            lblSubtitle.Location = new Point(32, 96);
            lblSubtitle.Margin = new Padding(5, 0, 5, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(519, 37);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Upravljanje receptima i njihovim stavkama";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(32, 32);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(317, 72);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📄 RECEPTI";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(dgvRecepti);
            panelMain.Controls.Add(panelButtons);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 160);
            panelMain.Margin = new Padding(5);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(32);
            panelMain.Size = new Size(2294, 800);
            panelMain.TabIndex = 1;
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
            panelButtons.Location = new Point(1899, 32);
            panelButtons.Margin = new Padding(5);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(32);
            panelButtons.Size = new Size(363, 736);
            panelButtons.TabIndex = 1;
            // 
            // btnRealizujRecept
            // 
            btnRealizujRecept.BackColor = Color.FromArgb(46, 204, 113);
            btnRealizujRecept.FlatAppearance.BorderSize = 0;
            btnRealizujRecept.FlatStyle = FlatStyle.Flat;
            btnRealizujRecept.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRealizujRecept.ForeColor = Color.White;
            btnRealizujRecept.Location = new Point(32, 480);
            btnRealizujRecept.Margin = new Padding(5);
            btnRealizujRecept.Name = "btnRealizujRecept";
            btnRealizujRecept.Size = new Size(325, 80);
            btnRealizujRecept.TabIndex = 4;
            btnRealizujRecept.Text = "✅ Realizuj recept";
            btnRealizujRecept.UseVisualStyleBackColor = false;
            btnRealizujRecept.Click += btnRealizujRecept_Click;
            btnRealizujRecept.MouseEnter += Button_MouseEnter;
            btnRealizujRecept.MouseLeave += Button_MouseLeave;
            // 
            // btnDodajStavku
            // 
            btnDodajStavku.BackColor = Color.FromArgb(250, 160, 80);
            btnDodajStavku.FlatAppearance.BorderSize = 0;
            btnDodajStavku.FlatStyle = FlatStyle.Flat;
            btnDodajStavku.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDodajStavku.ForeColor = Color.White;
            btnDodajStavku.Location = new Point(32, 368);
            btnDodajStavku.Margin = new Padding(5);
            btnDodajStavku.Name = "btnDodajStavku";
            btnDodajStavku.Size = new Size(325, 80);
            btnDodajStavku.TabIndex = 3;
            btnDodajStavku.Text = "➕ Dodaj stavku";
            btnDodajStavku.UseVisualStyleBackColor = false;
            btnDodajStavku.Click += btnDodajStavku_Click;
            btnDodajStavku.MouseEnter += Button_MouseEnter;
            btnDodajStavku.MouseLeave += Button_MouseLeave;
            // 
            // btnIzmeniRecept
            // 
            btnIzmeniRecept.BackColor = Color.FromArgb(80, 170, 230);
            btnIzmeniRecept.FlatAppearance.BorderSize = 0;
            btnIzmeniRecept.FlatStyle = FlatStyle.Flat;
            btnIzmeniRecept.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIzmeniRecept.ForeColor = Color.White;
            btnIzmeniRecept.Location = new Point(32, 256);
            btnIzmeniRecept.Margin = new Padding(5);
            btnIzmeniRecept.Name = "btnIzmeniRecept";
            btnIzmeniRecept.Size = new Size(325, 80);
            btnIzmeniRecept.TabIndex = 2;
            btnIzmeniRecept.Text = "✏️ Izmeni recept";
            btnIzmeniRecept.UseVisualStyleBackColor = false;
            btnIzmeniRecept.Click += btnIzmeniRecept_Click;
            btnIzmeniRecept.MouseEnter += Button_MouseEnter;
            btnIzmeniRecept.MouseLeave += Button_MouseLeave;
            // 
            // btnObrisiRecept
            // 
            btnObrisiRecept.BackColor = Color.FromArgb(250, 120, 100);
            btnObrisiRecept.FlatAppearance.BorderSize = 0;
            btnObrisiRecept.FlatStyle = FlatStyle.Flat;
            btnObrisiRecept.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnObrisiRecept.ForeColor = Color.White;
            btnObrisiRecept.Location = new Point(32, 144);
            btnObrisiRecept.Margin = new Padding(5);
            btnObrisiRecept.Name = "btnObrisiRecept";
            btnObrisiRecept.Size = new Size(325, 80);
            btnObrisiRecept.TabIndex = 1;
            btnObrisiRecept.Text = "🗑️ Obriši recept";
            btnObrisiRecept.UseVisualStyleBackColor = false;
            btnObrisiRecept.Click += btnObrisiRecept_Click;
            btnObrisiRecept.MouseEnter += Button_MouseEnter;
            btnObrisiRecept.MouseLeave += Button_MouseLeave;
            // 
            // btnNoviRecept
            // 
            btnNoviRecept.BackColor = Color.FromArgb(80, 220, 140);
            btnNoviRecept.FlatAppearance.BorderSize = 0;
            btnNoviRecept.FlatStyle = FlatStyle.Flat;
            btnNoviRecept.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNoviRecept.ForeColor = Color.White;
            btnNoviRecept.Location = new Point(32, 32);
            btnNoviRecept.Margin = new Padding(5);
            btnNoviRecept.Name = "btnNoviRecept";
            btnNoviRecept.Size = new Size(325, 80);
            btnNoviRecept.TabIndex = 0;
            btnNoviRecept.Text = "➕ Novi recept";
            btnNoviRecept.UseVisualStyleBackColor = false;
            btnNoviRecept.Click += btnNoviRecept_Click;
            btnNoviRecept.MouseEnter += Button_MouseEnter;
            btnNoviRecept.MouseLeave += Button_MouseLeave;
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
            dgvRecepti.Columns.AddRange(new DataGridViewColumn[] { colSerijskiBroj, colSifraLekara, colDatumIzd, colStatus, colNazivUstanove });
            dgvRecepti.Dock = DockStyle.Fill;
            dgvRecepti.GridColor = Color.FromArgb(233, 236, 239);
            dgvRecepti.Margin = new Padding(5);
            dgvRecepti.MultiSelect = false;
            dgvRecepti.Name = "dgvRecepti";
            dgvRecepti.ReadOnly = true;
            dgvRecepti.RowHeadersVisible = false;
            dgvRecepti.RowHeadersWidth = 51;
            dgvRecepti.RowTemplate.Height = 45;
            dgvRecepti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecepti.TabIndex = 0;
            // 
            // colSerijskiBroj
            // 
            colSerijskiBroj.DataPropertyName = "SerijskiBroj";
            colSerijskiBroj.HeaderText = "Serijski broj";
            colSerijskiBroj.MinimumWidth = 10;
            colSerijskiBroj.Name = "colSerijskiBroj";
            colSerijskiBroj.ReadOnly = true;
            // 
            // colSifraLekara
            // 
            colSifraLekara.DataPropertyName = "SifraLekara";
            colSifraLekara.HeaderText = "Šifra lekara";
            colSifraLekara.MinimumWidth = 10;
            colSifraLekara.Name = "colSifraLekara";
            colSifraLekara.ReadOnly = true;
            // 
            // colDatumIzd
            // 
            colDatumIzd.DataPropertyName = "DatumIzd";
            colDatumIzd.HeaderText = "Datum izdavanja";
            colDatumIzd.MinimumWidth = 10;
            colDatumIzd.Name = "colDatumIzd";
            colDatumIzd.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 10;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colNazivUstanove
            // 
            colNazivUstanove.DataPropertyName = "NazivUstanove";
            colNazivUstanove.HeaderText = "Naziv ustanove";
            colNazivUstanove.MinimumWidth = 10;
            colNazivUstanove.Name = "colNazivUstanove";
            colNazivUstanove.ReadOnly = true;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(44, 62, 80);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 960);
            panelFooter.Margin = new Padding(5);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(2294, 48);
            panelFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 8F);
            lblFooter.ForeColor = Color.FromArgb(189, 195, 199);
            lblFooter.Location = new Point(32, 13);
            lblFooter.Margin = new Padding(5, 0, 5, 0);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(511, 30);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Recepti - Upravljanje receptima i njihovim stavkama";
            // 
            // ReceptForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2294, 1008);
            Controls.Add(panelMain);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "ReceptForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Farmacy System - Recepti";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecepti).EndInit();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }
    }
}





