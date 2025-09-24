namespace Farmacy.Forme
{
    partial class LekAdminForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dgvLekovi;
        private System.Windows.Forms.Label lblLekovi;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnDodajNoviLek;
        private System.Windows.Forms.Button btnIzmeniLek;
        private System.Windows.Forms.Button btnObrisiLek;
        private System.Windows.Forms.Button btnOblik;
        private System.Windows.Forms.Button btnPrimarnaGrupa;
        private System.Windows.Forms.Button btnRecept;
        private System.Windows.Forms.Button btnSekundarnaGrupa;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooter;

        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHemijskiNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKomercijalniNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDejstvo;

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
            btnSekundarnaGrupa = new Button();
            btnRecept = new Button();
            btnPrimarnaGrupa = new Button();
            btnOblik = new Button();
            btnObrisiLek = new Button();
            btnIzmeniLek = new Button();
            btnDodajNoviLek = new Button();
            dgvLekovi = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colHemijskiNaziv = new DataGridViewTextBoxColumn();
            colKomercijalniNaziv = new DataGridViewTextBoxColumn();
            colDejstvo = new DataGridViewTextBoxColumn();
            lblLekovi = new Label();
            panelFooter = new Panel();
            lblFooter = new Label();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLekovi).BeginInit();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(155, 89, 182);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4, 4, 4, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1200, 120);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(220, 200, 255);
            lblSubtitle.Location = new Point(30, 70);
            lblSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(400, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Upravljanje lekovima, njihovim oblicima, grupama i receptima";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 25);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(140, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "💊 LEKOVI";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(panelButtons);
            panelMain.Controls.Add(dgvLekovi);
            panelMain.Controls.Add(lblLekovi);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 120);
            panelMain.Margin = new Padding(4, 4, 4, 4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20, 20, 20, 20);
            panelMain.Size = new Size(1200, 600);
            panelMain.TabIndex = 1;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(255, 255, 255);
            panelButtons.Controls.Add(btnSekundarnaGrupa);
            panelButtons.Controls.Add(btnRecept);
            panelButtons.Controls.Add(btnPrimarnaGrupa);
            panelButtons.Controls.Add(btnOblik);
            panelButtons.Controls.Add(btnObrisiLek);
            panelButtons.Controls.Add(btnIzmeniLek);
            panelButtons.Controls.Add(btnDodajNoviLek);
            panelButtons.Dock = DockStyle.Right;
            panelButtons.Location = new Point(800, 20);
            panelButtons.Margin = new Padding(4, 4, 4, 4);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(15, 15, 15, 15);
            panelButtons.Size = new Size(380, 560);
            panelButtons.TabIndex = 1;
            // 
            // btnSekundarnaGrupa
            // 
            btnSekundarnaGrupa.BackColor = Color.FromArgb(255, 220, 80);
            btnSekundarnaGrupa.FlatAppearance.BorderSize = 0;
            btnSekundarnaGrupa.FlatStyle = FlatStyle.Flat;
            btnSekundarnaGrupa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSekundarnaGrupa.ForeColor = Color.White;
            btnSekundarnaGrupa.Location = new Point(15, 480);
            btnSekundarnaGrupa.Margin = new Padding(4, 4, 4, 4);
            btnSekundarnaGrupa.Name = "btnSekundarnaGrupa";
            btnSekundarnaGrupa.Size = new Size(350, 50);
            btnSekundarnaGrupa.TabIndex = 11;
            btnSekundarnaGrupa.Text = "📊 Sekundarne grupe";
            btnSekundarnaGrupa.UseVisualStyleBackColor = false;
            btnSekundarnaGrupa.Click += btnSekundarnaGrupa_Click;
            btnSekundarnaGrupa.MouseEnter += Button_MouseEnter;
            btnSekundarnaGrupa.MouseLeave += Button_MouseLeave;
            // 
            // btnRecept
            // 
            btnRecept.BackColor = Color.FromArgb(170, 100, 200);
            btnRecept.FlatAppearance.BorderSize = 0;
            btnRecept.FlatStyle = FlatStyle.Flat;
            btnRecept.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRecept.ForeColor = Color.White;
            btnRecept.Location = new Point(15, 540);
            btnRecept.Margin = new Padding(4, 4, 4, 4);
            btnRecept.Name = "btnRecept";
            btnRecept.Size = new Size(350, 50);
            btnRecept.TabIndex = 10;
            btnRecept.Text = "📄 Recept";
            btnRecept.UseVisualStyleBackColor = false;
            btnRecept.Click += btnRecept_Click;
            btnRecept.MouseEnter += Button_MouseEnter;
            btnRecept.MouseLeave += Button_MouseLeave;
            // 
            // btnPrimarnaGrupa
            // 
            btnPrimarnaGrupa.BackColor = Color.FromArgb(250, 160, 80);
            btnPrimarnaGrupa.FlatAppearance.BorderSize = 0;
            btnPrimarnaGrupa.FlatStyle = FlatStyle.Flat;
            btnPrimarnaGrupa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrimarnaGrupa.ForeColor = Color.White;
            btnPrimarnaGrupa.Location = new Point(15, 300);
            btnPrimarnaGrupa.Margin = new Padding(4, 4, 4, 4);
            btnPrimarnaGrupa.Name = "btnPrimarnaGrupa";
            btnPrimarnaGrupa.Size = new Size(350, 50);
            btnPrimarnaGrupa.TabIndex = 8;
            btnPrimarnaGrupa.Text = "📋 Primarne grupe";
            btnPrimarnaGrupa.UseVisualStyleBackColor = false;
            btnPrimarnaGrupa.Click += btnPrimarnaGrupa_Click;
            btnPrimarnaGrupa.MouseEnter += Button_MouseEnter;
            btnPrimarnaGrupa.MouseLeave += Button_MouseLeave;
            // 
            // btnOblik
            // 
            btnOblik.BackColor = Color.FromArgb(80, 220, 140);
            btnOblik.FlatAppearance.BorderSize = 0;
            btnOblik.FlatStyle = FlatStyle.Flat;
            btnOblik.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnOblik.ForeColor = Color.White;
            btnOblik.Location = new Point(15, 390);
            btnOblik.Margin = new Padding(4, 4, 4, 4);
            btnOblik.Name = "btnOblik";
            btnOblik.Size = new Size(350, 50);
            btnOblik.TabIndex = 6;
            btnOblik.Text = "💊 Oblik";
            btnOblik.UseVisualStyleBackColor = false;
            btnOblik.Click += btnOblik_Click;
            btnOblik.MouseEnter += Button_MouseEnter;
            btnOblik.MouseLeave += Button_MouseLeave;
            // 
            // btnObrisiLek
            // 
            btnObrisiLek.BackColor = Color.FromArgb(250, 120, 100);
            btnObrisiLek.FlatAppearance.BorderSize = 0;
            btnObrisiLek.FlatStyle = FlatStyle.Flat;
            btnObrisiLek.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnObrisiLek.ForeColor = Color.White;
            btnObrisiLek.Location = new Point(15, 210);
            btnObrisiLek.Margin = new Padding(4, 4, 4, 4);
            btnObrisiLek.Name = "btnObrisiLek";
            btnObrisiLek.Size = new Size(350, 50);
            btnObrisiLek.TabIndex = 3;
            btnObrisiLek.Text = "🗑️ Obriši lek";
            btnObrisiLek.UseVisualStyleBackColor = false;
            btnObrisiLek.Click += btnObrisiLek_Click;
            btnObrisiLek.MouseEnter += Button_MouseEnter;
            btnObrisiLek.MouseLeave += Button_MouseLeave;
            // 
            // btnIzmeniLek
            // 
            btnIzmeniLek.BackColor = Color.FromArgb(80, 170, 230);
            btnIzmeniLek.FlatAppearance.BorderSize = 0;
            btnIzmeniLek.FlatStyle = FlatStyle.Flat;
            btnIzmeniLek.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIzmeniLek.ForeColor = Color.White;
            btnIzmeniLek.Location = new Point(15, 120);
            btnIzmeniLek.Margin = new Padding(4, 4, 4, 4);
            btnIzmeniLek.Name = "btnIzmeniLek";
            btnIzmeniLek.Size = new Size(350, 50);
            btnIzmeniLek.TabIndex = 2;
            btnIzmeniLek.Text = "✏️ Izmeni lek";
            btnIzmeniLek.UseVisualStyleBackColor = false;
            btnIzmeniLek.Click += btnIzmeniLek_Click;
            btnIzmeniLek.MouseEnter += Button_MouseEnter;
            btnIzmeniLek.MouseLeave += Button_MouseLeave;
            // 
            // btnDodajNoviLek
            // 
            btnDodajNoviLek.BackColor = Color.FromArgb(180, 120, 200);
            btnDodajNoviLek.FlatAppearance.BorderSize = 0;
            btnDodajNoviLek.FlatStyle = FlatStyle.Flat;
            btnDodajNoviLek.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDodajNoviLek.ForeColor = Color.White;
            btnDodajNoviLek.Location = new Point(15, 30);
            btnDodajNoviLek.Margin = new Padding(4, 4, 4, 4);
            btnDodajNoviLek.Name = "btnDodajNoviLek";
            btnDodajNoviLek.Size = new Size(350, 50);
            btnDodajNoviLek.TabIndex = 1;
            btnDodajNoviLek.Text = "➕ Dodaj novi lek";
            btnDodajNoviLek.UseVisualStyleBackColor = false;
            btnDodajNoviLek.Click += btnDodajNoviLek_Click;
            btnDodajNoviLek.MouseEnter += Button_MouseEnter;
            btnDodajNoviLek.MouseLeave += Button_MouseLeave;
            // 
            // dgvLekovi
            // 
            dgvLekovi.AllowUserToAddRows = false;
            dgvLekovi.AllowUserToDeleteRows = false;
            dgvLekovi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLekovi.BackgroundColor = Color.White;
            dgvLekovi.BorderStyle = BorderStyle.None;
            dgvLekovi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvLekovi.ColumnHeadersHeight = 50;
            dgvLekovi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvLekovi.Columns.AddRange(new DataGridViewColumn[] { colId, colHemijskiNaziv, colKomercijalniNaziv, colDejstvo });
            dgvLekovi.GridColor = Color.FromArgb(233, 236, 239);
            dgvLekovi.Location = new Point(20, 50);
            dgvLekovi.Margin = new Padding(4, 4, 4, 4);
            dgvLekovi.MultiSelect = false;
            dgvLekovi.Name = "dgvLekovi";
            dgvLekovi.ReadOnly = true;
            dgvLekovi.RowHeadersVisible = false;
            dgvLekovi.RowHeadersWidth = 51;
            dgvLekovi.RowTemplate.Height = 30;
            dgvLekovi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLekovi.Size = new Size(760, 530);
            dgvLekovi.TabIndex = 0;
            dgvLekovi.CellContentClick += dgvLekovi_CellContentClick;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.MinimumWidth = 10;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colHemijskiNaziv
            // 
            colHemijskiNaziv.DataPropertyName = "HemijskiNaziv";
            colHemijskiNaziv.HeaderText = "Hemijski naziv";
            colHemijskiNaziv.MinimumWidth = 10;
            colHemijskiNaziv.Name = "colHemijskiNaziv";
            colHemijskiNaziv.ReadOnly = true;
            // 
            // colKomercijalniNaziv
            // 
            colKomercijalniNaziv.DataPropertyName = "KomercijalniNaziv";
            colKomercijalniNaziv.HeaderText = "Komercijalni naziv";
            colKomercijalniNaziv.MinimumWidth = 10;
            colKomercijalniNaziv.Name = "colKomercijalniNaziv";
            colKomercijalniNaziv.ReadOnly = true;
            // 
            // colDejstvo
            // 
            colDejstvo.DataPropertyName = "Dejstvo";
            colDejstvo.HeaderText = "Dejstvo";
            colDejstvo.MinimumWidth = 10;
            colDejstvo.Name = "colDejstvo";
            colDejstvo.ReadOnly = true;
            // 
            // lblLekovi
            // 
            lblLekovi.AutoSize = true;
            lblLekovi.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLekovi.ForeColor = Color.FromArgb(33, 37, 41);
            lblLekovi.Location = new Point(20, 20);
            lblLekovi.Margin = new Padding(4, 0, 4, 0);
            lblLekovi.Name = "lblLekovi";
            lblLekovi.Size = new Size(80, 32);
            lblLekovi.TabIndex = 16;
            lblLekovi.Text = "Lekovi";
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(44, 62, 80);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 720);
            panelFooter.Margin = new Padding(4, 4, 4, 4);
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
            lblFooter.Margin = new Padding(4, 0, 4, 0);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(400, 20);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Lekovi - Upravljanje lekovima, oblicima, grupama i receptima";
            // 
            // LekAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 800);
            Controls.Add(panelMain);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.Sizable;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = true;
            MinimumSize = new Size(1000, 700);
            Name = "LekAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farmacy System - Lekovi";
            Load += LekAdminForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLekovi).EndInit();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }
    }
}
