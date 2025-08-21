namespace Farmacy.Forme
{
    partial class RealizujReceptForm
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
            lblPj = new Label();
            lblDatum = new Label();
            lblFarmaceut = new Label();
            txtProdajnaJedinica = new TextBox();
            dtpDatum = new DateTimePicker();
            txtFarmaceut = new TextBox();
            btnSacuvaj = new Button();
            btnOtkazi = new Button();
            label1 = new Label();
            txtRecept = new TextBox();
            SuspendLayout();
            // 
            // lblPj
            // 
            lblPj.AutoSize = true;
            lblPj.Location = new Point(22, 74);
            lblPj.Name = "lblPj";
            lblPj.Size = new Size(166, 15);
            lblPj.TabIndex = 0;
            lblPj.Text = "Realizovana prodajna jedinica:";
            // 
            // lblDatum
            // 
            lblDatum.AutoSize = true;
            lblDatum.Location = new Point(22, 114);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(100, 15);
            lblDatum.TabIndex = 1;
            lblDatum.Text = "Datum realizacije:";
            // 
            // lblFarmaceut
            // 
            lblFarmaceut.AutoSize = true;
            lblFarmaceut.Location = new Point(22, 154);
            lblFarmaceut.Name = "lblFarmaceut";
            lblFarmaceut.Size = new Size(123, 15);
            lblFarmaceut.TabIndex = 2;
            lblFarmaceut.Text = "Realizovao farmaceut:";
            // 
            // txtProdajnaJedinica
            // 
            txtProdajnaJedinica.Enabled = false;
            txtProdajnaJedinica.Location = new Point(204, 70);
            txtProdajnaJedinica.Name = "txtProdajnaJedinica";
            txtProdajnaJedinica.Size = new Size(170, 23);
            txtProdajnaJedinica.TabIndex = 0;
            // 
            // dtpDatum
            // 
            dtpDatum.Format = DateTimePickerFormat.Short;
            dtpDatum.Location = new Point(204, 110);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(170, 23);
            dtpDatum.TabIndex = 1;
            // 
            // txtFarmaceut
            // 
            txtFarmaceut.Enabled = false;
            txtFarmaceut.Location = new Point(204, 150);
            txtFarmaceut.Name = "txtFarmaceut";
            txtFarmaceut.Size = new Size(170, 23);
            txtFarmaceut.TabIndex = 2;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(202, 198);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(90, 27);
            btnSacuvaj.TabIndex = 3;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnOtkazi
            // 
            btnOtkazi.DialogResult = DialogResult.Cancel;
            btnOtkazi.Location = new Point(298, 198);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(90, 27);
            btnOtkazi.TabIndex = 4;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 37);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 5;
            label1.Text = "Broj racuna:";
            label1.Click += label1_Click;
            // 
            // txtRecept
            // 
            txtRecept.Location = new Point(204, 34);
            txtRecept.Name = "txtRecept";
            txtRecept.Size = new Size(170, 23);
            txtRecept.TabIndex = 6;
            // 
            // RealizujReceptForm
            // 
            AcceptButton = btnSacuvaj;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOtkazi;
            ClientSize = new Size(400, 246);
            Controls.Add(txtRecept);
            Controls.Add(label1);
            Controls.Add(lblPj);
            Controls.Add(txtProdajnaJedinica);
            Controls.Add(lblDatum);
            Controls.Add(dtpDatum);
            Controls.Add(lblFarmaceut);
            Controls.Add(txtFarmaceut);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnOtkazi);
            Name = "RealizujReceptForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Realizacija recepta";
            Load += RealizujReceptForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPj;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblFarmaceut;

        private System.Windows.Forms.TextBox txtProdajnaJedinica;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox txtFarmaceut;

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnOtkazi;
        private Label label1;
        private TextBox txtRecept;
    }
}