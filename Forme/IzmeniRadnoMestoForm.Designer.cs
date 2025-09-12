namespace Farmacy.Forme
{
    partial class IzmeniRadnoMestoForm
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbNovoR = new ComboBox();
            txtMbr = new TextBox();
            txtRadnoMesto = new TextBox();
            label4 = new Label();
            cmbSmena = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(111, 193);
            button1.Name = "button1";
            button1.Size = new Size(68, 30);
            button1.TabIndex = 0;
            button1.Text = "Sacuvaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(210, 193);
            button2.Name = "button2";
            button2.Size = new Size(68, 30);
            button2.TabIndex = 1;
            button2.Text = "Otkazi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 2;
            label1.Text = "Mbr";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 111);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 3;
            label2.Text = "Novo radno mesto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 75);
            label3.Name = "label3";
            label3.Size = new Size(128, 15);
            label3.TabIndex = 4;
            label3.Text = "Trenutno radno mesto:";
            // 
            // cmbNovoR
            // 
            cmbNovoR.FormattingEnabled = true;
            cmbNovoR.Location = new Point(155, 108);
            cmbNovoR.Name = "cmbNovoR";
            cmbNovoR.Size = new Size(121, 23);
            cmbNovoR.TabIndex = 5;
            // 
            // txtMbr
            // 
            txtMbr.Enabled = false;
            txtMbr.Location = new Point(155, 33);
            txtMbr.Name = "txtMbr";
            txtMbr.ReadOnly = true;
            txtMbr.Size = new Size(121, 23);
            txtMbr.TabIndex = 6;
            // 
            // txtRadnoMesto
            // 
            txtRadnoMesto.Enabled = false;
            txtRadnoMesto.Location = new Point(155, 75);
            txtRadnoMesto.Name = "txtRadnoMesto";
            txtRadnoMesto.ReadOnly = true;
            txtRadnoMesto.Size = new Size(121, 23);
            txtRadnoMesto.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 146);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 8;
            label4.Text = "Smena rada:";
            // 
            // cmbSmena
            // 
            cmbSmena.FormattingEnabled = true;
            cmbSmena.Location = new Point(155, 146);
            cmbSmena.Name = "cmbSmena";
            cmbSmena.Size = new Size(121, 23);
            cmbSmena.TabIndex = 9;
            // 
            // IzmeniRadnoMestoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 235);
            Controls.Add(cmbSmena);
            Controls.Add(label4);
            Controls.Add(txtRadnoMesto);
            Controls.Add(txtMbr);
            Controls.Add(cmbNovoR);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "IzmeniRadnoMestoForm";
            Text = "IzmeniRadnoMestoForm";
            Load += IzmeniRadnoMestoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbNovoR;
        private TextBox txtMbr;
        private TextBox txtRadnoMesto;
        private Label label4;
        private ComboBox cmbSmena;
    }
}