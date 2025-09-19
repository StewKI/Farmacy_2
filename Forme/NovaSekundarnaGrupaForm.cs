using Farmacy.Entiteti;
using System;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class NovaSekundarnaGrupaForm : Form
    {
        private SekundarnaKategorijaBasic sekundarnaGrupa;

        public NovaSekundarnaGrupaForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            sekundarnaGrupa = new SekundarnaKategorijaBasic();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            try
            {
                sekundarnaGrupa.Naziv = txtNaziv.Text.Trim();

                DTOManagerIsporukeZalihe.DodajSekundarnuGrupu(sekundarnaGrupa);

                MessageBox.Show("Sekundarna grupa je uspešno dodana!", "Uspeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju sekundarne grupe:\n" + ex.Message, "Greška",
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
                MessageBox.Show("Naziv sekundarne grupe je obavezan!", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNaziv.Focus();
                return false;
            }

            return true;
        }
    }
}



