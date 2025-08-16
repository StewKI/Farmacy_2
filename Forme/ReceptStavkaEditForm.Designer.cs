namespace Farmacy_2.Forme
{
    partial class ReceptStavkaEditForm
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
            this.lblRecept = new System.Windows.Forms.Label();
            this.txtRecept = new System.Windows.Forms.TextBox();
            this.lblPakovanje = new System.Windows.Forms.Label();
            this.txtPakovanje = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.lblPreporucenaDoza = new System.Windows.Forms.Label();
            this.txtPreporucenaDoza = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecept
            // 
            this.lblRecept.AutoSize = true;
            this.lblRecept.Location = new System.Drawing.Point(12, 15);
            this.lblRecept.Name = "lblRecept";
            this.lblRecept.Size = new System.Drawing.Size(47, 15);
            this.lblRecept.TabIndex = 0;
            this.lblRecept.Text = "Recept:";
            // 
            // txtRecept
            // 
            this.txtRecept.Location = new System.Drawing.Point(120, 12);
            this.txtRecept.Name = "txtRecept";
            this.txtRecept.ReadOnly = true;
            this.txtRecept.Size = new System.Drawing.Size(200, 23);
            this.txtRecept.TabIndex = 1;
            // 
            // lblPakovanje
            // 
            this.lblPakovanje.AutoSize = true;
            this.lblPakovanje.Location = new System.Drawing.Point(12, 44);
            this.lblPakovanje.Name = "lblPakovanje";
            this.lblPakovanje.Size = new System.Drawing.Size(70, 15);
            this.lblPakovanje.TabIndex = 2;
            this.lblPakovanje.Text = "Pakovanje:";
            // 
            // txtPakovanje
            // 
            this.txtPakovanje.Location = new System.Drawing.Point(120, 41);
            this.txtPakovanje.Name = "txtPakovanje";
            this.txtPakovanje.ReadOnly = true;
            this.txtPakovanje.Size = new System.Drawing.Size(200, 23);
            this.txtPakovanje.TabIndex = 3;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(12, 73);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(54, 15);
            this.lblKolicina.TabIndex = 4;
            this.lblKolicina.Text = "Količina:";
            // 
            // numKolicina
            // 
            this.numKolicina.Location = new System.Drawing.Point(120, 70);
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
            this.numKolicina.Size = new System.Drawing.Size(120, 23);
            this.numKolicina.TabIndex = 5;
            this.numKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPreporucenaDoza
            // 
            this.lblPreporucenaDoza.AutoSize = true;
            this.lblPreporucenaDoza.Location = new System.Drawing.Point(12, 102);
            this.lblPreporucenaDoza.Name = "lblPreporucenaDoza";
            this.lblPreporucenaDoza.Size = new System.Drawing.Size(100, 15);
            this.lblPreporucenaDoza.TabIndex = 6;
            this.lblPreporucenaDoza.Text = "Preporučena doza:";
            // 
            // txtPreporucenaDoza
            // 
            this.txtPreporucenaDoza.Location = new System.Drawing.Point(120, 99);
            this.txtPreporucenaDoza.Name = "txtPreporucenaDoza";
            this.txtPreporucenaDoza.Size = new System.Drawing.Size(200, 23);
            this.txtPreporucenaDoza.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(245, 140);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Otkaži";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ReceptStavkaEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 181);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPreporucenaDoza);
            this.Controls.Add(this.lblPreporucenaDoza);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.txtPakovanje);
            this.Controls.Add(this.lblPakovanje);
            this.Controls.Add(this.txtRecept);
            this.Controls.Add(this.lblRecept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReceptStavkaEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izmena stavke recepta";
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecept;
        private System.Windows.Forms.TextBox txtRecept;
        private System.Windows.Forms.Label lblPakovanje;
        private System.Windows.Forms.TextBox txtPakovanje;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.Label lblPreporucenaDoza;
        private System.Windows.Forms.TextBox txtPreporucenaDoza;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
