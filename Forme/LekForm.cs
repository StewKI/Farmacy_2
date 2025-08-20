using System;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class LekForm : Form
    {
        private Lek lek;
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
        }

        public LekForm(Lek lek) : this()
        {
            this.lek = lek;
            LoadLekData();
        }

        private void InitializeForm()
        {
            // Form initialization logic will be in Designer file
        }

        private void LoadLekData()
        {
            if (lek != null)
            {
                txtId.Text = lek.Id.ToString();
                txtHemijskiNaziv.Text = lek.HemijskiNaziv;
                txtKomercijalniNaziv.Text = lek.KomercijalniNaziv;
                txtDejstvo.Text = lek.Dejstvo ?? string.Empty;
                
                if (lek.Proizvodjac != null)
                    txtProizvodjac.Text = lek.Proizvodjac.ToString();
                if (lek.PrimarnaGrupa != null)
                    txtPrimarnaGrupa.Text = lek.PrimarnaGrupa.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            SaveLek(); // popunjava lek objekt

            try
            {
                LekBasic lekBasic = ConvertToBasic(lek); // konverzija

                if (lek.Id == 0)
                {
                    DTOManager.DodajLek(lekBasic);
                }
                else
                {
                    DTOManager.IzmeniLek(lekBasic);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri čuvanju leka:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtHemijskiNaziv.Text))
            {
                MessageBox.Show("Hemijski naziv je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHemijskiNaziv.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtKomercijalniNaziv.Text))
            {
                MessageBox.Show("Komercijalni naziv je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKomercijalniNaziv.Focus();
                return false;
            }

            return true;
        }

        private void SaveLek()
        {
            if (lek == null)
            {
                lek = new Lek();
            }

            lek.HemijskiNaziv = txtHemijskiNaziv.Text.Trim();
            lek.KomercijalniNaziv = txtKomercijalniNaziv.Text.Trim();
            lek.Dejstvo = string.IsNullOrWhiteSpace(txtDejstvo.Text) ? null : txtDejstvo.Text.Trim();
        }

        public Lek GetLek()
        {
            return lek;
        }
    }
}
