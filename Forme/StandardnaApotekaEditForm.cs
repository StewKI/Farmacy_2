using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class StandardnaApotekaEditForm : Form
    {
        private StandardnaApoteka standardnaApoteka;

        public StandardnaApotekaEditForm(StandardnaApoteka standardnaApoteka)
        {
            if (standardnaApoteka == null)
                throw new ArgumentNullException(nameof(standardnaApoteka));

            InitializeComponent();
            this.standardnaApoteka = standardnaApoteka;
            LoadStandardnaApotekaData();
        }

        private void LoadStandardnaApotekaData()
        {
            // Učitavamo postojeće podatke
            txtId.Text = standardnaApoteka.Id.ToString();
            txtNaziv.Text = standardnaApoteka.Naziv;
            txtUlica.Text = standardnaApoteka.Ulica;
            txtBroj.Text = standardnaApoteka.Broj;
            txtPostanskiBroj.Text = standardnaApoteka.PostanskiBroj;
            txtMesto.Text = standardnaApoteka.Mesto;

            if (standardnaApoteka.OdgovorniFarmaceut != null)
                txtOdgovorniFarmaceut.Text = standardnaApoteka.OdgovorniFarmaceut.MBr.ToString();

            if (!string.IsNullOrEmpty(standardnaApoteka.Napomena))
                txtNapomena.Text = standardnaApoteka.Napomena;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveStandardnaApoteka();
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
            if (long.TryParse(txtId.Text, out long id))
                standardnaApoteka.Id = id;

            standardnaApoteka.Naziv = txtNaziv.Text.Trim();
            standardnaApoteka.Ulica = txtUlica.Text.Trim();
            standardnaApoteka.Broj = txtBroj.Text.Trim();
            standardnaApoteka.PostanskiBroj = txtPostanskiBroj.Text.Trim();
            standardnaApoteka.Mesto = txtMesto.Text.Trim();
            standardnaApoteka.Napomena = string.IsNullOrWhiteSpace(txtNapomena.Text) ? null : txtNapomena.Text.Trim();
            standardnaApoteka.OdgovorniFarmaceut= DTOManager.VratiOdgovornogFarmaceuta(long.Parse(txtOdgovorniFarmaceut.Text.Trim()));
            // Napomena: OdgovorniFarmaceut treba postaviti spolja

            DTOManager.IzmeniSApoetku(standardnaApoteka);
        }

        public StandardnaApoteka GetStandardnaApoteka()
        {
            return standardnaApoteka;
        }

        private void StandardnaApotekaEditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
