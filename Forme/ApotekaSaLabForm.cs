using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class ApotekaSaLabForm : Form
    {
        private ApotekaSaLabBasic apotekaSaLab;

        public ApotekaSaLabForm()
        {
            InitializeComponent();
            InitializeForm();
            SetupButtonEffects();
        }

        public ApotekaSaLabForm(ApotekaSaLabBasic apotekaSaLab) : this()
        {
            this.apotekaSaLab = apotekaSaLab;
            LoadApotekaSaLabData();
        }

        private void InitializeForm()
        {
            IList<FarmaceutBasic> lista = DTOManagerProdajneJedinice.VratiSveFarmaceuteUSistemu() ?? new List<FarmaceutBasic>();
            var nazivi = lista.Select(l => new { Text = l.Ime, Value = l.MBr }).ToList();
            comboBox1.DataSource = nazivi;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
        }

        private void LoadApotekaSaLabData()
        {
            if (apotekaSaLab != null)
            {
                txtId.Text = apotekaSaLab.Id.ToString();
                txtNaziv.Text = apotekaSaLab.Naziv;
                txtUlica.Text = apotekaSaLab.Ulica;
                txtBroj.Text = apotekaSaLab.Broj;
                txtPostanskiBroj.Text = apotekaSaLab.PostanskiBroj;
                txtMesto.Text = apotekaSaLab.Mesto;
                txtNapomena.Text = apotekaSaLab.Napomena ?? string.Empty;

                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveApotekaSaLab();
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
            if (apotekaSaLab == null)
            {
                apotekaSaLab = new ApotekaSaLabBasic();
            }

            FarmaceutBasic f = new FarmaceutBasic();

            apotekaSaLab.Naziv = txtNaziv.Text.Trim();
            apotekaSaLab.Ulica = txtUlica.Text.Trim();
            apotekaSaLab.Broj = txtBroj.Text.Trim();
            apotekaSaLab.PostanskiBroj = txtPostanskiBroj.Text.Trim();
            apotekaSaLab.Mesto = txtMesto.Text.Trim();
            apotekaSaLab.Napomena = string.IsNullOrWhiteSpace(txtNapomena.Text) ? null : txtNapomena.Text.Trim();

            apotekaSaLab.OdgovorniFarmaceut = DTOManagerZaposleni.VratiOdgovornogFarmaceuta((long)comboBox1.SelectedValue);

            DTOManagerProdajneJedinice.DodajApotekuSaLab(apotekaSaLab);
        }

        public ApotekaSaLabBasic GetApotekaSaLab()
        {
            return apotekaSaLab;
        }

        private void ApotekaSaLabForm_Load(object sender, EventArgs e)
        {

        }

        private void lblOdgovorniFarmaceut_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveApotekaSaLab();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void ApotekaSaLabForm_Load_1(object sender, EventArgs e)
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
                    button.BackColor = Color.FromArgb(46, 204, 113);
                else if (button == btnCancel)
                    button.BackColor = Color.FromArgb(231, 76, 60);
            }
        }
    }
}
