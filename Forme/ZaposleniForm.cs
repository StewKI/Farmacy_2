using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class ZaposleniForm : Form
    {
        private Zaposleni zaposleni;

        public ZaposleniForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public ZaposleniForm(Zaposleni zaposleni) : this()
        {
            this.zaposleni = zaposleni;
            LoadZaposleniData();
        }

        private void InitializeForm()
        {
            // Form initialization logic will be in Designer file
        }

        private void LoadZaposleniData()
        {
            if (zaposleni != null)
            {
                txtMBr.Text = zaposleni.MBr.ToString();
                txtPrezime.Text = zaposleni.Prezime;
                txtIme.Text = zaposleni.Ime;
                dtpDatumRodj.Value = zaposleni.DatumRodj;
                txtAdresa.Text = zaposleni.Adresa ?? string.Empty;
                txtTelefon.Text = zaposleni.Telefon ?? string.Empty;
                dtpDatumZaposlenja.Value = zaposleni.DatumZaposlenja;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveZaposleni();
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

            if (dtpDatumRodj.Value >= DateTime.Now)
            {
                MessageBox.Show("Datum rođenja mora biti u prošlosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDatumRodj.Focus();
                return false;
            }

            if (dtpDatumZaposlenja.Value > DateTime.Now)
            {
                MessageBox.Show("Datum zaposlenja ne može biti u budućnosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDatumZaposlenja.Focus();
                return false;
            }

            return true;
        }

        private void SaveZaposleni()
        {
            if (zaposleni == null)
            {
                zaposleni = new Zaposleni();
            }

            zaposleni.Prezime = txtPrezime.Text.Trim();
            zaposleni.Ime = txtIme.Text.Trim();
            zaposleni.DatumRodj = dtpDatumRodj.Value;
            zaposleni.Adresa = string.IsNullOrWhiteSpace(txtAdresa.Text) ? null : txtAdresa.Text.Trim();
            zaposleni.Telefon = string.IsNullOrWhiteSpace(txtTelefon.Text) ? null : txtTelefon.Text.Trim();
            zaposleni.DatumZaposlenja = dtpDatumZaposlenja.Value;
        }

        public Zaposleni GetZaposleni()
        {
            return zaposleni;
        }
    }
}
