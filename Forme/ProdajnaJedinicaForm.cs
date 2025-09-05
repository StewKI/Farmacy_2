using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class ProdajnaJedinicaForm : Form
    {
        private ProdajnaJedinicaBasic prodajnaJedinica;

        public ProdajnaJedinicaForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public ProdajnaJedinicaForm(ProdajnaJedinicaBasic prodajnaJedinica) : this()
        {
            this.prodajnaJedinica = prodajnaJedinica;
            LoadProdajnaJedinicaData();
        }

        private void InitializeForm()
        {
            // Form initialization logic will be in Designer file
        }

        private void LoadProdajnaJedinicaData()
        {
            if (prodajnaJedinica != null)
            {
                txtId.Text = prodajnaJedinica.Id.ToString();
                txtNaziv.Text = prodajnaJedinica.Naziv;
                txtUlica.Text = prodajnaJedinica.Ulica;
                txtBroj.Text = prodajnaJedinica.Broj;
                txtPostanskiBroj.Text = prodajnaJedinica.PostanskiBroj;
                txtMesto.Text = prodajnaJedinica.Mesto;

                if (prodajnaJedinica.OdgovorniFarmaceutMbr != null)
                    txtOdgovorniFarmaceut.Text = prodajnaJedinica.OdgovorniFarmaceutMbr.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveProdajnaJedinica();
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

        private void SaveProdajnaJedinica()
        {
            if (prodajnaJedinica == null)
            {
                prodajnaJedinica = new ProdajnaJedinicaBasic();
            }

            prodajnaJedinica.Naziv = txtNaziv.Text.Trim();
            prodajnaJedinica.Ulica = txtUlica.Text.Trim();
            prodajnaJedinica.Broj = txtBroj.Text.Trim();
            prodajnaJedinica.PostanskiBroj = txtPostanskiBroj.Text.Trim();
            prodajnaJedinica.Mesto = txtMesto.Text.Trim();
            prodajnaJedinica.OdgovorniFarmaceutMbr = long.Parse(txtOdgovorniFarmaceut.Text.Trim());
            DTOManagerProdajneJedinice.DodajProdajnuJedinicu(prodajnaJedinica);

        }

        public ProdajnaJedinicaBasic GetProdajnaJedinica()
        {
            return prodajnaJedinica;
        }

        private void ProdajnaJedinicaForm_Load(object sender, EventArgs e)
        {

        }

        private void txtOdgovorniFarmaceut_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
