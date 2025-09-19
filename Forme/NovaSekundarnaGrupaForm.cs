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
            SetupButtonEffects();
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

        private void SetupButtonEffects()
        {
            // Dodaj hover efekte za dugmad
            foreach (Control control in panelButtons.Controls)
            {
                if (control is Button button)
                {
                    button.MouseEnter += Button_MouseEnter;
                    button.MouseLeave += Button_MouseLeave;
                }
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                // Sačuvaj originalnu boju
                button.Tag = button.BackColor;
                
                // Promeni boju na hover
                if (button == btnSacuvaj)
                {
                    button.BackColor = Color.FromArgb(46, 204, 113); // Tamnija zelena
                }
                else if (button == btnOtkazi)
                {
                    button.BackColor = Color.FromArgb(231, 76, 60); // Tamnija crvena
                }
                
                button.Cursor = Cursors.Hand;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is Color originalColor)
            {
                // Vrati originalnu boju
                button.BackColor = originalColor;
                button.Cursor = Cursors.Default;
            }
        }
    }
}



