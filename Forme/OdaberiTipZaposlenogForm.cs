using System;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class OdaberiTipZaposlenogForm : Form
    {
        private long prodajnaJedinicaId;

        public OdaberiTipZaposlenogForm(long prodajnaJedinicaId)
        {
            InitializeComponent();
            this.prodajnaJedinicaId = prodajnaJedinicaId;
        }

        private void btnFarmaceut_Click(object sender, EventArgs e)
        {
            FarmaceutForm form = new FarmaceutForm(prodajnaJedinicaId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Farmaceut je uspešno dodat!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void btnTehnicar_Click(object sender, EventArgs e)
        {
            TehnicarForm form = new TehnicarForm(prodajnaJedinicaId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Tehničar je uspešno dodat!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void btnMenadzer_Click(object sender, EventArgs e)
        {
            MenadzerForm form = new MenadzerForm(prodajnaJedinicaId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Menadžer je uspešno dodat!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
