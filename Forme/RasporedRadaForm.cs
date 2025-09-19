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
    public partial class RasporedRadaForm : Form
    {
        private long? prodajnaJedinicaId;
        private long? selektovaniMBr;

        public RasporedRadaForm(long? prodajnaJedinicaId = null)
        {
            InitializeComponent();
            this.prodajnaJedinicaId = prodajnaJedinicaId;
            LoadProdajneJedinice();
            LoadZaposlene();
            LoadRasporedRada();
        }

        private void LoadZaposlene()
        {
            try
            {
                var zaposleni = DTOManagerZaposleni.VratiSveZaposlene();
                
                cmbZaposleni.DataSource = zaposleni;
                cmbZaposleni.DisplayMember = "Ime";
                cmbZaposleni.ValueMember = "MBr";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju zaposlenih: {ex.Message}", "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProdajneJedinice()
        {
            try
            {
                var prodajneJedinice = DTOManagerProdajneJedinice.VratiSveProdajneJedinice();
                
                cmbProdajnaJedinica.DataSource = prodajneJedinice;
                cmbProdajnaJedinica.DisplayMember = "Naziv";
                cmbProdajnaJedinica.ValueMember = "Id";
                
                // Postavi selektovanu prodajnu jedinicu ako je prosleđena
                if (prodajnaJedinicaId.HasValue)
                {
                    cmbProdajnaJedinica.SelectedValue = prodajnaJedinicaId.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju prodajnih jedinica: {ex.Message}", "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRasporedRada()
        {
            try
            {
                IList<RasporedRadaBasic> raspored;
                
                if (prodajnaJedinicaId.HasValue)
                {
                    raspored = DTOManagerZaposleni.VratiRasporedRadaZaProdajnuJedinicu(prodajnaJedinicaId.Value);
                }
                else
                {
                    raspored = DTOManagerZaposleni.VratiSveRasporedeRada();
                }
                
                dgvRaspored.AutoGenerateColumns = true;
                dgvRaspored.DataSource = raspored;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju rasporeda rada: {ex.Message}", "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (cmbZaposleni.SelectedValue == null)
            {
                MessageBox.Show("Molimo odaberite zaposlenog!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbProdajnaJedinica.SelectedValue == null)
            {
                MessageBox.Show("Molimo odaberite prodajnu jedinicu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpPocetak.Value >= dtpKraj.Value)
            {
                MessageBox.Show("Datum početka mora biti pre datuma kraja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbSmena.SelectedIndex == -1)
            {
                MessageBox.Show("Molimo odaberite smenu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var raspored = new RasporedRadaBasic
                {
                    MBr = (long)cmbZaposleni.SelectedValue,
                    ProdajnaJedinicaId = (long)cmbProdajnaJedinica.SelectedValue,
                    Pocetak = dtpPocetak.Value,
                    Kraj = dtpKraj.Value,
                    BrojSmene = cmbSmena.SelectedIndex + 1
                };

                DTOManagerZaposleni.DodajRasporedRada(raspored);
                LoadRasporedRada();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri dodavanju rasporeda rada: {ex.Message}", "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvRaspored.CurrentRow == null)
            {
                MessageBox.Show("Molimo odaberite raspored rada za brisanje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var raspored = (RasporedRadaBasic)dgvRaspored.CurrentRow.DataBoundItem;
            
            var result = MessageBox.Show($"Da li ste sigurni da želite da obrišete raspored rada za {raspored.ZaposleniIme} {raspored.ZaposleniPrezime}?", 
                "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DTOManagerZaposleni.ObrisiRasporedRada(raspored.MBr, raspored.ProdajnaJedinicaId, raspored.Pocetak);
                LoadRasporedRada();
            }
        }

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            LoadRasporedRada();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            if (cmbProdajnaJedinica.SelectedValue != null)
            {
                prodajnaJedinicaId = (long)cmbProdajnaJedinica.SelectedValue;
            }
            else
            {
                prodajnaJedinicaId = null;
            }
            
            LoadRasporedRada();
        }

        private void ClearForm()
        {
            cmbZaposleni.SelectedIndex = -1;
            dtpPocetak.Value = DateTime.Now;
            dtpKraj.Value = DateTime.Now.AddHours(8);
            cmbSmena.SelectedIndex = -1;
        }

        private void RasporedRadaForm_Load(object sender, EventArgs e)
        {
            // Postavi default vrednosti
            dtpPocetak.Value = DateTime.Now;
            dtpKraj.Value = DateTime.Now.AddHours(8);
        }
    }
}
