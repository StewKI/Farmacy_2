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
            SetupButtonEffects();
        }

        public ZaposleniForm(long prodajnaJedinicaId)
        {
            InitializeComponent();
            InitializeForm();
            this.prodajnaJedinicaId = prodajnaJedinicaId;
            SetupButtonEffects();
        }

        public ZaposleniForm(ZaposleniBasic zaposleni, long prodajnaJedinicaId) : this(prodajnaJedinicaId)
        {
            this.zaposleni = zaposleni;
            LoadZaposleniData();
        }

        private void InitializeForm()
        {
            // Initialize smena combo box
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

        private void LoadZaposleniData()
        {
            if (zaposleni != null)
            {
                txtMatBr.Text = zaposleni.MatBr;
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
            if (string.IsNullOrWhiteSpace(txtMatBr.Text))
            {
                MessageBox.Show("Matični broj je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatBr.Focus();
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

            // Za novi zaposleni, kreiraj novi objekat bez Id-a
            bool isNewZaposleni = (zaposleni.Id == 0);
            if (isNewZaposleni)
            {
                zaposleni = new ZaposleniBasic();
            }

            zaposleni.MatBr = txtMatBr.Text.Trim();
            zaposleni.Prezime = txtPrezime.Text.Trim();
            zaposleni.Ime = txtIme.Text.Trim();
            zaposleni.DatumRodj = dtpDatumRodj.Value;
            zaposleni.Adresa = string.IsNullOrWhiteSpace(txtAdresa.Text) ? null : txtAdresa.Text.Trim();
            zaposleni.Telefon = string.IsNullOrWhiteSpace(txtTelefon.Text) ? null : txtTelefon.Text.Trim();
            zaposleni.DatumZaposlenja = dtpDatumZaposlenja.Value;

            // Dodaj ili ažuriraj zaposlenog u sistemu
            if (isNewZaposleni)
            {
                DTOManagerZaposleni.DodajZaposlenog(zaposleni);
            }
            else
            {
                // Za postojeći zaposleni, možda treba UpdateZaposlenog funkcija
                DTOManagerZaposleni.DodajZaposlenog(zaposleni);
            }

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
