using System;
using System.Windows.Forms;
using Farmacy;

namespace Farmacy_2.Forme
{
    public partial class ProdajnaJedinicaEditForm : Form
    {
        private ProdajnaJedinicaBasic prodajnaJedinica;

        public ProdajnaJedinicaEditForm(ProdajnaJedinicaBasic prodajnaJedinica)
        {
            InitializeComponent();
            this.prodajnaJedinica = prodajnaJedinica ?? throw new ArgumentNullException(nameof(prodajnaJedinica));
            LoadProdajnaJedinicaData();
        }

        private void LoadProdajnaJedinicaData()
        {
            txtId.Text = prodajnaJedinica.Id.ToString();
            txtNaziv.Text = prodajnaJedinica.Naziv;
            txtUlica.Text = prodajnaJedinica.Ulica;
            txtBroj.Text = prodajnaJedinica.Broj;
            txtPostanskiBroj.Text = prodajnaJedinica.PostanskiBroj;
            txtMesto.Text = prodajnaJedinica.Mesto;
            //Stavljeno je da apotekar koj je izabran iz globalnog sistema bude odgovaran a ne koj raid ovde se bira od onih sto rade bas u toj prodajnoj jedinici
            var f = DTOManagerZaposleni.VratiOdgovornogFarmaceuta(prodajnaJedinica.OdgovorniFarmaceutMbr);
            IList<FarmaceutBasic> lista = DTOManagerProdajneJedinice.VratiSveFarmaceuteZaApoteku(prodajnaJedinica.Id) ?? new List<FarmaceutBasic>();
            var nazivi = lista.Select(l => new { Text = l.Ime, Value = l.MBr }).ToList();
            var o = new { Text =f.Ime, Value = f.MBr };
            if (nazivi.Count < 1)
                nazivi.Add(o);
            comboBox1.DataSource = nazivi;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
            comboBox1.SelectedValue = prodajnaJedinica.OdgovorniFarmaceutMbr;
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
            prodajnaJedinica.Naziv = txtNaziv.Text.Trim();
            prodajnaJedinica.Ulica = txtUlica.Text.Trim();
            prodajnaJedinica.Broj = txtBroj.Text.Trim();
            prodajnaJedinica.PostanskiBroj = txtPostanskiBroj.Text.Trim();
            prodajnaJedinica.Mesto = txtMesto.Text.Trim();
            prodajnaJedinica.OdgovorniFarmaceutMbr= (long)comboBox1.SelectedValue;

            DTOManagerProdajneJedinice.IzmeniProdajnuJedinicu(prodajnaJedinica);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveProdajnaJedinica();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public ProdajnaJedinicaBasic GetProdajnaJedinica()
        {
            return prodajnaJedinica;
        }

        private void ProdajnaJedinicaEditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
