namespace Farmacy.Forme
{
    partial class LekSekundarnaForm
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
            lblLekId = new Label();
            txtLekId = new TextBox();
            lblKategorijaId = new Label();
            txtKategorijaId = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblLekId
            // 
            lblLekId.AutoSize = true;
            lblLekId.Location = new Point(14, 17);
            lblLekId.Margin = new Padding(4, 0, 4, 0);
            lblLekId.Name = "lblLekId";
            lblLekId.Size = new Size(48, 15);
            lblLekId.TabIndex = 0;
            lblLekId.Text = "ID Leka:";
            // 
            // txtLekId
            // 
            txtLekId.Location = new Point(140, 14);
            txtLekId.Margin = new Padding(4, 3, 4, 3);
            txtLekId.Name = "txtLekId";
            txtLekId.ReadOnly = true;
            txtLekId.Size = new Size(174, 23);
            txtLekId.TabIndex = 1;
            // 
            // lblKategorijaId
            // 
            lblKategorijaId.AutoSize = true;
            lblKategorijaId.Location = new Point(14, 47);
            lblKategorijaId.Margin = new Padding(4, 0, 4, 0);
            lblKategorijaId.Name = "lblKategorijaId";
            lblKategorijaId.Size = new Size(77, 15);
            lblKategorijaId.TabIndex = 2;
            lblKategorijaId.Text = "ID Kategorije:";
            // 
            // txtKategorijaId
            // 
            txtKategorijaId.Location = new Point(140, 44);
            txtKategorijaId.Margin = new Padding(4, 3, 4, 3);
            txtKategorijaId.Name = "txtKategorijaId";
            txtKategorijaId.Size = new Size(174, 23);
            txtKategorijaId.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(140, 85);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 27);
            btnSave.TabIndex = 4;
            btnSave.Text = "Sačuvaj";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(234, 85);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 27);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Otkaži";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // LekSekundarnaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 126);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtKategorijaId);
            Controls.Add(lblKategorijaId);
            Controls.Add(txtLekId);
            Controls.Add(lblLekId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LekSekundarnaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lek Sekundarna";
            Load += LekSekundarnaForm_Load;
            ResumeLayout(false);
            PerformLayout();
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
