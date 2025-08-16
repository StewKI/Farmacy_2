using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class LekForm : Form
    {
        private Lek lek;

        public LekForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public LekForm(Lek lek) : this()
        {
            this.lek = lek;
            LoadLekData();
        }

        private void InitializeForm()
        {
            // Form initialization logic will be in Designer file
        }

        private void LoadLekData()
        {
            if (lek != null)
            {
                txtId.Text = lek.Id.ToString();
                txtHemijskiNaziv.Text = lek.HemijskiNaziv;
                txtKomercijalniNaziv.Text = lek.KomercijalniNaziv;
                txtDejstvo.Text = lek.Dejstvo ?? string.Empty;
                
                if (lek.Proizvodjac != null)
                    txtProizvodjac.Text = lek.Proizvodjac.ToString();
                if (lek.PrimarnaGrupa != null)
                    txtPrimarnaGrupa.Text = lek.PrimarnaGrupa.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveLek();
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
            if (lek == null)
            {
                lek = new Lek();
            }

            lek.HemijskiNaziv = txtHemijskiNaziv.Text.Trim();
            lek.KomercijalniNaziv = txtKomercijalniNaziv.Text.Trim();
            lek.Dejstvo = string.IsNullOrWhiteSpace(txtDejstvo.Text) ? null : txtDejstvo.Text.Trim();
        }

        public Lek GetLek()
        {
            return lek;
        }
    }
}
