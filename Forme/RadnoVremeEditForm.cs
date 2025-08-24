using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class RadnoVremeEditForm : Form
    {
        private RadnoVreme radnoVreme;

        public RadnoVremeEditForm(RadnoVreme radnoVreme)
        {
            if (radnoVreme == null)
                throw new ArgumentNullException(nameof(radnoVreme));

            InitializeComponent();
            this.radnoVreme = radnoVreme;
            LoadRadnoVremeData();
        }

        private void LoadRadnoVremeData()
        {
            // Učitavamo postojeće podatke
            if (radnoVreme.ProdajnaJedinica != null)
                txtProdajnaJedinica.Text = radnoVreme.ProdajnaJedinica.Id.ToString();
            
            if (radnoVreme.Dan > 0)
                cmbDan.SelectedValue = radnoVreme.Dan;

            
                dtpVremeOd.Value = DateTime.Today.Add(radnoVreme.VremeOd);

            
                dtpVremeOd.Value = DateTime.Today.Add(radnoVreme.VremeOd);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveRadnoVreme();
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
            if (string.IsNullOrWhiteSpace(cmbDan.Text))
            {
                MessageBox.Show("Dan je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbDan.Focus();
                return false;
            }

            if (dtpVremeOd.Value >= dtpVremeDo.Value)
            {
                MessageBox.Show("Vreme od mora biti pre vremena do!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void SaveRadnoVreme()
        {
            radnoVreme.Dan = int.Parse(cmbDan.SelectedValue.ToString());
            radnoVreme.VremeOd = dtpVremeOd.Value.TimeOfDay;
            radnoVreme.VremeDo = dtpVremeDo.Value.TimeOfDay;

            // Napomena: ProdajnaJedinica treba postaviti spolja
        }

        public RadnoVreme GetRadnoVreme()
        {
            return radnoVreme;
        }
    }
}
