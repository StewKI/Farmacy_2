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
            lek.ProizvodjacId = long.Parse(txtProizvodjac.Text);

            string target = cmbPrimarnaGrupa.Text;

            //long id1= nadjiId(target);
            lek.PrimarnaGrupaId = list
                                .First(x => string.Equals(x.Naziv, target, StringComparison.OrdinalIgnoreCase))
                                   .Id;


            DTOManager.DodajLek(lek);
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

        private async Task LoadPrimarneGrupeAsync()
        {
            try
            {
                list = DTOManager.VratiPrimarneGrupe() ?? new List<PrimarnaGrupaBasic>();



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

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            SaveLek(); // popunjava lek objekt
        }
    }
}
