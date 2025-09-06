using Farmacy.Entiteti;
using Farmacy_2.Forme;
using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class ProdajnaJedinicaAdminForm : Form
    {
        public ProdajnaJedinicaAdminForm()
        {
            InitializeComponent();
            this.Load += ProdajnaJedinicaAdminForm_Load;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            OdaberiProdajnuJedinicu form = new OdaberiProdajnuJedinicu();
            form.ShowDialog();
            popuniPodacima();
        }

        private void ProdajnaJedinicaAdminForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            try
            {
                // 1) Učitaj podatke
                IList<ProdajnaJedinicaBasic> lista = DTOManagerProdajneJedinice.VratiSveProdajneJedinice() ?? new List<ProdajnaJedinicaBasic>();

                // 2) Mapiraj kolone (ako već nisu mapirane)
                dgvApoteke.AutoGenerateColumns = false;
                if (colId != null) colId.DataPropertyName = "Id";
                if (colNaziv != null) colNaziv.DataPropertyName = "Naziv";
                if (colUlica != null) colUlica.DataPropertyName = "Ulica";
                if (colPostanskiBroj != null) colPostanskiBroj.DataPropertyName = "PostanskiBroj";
                if (colMesto != null) colMesto.DataPropertyName = "Mesto";

                // 3) Veži podatke
                dgvApoteke.DataSource = false;   // osveži binding
                dgvApoteke.DataSource = lista;




                if (dgvApoteke.Columns.Count == 0)
                {
                    dgvApoteke.AutoGenerateColumns = false;
                    dgvApoteke.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colId",
                        HeaderText = "Id",
                        DataPropertyName = "Id",
                        Width = 90
                    });
                    dgvApoteke.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colNaziv",
                        HeaderText = "Naziv",
                        DataPropertyName = "Naziv",
                        Width = 140
                    });
                    dgvApoteke.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colUlica",
                        HeaderText = "Ulica",
                        DataPropertyName = "Ulica",
                        Width = 160
                    });
                    dgvApoteke.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colPostanskiBroj",
                        HeaderText = "Broj",
                        DataPropertyName = "Broj",
                        Width = 160
                    });
                    dgvApoteke.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colMesto",
                        HeaderText = "Mesto",
                        DataPropertyName = "Mesto",
                        Width = 160
                    });
                    //dgvZaposleni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju zaposlenih:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            long mbr = 0;
            if (dgvApoteke.SelectedRows.Count > 0)
            {
                mbr = Convert.ToInt64(dgvApoteke.CurrentRow.Cells[0].Value);
                MessageBox.Show("Selektovan MBr: " + mbr);

            }
            else
            {
                MessageBox.Show("Morate izabrati radnika prvo!");
                return;
            }
            DTOManagerProdajneJedinice.ObrisiProdajnuJedinicu(mbr);
            popuniPodacima();
        }

        private void groupBoxLista_Enter(object sender, EventArgs e)
        {

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvApoteke.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati prodajnu jedinicu!");
                return;
            }
            long id = 0;
            if (dgvApoteke.SelectedRows.Count > 0)
            {
                id = Convert.ToInt64(dgvApoteke.CurrentRow.Cells[0].Value);
                MessageBox.Show("Selektovan id: " + id);

            }
            else
            {
                MessageBox.Show("Morate izabrati radnika prvo!");
                return;
            }



            var selektovanaJedinica = DTOManagerProdajneJedinice.VratiProdajnuJedinicuTip(id);

            if (selektovanaJedinica is SpecijalizovanaApoteka specijalizovana)
            {
                SpecijalizovanaApotekaEditForm form = new SpecijalizovanaApotekaEditForm(specijalizovana);
                form.ShowDialog();
            }
            else if (selektovanaJedinica is ApotekaSaLabBasic saLab)
            {
                ApotekaSaLabEditForm form = new ApotekaSaLabEditForm(saLab);
                form.ShowDialog();
            }
            else if (selektovanaJedinica is StandardnaApoteka sApoteka)
            {
                StandardnaApotekaEditForm form = new StandardnaApotekaEditForm(sApoteka);
                form.ShowDialog();
            }
            else // osnovna prodajna jedinica
            {

                ProdajnaJedinicaEditForm form = new ProdajnaJedinicaEditForm(DTOManagerProdajneJedinice.VratiProdajnuJedinicu(id));
                form.ShowDialog();
            }


            popuniPodacima();
        }
        private void btnDistributeri_Click(object sender, EventArgs e)
        {
            DistributerAdminForm form = new DistributerAdminForm();
            form.ShowDialog();
        }
        private void btnProizvodjaci_Click(object sender, EventArgs e)
        {
            ProizvodjacAdminForm form = new ProizvodjacAdminForm();
            form.ShowDialog();
        }
        private void btnZalihe_Click(object sender, EventArgs e)
        {
            ZaliheAdminForm form = new ZaliheAdminForm();
            form.ShowDialog();
        }
        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            ZaposleniPrikaz form = new ZaposleniPrikaz();
            form.ShowDialog();
        }

        private void btnSuplementi_Click(object sender, EventArgs e)
        {
            if (dgvApoteke.CurrentRow == null)
            {
                MessageBox.Show("Morate izabrati apoteku!");
                return;
            }
            long id = 0;
            if (dgvApoteke.SelectedRows.Count > 0)
            {
                id = Convert.ToInt64(dgvApoteke.CurrentRow.Cells[0].Value);
                MessageBox.Show("Selektovan id: " + id);

            }
            else
            {
                MessageBox.Show("Morate izabrati apoteku kojoj dodeljujete menadzera prvo!");
                return;
            }

            MenadzerApotekaForm form = new MenadzerApotekaForm(id);
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvApoteke.CurrentRow == null)
            {
                MessageBox.Show("Morate izabrati apoteku!");
                return;
            }
            long id = 0;
            if (dgvApoteke.SelectedRows.Count > 0)
            {
                id = Convert.ToInt64(dgvApoteke.CurrentRow.Cells[0].Value);
                MessageBox.Show("Selektovan id: " + id);

            }
            else
            {
                MessageBox.Show("Morate izabrati apoteku kojoj dodeljujete menadzera prvo!");
                return;
            }
            OdaberiMenadzeraForm1 form = new OdaberiMenadzeraForm1(id);
            form.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvApoteke.CurrentRow == null)
            {
                MessageBox.Show("Morate izabrati apoteku!");
                return;
            }
            long id = 0;
            if (dgvApoteke.SelectedRows.Count > 0)
            {
                id = Convert.ToInt64(dgvApoteke.CurrentRow.Cells[0].Value);
                MessageBox.Show("Selektovan id: " + id);

            }
            else
            {
                MessageBox.Show("Morate izabrati apoteku kojoj dodeljujete menadzera prvo!");
                return;
            }

            MenadzerApotekaEditForm form = new MenadzerApotekaEditForm(id);
            form.ShowDialog();
        }

        private void btnReceptura_Click(object sender, EventArgs e)
        {
            if (dgvApoteke.CurrentRow == null)
            {
                MessageBox.Show("Morate izabrati apoteku!");
                return;
            }
            long id = 0;
            if (dgvApoteke.SelectedRows.Count > 0)
            {
                id = Convert.ToInt64(dgvApoteke.CurrentRow.Cells[0].Value);
                MessageBox.Show("Selektovan id: " + id);

            }
            

            RealizujReceptForm form = new RealizujReceptForm(DTOManagerProdajneJedinice.VratiProdajnuJedinicu(id));
            form.ShowDialog();
        }
    }
}
