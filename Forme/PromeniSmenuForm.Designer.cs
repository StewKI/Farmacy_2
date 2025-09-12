namespace Farmacy.Forme
{
    partial class PromeniSmenuForm
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
            cmbSmena = new ComboBox();
            label4 = new Label();
            txtMbr = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            dtpDatum = new DateTimePicker();
            SuspendLayout();
            // 
            // cmbSmena
            // 
            cmbSmena.FormattingEnabled = true;
            cmbSmena.Location = new Point(127, 119);
            cmbSmena.Name = "cmbSmena";
            cmbSmena.Size = new Size(121, 23);
            cmbSmena.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 119);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 16;
            label4.Text = "Smena rada:";
            label4.Click += label4_Click;
            // 
            // txtMbr
            // 
            txtMbr.Enabled = false;
            txtMbr.Location = new Point(127, 31);
            txtMbr.Name = "txtMbr";
            txtMbr.ReadOnly = true;
            txtMbr.Size = new Size(121, 23);
            txtMbr.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 73);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 12;
            label3.Text = "Dan za izmenu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 109);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 39);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 10;
            label1.Text = "Mbr:";
            // 
            // button1
            // 
            button1.Location = new Point(86, 170);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "Sacuvaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(174, 170);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 19;
            button2.Text = "Otkazi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dtpDatum
            // 
            dtpDatum.Format = DateTimePickerFormat.Short;
            dtpDatum.Location = new Point(127, 73);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(121, 23);
            dtpDatum.TabIndex = 20;
            // 
            // PromeniSmenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 205);
            Controls.Add(dtpDatum);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbSmena);
            Controls.Add(label4);
            Controls.Add(txtMbr);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PromeniSmenuForm";
            Text = "PromeniSmenuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSmena;
        private Label label4;
        private TextBox txtMbr;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private DateTimePicker dtpDatum;
    }
}