using Farmacy.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class NovoPakovanjeForm : Form
    {
        private IList<LekBasic> lekoviList;
        private IList<Oblik> obliciList;

        public NovoPakovanjeForm()
        {
            InitializeComponent();
            this.Load += NovoPakovanjeForm_Load;
        }

        private void NovoPakovanjeForm_Load(object sender, EventArgs e)
        {
            LoadLekoviAsync();
            LoadOblikeAsync();
        }

        private async void LoadLekoviAsync()
        {
            try
            {
                lekoviList = DTOManagerLek.VratiSveLekove() ?? new List<LekBasic>();
                cmbLek.Items.Clear();
                cmbLek.Items.AddRange(lekoviList.Select(l => l.KomercijalniNaziv).OrderBy(n => n).ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju lekova: " + ex.Message);
            }
        }

        private async void LoadOblikeAsync()
        {
            try
            {
                obliciList = DTOManagerLek.VratiSveOblikeLekova() ?? new List<Oblik>();
                cmbOblik.Items.Clear();
                cmbOblik.Items.AddRange(obliciList.Select(o => o.Naziv).OrderBy(n => n).ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju oblika: " + ex.Message);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    var dto = new PakovanjeBasic
                    {
                        LekId = GetSelectedLekId(),
                        OblikId = GetSelectedOblikId(),
                        VelicinaPakovanja = txtVelicinaPakovanja.Text.Trim(),
                        KolicinaAktivne = decimal.Parse(txtKolicinaAktivne.Text),
                        JedinicaMere = txtJedinicaMere.Text.Trim(),
                        Ambalaza = txtAmbalaza.Text.Trim(),
                        NacinCuvanja = txtNacinCuvanja.Text.Trim(),
                        PreporuceniRokDana = string.IsNullOrEmpty(txtPreporuceniRokDana.Text) ? null : int.Parse(txtPreporuceniRokDana.Text)
                    };

                    DTOManagerLek.DodajPakovanje(dto);
                    MessageBox.Show("Pakovanje je uspešno dodano!", "Uspeh",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri dodavanju pakovanja:\n" + ex.Message, "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private long GetSelectedLekId()
        {
            if (cmbLek.SelectedItem != null)
            {
                string selectedLek = cmbLek.SelectedItem.ToString();
                var lek = lekoviList.FirstOrDefault(l => l.KomercijalniNaziv == selectedLek);
                return lek?.Id ?? 0;
            }
            return 0;
        }

        private long GetSelectedOblikId()
        {
            if (cmbOblik.SelectedItem != null)
            {
                string selectedOblik = cmbOblik.SelectedItem.ToString();
                var oblik = obliciList.FirstOrDefault(o => o.Naziv == selectedOblik);
                return oblik?.Id ?? 0;
            }
            return 0;
        }

        private bool ValidateForm()
        {
            if (cmbLek.SelectedIndex == -1)
            {
                MessageBox.Show("Morate izabrati lek!", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbLek.Focus();
                return false;
            }

            if (cmbOblik.SelectedIndex == -1)
            {
                MessageBox.Show("Morate izabrati oblik!", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbOblik.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtVelicinaPakovanja.Text))
            {
                MessageBox.Show("Veličina pakovanja je obavezna!", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVelicinaPakovanja.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtKolicinaAktivne.Text))
            {
                MessageBox.Show("Količina aktivne supstance je obavezna!", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKolicinaAktivne.Focus();
                return false;
            }

            if (!decimal.TryParse(txtKolicinaAktivne.Text, out decimal kolicina) || kolicina <= 0)
            {
                MessageBox.Show("Količina aktivne supstance mora biti pozitivan broj!", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKolicinaAktivne.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtJedinicaMere.Text))
            {
                MessageBox.Show("Jedinica mere je obavezna!", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJedinicaMere.Focus();
                return false;
            }

            if (!string.IsNullOrEmpty(txtPreporuceniRokDana.Text) && 
                (!int.TryParse(txtPreporuceniRokDana.Text, out int rok) || rok <= 0))
            {
                MessageBox.Show("Preporučeni rok dana mora biti pozitivan broj!", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPreporuceniRokDana.Focus();
                return false;
            }

            return true;
        }
    }
}
