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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            imageList1 = new ImageList(components);
            label1 = new Label();
            zaposleniBtn = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(108, 188);
            button1.Name = "button1";
            button1.Size = new Size(162, 56);
            button1.TabIndex = 0;
            button1.Text = "Prodajne Jedinice";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnProdajneJedinice_Click;
            // 
            // button2
            // 
            button2.Location = new Point(323, 188);
            button2.Name = "button2";
            button2.Size = new Size(162, 56);
            button2.TabIndex = 1;
            button2.Text = "Distributeri";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnDistributeri_Click;
            // 
            // button3
            // 
            button3.Location = new Point(108, 272);
            button3.Name = "button3";
            button3.Size = new Size(162, 56);
            button3.TabIndex = 2;
            button3.Text = "Proizvodjači";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnProizvodjaci_Click;
            // 
            // button4
            // 
            button4.Location = new Point(323, 272);
            button4.Name = "button4";
            button4.Size = new Size(162, 56);
            button4.TabIndex = 3;
            button4.Text = "Lekovi";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnLekovi_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 35F);
            label1.Location = new Point(61, 103);
            label1.Name = "label1";
            label1.Size = new Size(381, 62);
            label1.TabIndex = 3;
            label1.Text = "LANAC APOTEKA";
            // 
            // zaposleniBtn
            // 
            zaposleniBtn.Location = new Point(559, 225);
            zaposleniBtn.Name = "zaposleniBtn";
            zaposleniBtn.Size = new Size(162, 56);
            zaposleniBtn.TabIndex = 4;
            zaposleniBtn.Text = "Zaposleni";
            zaposleniBtn.UseVisualStyleBackColor = true;
            zaposleniBtn.Click += zaposleniBtn_Click;
            // 
            // PocetnaStranica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 410);
            Controls.Add(zaposleniBtn);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "PocetnaStranica";
            Text = "PocetnaStranica";
            Load += PocetnaStranica_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ImageList imageList1;
        private Label label1;
        private Button zaposleniBtn;
    }
}