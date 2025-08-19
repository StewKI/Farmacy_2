using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class SpecijalizovanaApotekaEditForm : Form
    {
        private SpecijalizovanaApoteka specijalizovanaApoteka;

        public SpecijalizovanaApotekaEditForm(SpecijalizovanaApoteka specijalizovanaApoteka)
        {
            if (specijalizovanaApoteka == null)
                throw new ArgumentNullException(nameof(specijalizovanaApoteka));

            InitializeComponent();
            this.specijalizovanaApoteka = specijalizovanaApoteka;
            LoadSpecijalizovanaApotekaData();
        }

        private void LoadSpecijalizovanaApotekaData()
        {
            // Učitavamo postojeće podatke
            txtId.Text = specijalizovanaApoteka.Id.ToString();
            txtNaziv.Text = specijalizovanaApoteka.Naziv;
            txtUlica.Text = specijalizovanaApoteka.Ulica;
            txtBroj.Text = specijalizovanaApoteka.Broj;
            txtPostanskiBroj.Text = specijalizovanaApoteka.PostanskiBroj;
            txtMesto.Text = specijalizovanaApoteka.Mesto;
            
            if (specijalizovanaApoteka.OdgovorniFarmaceut != null)
                txtOdgovorniFarmaceut.Text = specijalizovanaApoteka.OdgovorniFarmaceut.MBr.ToString();
            
            if (!string.IsNullOrEmpty(specijalizovanaApoteka.SpecijalnostTipa))
                txtSpecijalnostTipa.Text = specijalizovanaApoteka.SpecijalnostTipa;
            
            if (!string.IsNullOrEmpty(specijalizovanaApoteka.Napomena))
                txtNapomena.Text = specijalizovanaApoteka.Napomena;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveSpecijalizovanaApoteka();
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
            if (long.TryParse(txtId.Text, out long id))
                specijalizovanaApoteka.Id = id;
            
            specijalizovanaApoteka.Naziv = txtNaziv.Text.Trim();
            specijalizovanaApoteka.Ulica = txtUlica.Text.Trim();
            specijalizovanaApoteka.Broj = txtBroj.Text.Trim();
            specijalizovanaApoteka.PostanskiBroj = txtPostanskiBroj.Text.Trim();
            specijalizovanaApoteka.Mesto = txtMesto.Text.Trim();
            specijalizovanaApoteka.SpecijalnostTipa = txtSpecijalnostTipa.Text.Trim();
            specijalizovanaApoteka.Napomena = string.IsNullOrWhiteSpace(txtNapomena.Text) ? null : txtNapomena.Text.Trim();
            specijalizovanaApoteka.OdgovorniFarmaceut = DTOManager.VratiOdgovornogFarmaceuta(long.Parse(txtOdgovorniFarmaceut.Text.Trim()));

            DTOManager.IzmeniSpecApoetku(specijalizovanaApoteka);
        }

        public SpecijalizovanaApoteka GetSpecijalizovanaApoteka()
        {
            return specijalizovanaApoteka;
        }
    }
}
