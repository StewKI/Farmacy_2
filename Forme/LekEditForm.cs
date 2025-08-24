using System;
using System.Windows.Forms;
using Farmacy;
using Farmacy.Entiteti;

namespace Farmacy_2.Forme
{
    public partial class LekEditForm : Form
    {
        private LekBasic lek;
        private IList<PrimarnaGrupaBasic> list;
        public LekEditForm(LekBasic lek)
        {
            InitializeComponent();
            this.lek = lek ?? throw new ArgumentNullException(nameof(lek));
            LoadLekData();
            LoadPrimarneGrupeAsync();
        }

        private void LoadLekData()
        {
            txtId.Text = lek.Id.ToString();
            txtHemijski.Text = lek.HemijskiNaziv;
            txtKomercijalni.Text = lek.KomercijalniNaziv;
            txtDejstvo.Text = lek.Dejstvo ?? "";
            txtProizvodjac.Text = lek.ProizvodjacId.ToString() ?? "Nije postavljen";

        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtHemijski.Text))
            {
                MessageBox.Show("Hemijski naziv je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHemijski.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtKomercijalni.Text))
            {
                MessageBox.Show("Komercijalni naziv je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKomercijalni.Focus();
                return false;
            }

            return true;
        }

        private void SaveLek()
        {
            if (lek == null)
            {
                lek = new LekBasic();
            }

            lek.HemijskiNaziv = txtHemijski.Text.Trim();
            lek.KomercijalniNaziv = txtKomercijalni.Text.Trim();
            lek.Dejstvo = string.IsNullOrWhiteSpace(txtDejstvo.Text) ? null : txtDejstvo.Text.Trim();
            lek.ProizvodjacId = long.Parse(txtProizvodjac.Text);

            string target = cmbPrimarnaGrupa.Text;

            //long id1= nadjiId(target);
            lek.PrimarnaGrupaId = list
                                .First(x => string.Equals(x.Naziv, target, StringComparison.OrdinalIgnoreCase))
                                   .Id;

            DTOManager.IzmeniLek(lek);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveLek();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public LekBasic GetLek()
        {
            return lek;
        }

        private async Task LoadPrimarneGrupeAsync()
        {
            try
            {
                list = DTOManager.VratiPrimarneGrupe() ?? new List<PrimarnaGrupaBasic>();



                cmbPrimarnaGrupa.Items.Clear();
                cmbPrimarnaGrupa.Items.AddRange(
                    list.Select(x => x.Naziv).OrderBy(n => n).ToArray()
                );
                cmbPrimarnaGrupa.SelectedIndex = 1;

                // čitanje

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju primarnih grupa: " + ex.Message);
            }
        }

        private void LekEditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
