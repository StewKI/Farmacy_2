using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class IsporukaForm : Form
    {
        private Isporuka isporuka;

        public IsporukaForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public IsporukaForm(Isporuka isporuka) : this()
        {
            this.isporuka = isporuka;
            LoadIsporukaData();
        }

        private void InitializeForm()
        {
            // Form initialization logic will be in Designer file
        }

        private void LoadIsporukaData()
        {
            if (isporuka != null)
            {
                txtId.Text = isporuka.Id.ToString();
                dtpDatum.Value = isporuka.Datum;
                
                if (isporuka.Distributer != null)
                    txtDistributer.Text = isporuka.Distributer.ToString();
                if (isporuka.ProdajnaJedinica != null)
                    txtProdajnaJedinica.Text = isporuka.ProdajnaJedinica.ToString();
                if (isporuka.Magacioner != null)
                    txtMagacioner.Text = isporuka.Magacioner.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveIsporuka();
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
            if (string.IsNullOrWhiteSpace(txtDistributer.Text))
            {
                MessageBox.Show("Distributer je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDistributer.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtProdajnaJedinica.Text))
            {
                MessageBox.Show("Prodajna jedinica je obavezna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProdajnaJedinica.Focus();
                return false;
            }

            return true;
        }

        private void SaveIsporuka()
        {
            if (isporuka == null)
            {
                isporuka = new Isporuka();
            }

            isporuka.Datum = dtpDatum.Value;
            // Napomena: Distributer, ProdajnaJedinica i Magacioner se postavljaju preko referenci
        }

        public Isporuka GetIsporuka()
        {
            return isporuka;
        }
    }
}
