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
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            try
            {
                IList<LekBasic> lista = DTOManager.VratiSveLekove() ?? new List<LekBasic>();

                dgvLekovi.AutoGenerateColumns = false;
                if (colId != null) colId.DataPropertyName = "Id";
                if (colHemijskiNaziv != null) colHemijskiNaziv.DataPropertyName = "HemijskiNaziv";
                if (colKomercijalniNaziv != null) colKomercijalniNaziv.DataPropertyName = "KomercijalniNaziv";
                if (colDejstvo != null) colDejstvo.DataPropertyName = "Dejstvo";

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
                DTOManager.ObrisiLek(id);
                popuniPodacima();
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
            var selektovaniLek = DTOManager.VratiLekEntitet(id);

            if (selektovaniLek != null)
            {
                LekEditForm form = new LekEditForm(selektovaniLek);
                form.ShowDialog();
                popuniPodacima();
            }
            else
            {
                MessageBox.Show("Greška pri učitavanju podataka o leku!");
            }
        }

        private void btnDodajNoviLek_Click(object sender, EventArgs e)
        {
            var noviLek = new Lek();
            LekEditForm form = new LekEditForm(noviLek);
            form.ShowDialog();
            popuniPodacima();
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
            var selektovaniLek = DTOManager.VratiLekEntitet(id);

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
            PakovanjeForm form = new PakovanjeForm();
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
    }
}
