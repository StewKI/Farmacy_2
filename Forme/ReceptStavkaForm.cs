using Farmacy.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class ReceptStavkaForm : Form
    {
        private Recept recept;
        private IList<Pakovanje> pakovanjaList;

        public ReceptStavkaForm(Recept recept)
        {
            InitializeComponent();
            this.recept = recept ?? throw new ArgumentNullException(nameof(recept));
            this.Load += ReceptStavkaForm_Load;
        }

        private void ReceptStavkaForm_Load(object sender, EventArgs e)
        {
            LoadPakovanjaAsync();
            LoadReceptStavke();
        }

        private async void LoadPakovanjaAsync()
        {
            try
            {
                pakovanjaList = DTOManagerLek.VratiSvaPakovanja() ?? new List<Pakovanje>();

                cmbLek.Items.Clear();
                cmbLek.Items.AddRange(
                    pakovanjaList.Select(p => $"{p.Lek.KomercijalniNaziv} - {p.VelicinaPakovanja} {p.JedinicaMere}").OrderBy(n => n).ToArray()
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju pakovanja: " + ex.Message);
            }
        }

        private void LoadReceptStavke()
        {
            try
            {
                // Load existing prescription items for this prescription
                // This would need to be implemented in DTOManagerIsporukeZalihe
                // For now, we'll show a placeholder
                lblReceptInfo.Text = $"Recept: {recept.SerijskiBroj} - {recept.NazivUstanove}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju stavki recepta: " + ex.Message);
            }
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            try
            {
                if (cmbLek.SelectedItem == null)
                {
                    MessageBox.Show("Morate izabrati pakovanje!");
                    return;
                }

                string selectedPakovanje = cmbLek.SelectedItem.ToString();
                var pakovanje = pakovanjaList.FirstOrDefault(p => 
                    $"{p.Lek.KomercijalniNaziv} - {p.VelicinaPakovanja} {p.JedinicaMere}" == selectedPakovanje);

                if (pakovanje == null)
                {
                    MessageBox.Show("Greška pri pronalaženju pakovanja!");
                    return;
                }

                if (!int.TryParse(txtKolicina.Text, out int kolicina) || kolicina <= 0)
                {
                    MessageBox.Show("Količina mora biti pozitivan broj!");
                    return;
                }

                // Create new prescription item
                var stavka = new ReceptStavka
                {
                    Recept = recept,
                    Pakovanje = pakovanje,
                    Kolicina = kolicina
                };

                // Add to database
                DTOManagerIsporukeZalihe.DodajReceptStavku(stavka);

                MessageBox.Show("Stavka je uspešno dodana!", "Uspeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear form
                cmbLek.SelectedIndex = -1;
                txtKolicina.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju stavke:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpravljajPakovanjima_Click(object sender, EventArgs e)
        {
            PakovanjeForm form = new PakovanjeForm();
            form.ShowDialog();
            // Refresh the packaging list after closing the form
            LoadPakovanjaAsync();
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

            if (string.IsNullOrWhiteSpace(txtKolicina.Text))
            {
                MessageBox.Show("Količina je obavezna!", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKolicina.Focus();
                return false;
            }

            return true;
        }
    }
}