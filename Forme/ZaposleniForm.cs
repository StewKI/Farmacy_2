using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class ZaposleniForm : Form
    {
        private ZaposleniBasic zaposleni;
        private long prodajnaJedinicaId;
      
        public ZaposleniForm()
        {
            InitializeComponent();
            InitializeForm();
            this.prodajnaJedinicaId = 0; // Default value
            ucitajApoteke();
        }

        public ZaposleniForm(long prodajnaJedinicaId)
        {
            InitializeComponent();
            InitializeForm();
            this.prodajnaJedinicaId = prodajnaJedinicaId;
            ucitajApoteke();
        }

        public ZaposleniForm(ZaposleniBasic zaposleni, long prodajnaJedinicaId) : this(prodajnaJedinicaId)
        {
            this.zaposleni = zaposleni;
            LoadZaposleniData();
        }

        void ucitajApoteke()
        {
            IList<ProdajnaJedinicaBasic>  lista = DTOManagerProdajneJedinice.VratiSveProdajneJedinice() ?? new List<ProdajnaJedinicaBasic>();
            var nazivi = lista.Select(l=>new { Text=l.Naziv,Value=l.Id }).ToList();
            comboBox1.DataSource = nazivi;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";

            var items = new[]
                                {
                                    new { Text = "Prva",  Value = 1 },
                                    new { Text = "Druga", Value = 2 },
                                    new { Text = "Treća", Value = 3 }
                                }.ToList();

            cmbSmena.DisplayMember = "Text";

            cmbSmena.ValueMember = "Value";
            cmbSmena.DataSource = items;
        }
        private void InitializeForm()
        {
            // Form initialization logic will be in Designer file
        }

        private void LoadZaposleniData()
        {
            if (zaposleni != null)
            {
                //txtMBr.Text = zaposleni.MBr.ToString();
                txtPrezime.Text = zaposleni.Prezime;
                txtIme.Text = zaposleni.Ime;
                dtpDatumRodj.Value = zaposleni.DatumRodj;
                txtAdresa.Text = zaposleni.Adresa ?? string.Empty;
                txtTelefon.Text = zaposleni.Telefon ?? string.Empty;
                dtpDatumZaposlenja.Value = zaposleni.DatumZaposlenja;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveZaposleni();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            try
            {
                // ovde pozivaš svoj DTOManager ili ORM


                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri snimanju u bazu: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                MessageBox.Show("Prezime je obavezno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrezime.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                MessageBox.Show("Ime je obavezno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIme.Focus();
                return false;
            }

            if (dtpDatumRodj.Value >= DateTime.Now)
            {
                MessageBox.Show("Datum rođenja mora biti u prošlosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDatumRodj.Focus();
                return false;
            }

            if (dtpDatumZaposlenja.Value > DateTime.Now)
            {
                MessageBox.Show("Datum zaposlenja ne može biti u budućnosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDatumZaposlenja.Focus();
                return false;
            }

            return true;
        }

        private void SaveZaposleni()
        {
            if (zaposleni == null)
            {
                zaposleni = new ZaposleniBasic();
            }

            // Generiši MBr ako nije postavljen
            if (zaposleni.MBr == 0)
            {
                zaposleni.MBr = DateTime.Now.Ticks;
            }

            zaposleni.Prezime = txtPrezime.Text.Trim();
            zaposleni.Ime = txtIme.Text.Trim();
            zaposleni.DatumRodj = dtpDatumRodj.Value;
            zaposleni.Adresa = string.IsNullOrWhiteSpace(txtAdresa.Text) ? null : txtAdresa.Text.Trim();
            zaposleni.Telefon = string.IsNullOrWhiteSpace(txtTelefon.Text) ? null : txtTelefon.Text.Trim();
            zaposleni.DatumZaposlenja = dtpDatumZaposlenja.Value;

            // Dodaj zaposlenog u sistem
            DTOManagerZaposleni.DodajZaposlenog(zaposleni);

        }

        public ZaposleniBasic GetZaposleni()
        {
            return zaposleni;
        }

        private void txtMBr_TextChanged(object sender, EventArgs e)
        {

        }

        private void ZaposleniForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void lblMBr_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
