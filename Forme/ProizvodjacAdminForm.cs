using Farmacy.Entiteti;
using Farmacy_2.Forme;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class ProizvodjacAdminForm : Form
    {
        public int brojProizvodjaca = 0;

        public ProizvodjacAdminForm()
        {
            InitializeComponent();
            this.Load += ProizvodjacAdminForm_Load;
        }

        private void ProizvodjacAdminForm_Load(object sender, EventArgs e)
        {
            popuniPodacimaProizvodjac();
        }

        public void popuniPodacimaProizvodjac()
        {
            try
            {
                IList<ProizvodjacBasic> lista = DTOManagerIsporukeZalihe.VratiSveProizvodjace() ?? new List<ProizvodjacBasic>();

                dgvProizvodjaci.AutoGenerateColumns = false;
                if (colId != null) colId.DataPropertyName = "Id";
                if (colNaziv != null) colNaziv.DataPropertyName = "Naziv";
                if (colZemlja != null) colZemlja.DataPropertyName = "Zemlja";
                if (colTelefon != null) colTelefon.DataPropertyName = "Telefon";
                if (colEmail != null) colEmail.DataPropertyName = "Email";
                dgvProizvodjaci.RowHeadersVisible = false;
                dgvProizvodjaci.DataSource = false;
                dgvProizvodjaci.DataSource = lista;

                if (dgvProizvodjaci.Columns.Count == 0)
                {
                    dgvProizvodjaci.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colId",
                        HeaderText = "ID",
                        DataPropertyName = "Id",
                        Width = 60
                    });
                    dgvProizvodjaci.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colNaziv",
                        HeaderText = "Naziv",
                        DataPropertyName = "Naziv",
                        Width = 150
                    });
                    dgvProizvodjaci.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colZemlja",
                        HeaderText = "Zemlja",
                        DataPropertyName = "Zemlja",
                        Width = 100
                    });
                    dgvProizvodjaci.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colTelefon",
                        HeaderText = "Telefon",
                        DataPropertyName = "Telefon",
                        Width = 120
                    });
                    dgvProizvodjaci.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colEmail",
                        HeaderText = "Email",
                        DataPropertyName = "Email",
                        Width = 150
                    });
                }

                brojProizvodjaca = lista.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju proizvodjača:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIzmeniProizvodjac_Click(object sender, EventArgs e)
        {
            if (dgvProizvodjaci.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati proizvodjača!");
                return;
            }

            long id = Convert.ToInt64(dgvProizvodjaci.CurrentRow.Cells[0].Value);
            var selektovaniProizvodjac = DTOManagerIsporukeZalihe.VratiProizvodjaca(id);

            if (selektovaniProizvodjac != null)
            {
                ProizvodjacEditForm form = new ProizvodjacEditForm(selektovaniProizvodjac);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    popuniPodacimaProizvodjac();
                }
            }
            else
            {
                MessageBox.Show("Greška pri učitavanju podataka o proizvodjaču!");
            }
        }

        private void btnDodajNoviProizvodjac_Click(object sender, EventArgs e)
        {
            ProizvodjacForm form = new ProizvodjacForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                popuniPodacimaProizvodjac();
            }
        }

        private void dgvProizvodjaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Može se dodati dodatna logika ako je potrebna
        }
    }
}
