using System.Drawing;
using System.Windows.Forms;
namespace Farmacy.Forme
{
    partial class ZaposleniPrikaz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelMain;
        private Panel panelFooter;
        private Label lblFooter;
        private GroupBox groupBoxZaposleni;
        private DataGridView dgvZaposleni;
        private Panel panelDesno;
        private Label lblOpis;
        private Button btnObrisiZaposlenog;
        private Label lblUkupanBroj;
        private TextBox txbBrojZaposlenih;

        private DataGridViewTextBoxColumn colMbr;
        private DataGridViewTextBoxColumn colIme;
        private DataGridViewTextBoxColumn colPrezime;

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
            groupBoxZaposleni = new GroupBox();
            dgvZaposleni = new DataGridView();
            panelDesno = new Panel();
            lblOpis = new Label();
            btnObrisiZaposlenog = new Button();
            lblUkupanBroj = new Label();
            txbBrojZaposlenih = new TextBox();
            panelFooter = new Panel();
            lblFooter = new Label();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            groupBoxZaposleni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvZaposleni).BeginInit();
            panelDesno.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(230, 126, 34);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1200, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(280, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "👥 PREGLED ZAPOSLENIH";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(255, 220, 200);
            lblSubtitle.Location = new Point(20, 45);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(280, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Pregled svih zaposlenih u sistemu";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(panelDesno);
            panelMain.Controls.Add(groupBoxZaposleni);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 80);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1200, 520);
            panelMain.TabIndex = 1;
            // 
            // groupBoxZaposleni
            // 
            groupBoxZaposleni.Controls.Add(dgvZaposleni);
            groupBoxZaposleni.Dock = DockStyle.Fill;
            groupBoxZaposleni.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxZaposleni.ForeColor = Color.FromArgb(44, 62, 80);
            groupBoxZaposleni.Location = new Point(0, 0);
            groupBoxZaposleni.Name = "groupBoxZaposleni";
            groupBoxZaposleni.Padding = new Padding(20);
            groupBoxZaposleni.Size = new Size(900, 520);
            groupBoxZaposleni.TabIndex = 1;
            groupBoxZaposleni.TabStop = false;
            groupBoxZaposleni.Text = "Zaposleni lanca prodavnica igracaka";
            // 
            // dgvZaposleni
            // 
            dgvZaposleni.AllowUserToAddRows = false;
            dgvZaposleni.AllowUserToDeleteRows = false;
            dgvZaposleni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvZaposleni.BackgroundColor = Color.White;
            dgvZaposleni.BorderStyle = BorderStyle.None;
            dgvZaposleni.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvZaposleni.ColumnHeadersHeight = 50;
            dgvZaposleni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvZaposleni.Dock = DockStyle.Fill;
            dgvZaposleni.GridColor = Color.FromArgb(233, 236, 239);
            dgvZaposleni.Location = new Point(20, 22);
            dgvZaposleni.MultiSelect = false;
            dgvZaposleni.Name = "dgvZaposleni";
            dgvZaposleni.ReadOnly = true;
            dgvZaposleni.RowHeadersVisible = false;
            dgvZaposleni.RowTemplate.Height = 40;
            dgvZaposleni.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvZaposleni.Size = new Size(860, 478);
            dgvZaposleni.TabIndex = 0;
            dgvZaposleni.CellContentClick += dgvZaposleni_CellContentClick;
            // 
            // panelDesno
            // 
            panelDesno.BackColor = Color.FromArgb(255, 255, 255);
            panelDesno.Controls.Add(lblOpis);
            panelDesno.Controls.Add(btnObrisiZaposlenog);
            panelDesno.Controls.Add(lblUkupanBroj);
            panelDesno.Controls.Add(txbBrojZaposlenih);
            panelDesno.Dock = DockStyle.Right;
            panelDesno.Location = new Point(900, 0);
            panelDesno.Name = "panelDesno";
            panelDesno.Padding = new Padding(20);
            panelDesno.Size = new Size(300, 520);
            panelDesno.TabIndex = 0;
            // 
            // lblOpis
            // 
            lblOpis.Font = new Font("Segoe UI", 9F);
            lblOpis.ForeColor = Color.FromArgb(44, 62, 80);
            lblOpis.Location = new Point(20, 20);
            lblOpis.Name = "lblOpis";
            lblOpis.Size = new Size(260, 90);
            lblOpis.TabIndex = 0;
            lblOpis.Text = "U tabeli su prikazani svi zaposleni lanca prodavnica igracaka.\r\nBrisanjem zaposlenog iz ove tabele bice trajno izbrisan iz sistema.";
            // 
            // btnObrisiZaposlenog
            // 
            btnObrisiZaposlenog.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnObrisiZaposlenog.BackColor = Color.FromArgb(231, 76, 60);
            btnObrisiZaposlenog.FlatAppearance.BorderSize = 0;
            btnObrisiZaposlenog.FlatStyle = FlatStyle.Flat;
            btnObrisiZaposlenog.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnObrisiZaposlenog.ForeColor = Color.White;
            btnObrisiZaposlenog.Location = new Point(20, 120);
            btnObrisiZaposlenog.Name = "btnObrisiZaposlenog";
            btnObrisiZaposlenog.Size = new Size(260, 48);
            btnObrisiZaposlenog.TabIndex = 1;
            btnObrisiZaposlenog.Text = "🗑️ Obriši zaposlenog";
            btnObrisiZaposlenog.UseVisualStyleBackColor = false;
            btnObrisiZaposlenog.Click += btnObrisiZaposlenog_Click;
            // 
            // lblUkupanBroj
            // 
            lblUkupanBroj.AutoSize = true;
            lblUkupanBroj.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUkupanBroj.ForeColor = Color.FromArgb(44, 62, 80);
            lblUkupanBroj.Location = new Point(20, 200);
            lblUkupanBroj.Name = "lblUkupanBroj";
            lblUkupanBroj.Size = new Size(164, 19);
            lblUkupanBroj.TabIndex = 2;
            lblUkupanBroj.Text = "Ukupan broj zaposlenih:";
            // 
            // txbBrojZaposlenih
            // 
            txbBrojZaposlenih.BackColor = Color.White;
            txbBrojZaposlenih.BorderStyle = BorderStyle.FixedSingle;
            txbBrojZaposlenih.Font = new Font("Segoe UI", 10F);
            txbBrojZaposlenih.Location = new Point(20, 225);
            txbBrojZaposlenih.Name = "txbBrojZaposlenih";
            txbBrojZaposlenih.ReadOnly = true;
            txbBrojZaposlenih.Size = new Size(180, 26);
            txbBrojZaposlenih.TabIndex = 3;
            txbBrojZaposlenih.TextAlign = HorizontalAlignment.Center;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(44, 62, 80);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 600);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1200, 30);
            panelFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 8F);
            lblFooter.ForeColor = Color.FromArgb(189, 195, 199);
            lblFooter.Location = new Point(20, 8);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(210, 13);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Sistem za upravljanje farmaceutskim podacima";
            // 
            // ZaposleniPrikaz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 630);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Controls.Add(panelFooter);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ZaposleniPrikaz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pregled zaposlenih - Svi zaposleni u sistemu";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            groupBoxZaposleni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvZaposleni).EndInit();
            panelDesno.ResumeLayout(false);
            panelDesno.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}