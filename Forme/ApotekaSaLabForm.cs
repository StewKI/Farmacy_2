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
        }

        public ApotekaSaLabForm(ApotekaSaLabBasic apotekaSaLab) : this()
        {
            this.apotekaSaLab = apotekaSaLab;
            LoadApotekaSaLabData();
        }

        private void InitializeForm()
        {
            // Form initialization logic will be in Designer file
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

                if (apotekaSaLab.OdgovorniFarmaceut != null)
                    txtOdgovorniFarmaceut.Text = apotekaSaLab.OdgovorniFarmaceut.ToString();
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

            apotekaSaLab.OdgovorniFarmaceut = DTOManagerZaposleni.VratiOdgovornogFarmaceuta(long.Parse(txtOdgovorniFarmaceut.Text.Trim()));

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
    }
}
