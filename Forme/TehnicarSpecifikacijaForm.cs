using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class TehnicarSpecifikacijaForm : Form
    {
        private TehnicarSertifikacija tehnicarSertifikacija;

        public TehnicarSpecifikacijaForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public TehnicarSpecifikacijaForm(TehnicarSertifikacija tehnicarSertifikacija) : this()
        {
            this.tehnicarSertifikacija = tehnicarSertifikacija;
            LoadTehnicarSertifikacijaData();
        }

        private void InitializeForm()
        {
            // Form initialization logic will be in Designer file
        }

        private void LoadTehnicarSertifikacijaData()
        {
            if (tehnicarSertifikacija != null)
            {
                if (tehnicarSertifikacija.Tehnicar != null)
                    txtTehnicar.Text = tehnicarSertifikacija.Tehnicar.ToString();
                txtNaziv.Text = tehnicarSertifikacija.Naziv;
                dtpDatum.Value = tehnicarSertifikacija.Datum;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveTehnicarSertifikacija();
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

            if (dtpDatum.Value > DateTime.Now)
            {
                MessageBox.Show("Datum ne može biti u budućnosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDatum.Focus();
                return false;
            }

            return true;
        }

        private void SaveTehnicarSertifikacija()
        {
            if (tehnicarSertifikacija == null)
            {
                tehnicarSertifikacija = new TehnicarSertifikacija();
            }

            tehnicarSertifikacija.Naziv = txtNaziv.Text.Trim();
            tehnicarSertifikacija.Datum = dtpDatum.Value;
        }

        public TehnicarSertifikacija GetTehnicarSertifikacija()
        {
            return tehnicarSertifikacija;
        }
    }
}
