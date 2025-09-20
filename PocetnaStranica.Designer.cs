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
            lblSubtitle = new Label();
            lblTitle = new Label();
            panelMain = new Panel();
            btnZaposleni = new Button();
            btnLekovi = new Button();
            btnProizvodjaci = new Button();
            btnDistributeri = new Button();
            btnProdajneJedinice = new Button();
            panelFooter = new Panel();
            lblFooter = new Label();
            imageList1 = new ImageList(components);
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 102, 102);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(5, 5, 5, 5);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1200, 180);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.FromArgb(200, 255, 255);
            lblSubtitle.Location = new Point(50, 110);
            lblSubtitle.Margin = new Padding(5, 0, 5, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(667, 45);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Sistem za vođenje evidencije apoteka i lekova";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(50, 30);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(700, 85);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🏥 FARMACY SYSTEM";
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
            panelMain.Location = new Point(0, 180);
            panelMain.Margin = new Padding(5, 5, 5, 5);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(50, 50, 50, 50);
            panelMain.Size = new Size(1200, 600);
            panelMain.TabIndex = 1;
            // 
            // btnZaposleni
            // 
            btnZaposleni.BackColor = Color.FromArgb(231, 76, 60);
            btnZaposleni.FlatAppearance.BorderSize = 0;
            btnZaposleni.FlatStyle = FlatStyle.Flat;
            btnZaposleni.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnZaposleni.ForeColor = Color.White;
            btnZaposleni.Location = new Point(50, 300);
            btnZaposleni.Margin = new Padding(5, 5, 5, 5);
            btnZaposleni.Name = "btnZaposleni";
            btnZaposleni.Size = new Size(300, 200);
            btnZaposleni.TabIndex = 4;
            btnZaposleni.Text = "👥\r\nZaposleni";
            btnZaposleni.UseVisualStyleBackColor = false;
            btnZaposleni.Click += zaposleniBtn_Click;
            btnZaposleni.MouseEnter += Button_MouseEnter;
            btnZaposleni.MouseLeave += Button_MouseLeave;
            // 
            // btnLekovi
            // 
            btnLekovi.BackColor = Color.FromArgb(230, 126, 34);
            btnLekovi.FlatAppearance.BorderSize = 0;
            btnLekovi.FlatStyle = FlatStyle.Flat;
            btnLekovi.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnLekovi.ForeColor = Color.White;
            btnLekovi.Location = new Point(450, 50);
            btnLekovi.Margin = new Padding(5, 5, 5, 5);
            btnLekovi.Name = "btnLekovi";
            btnLekovi.Size = new Size(300, 200);
            btnLekovi.TabIndex = 3;
            btnLekovi.Text = "💊\r\nLekovi";
            btnLekovi.UseVisualStyleBackColor = false;
            btnLekovi.Click += btnLekovi_Click;
            btnLekovi.MouseEnter += Button_MouseEnter;
            btnLekovi.MouseLeave += Button_MouseLeave;
            // 
            // btnProizvodjaci
            // 
            btnProizvodjaci.BackColor = Color.FromArgb(155, 89, 182);
            btnProizvodjaci.FlatAppearance.BorderSize = 0;
            btnProizvodjaci.FlatStyle = FlatStyle.Flat;
            btnProizvodjaci.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnProizvodjaci.ForeColor = Color.White;
            btnProizvodjaci.Location = new Point(850, 50);
            btnProizvodjaci.Margin = new Padding(5, 5, 5, 5);
            btnProizvodjaci.Name = "btnProizvodjaci";
            btnProizvodjaci.Size = new Size(300, 200);
            btnProizvodjaci.TabIndex = 2;
            btnProizvodjaci.Text = "🏭\r\nProizvođači";
            btnProizvodjaci.UseVisualStyleBackColor = false;
            btnProizvodjaci.Click += btnProizvodjaci_Click;
            btnProizvodjaci.MouseEnter += Button_MouseEnter;
            btnProizvodjaci.MouseLeave += Button_MouseLeave;
            // 
            // btnDistributeri
            // 
            btnDistributeri.BackColor = Color.FromArgb(46, 204, 113);
            btnDistributeri.FlatAppearance.BorderSize = 0;
            btnDistributeri.FlatStyle = FlatStyle.Flat;
            btnDistributeri.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDistributeri.ForeColor = Color.White;
            btnDistributeri.Location = new Point(450, 300);
            btnDistributeri.Margin = new Padding(5, 5, 5, 5);
            btnDistributeri.Name = "btnDistributeri";
            btnDistributeri.Size = new Size(300, 200);
            btnDistributeri.TabIndex = 1;
            btnDistributeri.Text = "🚚\r\nDistributeri";
            btnDistributeri.UseVisualStyleBackColor = false;
            btnDistributeri.Click += btnDistributeri_Click;
            btnDistributeri.MouseEnter += Button_MouseEnter;
            btnDistributeri.MouseLeave += Button_MouseLeave;
            // 
            // btnProdajneJedinice
            // 
            btnProdajneJedinice.BackColor = Color.FromArgb(52, 152, 219);
            btnProdajneJedinice.FlatAppearance.BorderSize = 0;
            btnProdajneJedinice.FlatStyle = FlatStyle.Flat;
            btnProdajneJedinice.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnProdajneJedinice.ForeColor = Color.White;
            btnProdajneJedinice.Location = new Point(50, 50);
            btnProdajneJedinice.Margin = new Padding(5, 5, 5, 5);
            btnProdajneJedinice.Name = "btnProdajneJedinice";
            btnProdajneJedinice.Size = new Size(300, 200);
            btnProdajneJedinice.TabIndex = 0;
            btnProdajneJedinice.Text = "🏪\r\nProdajne\r\nJedinice";
            btnProdajneJedinice.UseVisualStyleBackColor = false;
            btnProdajneJedinice.Click += btnProdajneJedinice_Click;
            btnProdajneJedinice.MouseEnter += Button_MouseEnter;
            btnProdajneJedinice.MouseLeave += Button_MouseLeave;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(44, 62, 80);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 780);
            panelFooter.Margin = new Padding(5, 5, 5, 5);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1200, 60);
            panelFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 10F);
            lblFooter.ForeColor = Color.FromArgb(189, 195, 199);
            lblFooter.Location = new Point(50, 15);
            lblFooter.Margin = new Padding(5, 0, 5, 0);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(553, 37);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "© 2025 Farmacy System - Sva prava zadržana";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // PocetnaStranica
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 840);
            Controls.Add(panelMain);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 5, 5, 5);
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