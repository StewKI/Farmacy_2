namespace Farmacy.Forme
{
    partial class PakovanjeForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvPakovanja;
        private System.Windows.Forms.Button btnNovoPakovanje;
        private System.Windows.Forms.Button btnObrisiPakovanje;
        private System.Windows.Forms.Button btnIzmeniPakovanje;
        private System.Windows.Forms.Label lblPakovanja;
        private System.Windows.Forms.ComboBox cmbLek;
        private System.Windows.Forms.ComboBox cmbOblik;

        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLek;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOblik;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVelicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKolicinaAktivne;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJedinicaMere;

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
            dgvPakovanja = new DataGridView();
            btnNovoPakovanje = new Button();
            btnObrisiPakovanje = new Button();
            btnIzmeniPakovanje = new Button();
            lblPakovanja = new Label();
            cmbLek = new ComboBox();
            cmbOblik = new ComboBox();
            colId = new DataGridViewTextBoxColumn();
            colLek = new DataGridViewTextBoxColumn();
            colOblik = new DataGridViewTextBoxColumn();
            colVelicina = new DataGridViewTextBoxColumn();
            colKolicinaAktivne = new DataGridViewTextBoxColumn();
            colJedinicaMere = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPakovanja).BeginInit();
            SuspendLayout();
            // 
            // dgvPakovanja
            // 
            dgvPakovanja.AllowUserToAddRows = false;
            dgvPakovanja.AllowUserToDeleteRows = false;
            dgvPakovanja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPakovanja.Columns.AddRange(new DataGridViewColumn[] { colId, colLek, colOblik, colVelicina, colKolicinaAktivne, colJedinicaMere });
            dgvPakovanja.Location = new Point(12, 50);
            dgvPakovanja.MultiSelect = false;
            dgvPakovanja.Name = "dgvPakovanja";
            dgvPakovanja.ReadOnly = true;
            dgvPakovanja.RowHeadersVisible = false;
            dgvPakovanja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPakovanja.Size = new Size(800, 400);
            dgvPakovanja.TabIndex = 0;
            // 
            // btnNovoPakovanje
            // 
            btnNovoPakovanje.Location = new Point(830, 50);
            btnNovoPakovanje.Name = "btnNovoPakovanje";
            btnNovoPakovanje.Size = new Size(150, 40);
            btnNovoPakovanje.TabIndex = 1;
            btnNovoPakovanje.Text = "Novo pakovanje";
            btnNovoPakovanje.UseVisualStyleBackColor = true;
            btnNovoPakovanje.Click += btnNovoPakovanje_Click;
            // 
            // btnObrisiPakovanje
            // 
            btnObrisiPakovanje.Location = new Point(830, 100);
            btnObrisiPakovanje.Name = "btnObrisiPakovanje";
            btnObrisiPakovanje.Size = new Size(150, 40);
            btnObrisiPakovanje.TabIndex = 2;
            btnObrisiPakovanje.Text = "Obriši pakovanje";
            btnObrisiPakovanje.UseVisualStyleBackColor = true;
            btnObrisiPakovanje.Click += btnObrisiPakovanje_Click;
            // 
            // btnIzmeniPakovanje
            // 
            btnIzmeniPakovanje.Location = new Point(830, 150);
            btnIzmeniPakovanje.Name = "btnIzmeniPakovanje";
            btnIzmeniPakovanje.Size = new Size(150, 40);
            btnIzmeniPakovanje.TabIndex = 3;
            btnIzmeniPakovanje.Text = "Izmeni pakovanje";
            btnIzmeniPakovanje.UseVisualStyleBackColor = true;
            btnIzmeniPakovanje.Click += btnIzmeniPakovanje_Click;
            // 
            // lblPakovanja
            // 
            lblPakovanja.AutoSize = true;
            lblPakovanja.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPakovanja.Location = new Point(12, 15);
            lblPakovanja.Name = "lblPakovanja";
            lblPakovanja.Size = new Size(90, 21);
            lblPakovanja.TabIndex = 4;
            lblPakovanja.Text = "Pakovanja";
            // 
            // cmbLek
            // 
            cmbLek.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLek.FormattingEnabled = true;
            cmbLek.Location = new Point(830, 200);
            cmbLek.Name = "cmbLek";
            cmbLek.Size = new Size(150, 23);
            cmbLek.TabIndex = 5;
            cmbLek.Visible = false;
            // 
            // cmbOblik
            // 
            cmbOblik.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOblik.FormattingEnabled = true;
            cmbOblik.Location = new Point(830, 230);
            cmbOblik.Name = "cmbOblik";
            cmbOblik.Size = new Size(150, 23);
            cmbOblik.TabIndex = 6;
            cmbOblik.Visible = false;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 60;
            // 
            // colLek
            // 
            colLek.DataPropertyName = "Lek.KomercijalniNaziv";
            colLek.HeaderText = "Lek";
            colLek.Name = "colLek";
            colLek.ReadOnly = true;
            colLek.Width = 150;
            // 
            // colOblik
            // 
            colOblik.DataPropertyName = "Oblik.Naziv";
            colOblik.HeaderText = "Oblik";
            colOblik.Name = "colOblik";
            colOblik.ReadOnly = true;
            colOblik.Width = 100;
            // 
            // colVelicina
            // 
            colVelicina.DataPropertyName = "VelicinaPakovanja";
            colVelicina.HeaderText = "Veličina";
            colVelicina.Name = "colVelicina";
            colVelicina.ReadOnly = true;
            colVelicina.Width = 100;
            // 
            // colKolicinaAktivne
            // 
            colKolicinaAktivne.DataPropertyName = "KolicinaAktivne";
            colKolicinaAktivne.HeaderText = "Količina aktivne";
            colKolicinaAktivne.Name = "colKolicinaAktivne";
            colKolicinaAktivne.ReadOnly = true;
            colKolicinaAktivne.Width = 120;
            // 
            // colJedinicaMere
            // 
            colJedinicaMere.DataPropertyName = "JedinicaMere";
            colJedinicaMere.HeaderText = "Jedinica mere";
            colJedinicaMere.Name = "colJedinicaMere";
            colJedinicaMere.ReadOnly = true;
            colJedinicaMere.Width = 100;
            // 
            // PakovanjeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 470);
            Controls.Add(cmbOblik);
            Controls.Add(cmbLek);
            Controls.Add(lblPakovanja);
            Controls.Add(btnIzmeniPakovanje);
            Controls.Add(btnObrisiPakovanje);
            Controls.Add(btnNovoPakovanje);
            Controls.Add(dgvPakovanja);
            Name = "PakovanjeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pakovanja";
            ((System.ComponentModel.ISupportInitialize)dgvPakovanja).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}