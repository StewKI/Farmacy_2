using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class MenadzerApotekaEditForm : Form
    {
        private MenadzerApoteka menadzerApoteka;

        public MenadzerApotekaEditForm(MenadzerApoteka menadzerApoteka)
        {
            if (menadzerApoteka == null)
                throw new ArgumentNullException(nameof(menadzerApoteka));

            InitializeComponent();
            this.menadzerApoteka = menadzerApoteka;
            LoadMenadzerApotekaData();
        }

        private void LoadMenadzerApotekaData()
        {
            // Učitavamo postojeće podatke
            if (menadzerApoteka.Menadzer != null)
                txtMenadzerId.Text = menadzerApoteka.Menadzer.MBr.ToString();
            
            if (menadzerApoteka.ProdajnaJedinica != null)
                txtProdajnaJedinicaId.Text = menadzerApoteka.ProdajnaJedinica.Id.ToString();
            
            dtpOd.Value = menadzerApoteka.Od;
            
            if (menadzerApoteka.Do.HasValue)
                dtpDo.Value = menadzerApoteka.Do.Value;
            else
                chkDo.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveMenadzerApoteka();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void chkDo_CheckedChanged(object sender, EventArgs e)
        {
            dtpDo.Enabled = !chkDo.Checked;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtMenadzerId.Text))
            {
                MessageBox.Show("ID menadžera je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtProdajnaJedinicaId.Text))
            {
                MessageBox.Show("ID prodajne jedinice je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dtpOd.Value >= dtpDo.Value && !chkDo.Checked)
            {
                MessageBox.Show("Datum 'Od' mora biti pre datuma 'Do'!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void SaveMenadzerApoteka()
        {
            // Napomena: Referentne entitete (Menadzer, ProdajnaJedinica) treba postaviti spolja
            // jer ova forma samo prikazuje ID-ove
            menadzerApoteka.Od = dtpOd.Value;
            menadzerApoteka.Do = chkDo.Checked ? null : dtpDo.Value;
        }

        public MenadzerApoteka GetMenadzerApoteka()
        {
            return menadzerApoteka;
        }
    }
}
