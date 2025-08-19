namespace Farmacy.Forme
{
    partial class IsporukaStavkaForm
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
            lblIsporukaId = new Label();
            txtIsporukaId = new TextBox();
            lblPakovanjeId = new Label();
            txtPakovanjeId = new TextBox();
            lblKolicina = new Label();
            numKolicina = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numKolicina).BeginInit();
            SuspendLayout();
            // 
            // lblIsporukaId
            // 
            lblIsporukaId.AutoSize = true;
            lblIsporukaId.Location = new Point(14, 17);
            lblIsporukaId.Margin = new Padding(4, 0, 4, 0);
            lblIsporukaId.Name = "lblIsporukaId";
            lblIsporukaId.Size = new Size(69, 15);
            lblIsporukaId.TabIndex = 0;
            lblIsporukaId.Text = "ID Isporuke:";
            // 
            // txtIsporukaId
            // 
            txtIsporukaId.Location = new Point(140, 14);
            txtIsporukaId.Margin = new Padding(4, 3, 4, 3);
            txtIsporukaId.Name = "txtIsporukaId";
            txtIsporukaId.Size = new Size(174, 23);
            txtIsporukaId.TabIndex = 1;
            // 
            // lblPakovanjeId
            // 
            lblPakovanjeId.AutoSize = true;
            lblPakovanjeId.Location = new Point(14, 47);
            lblPakovanjeId.Margin = new Padding(4, 0, 4, 0);
            lblPakovanjeId.Name = "lblPakovanjeId";
            lblPakovanjeId.Size = new Size(78, 15);
            lblPakovanjeId.TabIndex = 2;
            lblPakovanjeId.Text = "ID Pakovanja:";
            // 
            // txtPakovanjeId
            // 
            txtPakovanjeId.Location = new Point(140, 44);
            txtPakovanjeId.Margin = new Padding(4, 3, 4, 3);
            txtPakovanjeId.Name = "txtPakovanjeId";
            txtPakovanjeId.Size = new Size(174, 23);
            txtPakovanjeId.TabIndex = 3;
            // 
            // lblKolicina
            // 
            lblKolicina.AutoSize = true;
            lblKolicina.Location = new Point(14, 77);
            lblKolicina.Margin = new Padding(4, 0, 4, 0);
            lblKolicina.Name = "lblKolicina";
            lblKolicina.Size = new Size(52, 15);
            lblKolicina.TabIndex = 4;
            lblKolicina.Text = "Količina:";
            // 
            // numKolicina
            // 
            numKolicina.Location = new Point(140, 74);
            numKolicina.Margin = new Padding(4, 3, 4, 3);
            numKolicina.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numKolicina.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numKolicina.Name = "numKolicina";
            numKolicina.Size = new Size(175, 23);
            numKolicina.TabIndex = 5;
            numKolicina.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSave
            // 
            btnSave.Location = new Point(140, 115);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 27);
            btnSave.TabIndex = 6;
            btnSave.Text = "Sačuvaj";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(234, 115);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 27);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Otkaži";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // IsporukaStavkaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 156);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(numKolicina);
            Controls.Add(lblKolicina);
            Controls.Add(txtPakovanjeId);
            Controls.Add(lblPakovanjeId);
            Controls.Add(txtIsporukaId);
            Controls.Add(lblIsporukaId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "IsporukaStavkaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Isporuka Stavka";
            Load += IsporukaStavkaForm_Load;
            ((System.ComponentModel.ISupportInitialize)numKolicina).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
