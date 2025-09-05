using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class PrimarnaGrupaForm : Form
    {
        private PrimarnaGrupaBasic primarnaGrupa;

        public PrimarnaGrupaForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public PrimarnaGrupaForm(PrimarnaGrupaBasic primarnaGrupa) : this()
        {
            this.primarnaGrupa = primarnaGrupa;
            LoadPrimarnaGrupaData();
        }

        private void InitializeForm()
        {
            // Form initialization logic will be in Designer file
        }

        private void LoadPrimarnaGrupaData()
        {
            if (primarnaGrupa != null)
            {
                txtId.Text = primarnaGrupa.Id.ToString();
                txtNaziv.Text = primarnaGrupa.Naziv;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SavePrimarnaGrupa();
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

        private void SavePrimarnaGrupa()
        {
            if (primarnaGrupa == null)
            {
                primarnaGrupa = new PrimarnaGrupaBasic();
            }

            primarnaGrupa.Naziv = txtNaziv.Text.Trim();

            DTOManagerLek.DodajPrimarnuGrupu(primarnaGrupa);
        }

        public PrimarnaGrupaBasic GetPrimarnaGrupa()
        {
            return primarnaGrupa;
        }
    }
}
