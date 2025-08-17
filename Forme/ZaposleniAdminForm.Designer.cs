namespace Farmacy.Forme
{
    partial class ZaposleniAdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxZaposleni = new GroupBox();
            dgvZaposleni = new DataGridView();
            panelDesno = new Panel();
            btnObrisiZaposlenog = new Button();
            btnIzmeniZaposlenog = new Button();
            btnDodajNovog = new Button();
            groupBoxZaposleni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvZaposleni).BeginInit();
            panelDesno.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxZaposleni
            // 
            groupBoxZaposleni.Controls.Add(dgvZaposleni);
            groupBoxZaposleni.Dock = DockStyle.Left;
            groupBoxZaposleni.Font = new Font("Segoe UI", 9F);
            groupBoxZaposleni.Location = new Point(0, 0);
            groupBoxZaposleni.Name = "groupBoxZaposleni";
            groupBoxZaposleni.Padding = new Padding(10);
            groupBoxZaposleni.Size = new Size(670, 461);
            groupBoxZaposleni.TabIndex = 0;
            groupBoxZaposleni.TabStop = false;
            groupBoxZaposleni.Text = "Zaposleni";
            groupBoxZaposleni.Enter += groupBoxZaposleni_Enter;
            // 
            // dgvZaposleni
            // 
            dgvZaposleni.AllowUserToAddRows = false;
            dgvZaposleni.AllowUserToDeleteRows = false;
            dgvZaposleni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvZaposleni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvZaposleni.Dock = DockStyle.Fill;
            dgvZaposleni.Location = new Point(10, 26);
            dgvZaposleni.MultiSelect = false;
            dgvZaposleni.Name = "dgvZaposleni";
            dgvZaposleni.ReadOnly = true;
            dgvZaposleni.RowHeadersVisible = false;
            dgvZaposleni.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvZaposleni.Size = new Size(650, 425);
            dgvZaposleni.TabIndex = 0;
           // dgvZaposleni.CellContentClick += this.dgvZaposleni_CellContentClick_1;
            // 
            // panelDesno
            // 
            panelDesno.Controls.Add(btnObrisiZaposlenog);
            panelDesno.Controls.Add(btnIzmeniZaposlenog);
            panelDesno.Controls.Add(btnDodajNovog);
            panelDesno.Dock = DockStyle.Right;
            panelDesno.Location = new Point(674, 0);
            panelDesno.Name = "panelDesno";
            panelDesno.Padding = new Padding(15);
            panelDesno.Size = new Size(230, 461);
            panelDesno.TabIndex = 1;
            //panelDesno.Paint += this.panelDesno_Paint_1;
            // 
            // btnObrisiZaposlenog
            // 
            btnObrisiZaposlenog.Dock = DockStyle.Top;
            btnObrisiZaposlenog.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnObrisiZaposlenog.Location = new Point(15, 135);
            btnObrisiZaposlenog.Margin = new Padding(0, 10, 0, 0);
            btnObrisiZaposlenog.Name = "btnObrisiZaposlenog";
            btnObrisiZaposlenog.Padding = new Padding(4);
            btnObrisiZaposlenog.Size = new Size(200, 60);
            btnObrisiZaposlenog.TabIndex = 2;
            btnObrisiZaposlenog.Text = "Obriši zaposlenog";
            btnObrisiZaposlenog.UseVisualStyleBackColor = true;
            btnObrisiZaposlenog.Click += this.btnObrisiZaposlenog_Click;
            // 
            // btnIzmeniZaposlenog
            // 
            btnIzmeniZaposlenog.Dock = DockStyle.Top;
            btnIzmeniZaposlenog.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIzmeniZaposlenog.Location = new Point(15, 75);
            btnIzmeniZaposlenog.Margin = new Padding(0, 10, 0, 0);
            btnIzmeniZaposlenog.Name = "btnIzmeniZaposlenog";
            btnIzmeniZaposlenog.Padding = new Padding(4);
            btnIzmeniZaposlenog.Size = new Size(200, 60);
            btnIzmeniZaposlenog.TabIndex = 1;
            btnIzmeniZaposlenog.Text = "Izmeni zaposlenog";
            btnIzmeniZaposlenog.UseVisualStyleBackColor = true;
            btnIzmeniZaposlenog.Click += this.btnIzmeniZaposlenog_Click;
            // 
            // btnDodajNovog
            // 
            btnDodajNovog.Dock = DockStyle.Top;
            btnDodajNovog.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDodajNovog.Location = new Point(15, 15);
            btnDodajNovog.Margin = new Padding(0, 10, 0, 0);
            btnDodajNovog.Name = "btnDodajNovog";
            btnDodajNovog.Padding = new Padding(4);
            btnDodajNovog.Size = new Size(200, 60);
            btnDodajNovog.TabIndex = 0;
            btnDodajNovog.Text = "Dodaj novog zaposlenog";
            btnDodajNovog.UseVisualStyleBackColor = true;
            btnDodajNovog.Click += this.btnDodajNovog_Click;
            // 
            // ZaposleniAdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 224, 190);
            ClientSize = new Size(904, 461);
            Controls.Add(panelDesno);
            Controls.Add(groupBoxZaposleni);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(920, 500);
            Name = "ZaposleniAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Apoteka";
            Load += ZaposleniPrikazForm_Load_1;
            groupBoxZaposleni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvZaposleni).EndInit();
            panelDesno.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxZaposleni;
        private System.Windows.Forms.DataGridView dgvZaposleni;
        private System.Windows.Forms.Panel panelDesno;
        private System.Windows.Forms.Button btnDodajNovog;
        private System.Windows.Forms.Button btnIzmeniZaposlenog;
        private System.Windows.Forms.Button btnObrisiZaposlenog;

  
        private System.Windows.Forms.DataGridViewTextBoxColumn colMbr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatumRodj;

        
    }
}