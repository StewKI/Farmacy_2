using System;
using System.Drawing;
using System.Windows.Forms;
using Farmacy.Entiteti;

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
            SetupButtonEffects();
        }

        public MenadzerForm(long prodajnaJedinicaId)
        {
            InitializeComponent();
            menadzer = new MenadzerBasic();
            this.prodajnaJedinicaId = prodajnaJedinicaId;
            ucitajApoteke();
            SetupButtonEffects();
        }

        public MenadzerForm(MenadzerBasic menadzer, long prodajnaJedinicaId)
        {
            InitializeComponent();
            this.menadzer = menadzer;
            this.prodajnaJedinicaId = prodajnaJedinicaId;
            LoadMenadzerData();
            SetupButtonEffects();
        }
        void ucitajApoteke()
        {
            // No longer needed - prodajnaJedinicaId is passed as parameter
        }
        private void LoadMenadzerData()
        {
            txtMatBr.Text = menadzer.MatBr;
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
            if (string.IsNullOrWhiteSpace(txtMatBr.Text))
            {
                MessageBox.Show("Matični broj je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatBr.Focus();
                return false;
            }

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
            try
            {
                menadzer.MatBr = txtMatBr.Text.Trim();
                menadzer.Prezime = txtPrezime.Text.Trim();
                menadzer.Ime = txtIme.Text.Trim();
                menadzer.DatumRodj = dtpDatumRodj.Value;
                menadzer.Adresa = string.IsNullOrWhiteSpace(txtAdresa.Text) ? null : txtAdresa.Text.Trim();
                menadzer.Telefon = string.IsNullOrWhiteSpace(txtTelefon.Text) ? null : txtTelefon.Text.Trim();
                menadzer.DatumZaposlenja = dtpDatumZaposlenja.Value;

                // Dodaj menadžera u sistem
                DTOManagerZaposleni.DodajMenadzera(menadzer);

                MessageBox.Show("Menadžer je uspešno dodat!", "Uspešno",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri dodavanju menadžera: {ex.Message}", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //public Entiteti.MenadzerBasic GetMenadzer()
        //{
        //    return menadzer;
        //}

        private void MenadzerForm_Load(object sender, EventArgs e)
        {

        }


        private void SetupButtonEffects()
        {
            // Dodaj hover efekte za dugmad
            btnSave.MouseEnter += Button_MouseEnter;
            btnSave.MouseLeave += Button_MouseLeave;
            btnCancel.MouseEnter += Button_MouseEnter;
            btnCancel.MouseLeave += Button_MouseLeave;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                // Sačuvaj originalnu boju samo ako nije već sačuvana
                if (button.Tag == null)
                {
                    button.Tag = button.BackColor;
                }

                // Promeni boju na hover
                if (button == btnSave)
                {
                    button.BackColor = Color.FromArgb(33, 136, 56); // Tamnija zelena
                }
                else if (button == btnCancel)
                {
                    button.BackColor = Color.FromArgb(90, 98, 104); // Tamnija siva
                }

                button.Cursor = Cursors.Hand;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is Color originalColor)
            {
                // Vrati originalnu boju
                button.BackColor = originalColor;
                button.Cursor = Cursors.Default;
            }
        }

        private void lblMatBr_Click(object sender, EventArgs e)
        {

        }
    }
}
