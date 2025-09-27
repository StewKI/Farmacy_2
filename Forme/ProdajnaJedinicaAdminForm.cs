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
            SetupButtonEffects();
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
                // Column mapping removed - using AutoGenerateColumns
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

                // Dodaj kolone za sve DataGridView kontrole
                DodajKolone(dgvOsnovne);
                DodajKolone(dgvSaLab);
                DodajKolone(dgvStandardne);
                DodajKolone(dgvSpecijalizovane);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju prodajnih jedinica:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            long mbr = 0;
            if (GetCurrentDataGridView().SelectedRows.Count > 0)
            {
                mbr = Convert.ToInt64(GetCurrentDataGridView().CurrentRow.Cells[0].Value);
                MessageBox.Show("Selektovan ID: " + mbr);

            }
            else
            {
                MessageBox.Show("Morate izabrati prodajnu jedinicu prvo!");
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
            dgv.Columns.Clear(); // Clear existing columns first
            
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
                Name = "colBroj",
                HeaderText = "Broj",
                DataPropertyName = "Broj",
                Width = 80
            });
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPostanskiBroj",
                HeaderText = "Poštanski broj",
                DataPropertyName = "PostanskiBroj",
                Width = 100
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
            if(form.napravljeno)
            {
                form.ShowDialog();
            }
            
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

        private void SetupButtonEffects()
        {
            // Dodaj hover efekte za dugmad u svim GroupBox kontrolama
            foreach (Control groupBox in panelButtons.Controls)
            {
                if (groupBox is GroupBox gb)
                {
                    foreach (Control control in gb.Controls)
                    {
                        if (control is Button button)
                        {
                            button.MouseEnter += Button_MouseEnter;
                            button.MouseLeave += Button_MouseLeave;
                        }
                    }
                }
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                // Sačuvaj originalnu boju
                button.Tag = button.BackColor;
                
                // Promeni boju na hover
                if (button == btnDodaj)
                {
                    button.BackColor = Color.FromArgb(39, 174, 96); // Tamnija zelena
                }
                else if (button == btnObrisi)
                {
                    button.BackColor = Color.FromArgb(192, 57, 43); // Tamnija crvena
                }
                else if (button == btnIzmeni)
                {
                    button.BackColor = Color.FromArgb(41, 128, 185); // Tamnija plava
                }
                else if (button == btnProdaja)
                {
                    button.BackColor = Color.FromArgb(142, 68, 173); // Tamnija ljubičasta
                }
                else if (button == btnZalihe)
                {
                    button.BackColor = Color.FromArgb(41, 128, 185); // Tamnija plava
                }
                else if (button == btnRadnoVreme)
                {
                    button.BackColor = Color.FromArgb(34, 153, 84); // Tamnija zelena
                }
                else if (button == btnZaposleni)
                {
                    button.BackColor = Color.FromArgb(211, 84, 0); // Tamnija narandžasta
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
    }
}
