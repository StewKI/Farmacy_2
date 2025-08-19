namespace Farmacy.Forme
{
    partial class OdaberiMenadzeraForm1
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
            dgvMenadzeri = new DataGridView();
            button1 = new Button();
            colMbr = new DataGridViewTextBoxColumn();
            colIme = new DataGridViewTextBoxColumn();
            colPrezime = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvMenadzeri).BeginInit();
            SuspendLayout();
            // 
            // dgvMenadzeri
            // 
            dgvMenadzeri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenadzeri.Location = new Point(12, 62);
            dgvMenadzeri.Name = "dgvMenadzeri";
            dgvMenadzeri.Size = new Size(303, 264);
            dgvMenadzeri.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(344, 62);
            button1.Name = "button1";
            button1.Size = new Size(113, 264);
            button1.TabIndex = 1;
            button1.Text = "Ukloni";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // colMbr
            // 
            colMbr.Name = "colMbr";
            // 
            // colIme
            // 
            colIme.Name = "colIme";
            // 
            // colPrezime
            // 
            colPrezime.Name = "colPrezime";
            // 
            // OdaberiMenadzeraForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 338);
            Controls.Add(button1);
            Controls.Add(dgvMenadzeri);
            Name = "OdaberiMenadzeraForm1";
            Text = "OdaberiMenadzeraForm1";
            Load += OdaberiMenadzeraForm1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMenadzeri).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMenadzeri;
        private Button button1;

        private DataGridViewTextBoxColumn colMbr;
        private DataGridViewTextBoxColumn colIme;
        private DataGridViewTextBoxColumn colPrezime;
    }
}