using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class ProdajnaStavkaForm : Form
    {
        private ProdajaStavka prodajaStavka;

        public ProdajnaStavkaForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public ProdajnaStavkaForm(ProdajaStavka prodajaStavka) : this()
        {
            this.prodajaStavka = prodajaStavka;
            LoadProdajaStavkaData();
        }

        private void InitializeForm()
        {
            // Form initialization logic will be in Designer file
        }

        private void LoadProdajaStavkaData()
        {
            if (prodajaStavka != null)
            {
                if (prodajaStavka.Prodaja != null)
                    txtProdaja.Text = prodajaStavka.Prodaja.ToString();
                
                if (prodajaStavka.Pakovanje != null)
                    txtPakovanje.Text = prodajaStavka.Pakovanje.ToString();
                
                numKolicina.Value = prodajaStavka.Kolicina;
                
                if (prodajaStavka.Cena.HasValue)
                    numCena.Value = prodajaStavka.Cena.Value;
                
                if (prodajaStavka.Recept != null)
                    txtRecept.Text = prodajaStavka.Recept.ToString();
                
                if (prodajaStavka.KontrolisanaKol.HasValue)
                    numKontrolisanaKol.Value = prodajaStavka.KontrolisanaKol.Value;
                
                if (prodajaStavka.ProcenatParticip.HasValue)
                    numProcenatParticip.Value = prodajaStavka.ProcenatParticip.Value;
                
                if (prodajaStavka.NeophodanIzvestaj != null)
                    cboNeophodanIzvestaj.SelectedItem = prodajaStavka.NeophodanIzvestaj;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveProdajaStavka();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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

            return true;
        }

        private void SaveProdajaStavka()
        {
            if (prodajaStavka == null)
            {
                prodajaStavka = new ProdajaStavka();
            }

            prodajaStavka.Kolicina = (int)numKolicina.Value;
            prodajaStavka.Cena = numCena.Value;
            prodajaStavka.KontrolisanaKol = (int)numKontrolisanaKol.Value;
            prodajaStavka.ProcenatParticip = numProcenatParticip.Value;
            prodajaStavka.NeophodanIzvestaj = cboNeophodanIzvestaj.SelectedItem?.ToString();
        }

        public ProdajaStavka GetProdajaStavka()
        {
            return prodajaStavka;
        }
    }
}
