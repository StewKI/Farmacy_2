using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class RasporedRadaForm : Form
    {
        private long? prodajnaJedinicaId;
        private long? selektovaniMBr;

        public RasporedRadaForm(long? prodajnaJedinicaId = null)
        {
            InitializeComponent();
            this.prodajnaJedinicaId = prodajnaJedinicaId;
            LoadProdajneJedinice();
            LoadZaposlene();
            LoadRasporedRada();
            SetupButtonEffects();
        }

        private void LoadZaposlene()
        {
            try
            {
                var zaposleni = DTOManagerZaposleni.VratiSveZaposlene();

                cmbZaposleni.DataSource = zaposleni;
                cmbZaposleni.DisplayMember = "Ime";
                cmbZaposleni.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju zaposlenih: {ex.Message}", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProdajneJedinice()
        {
            try
            {
                var prodajneJedinice = DTOManagerProdajneJedinice.VratiSveProdajneJedinice();

                cmbProdajnaJedinica.DataSource = prodajneJedinice;
                cmbProdajnaJedinica.DisplayMember = "Naziv";
                cmbProdajnaJedinica.ValueMember = "Id";

                // Postavi selektovanu prodajnu jedinicu ako je prosleđena
                if (prodajnaJedinicaId.HasValue)
                {
                    cmbProdajnaJedinica.SelectedValue = prodajnaJedinicaId.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju prodajnih jedinica: {ex.Message}", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRasporedRada()
        {
            try
            {
                IList<RasporedRadaBasic> raspored;

                if (prodajnaJedinicaId.HasValue)
                {
                    raspored = DTOManagerZaposleni.VratiRasporedRadaZaProdajnuJedinicu(prodajnaJedinicaId.Value);
                }
                else
                {
                    raspored = DTOManagerZaposleni.VratiSveRasporedeRada();
                }

                dgvRaspored.AutoGenerateColumns = false;
                dgvRaspored.DataSource = raspored;

                // Konfiguriši kolone sa eksplicitnim širinama
                if (dgvRaspored.Columns.Count == 0)
                {
                    dgvRaspored.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colMBr",
                        HeaderText = "MBr",
                        DataPropertyName = "MBr",
                        Width = 80
                    });
                    dgvRaspored.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colZaposleniIme",
                        HeaderText = "Ime",
                        DataPropertyName = "ZaposleniIme",
                        Width = 120
                    });
                    dgvRaspored.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colZaposleniPrezime",
                        HeaderText = "Prezime",
                        DataPropertyName = "ZaposleniPrezime",
                        Width = 120
                    });
                    dgvRaspored.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colProdajnaJedinicaNaziv",
                        HeaderText = "Prodajna jedinica",
                        DataPropertyName = "ProdajnaJedinicaNaziv",
                        Width = 200
                    });
                    dgvRaspored.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colPocetak",
                        HeaderText = "Početak",
                        DataPropertyName = "Pocetak",
                        Width = 150
                    });
                    dgvRaspored.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colKraj",
                        HeaderText = "Kraj",
                        DataPropertyName = "Kraj",
                        Width = 150
                    });
                    dgvRaspored.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colBrojSmene",
                        HeaderText = "Smena",
                        DataPropertyName = "BrojSmene",
                        Width = 80
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju rasporeda rada: {ex.Message}", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (cmbZaposleni.SelectedValue == null)
            {
                MessageBox.Show("Molimo odaberite zaposlenog!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbProdajnaJedinica.SelectedValue == null)
            {
                MessageBox.Show("Molimo odaberite prodajnu jedinicu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpPocetak.Value >= dtpKraj.Value)
            {
                MessageBox.Show("Datum početka mora biti pre datuma kraja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbSmena.SelectedIndex == -1)
            {
                MessageBox.Show("Molimo odaberite smenu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var raspored = new RasporedRadaBasic
                {
                    IdZaposlenog = (long)cmbZaposleni.SelectedValue,
                    ProdajnaJedinicaId = (long)cmbProdajnaJedinica.SelectedValue,
                    Pocetak = dtpPocetak.Value,
                    Kraj = dtpKraj.Value,
                    BrojSmene = cmbSmena.SelectedIndex + 1
                };

                DTOManagerZaposleni.DodajRasporedRada(raspored);
                LoadRasporedRada();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri dodavanju rasporeda rada: {ex.Message}", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvRaspored.CurrentRow == null)
            {
                MessageBox.Show("Molimo odaberite raspored rada za brisanje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var raspored = (RasporedRadaBasic)dgvRaspored.CurrentRow.DataBoundItem;

            var result = MessageBox.Show($"Da li ste sigurni da želite da obrišete raspored rada za {raspored.ZaposleniIme} {raspored.ZaposleniPrezime}?",
                "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DTOManagerZaposleni.ObrisiRasporedRada(raspored.IdZaposlenog, raspored.ProdajnaJedinicaId, raspored.Pocetak);
                LoadRasporedRada();
            }
        }

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            LoadRasporedRada();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            if (cmbProdajnaJedinica.SelectedValue != null)
            {
                prodajnaJedinicaId = (long)cmbProdajnaJedinica.SelectedValue;
            }
            else
            {
                prodajnaJedinicaId = null;
            }

            LoadRasporedRada();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvRaspored.CurrentRow == null)
            {
                MessageBox.Show("Molimo odaberite raspored rada za izmenu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var raspored = (RasporedRadaBasic)dgvRaspored.CurrentRow.DataBoundItem;

            // Popuni formu sa podacima za izmenu
            cmbZaposleni.SelectedValue = raspored.IdZaposlenog;
            cmbProdajnaJedinica.SelectedValue = raspored.ProdajnaJedinicaId;
            dtpPocetak.Value = raspored.Pocetak;
            dtpKraj.Value = raspored.Kraj;
            cmbSmena.SelectedIndex = raspored.BrojSmene.HasValue ? raspored.BrojSmene.Value - 1 : -1;

            MessageBox.Show("Podaci su učitani u formu za izmenu. Izmenite potrebne podatke i kliknite 'Dodaj' za snimanje izmena.",
                "Izmena rasporeda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "CSV fajlovi (*.csv)|*.csv|Excel fajlovi (*.xlsx)|*.xlsx";
                saveDialog.Title = "Izvezite raspored rada";
                saveDialog.FileName = $"RasporedRada_{DateTime.Now:yyyyMMdd}.csv";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Implementacija export-a (može se dodati kasnije)
                    MessageBox.Show($"Export funkcionalnost će biti implementirana u sledećoj verziji.\n\nOdabrani fajl: {saveDialog.FileName}",
                        "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri eksportu: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStampaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRaspored.Rows.Count == 0)
                {
                    MessageBox.Show("Nema podataka za štampanje!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Implementacija štampanja (može se dodati kasnije)
                MessageBox.Show("Štampanje funkcionalnost će biti implementirana u sledećoj verziji.",
                    "Štampanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri štampanju: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            cmbZaposleni.SelectedIndex = -1;
            dtpPocetak.Value = DateTime.Now;
            dtpKraj.Value = DateTime.Now.AddHours(8);
            cmbSmena.SelectedIndex = -1;
        }

        private void RasporedRadaForm_Load(object sender, EventArgs e)
        {
            // Postavi default vrednosti
            dtpPocetak.Value = DateTime.Now;
            dtpKraj.Value = DateTime.Now.AddHours(8);
        }

        private void SetupButtonEffects()
        {
            // Add hover effects to all buttons
            btnDodaj.MouseEnter += Button_MouseEnter;
            btnDodaj.MouseLeave += Button_MouseLeave;
            btnObrisi.MouseEnter += Button_MouseEnter;
            btnObrisi.MouseLeave += Button_MouseLeave;
            btnOsvezi.MouseEnter += Button_MouseEnter;
            btnOsvezi.MouseLeave += Button_MouseLeave;
            btnZatvori.MouseEnter += Button_MouseEnter;
            btnZatvori.MouseLeave += Button_MouseLeave;
            btnFiltriraj.MouseEnter += Button_MouseEnter;
            btnFiltriraj.MouseLeave += Button_MouseLeave;
            btnIzmeni.MouseEnter += Button_MouseEnter;
            btnIzmeni.MouseLeave += Button_MouseLeave;
            btnOcisti.MouseEnter += Button_MouseEnter;
            btnOcisti.MouseLeave += Button_MouseLeave;
            btnExport.MouseEnter += Button_MouseEnter;
            btnExport.MouseLeave += Button_MouseLeave;
            btnStampaj.MouseEnter += Button_MouseEnter;
            btnStampaj.MouseLeave += Button_MouseLeave;
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
                if (button == btnDodaj)
                    button.BackColor = Color.FromArgb(46, 204, 113);
                else if (button == btnObrisi)
                    button.BackColor = Color.FromArgb(231, 76, 60);
                else if (button == btnOsvezi)
                    button.BackColor = Color.FromArgb(155, 89, 182);
                else if (button == btnZatvori)
                    button.BackColor = Color.FromArgb(230, 126, 34);
                else if (button == btnFiltriraj)
                    button.BackColor = Color.FromArgb(52, 152, 219);
                else if (button == btnIzmeni)
                    button.BackColor = Color.FromArgb(52, 152, 219);
                else if (button == btnOcisti)
                    button.BackColor = Color.FromArgb(149, 165, 166);
                else if (button == btnExport)
                    button.BackColor = Color.FromArgb(155, 89, 182);
                else if (button == btnStampaj)
                    button.BackColor = Color.FromArgb(230, 126, 34);
            }
        }

        private void grpActions_Enter(object sender, EventArgs e)
        {

        }
    }
}
