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
                // 1) Učitaj podatke za svaki tip apoteke
                IList<ProdajnaJedinicaBasic> osnovneLista = DTOManagerProdajneJedinice.VratiOsnovneProdajneJedinice() ?? new List<ProdajnaJedinicaBasic>();
                IList<ApotekaSaLabBasic> saLabLista = DTOManagerProdajneJedinice.VratiApotekeSaLab() ?? new List<ApotekaSaLabBasic>();
                IList<StandardnaApoteka> standardneLista = DTOManagerProdajneJedinice.VratiStandardneApoteke() ?? new List<StandardnaApoteka>();
                IList<SpecijalizovanaApoteka> specijalizovaneLista = DTOManagerProdajneJedinice.VratiSpecijalizovaneApoteke() ?? new List<SpecijalizovanaApoteka>();

                // 2) Konfiguriši i popuni osnovne prodajne jedinice
                dgvOsnovne.AutoGenerateColumns = false;
                if (colId != null) colId.DataPropertyName = "Id";
                if (colNaziv != null) colNaziv.DataPropertyName = "Naziv";
                if (colUlica != null) colUlica.DataPropertyName = "Ulica";
                if (colPostanskiBroj != null) colPostanskiBroj.DataPropertyName = "PostanskiBroj";
                if (colMesto != null) colMesto.DataPropertyName = "Mesto";
                dgvOsnovne.DataSource = false;
                dgvOsnovne.DataSource = osnovneLista;

                // 3) Konfiguriši i popuni apoteke sa lab
                dgvSaLab.AutoGenerateColumns = false;
                dgvSaLab.DataSource = false;
                dgvSaLab.DataSource = saLabLista;

                // 4) Konfiguriši i popuni standardne apoteke
                dgvStandardne.AutoGenerateColumns = false;
                dgvStandardne.DataSource = false;
                dgvStandardne.DataSource = standardneLista;

                // 5) Konfiguriši i popuni specijalizovane apoteke
                dgvSpecijalizovane.AutoGenerateColumns = false;
                dgvSpecijalizovane.DataSource = false;
                dgvSpecijalizovane.DataSource = specijalizovaneLista;

                // Dodaj kolone za sve DataGridView kontrole ako nisu već dodate
                if (dgvOsnovne.Columns.Count == 0)
                {
                    DodajKolone(dgvOsnovne);
                }
                if (dgvSaLab.Columns.Count == 0)
                {
                    DodajKolone(dgvSaLab);
                }
                if (dgvStandardne.Columns.Count == 0)
                {
                    DodajKolone(dgvStandardne);
                }
                if (dgvSpecijalizovane.Columns.Count == 0)
                {
                    DodajKolone(dgvSpecijalizovane);
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
            if (GetCurrentDataGridView().SelectedRows.Count > 0)
            {
                mbr = Convert.ToInt64(GetCurrentDataGridView().CurrentRow.Cells[0].Value);
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
            if (GetCurrentDataGridView().CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati prodajnu jedinicu!");
                return;
            }
            long id = 0;
            if (GetCurrentDataGridView().SelectedRows.Count > 0)
            {
                id = Convert.ToInt64(GetCurrentDataGridView().CurrentRow.Cells[0].Value);
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
        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            ZaposleniPrikaz form = new ZaposleniPrikaz();
            form.ShowDialog();
        }

        private void DodajKolone(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "Id",
                DataPropertyName = "Id",
                Width = 90
            });
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNaziv",
                HeaderText = "Naziv",
                DataPropertyName = "Naziv",
                Width = 140
            });
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUlica",
                HeaderText = "Ulica",
                DataPropertyName = "Ulica",
                Width = 160
            });
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPostanskiBroj",
                HeaderText = "Broj",
                DataPropertyName = "Broj",
                Width = 160
            });
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colMesto",
                HeaderText = "Mesto",
                DataPropertyName = "Mesto",
                Width = 160
            });
        }

        private DataGridView GetCurrentDataGridView()
        {
            switch (tabControlApoteke.SelectedIndex)
            {
                case 0: return dgvOsnovne;
                case 1: return dgvSaLab;
                case 2: return dgvStandardne;
                case 3: return dgvSpecijalizovane;
                default: return dgvOsnovne;
            }
        }

        private void btnSuplementi_Click(object sender, EventArgs e)
        {
            DataGridView currentDgv = GetCurrentDataGridView();
            if (currentDgv?.CurrentRow == null)
            {
                MessageBox.Show("Morate izabrati apoteku!");
                return;
            }
            long id = 0;
            if (currentDgv.SelectedRows.Count > 0)
            {
                id = Convert.ToInt64(currentDgv.CurrentRow.Cells[0].Value);
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
            DataGridView currentDgv = GetCurrentDataGridView();
            if (currentDgv?.CurrentRow == null)
            {
                MessageBox.Show("Morate izabrati apoteku!");
                return;
            }
            long id = 0;
            if (currentDgv.SelectedRows.Count > 0)
            {
                id = Convert.ToInt64(currentDgv.CurrentRow.Cells[0].Value);
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
            DataGridView currentDgv = GetCurrentDataGridView();
            if (currentDgv?.CurrentRow == null)
            {
                MessageBox.Show("Morate izabrati apoteku!");
                return;
            }
            long id = 0;
            if (currentDgv.SelectedRows.Count > 0)
            {
                id = Convert.ToInt64(currentDgv.CurrentRow.Cells[0].Value);
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

        private void btnRadnoVreme_Click(object sender, EventArgs e)
        {
            if (GetCurrentDataGridView().CurrentRow == null)
            {
                MessageBox.Show("Morate izabrati apoteku!");
                return;
            }
            long id = 0;
            if (GetCurrentDataGridView().SelectedRows.Count > 0)
            {
                id = Convert.ToInt64(GetCurrentDataGridView().CurrentRow.Cells[0].Value);
            }
            else
            {
                MessageBox.Show("Morate izabrati apoteku prvo!");
                return;
            }

            RadnoVremeForm form = new RadnoVremeForm(id);
            form.ShowDialog();
        }

        private void btnZalihe_Click(object sender, EventArgs e)
        {
            ZaliheAdminForm form = new ZaliheAdminForm();
            form.ShowDialog();
        }

        private void btnProdaja_Click(object sender, EventArgs e)
        {
            if (GetCurrentDataGridView().CurrentRow == null)
            {
                MessageBox.Show("Morate izabrati apoteku!");
                return;
            }
            long id = 0;
            if (GetCurrentDataGridView().SelectedRows.Count > 0)
            {
                id = Convert.ToInt64(GetCurrentDataGridView().CurrentRow.Cells[0].Value);
            }
            else
            {
                MessageBox.Show("Morate izabrati apoteku prvo!");
                return;
            }

            ProdajaAdminForm form = new ProdajaAdminForm(id);
            form.ShowDialog();
        }

        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {
            if (GetCurrentDataGridView().CurrentRow == null)
            {
                MessageBox.Show("Morate izabrati prodajnu jedinicu!");
                return;
            }
            long id = Convert.ToInt64(GetCurrentDataGridView().CurrentRow.Cells[0].Value);

            // Prikaži formu za odabir tipa zaposlenog
            OdaberiTipZaposlenogForm form = new OdaberiTipZaposlenogForm(id);
            form.ShowDialog();
        }

        private void btnPrikaziZaposlene_Click(object sender, EventArgs e)
        {
            if (GetCurrentDataGridView().CurrentRow == null)
            {
                MessageBox.Show("Morate izabrati prodajnu jedinicu!");
                return;
            }
            long id = Convert.ToInt64(GetCurrentDataGridView().CurrentRow.Cells[0].Value);

            // Prikaži formu za raspored rada
            RasporedRadaForm form = new RasporedRadaForm(id);
            form.ShowDialog();
        }

        private void grpServisi_Enter(object sender, EventArgs e)
        {

        }
    }
}
