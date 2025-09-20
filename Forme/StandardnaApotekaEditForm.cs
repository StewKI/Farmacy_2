using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class StandardnaApotekaEditForm : Form
    {
        private StandardnaApoteka standardnaApoteka;

        public StandardnaApotekaEditForm(StandardnaApoteka standardnaApoteka)
        {
            if (standardnaApoteka == null)
                throw new ArgumentNullException(nameof(standardnaApoteka));

            InitializeComponent();
            this.standardnaApoteka = standardnaApoteka;
            LoadStandardnaApotekaData();
            SetupButtonEffects();
        }

        private void LoadStandardnaApotekaData()
        {
            // Učitavamo postojeće podatke
            txtId.Text = standardnaApoteka.Id.ToString();
            txtNaziv.Text = standardnaApoteka.Naziv;
            txtUlica.Text = standardnaApoteka.Ulica;
            txtBroj.Text = standardnaApoteka.Broj;
            txtPostanskiBroj.Text = standardnaApoteka.PostanskiBroj;
            txtMesto.Text = standardnaApoteka.Mesto;
            var f = DTOManagerZaposleni.VratiOdgovornogFarmaceuta(standardnaApoteka.OdgovorniFarmaceut.MBr);
            IList<FarmaceutBasic> lista = DTOManagerProdajneJedinice.VratiSveFarmaceuteZaApoteku(standardnaApoteka.Id) ?? new List<FarmaceutBasic>();
            var nazivi = lista.Select(l => new { Text = l.Ime, Value = l.MBr }).ToList();
            var o = new { Text = f.Ime, Value = f.MBr };
            if (nazivi.Count < 1)
                nazivi.Add(o);
            comboBox1.DataSource = nazivi;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
            comboBox1.SelectedValue =standardnaApoteka.OdgovorniFarmaceut.MBr;

            

            if (!string.IsNullOrEmpty(standardnaApoteka.Napomena))
                txtNapomena.Text = standardnaApoteka.Napomena;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveStandardnaApoteka();
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
                txtNaziv.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUlica.Text))
            {
                MessageBox.Show("Ulica je obavezna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUlica.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBroj.Text))
            {
                MessageBox.Show("Broj je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBroj.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPostanskiBroj.Text))
            {
                MessageBox.Show("Poštanski broj je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPostanskiBroj.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMesto.Text))
            {
                MessageBox.Show("Mesto je obavezno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMesto.Focus();
                return false;
            }

            return true;
        }

        private void SaveStandardnaApoteka()
        {
            if (long.TryParse(txtId.Text, out long id))
                standardnaApoteka.Id = id;

            standardnaApoteka.Naziv = txtNaziv.Text.Trim();
            standardnaApoteka.Ulica = txtUlica.Text.Trim();
            standardnaApoteka.Broj = txtBroj.Text.Trim();
            standardnaApoteka.PostanskiBroj = txtPostanskiBroj.Text.Trim();
            standardnaApoteka.Mesto = txtMesto.Text.Trim();
            standardnaApoteka.Napomena = string.IsNullOrWhiteSpace(txtNapomena.Text) ? null : txtNapomena.Text.Trim();
            standardnaApoteka.OdgovorniFarmaceut= DTOManagerZaposleni.VratiOdgovornogFarmaceuta((long)comboBox1.SelectedValue);
            

            DTOManagerProdajneJedinice.IzmeniSApoetku(standardnaApoteka);
        }

        public StandardnaApoteka GetStandardnaApoteka()
        {
            return standardnaApoteka;
        }

        private void StandardnaApotekaEditForm_Load(object sender, EventArgs e)
        {

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
                    button.BackColor = Color.FromArgb(52, 152, 219);
                else if (button == btnCancel)
                    button.BackColor = Color.FromArgb(231, 76, 60);
            }
        }
    }
}
