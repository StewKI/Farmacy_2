using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class SekundarnaGrupaEditForm : Form
    {
        private SekundarnaKategorija sekundarnaGrupa;

        public SekundarnaGrupaEditForm(SekundarnaKategorija sekundarnaGrupa)
        {
            if (sekundarnaGrupa == null)
                throw new ArgumentNullException(nameof(sekundarnaGrupa));

            InitializeComponent();
            this.sekundarnaGrupa = sekundarnaGrupa;
            LoadSekundarnaGrupaData();
        }

        private void LoadSekundarnaGrupaData()
        {
            // Učitavamo postojeće podatke
            txtId.Text = sekundarnaGrupa.Id.ToString();
            txtNaziv.Text = sekundarnaGrupa.Naziv;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveSekundarnaGrupa();
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

            return true;
        }

        private void SaveSekundarnaGrupa()
        {
            if (long.TryParse(txtId.Text, out long id))
                sekundarnaGrupa.Id = id;
            
            sekundarnaGrupa.Naziv = txtNaziv.Text.Trim();
        }

        public SekundarnaKategorija GetSekundarnaGrupa()
        {
            return sekundarnaGrupa;
        }
    }
}
