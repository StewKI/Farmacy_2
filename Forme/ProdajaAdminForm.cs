using Farmacy.Entiteti;
using Farmacy_2.Forme;
using System;
using System.Collections.Generic;
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
    }
}
