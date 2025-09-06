namespace Farmacy.Forme
{
    partial class ReceptForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvRecepti;
        private System.Windows.Forms.Button btnNoviRecept;
        private System.Windows.Forms.Button btnObrisiRecept;
        private System.Windows.Forms.Button btnIzmeniRecept;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.Button btnRealizujRecept;
        private System.Windows.Forms.Label lblRecepti;

        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerijskiBroj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSifraLekara;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatumIzd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNazivUstanove;

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
            dgvRecepti = new DataGridView();
            btnNoviRecept = new Button();
            btnObrisiRecept = new Button();
            btnIzmeniRecept = new Button();
            btnDodajStavku = new Button();
            btnRealizujRecept = new Button();
            lblRecepti = new Label();
            colId = new DataGridViewTextBoxColumn();
            colSerijskiBroj = new DataGridViewTextBoxColumn();
            colSifraLekara = new DataGridViewTextBoxColumn();
            colDatumIzd = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colNazivUstanove = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRecepti).BeginInit();
            SuspendLayout();
            // 
            // dgvRecepti
            // 
            dgvRecepti.AllowUserToAddRows = false;
            dgvRecepti.AllowUserToDeleteRows = false;
            dgvRecepti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecepti.Columns.AddRange(new DataGridViewColumn[] { colId, colSerijskiBroj, colSifraLekara, colDatumIzd, colStatus, colNazivUstanove });
            dgvRecepti.Location = new Point(12, 50);
            dgvRecepti.MultiSelect = false;
            dgvRecepti.Name = "dgvRecepti";
            dgvRecepti.ReadOnly = true;
            dgvRecepti.RowHeadersVisible = false;
            dgvRecepti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecepti.Size = new Size(800, 400);
            dgvRecepti.TabIndex = 0;
            // 
            // btnNoviRecept
            // 
            btnNoviRecept.Location = new Point(830, 50);
            btnNoviRecept.Name = "btnNoviRecept";
            btnNoviRecept.Size = new Size(150, 40);
            btnNoviRecept.TabIndex = 1;
            btnNoviRecept.Text = "Novi recept";
            btnNoviRecept.UseVisualStyleBackColor = true;
            btnNoviRecept.Click += btnNoviRecept_Click;
            // 
            // btnObrisiRecept
            // 
            btnObrisiRecept.Location = new Point(830, 100);
            btnObrisiRecept.Name = "btnObrisiRecept";
            btnObrisiRecept.Size = new Size(150, 40);
            btnObrisiRecept.TabIndex = 2;
            btnObrisiRecept.Text = "Obriši recept";
            btnObrisiRecept.UseVisualStyleBackColor = true;
            btnObrisiRecept.Click += btnObrisiRecept_Click;
            // 
            // btnIzmeniRecept
            // 
            btnIzmeniRecept.Location = new Point(830, 150);
            btnIzmeniRecept.Name = "btnIzmeniRecept";
            btnIzmeniRecept.Size = new Size(150, 40);
            btnIzmeniRecept.TabIndex = 3;
            btnIzmeniRecept.Text = "Izmeni recept";
            btnIzmeniRecept.UseVisualStyleBackColor = true;
            btnIzmeniRecept.Click += btnIzmeniRecept_Click;
            // 
            // btnDodajStavku
            // 
            btnDodajStavku.Location = new Point(830, 200);
            btnDodajStavku.Name = "btnDodajStavku";
            btnDodajStavku.Size = new Size(150, 40);
            btnDodajStavku.TabIndex = 4;
            btnDodajStavku.Text = "Dodaj stavku";
            btnDodajStavku.UseVisualStyleBackColor = true;
            btnDodajStavku.Click += btnDodajStavku_Click;
            // 
            // btnRealizujRecept
            // 
            btnRealizujRecept.Location = new Point(830, 250);
            btnRealizujRecept.Name = "btnRealizujRecept";
            btnRealizujRecept.Size = new Size(150, 40);
            btnRealizujRecept.TabIndex = 5;
            btnRealizujRecept.Text = "Realizuj recept";
            btnRealizujRecept.UseVisualStyleBackColor = true;
            btnRealizujRecept.Click += btnRealizujRecept_Click;
            // 
            // lblRecepti
            // 
            lblRecepti.AutoSize = true;
            lblRecepti.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRecepti.Location = new Point(12, 15);
            lblRecepti.Name = "lblRecepti";
            lblRecepti.Size = new Size(70, 21);
            lblRecepti.TabIndex = 6;
            lblRecepti.Text = "Recepti";
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 60;
            // 
            // colSerijskiBroj
            // 
            colSerijskiBroj.DataPropertyName = "SerijskiBroj";
            colSerijskiBroj.HeaderText = "Serijski broj";
            colSerijskiBroj.Name = "colSerijskiBroj";
            colSerijskiBroj.ReadOnly = true;
            colSerijskiBroj.Width = 120;
            // 
            // colSifraLekara
            // 
            colSifraLekara.DataPropertyName = "SifraLekara";
            colSifraLekara.HeaderText = "Šifra lekara";
            colSifraLekara.Name = "colSifraLekara";
            colSifraLekara.ReadOnly = true;
            colSifraLekara.Width = 100;
            // 
            // colDatumIzd
            // 
            colDatumIzd.DataPropertyName = "DatumIzd";
            colDatumIzd.HeaderText = "Datum izdavanja";
            colDatumIzd.Name = "colDatumIzd";
            colDatumIzd.ReadOnly = true;
            colDatumIzd.Width = 120;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 80;
            // 
            // colNazivUstanove
            // 
            colNazivUstanove.DataPropertyName = "NazivUstanove";
            colNazivUstanove.HeaderText = "Naziv ustanove";
            colNazivUstanove.Name = "colNazivUstanove";
            colNazivUstanove.ReadOnly = true;
            colNazivUstanove.Width = 200;
            // 
            // ReceptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 470);
            Controls.Add(lblRecepti);
            Controls.Add(btnRealizujRecept);
            Controls.Add(btnDodajStavku);
            Controls.Add(btnIzmeniRecept);
            Controls.Add(btnObrisiRecept);
            Controls.Add(btnNoviRecept);
            Controls.Add(dgvRecepti);
            Name = "ReceptForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Recepti";
            ((System.ComponentModel.ISupportInitialize)dgvRecepti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

