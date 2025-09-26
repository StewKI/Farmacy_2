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
            SetupButtonEffects();
        }

        private void LoadZalihaData()
        {
            // Učitavamo postojeće podatke
            txtProdajnaJedinica.Text = zaliha.ProdajnaJedinicaId.ToString();
            txtPakovanje.Text = zaliha.PakovanjeId.ToString();
            numKolicina.Value = zaliha.Kolicina;

            if (zaliha.DatumPoslednjeIsporuke.HasValue)
                dtpDatumPoslednjeIsporuke.Value = zaliha.DatumPoslednjeIsporuke.Value;

            if (zaliha.OdgovorniMagacionerId.HasValue)
                txtOdgovorniMagacioner.Text = zaliha.OdgovorniMagacionerId.ToString();
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
                    zaliha.OdgovorniMagacionerId = mbr;
                }
            }
            else
            {
                zaliha.OdgovorniMagacionerId = null;
            }

            DTOManagerIsporukeZalihe.IzmeniZalihu(zaliha);
        }

        public ZalihaBasic GetZaliha()
        {
            return zaliha;
        }

        private void SetupButtonEffects()
        {
            // Add hover effects to all buttons
            btnSave.MouseEnter += Button_MouseEnter;
            btnSave.MouseLeave += Button_MouseLeave;
            btnCancel.MouseEnter += Button_MouseEnter;
            btnCancel.MouseLeave += Button_MouseLeave;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                // Store original color and make button lighter
                button.BackColor = Color.FromArgb(
                    Math.Min(255, button.BackColor.R + 30),
                    Math.Min(255, button.BackColor.G + 30),
                    Math.Min(255, button.BackColor.B + 30)
                );
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                // Restore original color
                if (button == btnSave)
                    button.BackColor = Color.FromArgb(41, 128, 185);
                else if (button == btnCancel)
                    button.BackColor = Color.FromArgb(231, 76, 60);
            }
        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }
    }
}
