using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class DistributerEditForm : Form
    {
        private DistributerBasic distributer;

        public DistributerEditForm(DistributerBasic distributer)
        {
            InitializeComponent();
            this.distributer = distributer;
            LoadDistributerData();
        }

        private void LoadDistributerData()
        {
            txtId.Text = distributer.Id.ToString();
            txtNaziv.Text = distributer.Naziv;
            txtKontakt.Text = distributer.Kontakt;
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

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                MessageBox.Show("Naziv je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtKontakt.Text))
            {
                MessageBox.Show("Kontakt je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void SaveDistributer()
        {
            distributer.Naziv = txtNaziv.Text.Trim();
            distributer.Kontakt = txtKontakt.Text.Trim();

            try
            {
                DTOManagerIsporukeZalihe.IzmeniDistributera(distributer);
                MessageBox.Show("Distributer je uspešno izmenjen!", "Uspešno", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri izmeni distributera:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DistributerBasic GetDistributer()
        {
            return distributer;
        }
    }
}