using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class ZalihaForm : Form
    {
        private Zaliha zaliha;

        public ZalihaForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public ZalihaForm(Zaliha zaliha) : this()
        {
            this.zaliha = zaliha;
            LoadZalihaData();
        }

        private void InitializeForm()
        {
            // Form initialization logic will be in Designer file
        }

        private void LoadZalihaData()
        {
            if (zaliha != null)
            {
                if (zaliha.ProdajnaJedinica != null)
                    txtProdajnaJedinica.Text = zaliha.ProdajnaJedinica.ToString();
                
                if (zaliha.Pakovanje != null)
                    txtPakovanje.Text = zaliha.Pakovanje.ToString();
                
                numKolicina.Value = zaliha.Kolicina;
                
                if (zaliha.DatumPoslednjeIsporuke.HasValue)
                    dtpDatumPoslednjeIsporuke.Value = zaliha.DatumPoslednjeIsporuke.Value;
                else
                    dtpDatumPoslednjeIsporuke.Value = DateTime.Today;
                
                if (zaliha.OdgovorniMagacioner != null)
                    txtOdgovorniMagacioner.Text = zaliha.OdgovorniMagacioner.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveZaliha();
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
            if (numKolicina.Value < 0)
            {
                MessageBox.Show("Količina ne može biti negativna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numKolicina.Focus();
                return false;
            }

            if (dtpDatumPoslednjeIsporuke.Value > DateTime.Now)
            {
                MessageBox.Show("Datum poslednje isporuke ne može biti u budućnosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDatumPoslednjeIsporuke.Focus();
                return false;
            }

            return true;
        }

        private void SaveZaliha()
        {
            if (zaliha == null)
            {
                zaliha = new Zaliha();
            }

            zaliha.Kolicina = (int)numKolicina.Value;
            zaliha.DatumPoslednjeIsporuke = dtpDatumPoslednjeIsporuke.Value;
        }

        public Zaliha GetZaliha()
        {
            return zaliha;
        }
    }
}
