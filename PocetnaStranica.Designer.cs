namespace Farmacy
{
    partial class PocetnaStranica
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
            components = new System.ComponentModel.Container();
            panelHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            panelMain = new Panel();
            btnProdajneJedinice = new Button();
            btnDistributeri = new Button();
            btnProizvodjaci = new Button();
            btnLekovi = new Button();
            btnZaposleni = new Button();
            panelFooter = new Panel();
            lblFooter = new Label();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 102, 102);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1200, 150);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(50, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 51);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🏥 FARMACY SYSTEM";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.FromArgb(200, 255, 255);
            lblSubtitle.Location = new Point(50, 90);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(350, 21);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Sistem za vođenje evidencije apoteka i lekova";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(btnZaposleni);
            panelMain.Controls.Add(btnLekovi);
            panelMain.Controls.Add(btnProizvodjaci);
            panelMain.Controls.Add(btnDistributeri);
            panelMain.Controls.Add(btnProdajneJedinice);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 150);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(50);
            panelMain.Size = new Size(1200, 500);
            panelMain.TabIndex = 1;
            // 
            // btnProdajneJedinice
            // 
            btnProdajneJedinice.BackColor = Color.FromArgb(52, 152, 219);
            btnProdajneJedinice.FlatAppearance.BorderSize = 0;
            btnProdajneJedinice.FlatStyle = FlatStyle.Flat;
            btnProdajneJedinice.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnProdajneJedinice.ForeColor = Color.White;
            btnProdajneJedinice.Location = new Point(50, 50);
            btnProdajneJedinice.Name = "btnProdajneJedinice";
            btnProdajneJedinice.Size = new Size(200, 120);
            btnProdajneJedinice.TabIndex = 0;
            btnProdajneJedinice.Text = "🏪\r\nProdajne\r\nJedinice";
            btnProdajneJedinice.TextAlign = ContentAlignment.MiddleCenter;
            btnProdajneJedinice.UseVisualStyleBackColor = false;
            btnProdajneJedinice.Click += btnProdajneJedinice_Click;
            btnProdajneJedinice.MouseEnter += Button_MouseEnter;
            btnProdajneJedinice.MouseLeave += Button_MouseLeave;
            // 
            // btnDistributeri
            // 
            btnDistributeri.BackColor = Color.FromArgb(46, 204, 113);
            btnDistributeri.FlatAppearance.BorderSize = 0;
            btnDistributeri.FlatStyle = FlatStyle.Flat;
            btnDistributeri.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDistributeri.ForeColor = Color.White;
            btnDistributeri.Location = new Point(300, 50);
            btnDistributeri.Name = "btnDistributeri";
            btnDistributeri.Size = new Size(200, 120);
            btnDistributeri.TabIndex = 1;
            btnDistributeri.Text = "🚚\r\nDistributeri";
            btnDistributeri.TextAlign = ContentAlignment.MiddleCenter;
            btnDistributeri.UseVisualStyleBackColor = false;
            btnDistributeri.Click += btnDistributeri_Click;
            btnDistributeri.MouseEnter += Button_MouseEnter;
            btnDistributeri.MouseLeave += Button_MouseLeave;
            // 
            // btnProizvodjaci
            // 
            btnProizvodjaci.BackColor = Color.FromArgb(155, 89, 182);
            btnProizvodjaci.FlatAppearance.BorderSize = 0;
            btnProizvodjaci.FlatStyle = FlatStyle.Flat;
            btnProizvodjaci.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnProizvodjaci.ForeColor = Color.White;
            btnProizvodjaci.Location = new Point(550, 50);
            btnProizvodjaci.Name = "btnProizvodjaci";
            btnProizvodjaci.Size = new Size(200, 120);
            btnProizvodjaci.TabIndex = 2;
            btnProizvodjaci.Text = "🏭\r\nProizvođači";
            btnProizvodjaci.TextAlign = ContentAlignment.MiddleCenter;
            btnProizvodjaci.UseVisualStyleBackColor = false;
            btnProizvodjaci.Click += btnProizvodjaci_Click;
            btnProizvodjaci.MouseEnter += Button_MouseEnter;
            btnProizvodjaci.MouseLeave += Button_MouseLeave;
            // 
            // btnLekovi
            // 
            btnLekovi.BackColor = Color.FromArgb(230, 126, 34);
            btnLekovi.FlatAppearance.BorderSize = 0;
            btnLekovi.FlatStyle = FlatStyle.Flat;
            btnLekovi.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnLekovi.ForeColor = Color.White;
            btnLekovi.Location = new Point(800, 50);
            btnLekovi.Name = "btnLekovi";
            btnLekovi.Size = new Size(200, 120);
            btnLekovi.TabIndex = 3;
            btnLekovi.Text = "💊\r\nLekovi";
            btnLekovi.TextAlign = ContentAlignment.MiddleCenter;
            btnLekovi.UseVisualStyleBackColor = false;
            btnLekovi.Click += btnLekovi_Click;
            btnLekovi.MouseEnter += Button_MouseEnter;
            btnLekovi.MouseLeave += Button_MouseLeave;
            // 
            // btnZaposleni
            // 
            btnZaposleni.BackColor = Color.FromArgb(231, 76, 60);
            btnZaposleni.FlatAppearance.BorderSize = 0;
            btnZaposleni.FlatStyle = FlatStyle.Flat;
            btnZaposleni.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnZaposleni.ForeColor = Color.White;
            btnZaposleni.Location = new Point(50, 220);
            btnZaposleni.Name = "btnZaposleni";
            btnZaposleni.Size = new Size(200, 120);
            btnZaposleni.TabIndex = 4;
            btnZaposleni.Text = "👥\r\nZaposleni";
            btnZaposleni.TextAlign = ContentAlignment.MiddleCenter;
            btnZaposleni.UseVisualStyleBackColor = false;
            btnZaposleni.Click += zaposleniBtn_Click;
            btnZaposleni.MouseEnter += Button_MouseEnter;
            btnZaposleni.MouseLeave += Button_MouseLeave;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(44, 62, 80);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 650);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1200, 50);
            panelFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 10F);
            lblFooter.ForeColor = Color.FromArgb(189, 195, 199);
            lblFooter.Location = new Point(50, 15);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(300, 19);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "© 2024 Farmacy System - Sva prava zadržana";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // PocetnaStranica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 700);
            Controls.Add(panelMain);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PocetnaStranica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farmacy System - Početna stranica";
            Load += PocetnaStranica_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelMain;
        private Button btnProdajneJedinice;
        private Button btnDistributeri;
        private Button btnProizvodjaci;
        private Button btnLekovi;
        private Button btnZaposleni;
        private Panel panelFooter;
        private Label lblFooter;
        private ImageList imageList1;
    }
}