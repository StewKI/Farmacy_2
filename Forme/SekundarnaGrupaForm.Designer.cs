namespace Farmacy.Forme
{
    partial class SekundarnaGrupaForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvSekundarneGrupe;
        private System.Windows.Forms.Button btnNovaSekundarnaGrupa;
        private System.Windows.Forms.Button btnObrisiSekundarnuGrupu;
        private System.Windows.Forms.Button btnIzmeniSekundarnuGrupu;
        private System.Windows.Forms.Label lblSekundarneGrupe;

        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNaziv;

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
            dgvSekundarneGrupe = new DataGridView();
            btnNovaSekundarnaGrupa = new Button();
            btnObrisiSekundarnuGrupu = new Button();
            btnIzmeniSekundarnuGrupu = new Button();
            lblSekundarneGrupe = new Label();
            colId = new DataGridViewTextBoxColumn();
            colNaziv = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSekundarneGrupe).BeginInit();
            SuspendLayout();
            // 
            // dgvSekundarneGrupe
            // 
            dgvSekundarneGrupe.AllowUserToAddRows = false;
            dgvSekundarneGrupe.AllowUserToDeleteRows = false;
            dgvSekundarneGrupe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSekundarneGrupe.Columns.AddRange(new DataGridViewColumn[] { colId, colNaziv });
            dgvSekundarneGrupe.Location = new Point(12, 50);
            dgvSekundarneGrupe.MultiSelect = false;
            dgvSekundarneGrupe.Name = "dgvSekundarneGrupe";
            dgvSekundarneGrupe.ReadOnly = true;
            dgvSekundarneGrupe.RowHeadersVisible = false;
            dgvSekundarneGrupe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSekundarneGrupe.Size = new Size(600, 400);
            dgvSekundarneGrupe.TabIndex = 0;
            // 
            // btnNovaSekundarnaGrupa
            // 
            btnNovaSekundarnaGrupa.Location = new Point(650, 50);
            btnNovaSekundarnaGrupa.Name = "btnNovaSekundarnaGrupa";
            btnNovaSekundarnaGrupa.Size = new Size(150, 40);
            btnNovaSekundarnaGrupa.TabIndex = 1;
            btnNovaSekundarnaGrupa.Text = "Nova sekundarna grupa";
            btnNovaSekundarnaGrupa.UseVisualStyleBackColor = true;
            btnNovaSekundarnaGrupa.Click += btnNovaSekundarnaGrupa_Click;
            // 
            // btnObrisiSekundarnuGrupu
            // 
            btnObrisiSekundarnuGrupu.Location = new Point(650, 100);
            btnObrisiSekundarnuGrupu.Name = "btnObrisiSekundarnuGrupu";
            btnObrisiSekundarnuGrupu.Size = new Size(150, 40);
            btnObrisiSekundarnuGrupu.TabIndex = 2;
            btnObrisiSekundarnuGrupu.Text = "Obriši sekundarnu grupu";
            btnObrisiSekundarnuGrupu.UseVisualStyleBackColor = true;
            btnObrisiSekundarnuGrupu.Click += btnObrisiSekundarnuGrupu_Click;
            // 
            // btnIzmeniSekundarnuGrupu
            // 
            btnIzmeniSekundarnuGrupu.Location = new Point(650, 150);
            btnIzmeniSekundarnuGrupu.Name = "btnIzmeniSekundarnuGrupu";
            btnIzmeniSekundarnuGrupu.Size = new Size(150, 40);
            btnIzmeniSekundarnuGrupu.TabIndex = 3;
            btnIzmeniSekundarnuGrupu.Text = "Izmeni sekundarnu grupu";
            btnIzmeniSekundarnuGrupu.UseVisualStyleBackColor = true;
            btnIzmeniSekundarnuGrupu.Click += btnIzmeniSekundarnuGrupu_Click;
            // 
            // lblSekundarneGrupe
            // 
            lblSekundarneGrupe.AutoSize = true;
            lblSekundarneGrupe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSekundarneGrupe.Location = new Point(12, 15);
            lblSekundarneGrupe.Name = "lblSekundarneGrupe";
            lblSekundarneGrupe.Size = new Size(170, 21);
            lblSekundarneGrupe.TabIndex = 4;
            lblSekundarneGrupe.Text = "Sekundarne grupe";
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 60;
            // 
            // colNaziv
            // 
            colNaziv.DataPropertyName = "Naziv";
            colNaziv.HeaderText = "Naziv";
            colNaziv.Name = "colNaziv";
            colNaziv.ReadOnly = true;
            colNaziv.Width = 500;
            // 
            // SekundarnaGrupaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 470);
            Controls.Add(lblSekundarneGrupe);
            Controls.Add(btnIzmeniSekundarnuGrupu);
            Controls.Add(btnObrisiSekundarnuGrupu);
            Controls.Add(btnNovaSekundarnaGrupa);
            Controls.Add(dgvSekundarneGrupe);
            Name = "SekundarnaGrupaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sekundarne grupe";
            ((System.ComponentModel.ISupportInitialize)dgvSekundarneGrupe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}