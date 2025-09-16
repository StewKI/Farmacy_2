using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class RadnoVremeEditForm : Form
    {
        private RadnoVremeBasic radnoVreme;

        public RadnoVremeEditForm(RadnoVremeBasic radnoVreme)
        {
            InitializeComponent();
            this.radnoVreme = radnoVreme;
            LoadRadnoVremeData();
        }

        private void LoadRadnoVremeData()
        {
            if (radnoVreme != null)
            {
                txtProdajnaJedinica.Text = radnoVreme.ProdajnaJedinicaNaziv;
                cboDan.SelectedIndex = radnoVreme.Dan - 1; // Dan je 1-7, indeks je 0-6
                
                // Proveri da li postoje vrednosti za radno vreme
                if (radnoVreme.VremeOd.HasValue)
                    dtpVremeOd.Value = DateTime.Today.Add(radnoVreme.VremeOd.Value);
                else
                    dtpVremeOd.Value = DateTime.Today.Add(new TimeSpan(8, 0, 0)); // Default 08:00
                    
                if (radnoVreme.VremeDo.HasValue)
                    dtpVremeDo.Value = DateTime.Today.Add(radnoVreme.VremeDo.Value);
                else
                    dtpVremeDo.Value = DateTime.Today.Add(new TimeSpan(16, 0, 0)); // Default 16:00
            }
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
            if (radnoVreme != null)
            {
                radnoVreme.Dan = cboDan.SelectedIndex + 1; // Indeks je 0-6, Dan je 1-7
                radnoVreme.VremeOd = dtpVremeOd.Value.TimeOfDay;
                radnoVreme.VremeDo = dtpVremeDo.Value.TimeOfDay;
                
                // Proveri da li postoje radna vremena
                if (radnoVreme.VremeOd.HasValue && radnoVreme.VremeDo.HasValue)
                {
                    DTOManagerProdajneJedinice.IzmeniRadnoVreme(radnoVreme);
                }
                else
                {
                    // Ako nema radnog vremena, obriši postojeći zapis
                    DTOManagerProdajneJedinice.ObrisiRadnoVreme(radnoVreme.ProdajnaJedinicaId, radnoVreme.Dan);
                }
            }
        }

        public RadnoVremeBasic GetRadnoVreme()
        {
            return radnoVreme;
        }
    }
}