namespace Farmacy.Forme
{
    partial class RadnoVremeEditForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label lblProdajnaJedinica;
        private System.Windows.Forms.TextBox txtProdajnaJedinica;
        private System.Windows.Forms.Label lblDan;
        private System.Windows.Forms.ComboBox cboDan;
        private System.Windows.Forms.Label lblVremeOd;
        private System.Windows.Forms.DateTimePicker dtpVremeOd;
        private System.Windows.Forms.Label lblVremeDo;
        private System.Windows.Forms.DateTimePicker dtpVremeDo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            panelMain = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            dtpVremeDo = new DateTimePicker();
            lblVremeDo = new Label();
            dtpVremeOd = new DateTimePicker();
            lblVremeOd = new Label();
            cboDan = new ComboBox();
            lblDan = new Label();
            txtProdajnaJedinica = new TextBox();
            lblProdajnaJedinica = new Label();
            panelFooter = new Panel();
            lblFooter = new Label();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(155, 89, 182);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(600, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(348, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "✏️ IZMENA RADNOG VREMENA";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(189, 195, 199);
            lblSubtitle.Location = new Point(20, 45);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(302, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Izmena postojećih podataka o radnom vremenu";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 250);
            panelMain.Controls.Add(btnCancel);
            panelMain.Controls.Add(btnSave);
            panelMain.Controls.Add(dtpVremeDo);
            panelMain.Controls.Add(lblVremeDo);
            panelMain.Controls.Add(dtpVremeOd);
            panelMain.Controls.Add(lblVremeOd);
            panelMain.Controls.Add(cboDan);
            panelMain.Controls.Add(lblDan);
            panelMain.Controls.Add(txtProdajnaJedinica);
            panelMain.Controls.Add(lblProdajnaJedinica);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 80);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(616, 389);
            panelMain.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(330, 200);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "❌ Otkaži";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 204, 113);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(200, 200);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 40);
            btnSave.TabIndex = 8;
            btnSave.Text = "💾 Sačuvaj";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dtpVremeDo
            // 
            dtpVremeDo.Font = new Font("Segoe UI", 10F);
            dtpVremeDo.Format = DateTimePickerFormat.Time;
            dtpVremeDo.Location = new Point(200, 147);
            dtpVremeDo.Name = "dtpVremeDo";
            dtpVremeDo.ShowUpDown = true;
            dtpVremeDo.Size = new Size(120, 25);
            dtpVremeDo.TabIndex = 7;
            // 
            // lblVremeDo
            // 
            lblVremeDo.AutoSize = true;
            lblVremeDo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVremeDo.ForeColor = Color.FromArgb(44, 62, 80);
            lblVremeDo.Location = new Point(50, 150);
            lblVremeDo.Name = "lblVremeDo";
            lblVremeDo.Size = new Size(79, 19);
            lblVremeDo.TabIndex = 6;
            lblVremeDo.Text = "Vreme do:";
            // 
            // dtpVremeOd
            // 
            dtpVremeOd.Font = new Font("Segoe UI", 10F);
            dtpVremeOd.Format = DateTimePickerFormat.Time;
            dtpVremeOd.Location = new Point(200, 107);
            dtpVremeOd.Name = "dtpVremeOd";
            dtpVremeOd.ShowUpDown = true;
            dtpVremeOd.Size = new Size(120, 25);
            dtpVremeOd.TabIndex = 5;
            // 
            // lblVremeOd
            // 
            lblVremeOd.AutoSize = true;
            lblVremeOd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVremeOd.ForeColor = Color.FromArgb(44, 62, 80);
            lblVremeOd.Location = new Point(50, 110);
            lblVremeOd.Name = "lblVremeOd";
            lblVremeOd.Size = new Size(79, 19);
            lblVremeOd.TabIndex = 4;
            lblVremeOd.Text = "Vreme od:";
            // 
            // cboDan
            // 
            cboDan.BackColor = Color.White;
            cboDan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDan.FlatStyle = FlatStyle.Flat;
            cboDan.Font = new Font("Segoe UI", 10F);
            cboDan.FormattingEnabled = true;
            cboDan.Location = new Point(200, 67);
            cboDan.Name = "cboDan";
            cboDan.Size = new Size(250, 25);
            cboDan.TabIndex = 3;
            // 
            // lblDan
            // 
            lblDan.AutoSize = true;
            lblDan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDan.ForeColor = Color.FromArgb(44, 62, 80);
            lblDan.Location = new Point(50, 70);
            lblDan.Name = "lblDan";
            lblDan.Size = new Size(39, 19);
            lblDan.TabIndex = 2;
            lblDan.Text = "Dan:";
            // 
            // txtProdajnaJedinica
            // 
            txtProdajnaJedinica.BackColor = Color.White;
            txtProdajnaJedinica.BorderStyle = BorderStyle.FixedSingle;
            txtProdajnaJedinica.Font = new Font("Segoe UI", 10F);
            txtProdajnaJedinica.Location = new Point(200, 27);
            txtProdajnaJedinica.Name = "txtProdajnaJedinica";
            txtProdajnaJedinica.ReadOnly = true;
            txtProdajnaJedinica.Size = new Size(250, 25);
            txtProdajnaJedinica.TabIndex = 1;
            txtProdajnaJedinica.TabStop = false;
            // 
            // lblProdajnaJedinica
            // 
            lblProdajnaJedinica.AutoSize = true;
            lblProdajnaJedinica.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProdajnaJedinica.ForeColor = Color.FromArgb(44, 62, 80);
            lblProdajnaJedinica.Location = new Point(50, 30);
            lblProdajnaJedinica.Name = "lblProdajnaJedinica";
            lblProdajnaJedinica.Size = new Size(130, 19);
            lblProdajnaJedinica.TabIndex = 0;
            lblProdajnaJedinica.Text = "Prodajna jedinica:";
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(44, 62, 80);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 430);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(600, 30);
            panelFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 8F);
            lblFooter.ForeColor = Color.FromArgb(189, 195, 199);
            lblFooter.Location = new Point(20, 8);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(244, 13);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Sistem za upravljanje farmaceutskim podacima";
            // 
            // RadnoVremeEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(616, 499);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Controls.Add(panelFooter);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RadnoVremeEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Izmena radnog vremena - Upravljanje radnim vremenom";
            Load += RadnoVremeEditForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }
    }
}