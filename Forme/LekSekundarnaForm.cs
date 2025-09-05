using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class LekSekundarnaForm : Form
    {
        private LekSekundarna lekSekundarna;

        public LekSekundarnaForm()
        {
            InitializeComponent();
            lekSekundarna = new LekSekundarna();
            LoadLekSekundarnaData();
        }

        public LekSekundarnaForm(LekSekundarna lekSekundarna)
        {
            InitializeComponent();
            this.lekSekundarna = lekSekundarna;
            LoadLekSekundarnaData();
        }

        private void LoadLekSekundarnaData()
        {
            if (lekSekundarna.Lek != null)
                txtLekId.Text = lekSekundarna.Lek.Id.ToString();

            if (lekSekundarna.Kategorija != null)
                txtKategorijaId.Text = lekSekundarna.Kategorija.Id.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveLekSekundarna();
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
            if (string.IsNullOrWhiteSpace(txtLekId.Text))
            {
                MessageBox.Show("ID leka je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtKategorijaId.Text))
            {
                MessageBox.Show("ID kategorije je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void SaveLekSekundarna()
        {
            // Napomena: Referentne entitete (Lek, Kategorija) treba postaviti spolja
            // jer ova forma samo prikazuje ID-ove

           

            DTOManagerLek.DodajLekSekundarna(long.Parse(txtKategorijaId.Text), long.Parse(txtLekId.Text));
        }

        public LekSekundarna GetLekSekundarna()
        {
            return lekSekundarna;
        }

        private void LekSekundarnaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
