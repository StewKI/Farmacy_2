using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class TehnicarForm : Form
    {
        private Tehnicar tehnicar;

        public TehnicarForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public TehnicarForm(Tehnicar tehnicar) : this()
        {
            this.tehnicar = tehnicar;
            LoadTehnicarData();
        }

        private void InitializeForm()
        {
            // Form initialization logic will be in Designer file
        }

        private void LoadTehnicarData()
        {
            if (tehnicar != null)
            {
                txtMBr.Text = tehnicar.MBr.ToString();
                txtPrezime.Text = tehnicar.Prezime;
                txtIme.Text = tehnicar.Ime;
                dtpDatumRodj.Value = tehnicar.DatumRodj;
                txtAdresa.Text = tehnicar.Adresa ?? string.Empty;
                txtTelefon.Text = tehnicar.Telefon ?? string.Empty;
                dtpDatumZaposlenja.Value = tehnicar.DatumZaposlenja;
                txtNivoObrazovanja.Text = tehnicar.NivoObrazovanja;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveTehnicar();
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

            if (string.IsNullOrWhiteSpace(txtNivoObrazovanja.Text))
            {
                MessageBox.Show("Nivo obrazovanja je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNivoObrazovanja.Focus();
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

        private void SaveTehnicar()
        {
            if (tehnicar == null)
            {
                tehnicar = new Tehnicar();
            }

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
