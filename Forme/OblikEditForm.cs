using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class OblikEditForm : Form
    {
        private Oblik oblik;

        public OblikEditForm(Oblik oblik)
        {
            if (oblik == null)
                throw new ArgumentNullException(nameof(oblik));

            InitializeComponent();
            this.oblik = oblik;
            LoadOblikData();
        }

        private void LoadOblikData()
        {
            // Učitavamo postojeće podatke
            txtId.Text = oblik.Id.ToString();
            txtNaziv.Text = oblik.Naziv;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveOblik();
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
                return false;
            }

            return true;
        }

        private void SaveOblik()
        {
            if (long.TryParse(txtId.Text, out long id))
                oblik.Id = id;
            
            oblik.Naziv = txtNaziv.Text.Trim();
        }

        public Oblik GetOblik()
        {
            return oblik;
        }
    }
}
