using Farmacy.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class PakovanjeForm : Form
    {
        public PakovanjeForm()
        {
            InitializeComponent();
            this.Load += PakovanjeForm_Load;
        }

        private void PakovanjeForm_Load(object sender, EventArgs e)
        {
            popuniPodacimaPakovanja();
            LoadLekoviAsync();
            LoadOblikeAsync();
        }

        public void popuniPodacimaPakovanja()
        {
            try
            {
                IList<Pakovanje> lista = DTOManagerLek.VratiSvaPakovanja() ?? new List<Pakovanje>();

                dgvPakovanja.AutoGenerateColumns = false;
                dgvPakovanja.RowHeadersVisible = false;
                dgvPakovanja.DataSource = false;

                // Clear existing columns
                dgvPakovanja.Columns.Clear();

                // Add columns with proper data binding
                dgvPakovanja.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colId",
                    HeaderText = "ID",
                    DataPropertyName = "Id",
                    Width = 60
                });
                dgvPakovanja.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colLek",
                    HeaderText = "Lek",
                    DataPropertyName = "LekNaziv",
                    Width = 150
                });
                dgvPakovanja.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colOblik",
                    HeaderText = "Oblik",
                    DataPropertyName = "OblikNaziv",
                    Width = 100
                });
                dgvPakovanja.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colVelicina",
                    HeaderText = "Veličina",
                    DataPropertyName = "VelicinaPakovanja",
                    Width = 100
                });
                dgvPakovanja.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colKolicinaAktivne",
                    HeaderText = "Količina aktivne",
                    DataPropertyName = "KolicinaAktivne",
                    Width = 120
                });
                dgvPakovanja.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colJedinicaMere",
                    HeaderText = "Jedinica mere",
                    DataPropertyName = "JedinicaMere",
                    Width = 100
                });

                // Create a custom data source with flattened properties
                var customList = lista.Select(p => new
                {
                    Id = p.Id,
                    LekNaziv = p.Lek?.KomercijalniNaziv ?? "",
                    OblikNaziv = p.Oblik?.Naziv ?? "",
                    VelicinaPakovanja = p.VelicinaPakovanja,
                    KolicinaAktivne = p.KolicinaAktivne,
                    JedinicaMere = p.JedinicaMere,
                    // Keep reference to original entity for operations
                    OriginalEntity = p
                }).ToList();

                dgvPakovanja.DataSource = customList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju pakovanja:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadLekoviAsync()
        {
            try
            {
                var lekovi = DTOManagerLek.VratiSveLekove() ?? new List<LekBasic>();
                cmbLek.Items.Clear();
                cmbLek.Items.AddRange(lekovi.Select(l => l.KomercijalniNaziv).OrderBy(n => n).ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju lekova: " + ex.Message);
            }
        }

        private async void LoadOblikeAsync()
        {
            try
            {
                var oblici = DTOManagerLek.VratiSveOblikeLekova() ?? new List<Oblik>();
                cmbOblik.Items.Clear();
                cmbOblik.Items.AddRange(oblici.Select(o => o.Naziv).OrderBy(n => n).ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju oblika: " + ex.Message);
            }
        }

        private void btnNovoPakovanje_Click(object sender, EventArgs e)
        {
            NovoPakovanjeForm form = new NovoPakovanjeForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                popuniPodacimaPakovanja();
            }
        }

        private void btnObrisiPakovanje_Click(object sender, EventArgs e)
        {
            if (dgvPakovanja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate izabrati pakovanje prvo!");
                return;
            }

            long id = Convert.ToInt64(dgvPakovanja.CurrentRow.Cells[0].Value);

            var result = MessageBox.Show($"Da li ste sigurni da želite da obrišete pakovanje sa ID: {id}?",
                "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    DTOManagerLek.ObrisiPakovanje(id);
                    popuniPodacimaPakovanja();
                    MessageBox.Show("Pakovanje je uspešno obrisano!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri brisanju pakovanja:\n" + ex.Message, "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIzmeniPakovanje_Click(object sender, EventArgs e)
        {
            if (dgvPakovanja.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati pakovanje!");
                return;
            }

            // Get the original entity from the custom data source
            var selectedItem = dgvPakovanja.CurrentRow.DataBoundItem;
            var originalEntity = selectedItem.GetType().GetProperty("OriginalEntity")?.GetValue(selectedItem) as Pakovanje;

            if (originalEntity != null)
            {
                IzmeniPakovanjeForm form = new IzmeniPakovanjeForm(originalEntity);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    popuniPodacimaPakovanja();
                }
            }
            else
            {
                MessageBox.Show("Greška pri učitavanju podataka o pakovanju!");
            }
        }
    }
}