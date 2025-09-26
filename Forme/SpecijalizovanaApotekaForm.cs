using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class SpecijalizovanaApotekaForm : Form
    {
        private SpecijalizovanaApoteka specijalizovanaApoteka;

        public SpecijalizovanaApotekaForm()
        {
            InitializeComponent();
            InitializeForm();
            SetupButtonEffects();
        }

        public SpecijalizovanaApotekaForm(SpecijalizovanaApoteka specijalizovanaApoteka) : this()
        {
            this.specijalizovanaApoteka = specijalizovanaApoteka;
            LoadSpecijalizovanaApotekaData();
        }

        private void InitializeForm()
        {
            IList<FarmaceutBasic> lista = DTOManagerProdajneJedinice.VratiSveFarmaceuteUSistemu() ?? new List<FarmaceutBasic>();
            var nazivi = lista.Select(l => new { Text = l.Ime, Value = l.Id }).ToList();
            comboBox1.DataSource = nazivi;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
        }

        private void LoadSpecijalizovanaApotekaData()
        {
            if (specijalizovanaApoteka != null)
            {
                txtNaziv.Text = specijalizovanaApoteka.Naziv;
                txtUlica.Text = specijalizovanaApoteka.Ulica;
                txtBroj.Text = specijalizovanaApoteka.Broj;
                txtPostanskiBroj.Text = specijalizovanaApoteka.PostanskiBroj;
                txtMesto.Text = specijalizovanaApoteka.Mesto;
                txtSpecijalnostTipa.Text = specijalizovanaApoteka.SpecijalnostTipa ?? string.Empty;
                txtNapomena.Text = specijalizovanaApoteka.Napomena ?? string.Empty;

            
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveSpecijalizovanaApoteka();
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

            if (string.IsNullOrWhiteSpace(txtSpecijalnostTipa.Text))
            {
                MessageBox.Show("Specijalnost tipa je obavezna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSpecijalnostTipa.Focus();
                return false;
            }

            return true;
        }

        private void SaveSpecijalizovanaApoteka()
        {
            if (specijalizovanaApoteka == null)
            {
                specijalizovanaApoteka = new SpecijalizovanaApoteka();
            }

            specijalizovanaApoteka.Naziv = txtNaziv.Text.Trim();
            specijalizovanaApoteka.Ulica = txtUlica.Text.Trim();
            specijalizovanaApoteka.Broj = txtBroj.Text.Trim();
            specijalizovanaApoteka.PostanskiBroj = txtPostanskiBroj.Text.Trim();
            specijalizovanaApoteka.Mesto = txtMesto.Text.Trim();
            specijalizovanaApoteka.SpecijalnostTipa = txtSpecijalnostTipa.Text.Trim();
            specijalizovanaApoteka.Napomena = string.IsNullOrWhiteSpace(txtNapomena.Text) ? null : txtNapomena.Text.Trim();
            specijalizovanaApoteka.OdgovorniFarmaceut = DTOManagerZaposleni.VratiOdgovornogFarmaceuta((long)comboBox1.SelectedValue);

            DTOManagerProdajneJedinice.DodajSpecApoteku(specijalizovanaApoteka);
        }

        public SpecijalizovanaApoteka GetSpecijalizovanaApoteka()
        {
            return specijalizovanaApoteka;
        }

        private void SpecijalizovanaApotekaForm_Load(object sender, EventArgs e)
        {

        }

        private void SetupButtonEffects()
        {
            // Add hover effects to all buttons
            btnSave.MouseEnter += Button_MouseEnter;
            btnSave.MouseLeave += Button_MouseLeave;
            btnCancel.MouseEnter += Button_MouseEnter;
            btnCancel.MouseLeave += Button_MouseLeave;
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
            }
        }
    }
}
