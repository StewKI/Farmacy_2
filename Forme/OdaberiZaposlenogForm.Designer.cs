namespace Farmacy.Forme
{
    partial class OdaberiZaposlenogForm
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
            lblSubtitle = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panelMain = new Panel();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(button4);
            panelMain.Controls.Add(button3);
            panelMain.Controls.Add(button2);
            panelMain.Controls.Add(button1);
            panelMain.Controls.Add(lblSubtitle);
            panelMain.Controls.Add(lblTitle);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(30);
            panelMain.Size = new Size(800, 320);
            panelMain.TabIndex = 5;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitle.Location = new Point(250, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 37);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "👥 Odaberite tip zaposlenog";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = Color.FromArgb(108, 117, 125);
            lblSubtitle.Location = new Point(280, 75);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(240, 20);
            lblSubtitle.TabIndex = 5;
            lblSubtitle.Text = "Izaberite kategoriju novog zaposlenog";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(52, 152, 219);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(60, 130);
            button1.Name = "button1";
            button1.Size = new Size(160, 70);
            button1.TabIndex = 0;
            button1.Text = "👤 Zaposleni";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(46, 204, 113);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(240, 130);
            button2.Name = "button2";
            button2.Size = new Size(160, 70);
            button2.TabIndex = 1;
            button2.Text = "💊 Farmaceut";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(155, 89, 182);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(420, 130);
            button3.Name = "button3";
            button3.Size = new Size(160, 70);
            button3.TabIndex = 2;
            button3.Text = "👔 Menadžer";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(231, 76, 60);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(600, 130);
            button4.Name = "button4";
            button4.Size = new Size(160, 70);
            button4.TabIndex = 3;
            button4.Text = "🔧 Tehničar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // OdaberiZaposlenogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(800, 320);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OdaberiZaposlenogForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "👥 Dodavanje novog zaposlenog";
            Load += OdaberiZaposlenogForm_Load;
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panelMain;
    }
}