using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class TehnicarEditForm : Form
    {
        private TehnicarBasic tehnicar;

        public TehnicarEditForm(TehnicarBasic tehnicar)
        {
            if (tehnicar == null)
                throw new ArgumentNullException(nameof(tehnicar));

            InitializeComponent();
            this.tehnicar = tehnicar;
            LoadTehnicarData();
            SetupButtonEffects();
        }

        private void LoadTehnicarData()
        {
            // Učitavamo postojeće podatke
            txtMBr.Text = tehnicar.Id.ToString();
            txtPrezime.Text = tehnicar.Prezime;
            txtIme.Text = tehnicar.Ime;
            dtpDatumRodj.Value = tehnicar.DatumRodj;

            if (!string.IsNullOrEmpty(tehnicar.Adresa))
                txtAdresa.Text = tehnicar.Adresa;

            if (!string.IsNullOrEmpty(tehnicar.Telefon))
                txtTelefon.Text = tehnicar.Telefon;

            dtpDatumZaposlenja.Value = tehnicar.DatumZaposlenja;

            if (!string.IsNullOrEmpty(tehnicar.NivoObrazovanja))
                txtNivoObrazovanja.Text = tehnicar.NivoObrazovanja;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveTehnicar();
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
            if (string.IsNullOrWhiteSpace(txtMBr.Text))
            {
                MessageBox.Show("Matični broj je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMBr.Focus();
                return false;
            }

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

            if (string.IsNullOrWhiteSpace(txtNivoObrazovanja.Text))
            {
                MessageBox.Show("Nivo obrazovanja je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNivoObrazovanja.Focus();
                return false;
            }

            return true;
        }

        private void SaveTehnicar()
        {
           
            TehnicarBasic t= new TehnicarBasic();

            if (long.TryParse(txtMBr.Text, out long mbr))
                t.Id = mbr;

            t.Prezime = txtPrezime.Text.Trim();
            t.Ime = txtIme.Text.Trim();
            t.DatumRodj = dtpDatumRodj.Value;
            t.Adresa = string.IsNullOrWhiteSpace(txtAdresa.Text) ? null : txtAdresa.Text.Trim();
            t.Telefon = string.IsNullOrWhiteSpace(txtTelefon.Text) ? null : txtTelefon.Text.Trim();
            t.DatumZaposlenja = dtpDatumZaposlenja.Value;
            t.NivoObrazovanja = txtNivoObrazovanja.Text.Trim();

            DTOManagerZaposleni.UpdateTehnicara(t);
        }

        public TehnicarBasic GetTehnicar()
        {
            return tehnicar;
        }

        private void TehnicarEditForm_Load(object sender, EventArgs e)
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
                    button.BackColor = Color.FromArgb(39, 174, 96); // Tamnija zelena
                }
                else if (button == btnCancel)
                {
                    button.BackColor = Color.FromArgb(192, 57, 43); // Tamnija crvena
                }
                
                button.Cursor = Cursors.Hand;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is Color originalColor)
            {
                button.BackColor = originalColor;
                button.Cursor = Cursors.Default;
            }
        }
    }
}
