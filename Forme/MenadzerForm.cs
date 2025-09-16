using System;
using System.Windows.Forms;
using Farmacy.Entiteti;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Farmacy.Forme
{
    public partial class MenadzerForm : Form
    {
        private MenadzerBasic menadzer;

        public MenadzerForm()
        {
            InitializeComponent();
            menadzer = new MenadzerBasic();
            ucitajApoteke();
        }

        public MenadzerForm(MenadzerBasic menadzer)
        {
            InitializeComponent();
            this.menadzer = menadzer;
            LoadMenadzerData();
        }
        void ucitajApoteke()
        {
            IList<ProdajnaJedinicaBasic> lista = DTOManagerProdajneJedinice.VratiSveProdajneJedinice() ?? new List<ProdajnaJedinicaBasic>();
            var nazivi = lista.Select(l => new { Text = l.Naziv, Value = l.Id }).ToList();
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
        private void LoadMenadzerData()
        {
            //txtMBr.Text = menadzer.MBr.ToString();
            txtPrezime.Text = menadzer.Prezime;
            txtIme.Text = menadzer.Ime;
            dtpDatumRodj.Value = menadzer.DatumRodj;

            if (!string.IsNullOrEmpty(menadzer.Adresa))
                txtAdresa.Text = menadzer.Adresa;

            if (!string.IsNullOrEmpty(menadzer.Telefon))
                txtTelefon.Text = menadzer.Telefon;

            dtpDatumZaposlenja.Value = menadzer.DatumZaposlenja;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveMenadzer();
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


            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                MessageBox.Show("Prezime je obavezno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                MessageBox.Show("Ime je obavezno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dtpDatumRodj.Value >= DateTime.Now)
            {
                MessageBox.Show("Datum rođenja ne može biti u budućnosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dtpDatumZaposlenja.Value > DateTime.Now)
            {
                MessageBox.Show("Datum zaposlenja ne može biti u budućnosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dtpDatumZaposlenja.Value <= dtpDatumRodj.Value)
            {
                MessageBox.Show("Datum zaposlenja mora biti posle datuma rođenja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void SaveMenadzer()
        {


            menadzer.Prezime = txtPrezime.Text.Trim();
            menadzer.Ime = txtIme.Text.Trim();
            menadzer.DatumRodj = dtpDatumRodj.Value;
            menadzer.Adresa = string.IsNullOrWhiteSpace(txtAdresa.Text) ? null : txtAdresa.Text.Trim();
            menadzer.Telefon = string.IsNullOrWhiteSpace(txtTelefon.Text) ? null : txtTelefon.Text.Trim();
            menadzer.DatumZaposlenja = dtpDatumZaposlenja.Value;
            int smena = (int)cmbSmena.SelectedValue;


            long idP = (long)comboBox1.SelectedValue;
            DTOManagerZaposleni.DodajMenadzera(menadzer, idP, dateTimePicker1.Value,smena);
        }

        //public Entiteti.MenadzerBasic GetMenadzer()
        //{
        //    return menadzer;
        //}

        private void MenadzerForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
