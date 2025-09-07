using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class ZalihaEditForm : Form
    {
        private ZalihaBasic zaliha;

        public ZalihaEditForm(ZalihaBasic zaliha)
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
            txtProdajnaJedinica.Text = zaliha.ProdajnaJedinicaId.ToString();
            txtPakovanje.Text = zaliha.PakovanjeId.ToString();
            numKolicina.Value = zaliha.Kolicina;
            
            if (zaliha.DatumPoslednjeIsporuke.HasValue)
                dtpDatumPoslednjeIsporuke.Value = zaliha.DatumPoslednjeIsporuke.Value;
            
            if (zaliha.OdgovorniMagacionerMbr.HasValue)
                txtOdgovorniMagacioner.Text = zaliha.OdgovorniMagacionerMbr.ToString();
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
            
            if (!string.IsNullOrEmpty(txtOdgovorniMagacioner.Text))
            {
                if (long.TryParse(txtOdgovorniMagacioner.Text, out long mbr))
                {
                    zaliha.OdgovorniMagacionerMbr = mbr;
                }
            }
            else
            {
                zaliha.OdgovorniMagacionerMbr = null;
            }

            DTOManagerIsporukeZalihe.IzmeniZalihu(zaliha);
        }

        public ZalihaBasic GetZaliha()
        {
            return zaliha;
        }
    }
}
