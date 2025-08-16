namespace Farmacy.Forme
{
    partial class RadnoVremeEditForm
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
            this.lblProdajnaJedinica = new System.Windows.Forms.Label();
            this.txtProdajnaJedinica = new System.Windows.Forms.TextBox();
            this.lblDan = new System.Windows.Forms.Label();
            this.cmbDan = new System.Windows.Forms.ComboBox();
            this.lblVremeOd = new System.Windows.Forms.Label();
            this.dtpVremeOd = new System.Windows.Forms.DateTimePicker();
            this.lblVremeDo = new System.Windows.Forms.Label();
            this.dtpVremeDo = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProdajnaJedinica
            // 
            this.lblProdajnaJedinica.AutoSize = true;
            this.lblProdajnaJedinica.Location = new System.Drawing.Point(12, 15);
            this.lblProdajnaJedinica.Name = "lblProdajnaJedinica";
            this.lblProdajnaJedinica.Size = new System.Drawing.Size(89, 13);
            this.lblProdajnaJedinica.TabIndex = 0;
            this.lblProdajnaJedinica.Text = "Prodajna jedinica:";
            // 
            // txtProdajnaJedinica
            // 
            this.txtProdajnaJedinica.Location = new System.Drawing.Point(120, 12);
            this.txtProdajnaJedinica.Name = "txtProdajnaJedinica";
            this.txtProdajnaJedinica.ReadOnly = true;
            this.txtProdajnaJedinica.Size = new System.Drawing.Size(200, 20);
            this.txtProdajnaJedinica.TabIndex = 1;
            // 
            // lblDan
            // 
            this.lblDan.AutoSize = true;
            this.lblDan.Location = new System.Drawing.Point(12, 41);
            this.lblDan.Name = "lblDan";
            this.lblDan.Size = new System.Drawing.Size(28, 13);
            this.lblDan.TabIndex = 2;
            this.lblDan.Text = "Dan:";
            // 
            // cmbDan
            // 
            this.cmbDan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDan.FormattingEnabled = true;
            this.cmbDan.Items.AddRange(new object[] {
            "Ponedeljak",
            "Utorak",
            "Sreda",
            "Četvrtak",
            "Petak",
            "Subota",
            "Nedelja"});
            this.cmbDan.Location = new System.Drawing.Point(120, 38);
            this.cmbDan.Name = "cmbDan";
            this.cmbDan.Size = new System.Drawing.Size(200, 21);
            this.cmbDan.TabIndex = 3;
            // 
            // lblVremeOd
            // 
            this.lblVremeOd.AutoSize = true;
            this.lblVremeOd.Location = new System.Drawing.Point(12, 67);
            this.lblVremeOd.Name = "lblVremeOd";
            this.lblVremeOd.Size = new System.Drawing.Size(58, 13);
            this.lblVremeOd.TabIndex = 4;
            this.lblVremeOd.Text = "Vreme od:";
            // 
            // dtpVremeOd
            // 
            this.dtpVremeOd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVremeOd.Location = new System.Drawing.Point(120, 64);
            this.dtpVremeOd.Name = "dtpVremeOd";
            this.dtpVremeOd.ShowUpDown = true;
            this.dtpVremeOd.Size = new System.Drawing.Size(200, 20);
            this.dtpVremeOd.TabIndex = 5;
            // 
            // lblVremeDo
            // 
            this.lblVremeDo.AutoSize = true;
            this.lblVremeDo.Location = new System.Drawing.Point(12, 93);
            this.lblVremeDo.Name = "lblVremeDo";
            this.lblVremeDo.Size = new System.Drawing.Size(58, 13);
            this.lblVremeDo.TabIndex = 6;
            this.lblVremeDo.Text = "Vreme do:";
            // 
            // dtpVremeDo
            // 
            this.dtpVremeDo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVremeDo.Location = new System.Drawing.Point(120, 90);
            this.dtpVremeDo.Name = "dtpVremeDo";
            this.dtpVremeDo.ShowUpDown = true;
            this.dtpVremeDo.Size = new System.Drawing.Size(200, 20);
            this.dtpVremeDo.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 125);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(245, 125);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Otkaži";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RadnoVremeEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 160);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpVremeDo);
            this.Controls.Add(this.lblVremeDo);
            this.Controls.Add(this.dtpVremeOd);
            this.Controls.Add(this.lblVremeOd);
            this.Controls.Add(this.cmbDan);
            this.Controls.Add(this.lblDan);
            this.Controls.Add(this.txtProdajnaJedinica);
            this.Controls.Add(this.lblProdajnaJedinica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RadnoVremeEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Uredi Radno Vreme";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblProdajnaJedinica;
        private System.Windows.Forms.TextBox txtProdajnaJedinica;
        private System.Windows.Forms.Label lblDan;
        private System.Windows.Forms.ComboBox cmbDan;
        private System.Windows.Forms.Label lblVremeOd;
        private System.Windows.Forms.DateTimePicker dtpVremeOd;
        private System.Windows.Forms.Label lblVremeDo;
        private System.Windows.Forms.DateTimePicker dtpVremeDo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
