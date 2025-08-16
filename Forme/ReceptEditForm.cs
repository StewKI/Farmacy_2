using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class ReceptEditForm : Form
    {
        private Recept recept;

        public ReceptEditForm(Recept recept)
        {
            if (recept == null)
                throw new ArgumentNullException(nameof(recept));

            InitializeComponent();
            this.recept = recept;
            LoadReceptData();
        }

        private void LoadReceptData()
        {
            // Učitavamo postojeće podatke
            txtSerijskiBroj.Text = recept.SerijskiBroj;
            txtSifraLekara.Text = recept.SifraLekara;
            dtpDatumIzd.Value = recept.DatumIzd;
            
            if (!string.IsNullOrEmpty(recept.Status))
                cmbStatus.Text = recept.Status;
            
            if (!string.IsNullOrEmpty(recept.NazivUstanove))
                txtNazivUstanove.Text = recept.NazivUstanove;
            
            if (recept.RealizovanaProdajnaJedinica != null)
                txtRealizovanaProdajnaJedinica.Text = recept.RealizovanaProdajnaJedinica.Id.ToString();
            
            if (recept.RealizacijaDatum.HasValue)
                dtpRealizacijaDatum.Value = recept.RealizacijaDatum.Value;
            
            if (recept.RealizovaoFarmaceut != null)
                txtRealizovaoFarmaceut.Text = recept.RealizovaoFarmaceut.MBr.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveRecept();
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
            if (string.IsNullOrWhiteSpace(txtSerijskiBroj.Text))
            {
                MessageBox.Show("Serijski broj je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSerijskiBroj.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSifraLekara.Text))
            {
                MessageBox.Show("Šifra lekara je obavezna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSifraLekara.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbStatus.Text))
            {
                MessageBox.Show("Status je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbStatus.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNazivUstanove.Text))
            {
                MessageBox.Show("Naziv ustanove je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNazivUstanove.Focus();
                return false;
            }

            if (dtpDatumIzd.Value > DateTime.Now)
            {
                MessageBox.Show("Datum izdavanja ne može biti u budućnosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dtpRealizacijaDatum.Value > DateTime.Now)
            {
                MessageBox.Show("Datum realizacije ne može biti u budućnosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dtpRealizacijaDatum.Value < dtpDatumIzd.Value)
            {
                MessageBox.Show("Datum realizacije ne može biti pre datuma izdavanja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void SaveRecept()
        {
            recept.SerijskiBroj = txtSerijskiBroj.Text.Trim();
            recept.SifraLekara = txtSifraLekara.Text.Trim();
            recept.DatumIzd = dtpDatumIzd.Value;
            recept.Status = cmbStatus.Text;
            recept.NazivUstanove = txtNazivUstanove.Text.Trim();
            recept.RealizacijaDatum = dtpRealizacijaDatum.Value;
            
            // Napomena: RealizovanaProdajnaJedinica i RealizovaoFarmaceut treba postaviti spolja
        }

        public Recept GetRecept()
        {
            return recept;
        }
    }
}
