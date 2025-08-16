namespace Farmacy.Forme
{
    partial class IsporukaForm
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblDistributer = new System.Windows.Forms.Label();
            this.txtDistributer = new System.Windows.Forms.TextBox();
            this.lblProdajnaJedinica = new System.Windows.Forms.Label();
            this.txtProdajnaJedinica = new System.Windows.Forms.TextBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lblMagacioner = new System.Windows.Forms.Label();
            this.txtMagacioner = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(30, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(150, 27);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(200, 23);
            this.txtId.TabIndex = 1;
            this.txtId.TabStop = false;
            // 
            // lblDistributer
            // 
            this.lblDistributer.AutoSize = true;
            this.lblDistributer.Location = new System.Drawing.Point(30, 70);
            this.lblDistributer.Name = "lblDistributer";
            this.lblDistributer.Size = new System.Drawing.Size(65, 15);
            this.lblDistributer.TabIndex = 2;
            this.lblDistributer.Text = "Distributer:";
            // 
            // txtDistributer
            // 
            this.txtDistributer.Location = new System.Drawing.Point(150, 67);
            this.txtDistributer.Name = "txtDistributer";
            this.txtDistributer.Size = new System.Drawing.Size(200, 23);
            this.txtDistributer.TabIndex = 3;
            // 
            // lblProdajnaJedinica
            // 
            this.lblProdajnaJedinica.AutoSize = true;
            this.lblProdajnaJedinica.Location = new System.Drawing.Point(30, 110);
            this.lblProdajnaJedinica.Name = "lblProdajnaJedinica";
            this.lblProdajnaJedinica.Size = new System.Drawing.Size(100, 15);
            this.lblProdajnaJedinica.TabIndex = 4;
            this.lblProdajnaJedinica.Text = "Prodajna jedinica:";
            // 
            // txtProdajnaJedinica
            // 
            this.txtProdajnaJedinica.Location = new System.Drawing.Point(150, 107);
            this.txtProdajnaJedinica.Name = "txtProdajnaJedinica";
            this.txtProdajnaJedinica.Size = new System.Drawing.Size(200, 23);
            this.txtProdajnaJedinica.TabIndex = 5;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(30, 150);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(45, 15);
            this.lblDatum.TabIndex = 6;
            this.lblDatum.Text = "Datum:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(150, 147);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 23);
            this.dtpDatum.TabIndex = 7;
            // 
            // lblMagacioner
            // 
            this.lblMagacioner.AutoSize = true;
            this.lblMagacioner.Location = new System.Drawing.Point(30, 190);
            this.lblMagacioner.Name = "lblMagacioner";
            this.lblMagacioner.Size = new System.Drawing.Size(75, 15);
            this.lblMagacioner.TabIndex = 8;
            this.lblMagacioner.Text = "Magacioner:";
            // 
            // txtMagacioner
            // 
            this.txtMagacioner.Location = new System.Drawing.Point(150, 187);
            this.txtMagacioner.Name = "txtMagacioner";
            this.txtMagacioner.Size = new System.Drawing.Size(200, 23);
            this.txtMagacioner.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(275, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Otkaži";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // IsporukaForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(384, 280);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMagacioner);
            this.Controls.Add(this.lblMagacioner);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.txtProdajnaJedinica);
            this.Controls.Add(this.lblProdajnaJedinica);
            this.Controls.Add(this.txtDistributer);
            this.Controls.Add(this.lblDistributer);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IsporukaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Isporuka";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblDistributer;
        private System.Windows.Forms.TextBox txtDistributer;
        private System.Windows.Forms.Label lblProdajnaJedinica;
        private System.Windows.Forms.TextBox txtProdajnaJedinica;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lblMagacioner;
        private System.Windows.Forms.TextBox txtMagacioner;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
