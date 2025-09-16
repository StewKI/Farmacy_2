using Farmacy.Entiteti;
using Farmacy_2.Forme;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class DistributerAdminForm : Form
    {
        public int brojDistributera = 0;

        public DistributerAdminForm()
        {
            InitializeComponent();
            this.Load += DistributerAdminForm_Load;
        }

        private void DistributerAdminForm_Load(object sender, EventArgs e)
        {
            popuniPodacimaDistributer();
        }

        public void popuniPodacimaDistributer()
        {
            try
            {
                IList<DistributerBasic> lista = DTOManagerIsporukeZalihe.VratiSveDistributere() ?? new List<DistributerBasic>();

                dgvDistributeri.AutoGenerateColumns = false;
                if (colId != null) colId.DataPropertyName = "Id";
                if (colNaziv != null) colNaziv.DataPropertyName = "Naziv";
                if (colKontakt != null) colKontakt.DataPropertyName = "Kontakt";
                dgvDistributeri.RowHeadersVisible = false;
                dgvDistributeri.DataSource = false;
                dgvDistributeri.DataSource = lista;

                if (dgvDistributeri.Columns.Count == 0)
                {
                    dgvDistributeri.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colId",
                        HeaderText = "ID",
                        DataPropertyName = "Id",
                        Width = 60
                    });
                    dgvDistributeri.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colNaziv",
                        HeaderText = "Naziv",
                        DataPropertyName = "Naziv",
                        Width = 200
                    });
                    dgvDistributeri.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colKontakt",
                        HeaderText = "Kontakt",
                        DataPropertyName = "Kontakt",
                        Width = 200
                    });
                }

                brojDistributera = lista.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju distributera:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnIzmeniDistributer_Click(object sender, EventArgs e)
        {
            if (dgvDistributeri.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati distributera!");
                return;
            }

            long id = Convert.ToInt64(dgvDistributeri.CurrentRow.Cells[0].Value);
            var selektovaniDistributer = DTOManagerIsporukeZalihe.VratiDistributera(id);

            if (selektovaniDistributer != null)
            {
                DistributerEditForm form = new DistributerEditForm(selektovaniDistributer);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    popuniPodacimaDistributer();
                }
            }
            else
            {
                MessageBox.Show("Greška pri učitavanju podataka o distributeru!");
            }
        }

        private void btnDodajNoviDistributer_Click(object sender, EventArgs e)
        {
            DistributerForm form = new DistributerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                popuniPodacimaDistributer();
            }
        }

        private void dgvDistributeri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Može se dodati dodatna logika ako je potrebna
        }
    }
}
