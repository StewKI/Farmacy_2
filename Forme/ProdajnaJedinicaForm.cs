using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class ProdajnaJedinicaForm : Form
    {
        private ProdajnaJedinicaBasic prodajnaJedinica;

        public ProdajnaJedinicaForm()
        {
            InitializeComponent();
            InitializeForm();
            SetupButtonEffects();
        }

        public ProdajnaJedinicaForm(ProdajnaJedinicaBasic prodajnaJedinica) : this()
        {
            this.prodajnaJedinica = prodajnaJedinica;
            LoadProdajnaJedinicaData();
        }

        private void InitializeForm()
        {
            IList<FarmaceutBasic> lista = DTOManagerZaposleni.VratiSveFarmaceute() ?? new List<FarmaceutBasic>();
            var nazivi = lista.Select(l => new { Text = $"{l.Ime} {l.Prezime}", Value = l.Id }).ToList();
            comboBox1.DataSource = nazivi;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
        }

        private void LoadProdajnaJedinicaData()
        {
            if (prodajnaJedinica != null)
            {
                txtNaziv.Text = prodajnaJedinica.Naziv;
                txtUlica.Text = prodajnaJedinica.Ulica;
                txtBroj.Text = prodajnaJedinica.Broj;
                txtPostanskiBroj.Text = prodajnaJedinica.PostanskiBroj;
                txtMesto.Text = prodajnaJedinica.Mesto;

                //if (prodajnaJedinica.OdgovorniFarmaceutMbr != null)
                   // txtOdgovorniFarmaceut.Text = prodajnaJedinica.OdgovorniFarmaceutMbr.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveProdajnaJedinica();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                MessageBox.Show("Naziv je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNaziv.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUlica.Text))
            {
                MessageBox.Show("Ulica je obavezna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUlica.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBroj.Text))
            {
                MessageBox.Show("Broj je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBroj.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPostanskiBroj.Text))
            {
                MessageBox.Show("Poštanski broj je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPostanskiBroj.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMesto.Text))
            {
                MessageBox.Show("Mesto je obavezno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMesto.Focus();
                return false;
            }

            return true;
        }

        private void SaveProdajnaJedinica()
        {
            if (prodajnaJedinica == null)
            {
                prodajnaJedinica = new ProdajnaJedinicaBasic();
            }

            prodajnaJedinica.Naziv = txtNaziv.Text.Trim();
            prodajnaJedinica.Ulica = txtUlica.Text.Trim();
            prodajnaJedinica.Broj = txtBroj.Text.Trim();
            prodajnaJedinica.PostanskiBroj = txtPostanskiBroj.Text.Trim();
            prodajnaJedinica.Mesto = txtMesto.Text.Trim();
            prodajnaJedinica.OdgovorniFarmaceutId = (long)comboBox1.SelectedValue;
            DTOManagerProdajneJedinice.DodajProdajnuJedinicu(prodajnaJedinica);

        }

        public ProdajnaJedinicaBasic GetProdajnaJedinica()
        {
            return prodajnaJedinica;
        }

        private void ProdajnaJedinicaForm_Load(object sender, EventArgs e)
        {

        }

        private void txtOdgovorniFarmaceut_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpravljajZaposlenima_Click(object sender, EventArgs e)
        {
            if (prodajnaJedinica == null || prodajnaJedinica.Id == 0)
            {
                MessageBox.Show("Morate prvo sačuvati prodajnu jedinicu pre upravljanja zaposlenima!", "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Otvori formu za raspored rada
            RasporedRadaForm form = new RasporedRadaForm(prodajnaJedinica.Id);
            form.ShowDialog();
        }

        private void SetupButtonEffects()
        {
            // Add hover effects to all buttons
            btnSave.MouseEnter += Button_MouseEnter;
            btnSave.MouseLeave += Button_MouseLeave;
            btnCancel.MouseEnter += Button_MouseEnter;
            btnCancel.MouseLeave += Button_MouseLeave;
            btnUpravljajZaposlenima.MouseEnter += Button_MouseEnter;
            btnUpravljajZaposlenima.MouseLeave += Button_MouseLeave;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                // Store original color and make button lighter
                button.BackColor = Color.FromArgb(
                    Math.Min(255, button.BackColor.R + 30),
                    Math.Min(255, button.BackColor.G + 30),
                    Math.Min(255, button.BackColor.B + 30)
                );
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                // Restore original color
                if (button == btnSave)
                    button.BackColor = Color.FromArgb(46, 204, 113);
                else if (button == btnCancel)
                    button.BackColor = Color.FromArgb(231, 76, 60);
                else if (button == btnUpravljajZaposlenima)
                    button.BackColor = Color.FromArgb(230, 126, 34);
            }
        }
    }
}
