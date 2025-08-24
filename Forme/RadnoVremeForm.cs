using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class RadnoVremeForm : Form
    {
        private RadnoVreme radnoVreme;

        public RadnoVremeForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public RadnoVremeForm(RadnoVreme radnoVreme) : this()
        {
            this.radnoVreme = radnoVreme;
            LoadRadnoVremeData();
        }

        private void InitializeForm()
        {
            // Form initialization logic will be in Designer file
            LoadDani();
        }

        private void LoadDani()
        {
            cboDan.Items.Clear();
            cboDan.Items.Add("Ponedeljak");
            cboDan.Items.Add("Utorak");
            cboDan.Items.Add("Sreda");
            cboDan.Items.Add("Četvrtak");
            cboDan.Items.Add("Petak");
            cboDan.Items.Add("Subota");
            cboDan.Items.Add("Nedelja");
        }

        private void LoadRadnoVremeData()
        {
            if (radnoVreme != null)
            {
                if (radnoVreme.ProdajnaJedinica != null)
                    txtProdajnaJedinica.Text = radnoVreme.ProdajnaJedinica.ToString();
                
                cboDan.SelectedIndex = radnoVreme.Dan - 1; // Dan je 1-7, indeks je 0-6
                dtpVremeOd.Value = DateTime.Today.Add(radnoVreme.VremeOd);
                dtpVremeDo.Value = DateTime.Today.Add(radnoVreme.VremeDo);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveRadnoVreme();
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
            if (cboDan.SelectedIndex == -1)
            {
                MessageBox.Show("Dan je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDan.Focus();
                return false;
            }

            TimeSpan vremeOd = dtpVremeOd.Value.TimeOfDay;
            TimeSpan vremeDo = dtpVremeDo.Value.TimeOfDay;

            if (vremeOd >= vremeDo)
            {
                MessageBox.Show("Vreme od mora biti manje od vremena do!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpVremeOd.Focus();
                return false;
            }

            return true;
        }

        private void SaveRadnoVreme()
        {
            if (radnoVreme == null)
            {
                radnoVreme = new RadnoVreme();
            }

            radnoVreme.Dan = cboDan.SelectedIndex + 1; // Indeks je 0-6, Dan je 1-7
            radnoVreme.VremeOd = dtpVremeOd.Value.TimeOfDay;
            radnoVreme.VremeDo = dtpVremeDo.Value.TimeOfDay;
        }

        public RadnoVreme GetRadnoVreme()
        {
            return radnoVreme;
        }
    }
}
