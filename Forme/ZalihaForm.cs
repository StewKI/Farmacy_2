using System;
using System.Drawing;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class ZalihaForm : Form
    {
        private ZalihaBasic zaliha;

        public ZalihaForm()
        {
            InitializeComponent();
            InitializeForm();
            SetupButtonEffects();
            zaliha = new ZalihaBasic();
        }

        public ZalihaForm(ZalihaBasic zaliha) : this()
        {
            this.zaliha = zaliha;
            LoadZalihaData();
        }

        private void InitializeForm()
        {
            // Form initialization logic will be in Designer file
            dtpDatumPoslednjeIsporuke.Value = DateTime.Today;
            LoadComboBoxData();
        }

        private void LoadComboBoxData()
        {
            try
            {
                // Load ProdajnaJedinica data
                var prodajneJedinice = DTOManagerIsporukeZalihe.VratiSveProdajneJedinice();
                cmbProdajnaJedinica.DataSource = prodajneJedinice;
                cmbProdajnaJedinica.DisplayMember = "Naziv";
                cmbProdajnaJedinica.ValueMember = "Id";

                // Load Pakovanje data
                var pakovanja = DTOManagerLek.VratiSvaPakovanja();
                cmbPakovanje.DataSource = null;
                cmbPakovanje.Items.Clear();
                
                foreach (var p in pakovanja)
                {
                    string displayText = $"{p.Lek.KomercijalniNaziv} - {p.VelicinaPakovanja} {p.JedinicaMere}";
                    cmbPakovanje.Items.Add(new { Value = p.Id, Text = displayText, Pakovanje = p });
                }
                
                cmbPakovanje.DisplayMember = "Text";
                cmbPakovanje.ValueMember = "Value";

                // Load Magacioneri data
                var magacioneri = DTOManagerIsporukeZalihe.VratiSveMagacionere();
                cmbOdgovorniMagacioner.DataSource = magacioneri;
                cmbOdgovorniMagacioner.DisplayMember = "Ime";
                cmbOdgovorniMagacioner.ValueMember = "MBr";
                cmbOdgovorniMagacioner.SelectedIndex = -1; // No selection by default
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju podataka za dropdown liste:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadZalihaData()
        {
            if (zaliha != null)
            {
                // Set ComboBox selections based on zaliha data
                cmbProdajnaJedinica.SelectedValue = zaliha.ProdajnaJedinicaId;
                
                // Find and select the packaging in the combo box
                for (int i = 0; i < cmbPakovanje.Items.Count; i++)
                {
                    dynamic item = cmbPakovanje.Items[i];
                    if (item.Value == zaliha.PakovanjeId)
                    {
                        cmbPakovanje.SelectedIndex = i;
                        break;
                    }
                }
                numKolicina.Value = zaliha.Kolicina;
                
                if (zaliha.DatumPoslednjeIsporuke.HasValue)
                    dtpDatumPoslednjeIsporuke.Value = zaliha.DatumPoslednjeIsporuke.Value;
                else
                    dtpDatumPoslednjeIsporuke.Value = DateTime.Today;
                
                if (zaliha.OdgovorniMagacionerMbr.HasValue)
                    cmbOdgovorniMagacioner.SelectedValue = zaliha.OdgovorniMagacionerMbr.Value;
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
            if (cmbProdajnaJedinica.SelectedValue == null)
            {
                MessageBox.Show("Morate selektovati prodajnu jedinicu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbProdajnaJedinica.Focus();
                return false;
            }

            if (cmbPakovanje.SelectedItem == null)
            {
                MessageBox.Show("Morate selektovati pakovanje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPakovanje.Focus();
                return false;
            }

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
                zaliha = new ZalihaBasic();
            }

            // Get values from ComboBox controls
            if (cmbProdajnaJedinica.SelectedValue == null)
            {
                MessageBox.Show("Morate selektovati prodajnu jedinicu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbPakovanje.SelectedItem == null)
            {
                MessageBox.Show("Morate selektovati pakovanje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            zaliha.ProdajnaJedinicaId = (long)cmbProdajnaJedinica.SelectedValue;
            zaliha.PakovanjeId = ((dynamic)cmbPakovanje.SelectedItem).Value;
            zaliha.Kolicina = (int)numKolicina.Value;
            zaliha.DatumPoslednjeIsporuke = dtpDatumPoslednjeIsporuke.Value;

            if (cmbOdgovorniMagacioner.SelectedValue != null)
            {
                zaliha.OdgovorniMagacionerMbr = (long)cmbOdgovorniMagacioner.SelectedValue;
            }
            else
            {
                zaliha.OdgovorniMagacionerMbr = null;
            }

            DTOManagerIsporukeZalihe.DodajZalihu(zaliha);
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
    }
}
