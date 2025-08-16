using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class PakovanjeEditForm : Form
    {
        private Pakovanje pakovanje;

        public PakovanjeEditForm(Pakovanje pakovanje)
        {
            if (pakovanje == null)
                throw new ArgumentNullException(nameof(pakovanje));

            InitializeComponent();
            this.pakovanje = pakovanje;
            LoadPakovanjeData();
        }

        private void LoadPakovanjeData()
        {
            // Učitavamo postojeće podatke
            txtId.Text = pakovanje.Id.ToString();
            
            if (pakovanje.Lek != null)
                txtLekId.Text = pakovanje.Lek.Id.ToString();
            
            if (pakovanje.Oblik != null)
                txtOblikId.Text = pakovanje.Oblik.Id.ToString();
            
            txtVelicinaPakovanja.Text = pakovanje.VelicinaPakovanja;
            numKolicinaAktivne.Value = pakovanje.KolicinaAktivne;
            txtJedinicaMere.Text = pakovanje.JedinicaMere;
            
            if (!string.IsNullOrEmpty(pakovanje.Ambalaza))
                txtAmbalaza.Text = pakovanje.Ambalaza;
            
            if (!string.IsNullOrEmpty(pakovanje.NacinCuvanja))
                txtNacinCuvanja.Text = pakovanje.NacinCuvanja;
            
            if (pakovanje.PreporuceniRokDana.HasValue)
                numPreporuceniRokDana.Value = pakovanje.PreporuceniRokDana.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SavePakovanje();
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
            if (string.IsNullOrWhiteSpace(txtLekId.Text))
            {
                MessageBox.Show("ID leka je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtOblikId.Text))
            {
                MessageBox.Show("ID oblika je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtVelicinaPakovanja.Text))
            {
                MessageBox.Show("Veličina pakovanja je obavezna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (numKolicinaAktivne.Value <= 0)
            {
                MessageBox.Show("Količina aktivne materije mora biti veća od 0!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtJedinicaMere.Text))
            {
                MessageBox.Show("Jedinica mere je obavezna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void SavePakovanje()
        {
            if (long.TryParse(txtId.Text, out long id))
                pakovanje.Id = id;
            
            // Napomena: Referentne entitete (Lek, Oblik) treba postaviti spolja
            // jer ova forma samo prikazuje ID-ove
            
            pakovanje.VelicinaPakovanja = txtVelicinaPakovanja.Text.Trim();
            pakovanje.KolicinaAktivne = numKolicinaAktivne.Value;
            pakovanje.JedinicaMere = txtJedinicaMere.Text.Trim();
            pakovanje.Ambalaza = string.IsNullOrWhiteSpace(txtAmbalaza.Text) ? null : txtAmbalaza.Text.Trim();
            pakovanje.NacinCuvanja = string.IsNullOrWhiteSpace(txtNacinCuvanja.Text) ? null : txtNacinCuvanja.Text.Trim();
            pakovanje.PreporuceniRokDana = numPreporuceniRokDana.Value > 0 ? (int?)numPreporuceniRokDana.Value : null;
        }

        public Pakovanje GetPakovanje()
        {
            return pakovanje;
        }
    }
}
