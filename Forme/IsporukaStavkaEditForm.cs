using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class IsporukaStavkaEditForm : Form
    {
        private IsporukaStavka isporukaStavka;

        public IsporukaStavkaEditForm(IsporukaStavka isporukaStavka)
        {
            if (isporukaStavka == null)
                throw new ArgumentNullException(nameof(isporukaStavka));

            InitializeComponent();
            this.isporukaStavka = isporukaStavka;
            LoadIsporukaStavkaData();
        }

        private void LoadIsporukaStavkaData()
        {
            // Učitavamo postojeće podatke
            if (isporukaStavka.Isporuka != null)
                txtIsporukaId.Text = isporukaStavka.Isporuka.Id.ToString();
            
            if (isporukaStavka.Pakovanje != null)
                txtPakovanjeId.Text = isporukaStavka.Pakovanje.Id.ToString();
            
            numKolicina.Value = isporukaStavka.Kolicina;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveIsporukaStavka();
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
            if (string.IsNullOrWhiteSpace(txtIsporukaId.Text))
            {
                MessageBox.Show("ID isporuke je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPakovanjeId.Text))
            {
                MessageBox.Show("ID pakovanja je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (numKolicina.Value <= 0)
            {
                MessageBox.Show("Količina mora biti veća od 0!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void SaveIsporukaStavka()
        {
            // Napomena: Referentne entitete (Isporuka, Pakovanje) treba postaviti spolja
            // jer ova forma samo prikazuje ID-ove
            isporukaStavka.Kolicina = (int)numKolicina.Value;
        }

        public IsporukaStavka GetIsporukaStavka()
        {
            return isporukaStavka;
        }
    }
}
