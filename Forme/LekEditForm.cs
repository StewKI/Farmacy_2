using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy_2.Forme
{
    public partial class LekEditForm : Form
    {
        private Lek lek;

        public LekEditForm(Lek lek)
        {
            InitializeComponent();
            this.lek = lek ?? throw new ArgumentNullException(nameof(lek));
            LoadLekData();
        }

        private void LoadLekData()
        {
            txtId.Text = lek.Id.ToString();
            txtHemijskiNaziv.Text = lek.HemijskiNaziv;
            txtKomercijalniNaziv.Text = lek.KomercijalniNaziv;
            txtDejstvo.Text = lek.Dejstvo ?? "";
            txtProizvodjac.Text = lek.Proizvodjac?.Id.ToString() ?? "Nije postavljen";
            txtPrimarnaGrupa.Text = lek.PrimarnaGrupa?.Id.ToString() ?? "Nije postavljen";
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtHemijskiNaziv.Text))
            {
                MessageBox.Show("Hemijski naziv je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHemijskiNaziv.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtKomercijalniNaziv.Text))
            {
                MessageBox.Show("Komercijalni naziv je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKomercijalniNaziv.Focus();
                return false;
            }

            return true;
        }

        private void SaveLek()
        {
            lek.HemijskiNaziv = txtHemijskiNaziv.Text.Trim();
            lek.KomercijalniNaziv = txtKomercijalniNaziv.Text.Trim();
            lek.Dejstvo = string.IsNullOrWhiteSpace(txtDejstvo.Text) ? null : txtDejstvo.Text.Trim();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveLek();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public Lek GetLek()
        {
            return lek;
        }
    }
}
