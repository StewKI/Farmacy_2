using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy_2.Forme
{
    public partial class ProdajnaStavkaEditForm : Form
    {
        private ProdajaStavka prodajnaStavka;

        public ProdajnaStavkaEditForm(ProdajaStavka prodajnaStavka)
        {
            InitializeComponent();
            this.prodajnaStavka = prodajnaStavka ?? throw new ArgumentNullException(nameof(prodajnaStavka));
            LoadProdajnaStavkaData();
        }

        private void LoadProdajnaStavkaData()
        {
            txtProdaja.Text = prodajnaStavka.Prodaja?.Id.ToString() ?? "Nije postavljen";
            txtPakovanje.Text = prodajnaStavka.Pakovanje?.Id.ToString() ?? "Nije postavljen";
            numKolicina.Value = prodajnaStavka.Kolicina;
            numCena.Value = prodajnaStavka.Cena ?? 0;
            txtRecept.Text = prodajnaStavka.Recept?.SerijskiBroj ?? "Nije postavljen";
            numKontrolisanaKol.Value = prodajnaStavka.KontrolisanaKol ?? 0;
            numProcenatParticip.Value = prodajnaStavka.ProcenatParticip ?? 0;
            cmbNeophodanIzvestaj.Text = prodajnaStavka.NeophodanIzvestaj ?? "N";
        }

        private bool ValidateForm()
        {
            if (numKolicina.Value <= 0)
            {
                MessageBox.Show("Količina mora biti veća od 0!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numKolicina.Focus();
                return false;
            }

            if (numCena.Value < 0)
            {
                MessageBox.Show("Cena ne može biti negativna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numCena.Focus();
                return false;
            }

            if (numKontrolisanaKol.Value < 0)
            {
                MessageBox.Show("Kontrolisana količina ne može biti negativna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numKontrolisanaKol.Focus();
                return false;
            }

            if (numProcenatParticip.Value < 0 || numProcenatParticip.Value > 100)
            {
                MessageBox.Show("Procenat participacije mora biti između 0 i 100!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numProcenatParticip.Focus();
                return false;
            }

            if (cmbNeophodanIzvestaj.Text != "Y" && cmbNeophodanIzvestaj.Text != "N")
            {
                MessageBox.Show("Neophodan izveštaj mora biti 'Y' ili 'N'!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbNeophodanIzvestaj.Focus();
                return false;
            }

            return true;
        }

        private void SaveProdajnaStavka()
        {
            prodajnaStavka.Kolicina = (int)numKolicina.Value;
            prodajnaStavka.Cena = numCena.Value > 0 ? numCena.Value : null;
            prodajnaStavka.KontrolisanaKol = numKontrolisanaKol.Value > 0 ? (int)numKontrolisanaKol.Value : null;
            prodajnaStavka.ProcenatParticip = numProcenatParticip.Value > 0 ? numProcenatParticip.Value : null;
            prodajnaStavka.NeophodanIzvestaj = cmbNeophodanIzvestaj.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveProdajnaStavka();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public ProdajaStavka GetProdajnaStavka()
        {
            return prodajnaStavka;
        }
    }
}
