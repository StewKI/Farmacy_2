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
            this.lblMenadzerId = new System.Windows.Forms.Label();
            this.txtMenadzerId = new System.Windows.Forms.TextBox();
            this.lblProdajnaJedinicaId = new System.Windows.Forms.Label();
            this.txtProdajnaJedinicaId = new System.Windows.Forms.TextBox();
            this.lblOd = new System.Windows.Forms.Label();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.lblDo = new System.Windows.Forms.Label();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.chkDo = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenadzerId
            // 
            this.lblMenadzerId.AutoSize = true;
            this.lblMenadzerId.Location = new System.Drawing.Point(12, 15);
            this.lblMenadzerId.Name = "lblMenadzerId";
            this.lblMenadzerId.Size = new System.Drawing.Size(82, 13);
            this.lblMenadzerId.TabIndex = 0;
            this.lblMenadzerId.Text = "ID Menadžera:";
            // 
            // txtMenadzerId
            // 
            this.txtMenadzerId.Location = new System.Drawing.Point(120, 12);
            this.txtMenadzerId.Name = "txtMenadzerId";
            this.txtMenadzerId.Size = new System.Drawing.Size(150, 20);
            this.txtMenadzerId.TabIndex = 1;
            // 
            // lblProdajnaJedinicaId
            // 
            this.lblProdajnaJedinicaId.AutoSize = true;
            this.lblProdajnaJedinicaId.Location = new System.Drawing.Point(12, 41);
            this.lblProdajnaJedinicaId.Name = "lblProdajnaJedinicaId";
            this.lblProdajnaJedinicaId.Size = new System.Drawing.Size(105, 13);
            this.lblProdajnaJedinicaId.TabIndex = 2;
            this.lblProdajnaJedinicaId.Text = "ID Prodajne Jedinice:";
            // 
            // txtProdajnaJedinicaId
            // 
            this.txtProdajnaJedinicaId.Location = new System.Drawing.Point(120, 38);
            this.txtProdajnaJedinicaId.Name = "txtProdajnaJedinicaId";
            this.txtProdajnaJedinicaId.Size = new System.Drawing.Size(150, 20);
            this.txtProdajnaJedinicaId.TabIndex = 3;
            // 
            // lblOd
            // 
            this.lblOd.AutoSize = true;
            this.lblOd.Location = new System.Drawing.Point(12, 67);
            this.lblOd.Name = "lblOd";
            this.lblOd.Size = new System.Drawing.Size(23, 13);
            this.lblOd.TabIndex = 4;
            this.lblOd.Text = "Od:";
            // 
            // dtpOd
            // 
            this.dtpOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOd.Location = new System.Drawing.Point(120, 64);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(150, 20);
            this.dtpOd.TabIndex = 5;
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.Location = new System.Drawing.Point(12, 93);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(23, 13);
            this.lblDo.TabIndex = 6;
            this.lblDo.Text = "Do:";
            // 
            // dtpDo
            // 
            this.dtpDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDo.Location = new System.Drawing.Point(120, 90);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(150, 20);
            this.dtpDo.TabIndex = 7;
            // 
            // chkDo
            // 
            this.chkDo.AutoSize = true;
            this.chkDo.Location = new System.Drawing.Point(276, 92);
            this.chkDo.Name = "chkDo";
            this.chkDo.Size = new System.Drawing.Size(15, 14);
            this.chkDo.TabIndex = 8;
            this.chkDo.UseVisualStyleBackColor = true;
            this.chkDo.CheckedChanged += new System.EventHandler(this.chkDo_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 126);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(201, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Otkaži";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MenadzerApotekaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 161);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkDo);
            this.Controls.Add(this.dtpDo);
            this.Controls.Add(this.lblDo);
            this.Controls.Add(this.dtpOd);
            this.Controls.Add(this.lblOd);
            this.Controls.Add(this.txtProdajnaJedinicaId);
            this.Controls.Add(this.lblProdajnaJedinicaId);
            this.Controls.Add(this.txtMenadzerId);
            this.Controls.Add(this.lblMenadzerId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenadzerApotekaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menadžer Apoteka";
            this.ResumeLayout(false);
            this.PerformLayout();
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
