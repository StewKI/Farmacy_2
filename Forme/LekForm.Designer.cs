namespace Farmacy.Forme
{
    partial class LekForm
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
            lblId = new Label();
            txtId = new TextBox();
            lblHemijskiNaziv = new Label();
            txtHemijskiNaziv = new TextBox();
            lblKomercijalniNaziv = new Label();
            txtKomercijalniNaziv = new TextBox();
            lblDejstvo = new Label();
            txtDejstvo = new TextBox();
            lblProizvodjac = new Label();
            txtProizvodjac = new TextBox();
            lblPrimarnaGrupa = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(30, 30);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(150, 27);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(200, 23);
            txtId.TabIndex = 1;
            txtId.TabStop = false;
            // 
            // lblHemijskiNaziv
            // 
            lblHemijskiNaziv.AutoSize = true;
            lblHemijskiNaziv.Location = new Point(30, 70);
            lblHemijskiNaziv.Name = "lblHemijskiNaziv";
            lblHemijskiNaziv.Size = new Size(86, 15);
            lblHemijskiNaziv.TabIndex = 2;
            lblHemijskiNaziv.Text = "Hemijski naziv:";
            // 
            // txtHemijskiNaziv
            // 
            txtHemijskiNaziv.Location = new Point(150, 67);
            txtHemijskiNaziv.Name = "txtHemijskiNaziv";
            txtHemijskiNaziv.Size = new Size(200, 23);
            txtHemijskiNaziv.TabIndex = 3;
            // 
            // lblKomercijalniNaziv
            // 
            lblKomercijalniNaziv.AutoSize = true;
            lblKomercijalniNaziv.Location = new Point(30, 110);
            lblKomercijalniNaziv.Name = "lblKomercijalniNaziv";
            lblKomercijalniNaziv.Size = new Size(106, 15);
            lblKomercijalniNaziv.TabIndex = 4;
            lblKomercijalniNaziv.Text = "Komercijalni naziv:";
            // 
            // txtKomercijalniNaziv
            // 
            txtKomercijalniNaziv.Location = new Point(150, 107);
            txtKomercijalniNaziv.Name = "txtKomercijalniNaziv";
            txtKomercijalniNaziv.Size = new Size(200, 23);
            txtKomercijalniNaziv.TabIndex = 5;
            // 
            // lblDejstvo
            // 
            lblDejstvo.AutoSize = true;
            lblDejstvo.Location = new Point(30, 150);
            lblDejstvo.Name = "lblDejstvo";
            lblDejstvo.Size = new Size(49, 15);
            lblDejstvo.TabIndex = 6;
            lblDejstvo.Text = "Dejstvo:";
            // 
            // txtDejstvo
            // 
            txtDejstvo.Location = new Point(150, 147);
            txtDejstvo.Name = "txtDejstvo";
            txtDejstvo.Size = new Size(200, 23);
            txtDejstvo.TabIndex = 7;
            // 
            // lblProizvodjac
            // 
            lblProizvodjac.AutoSize = true;
            lblProizvodjac.Location = new Point(30, 190);
            lblProizvodjac.Name = "lblProizvodjac";
            lblProizvodjac.Size = new Size(68, 15);
            lblProizvodjac.TabIndex = 8;
            lblProizvodjac.Text = "Proizvođač:";
            // 
            // txtProizvodjac
            // 
            txtProizvodjac.Location = new Point(150, 187);
            txtProizvodjac.Name = "txtProizvodjac";
            txtProizvodjac.Size = new Size(200, 23);
            txtProizvodjac.TabIndex = 9;
            txtProizvodjac.TabStop = false;
            // 
            // lblPrimarnaGrupa
            // 
            lblPrimarnaGrupa.AutoSize = true;
            lblPrimarnaGrupa.Location = new Point(24, 232);
            lblPrimarnaGrupa.Name = "lblPrimarnaGrupa";
            lblPrimarnaGrupa.Size = new Size(92, 15);
            lblPrimarnaGrupa.TabIndex = 10;
            lblPrimarnaGrupa.Text = "Primarna grupa:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(199, 275);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 12;
            btnSave.Text = "Sačuvaj";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(288, 275);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Otkaži";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(131, 230);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 19);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "Analgetik";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(212, 230);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(77, 19);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "Antibiotik";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(301, 230);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(66, 19);
            radioButton3.TabIndex = 16;
            radioButton3.TabStop = true;
            radioButton3.Text = "Diuretik";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // LekForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(375, 312);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblPrimarnaGrupa);
            Controls.Add(txtProizvodjac);
            Controls.Add(lblProizvodjac);
            Controls.Add(txtDejstvo);
            Controls.Add(lblDejstvo);
            Controls.Add(txtKomercijalniNaziv);
            Controls.Add(lblKomercijalniNaziv);
            Controls.Add(txtHemijskiNaziv);
            Controls.Add(lblHemijskiNaziv);
            Controls.Add(txtId);
            Controls.Add(lblId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LekForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lek";
            Load += LekForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblHemijskiNaziv;
        private System.Windows.Forms.TextBox txtHemijskiNaziv;
        private System.Windows.Forms.Label lblKomercijalniNaziv;
        private System.Windows.Forms.TextBox txtKomercijalniNaziv;
        private System.Windows.Forms.Label lblDejstvo;
        private System.Windows.Forms.TextBox txtDejstvo;
        private System.Windows.Forms.Label lblProizvodjac;
        private System.Windows.Forms.TextBox txtProizvodjac;
        private System.Windows.Forms.Label lblPrimarnaGrupa;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
    }
}
