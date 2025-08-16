using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy_2.Forme
{
    public partial class ZaposleniEditForm : Form
    {
        private Zaposleni zaposleni;

        public ZaposleniEditForm(Zaposleni zaposleni)
        {
            InitializeComponent();
            this.zaposleni = zaposleni ?? throw new ArgumentNullException(nameof(zaposleni));
            LoadZaposleniData();
        }

        private void LoadZaposleniData()
        {
            txtMBr.Text = zaposleni.MBr.ToString();
            txtPrezime.Text = zaposleni.Prezime;
            txtIme.Text = zaposleni.Ime;
            dtpDatumRodj.Value = zaposleni.DatumRodj;
            txtAdresa.Text = zaposleni.Adresa ?? "";
            txtTelefon.Text = zaposleni.Telefon ?? "";
            dtpDatumZaposlenja.Value = zaposleni.DatumZaposlenja;
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

            if (!string.IsNullOrWhiteSpace(txtTelefon.Text) && txtTelefon.Text.Length < 9)
            {
                MessageBox.Show("Telefon mora imati najmanje 9 karaktera!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefon.Focus();
                return false;
            }

            return true;
        }

        private void SaveZaposleni()
        {
            zaposleni.Prezime = txtPrezime.Text.Trim();
            zaposleni.Ime = txtIme.Text.Trim();
            zaposleni.DatumRodj = dtpDatumRodj.Value;
            zaposleni.Adresa = string.IsNullOrWhiteSpace(txtAdresa.Text) ? null : txtAdresa.Text.Trim();
            zaposleni.Telefon = string.IsNullOrWhiteSpace(txtTelefon.Text) ? null : txtTelefon.Text.Trim();
            zaposleni.DatumZaposlenja = dtpDatumZaposlenja.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveZaposleni();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public Zaposleni GetZaposleni()
        {
            return zaposleni;
        }
    }
}
