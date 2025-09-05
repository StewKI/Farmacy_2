using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class PakovanjeForm : Form
    {
        private PakovanjeBasic pakovanje;
        private long idLek, idOblik;
        public PakovanjeForm(long id1,long id2)
        {
            InitializeComponent();
            pakovanje = new PakovanjeBasic();
            idLek = id1;
            idOblik = id2;
            LoadPakovanjeData();
        }

        public PakovanjeForm(PakovanjeBasic pakovanje)
        {
            InitializeComponent();
            this.pakovanje = pakovanje;
            LoadPakovanjeData();
        }

        private void LoadPakovanjeData()
        {
            txtLekId.Text=idLek.ToString();
            txtOblikId.Text=idOblik.ToString();
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
            pakovanje.LekId = idLek;
            pakovanje.OblikId = idOblik;

            DTOManagerLek.DodajPakovanje(pakovanje);

        }

        public PakovanjeBasic GetPakovanje()
        {
            return pakovanje;
        }
    }
}
