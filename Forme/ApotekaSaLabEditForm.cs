using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy_2.Forme
{
    public partial class ApotekaSaLabEditForm : Form
    {
        private ApotekaSaLabBasic apotekaSaLab;

        public ApotekaSaLabEditForm(ApotekaSaLabBasic apotekaSaLab)
        {
            InitializeComponent();
            this.apotekaSaLab = apotekaSaLab ?? throw new ArgumentNullException(nameof(apotekaSaLab));
            LoadApotekaSaLabData();
        }

        private void LoadApotekaSaLabData()
        {
            // Load inherited properties from ProdajnaJedinica
            txtId.Text = apotekaSaLab.Id.ToString();
            txtNaziv.Text = apotekaSaLab.Naziv;
            txtUlica.Text = apotekaSaLab.Ulica;
            txtBroj.Text = apotekaSaLab.Broj;
            txtPostanskiBroj.Text = apotekaSaLab.PostanskiBroj;
            txtMesto.Text = apotekaSaLab.Mesto;
            txtOdgovorniFarmaceut.Text = apotekaSaLab.OdgovorniFarmaceut != null
    ? apotekaSaLab.OdgovorniFarmaceut.MBr.ToString()
    : "Nije postavljen";

            // Load ApotekaSaLab-specific properties
            txtNapomena.Text = apotekaSaLab.Napomena ?? "";
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

        private void SaveApotekaSaLab()
        {
            // Save inherited properties to ProdajnaJedinica
            apotekaSaLab.Naziv = txtNaziv.Text.Trim();
            apotekaSaLab.Ulica = txtUlica.Text.Trim();
            apotekaSaLab.Broj = txtBroj.Text.Trim();
            apotekaSaLab.PostanskiBroj = txtPostanskiBroj.Text.Trim();
            apotekaSaLab.Mesto = txtMesto.Text.Trim();
            
            // Save ApotekaSaLab-specific properties
            apotekaSaLab.Napomena = string.IsNullOrWhiteSpace(txtNapomena.Text) ? null : txtNapomena.Text.Trim();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveApotekaSaLab();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public ApotekaSaLabBasic GetApotekaSaLab()
        {
            return apotekaSaLab;
        }
    }
}
