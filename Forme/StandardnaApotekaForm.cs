using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class StandardnaApotekaForm : Form
    {
        private StandardnaApoteka standardnaApoteka;

        public StandardnaApotekaForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public StandardnaApotekaForm(StandardnaApoteka standardnaApoteka) : this()
        {
            this.standardnaApoteka = standardnaApoteka;
            LoadStandardnaApotekaData();
        }

        private void InitializeForm()
        {
            // Form initialization logic will be in Designer file
        }

        private void LoadStandardnaApotekaData()
        {
            if (standardnaApoteka != null)
            {
                txtId.Text = standardnaApoteka.Id.ToString();
                txtNaziv.Text = standardnaApoteka.Naziv;
                txtUlica.Text = standardnaApoteka.Ulica;
                txtBroj.Text = standardnaApoteka.Broj;
                txtPostanskiBroj.Text = standardnaApoteka.PostanskiBroj;
                txtMesto.Text = standardnaApoteka.Mesto;
                txtNapomena.Text = standardnaApoteka.Napomena ?? string.Empty;
                
                if (standardnaApoteka.OdgovorniFarmaceut != null)
                    txtOdgovorniFarmaceut.Text = standardnaApoteka.OdgovorniFarmaceut.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveStandardnaApoteka();
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

            if (string.IsNullOrWhiteSpace(txtUlica.Text))
            {
                MessageBox.Show("Ulica je obavezna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUlica.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBroj.Text))
            {
                MessageBox.Show("Broj je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBroj.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPostanskiBroj.Text))
            {
                MessageBox.Show("Poštanski broj je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPostanskiBroj.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMesto.Text))
            {
                MessageBox.Show("Mesto je obavezno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMesto.Focus();
                return false;
            }

            return true;
        }

        private void SaveStandardnaApoteka()
        {
            if (standardnaApoteka == null)
            {
                standardnaApoteka = new StandardnaApoteka();
            }

            standardnaApoteka.Naziv = txtNaziv.Text.Trim();
            standardnaApoteka.Ulica = txtUlica.Text.Trim();
            standardnaApoteka.Broj = txtBroj.Text.Trim();
            standardnaApoteka.PostanskiBroj = txtPostanskiBroj.Text.Trim();
            standardnaApoteka.Mesto = txtMesto.Text.Trim();
            standardnaApoteka.Napomena = string.IsNullOrWhiteSpace(txtNapomena.Text) ? null : txtNapomena.Text.Trim();
        }

        public StandardnaApoteka GetStandardnaApoteka()
        {
            return standardnaApoteka;
        }
    }
}
