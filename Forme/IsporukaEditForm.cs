using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy_2.Forme
{
    public partial class IsporukaEditForm : Form
    {
        private Isporuka isporuka;

        public IsporukaEditForm(Isporuka isporuka)
        {
            InitializeComponent();
            this.isporuka = isporuka ?? throw new ArgumentNullException(nameof(isporuka));
            LoadIsporukaData();
        }

        private void LoadIsporukaData()
        {
            txtId.Text = isporuka.Id.ToString();
            txtDistributer.Text = isporuka.Distributer?.Id.ToString() ?? "Nije postavljen";
            txtProdajnaJedinica.Text = isporuka.ProdajnaJedinica?.Id.ToString() ?? "Nije postavljen";
            dtpDatum.Value = isporuka.Datum;
            txtMagacioner.Text = isporuka.Magacioner?.MBr.ToString() ?? "Nije postavljen";
        }

        private bool ValidateForm()
        {
            if (dtpDatum.Value > DateTime.Now)
            {
                MessageBox.Show("Datum isporuke ne može biti u budućnosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDatum.Focus();
                return false;
            }

            return true;
        }

        private void SaveIsporuka()
        {
            isporuka.Datum = dtpDatum.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveIsporuka();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public Isporuka GetIsporuka()
        {
            return isporuka;
        }
    }
}
