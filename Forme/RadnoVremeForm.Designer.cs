namespace Farmacy.Forme
{
    partial class RadnoVremeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            panelMain = new Panel();
            btnCancel = new Button();
            btnIzmeni = new Button();
            dgvRadnoVreme = new DataGridView();
            txtProdajnaJedinica = new TextBox();
            lblProdajnaJedinica = new Label();
            panelFooter = new Panel();
            lblFooter = new Label();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRadnoVreme).BeginInit();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(155, 89, 182);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1064, 104);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(3, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(410, 59);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🕐 RADNO VREME";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(189, 195, 199);
            lblSubtitle.Location = new Point(20, 59);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(485, 37);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Pregled i upravljanje radnim vremenom";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(btnCancel);
            panelMain.Controls.Add(btnIzmeni);
            panelMain.Controls.Add(dgvRadnoVreme);
            panelMain.Controls.Add(txtProdajnaJedinica);
            panelMain.Controls.Add(lblProdajnaJedinica);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 104);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(1064, 664);
            panelMain.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(341, 612);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "❌ Otkaži";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.BackColor = Color.FromArgb(155, 89, 182);
            btnIzmeni.FlatAppearance.BorderSize = 0;
            btnIzmeni.FlatStyle = FlatStyle.Flat;
            btnIzmeni.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIzmeni.ForeColor = Color.White;
            btnIzmeni.Location = new Point(197, 612);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(120, 40);
            btnIzmeni.TabIndex = 3;
            btnIzmeni.Text = "✏️ Izmeni";
            btnIzmeni.UseVisualStyleBackColor = false;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // dgvRadnoVreme
            // 
            dgvRadnoVreme.AllowUserToAddRows = false;
            dgvRadnoVreme.AllowUserToDeleteRows = false;
            dgvRadnoVreme.BackgroundColor = Color.White;
            dgvRadnoVreme.BorderStyle = BorderStyle.None;
            dgvRadnoVreme.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRadnoVreme.GridColor = Color.FromArgb(233, 236, 239);
            dgvRadnoVreme.Location = new Point(33, 137);
            dgvRadnoVreme.MultiSelect = false;
            dgvRadnoVreme.Name = "dgvRadnoVreme";
            dgvRadnoVreme.ReadOnly = true;
            dgvRadnoVreme.RowHeadersVisible = false;
            dgvRadnoVreme.RowHeadersWidth = 82;
            dgvRadnoVreme.RowTemplate.Height = 30;
            dgvRadnoVreme.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRadnoVreme.Size = new Size(692, 453);
            dgvRadnoVreme.TabIndex = 2;
            // 
            // txtProdajnaJedinica
            // 
            txtProdajnaJedinica.BackColor = Color.White;
            txtProdajnaJedinica.BorderStyle = BorderStyle.FixedSingle;
            txtProdajnaJedinica.Font = new Font("Segoe UI", 10F);
            txtProdajnaJedinica.Location = new Point(313, 58);
            txtProdajnaJedinica.Name = "txtProdajnaJedinica";
            txtProdajnaJedinica.ReadOnly = true;
            txtProdajnaJedinica.Size = new Size(300, 43);
            txtProdajnaJedinica.TabIndex = 1;
            txtProdajnaJedinica.TabStop = false;
            // 
            // lblProdajnaJedinica
            // 
            lblProdajnaJedinica.AutoSize = true;
            lblProdajnaJedinica.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProdajnaJedinica.ForeColor = Color.FromArgb(44, 62, 80);
            lblProdajnaJedinica.Location = new Point(50, 60);
            lblProdajnaJedinica.Name = "lblProdajnaJedinica";
            lblProdajnaJedinica.Size = new Size(247, 37);
            lblProdajnaJedinica.TabIndex = 0;
            lblProdajnaJedinica.Text = "Prodajna jedinica:";
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(44, 62, 80);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 768);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1064, 30);
            panelFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 8F);
            lblFooter.ForeColor = Color.FromArgb(189, 195, 199);
            lblFooter.Location = new Point(20, 8);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(463, 30);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Sistem za upravljanje farmaceutskim podacima";
            // 
            // RadnoVremeForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1064, 798);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Controls.Add(panelFooter);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RadnoVremeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Radno Vreme - Pregled i upravljanje";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRadnoVreme).EndInit();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label lblProdajnaJedinica;
        private System.Windows.Forms.TextBox txtProdajnaJedinica;
        private System.Windows.Forms.DataGridView dgvRadnoVreme;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnCancel;
    }
}
