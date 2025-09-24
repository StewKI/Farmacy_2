using Farmacy.Entiteti;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class ReceptForm : Form
    {
        public ReceptForm()
        {
            InitializeComponent();
            this.Load += ReceptForm_Load;
            SetupButtonEffects();
        }

        private void ReceptForm_Load(object sender, EventArgs e)
        {
            popuniPodacimaRecepti();
        }

        public void popuniPodacimaRecepti()
        {
            try
            {
                IList<Recept> lista = DTOManagerIsporukeZalihe.VratiSveRecepte() ?? new List<Recept>();

                dgvRecepti.AutoGenerateColumns = false;
                if (colId != null) colId.DataPropertyName = "Id";
                if (colSerijskiBroj != null) colSerijskiBroj.DataPropertyName = "SerijskiBroj";
                if (colSifraLekara != null) colSifraLekara.DataPropertyName = "SifraLekara";
                if (colDatumIzd != null) colDatumIzd.DataPropertyName = "DatumIzd";
                if (colStatus != null) colStatus.DataPropertyName = "Status";
                if (colNazivUstanove != null) colNazivUstanove.DataPropertyName = "NazivUstanove";
                dgvRecepti.RowHeadersVisible = false;
                dgvRecepti.DataSource = false;
                dgvRecepti.DataSource = lista;

                if (dgvRecepti.Columns.Count == 0)
                {
                    dgvRecepti.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colId",
                        HeaderText = "ID",
                        DataPropertyName = "Id",
                        Width = 60
                    });
                    dgvRecepti.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colSerijskiBroj",
                        HeaderText = "Serijski broj",
                        DataPropertyName = "SerijskiBroj",
                        Width = 120
                    });
                    dgvRecepti.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colSifraLekara",
                        HeaderText = "Šifra lekara",
                        DataPropertyName = "SifraLekara",
                        Width = 100
                    });
                    dgvRecepti.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colDatumIzd",
                        HeaderText = "Datum izdavanja",
                        DataPropertyName = "DatumIzd",
                        Width = 120
                    });
                    dgvRecepti.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colStatus",
                        HeaderText = "Status",
                        DataPropertyName = "Status",
                        Width = 80
                    });
                    dgvRecepti.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colNazivUstanove",
                        HeaderText = "Naziv ustanove",
                        DataPropertyName = "NazivUstanove",
                        Width = 200
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju recepata:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNoviRecept_Click(object sender, EventArgs e)
        {
            NoviReceptForm form = new NoviReceptForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                popuniPodacimaRecepti();
            }
        }

        private void btnObrisiRecept_Click(object sender, EventArgs e)
        {
            if (dgvRecepti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate izabrati recept prvo!");
                return;
            }

            string serijskiBroj = dgvRecepti.CurrentRow.Cells[1].Value.ToString(); // Serijski broj is in column 1

            var result = MessageBox.Show($"Da li ste sigurni da želite da obrišete recept sa serijskim brojem: {serijskiBroj}?",
                "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    DTOManagerIsporukeZalihe.ObrisiRecept(serijskiBroj);
                    popuniPodacimaRecepti();
                    MessageBox.Show("Recept je uspešno obrisan!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri brisanju recepta:\n" + ex.Message, "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIzmeniRecept_Click(object sender, EventArgs e)
        {
            if (dgvRecepti.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati recept!");
                return;
            }

            try
            {
                string serijskiBroj = dgvRecepti.CurrentRow.Cells[1].Value.ToString(); // Serijski broj is in column 1
                var selektovaniRecept = DTOManagerIsporukeZalihe.VratiRecept(serijskiBroj);

                if (selektovaniRecept != null)
                {
                    NoviReceptForm form = new NoviReceptForm(selektovaniRecept);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        popuniPodacimaRecepti();
                    }
                }
                else
                {
                    MessageBox.Show("Recept sa serijskim brojem " + serijskiBroj + " nije pronađen!", "Greška", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju podataka o receptu:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            if (dgvRecepti.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati recept prvo!");
                return;
            }

            try
            {
                string serijskiBroj = dgvRecepti.CurrentRow.Cells[1].Value.ToString(); // Serijski broj is in column 1
                var selektovaniRecept = DTOManagerIsporukeZalihe.VratiRecept(serijskiBroj);

                if (selektovaniRecept != null)
                {
                    ReceptStavkaForm form = new ReceptStavkaForm(selektovaniRecept);
                    form.ShowDialog();
                    popuniPodacimaRecepti();
                }
                else
                {
                    MessageBox.Show("Recept sa serijskim brojem " + serijskiBroj + " nije pronađen!", "Greška", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju podataka o receptu:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRealizujRecept_Click(object sender, EventArgs e)
        {
            if (dgvRecepti.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati recept prvo!");
                return;
            }

            try
            {
                string serijskiBroj = dgvRecepti.CurrentRow.Cells[1].Value.ToString(); // Serijski broj is in column 1
                var selektovaniRecept = DTOManagerIsporukeZalihe.VratiRecept(serijskiBroj);

                if (selektovaniRecept != null)
                {
                    var result = MessageBox.Show($"Da li ste sigurni da želite da realizujete recept sa serijskim brojem: {serijskiBroj}?",
                        "Potvrda realizacije", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            // For now, we'll use a default sales unit and current date
                            // In a real application, you'd want to let the user select these
                            var defaultProdajnaJedinica = new ProdajnaJedinicaBasic
                            {
                                Id = 1, // Default ID - you might want to get this from user selection
                                Naziv = "Glavna apoteka" // Default name
                            };
                            
                            DTOManagerIsporukeZalihe.RealizujRecept(serijskiBroj, defaultProdajnaJedinica, DateTime.Now);
                            popuniPodacimaRecepti();
                            MessageBox.Show("Recept je uspešno realizovan!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Greška pri realizaciji recepta:\n" + ex.Message, "Greška",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Recept sa serijskim brojem " + serijskiBroj + " nije pronađen!", "Greška", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju podataka o receptu:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                if (button == btnNoviRecept)
                {
                    button.BackColor = Color.FromArgb(46, 204, 113); // Tamnija zelena
                }
                else if (button == btnObrisiRecept)
                {
                    button.BackColor = Color.FromArgb(231, 76, 60); // Tamnija crvena
                }
                else if (button == btnIzmeniRecept)
                {
                    button.BackColor = Color.FromArgb(52, 152, 219); // Tamnija plava
                }
                else if (button == btnDodajStavku)
                {
                    button.BackColor = Color.FromArgb(230, 126, 34); // Tamnija narandžasta
                }
                else if (button == btnRealizujRecept)
                {
                    button.BackColor = Color.FromArgb(39, 174, 96); // Tamnija zelena
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
