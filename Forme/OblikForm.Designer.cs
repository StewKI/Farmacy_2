namespace Farmacy.Forme
{
    partial class OblikForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvOblik;
        private System.Windows.Forms.Button btnNoviOblik;
        private System.Windows.Forms.Button btnObrisiOblik;
        private System.Windows.Forms.Button btnIzmeniOblik;
        private System.Windows.Forms.Label lblOblik;

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
            dgvOblik = new DataGridView();
            btnNoviOblik = new Button();
            btnObrisiOblik = new Button();
            btnIzmeniOblik = new Button();
            lblOblik = new Label();
            colId = new DataGridViewTextBoxColumn();
            colNaziv = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvOblik).BeginInit();
            SuspendLayout();
            // 
            // dgvOblik
            // 
            dgvOblik.AllowUserToAddRows = false;
            dgvOblik.AllowUserToDeleteRows = false;
            dgvOblik.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOblik.Columns.AddRange(new DataGridViewColumn[] { colId, colNaziv });
            dgvOblik.Location = new Point(12, 50);
            dgvOblik.MultiSelect = false;
            dgvOblik.Name = "dgvOblik";
            dgvOblik.ReadOnly = true;
            dgvOblik.RowHeadersVisible = false;
            dgvOblik.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOblik.Size = new Size(600, 400);
            dgvOblik.TabIndex = 0;
            // 
            // btnNoviOblik
            // 
            btnNoviOblik.Location = new Point(650, 50);
            btnNoviOblik.Name = "btnNoviOblik";
            btnNoviOblik.Size = new Size(150, 40);
            btnNoviOblik.TabIndex = 1;
            btnNoviOblik.Text = "Novi oblik";
            btnNoviOblik.UseVisualStyleBackColor = true;
            btnNoviOblik.Click += btnNoviOblik_Click;
            // 
            // btnObrisiOblik
            // 
            btnObrisiOblik.Location = new Point(650, 100);
            btnObrisiOblik.Name = "btnObrisiOblik";
            btnObrisiOblik.Size = new Size(150, 40);
            btnObrisiOblik.TabIndex = 2;
            btnObrisiOblik.Text = "Obriši oblik";
            btnObrisiOblik.UseVisualStyleBackColor = true;
            btnObrisiOblik.Click += btnObrisiOblik_Click;
            // 
            // btnIzmeniOblik
            // 
            btnIzmeniOblik.Location = new Point(650, 150);
            btnIzmeniOblik.Name = "btnIzmeniOblik";
            btnIzmeniOblik.Size = new Size(150, 40);
            btnIzmeniOblik.TabIndex = 3;
            btnIzmeniOblik.Text = "Izmeni oblik";
            btnIzmeniOblik.UseVisualStyleBackColor = true;
            btnIzmeniOblik.Click += btnIzmeniOblik_Click;
            // 
            // lblOblik
            // 
            lblOblik.AutoSize = true;
            lblOblik.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOblik.Location = new Point(12, 15);
            lblOblik.Name = "lblOblik";
            lblOblik.Size = new Size(60, 21);
            lblOblik.TabIndex = 4;
            lblOblik.Text = "Oblici";
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
            // OblikForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 470);
            Controls.Add(lblOblik);
            Controls.Add(btnIzmeniOblik);
            Controls.Add(btnObrisiOblik);
            Controls.Add(btnNoviOblik);
            Controls.Add(dgvOblik);
            Name = "OblikForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Oblici";
            ((System.ComponentModel.ISupportInitialize)dgvOblik).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}