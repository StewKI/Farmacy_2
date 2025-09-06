using Farmacy.Entiteti;
using System;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class IzmeniOblikForm : Form
    {
        private OblikBasic oblik;

        public IzmeniOblikForm(OblikBasic oblik)
        {
            InitializeComponent();
            this.oblik = oblik ?? throw new ArgumentNullException(nameof(oblik));
            LoadOblikData();
        }

        private void LoadOblikData()
        {
            txtId.Text = oblik.Id.ToString();
            txtNaziv.Text = oblik.Naziv;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            try
            {
                oblik.Naziv = txtNaziv.Text.Trim();

                DTOManagerLek.IzmeniOblik(oblik);

                MessageBox.Show("Oblik je uspešno izmenjen!", "Uspeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri izmeni oblika:\n" + ex.Message, "Greška",
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
                MessageBox.Show("Naziv oblika je obavezan!", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNaziv.Focus();
                return false;
            }

            return true;
        }
    }
}
