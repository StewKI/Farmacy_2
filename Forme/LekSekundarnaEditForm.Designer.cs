namespace Farmacy.Forme
{
    partial class LekSekundarnaEditForm
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
            this.lblLekId = new System.Windows.Forms.Label();
            this.txtLekId = new System.Windows.Forms.TextBox();
            this.lblKategorijaId = new System.Windows.Forms.Label();
            this.txtKategorijaId = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLekId
            // 
            this.lblLekId.AutoSize = true;
            this.lblLekId.Location = new System.Drawing.Point(12, 15);
            this.lblLekId.Name = "lblLekId";
            this.lblLekId.Size = new System.Drawing.Size(45, 13);
            this.lblLekId.TabIndex = 0;
            this.lblLekId.Text = "ID Leka:";
            // 
            // txtLekId
            // 
            this.txtLekId.Location = new System.Drawing.Point(120, 12);
            this.txtLekId.Name = "txtLekId";
            this.txtLekId.Size = new System.Drawing.Size(150, 20);
            this.txtLekId.TabIndex = 1;
            // 
            // lblKategorijaId
            // 
            this.lblKategorijaId.AutoSize = true;
            this.lblKategorijaId.Location = new System.Drawing.Point(12, 41);
            this.lblKategorijaId.Name = "lblKategorijaId";
            this.lblKategorijaId.Size = new System.Drawing.Size(75, 13);
            this.lblKategorijaId.TabIndex = 2;
            this.lblKategorijaId.Text = "ID Kategorije:";
            // 
            // txtKategorijaId
            // 
            this.txtKategorijaId.Location = new System.Drawing.Point(120, 38);
            this.txtKategorijaId.Name = "txtKategorijaId";
            this.txtKategorijaId.Size = new System.Drawing.Size(150, 20);
            this.txtKategorijaId.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 74);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(201, 74);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Otkaži";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // LekSekundarnaEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 109);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtKategorijaId);
            this.Controls.Add(this.lblKategorijaId);
            this.Controls.Add(this.txtLekId);
            this.Controls.Add(this.lblLekId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LekSekundarnaEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izmena Lek Sekundarna";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblLekId;
        private System.Windows.Forms.TextBox txtLekId;
        private System.Windows.Forms.Label lblKategorijaId;
        private System.Windows.Forms.TextBox txtKategorijaId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
