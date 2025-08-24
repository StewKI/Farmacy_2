using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy_2.Forme
{
    public partial class DistributerEditForm : Form
    {
        private Distributer distributer;

        public DistributerEditForm(Distributer distributer)
        {
            InitializeComponent();
            this.distributer = distributer ?? throw new ArgumentNullException(nameof(distributer));
            LoadDistributerData();
        }

        private void LoadDistributerData()
        {
            txtId.Text = distributer.Id.ToString();
            txtNaziv.Text = distributer.Naziv;
            txtKontakt.Text = distributer.Kontakt ?? "";
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

        private void SaveDistributer()
        {
            distributer.Naziv = txtNaziv.Text.Trim();
            distributer.Kontakt = string.IsNullOrWhiteSpace(txtKontakt.Text) ? null : txtKontakt.Text.Trim();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveDistributer();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public Distributer GetDistributer()
        {
            return distributer;
        }
    }
}
