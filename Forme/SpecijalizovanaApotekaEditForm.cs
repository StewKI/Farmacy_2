using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class SpecijalizovanaApotekaEditForm : Form
    {
        private SpecijalizovanaApoteka specijalizovanaApoteka;

        public SpecijalizovanaApotekaEditForm(SpecijalizovanaApoteka specijalizovanaApoteka)
        {
            if (specijalizovanaApoteka == null)
                throw new ArgumentNullException(nameof(specijalizovanaApoteka));

            InitializeComponent();
            this.specijalizovanaApoteka = specijalizovanaApoteka;
            LoadSpecijalizovanaApotekaData();
            SetupButtonEffects();
        }

        private void LoadSpecijalizovanaApotekaData()
        {
            // Učitavamo postojeće podatke
            txtId.Text = specijalizovanaApoteka.Id.ToString();
            txtNaziv.Text = specijalizovanaApoteka.Naziv;
            txtUlica.Text = specijalizovanaApoteka.Ulica;
            txtBroj.Text = specijalizovanaApoteka.Broj;
            txtPostanskiBroj.Text = specijalizovanaApoteka.PostanskiBroj;
            txtMesto.Text = specijalizovanaApoteka.Mesto;

            //Stavljeno je da apotekar koj je izabran iz globalnog sistema bude odgovaran a ne koj raid ovde se bira od onih sto rade bas u toj prodajnoj jedinici
            var f = DTOManagerZaposleni.VratiOdgovornogFarmaceuta(specijalizovanaApoteka.OdgovorniFarmaceut.MBr);
            IList<FarmaceutBasic> lista = DTOManagerProdajneJedinice.VratiSveFarmaceuteZaApoteku(specijalizovanaApoteka.Id) ?? new List<FarmaceutBasic>();
            var nazivi = lista.Select(l => new { Text = l.Ime, Value = l.MBr }).ToList();
            var o = new { Text = f.Ime, Value = f.MBr };
            if (nazivi.Count < 1)
                nazivi.Add(o);
            comboBox1.DataSource = nazivi;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
            comboBox1.SelectedValue = specijalizovanaApoteka.OdgovorniFarmaceut.MBr;

            if (!string.IsNullOrEmpty(specijalizovanaApoteka.SpecijalnostTipa))
                txtSpecijalnostTipa.Text = specijalizovanaApoteka.SpecijalnostTipa;
            
            if (!string.IsNullOrEmpty(specijalizovanaApoteka.Napomena))
                txtNapomena.Text = specijalizovanaApoteka.Napomena;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveSpecijalizovanaApoteka();
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

            if (string.IsNullOrWhiteSpace(txtSpecijalnostTipa.Text))
            {
                MessageBox.Show("Specijalnost tipa je obavezna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSpecijalnostTipa.Focus();
                return false;
            }

            return true;
        }

        private void SaveSpecijalizovanaApoteka()
        {
            if (long.TryParse(txtId.Text, out long id))
                specijalizovanaApoteka.Id = id;
            
            specijalizovanaApoteka.Naziv = txtNaziv.Text.Trim();
            specijalizovanaApoteka.Ulica = txtUlica.Text.Trim();
            specijalizovanaApoteka.Broj = txtBroj.Text.Trim();
            specijalizovanaApoteka.PostanskiBroj = txtPostanskiBroj.Text.Trim();
            specijalizovanaApoteka.Mesto = txtMesto.Text.Trim();
            specijalizovanaApoteka.SpecijalnostTipa = txtSpecijalnostTipa.Text.Trim();
            specijalizovanaApoteka.Napomena = string.IsNullOrWhiteSpace(txtNapomena.Text) ? null : txtNapomena.Text.Trim();
            specijalizovanaApoteka.OdgovorniFarmaceut = DTOManagerZaposleni.VratiOdgovornogFarmaceuta((long)comboBox1.SelectedValue);

            DTOManagerProdajneJedinice.IzmeniSpecApoetku(specijalizovanaApoteka);
        }

        public SpecijalizovanaApoteka GetSpecijalizovanaApoteka()
        {
            return specijalizovanaApoteka;
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
                    button.BackColor = Color.FromArgb(155, 89, 182);
                else if (button == btnCancel)
                    button.BackColor = Color.FromArgb(231, 76, 60);
            }
        }
    }
}
