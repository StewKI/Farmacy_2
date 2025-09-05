using Farmacy.Entiteti;
using Farmacy_2.Forme;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class LekAdminForm : Form
    {
        public int brojLekova = 0;

        public LekAdminForm()
        {
            InitializeComponent();
            this.Load += LekAdminForm_Load;
        }

        private void LekAdminForm_Load(object sender, EventArgs e)
        {
            popuniPodacimaLek();
            popuniPodacimaOblik();
        }

        public void popuniPodacimaLek()
        {
            try
            {
                IList<LekBasic> lista = DTOManagerLek.VratiSveLekove() ?? new List<LekBasic>();

                dgvLekovi.AutoGenerateColumns = false;
                if (colId != null) colId.DataPropertyName = "Id";
                if (colKomercijalniNaziv != null) colKomercijalniNaziv.DataPropertyName = "KomercijalniNaziv";
                if (colDejstvo != null) colDejstvo.DataPropertyName = "Dejstvo";
                dgvLekovi.RowHeadersVisible = false;
                dgvLekovi.DataSource = false;
                dgvLekovi.DataSource = lista;

                if (dgvLekovi.Columns.Count == 0)
                {
                    dgvLekovi.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colId",
                        HeaderText = "ID",
                        DataPropertyName = "Id",
                        Width = 60
                    });
                    dgvLekovi.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colHemijskiNaziv",
                        HeaderText = "Hemijski naziv",
                        DataPropertyName = "HemijskiNaziv",
                        Width = 180
                    });
                    dgvLekovi.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colKomercijalniNaziv",
                        HeaderText = "Komercijalni naziv",
                        DataPropertyName = "KomercijalniNaziv",
                        Width = 180
                    });
                    dgvLekovi.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colDejstvo",
                        HeaderText = "Dejstvo",
                        DataPropertyName = "Dejstvo",
                        Width = 200
                    });
                }

                brojLekova = lista.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju lekova:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void popuniPodacimaOblik()
        {
            try
            {
                IList<Oblik> lista = DTOManagerLek.VratiSveOblikeLekova() ?? new List<Oblik>();

                dgvOblik.AutoGenerateColumns = false;
                if (oblikId != null) oblikId.DataPropertyName = "Id";
                if (oblikNaziv != null) oblikNaziv.DataPropertyName = "Naziv";
                dgvOblik.RowHeadersVisible = false;
                dgvOblik.DataSource = false;
                dgvOblik.DataSource = lista;

                if (dgvLekovi.Columns.Count == 0)
                {
                    dgvOblik.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colId",
                        HeaderText = "ID",
                        DataPropertyName = "Id",
                        Width = 60
                    });
                    dgvOblik.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colNaziv",
                        HeaderText = "Naziv",
                        DataPropertyName = "Naziv",
                        Width = 180
                    });
                    
                }

                brojLekova = lista.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju lekova:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObrisiLek_Click(object sender, EventArgs e)
        {
            if (dgvLekovi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate izabrati lek prvo!");
                return;
            }

            long id = Convert.ToInt64(dgvLekovi.CurrentRow.Cells[0].Value);

            var result = MessageBox.Show($"Da li ste sigurni da želite da obrišete lek sa ID: {id}?",
                "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DTOManagerLek.ObrisiLek(id);
                popuniPodacimaLek();
            }
        }

        private void btnIzmeniLek_Click(object sender, EventArgs e)
        {
            if (dgvLekovi.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati lek!");
                return;
            }

            long id = Convert.ToInt64(dgvLekovi.CurrentRow.Cells[0].Value);
            var selektovaniLek = DTOManagerLek.VratiLek(id);

            if (selektovaniLek != null)
            {
                LekEditForm form = new LekEditForm(selektovaniLek);
                form.ShowDialog();
                popuniPodacimaLek();
            }
            else
            {
                MessageBox.Show("Greška pri učitavanju podataka o leku!");
            }


        }

        private void btnDodajNoviLek_Click(object sender, EventArgs e)
        {
            LekForm form = new LekForm();
            form.ShowDialog();
            popuniPodacimaLek();
        }

        // --- Dugmad za povezane forme ---

        private void btnDistributeri_Click(object sender, EventArgs e)
        {
            DistributerForm form = new DistributerForm();
            form.ShowDialog();
        }

        private void btnSekundarneKategorije_Click(object sender, EventArgs e)
        {
            if (dgvLekovi.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati lek prvo!");
                return;
            }
            
            long id = Convert.ToInt64(dgvLekovi.CurrentRow.Cells[0].Value);
            var selektovaniLek = DTOManagerLek.VratiLekEntitet(id);

            if (selektovaniLek != null)
            {
                LekSekundarna lekSekundarna = new LekSekundarna
                {
                    Lek = selektovaniLek
                };

                LekSekundarnaForm form = new LekSekundarnaForm(lekSekundarna);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Greška pri učitavanju leka!");
            }
        }

        private void btnOblik_Click(object sender, EventArgs e)
        {
            OblikForm form = new OblikForm();
            form.ShowDialog();
        }

        private void btnPakovanje_Click(object sender, EventArgs e)
        {
            if (dgvLekovi.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati lek prvo!");
                return;
            }

            long idLek = Convert.ToInt64(dgvLekovi.CurrentRow.Cells[0].Value);
            //var selektovaniLek = DTOManagerLek.VratiLekEntitet(id);
            long idOblik = Convert.ToInt64(dgvLekovi.CurrentRow.Cells[0].Value);
            //var selektovaniLek = DTOManagerLek.VratiLekEntitet(id);
            if (dgvOblik.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati oblik takodje!");
                return;
            }

           

            PakovanjeForm form = new PakovanjeForm(idLek,idOblik);
            form.ShowDialog();

        }

        private void btnPrimarnaGrupa_Click(object sender, EventArgs e)
        {
            PrimarnaGrupaForm form = new PrimarnaGrupaForm();
            form.ShowDialog();
        }

        private void btnProizvodjac_Click(object sender, EventArgs e)
        {
            ProizvodjacForm form = new ProizvodjacForm();
            form.ShowDialog();
        }

        private void btnRecept_Click(object sender, EventArgs e)
        {
            ReceptForm form = new ReceptForm();
            form.ShowDialog();
        }

        private void btnSekundarnaGrupa_Click(object sender, EventArgs e)
        {
            SekundarnaGrupaForm form = new SekundarnaGrupaForm();
            form.ShowDialog();
        }

        private void dgvLekovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LekAdminForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
