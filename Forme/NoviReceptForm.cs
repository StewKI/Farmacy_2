using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class NoviReceptForm : Form
    {
        private Recept recept;

        public NoviReceptForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public NoviReceptForm(Recept recept) : this()
        {
            this.recept = recept;
            LoadReceptData();
        }

        private void InitializeForm()
        {
            // Form initialization logic will be in Designer file
            LoadStatusi();
        }

        private void LoadStatusi()
        {
            cboStatus.Items.Clear();
            cboStatus.Items.Add("IZDAT");
            cboStatus.Items.Add("CEKANJE");
            cboStatus.Items.Add("ODBIJEN");
        }

        private void LoadReceptData()
        {
            if (recept != null)
            {
                txtSerijskiBroj.Text = recept.SerijskiBroj;
                txtSifraLekara.Text = recept.SifraLekara;
                dtpDatumIzd.Value = recept.DatumIzd;
                cboStatus.SelectedItem = recept.Status;
                txtNazivUstanove.Text = recept.NazivUstanove;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveRecept();
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
            if (string.IsNullOrWhiteSpace(txtSerijskiBroj.Text))
            {
                MessageBox.Show("Serijski broj je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSerijskiBroj.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSifraLekara.Text))
            {
                MessageBox.Show("Šifra lekara je obavezna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSifraLekara.Focus();
                return false;
            }

            if (cboStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Status je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboStatus.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNazivUstanove.Text))
            {
                MessageBox.Show("Naziv ustanove je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNazivUstanove.Focus();
                return false;
            }

            if (dtpDatumIzd.Value > DateTime.Now)
            {
                MessageBox.Show("Datum izdavanja ne može biti u budućnosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDatumIzd.Focus();
                return false;
            }

            return true;
        }

        private void SaveRecept()
        {
            if (recept == null)
            {
                recept = new Recept();
            }

            recept.SerijskiBroj = txtSerijskiBroj.Text.Trim();
            recept.SifraLekara = txtSifraLekara.Text.Trim();
            recept.DatumIzd = dtpDatumIzd.Value;
            recept.Status = cboStatus.SelectedItem.ToString();
            recept.NazivUstanove = txtNazivUstanove.Text.Trim();

            DTOManagerIsporukeZalihe.DodajRecept(recept);
        }

        public Recept GetRecept()
        {
            return recept;
        }

        private void NoviReceptForm_Load(object sender, EventArgs e)
        {

        }

        private void dtpRealizacijaDatum_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
