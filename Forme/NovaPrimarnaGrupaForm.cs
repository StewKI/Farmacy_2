using Farmacy.Entiteti;
using System;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class NovaPrimarnaGrupaForm : Form
    {
        private PrimarnaGrupaBasic primarnaGrupa;

        public NovaPrimarnaGrupaForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            primarnaGrupa = new PrimarnaGrupaBasic();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            try
            {
                primarnaGrupa.Naziv = txtNaziv.Text.Trim();

                DTOManagerLek.DodajPrimarnuGrupu(primarnaGrupa);

                MessageBox.Show("Primarna grupa je uspešno dodana!", "Uspeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju primarne grupe:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                MessageBox.Show("Naziv primarne grupe je obavezan!", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNaziv.Focus();
                return false;
            }

            return true;
        }
    }
}