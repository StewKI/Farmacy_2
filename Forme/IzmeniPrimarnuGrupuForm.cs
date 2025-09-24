using Farmacy.Entiteti;
using System;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class IzmeniPrimarnuGrupuForm : Form
    {
        private PrimarnaGrupaBasic primarnaGrupa;

        public IzmeniPrimarnuGrupuForm(PrimarnaGrupaBasic primarnaGrupa)
        {
            InitializeComponent();
            this.primarnaGrupa = primarnaGrupa ?? throw new ArgumentNullException(nameof(primarnaGrupa));
            LoadPrimarnaGrupaData();
            SetupButtonEffects();
        }

        private void LoadPrimarnaGrupaData()
        {
            txtId.Text = primarnaGrupa.Id.ToString();
            txtNaziv.Text = primarnaGrupa.Naziv;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            try
            {
                // Ažuriraj podatke
                primarnaGrupa.Naziv = txtNaziv.Text.Trim();

                // Sačuvaj u bazu
                DTOManagerLek.IzmeniPrimarnuGrupu(primarnaGrupa);

                MessageBox.Show("Primarna grupa je uspešno ažurirana!", "Uspeh", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri ažuriranju primarne grupe:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            if (txtNaziv.Text.Trim().Length < 2)
            {
                MessageBox.Show("Naziv primarne grupe mora imati najmanje 2 karaktera!", "Greška",
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
