namespace Farmacy.Forme
{
    partial class MenadzerApotekaForm
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
            lblMenadzerId = new Label();
            txtMenadzerId = new TextBox();
            lblProdajnaJedinicaId = new Label();
            txtProdajnaJedinicaId = new TextBox();
            lblOd = new Label();
            dtpOd = new DateTimePicker();
            lblDo = new Label();
            dtpDo = new DateTimePicker();
            chkDo = new CheckBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblMenadzerId
            // 
            lblMenadzerId.AutoSize = true;
            lblMenadzerId.Location = new Point(14, 17);
            lblMenadzerId.Margin = new Padding(4, 0, 4, 0);
            lblMenadzerId.Name = "lblMenadzerId";
            lblMenadzerId.Size = new Size(82, 15);
            lblMenadzerId.TabIndex = 0;
            lblMenadzerId.Text = "ID Menadžera:";
            // 
            // txtMenadzerId
            // 
            txtMenadzerId.Location = new Point(140, 14);
            txtMenadzerId.Margin = new Padding(4, 3, 4, 3);
            txtMenadzerId.Name = "txtMenadzerId";
            txtMenadzerId.Size = new Size(174, 23);
            txtMenadzerId.TabIndex = 1;
            // 
            // lblProdajnaJedinicaId
            // 
            lblProdajnaJedinicaId.AutoSize = true;
            lblProdajnaJedinicaId.Location = new Point(14, 47);
            lblProdajnaJedinicaId.Margin = new Padding(4, 0, 4, 0);
            lblProdajnaJedinicaId.Name = "lblProdajnaJedinicaId";
            lblProdajnaJedinicaId.Size = new Size(116, 15);
            lblProdajnaJedinicaId.TabIndex = 2;
            lblProdajnaJedinicaId.Text = "ID Prodajne Jedinice:";
            // 
            // txtProdajnaJedinicaId
            // 
            txtProdajnaJedinicaId.Location = new Point(140, 44);
            txtProdajnaJedinicaId.Margin = new Padding(4, 3, 4, 3);
            txtProdajnaJedinicaId.Name = "txtProdajnaJedinicaId";
            txtProdajnaJedinicaId.ReadOnly = true;
            txtProdajnaJedinicaId.Size = new Size(174, 23);
            txtProdajnaJedinicaId.TabIndex = 3;
            // 
            // lblOd
            // 
            lblOd.AutoSize = true;
            lblOd.Location = new Point(14, 77);
            lblOd.Margin = new Padding(4, 0, 4, 0);
            lblOd.Name = "lblOd";
            lblOd.Size = new Size(26, 15);
            lblOd.TabIndex = 4;
            lblOd.Text = "Od:";
            // 
            // dtpOd
            // 
            dtpOd.Format = DateTimePickerFormat.Short;
            dtpOd.Location = new Point(140, 74);
            dtpOd.Margin = new Padding(4, 3, 4, 3);
            dtpOd.Name = "dtpOd";
            dtpOd.Size = new Size(174, 23);
            dtpOd.TabIndex = 5;
            // 
            // lblDo
            // 
            lblDo.AutoSize = true;
            lblDo.Location = new Point(14, 107);
            lblDo.Margin = new Padding(4, 0, 4, 0);
            lblDo.Name = "lblDo";
            lblDo.Size = new Size(25, 15);
            lblDo.TabIndex = 6;
            lblDo.Text = "Do:";
            // 
            // dtpDo
            // 
            dtpDo.Format = DateTimePickerFormat.Short;
            dtpDo.Location = new Point(140, 104);
            dtpDo.Margin = new Padding(4, 3, 4, 3);
            dtpDo.Name = "dtpDo";
            dtpDo.Size = new Size(174, 23);
            dtpDo.TabIndex = 7;
            // 
            // chkDo
            // 
            chkDo.AutoSize = true;
            chkDo.Location = new Point(322, 106);
            chkDo.Margin = new Padding(4, 3, 4, 3);
            chkDo.Name = "chkDo";
            chkDo.Size = new Size(15, 14);
            chkDo.TabIndex = 8;
            chkDo.UseVisualStyleBackColor = true;
            chkDo.CheckedChanged += chkDo_CheckedChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(140, 145);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 27);
            btnSave.TabIndex = 9;
            btnSave.Text = "Sačuvaj";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(234, 145);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 27);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Otkaži";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // MenadzerApotekaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 186);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(chkDo);
            Controls.Add(dtpDo);
            Controls.Add(lblDo);
            Controls.Add(dtpOd);
            Controls.Add(lblOd);
            Controls.Add(txtProdajnaJedinicaId);
            Controls.Add(lblProdajnaJedinicaId);
            Controls.Add(txtMenadzerId);
            Controls.Add(lblMenadzerId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MenadzerApotekaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Menadžer Apoteka";
            Load += MenadzerApotekaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMenadzerId;
        private System.Windows.Forms.TextBox txtMenadzerId;
        private System.Windows.Forms.Label lblProdajnaJedinicaId;
        private System.Windows.Forms.TextBox txtProdajnaJedinicaId;
        private System.Windows.Forms.Label lblOd;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.CheckBox chkDo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
