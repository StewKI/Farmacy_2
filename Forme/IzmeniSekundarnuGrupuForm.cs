using Farmacy.Entiteti;
using System;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class IzmeniSekundarnuGrupuForm : Form
    {
        private SekundarnaKategorijaBasic sekundarnaGrupa;

        public IzmeniSekundarnuGrupuForm(SekundarnaKategorijaBasic sekundarnaGrupa)
        {
            InitializeComponent();
            this.sekundarnaGrupa = sekundarnaGrupa ?? throw new ArgumentNullException(nameof(sekundarnaGrupa));
            LoadSekundarnaGrupaData();
        }

        private void LoadSekundarnaGrupaData()
        {
            txtId.Text = sekundarnaGrupa.Id.ToString();
            txtNaziv.Text = sekundarnaGrupa.Naziv;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            try
            {
                sekundarnaGrupa.Naziv = txtNaziv.Text.Trim();

                DTOManagerIsporukeZalihe.IzmeniSekundarnuGrupu(sekundarnaGrupa);

                MessageBox.Show("Sekundarna grupa je uspešno izmenjena!", "Uspeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri izmeni sekundarne grupe:\n" + ex.Message, "Greška",
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



