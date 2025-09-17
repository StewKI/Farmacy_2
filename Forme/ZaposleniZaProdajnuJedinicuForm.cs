using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class ZaposleniZaProdajnuJedinicuForm : Form
    {
        private long prodajnaJedinicaId;

        public ZaposleniZaProdajnuJedinicuForm(long prodajnaJedinicaId)
        {
            InitializeComponent();
            this.prodajnaJedinicaId = prodajnaJedinicaId;
            this.Load += (s, e) => LoadZaposlene();
        }

        private void LoadZaposlene()
        {
            try
            {
                if (dgvZaposleni == null) return;
                
                var zaposleni = DTOManagerZaposleni.VratiZaposleneZaProdajnuJedinicu(prodajnaJedinicaId);
                
                dgvZaposleni.AutoGenerateColumns = true;
                dgvZaposleni.DataSource = zaposleni;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju zaposlenih: {ex.Message}", "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnZavrsiRad_Click(object sender, EventArgs e)
        {
            if (dgvZaposleni.CurrentRow == null)
            {
                MessageBox.Show("Morate izabrati zaposlenog!");
                return;
            }

            var zaposleni = (ZaposleniProdajnaJedinicaBasic)dgvZaposleni.CurrentRow.DataBoundItem;
            
            if (zaposleni.DatumKraja.HasValue)
            {
                MessageBox.Show("Ovaj zaposleni je već završio rad u ovoj prodajnoj jedinici!");
                return;
            }

            var result = MessageBox.Show($"Da li ste sigurni da želite da završite rad zaposlenog {zaposleni.ZaposleniIme} {zaposleni.ZaposleniPrezime}?", 
                "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DTOManagerZaposleni.ZavrsiRadZaposlenog(zaposleni.MBr, zaposleni.ProdajnaJedinicaId, DateTime.Now);
                LoadZaposlene();
                MessageBox.Show("Rad zaposlenog je uspešno završen!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadZaposlene();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRasporedRada_Click(object sender, EventArgs e)
        {
            // Otvori formu za upravljanje rasporedom rada
            RasporedRadaForm form = new RasporedRadaForm(prodajnaJedinicaId);
            form.ShowDialog();
        }

        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {
            // Prikaži formu za odabir tipa zaposlenog
            OdaberiTipZaposlenogForm form = new OdaberiTipZaposlenogForm(prodajnaJedinicaId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadZaposlene(); // Osveži listu nakon dodavanja
            }
        }

        private void btnPrikaziDetalje_Click(object sender, EventArgs e)
        {
            if (dgvZaposleni.CurrentRow == null)
            {
                MessageBox.Show("Morate izabrati zaposlenog!");
                return;
            }

            var zaposleni = (ZaposleniProdajnaJedinicaBasic)dgvZaposleni.CurrentRow.DataBoundItem;
            
            // Otvori formu za prikaz detalja zaposlenog
            PrikaziDetaljeZaposlenogForm form = new PrikaziDetaljeZaposlenogForm(zaposleni.MBr, prodajnaJedinicaId);
            form.ShowDialog();
        }

        private void btnIzmeniZaposlenog_Click(object sender, EventArgs e)
        {
            if (dgvZaposleni.CurrentRow == null)
            {
                MessageBox.Show("Morate izabrati zaposlenog!");
                return;
            }

            var zaposleni = (ZaposleniProdajnaJedinicaBasic)dgvZaposleni.CurrentRow.DataBoundItem;
            
            // Otvori formu za izmenu zaposlenog
            IzmeniZaposlenogForm form = new IzmeniZaposlenogForm(zaposleni.MBr, prodajnaJedinicaId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadZaposlene(); // Osveži listu nakon izmene
            }
        }
    }
}
