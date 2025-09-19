using System;
using System.Windows.Forms;
using Farmacy.Entiteti;
using Microsoft.Data.SqlClient;

namespace Farmacy.Forme
{
    public partial class LekForm : Form
    {
        private LekBasic lek;
        private IList<PrimarnaGrupaBasic> list;
        private IList<ProizvodjacBasic> proizvodjaciList;
        private IList<SekundarnaKategorijaBasic> sekundarneKategorijeList;
        private LekBasic ConvertToBasic(Lek lek)
        {
            return new LekBasic
            {
                Id = lek.Id,
                HemijskiNaziv = lek.HemijskiNaziv,
                KomercijalniNaziv = lek.KomercijalniNaziv,
                Dejstvo = lek.Dejstvo,
                ProizvodjacId = lek.Proizvodjac?.Id ?? 0,
                PrimarnaGrupaId = lek.PrimarnaGrupa?.Id ?? 0,
                SekundarneKategorijeIds = new List<long>() // kasnije možeš dodati iz forme
            };
        }

        public LekForm()
        {
            InitializeComponent();
            InitializeForm();
            LoadPrimarneGrupeAsync();
            LoadProizvodjaciAsync();
            SetupButtonEffects();
            LoadSekundarneKategorijeAsync();
        }

        public LekForm(LekBasic lek) : this()
        {
            this.lek = lek;
            //LoadLekData();
        }

        private void InitializeForm()
        {
            // Form initialization logic will be in Designer file
        }

        //private void LoadLekData()
        //{
        //    if (lek != null)
        //    {
        //        txtId.Text = lek.Id.ToString();
        //        txtHemijskiNaziv.Text = lek.HemijskiNaziv;
        //        txtKomercijalniNaziv.Text = lek.KomercijalniNaziv;
        //        txtDejstvo.Text = lek.Dejstvo ?? string.Empty;

        //        if (lek.Proizvodjac != null)
        //            txtProizvodjac.Text = lek.Proizvodjac.ToString();
        //        if (lek.PrimarnaGrupa != null)
        //            txtPrimarnaGrupa.Text = lek.PrimarnaGrupa.ToString();
        //    }
        //}

      



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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

            DTOManagerLek.DodajLek(lek);
        }

        private long nadjiId(string naziv)
        {
            long id = 0;
            foreach(PrimarnaGrupaBasic x in list)
            {
                if(x.Naziv == naziv)
                {
                    id = x.Id; 
                    return id;
                }
            }
            return id;
        }

        public LekBasic GetLek()
        {
            return lek;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LekForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbPrimarnaGrupa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProizvodjac_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                
                // Select first item if available
                if (cmbProizvodjac.Items.Count > 0)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju sekundarnih kategorija: " + ex.Message);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            SaveLek(); // popunjava lek objekt
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
