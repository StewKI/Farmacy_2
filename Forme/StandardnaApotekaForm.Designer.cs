namespace Farmacy.Forme
{
    partial class StandardnaApotekaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Header panel and labels
        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelMain;
        private Panel panelFooter;
        private Label lblFooter;

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
            lblNaziv = new Label();
            txtNaziv = new TextBox();
            lblUlica = new Label();
            txtUlica = new TextBox();
            lblBroj = new Label();
            txtBroj = new TextBox();
            lblPostanskiBroj = new Label();
            txtPostanskiBroj = new TextBox();
            lblMesto = new Label();
            txtMesto = new TextBox();
            lblOdgovorniFarmaceut = new Label();
            lblNapomena = new Label();
            txtNapomena = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            comboBox1 = new ComboBox();
            panelFooter = new Panel();
            lblFooter = new Label();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(52, 152, 219);
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
            lblTitle.Size = new Size(380, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🏥 STANDARDNA APOTEKA";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(200, 220, 255);
            lblSubtitle.Location = new Point(20, 60);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(300, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Dodavanje ili izmena standardne apoteke";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(btnCancel);
            panelMain.Controls.Add(btnSave);
            panelMain.Controls.Add(txtNapomena);
            panelMain.Controls.Add(lblNapomena);
            panelMain.Controls.Add(comboBox1);
            panelMain.Controls.Add(lblOdgovorniFarmaceut);
            panelMain.Controls.Add(txtMesto);
            panelMain.Controls.Add(lblMesto);
            panelMain.Controls.Add(txtPostanskiBroj);
            panelMain.Controls.Add(lblPostanskiBroj);
            panelMain.Controls.Add(txtBroj);
            panelMain.Controls.Add(lblBroj);
            panelMain.Controls.Add(txtUlica);
            panelMain.Controls.Add(lblUlica);
            panelMain.Controls.Add(txtNaziv);
            panelMain.Controls.Add(lblNaziv);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 100);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(30);
            panelMain.Size = new Size(800, 500);
            panelMain.TabIndex = 1;
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNaziv.ForeColor = Color.FromArgb(33, 37, 41);
            lblNaziv.Location = new Point(30, 30);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(51, 19);
            lblNaziv.TabIndex = 2;
            lblNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            txtNaziv.BackColor = Color.White;
            txtNaziv.BorderStyle = BorderStyle.FixedSingle;
            txtNaziv.Font = new Font("Segoe UI", 10F);
            txtNaziv.Location = new Point(250, 27);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(300, 25);
            txtNaziv.TabIndex = 3;
            // 
            // lblUlica
            // 
            lblUlica.AutoSize = true;
            lblUlica.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUlica.ForeColor = Color.FromArgb(33, 37, 41);
            lblUlica.Location = new Point(30, 70);
            lblUlica.Name = "lblUlica";
            lblUlica.Size = new Size(46, 19);
            lblUlica.TabIndex = 4;
            lblUlica.Text = "Ulica:";
            // 
            // txtUlica
            // 
            txtUlica.BackColor = Color.White;
            txtUlica.BorderStyle = BorderStyle.FixedSingle;
            txtUlica.Font = new Font("Segoe UI", 10F);
            txtUlica.Location = new Point(250, 67);
            txtUlica.Name = "txtUlica";
            txtUlica.Size = new Size(300, 25);
            txtUlica.TabIndex = 5;
            // 
            // lblBroj
            // 
            lblBroj.AutoSize = true;
            lblBroj.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBroj.ForeColor = Color.FromArgb(33, 37, 41);
            lblBroj.Location = new Point(30, 110);
            lblBroj.Name = "lblBroj";
            lblBroj.Size = new Size(39, 19);
            lblBroj.TabIndex = 6;
            lblBroj.Text = "Broj:";
            // 
            // txtBroj
            // 
            txtBroj.BackColor = Color.White;
            txtBroj.BorderStyle = BorderStyle.FixedSingle;
            txtBroj.Font = new Font("Segoe UI", 10F);
            txtBroj.Location = new Point(250, 107);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(300, 25);
            txtBroj.TabIndex = 7;
            // 
            // lblPostanskiBroj
            // 
            lblPostanskiBroj.AutoSize = true;
            lblPostanskiBroj.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPostanskiBroj.ForeColor = Color.FromArgb(33, 37, 41);
            lblPostanskiBroj.Location = new Point(30, 150);
            lblPostanskiBroj.Name = "lblPostanskiBroj";
            lblPostanskiBroj.Size = new Size(107, 19);
            lblPostanskiBroj.TabIndex = 8;
            lblPostanskiBroj.Text = "Poštanski broj:";
            // 
            // txtPostanskiBroj
            // 
            txtPostanskiBroj.BackColor = Color.White;
            txtPostanskiBroj.BorderStyle = BorderStyle.FixedSingle;
            txtPostanskiBroj.Font = new Font("Segoe UI", 10F);
            txtPostanskiBroj.Location = new Point(250, 147);
            txtPostanskiBroj.Name = "txtPostanskiBroj";
            txtPostanskiBroj.Size = new Size(300, 25);
            txtPostanskiBroj.TabIndex = 9;
            // 
            // lblMesto
            // 
            lblMesto.AutoSize = true;
            lblMesto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMesto.ForeColor = Color.FromArgb(33, 37, 41);
            lblMesto.Location = new Point(30, 190);
            lblMesto.Name = "lblMesto";
            lblMesto.Size = new Size(54, 19);
            lblMesto.TabIndex = 10;
            lblMesto.Text = "Mesto:";
            // 
            // txtMesto
            // 
            txtMesto.BackColor = Color.White;
            txtMesto.BorderStyle = BorderStyle.FixedSingle;
            txtMesto.Font = new Font("Segoe UI", 10F);
            txtMesto.Location = new Point(250, 187);
            txtMesto.Name = "txtMesto";
            txtMesto.Size = new Size(300, 25);
            txtMesto.TabIndex = 11;
            // 
            // lblOdgovorniFarmaceut
            // 
            lblOdgovorniFarmaceut.AutoSize = true;
            lblOdgovorniFarmaceut.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOdgovorniFarmaceut.ForeColor = Color.FromArgb(33, 37, 41);
            lblOdgovorniFarmaceut.Location = new Point(30, 230);
            lblOdgovorniFarmaceut.Name = "lblOdgovorniFarmaceut";
            lblOdgovorniFarmaceut.Size = new Size(160, 19);
            lblOdgovorniFarmaceut.TabIndex = 12;
            lblOdgovorniFarmaceut.Text = "Odgovorni farmaceut:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(250, 227);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 25);
            comboBox1.TabIndex = 18;
            // 
            // lblNapomena
            // 
            lblNapomena.AutoSize = true;
            lblNapomena.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNapomena.ForeColor = Color.FromArgb(33, 37, 41);
            lblNapomena.Location = new Point(30, 270);
            lblNapomena.Name = "lblNapomena";
            lblNapomena.Size = new Size(88, 19);
            lblNapomena.TabIndex = 14;
            lblNapomena.Text = "Napomena:";
            // 
            // txtNapomena
            // 
            txtNapomena.BackColor = Color.White;
            txtNapomena.BorderStyle = BorderStyle.FixedSingle;
            txtNapomena.Font = new Font("Segoe UI", 10F);
            txtNapomena.Location = new Point(250, 267);
            txtNapomena.Multiline = true;
            txtNapomena.Name = "txtNapomena";
            txtNapomena.Size = new Size(300, 60);
            txtNapomena.TabIndex = 15;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 204, 113);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(250, 350);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 45);
            btnSave.TabIndex = 16;
            btnSave.Text = "💾 Sačuvaj";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            btnSave.MouseEnter += Button_MouseEnter;
            btnSave.MouseLeave += Button_MouseLeave;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(410, 350);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 45);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "❌ Otkaži";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            btnCancel.MouseEnter += Button_MouseEnter;
            btnCancel.MouseLeave += Button_MouseLeave;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(44, 62, 80);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 600);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(800, 40);
            panelFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 9F);
            lblFooter.ForeColor = Color.FromArgb(189, 195, 199);
            lblFooter.Location = new Point(30, 12);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(350, 15);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Standardna apoteka - Upravljanje standardnim apotekama";
            // 
            // StandardnaApotekaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 640);
            Controls.Add(panelMain);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StandardnaApotekaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farmacy System - Standardna Apoteka";
            Load += StandardnaApotekaForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblUlica;
        private System.Windows.Forms.TextBox txtUlica;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.Label lblPostanskiBroj;
        private System.Windows.Forms.TextBox txtPostanskiBroj;
        private System.Windows.Forms.Label lblMesto;
        private System.Windows.Forms.TextBox txtMesto;
        private System.Windows.Forms.Label lblOdgovorniFarmaceut;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private ComboBox comboBox1;
    }
}
