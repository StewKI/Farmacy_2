using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class SpecijalizovanaApotekaForm : Form
    {
        private SpecijalizovanaApoteka specijalizovanaApoteka;

        public SpecijalizovanaApotekaForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public SpecijalizovanaApotekaForm(SpecijalizovanaApoteka specijalizovanaApoteka) : this()
        {
            this.specijalizovanaApoteka = specijalizovanaApoteka;
            LoadSpecijalizovanaApotekaData();
        }

        private void InitializeForm()
        {
            // Form initialization logic will be in Designer file
        }

        private void LoadSpecijalizovanaApotekaData()
        {
            if (specijalizovanaApoteka != null)
            {
                txtId.Text = specijalizovanaApoteka.Id.ToString();
                txtNaziv.Text = specijalizovanaApoteka.Naziv;
                txtUlica.Text = specijalizovanaApoteka.Ulica;
                txtBroj.Text = specijalizovanaApoteka.Broj;
                txtPostanskiBroj.Text = specijalizovanaApoteka.PostanskiBroj;
                txtMesto.Text = specijalizovanaApoteka.Mesto;
                txtSpecijalnostTipa.Text = specijalizovanaApoteka.SpecijalnostTipa ?? string.Empty;
                txtNapomena.Text = specijalizovanaApoteka.Napomena ?? string.Empty;

                if (specijalizovanaApoteka.OdgovorniFarmaceut != null)
                    txtOdgovorniFarmaceut.Text = specijalizovanaApoteka.OdgovorniFarmaceut.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveSpecijalizovanaApoteka();
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

            if (string.IsNullOrWhiteSpace(txtSpecijalnostTipa.Text))
            {
                MessageBox.Show("Specijalnost tipa je obavezna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSpecijalnostTipa.Focus();
                return false;
            }

            return true;
        }

        private void SaveSpecijalizovanaApoteka()
        {
            if (specijalizovanaApoteka == null)
            {
                specijalizovanaApoteka = new SpecijalizovanaApoteka();
            }

            specijalizovanaApoteka.Naziv = txtNaziv.Text.Trim();
            specijalizovanaApoteka.Ulica = txtUlica.Text.Trim();
            specijalizovanaApoteka.Broj = txtBroj.Text.Trim();
            specijalizovanaApoteka.PostanskiBroj = txtPostanskiBroj.Text.Trim();
            specijalizovanaApoteka.Mesto = txtMesto.Text.Trim();
            specijalizovanaApoteka.SpecijalnostTipa = txtSpecijalnostTipa.Text.Trim();
            specijalizovanaApoteka.Napomena = string.IsNullOrWhiteSpace(txtNapomena.Text) ? null : txtNapomena.Text.Trim();
            specijalizovanaApoteka.OdgovorniFarmaceut = DTOManager.VratiOdgovornogFarmaceuta(long.Parse(txtOdgovorniFarmaceut.Text.Trim()));

            DTOManager.DodajSpecApoteku(specijalizovanaApoteka);
        }

        public SpecijalizovanaApoteka GetSpecijalizovanaApoteka()
        {
            return specijalizovanaApoteka;
        }

        private void SpecijalizovanaApotekaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
