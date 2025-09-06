using System;
using System.Windows.Forms;
using Farmacy;
using Farmacy.Entiteti;

namespace Farmacy_2.Forme
{
    public partial class LekEditForm : Form
    {
        private LekBasic lek;
        private IList<PrimarnaGrupaBasic> list;
        private IList<ProizvodjacBasic> proizvodjaciList;
        private IList<SekundarnaKategorijaBasic> sekundarneKategorijeList;
        public LekEditForm(LekBasic lek)
        {
            InitializeComponent();
            this.lek = lek ?? throw new ArgumentNullException(nameof(lek));
            LoadLekData();
            LoadPrimarneGrupeAsync();
            LoadProizvodjaciAsync();
            LoadSekundarneKategorijeAsync();
        }

        private void LoadLekData()
        {
            txtId.Text = lek.Id.ToString();
            txtHemijski.Text = lek.HemijskiNaziv;
            txtKomercijalni.Text = lek.KomercijalniNaziv;
            txtDejstvo.Text = lek.Dejstvo ?? "";
            // Proizvodjac will be set in LoadProizvodjaciAsync after the ComboBox is populated

        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtHemijski.Text))
            {
                MessageBox.Show("Hemijski naziv je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHemijski.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtKomercijalni.Text))
            {
                MessageBox.Show("Komercijalni naziv je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKomercijalni.Focus();
                return false;
            }

            return true;
        }

        private void SaveLek()
        {
            if (lek == null)
            {
                lek = new LekBasic();
            }

            lek.HemijskiNaziv = txtHemijski.Text.Trim();
            lek.KomercijalniNaziv = txtKomercijalni.Text.Trim();
            lek.Dejstvo = string.IsNullOrWhiteSpace(txtDejstvo.Text) ? null : txtDejstvo.Text.Trim();
            // Get selected proizvodjac ID from ComboBox
            if (cmbProizvodjac.SelectedItem != null)
            {
                string selectedProizvodjac = cmbProizvodjac.SelectedItem.ToString();
                lek.ProizvodjacId = proizvodjaciList
                    .First(x => string.Equals(x.Naziv, selectedProizvodjac, StringComparison.OrdinalIgnoreCase))
                    .Id;
            }

            string target = cmbPrimarnaGrupa.Text;

            //long id1= nadjiId(target);
            lek.PrimarnaGrupaId = list
                                .First(x => string.Equals(x.Naziv, target, StringComparison.OrdinalIgnoreCase))
                                   .Id;

            // Get selected sekundarne kategorije from CheckedListBox
            lek.SekundarneKategorijeIds.Clear();
            for (int i = 0; i < chkListSekundarneKategorije.Items.Count; i++)
            {
                if (chkListSekundarneKategorije.GetItemChecked(i))
                {
                    string selectedKategorija = chkListSekundarneKategorije.Items[i].ToString();
                    var kategorija = sekundarneKategorijeList
                        .First(x => string.Equals(x.Naziv, selectedKategorija, StringComparison.OrdinalIgnoreCase));
                    lek.SekundarneKategorijeIds.Add(kategorija.Id);
                }
            }

            DTOManagerLek.IzmeniLek(lek);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveLek();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public LekBasic GetLek()
        {
            return lek;
        }

        private async Task LoadPrimarneGrupeAsync()
        {
            try
            {
                list = DTOManagerLek.VratiPrimarneGrupe() ?? new List<PrimarnaGrupaBasic>();



                cmbPrimarnaGrupa.Items.Clear();
                cmbPrimarnaGrupa.Items.AddRange(
                    list.Select(x => x.Naziv).OrderBy(n => n).ToArray()
                );
                cmbPrimarnaGrupa.SelectedIndex = 1;

                // čitanje

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju primarnih grupa: " + ex.Message);
            }
        }

        private async Task LoadProizvodjaciAsync()
        {
            try
            {
                proizvodjaciList = DTOManagerIsporukeZalihe.VratiSveProizvodjace() ?? new List<ProizvodjacBasic>();

                cmbProizvodjac.Items.Clear();
                cmbProizvodjac.Items.AddRange(
                    proizvodjaciList.Select(x => x.Naziv).OrderBy(n => n).ToArray()
                );
                
                // Set selected proizvodjac based on current lek.ProizvodjacId
                if (lek.ProizvodjacId > 0)
                {
                    var selectedProizvodjac = proizvodjaciList.FirstOrDefault(p => p.Id == lek.ProizvodjacId);
                    if (selectedProizvodjac != null)
                    {
                        cmbProizvodjac.SelectedItem = selectedProizvodjac.Naziv;
                    }
                }
                
                // Select first item if no specific selection
                if (cmbProizvodjac.SelectedIndex == -1 && cmbProizvodjac.Items.Count > 0)
                {
                    cmbProizvodjac.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju proizvođača: " + ex.Message);
            }
        }

        private async Task LoadSekundarneKategorijeAsync()
        {
            try
            {
                sekundarneKategorijeList = DTOManagerIsporukeZalihe.VratiSveSekundarneKategorije() ?? new List<SekundarnaKategorijaBasic>();

                chkListSekundarneKategorije.Items.Clear();
                chkListSekundarneKategorije.Items.AddRange(
                    sekundarneKategorijeList.Select(x => x.Naziv).OrderBy(n => n).ToArray()
                );
                
                // Set checked items based on current lek.SekundarneKategorijeIds
                if (lek.SekundarneKategorijeIds != null && lek.SekundarneKategorijeIds.Count > 0)
                {
                    for (int i = 0; i < chkListSekundarneKategorije.Items.Count; i++)
                    {
                        string kategorijaNaziv = chkListSekundarneKategorije.Items[i].ToString();
                        var kategorija = sekundarneKategorijeList.FirstOrDefault(k => k.Naziv == kategorijaNaziv);
                        if (kategorija != null && lek.SekundarneKategorijeIds.Contains(kategorija.Id))
                        {
                            chkListSekundarneKategorije.SetItemChecked(i, true);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju sekundarnih kategorija: " + ex.Message);
            }
        }

        private void LekEditForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbProizvodjac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
