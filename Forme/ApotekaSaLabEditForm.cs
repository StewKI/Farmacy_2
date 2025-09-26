using System;
using System.Windows.Forms;
using Farmacy;
using Farmacy.Entiteti;

namespace Farmacy_2.Forme
{
    public partial class ApotekaSaLabEditForm : Form
    {
        private ApotekaSaLabBasic apotekaSaLab;

        public ApotekaSaLabEditForm(ApotekaSaLabBasic apotekaSaLab)
        {
            InitializeComponent();
            this.apotekaSaLab = apotekaSaLab ?? throw new ArgumentNullException(nameof(apotekaSaLab));
            LoadApotekaSaLabData();
            SetupButtonEffects();
        }

        private void LoadApotekaSaLabData()
        {
            // Load inherited properties from ProdajnaJedinica
            txtId.Text = apotekaSaLab.Id.ToString();
            txtNaziv.Text = apotekaSaLab.Naziv;
            txtUlica.Text = apotekaSaLab.Ulica;
            txtBroj.Text = apotekaSaLab.Broj;
            txtPostanskiBroj.Text = apotekaSaLab.PostanskiBroj;
            txtMesto.Text = apotekaSaLab.Mesto;
            //Stavljeno je da apotekar koj je izabran iz globalnog sistema bude odgovaran a ne koj raid ovde se bira od onih sto rade bas u toj prodajnoj jedinici
            var f = DTOManagerZaposleni.VratiOdgovornogFarmaceuta(apotekaSaLab.OdgovorniFarmaceut.Id);
            IList<Farmacy.FarmaceutBasic> lista = DTOManagerProdajneJedinice.VratiSveFarmaceuteZaApoteku(apotekaSaLab.Id) ?? new List<Farmacy.FarmaceutBasic>();
            var nazivi = lista.Select(l => new { Text = l.Ime, Value = l.Id}).ToList();
            var o = new { Text = f.Ime, Value = f.Id };
            if(nazivi.Count < 1 )
                nazivi.Add(o);
            comboBox1.DataSource = nazivi;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
            comboBox1.SelectedValue = apotekaSaLab.OdgovorniFarmaceut.Id;

            // Load ApotekaSaLab-specific properties
            txtNapomena.Text = apotekaSaLab.Napomena ?? "";
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

        private void SaveApotekaSaLab()
        {
            // Save inherited properties to ProdajnaJedinica
            apotekaSaLab.Naziv = txtNaziv.Text.Trim();
            apotekaSaLab.Ulica = txtUlica.Text.Trim();
            apotekaSaLab.Broj = txtBroj.Text.Trim();
            apotekaSaLab.PostanskiBroj = txtPostanskiBroj.Text.Trim();
            apotekaSaLab.Mesto = txtMesto.Text.Trim();
            apotekaSaLab.OdgovorniFarmaceut= DTOManagerZaposleni.VratiOdgovornogFarmaceuta((long)comboBox1.SelectedValue); ;
            // Save ApotekaSaLab-specific properties
            apotekaSaLab.Napomena = string.IsNullOrWhiteSpace(txtNapomena.Text) ? null : txtNapomena.Text.Trim();

            DTOManagerProdajneJedinice.IzmeniApoetkuSaLab(apotekaSaLab);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveApotekaSaLab();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public ApotekaSaLabBasic GetApotekaSaLab()
        {
            return apotekaSaLab;
        }

        private void ApotekaSaLabEditForm_Load(object sender, EventArgs e)
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
                    button.BackColor = Color.FromArgb(39, 174, 96);
                else if (button == btnCancel)
                    button.BackColor = Color.FromArgb(231, 76, 60);
            }
        }
    }
}
