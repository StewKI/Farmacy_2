namespace Farmacy.Forme
{
    partial class OdaberiProdajnuJedinicu
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
            lblTitle = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitle.Location = new Point(180, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(246, 32);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Odaberite tip prodajne jedinice";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(52, 152, 219);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(50, 120);
            button1.Name = "button1";
            button1.Size = new Size(150, 60);
            button1.TabIndex = 0;
            button1.Text = "Prodajna jedinica";
            button1.UseVisualStyleBackColor = false;
            button1.Click += ProdajnaJedinica_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(46, 204, 113);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(220, 120);
            button2.Name = "button2";
            button2.Size = new Size(150, 60);
            button2.TabIndex = 1;
            button2.Text = "Apoteka sa lab";
            button2.UseVisualStyleBackColor = false;
            button2.Click += ApotekaSaLab_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(155, 89, 182);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(390, 120);
            button3.Name = "button3";
            button3.Size = new Size(150, 60);
            button3.TabIndex = 2;
            button3.Text = "Standardna\nApoteka";
            button3.UseVisualStyleBackColor = false;
            button3.Click += StandardnaApoteka_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(231, 76, 60);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(560, 120);
            button4.Name = "button4";
            button4.Size = new Size(150, 60);
            button4.TabIndex = 3;
            button4.Text = "Specijalizovana\nApoteka";
            button4.UseVisualStyleBackColor = false;
            button4.Click += SpecijalizovanaApoteka_Click;
            // 
            // OdaberiProdajnuJedinicu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(760, 250);
            Controls.Add(lblTitle);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OdaberiProdajnuJedinicu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Odabir prodajne jedinice";
            Load += OdaberiProdajnuJedinicu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}