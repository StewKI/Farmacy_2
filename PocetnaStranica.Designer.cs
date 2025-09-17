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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(201, 401);
            button1.Margin = new Padding(6, 6, 6, 6);
            button1.Name = "button1";
            button1.Size = new Size(301, 119);
            button1.TabIndex = 0;
            button1.Text = "Prodajne Jedinice";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnProdajneJedinice_Click;
            // 
            // button2
            // 
            button2.Location = new Point(600, 401);
            button2.Margin = new Padding(6, 6, 6, 6);
            button2.Name = "button2";
            button2.Size = new Size(301, 119);
            button2.TabIndex = 1;
            button2.Text = "Distributeri";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnDistributeri_Click;
            // 
            // button3
            // 
            button3.Location = new Point(201, 580);
            button3.Margin = new Padding(6, 6, 6, 6);
            button3.Name = "button3";
            button3.Size = new Size(301, 119);
            button3.TabIndex = 2;
            button3.Text = "Proizvodjači";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnProizvodjaci_Click;
            // 
            // button4
            // 
            button4.Location = new Point(600, 580);
            button4.Margin = new Padding(6, 6, 6, 6);
            button4.Name = "button4";
            button4.Size = new Size(301, 119);
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
            label1.Location = new Point(113, 220);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(768, 125);
            label1.TabIndex = 3;
            label1.Text = "LANAC APOTEKA";
            // 
            // PocetnaStranica
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1725, 875);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(6, 6, 6, 6);
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
    }
}