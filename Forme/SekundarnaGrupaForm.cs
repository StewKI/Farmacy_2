using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class SekundarnaGrupaForm : Form
    {
        private SekundarnaKategorija sekundarnaGrupa;

        public SekundarnaGrupaForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public SekundarnaGrupaForm(SekundarnaKategorija sekundarnaGrupa) : this()
        {
            this.sekundarnaGrupa = sekundarnaGrupa;
            LoadSekundarnaGrupaData();
        }

        private void InitializeForm()
        {
            // Form initialization logic will be in Designer file
        }

        private void LoadSekundarnaGrupaData()
        {
            if (sekundarnaGrupa != null)
            {
                txtId.Text = sekundarnaGrupa.Id.ToString();
                txtNaziv.Text = sekundarnaGrupa.Naziv;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveSekundarnaGrupa();
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

            return true;
        }

        private void SaveSekundarnaGrupa()
        {
            if (sekundarnaGrupa == null)
            {
                sekundarnaGrupa = new SekundarnaKategorija();
            }

            sekundarnaGrupa.Naziv = txtNaziv.Text.Trim();
        }

        public SekundarnaKategorija GetSekundarnaGrupa()
        {
            return sekundarnaGrupa;
        }
    }
}
