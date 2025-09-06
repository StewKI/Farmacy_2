using Farmacy.Entiteti;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class PrimarnaGrupaForm : Form
    {
        public PrimarnaGrupaForm()
        {
            InitializeComponent();
            this.Load += PrimarnaGrupaForm_Load;
        }

        private void PrimarnaGrupaForm_Load(object sender, EventArgs e)
        {
            popuniPodacimaPrimarneGrupe();
        }

        public void popuniPodacimaPrimarneGrupe()
        {
            try
            {
                IList<PrimarnaGrupaBasic> lista = DTOManagerLek.VratiPrimarneGrupe() ?? new List<PrimarnaGrupaBasic>();

                dgvPrimarneGrupe.AutoGenerateColumns = false;
                if (colId != null) colId.DataPropertyName = "Id";
                if (colNaziv != null) colNaziv.DataPropertyName = "Naziv";
                dgvPrimarneGrupe.RowHeadersVisible = false;
                dgvPrimarneGrupe.DataSource = false;
                dgvPrimarneGrupe.DataSource = lista;

                if (dgvPrimarneGrupe.Columns.Count == 0)
                {
                    dgvPrimarneGrupe.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colId",
                        HeaderText = "ID",
                        DataPropertyName = "Id",
                        Width = 60
                    });
                    dgvPrimarneGrupe.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colNaziv",
                        HeaderText = "Naziv",
                        DataPropertyName = "Naziv",
                        Width = 300
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju primarnih grupa:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovaPrimarnaGrupa_Click(object sender, EventArgs e)
        {
            NovaPrimarnaGrupaForm form = new NovaPrimarnaGrupaForm();
            form.ShowDialog();
            popuniPodacimaPrimarneGrupe();
        }

        private void btnObrisiPrimarnuGrupu_Click(object sender, EventArgs e)
        {
            if (dgvPrimarneGrupe.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate izabrati primarnu grupu prvo!");
                return;
            }

            long id = Convert.ToInt64(dgvPrimarneGrupe.CurrentRow.Cells[0].Value);

            var result = MessageBox.Show($"Da li ste sigurni da želite da obrišete primarnu grupu sa ID: {id}?",
                "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    DTOManagerLek.ObrisiPrimarnuGrupu(id);
                    popuniPodacimaPrimarneGrupe();
                    MessageBox.Show("Primarna grupa je uspešno obrisana!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri brisanju primarne grupe:\n" + ex.Message, "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIzmeniPrimarnuGrupu_Click(object sender, EventArgs e)
        {
            if (dgvPrimarneGrupe.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati primarnu grupu!");
                return;
            }

            long id = Convert.ToInt64(dgvPrimarneGrupe.CurrentRow.Cells[0].Value);
            var selektovanaGrupa = DTOManagerLek.VratiPrimarnuGrupu(id);

            if (selektovanaGrupa != null)
            {
                //IzmeniPrimarnuGrupuForm form = new IzmeniPrimarnuGrupuForm(selektovanaGrupa);
                //form.ShowDialog();
                //popuniPodacimaPrimarneGrupe();
            }
            else
            {
                MessageBox.Show("Greška pri učitavanju podataka o primarnoj grupi!");
            }
        }
    }
}

