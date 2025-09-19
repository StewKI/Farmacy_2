using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class ProizvodjacEditForm : Form
    {
        private ProizvodjacBasic proizvodjac;

        public ProizvodjacEditForm(ProizvodjacBasic proizvodjac)
        {
            InitializeComponent();
            this.proizvodjac = proizvodjac;
            LoadProizvodjacData();
            SetupButtonEffects();
        }

        private void LoadProizvodjacData()
        {
            txtId.Text = proizvodjac.Id.ToString();
            txtNaziv.Text = proizvodjac.Naziv;
            txtZemlja.Text = proizvodjac.Zemlja;
            txtTelefon.Text = proizvodjac.Telefon;
            txtEmail.Text = proizvodjac.Email;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveProizvodjac();
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
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                MessageBox.Show("Naziv je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtZemlja.Text))
            {
                MessageBox.Show("Zemlja je obavezna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                MessageBox.Show("Telefon je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void SaveProizvodjac()
        {
            proizvodjac.Naziv = txtNaziv.Text.Trim();
            proizvodjac.Zemlja = txtZemlja.Text.Trim();
            proizvodjac.Telefon = txtTelefon.Text.Trim();
            proizvodjac.Email = txtEmail.Text.Trim();

            try
            {
                DTOManagerIsporukeZalihe.IzmeniProizvodjaca(proizvodjac);
                MessageBox.Show("Proizvodjač je uspešno izmenjen!", "Uspešno", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri izmeni proizvodjača:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ProizvodjacBasic GetProizvodjac()
        {
            return proizvodjac;
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
                if (button == btnSave)
                {
                    button.BackColor = Color.FromArgb(46, 204, 113); // Tamnija zelena
                }
                else if (button == btnCancel)
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