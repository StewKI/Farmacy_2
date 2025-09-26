using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class MenadzerEditForm : Form
    {
        private MenadzerBasic menadzer;

        public MenadzerEditForm(MenadzerBasic menadzer)
        {
            if (menadzer == null)
                throw new ArgumentNullException(nameof(menadzer));

            InitializeComponent();
            this.menadzer = menadzer;
            LoadMenadzerData();
            SetupButtonEffects();
        }

        private void LoadMenadzerData()
        {
            // Učitavamo postojeće podatke
            txtMBr.Text = menadzer.Id.ToString();
            txtPrezime.Text = menadzer.Prezime;
            txtIme.Text = menadzer.Ime;
            dtpDatumRodj.Value = menadzer.DatumRodj;

            if (!string.IsNullOrEmpty(menadzer.Adresa))
                txtAdresa.Text = menadzer.Adresa;

            if (!string.IsNullOrEmpty(menadzer.Telefon))
                txtTelefon.Text = menadzer.Telefon;

            dtpDatumZaposlenja.Value = menadzer.DatumZaposlenja;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveMenadzer();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtMBr.Text))
            {
                MessageBox.Show("Matični broj je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                MessageBox.Show("Prezime je obavezno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                MessageBox.Show("Ime je obavezno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dtpDatumRodj.Value >= DateTime.Now)
            {
                MessageBox.Show("Datum rođenja ne može biti u budućnosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dtpDatumZaposlenja.Value > DateTime.Now)
            {
                MessageBox.Show("Datum zaposlenja ne može biti u budućnosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dtpDatumZaposlenja.Value <= dtpDatumRodj.Value)
            {
                MessageBox.Show("Datum zaposlenja mora biti posle datuma rođenja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void SaveMenadzer()
        {
            if (long.TryParse(txtMBr.Text, out long mbr))
                menadzer.Id = mbr;

            menadzer.Prezime = txtPrezime.Text.Trim();
            menadzer.Ime = txtIme.Text.Trim();
            menadzer.DatumRodj = dtpDatumRodj.Value;
            menadzer.Adresa = string.IsNullOrWhiteSpace(txtAdresa.Text) ? null : txtAdresa.Text.Trim();
            menadzer.Telefon = string.IsNullOrWhiteSpace(txtTelefon.Text) ? null : txtTelefon.Text.Trim();
            menadzer.DatumZaposlenja = dtpDatumZaposlenja.Value;

            DTOManagerZaposleni.UpdateMenadzera(menadzer);
        }

        public MenadzerBasic GetMenadzer()
        {
            return menadzer;
        }

        private void MenadzerEditForm_Load(object sender, EventArgs e)
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
                    button.BackColor = Color.FromArgb(142, 68, 173); // Tamnija ljubičasta
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
