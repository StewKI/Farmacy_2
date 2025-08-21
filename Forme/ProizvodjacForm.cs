using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class ProizvodjacForm : Form
    {
        private ProizvodjacBasic proizvodjac;

        public ProizvodjacForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public ProizvodjacForm(ProizvodjacBasic proizvodjac) : this()
        {
            this.proizvodjac = proizvodjac;
            LoadProizvodjacData();
        }

        private void InitializeForm()
        {
            // Form initialization logic will be in Designer file
        }

        private void LoadProizvodjacData()
        {
            if (proizvodjac != null)
            {
                txtId.Text = proizvodjac.Id.ToString();
                txtNaziv.Text = proizvodjac.Naziv;
                txtZemlja.Text = proizvodjac.Zemlja;
                txtTelefon.Text = proizvodjac.Telefon ?? string.Empty;
                txtEmail.Text = proizvodjac.Email ?? string.Empty;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveProizvodjac();
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
            if (proizvodjac == null)
            {
                proizvodjac = new ProizvodjacBasic();
            }

            proizvodjac.Naziv = txtNaziv.Text.Trim();
            proizvodjac.Zemlja = txtZemlja.Text.Trim();
            proizvodjac.Telefon = string.IsNullOrWhiteSpace(txtTelefon.Text) ? null : txtTelefon.Text.Trim();
            proizvodjac.Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim();

            DTOManager.DodajProizvodjaca(proizvodjac);
        }

        public ProizvodjacBasic GetProizvodjac()
        {
            return proizvodjac;
        }
    }
}
