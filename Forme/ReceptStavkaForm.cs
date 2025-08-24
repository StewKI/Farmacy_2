using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class ReceptStavkaForm : Form
    {
        private ReceptStavka receptStavka;

        public ReceptStavkaForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public ReceptStavkaForm(ReceptStavka receptStavka) : this()
        {
            this.receptStavka = receptStavka;
            LoadReceptStavkaData();
        }

        private void InitializeForm()
        {
            // Form initialization logic will be in Designer file
        }

        private void LoadReceptStavkaData()
        {
            if (receptStavka != null)
            {
                if (receptStavka.Recept != null)
                    txtRecept.Text = receptStavka.Recept.ToString();
                
                if (receptStavka.Pakovanje != null)
                    txtPakovanje.Text = receptStavka.Pakovanje.ToString();
                
                numKolicina.Value = receptStavka.Kolicina;
                txtPreporucenaDoza.Text = receptStavka.PreporucenaDoza ?? string.Empty;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveReceptStavka();
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
            if (numKolicina.Value <= 0)
            {
                MessageBox.Show("Količina mora biti veća od 0!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numKolicina.Focus();
                return false;
            }

            return true;
        }

        private void SaveReceptStavka()
        {
            if (receptStavka == null)
            {
                receptStavka = new ReceptStavka();
            }

            receptStavka.Kolicina = (int)numKolicina.Value;
            receptStavka.PreporucenaDoza = string.IsNullOrWhiteSpace(txtPreporucenaDoza.Text) ? null : txtPreporucenaDoza.Text.Trim();
        }

        public ReceptStavka GetReceptStavka()
        {
            return receptStavka;
        }
    }
}
