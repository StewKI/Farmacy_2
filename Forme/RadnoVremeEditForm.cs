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
            SetupButtonEffects();
        }

        private void LoadRadnoVremeData()
        {
            if (radnoVreme != null)
            {
                LoadDani(); // Učitaj dane pre postavljanja SelectedIndex
                txtProdajnaJedinica.Text = radnoVreme.ProdajnaJedinicaNaziv;
                cboDan.SelectedIndex = radnoVreme.Dan - 1; // Dan je 1-7, indeks je 0-6
                
                // Proveri da li postoje vrednosti za radno vreme
                if (radnoVreme.VremeOd.HasValue && radnoVreme.VremeOd.Value != DateTime.MinValue)
                    dtpVremeOd.Value = radnoVreme.VremeOd.Value;
                else
                    dtpVremeOd.Value = DateTime.Today.Add(new TimeSpan(8, 0, 0)); // Default 08:00
                    
                if (radnoVreme.VremeDo.HasValue && radnoVreme.VremeDo.Value != DateTime.MinValue)
                    dtpVremeDo.Value = radnoVreme.VremeDo.Value;
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
                radnoVreme.VremeOd = dtpVremeOd.Value;
                radnoVreme.VremeDo = dtpVremeDo.Value;
                
                // Uvek pozovi IzmeniRadnoVreme - metoda će proveriti da li postoje vrednosti
                try
                {
                    DTOManagerProdajneJedinice.IzmeniRadnoVreme(radnoVreme);
                    MessageBox.Show("Radno vreme je uspešno sačuvano!", "Uspeh", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Greška pri čuvanju radnog vremena: {ex.Message}", "Greška", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public RadnoVremeBasic GetRadnoVreme()
        {
            return radnoVreme;
        }

        private void SetupButtonEffects()
        {
            // Add hover effects to all buttons
            btnSave.MouseEnter += Button_MouseEnter;
            btnSave.MouseLeave += Button_MouseLeave;
            btnCancel.MouseEnter += Button_MouseEnter;
            btnCancel.MouseLeave += Button_MouseLeave;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                // Store original color and make button lighter
                button.BackColor = Color.FromArgb(
                    Math.Min(255, button.BackColor.R + 30),
                    Math.Min(255, button.BackColor.G + 30),
                    Math.Min(255, button.BackColor.B + 30)
                );
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                // Restore original color
                if (button == btnSave)
                    button.BackColor = Color.FromArgb(46, 204, 113);
                else if (button == btnCancel)
                    button.BackColor = Color.FromArgb(231, 76, 60);
            }
        }
    }
}