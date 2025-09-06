using Farmacy.Entiteti;
using Farmacy_2.Forme;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class ZaliheAdminForm : Form
    {
        public int brojZaliha = 0;

        public ZaliheAdminForm()
        {
            InitializeComponent();
            this.Load += ZaliheAdminForm_Load;
        }

        private void ZaliheAdminForm_Load(object sender, EventArgs e)
        {
            popuniPodacimaZalihe();
        }

        public void popuniPodacimaZalihe()
        {
            try
            {
                // Za sada ću koristiti praznu listu, kasnije ću dodati funkciju za učitavanje zaliha
                IList<ZalihaBasic> lista = new List<ZalihaBasic>();

                dgvZalihe.AutoGenerateColumns = false;
                if (colProdajnaJedinicaId != null) colProdajnaJedinicaId.DataPropertyName = "ProdajnaJedinicaId";
                if (colPakovanjeId != null) colPakovanjeId.DataPropertyName = "PakovanjeId";
                if (colKolicina != null) colKolicina.DataPropertyName = "Kolicina";
                if (colDatumPoslednjeIsporuke != null) colDatumPoslednjeIsporuke.DataPropertyName = "DatumPoslednjeIsporuke";
                if (colOdgovorniMagacionerMbr != null) colOdgovorniMagacionerMbr.DataPropertyName = "OdgovorniMagacionerMbr";
                dgvZalihe.RowHeadersVisible = false;
                dgvZalihe.DataSource = false;
                dgvZalihe.DataSource = lista;

                if (dgvZalihe.Columns.Count == 0)
                {
                    dgvZalihe.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colProdajnaJedinicaId",
                        HeaderText = "Prodajna Jedinica ID",
                        DataPropertyName = "ProdajnaJedinicaId",
                        Width = 150
                    });
                    dgvZalihe.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colPakovanjeId",
                        HeaderText = "Pakovanje ID",
                        DataPropertyName = "PakovanjeId",
                        Width = 120
                    });
                    dgvZalihe.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colKolicina",
                        HeaderText = "Količina",
                        DataPropertyName = "Kolicina",
                        Width = 100
                    });
                    dgvZalihe.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colDatumPoslednjeIsporuke",
                        HeaderText = "Datum poslednje isporuke",
                        DataPropertyName = "DatumPoslednjeIsporuke",
                        Width = 180
                    });
                    dgvZalihe.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colOdgovorniMagacionerMbr",
                        HeaderText = "Magacioner MBR",
                        DataPropertyName = "OdgovorniMagacionerMbr",
                        Width = 150
                    });
                }

                brojZaliha = lista.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju zaliha:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIzmeniZalihu_Click(object sender, EventArgs e)
        {
            if (dgvZalihe.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati zalihe!");
                return;
            }

            // Za sada samo poruka, kasnije ću implementirati edit formu
            MessageBox.Show("Funkcionalnost za izmenu zaliha će biti implementirana kasnije.", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDodajNovuZalihu_Click(object sender, EventArgs e)
        {
            // Za sada samo poruka, kasnije ću implementirati add formu
            MessageBox.Show("Funkcionalnost za dodavanje zaliha će biti implementirana kasnije.", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvZalihe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Može se dodati dodatna logika ako je potrebna
        }
    }
}
