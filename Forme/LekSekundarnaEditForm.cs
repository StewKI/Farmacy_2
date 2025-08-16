using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class LekSekundarnaEditForm : Form
    {
        private LekSekundarna lekSekundarna;

        public LekSekundarnaEditForm(LekSekundarna lekSekundarna)
        {
            if (lekSekundarna == null)
                throw new ArgumentNullException(nameof(lekSekundarna));

            InitializeComponent();
            this.lekSekundarna = lekSekundarna;
            LoadLekSekundarnaData();
        }

        private void LoadLekSekundarnaData()
        {
            // Učitavamo postojeće podatke
            if (lekSekundarna.Lek != null)
                txtLekId.Text = lekSekundarna.Lek.Id.ToString();
            
            if (lekSekundarna.Kategorija != null)
                txtKategorijaId.Text = lekSekundarna.Kategorija.Id.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveLekSekundarna();
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
            if (string.IsNullOrWhiteSpace(txtLekId.Text))
            {
                MessageBox.Show("ID leka je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtKategorijaId.Text))
            {
                MessageBox.Show("ID kategorije je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void SaveLekSekundarna()
        {
            // Napomena: Referentne entitete (Lek, Kategorija) treba postaviti spolja
            // jer ova forma samo prikazuje ID-ove
        }

        public LekSekundarna GetLekSekundarna()
        {
            return lekSekundarna;
        }
    }
}
