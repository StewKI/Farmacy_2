using Farmacy.Entiteti;
using Farmacy_2.Forme;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class ProdajaAdminForm : Form
    {
        public int brojProdaja = 0;
        private long? prodajnaJedinicaId = null;

        public ProdajaAdminForm(long? prodajnaJedinicaId = null)
        {
            InitializeComponent();
            this.prodajnaJedinicaId = prodajnaJedinicaId;
            this.Load += ProdajaAdminForm_Load;
            SetupButtonEffects();
            SetupSearchFunctionality();
        }

        private void ProdajaAdminForm_Load(object sender, EventArgs e)
        {
            if (prodajnaJedinicaId.HasValue)
            {
                this.Text = $"Prodaje - Prodajna Jedinica ID: {prodajnaJedinicaId.Value}";
            }
            popuniPodacimaProdaja();
        }

        public void popuniPodacimaProdaja()
        {
            try
            {
                IList<ProdajaBasic> lista;
                
                if (prodajnaJedinicaId.HasValue)
                {
                    lista = DTOManagerIsporukeZalihe.VratiProdajeZaProdajnuJedinicu(prodajnaJedinicaId.Value) ?? new List<ProdajaBasic>();
                }
                else
                {
                    lista = DTOManagerIsporukeZalihe.VratiSveProdaje() ?? new List<ProdajaBasic>();
                }

                dgvProdaje.AutoGenerateColumns = false;
                if (colId != null) colId.DataPropertyName = "Id";
                if (colProdajnaJedinicaNaziv != null) colProdajnaJedinicaNaziv.DataPropertyName = "ProdajnaJedinicaNaziv";
                if (colDatumVreme != null) colDatumVreme.DataPropertyName = "DatumVreme";
                if (colBlagajnikIme != null) colBlagajnikIme.DataPropertyName = "BlagajnikIme";
                if (colUkupnaVrednost != null) colUkupnaVrednost.DataPropertyName = "UkupnaVrednost";
                if (colBrojStavki != null) colBrojStavki.DataPropertyName = "BrojStavki";
                dgvProdaje.RowHeadersVisible = false;
                dgvProdaje.DataSource = false;
                dgvProdaje.DataSource = lista;

                if (dgvProdaje.Columns.Count == 0)
                {
                    dgvProdaje.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colId",
                        HeaderText = "ID",
                        DataPropertyName = "Id",
                        Width = 60
                    });
                    dgvProdaje.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colProdajnaJedinicaNaziv",
                        HeaderText = "Prodajna Jedinica",
                        DataPropertyName = "ProdajnaJedinicaNaziv",
                        Width = 150
                    });
                    dgvProdaje.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colDatumVreme",
                        HeaderText = "Datum i Vreme",
                        DataPropertyName = "DatumVreme",
                        Width = 150
                    });
                    dgvProdaje.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colBlagajnikIme",
                        HeaderText = "Blagajnik",
                        DataPropertyName = "BlagajnikIme",
                        Width = 150
                    });
                    dgvProdaje.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colUkupnaVrednost",
                        HeaderText = "Ukupna Vrednost",
                        DataPropertyName = "UkupnaVrednost",
                        Width = 120
                    });
                    dgvProdaje.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colBrojStavki",
                        HeaderText = "Broj Stavki",
                        DataPropertyName = "BrojStavki",
                        Width = 100
                    });
                }

                brojProdaja = lista.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju prodaja:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDodajNovuProdaju_Click(object sender, EventArgs e)
        {
            // Za sada samo poruka, kasnije će se implementirati ProdajaForm
            MessageBox.Show("Funkcionalnost za dodavanje prodaje će biti implementirana kasnije.", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnObrisiProdaju_Click(object sender, EventArgs e)
        {
            if (dgvProdaje.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati prodaju!");
                return;
            }

            long id = Convert.ToInt64(dgvProdaje.CurrentRow.Cells[0].Value);

            var result = MessageBox.Show(
                "Da li ste sigurni da želite da obrišete selektovanu prodaju?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    DTOManagerIsporukeZalihe.ObrisiProdaju(id);
                    MessageBox.Show("Prodaja je uspešno obrisana!", "Uspešno", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    popuniPodacimaProdaja();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Greška pri brisanju prodaje:\n{ex.Message}", "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvProdaje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Može se dodati dodatna logika ako je potrebna
        }

        private void SetupButtonEffects()
        {
            // Dodaj hover efekte za sva dugmad
            btnDodajNovuProdaju.MouseEnter += Button_MouseEnter;
            btnDodajNovuProdaju.MouseLeave += Button_MouseLeave;
            btnObrisiProdaju.MouseEnter += Button_MouseEnter;
            btnObrisiProdaju.MouseLeave += Button_MouseLeave;
            btnDetalji.MouseEnter += Button_MouseEnter;
            btnDetalji.MouseLeave += Button_MouseLeave;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                // Sačuvaj originalnu boju
                button.Tag = button.BackColor;
                
                // Promeni boju na hover
                if (button == btnDodajNovuProdaju)
                {
                    button.BackColor = Color.FromArgb(33, 136, 56); // Tamnija zelena
                }
                else if (button == btnObrisiProdaju)
                {
                    button.BackColor = Color.FromArgb(200, 35, 51); // Tamnija crvena
                }
                else if (button == btnDetalji)
                {
                    button.BackColor = Color.FromArgb(0, 86, 179); // Tamnija plava
                }
                
                button.Cursor = Cursors.Hand;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is Color originalColor)
            {
                // Vrati originalnu boju
                button.BackColor = originalColor;
                button.Cursor = Cursors.Default;
            }
        }

        private void SetupSearchFunctionality()
        {
            txtSearch.TextChanged += TxtSearch_TextChanged;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void FilterData()
        {
            try
            {
                string searchText = txtSearch.Text.ToLower().Trim();
                
                if (string.IsNullOrEmpty(searchText))
                {
                    popuniPodacimaProdaja();
                    return;
                }

                IList<ProdajaBasic> allData;
                
                if (prodajnaJedinicaId.HasValue)
                {
                    allData = DTOManagerIsporukeZalihe.VratiProdajeZaProdajnuJedinicu(prodajnaJedinicaId.Value) ?? new List<ProdajaBasic>();
                }
                else
                {
                    allData = DTOManagerIsporukeZalihe.VratiSveProdaje() ?? new List<ProdajaBasic>();
                }

                var filteredData = allData.Where(p => 
                    (p.ProdajnaJedinicaNaziv?.ToLower().Contains(searchText) == true) ||
                    (p.BlagajnikIme?.ToLower().Contains(searchText) == true) ||
                    p.Id.ToString().Contains(searchText)
                ).ToList();

                dgvProdaje.DataSource = filteredData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri pretrazi: " + ex.Message, "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            if (dgvProdaje.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati prodaju prvo!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            long prodajaId = Convert.ToInt64(dgvProdaje.CurrentRow.Cells[0].Value);
            
            // Ovde će se implementirati forma za detalje prodaje
            MessageBox.Show($"Detalji prodaje ID: {prodajaId}\n\nOva funkcionalnost će biti implementirana u sledećoj verziji.", 
                "Detalji prodaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
