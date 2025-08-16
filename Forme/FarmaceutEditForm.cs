using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy_2.Forme
{
    public partial class FarmaceutEditForm : Form
    {
        private Farmaceut farmaceut;

        public FarmaceutEditForm(Farmaceut farmaceut)
        {
            InitializeComponent();
            this.farmaceut = farmaceut ?? throw new ArgumentNullException(nameof(farmaceut));
            LoadFarmaceutData();
        }

        private void LoadFarmaceutData()
        {
            // Load inherited properties from Zaposleni
            txtMBr.Text = farmaceut.MBr.ToString();
            txtPrezime.Text = farmaceut.Prezime;
            txtIme.Text = farmaceut.Ime;
            dtpDatumRodj.Value = farmaceut.DatumRodj;
            txtAdresa.Text = farmaceut.Adresa ?? "";
            txtTelefon.Text = farmaceut.Telefon ?? "";
            dtpDatumZaposlenja.Value = farmaceut.DatumZaposlenja;
            
            // Load Farmaceut-specific properties
            dtpDatumDiplomiranja.Value = farmaceut.DatumDiplomiranja;
            txtBrLicence.Text = farmaceut.BrLicence;
            dtpDatumPoslObnoveLicence.Value = farmaceut.DatumPoslObnoveLicence;
            txtSpecijalnost.Text = farmaceut.Specijalnost ?? "";
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                MessageBox.Show("Prezime je obavezno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrezime.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                MessageBox.Show("Ime je obavezno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIme.Focus();
                return false;
            }

            if (dtpDatumRodj.Value >= DateTime.Now)
            {
                MessageBox.Show("Datum rođenja ne može biti u budućnosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDatumRodj.Focus();
                return false;
            }

            if (dtpDatumZaposlenja.Value > DateTime.Now)
            {
                MessageBox.Show("Datum zaposlenja ne može biti u budućnosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDatumZaposlenja.Focus();
                return false;
            }

            if (dtpDatumZaposlenja.Value <= dtpDatumRodj.Value)
            {
                MessageBox.Show("Datum zaposlenja mora biti nakon datuma rođenja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDatumZaposlenja.Focus();
                return false;
            }

            if (dtpDatumDiplomiranja.Value > DateTime.Now)
            {
                MessageBox.Show("Datum diplomiranja ne može biti u budućnosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDatumDiplomiranja.Focus();
                return false;
            }

            if (dtpDatumDiplomiranja.Value <= dtpDatumRodj.Value)
            {
                MessageBox.Show("Datum diplomiranja mora biti nakon datuma rođenja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDatumDiplomiranja.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBrLicence.Text))
            {
                MessageBox.Show("Broj licence je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBrLicence.Focus();
                return false;
            }

            if (dtpDatumPoslObnoveLicence.Value > DateTime.Now)
            {
                MessageBox.Show("Datum poslednje obnove licence ne može biti u budućnosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDatumPoslObnoveLicence.Focus();
                return false;
            }

            if (dtpDatumPoslObnoveLicence.Value < dtpDatumDiplomiranja.Value)
            {
                MessageBox.Show("Datum poslednje obnove licence ne može biti pre diplomiranja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDatumPoslObnoveLicence.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtTelefon.Text) && txtTelefon.Text.Length < 9)
            {
                MessageBox.Show("Telefon mora imati najmanje 9 karaktera!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefon.Focus();
                return false;
            }

            return true;
        }

        private void SaveFarmaceut()
        {
            // Save inherited properties to Zaposleni
            farmaceut.Prezime = txtPrezime.Text.Trim();
            farmaceut.Ime = txtIme.Text.Trim();
            farmaceut.DatumRodj = dtpDatumRodj.Value;
            farmaceut.Adresa = string.IsNullOrWhiteSpace(txtAdresa.Text) ? null : txtAdresa.Text.Trim();
            farmaceut.Telefon = string.IsNullOrWhiteSpace(txtTelefon.Text) ? null : txtTelefon.Text.Trim();
            farmaceut.DatumZaposlenja = dtpDatumZaposlenja.Value;
            
            // Save Farmaceut-specific properties
            farmaceut.DatumDiplomiranja = dtpDatumDiplomiranja.Value;
            farmaceut.BrLicence = txtBrLicence.Text.Trim();
            farmaceut.DatumPoslObnoveLicence = dtpDatumPoslObnoveLicence.Value;
            farmaceut.Specijalnost = string.IsNullOrWhiteSpace(txtSpecijalnost.Text) ? null : txtSpecijalnost.Text.Trim();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveFarmaceut();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public Farmaceut GetFarmaceut()
        {
            return farmaceut;
        }
    }
}
