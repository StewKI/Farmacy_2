namespace Farmacy.Forme
{
    partial class PrimarnaGrupaForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvPrimarneGrupe;
        private System.Windows.Forms.Button btnNovaPrimarnaGrupa;
        private System.Windows.Forms.Button btnObrisiPrimarnuGrupu;
        private System.Windows.Forms.Button btnIzmeniPrimarnuGrupu;
        private System.Windows.Forms.Label lblPrimarneGrupe;

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
            dgvPrimarneGrupe = new DataGridView();
            btnNovaPrimarnaGrupa = new Button();
            btnObrisiPrimarnuGrupu = new Button();
            btnIzmeniPrimarnuGrupu = new Button();
            lblPrimarneGrupe = new Label();
            colId = new DataGridViewTextBoxColumn();
            colNaziv = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPrimarneGrupe).BeginInit();
            SuspendLayout();
            // 
            // dgvPrimarneGrupe
            // 
            dgvPrimarneGrupe.AllowUserToAddRows = false;
            dgvPrimarneGrupe.AllowUserToDeleteRows = false;
            dgvPrimarneGrupe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrimarneGrupe.Columns.AddRange(new DataGridViewColumn[] { colId, colNaziv });
            dgvPrimarneGrupe.Location = new Point(12, 50);
            dgvPrimarneGrupe.MultiSelect = false;
            dgvPrimarneGrupe.Name = "dgvPrimarneGrupe";
            dgvPrimarneGrupe.ReadOnly = true;
            dgvPrimarneGrupe.RowHeadersVisible = false;
            dgvPrimarneGrupe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrimarneGrupe.Size = new Size(600, 400);
            dgvPrimarneGrupe.TabIndex = 0;
            // 
            // btnNovaPrimarnaGrupa
            // 
            btnNovaPrimarnaGrupa.Location = new Point(650, 50);
            btnNovaPrimarnaGrupa.Name = "btnNovaPrimarnaGrupa";
            btnNovaPrimarnaGrupa.Size = new Size(150, 40);
            btnNovaPrimarnaGrupa.TabIndex = 1;
            btnNovaPrimarnaGrupa.Text = "Nova primarna grupa";
            btnNovaPrimarnaGrupa.UseVisualStyleBackColor = true;
            btnNovaPrimarnaGrupa.Click += btnNovaPrimarnaGrupa_Click;
            // 
            // btnObrisiPrimarnuGrupu
            // 
            btnObrisiPrimarnuGrupu.Location = new Point(650, 100);
            btnObrisiPrimarnuGrupu.Name = "btnObrisiPrimarnuGrupu";
            btnObrisiPrimarnuGrupu.Size = new Size(150, 40);
            btnObrisiPrimarnuGrupu.TabIndex = 2;
            btnObrisiPrimarnuGrupu.Text = "Obriši primarnu grupu";
            btnObrisiPrimarnuGrupu.UseVisualStyleBackColor = true;
            btnObrisiPrimarnuGrupu.Click += btnObrisiPrimarnuGrupu_Click;
            // 
            // btnIzmeniPrimarnuGrupu
            // 
            btnIzmeniPrimarnuGrupu.Location = new Point(650, 150);
            btnIzmeniPrimarnuGrupu.Name = "btnIzmeniPrimarnuGrupu";
            btnIzmeniPrimarnuGrupu.Size = new Size(150, 40);
            btnIzmeniPrimarnuGrupu.TabIndex = 3;
            btnIzmeniPrimarnuGrupu.Text = "Izmeni primarnu grupu";
            btnIzmeniPrimarnuGrupu.UseVisualStyleBackColor = true;
            btnIzmeniPrimarnuGrupu.Click += btnIzmeniPrimarnuGrupu_Click;
            // 
            // lblPrimarneGrupe
            // 
            lblPrimarneGrupe.AutoSize = true;
            lblPrimarneGrupe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPrimarneGrupe.Location = new Point(12, 15);
            lblPrimarneGrupe.Name = "lblPrimarneGrupe";
            lblPrimarneGrupe.Size = new Size(150, 21);
            lblPrimarneGrupe.TabIndex = 4;
            lblPrimarneGrupe.Text = "Primarne grupe";
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
            // PrimarnaGrupaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 470);
            Controls.Add(lblPrimarneGrupe);
            Controls.Add(btnIzmeniPrimarnuGrupu);
            Controls.Add(btnObrisiPrimarnuGrupu);
            Controls.Add(btnNovaPrimarnaGrupa);
            Controls.Add(dgvPrimarneGrupe);
            Name = "PrimarnaGrupaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Primarne grupe";
            ((System.ComponentModel.ISupportInitialize)dgvPrimarneGrupe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
