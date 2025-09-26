using System;
using System.Windows.Forms;
using Farmacy;
using Farmacy.Entiteti;

namespace Farmacy_2.Forme
{
    public partial class ZaposleniEditForm : Form
    {
        private ZaposleniBasic zaposleni;

        public ZaposleniEditForm(ZaposleniBasic zaposleni1)
        {
            InitializeComponent();
            this.zaposleni = zaposleni1;
            LoadZaposleniData();
            SetupButtonEffects();
        }

        private void LoadZaposleniData()
        {

            txtMBr.Text = zaposleni.Id.ToString();
            txtPrezime.Text = zaposleni.Prezime;
            txtIme.Text = zaposleni.Ime;
            dtpDatumRodj.Value = zaposleni.DatumRodj;
            txtAdresa.Text = zaposleni.Adresa ?? "";
            txtTelefon.Text = zaposleni.Telefon ?? "";
            dtpDatumZaposlenja.Value = zaposleni.DatumZaposlenja;
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
                MessageBox.Show("Datum rođenja ne može biti u budućnosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDatumRodj.Focus();
                return false;
            }

            if (dtpDatumZaposlenja.Value > DateTime.Now)
            {
                MessageBox.Show("Datum zaposlenja ne može biti u budućnosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDatumZaposlenja.Focus();
                return false;
            }

            if (dtpDatumZaposlenja.Value <= dtpDatumRodj.Value)
            {
                MessageBox.Show("Datum zaposlenja mora biti nakon datuma rođenja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDatumZaposlenja.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtTelefon.Text) && txtTelefon.Text.Length < 9)
            {
                MessageBox.Show("Telefon mora imati najmanje 9 karaktera!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefon.Focus();
                return false;
            }

            return true;
        }

        private void SaveZaposleni()
        {

            Zaposleni z = new Zaposleni();
            if (long.TryParse(txtMBr.Text, out long mbr))
                z.Id = mbr;

           
            z.Prezime = txtPrezime.Text.Trim();
            z.Ime = txtIme.Text.Trim();
            z.DatumRodj = dtpDatumRodj.Value;
            z.Adresa = string.IsNullOrWhiteSpace(txtAdresa.Text) ? null : txtAdresa.Text.Trim();
            z.Telefon = string.IsNullOrWhiteSpace(txtTelefon.Text) ? null : txtTelefon.Text.Trim();
            z.DatumZaposlenja = dtpDatumZaposlenja.Value;

            DTOManagerZaposleni.UpdateZaposlenog(z);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveZaposleni();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        //public Zaposleni GetZaposleni()
        //{
        //    return zaposleni;
        //}

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void ZaposleniEditForm_Load(object sender, EventArgs e)
        {

        }

        private void txtMBr_TextChanged(object sender, EventArgs e)
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
