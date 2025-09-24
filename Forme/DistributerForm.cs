using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class DistributerForm : Form
    {
        private DistributerBasic distributer;

        public DistributerForm()
        {
            InitializeComponent();
            distributer = new DistributerBasic();
            LoadDistributerData();
            SetupButtonEffects();
        }

        public DistributerForm(DistributerBasic distributer)
        {
            InitializeComponent();
            this.distributer = distributer;
            LoadDistributerData();
            SetupButtonEffects();
        }

        private void LoadDistributerData()
        {
            txtId.Text = distributer.Id.ToString();
            txtNaziv.Text = distributer.Naziv;
            txtKontakt.Text = distributer.Kontakt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveDistributer();
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

            if (string.IsNullOrWhiteSpace(txtKontakt.Text))
            {
                MessageBox.Show("Kontakt je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void SaveDistributer()
        {
           

            distributer.Naziv = txtNaziv.Text.Trim();
            distributer.Kontakt = txtKontakt.Text.Trim();

            DTOManagerIsporukeZalihe.DodajDistributera(distributer);
        }

        public DistributerBasic GetDistributer()
        {
            return distributer;
        }

        private void DistributerForm_Load(object sender, EventArgs e)
        {

        }

        private void lblKontakt_Click(object sender, EventArgs e)
        {

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
