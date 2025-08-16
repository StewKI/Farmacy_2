namespace Farmacy.Forme
{
    partial class IsporukaStavkaEditForm
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
            this.lblIsporukaId = new System.Windows.Forms.Label();
            this.txtIsporukaId = new System.Windows.Forms.TextBox();
            this.lblPakovanjeId = new System.Windows.Forms.Label();
            this.txtPakovanjeId = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIsporukaId
            // 
            this.lblIsporukaId.AutoSize = true;
            this.lblIsporukaId.Location = new System.Drawing.Point(12, 15);
            this.lblIsporukaId.Name = "lblIsporukaId";
            this.lblIsporukaId.Size = new System.Drawing.Size(70, 13);
            this.lblIsporukaId.TabIndex = 0;
            this.lblIsporukaId.Text = "ID Isporuke:";
            // 
            // txtIsporukaId
            // 
            this.txtIsporukaId.Location = new System.Drawing.Point(120, 12);
            this.txtIsporukaId.Name = "txtIsporukaId";
            this.txtIsporukaId.Size = new System.Drawing.Size(150, 20);
            this.txtIsporukaId.TabIndex = 1;
            // 
            // lblPakovanjeId
            // 
            this.lblPakovanjeId.AutoSize = true;
            this.lblPakovanjeId.Location = new System.Drawing.Point(12, 41);
            this.lblPakovanjeId.Name = "lblPakovanjeId";
            this.lblPakovanjeId.Size = new System.Drawing.Size(82, 13);
            this.lblPakovanjeId.TabIndex = 2;
            this.lblPakovanjeId.Text = "ID Pakovanja:";
            // 
            // txtPakovanjeId
            // 
            this.txtPakovanjeId.Location = new System.Drawing.Point(120, 38);
            this.txtPakovanjeId.Name = "txtPakovanjeId";
            this.txtPakovanjeId.Size = new System.Drawing.Size(150, 20);
            this.txtPakovanjeId.TabIndex = 3;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(12, 67);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(47, 13);
            this.lblKolicina.TabIndex = 4;
            this.lblKolicina.Text = "Količina:";
            // 
            // numKolicina
            // 
            this.numKolicina.Location = new System.Drawing.Point(120, 64);
            this.numKolicina.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(150, 20);
            this.numKolicina.TabIndex = 5;
            this.numKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 100);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(201, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Otkaži";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // IsporukaStavkaEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 135);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.txtPakovanjeId);
            this.Controls.Add(this.lblPakovanjeId);
            this.Controls.Add(this.txtIsporukaId);
            this.Controls.Add(this.lblIsporukaId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IsporukaStavkaEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izmena Isporuke Stavke";
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblIsporukaId;
        private System.Windows.Forms.TextBox txtIsporukaId;
        private System.Windows.Forms.Label lblPakovanjeId;
        private System.Windows.Forms.TextBox txtPakovanjeId;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
