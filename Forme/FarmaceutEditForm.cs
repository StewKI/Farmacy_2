using System;
using System.Windows.Forms;
using Farmacy;


namespace Farmacy_2.Forme
{
    public partial class FarmaceutEditForm : Form
    {
        private FarmaceutBasic farmaceut;

        public FarmaceutEditForm(FarmaceutBasic farmaceut)
        {
            InitializeComponent();
            this.farmaceut = farmaceut ?? throw new ArgumentNullException(nameof(farmaceut));
            LoadFarmaceutData();
            SetupButtonEffects();
        }

        private void LoadFarmaceutData()
        {
            // Load inherited properties from Zaposleni
            txtMBr.Text = farmaceut.Id.ToString();
            txtPrezime.Text = farmaceut.Prezime;
            txtIme.Text = farmaceut.Ime;
            dtpDatumRodj.Value = farmaceut.DatumRodj;
            txtAdresa.Text = farmaceut.Adresa ?? "";
            txtTelefon.Text = farmaceut.Telefon ?? "";
            dtpDatumZaposlenja.Value = farmaceut.DatumZaposlenja;

            // Load Farmaceut-specific properties
            dtpDatumDiplomiranja.Value = farmaceut.DatumDiplomiranja;
            txtBrLicence.Text = farmaceut.BrLicence;
            dtpDatumPoslObnoveLicence.Value = farmaceut.DatumPoslednjeObnoveLicence;
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
            farmaceut.DatumPoslednjeObnoveLicence = dtpDatumPoslObnoveLicence.Value;
            farmaceut.Specijalnost = string.IsNullOrWhiteSpace(txtSpecijalnost.Text) ? null : txtSpecijalnost.Text.Trim();

            DTOManagerZaposleni.UpdateFarmaceuta(farmaceut);
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

        public FarmaceutBasic GetFarmaceut()
        {
            return farmaceut;
        }

        private void FarmaceutEditForm_Load(object sender, EventArgs e)
        {

        }

        private void SetupButtonEffects()
        {
            // Dodaj hover efekte za dugmad
            btnSave.MouseEnter += Button_MouseEnter;
            btnSave.MouseLeave += Button_MouseLeave;
            btnCancel.MouseEnter += Button_MouseEnter;
            btnCancel.MouseLeave += Button_MouseLeave;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                // Sačuvaj originalnu boju samo ako nije već sačuvana
                if (button.Tag == null)
                {
                    button.Tag = button.BackColor;
                }
                
                // Promeni boju na hover
                if (button == btnSave)
                {
                    button.BackColor = Color.FromArgb(41, 128, 185); // Tamnija plava
                }
                else if (button == btnCancel)
                {
                    button.BackColor = Color.FromArgb(192, 57, 43); // Tamnija crvena
                }
                
                button.Cursor = Cursors.Hand;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is Color originalColor)
            {
                button.BackColor = originalColor;
                button.Cursor = Cursors.Default;
            }
        }
    }
}
