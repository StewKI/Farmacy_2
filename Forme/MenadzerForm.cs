using System;
using System.Windows.Forms;
using Farmacy.Entiteti;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Farmacy.Forme
{
    public partial class MenadzerForm : Form
    {
        private MenadzerBasic menadzer;
        private long prodajnaJedinicaId;

        public MenadzerForm()
        {
            InitializeComponent();
            menadzer = new MenadzerBasic();
            this.prodajnaJedinicaId = 0; // Default value
            ucitajApoteke();
        }

        public MenadzerForm(long prodajnaJedinicaId)
        {
            InitializeComponent();
            menadzer = new MenadzerBasic();
            this.prodajnaJedinicaId = prodajnaJedinicaId;
            ucitajApoteke();
        }

        public MenadzerForm(MenadzerBasic menadzer, long prodajnaJedinicaId)
        {
            InitializeComponent();
            this.menadzer = menadzer;
            this.prodajnaJedinicaId = prodajnaJedinicaId;
            LoadMenadzerData();
        }
        void ucitajApoteke()
        {
            // No longer needed - prodajnaJedinicaId is passed as parameter
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
            // Generiši MBr ako nije postavljen
            if (menadzer.MBr == 0)
            {
                menadzer.MBr = DateTime.Now.Ticks;
            }

            menadzer.Prezime = txtPrezime.Text.Trim();
            menadzer.Ime = txtIme.Text.Trim();
            menadzer.DatumRodj = dtpDatumRodj.Value;
            menadzer.Adresa = string.IsNullOrWhiteSpace(txtAdresa.Text) ? null : txtAdresa.Text.Trim();
            menadzer.Telefon = string.IsNullOrWhiteSpace(txtTelefon.Text) ? null : txtTelefon.Text.Trim();
            menadzer.DatumZaposlenja = dtpDatumZaposlenja.Value;

            // Dodaj menadžera u sistem
            DTOManagerZaposleni.DodajMenadzera(menadzer);

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
