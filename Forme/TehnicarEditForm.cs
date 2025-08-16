using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class TehnicarEditForm : Form
    {
        private Tehnicar tehnicar;

        public TehnicarEditForm(Tehnicar tehnicar)
        {
            if (tehnicar == null)
                throw new ArgumentNullException(nameof(tehnicar));

            InitializeComponent();
            this.tehnicar = tehnicar;
            LoadTehnicarData();
        }

        private void LoadTehnicarData()
        {
            // Učitavamo postojeće podatke
            txtMBr.Text = tehnicar.MBr.ToString();
            txtPrezime.Text = tehnicar.Prezime;
            txtIme.Text = tehnicar.Ime;
            dtpDatumRodj.Value = tehnicar.DatumRodj;
            
            if (!string.IsNullOrEmpty(tehnicar.Adresa))
                txtAdresa.Text = tehnicar.Adresa;
            
            if (!string.IsNullOrEmpty(tehnicar.Telefon))
                txtTelefon.Text = tehnicar.Telefon;
            
            dtpDatumZaposlenja.Value = tehnicar.DatumZaposlenja;
            
            if (!string.IsNullOrEmpty(tehnicar.NivoObrazovanja))
                txtNivoObrazovanja.Text = tehnicar.NivoObrazovanja;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveTehnicar();
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
                txtMBr.Focus();
                return false;
            }

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

            if (string.IsNullOrWhiteSpace(txtNivoObrazovanja.Text))
            {
                MessageBox.Show("Nivo obrazovanja je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNivoObrazovanja.Focus();
                return false;
            }

            return true;
        }

        private void SaveTehnicar()
        {
            if (long.TryParse(txtMBr.Text, out long mbr))
                tehnicar.MBr = mbr;
            
            tehnicar.Prezime = txtPrezime.Text.Trim();
            tehnicar.Ime = txtIme.Text.Trim();
            tehnicar.DatumRodj = dtpDatumRodj.Value;
            tehnicar.Adresa = string.IsNullOrWhiteSpace(txtAdresa.Text) ? null : txtAdresa.Text.Trim();
            tehnicar.Telefon = string.IsNullOrWhiteSpace(txtTelefon.Text) ? null : txtTelefon.Text.Trim();
            tehnicar.DatumZaposlenja = dtpDatumZaposlenja.Value;
            tehnicar.NivoObrazovanja = txtNivoObrazovanja.Text.Trim();
        }

        public Tehnicar GetTehnicar()
        {
            return tehnicar;
        }
    }
}
