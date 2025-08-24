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
            imageList1 = new ImageList(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(170, 270);
            button1.Name = "button1";
            button1.Size = new Size(119, 48);
            button1.TabIndex = 0;
            button1.Text = "Apoteke";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(170, 379);
            button2.Name = "button2";
            button2.Size = new Size(119, 48);
            button2.TabIndex = 1;
            button2.Text = "Zaposleni";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnZaposleni;
            // 
            // button3
            // 
            button3.Location = new Point(170, 476);
            button3.Name = "button3";
            button3.Size = new Size(119, 48);
            button3.TabIndex = 2;
            button3.Text = "Lekovi";
            button3.UseVisualStyleBackColor = true;
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
            label1.Location = new Point(61, 135);
            label1.Name = "label1";
            label1.Size = new Size(381, 62);
            label1.TabIndex = 3;
            label1.Text = "LANAC APOTEKA";
            // 
            // PocetnaStranica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 618);
            Controls.Add(label1);
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
        private ImageList imageList1;
        private Label label1;
    }
}