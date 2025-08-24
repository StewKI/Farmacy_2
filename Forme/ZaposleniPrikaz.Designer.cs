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
            groupBoxZaposleni = new GroupBox();
            dgvZaposleni = new DataGridView();
            panelDesno = new Panel();
            lblOpis = new Label();
            btnObrisiZaposlenog = new Button();
            lblUkupanBroj = new Label();
            txbBrojZaposlenih = new TextBox();
            groupBoxZaposleni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvZaposleni).BeginInit();
            panelDesno.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxZaposleni
            // 
            groupBoxZaposleni.Controls.Add(dgvZaposleni);
            groupBoxZaposleni.Dock = DockStyle.Fill;
            groupBoxZaposleni.Font = new Font("Segoe UI", 9F);
            groupBoxZaposleni.Location = new Point(0, 0);
            groupBoxZaposleni.Name = "groupBoxZaposleni";
            groupBoxZaposleni.Padding = new Padding(12);
            groupBoxZaposleni.Size = new Size(980, 540);
            groupBoxZaposleni.TabIndex = 1;
            groupBoxZaposleni.TabStop = false;
            groupBoxZaposleni.Text = "Zaposleni lanca prodavnica igracaka";
            // 
            // dgvZaposleni
            // 
            dgvZaposleni.AllowUserToAddRows = false;
            dgvZaposleni.AllowUserToDeleteRows = false;
            dgvZaposleni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvZaposleni.Dock = DockStyle.Fill;
            dgvZaposleni.Location = new Point(12, 28);
            dgvZaposleni.MultiSelect = false;
            dgvZaposleni.Name = "dgvZaposleni";
            dgvZaposleni.ReadOnly = true;
            dgvZaposleni.RowHeadersVisible = false;
            dgvZaposleni.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvZaposleni.Size = new Size(956, 500);
            dgvZaposleni.TabIndex = 0;
            dgvZaposleni.CellContentClick += dgvZaposleni_CellContentClick;
            // 
            // panelDesno
            // 
            panelDesno.BackColor = Color.FromArgb(245, 208, 168);
            panelDesno.Controls.Add(lblOpis);
            panelDesno.Controls.Add(btnObrisiZaposlenog);
            panelDesno.Controls.Add(lblUkupanBroj);
            panelDesno.Controls.Add(txbBrojZaposlenih);
            panelDesno.Dock = DockStyle.Right;
            panelDesno.Location = new Point(680, 0);
            panelDesno.Name = "panelDesno";
            panelDesno.Padding = new Padding(16);
            panelDesno.Size = new Size(300, 540);
            panelDesno.TabIndex = 0;
            // 
            // lblOpis
            // 
            lblOpis.Location = new Point(16, 12);
            lblOpis.Name = "lblOpis";
            lblOpis.Size = new Size(268, 90);
            lblOpis.TabIndex = 0;
            lblOpis.Text = "U tabeli su prikazani svi zaposleni lanca prodavnica igracaka.\r\nBrisanjem zaposlenog iz ove tabele bice trajno izbrisan iz sistema.";
            // 
            // btnObrisiZaposlenog
            // 
            btnObrisiZaposlenog.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnObrisiZaposlenog.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            btnObrisiZaposlenog.Location = new Point(20, 120);
            btnObrisiZaposlenog.Name = "btnObrisiZaposlenog";
            btnObrisiZaposlenog.Size = new Size(260, 48);
            btnObrisiZaposlenog.TabIndex = 1;
            btnObrisiZaposlenog.Text = "Obriši zaposlenog";
            btnObrisiZaposlenog.Click += btnObrisiZaposlenog_Click;
            // 
            // lblUkupanBroj
            // 
            lblUkupanBroj.AutoSize = true;
            lblUkupanBroj.Location = new Point(20, 200);
            lblUkupanBroj.Name = "lblUkupanBroj";
            lblUkupanBroj.Size = new Size(134, 15);
            lblUkupanBroj.TabIndex = 2;
            lblUkupanBroj.Text = "Ukupan broj zaposlenih:";
            // 
            // txbBrojZaposlenih
            // 
            txbBrojZaposlenih.Location = new Point(20, 225);
            txbBrojZaposlenih.Name = "txbBrojZaposlenih";
            txbBrojZaposlenih.ReadOnly = true;
            txbBrojZaposlenih.Size = new Size(180, 23);
            txbBrojZaposlenih.TabIndex = 3;
            txbBrojZaposlenih.TextAlign = HorizontalAlignment.Center;
            // 
            // ZaposleniPrikaz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 224, 190);
            ClientSize = new Size(980, 540);
            Controls.Add(panelDesno);
            Controls.Add(groupBoxZaposleni);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(900, 520);
            Name = "ZaposleniPrikaz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SVI ZAPOSLENI";
            groupBoxZaposleni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvZaposleni).EndInit();
            panelDesno.ResumeLayout(false);
            panelDesno.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}