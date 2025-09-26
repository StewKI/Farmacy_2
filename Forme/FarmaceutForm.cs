using System;
using System.Drawing;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class FarmaceutForm : Form
    {
        private FarmaceutBasic farmaceut;
        private long prodajnaJedinicaId;

        public FarmaceutForm()
        {
            InitializeComponent();
            InitializeForm();
            this.prodajnaJedinicaId = 0; // Default value
            SetupButtonEffects();
        }

        public FarmaceutForm(long prodajnaJedinicaId)
        {
            InitializeComponent();
            InitializeForm();
            this.prodajnaJedinicaId = prodajnaJedinicaId;
            SetupButtonEffects();
        }

        public FarmaceutForm(FarmaceutBasic farmaceut, long prodajnaJedinicaId) : this(prodajnaJedinicaId)
        {
            this.farmaceut = farmaceut;
            LoadFarmaceutData();
            SetupButtonEffects();
        }

        private void InitializeForm()
        {
            // Form initialization logic will be in Designer file
        }

        private void LoadFarmaceutData()
        {
            if (farmaceut != null)
            {
                //txtMBr.Text = farmaceut.MBr.ToString();
                txtPrezime.Text = farmaceut.Prezime;
                txtIme.Text = farmaceut.Ime;
                dtpDatumRodj.Value = farmaceut.DatumRodj;
                txtAdresa.Text = farmaceut.Adresa ?? string.Empty;
                txtTelefon.Text = farmaceut.Telefon ?? string.Empty;
                dtpDatumZaposlenja.Value = farmaceut.DatumZaposlenja;
                dtpDatumDiplomiranja.Value = farmaceut.DatumDiplomiranja;
                txtBrLicence.Text = farmaceut.BrLicence;
                dtpDatumPoslObnoveLicence.Value = farmaceut.DatumPoslednjeObnoveLicence;
                txtSpecijalnost.Text = farmaceut.Specijalnost ?? string.Empty;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveFarmaceut();
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

            if (string.IsNullOrWhiteSpace(txtBrLicence.Text))
            {
                MessageBox.Show("Broj licence je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBrLicence.Focus();
                return false;
            }

            return true;
        }

        void ucitajApoteke()
        {
            // No longer needed - prodajnaJedinicaId is passed as parameter
        }
        private void SaveFarmaceut()
        {
            if (farmaceut == null)
            {
                farmaceut = new FarmaceutBasic();
            }

            // Generiši MBr ako nije postavljen
            if (farmaceut.Id == 0)
            {
                farmaceut.Id = DateTime.Now.Ticks;
            }

            farmaceut.Prezime = txtPrezime.Text.Trim();
            farmaceut.Ime = txtIme.Text.Trim();
            farmaceut.DatumRodj = dtpDatumRodj.Value;
            farmaceut.Adresa = string.IsNullOrWhiteSpace(txtAdresa.Text) ? null : txtAdresa.Text.Trim();
            farmaceut.Telefon = string.IsNullOrWhiteSpace(txtTelefon.Text) ? null : txtTelefon.Text.Trim();
            farmaceut.DatumZaposlenja = dtpDatumZaposlenja.Value;
            farmaceut.DatumDiplomiranja = dtpDatumDiplomiranja.Value;
            farmaceut.BrLicence = txtBrLicence.Text.Trim();
            farmaceut.DatumPoslednjeObnoveLicence = dtpDatumPoslObnoveLicence.Value;
            farmaceut.Specijalnost = string.IsNullOrWhiteSpace(txtSpecijalnost.Text) ? null : txtSpecijalnost.Text.Trim();

            // Dodaj farmaceuta u sistem
            DTOManagerZaposleni.DodajFarmaceuta(farmaceut);


        }

        public FarmaceutBasic GetFarmaceut()
        {
            return farmaceut;
        }

        private void FarmaceutForm_Load(object sender, EventArgs e)
        {

        }

        private void lblMBr_Click(object sender, EventArgs e)
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
                // Vrati originalnu boju
                button.BackColor = originalColor;
                button.Cursor = Cursors.Default;
            }
        }
    }
}
