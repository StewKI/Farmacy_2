using System;
using System.Drawing;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class TehnicarForm : Form
    {
        private TehnicarBasic tehnicar;
        private long prodajnaJedinicaId;

        public TehnicarForm()
        {
            InitializeComponent();
            tehnicar = new TehnicarBasic();
            InitializeForm();
            this.prodajnaJedinicaId = 0;
            ucitajApoteke();
            SetupButtonEffects();
        }

        public TehnicarForm(long prodajnaJedinicaId)
        {
            InitializeComponent();
            tehnicar = new TehnicarBasic();
            InitializeForm();
            this.prodajnaJedinicaId = prodajnaJedinicaId;
            ucitajApoteke();
            SetupButtonEffects();
        }

        public TehnicarForm(TehnicarBasic tehnicar, long prodajnaJedinicaId) : this(prodajnaJedinicaId)
        {
            this.tehnicar = tehnicar;
            LoadTehnicarData();
        }

        void ucitajApoteke()
        {
            // Initialize only the education level combo box
            var items2 = new[]
                                {
                                    new { Text = "VISI",  Value = "VISI" },
                                    new { Text = "SREDNJI", Value = "SREDNJI" },
                                   
                                }.ToList();

            cmbNivo.DisplayMember = "Text";
            cmbNivo.ValueMember = "Value";
            cmbNivo.DataSource = items2;
        }

        private void InitializeForm()
        {
            // Form initialization logic will be in Designer file
        }

        private void LoadTehnicarData()
        {
            if (tehnicar != null)
            {
                txtMatBr.Text = tehnicar.MatBr;
                txtPrezime.Text = tehnicar.Prezime;
                txtIme.Text = tehnicar.Ime;
                dtpDatumRodj.Value = tehnicar.DatumRodj;
                txtAdresa.Text = tehnicar.Adresa ?? string.Empty;
                txtTelefon.Text = tehnicar.Telefon ?? string.Empty;
                dtpDatumZaposlenja.Value = tehnicar.DatumZaposlenja;
                //txtNivoObrazovanja.Text = tehnicar.NivoObrazovanja;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveTehnicar();
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

            if (string.IsNullOrWhiteSpace(cmbNivo.Text))
            {
                MessageBox.Show("Nivo obrazovanja je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbNivo.Focus();
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

        private void SaveTehnicar()
        {
            tehnicar.MatBr = txtMatBr.Text.Trim();
            tehnicar.Prezime = txtPrezime.Text.Trim();
            tehnicar.Ime = txtIme.Text.Trim();
            tehnicar.DatumRodj = dtpDatumRodj.Value;
            tehnicar.Adresa = string.IsNullOrWhiteSpace(txtAdresa.Text) ? null : txtAdresa.Text.Trim();
            tehnicar.Telefon = string.IsNullOrWhiteSpace(txtTelefon.Text) ? null : txtTelefon.Text.Trim();
            tehnicar.DatumZaposlenja = dtpDatumZaposlenja.Value;
            tehnicar.NivoObrazovanja = cmbNivo.Text;

            // Dodaj tehničara u sistem
            DTOManagerZaposleni.DodajTehnicara(tehnicar);

        }

        //public Tehnicar GetTehnicar()
        //{
        //    return tehnicar;
        //}

        private void txtMBr_TextChanged(object sender, EventArgs e)
        {

        }

        private void TehnicarForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajSertifikaciju_Click(object sender, EventArgs e)
        {
            DodajSertifikacijuForm form=new DodajSertifikacijuForm(tehnicar);
            form.ShowDialog();
        }

        private void SetupButtonEffects()
        {
            // Dodaj hover efekte za dugmad
            btnSave.MouseEnter += Button_MouseEnter;
            btnSave.MouseLeave += Button_MouseLeave;
            btnCancel.MouseEnter += Button_MouseEnter;
            btnCancel.MouseLeave += Button_MouseLeave;
            btnDodajSertifikaciju.MouseEnter += Button_MouseEnter;
            btnDodajSertifikaciju.MouseLeave += Button_MouseLeave;
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
                else if (button == btnDodajSertifikaciju)
                {
                    button.BackColor = Color.FromArgb(41, 128, 185); // Tamnija plava
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
