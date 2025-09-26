using System;
using System.Drawing;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class NoviReceptForm : Form
    {
        private Recept recept;
        private string originalSerijskiBroj;

        public NoviReceptForm()
        {
            InitializeComponent();
            this.Text = "Novi recept";
            InitializeForm();
            SetupButtonEffects();
        }

        public NoviReceptForm(Recept recept) : this()
        {
            this.recept = recept;
            this.originalSerijskiBroj = recept.SerijskiBroj; // Sačuvamo originalni serijski broj
            this.Text = "Izmena recepta";
            LoadReceptData();
        }

        private void InitializeForm()
        {
            // Form initialization logic will be in Designer file
            LoadStatusi();
        }

        private void LoadStatusi()
        {
            cboStatus.Items.Clear();
            cboStatus.Items.Add("IZDAT");
            cboStatus.Items.Add("CEKANJE");
            cboStatus.Items.Add("ODBIJEN");
        }

        private void LoadReceptData()
        {
            if (recept != null)
            {
                // Za postojeći recept, sakrijemo polje za serijski broj jer se ne može menjati
                lblSerijskiBroj.Visible = false;
                txtSerijskiBroj.Visible = false;
                
                // Postavljamo vrednosti za ostala polja
                txtSerijskiBroj.Text = recept.SerijskiBroj; // Zadržavamo vrednost za internal use
                txtSifraLekara.Text = recept.SifraLekara;
                dtpDatumIzd.Value = recept.DatumIzd;
                cboStatus.SelectedItem = recept.Status;
                txtNazivUstanove.Text = recept.NazivUstanove;
                
                // Ako ima dodatne podatke o realizaciji, prikaži ih
                if (recept.RealizovanaProdajnaJedinica != null)
                    txtRealizovanaProdajnaJedinica.Text = recept.RealizovanaProdajnaJedinica.Id.ToString();
                if (recept.RealizacijaDatum.HasValue)
                    dtpRealizacijaDatum.Value = recept.RealizacijaDatum.Value;
                if (recept.RealizovaoFarmaceut != null)
                    txtRealizovaoFarmaceut.Text = recept.RealizovaoFarmaceut.Id.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveRecept();
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
            bool isNewRecept = (recept == null);
            
            // Serijski broj je obavezan samo za nove recepte
            if (isNewRecept && string.IsNullOrWhiteSpace(txtSerijskiBroj.Text))
            {
                MessageBox.Show("Serijski broj je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSerijskiBroj.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSifraLekara.Text))
            {
                MessageBox.Show("Šifra lekara je obavezna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSifraLekara.Focus();
                return false;
            }

            if (cboStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Status je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboStatus.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNazivUstanove.Text))
            {
                MessageBox.Show("Naziv ustanove je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNazivUstanove.Focus();
                return false;
            }

            if (dtpDatumIzd.Value > DateTime.Now)
            {
                MessageBox.Show("Datum izdavanja ne može biti u budućnosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDatumIzd.Focus();
                return false;
            }

            return true;
        }

        private void SaveRecept()
        {
            bool isNewRecept = (recept == null);
            
            if (isNewRecept)
            {
                recept = new Recept();
                recept.SerijskiBroj = txtSerijskiBroj.Text.Trim(); // Serijski broj se postavlja samo za nove recepte
            }
            // Za postojeće recepte, serijski broj se ne menja (ostaje originalni)

            recept.SifraLekara = txtSifraLekara.Text.Trim();
            recept.DatumIzd = dtpDatumIzd.Value;
            recept.Status = cboStatus.SelectedItem.ToString();
            recept.NazivUstanove = txtNazivUstanove.Text.Trim();

            if (isNewRecept)
            {
                DTOManagerIsporukeZalihe.DodajRecept(recept);
            }
            else
            {
                DTOManagerIsporukeZalihe.AzurirajRecept(recept, originalSerijskiBroj);
            }
        }

        public Recept GetRecept()
        {
            return recept;
        }

        private void NoviReceptForm_Load(object sender, EventArgs e)
        {

        }

        private void dtpRealizacijaDatum_ValueChanged(object sender, EventArgs e)
        {

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
                if (button == btnSave)
                {
                    button.BackColor = Color.FromArgb(46, 204, 113); // Tamnija zelena
                }
                else if (button == btnCancel)
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
