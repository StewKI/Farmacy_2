using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class ReceptStavkaEditForm : Form
    {
        private ReceptStavka receptStavka;

        public ReceptStavkaEditForm(ReceptStavka receptStavka)
        {
            if (receptStavka == null)
                throw new ArgumentNullException(nameof(receptStavka));

            InitializeComponent();
            this.receptStavka = receptStavka;
            LoadReceptStavkaData();
        }

        private void LoadReceptStavkaData()
        {
            // Učitavamo postojeće podatke
            if (receptStavka.Recept != null)
                txtRecept.Text = receptStavka.Recept.SerijskiBroj;
            
            if (receptStavka.Pakovanje != null)
                txtPakovanje.Text = receptStavka.Pakovanje.Id.ToString();
            
            numKolicina.Value = receptStavka.Kolicina;
            
            if (!string.IsNullOrEmpty(receptStavka.PreporucenaDoza))
                txtPreporucenaDoza.Text = receptStavka.PreporucenaDoza;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveReceptStavka();
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
            if (numKolicina.Value <= 0)
            {
                MessageBox.Show("Količina mora biti veća od 0!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numKolicina.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPreporucenaDoza.Text))
            {
                MessageBox.Show("Preporučena doza je obavezna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPreporucenaDoza.Focus();
                return false;
            }

            return true;
        }

        private void SaveReceptStavka()
        {
            receptStavka.Kolicina = (int)numKolicina.Value;
            receptStavka.PreporucenaDoza = txtPreporucenaDoza.Text.Trim();
            
            // Napomena: Recept i Pakovanje treba postaviti spolja
        }

        public ReceptStavka GetReceptStavka()
        {
            return receptStavka;
        }
    }
}
