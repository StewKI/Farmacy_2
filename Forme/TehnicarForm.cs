using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class TehnicarForm : Form
    {
        private TehnicarBasic tehnicar;

        public TehnicarForm()
        {
            InitializeComponent();
            tehnicar = new TehnicarBasic();
            InitializeForm();
            ucitajApoteke();
        }

        public TehnicarForm(TehnicarBasic tehnicar) : this()
        {
            this.tehnicar = tehnicar;
            LoadTehnicarData();
        }

        void ucitajApoteke()
        {
            
            IList<ProdajnaJedinicaBasic> lista = DTOManagerProdajneJedinice.VratiSveProdajneJedinice() ?? new List<ProdajnaJedinicaBasic>();
            var nazivi = lista.Select(l => new { Text = l.Naziv, Value = l.Id }).ToList();
            comboBox1.DataSource = nazivi;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
        }

        private void InitializeForm()
        {
            // Form initialization logic will be in Designer file
        }

        private void LoadTehnicarData()
        {
            if (tehnicar != null)
            {
                //txtMBr.Text = tehnicar.MBr.ToString();
                txtPrezime.Text = tehnicar.Prezime;
                txtIme.Text = tehnicar.Ime;
                dtpDatumRodj.Value = tehnicar.DatumRodj;
                txtAdresa.Text = tehnicar.Adresa ?? string.Empty;
                txtTelefon.Text = tehnicar.Telefon ?? string.Empty;
                dtpDatumZaposlenja.Value = tehnicar.DatumZaposlenja;
                txtNivoObrazovanja.Text = tehnicar.NivoObrazovanja;
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

            if (string.IsNullOrWhiteSpace(txtNivoObrazovanja.Text))
            {
                MessageBox.Show("Nivo obrazovanja je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNivoObrazovanja.Focus();
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
           

            tehnicar.Prezime = txtPrezime.Text.Trim();
            tehnicar.Ime = txtIme.Text.Trim();
            tehnicar.DatumRodj = dtpDatumRodj.Value;
            tehnicar.Adresa = string.IsNullOrWhiteSpace(txtAdresa.Text) ? null : txtAdresa.Text.Trim();
            tehnicar.Telefon = string.IsNullOrWhiteSpace(txtTelefon.Text) ? null : txtTelefon.Text.Trim();
            tehnicar.DatumZaposlenja = dtpDatumZaposlenja.Value;
            tehnicar.NivoObrazovanja = txtNivoObrazovanja.Text.Trim();
            long idP = (long)comboBox1.SelectedValue;


            DTOManagerZaposleni.DodajTehnicara(tehnicar,idP,dateTimePicker1.Value);
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
    }
}
