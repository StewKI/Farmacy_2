using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class TehnicarSpecifikacijaEditForm : Form
    {
        private TehnicarSertifikacija tehnicarSpecifikacija;

        public TehnicarSpecifikacijaEditForm(TehnicarSertifikacija tehnicarSpecifikacija)
        {
            if (tehnicarSpecifikacija == null)
                throw new ArgumentNullException(nameof(tehnicarSpecifikacija));

            InitializeComponent();
            this.tehnicarSpecifikacija = tehnicarSpecifikacija;
            LoadTehnicarSpecifikacijaData();
        }

        private void LoadTehnicarSpecifikacijaData()
        {
            // Učitavamo postojeće podatke
            if (tehnicarSpecifikacija.Tehnicar != null)
                txtTehnicar.Text = tehnicarSpecifikacija.Tehnicar.MBr.ToString();
            
            if (!string.IsNullOrEmpty(tehnicarSpecifikacija.Naziv))
                txtNaziv.Text = tehnicarSpecifikacija.Naziv;
            
            
                dtpDatum.Value = tehnicarSpecifikacija.Datum;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveTehnicarSpecifikacija();
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

            if (dtpDatum.Value > DateTime.Now)
            {
                MessageBox.Show("Datum ne može biti u budućnosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void SaveTehnicarSpecifikacija()
        {
            tehnicarSpecifikacija.Naziv = txtNaziv.Text.Trim();
            tehnicarSpecifikacija.Datum = dtpDatum.Value;
            
            // Napomena: Tehnicar treba postaviti spolja
        }

        public TehnicarSertifikacija GetTehnicarSpecifikacija()
        {
            return tehnicarSpecifikacija;
        }
    }
}
