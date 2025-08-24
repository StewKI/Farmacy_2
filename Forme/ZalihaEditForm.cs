using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class ZalihaEditForm : Form
    {
        private Zaliha zaliha;

        public ZalihaEditForm(Zaliha zaliha)
        {
            if (zaliha == null)
                throw new ArgumentNullException(nameof(zaliha));

            InitializeComponent();
            this.zaliha = zaliha;
            LoadZalihaData();
        }

        private void LoadZalihaData()
        {
            // Učitavamo postojeće podatke
            if (zaliha.ProdajnaJedinica != null)
                txtProdajnaJedinica.Text = zaliha.ProdajnaJedinica.Id.ToString();
            
            if (zaliha.Pakovanje != null)
                txtPakovanje.Text = zaliha.Pakovanje.Id.ToString();
            
            numKolicina.Value = zaliha.Kolicina;
            
            if (zaliha.DatumPoslednjeIsporuke.HasValue)
                dtpDatumPoslednjeIsporuke.Value = zaliha.DatumPoslednjeIsporuke.Value;
            
            if (zaliha.OdgovorniMagacioner != null)
                txtOdgovorniMagacioner.Text = zaliha.OdgovorniMagacioner.MBr.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveZaliha();
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
            if (numKolicina.Value < 0)
            {
                MessageBox.Show("Količina ne može biti negativna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numKolicina.Focus();
                return false;
            }

            if (dtpDatumPoslednjeIsporuke.Value > DateTime.Now)
            {
                MessageBox.Show("Datum poslednje isporuke ne može biti u budućnosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void SaveZaliha()
        {
            zaliha.Kolicina = (int)numKolicina.Value;
            zaliha.DatumPoslednjeIsporuke = dtpDatumPoslednjeIsporuke.Value;
            
            // Napomena: ProdajnaJedinica, Pakovanje i OdgovorniMagacioner treba postaviti spolja
        }

        public Zaliha GetZaliha()
        {
            return zaliha;
        }
    }
}
