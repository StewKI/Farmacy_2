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
        private long prodajnaJedinicaId;
        private long? selektovaniMBr;

        public RasporedRadaForm(long prodajnaJedinicaId)
        {
            InitializeComponent();
            this.prodajnaJedinicaId = prodajnaJedinicaId;
            LoadZaposlene();
            LoadRasporedRada();
        }

        private void LoadZaposlene()
        {
            try
            {
                var zaposleni = DTOManagerZaposleni.VratiZaposleneZaProdajnuJedinicu(prodajnaJedinicaId);
                
                cmbZaposleni.DataSource = zaposleni;
                cmbZaposleni.DisplayMember = "ZaposleniIme";
                cmbZaposleni.ValueMember = "MBr";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju zaposlenih: {ex.Message}", "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRasporedRada()
        {
            try
            {
                var raspored = DTOManagerZaposleni.VratiRasporedRadaZaProdajnuJedinicu(prodajnaJedinicaId);
                
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
                    ProdajnaJedinicaId = prodajnaJedinicaId,
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
