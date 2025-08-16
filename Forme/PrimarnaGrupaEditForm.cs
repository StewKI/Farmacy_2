using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class PrimarnaGrupaEditForm : Form
    {
        private PrimarnaGrupa primarnaGrupa;

        public PrimarnaGrupaEditForm(PrimarnaGrupa primarnaGrupa)
        {
            if (primarnaGrupa == null)
                throw new ArgumentNullException(nameof(primarnaGrupa));

            InitializeComponent();
            this.primarnaGrupa = primarnaGrupa;
            LoadPrimarnaGrupaData();
        }

        private void LoadPrimarnaGrupaData()
        {
            // Učitavamo postojeće podatke
            txtId.Text = primarnaGrupa.Id.ToString();
            txtNaziv.Text = primarnaGrupa.Naziv;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SavePrimarnaGrupa();
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

        private void SavePrimarnaGrupa()
        {
            if (long.TryParse(txtId.Text, out long id))
                primarnaGrupa.Id = id;
            
            primarnaGrupa.Naziv = txtNaziv.Text.Trim();
        }

        public PrimarnaGrupa GetPrimarnaGrupa()
        {
            return primarnaGrupa;
        }
    }
}
