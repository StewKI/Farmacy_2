using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class ProizvodjacEditForm : Form
    {
        private Proizvodjac proizvodjac;

        public ProizvodjacEditForm(Proizvodjac proizvodjac)
        {
            if (proizvodjac == null)
                throw new ArgumentNullException(nameof(proizvodjac));

            InitializeComponent();
            this.proizvodjac = proizvodjac;
            LoadProizvodjacData();
        }

        private void LoadProizvodjacData()
        {
            // Učitavamo postojeće podatke
            txtId.Text = proizvodjac.Id.ToString();
            txtNaziv.Text = proizvodjac.Naziv;
            txtZemlja.Text = proizvodjac.Zemlja;
            
            if (!string.IsNullOrEmpty(proizvodjac.Telefon))
                txtTelefon.Text = proizvodjac.Telefon;
            
            if (!string.IsNullOrEmpty(proizvodjac.Email))
                txtEmail.Text = proizvodjac.Email;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveProizvodjac();
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
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                MessageBox.Show("Naziv je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNaziv.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtZemlja.Text))
            {
                MessageBox.Show("Zemlja je obavezna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtZemlja.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email adresa nije validna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void SaveProizvodjac()
        {
            if (long.TryParse(txtId.Text, out long id))
                proizvodjac.Id = id;
            
            proizvodjac.Naziv = txtNaziv.Text.Trim();
            proizvodjac.Zemlja = txtZemlja.Text.Trim();
            proizvodjac.Telefon = string.IsNullOrWhiteSpace(txtTelefon.Text) ? null : txtTelefon.Text.Trim();
            proizvodjac.Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim();
        }

        public Proizvodjac GetProizvodjac()
        {
            return proizvodjac;
        }
    }
}
