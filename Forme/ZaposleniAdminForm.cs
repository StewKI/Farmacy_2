using Farmacy.Entiteti;
using Farmacy_2.Forme;
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
    public partial class ZaposleniAdminForm : Form
    {
        public int brojZaposlenih = 0;

        public ZaposleniAdminForm()
        {
            InitializeComponent();
            this.Load += ZaposleniPrikazForm_Load;
            SetupButtonEffects();
        }

        private void ZaposleniPrikazForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {


            try
            {
                // 1) Učitaj podatke
                IList<ZaposleniBasic> lista = DTOManagerZaposleni.VratiSveZaposlene() ?? new List<ZaposleniBasic>();

                // Debug info - uklonjen MessageBox

                // 2) Mapiraj kolone
                dgvZaposleni.AutoGenerateColumns = false;
                dgvZaposleni.Columns.Clear(); // Obriši sve postojeće kolone

                dgvZaposleni.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colId",
                    HeaderText = "Id",
                    DataPropertyName = "Id",
                    Width = 60
                });
                dgvZaposleni.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colMbr",
                    HeaderText = "MBr",
                    DataPropertyName = "MatBr",
                    Width = 90
                });
                dgvZaposleni.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colIme",
                    HeaderText = "Ime",
                    DataPropertyName = "Ime",
                    Width = 140
                });
                dgvZaposleni.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colPrezime",
                    HeaderText = "Prezime",
                    DataPropertyName = "Prezime",
                    Width = 160
                });
                dgvZaposleni.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colDatumRodj",
                    HeaderText = "Datum rođenja",
                    DataPropertyName = "DatumRodj",
                    Width = 120
                });
                dgvZaposleni.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colAdresa",
                    HeaderText = "Adresa",
                    DataPropertyName = "Adresa",
                    Width = 200
                });
                dgvZaposleni.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colTelefon",
                    HeaderText = "Telefon",
                    DataPropertyName = "Telefon",
                    Width = 120
                });
                dgvZaposleni.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colDatumZaposlenja",
                    HeaderText = "Datum zaposlenja",
                    DataPropertyName = "DatumZaposlenja",
                    Width = 120
                });

                // Omogući horizontalno skrolovanje
                dgvZaposleni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgvZaposleni.ScrollBars = ScrollBars.Both;

                // 3) Veži podatke
                dgvZaposleni.DataSource = false;   // osveži binding
                dgvZaposleni.DataSource = lista;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju zaposlenih:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBoxZaposleni_Enter(object sender, EventArgs e)
        {

        }



        private void btnObrisiZaposlenog_Click(object sender, EventArgs e)
        {
            long mbr = 0;
            if (dgvZaposleni.SelectedRows.Count > 0)
            {
                mbr = Convert.ToInt64(dgvZaposleni.CurrentRow.Cells[0].Value);
                MessageBox.Show("Selektovan MBr: " + mbr);

            }
            else
            {
                MessageBox.Show("Morate izabrati radnika prvo!");
                return;
            }
            DTOManagerZaposleni.ObrisiZaposlenog(mbr);
            popuniPodacima();

        }
        private void btnIzmeniZaposlenog_Click(object sender, EventArgs e)
        {
            if (dgvZaposleni.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati zaposlenog!");
                return;
            }
            long mbr = 0;
            if (dgvZaposleni.SelectedRows.Count > 0)
            {
                mbr = Convert.ToInt64(dgvZaposleni.CurrentRow.Cells[0].Value);
                MessageBox.Show("Selektovan MBr: " + mbr);

            }
            else
            {
                MessageBox.Show("Morate izabrati radnika prvo!");
                return;
            }

            // Get the employee with their specific type
            var zaposleni = DTOManagerZaposleni.VratiZaposlenog(mbr);

            if (zaposleni == null)
            {
                MessageBox.Show("Greška pri učitavanju podataka o zaposlenom!");
                return;
            }

            // Open appropriate edit form based on employee type
            if (zaposleni is FarmaceutBasic farmaceut)
            {
                FarmaceutEditForm form = new FarmaceutEditForm(farmaceut);
                form.ShowDialog();
            }
            else if (zaposleni is TehnicarBasic tehnicar)
            {
                TehnicarEditForm form = new TehnicarEditForm(tehnicar);
                form.ShowDialog();
            }
            else if (zaposleni is MenadzerBasic menadzer)
            {
                MenadzerEditForm form = new MenadzerEditForm(menadzer);
                form.ShowDialog();
            }
            else
            {
                // Fallback to generic form for basic employees
                IzmeniZaposlenogForm form = new IzmeniZaposlenogForm(mbr, 0);
                form.ShowDialog();
            }

            popuniPodacima();
        }
        private void btnDodajNovog_Click(object sender, EventArgs e)
        {


            OdaberiZaposlenogForm form = new OdaberiZaposlenogForm();
            form.ShowDialog();
            popuniPodacima();
        }

        private void ZaposleniAdminForm_Load(object sender, EventArgs e)
        {

        }

        public void updatePodatke<T>(IList<T> lista1)
        {
            try
            {

                // 2) Mapiraj kolone
                dgvZaposleni.AutoGenerateColumns = false;
                dgvZaposleni.Columns.Clear(); // Obriši sve postojeće kolone

                dgvZaposleni.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colId",
                    HeaderText = "Id",
                    DataPropertyName = "Id",
                    Width = 60
                });
                dgvZaposleni.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colMbr",
                    HeaderText = "MBr",
                    DataPropertyName = "MatBr",
                    Width = 90
                });
                dgvZaposleni.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colIme",
                    HeaderText = "Ime",
                    DataPropertyName = "Ime",
                    Width = 140
                });
                dgvZaposleni.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colPrezime",
                    HeaderText = "Prezime",
                    DataPropertyName = "Prezime",
                    Width = 160
                });
                dgvZaposleni.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colDatumRodj",
                    HeaderText = "Datum rođenja",
                    DataPropertyName = "DatumRodj",
                    Width = 120
                });
                dgvZaposleni.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colAdresa",
                    HeaderText = "Adresa",
                    DataPropertyName = "Adresa",
                    Width = 200
                });
                dgvZaposleni.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colTelefon",
                    HeaderText = "Telefon",
                    DataPropertyName = "Telefon",
                    Width = 120
                });
                dgvZaposleni.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colDatumZaposlenja",
                    HeaderText = "Datum zaposlenja",
                    DataPropertyName = "DatumZaposlenja",
                    Width = 120
                });

                // Omogući horizontalno skrolovanje
                dgvZaposleni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgvZaposleni.ScrollBars = ScrollBars.Both;

                // 3) Veži podatke
                dgvZaposleni.DataSource = false;   // osveži binding
                dgvZaposleni.DataSource = lista1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju zaposlenih:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void brnPrikaziFarmaceute_Click(object sender, EventArgs e)
        {
            try
            {
                // 1) Učitaj podatke
                IList<ZaposleniBasic> lista = DTOManagerZaposleni.VratiSveZaposlene() ?? new List<ZaposleniBasic>();
                IList<FarmaceutBasic> lista1 = new List<FarmaceutBasic>();
                foreach (var l in lista)
                {
                    var m = DTOManagerZaposleni.VratiZaposlenog(l.Id);
                    if (m is FarmaceutBasic f)
                        lista1.Add(f);
                }
                updatePodatke(lista1);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju zaposlenih:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrikaziSve_Click(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void brnPrikaziTehnicare_Click(object sender, EventArgs e)
        {
            try
            {
                // 1) Učitaj podatke
                IList<ZaposleniBasic> lista = DTOManagerZaposleni.VratiSveZaposlene() ?? new List<ZaposleniBasic>();
                IList<TehnicarBasic> lista1 = new List<TehnicarBasic>();
                foreach (var l in lista)
                {
                    var m = DTOManagerZaposleni.VratiZaposlenog(l.Id);
                    if (m is TehnicarBasic t)
                        lista1.Add(t);
                }
                updatePodatke(lista1);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju zaposlenih:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrikaziMenadzere_Click(object sender, EventArgs e)
        {
            try
            {
                // 1) Učitaj podatke
                IList<ZaposleniBasic> lista = DTOManagerZaposleni.VratiSveZaposlene() ?? new List<ZaposleniBasic>();
                IList<MenadzerBasic> lista1 = new List<MenadzerBasic>();
                foreach (var l in lista)
                {
                    var m = DTOManagerZaposleni.VratiZaposlenog(l.Id);
                    if (m is MenadzerBasic m1)
                        lista1.Add(m1);
                }
                updatePodatke(lista1);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju zaposlenih:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRasporedRada_Click(object sender, EventArgs e)
        {
            try
            {
                RasporedRadaForm form = new RasporedRadaForm();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri otvaranju forme za raspored rada: {ex.Message}", "Greška",
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
                if (button == btnDodajNovog)
                {
                    button.BackColor = Color.FromArgb(211, 84, 0); // Tamnija narandžasta
                }
                else if (button == btnIzmeniZaposlenog)
                {
                    button.BackColor = Color.FromArgb(41, 128, 185); // Tamnija plava
                }
                else if (button == btnObrisiZaposlenog)
                {
                    button.BackColor = Color.FromArgb(192, 57, 43); // Tamnija crvena
                }
                else if (button == brnPrikaziFarmaceute)
                {
                    button.BackColor = Color.FromArgb(39, 174, 96); // Tamnija zelena
                }
                else if (button == brnPrikaziTehnicare)
                {
                    button.BackColor = Color.FromArgb(142, 68, 173); // Tamnija ljubičasta
                }
                else if (button == btnPrikaziMenadzere)
                {
                    button.BackColor = Color.FromArgb(230, 126, 34); // Tamnija žuta
                }
                else if (button == btnPrikaziSve)
                {
                    button.BackColor = Color.FromArgb(125, 60, 152); // Tamnija ljubičasta
                }
                else if (button == btnRasporedRada)
                {
                    button.BackColor = Color.FromArgb(34, 153, 84); // Tamnija zelena
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

        private void dgvZaposleni_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
