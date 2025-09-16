using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class RadnoVremeCreateForm : Form
    {
        private long prodajnaJedinicaId;
        private List<RadnoVremeBasic> radnaVremena;

        public RadnoVremeCreateForm(long prodajnaJedinicaId)
        {
            InitializeComponent();
            this.prodajnaJedinicaId = prodajnaJedinicaId;
            radnaVremena = new List<RadnoVremeBasic>();
        }

        private void RadnoVremeCreateForm_Load(object sender, EventArgs e)
        {
            LoadProdajnaJedinicaData();
            LoadDani();
            InitializeRadnoVremeList();
        }

        private void LoadProdajnaJedinicaData()
        {
            try
            {
                var prodajnaJedinica = DTOManagerProdajneJedinice.VratiProdajnuJedinicu(prodajnaJedinicaId);
                if (prodajnaJedinica != null)
                {
                    txtProdajnaJedinica.Text = prodajnaJedinica.Naziv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju prodajne jedinice: " + ex.Message, "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDani()
        {
            string[] dani = { "Ponedeljak", "Utorak", "Sreda", "Četvrtak", "Petak", "Subota", "Nedelja" };
            cboDan.Items.Clear();
            
            for (int i = 0; i < dani.Length; i++)
            {
                cboDan.Items.Add(dani[i]);
            }
        }

        private void InitializeRadnoVremeList()
        {
            // Kreiraj listu sa svim danima u nedelji
            string[] naziviDana = { "Ponedeljak", "Utorak", "Sreda", "Četvrtak", "Petak", "Subota", "Nedelja" };
            
            for (int i = 1; i <= 7; i++)
            {
                radnaVremena.Add(new RadnoVremeBasic
                {
                    Id = prodajnaJedinicaId * 100 + i,
                    ProdajnaJedinicaId = prodajnaJedinicaId,
                    Dan = i,
                    DanNaziv = naziviDana[i - 1],
                    VremeOd = (TimeSpan?)null,
                    VremeDo = (TimeSpan?)null,
                    ProdajnaJedinicaNaziv = txtProdajnaJedinica.Text
                });
            }
            
            dgvRadnoVreme.AutoGenerateColumns = false;
            dgvRadnoVreme.DataSource = radnaVremena;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            try
            {
                int danIndex = cboDan.SelectedIndex + 1; // SelectedIndex je 0-based, Dan je 1-based
                
                var radnoVreme = new RadnoVremeBasic
                {
                    Id = prodajnaJedinicaId * 100 + danIndex,
                    ProdajnaJedinicaId = prodajnaJedinicaId,
                    Dan = danIndex,
                    DanNaziv = cboDan.Text,
                    VremeOd = dtpVremeOd.Value.TimeOfDay,
                    VremeDo = dtpVremeDo.Value.TimeOfDay,
                    ProdajnaJedinicaNaziv = txtProdajnaJedinica.Text
                };

                DTOManagerProdajneJedinice.DodajRadnoVreme(radnoVreme);
                
                MessageBox.Show("Radno vreme je uspešno dodato!", "Uspeh", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Osveži listu
                RefreshRadnoVremeList();
                
                // Resetuj kontrole
                ResetControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju radnog vremena: " + ex.Message, "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvRadnoVreme.CurrentRow == null)
            {
                MessageBox.Show("Molimo odaberite radno vreme za brisanje!", "Upozorenje", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var radnoVreme = dgvRadnoVreme.CurrentRow.DataBoundItem as RadnoVremeBasic;
                if (radnoVreme != null)
                {
                    var result = MessageBox.Show($"Da li ste sigurni da želite da obrišete radno vreme za {radnoVreme.DanNaziv}?", 
                        "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (result == DialogResult.Yes)
                    {
                        DTOManagerProdajneJedinice.ObrisiRadnoVreme(radnoVreme.ProdajnaJedinicaId, radnoVreme.Dan);
                        
                        MessageBox.Show("Radno vreme je uspešno obrisano!", "Uspeh", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        RefreshRadnoVremeList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri brisanju radnog vremena: " + ex.Message, "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateForm()
        {
            if (cboDan.SelectedIndex == -1)
            {
                MessageBox.Show("Molimo odaberite dan!", "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dtpVremeOd.Value.TimeOfDay >= dtpVremeDo.Value.TimeOfDay)
            {
                MessageBox.Show("Vreme početka mora biti pre vremena završetka!", "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void RefreshRadnoVremeList()
        {
            try
            {
                var novaRadnaVremena = DTOManagerProdajneJedinice.VratiRadnoVremeZaProdajnuJedinicu(prodajnaJedinicaId);
                
                // Kreiraj kompletnu listu sa svim danima
                string[] naziviDana = { "Ponedeljak", "Utorak", "Sreda", "Četvrtak", "Petak", "Subota", "Nedelja" };
                var listaDana = new List<RadnoVremeBasic>();
                
                for (int i = 1; i <= 7; i++)
                {
                    var postojece = novaRadnaVremena.FirstOrDefault(rv => rv.Dan == i);
                    if (postojece != null)
                    {
                        listaDana.Add(postojece);
                    }
                    else
                    {
                        listaDana.Add(new RadnoVremeBasic
                        {
                            Id = prodajnaJedinicaId * 100 + i,
                            ProdajnaJedinicaId = prodajnaJedinicaId,
                            Dan = i,
                            DanNaziv = naziviDana[i - 1],
                            VremeOd = (TimeSpan?)null,
                            VremeDo = (TimeSpan?)null,
                            ProdajnaJedinicaNaziv = txtProdajnaJedinica.Text
                        });
                    }
                }
                
                radnaVremena.Clear();
                radnaVremena.AddRange(listaDana);
                dgvRadnoVreme.DataSource = null;
                dgvRadnoVreme.DataSource = radnaVremena;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri osvežavanju liste: " + ex.Message, "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetControls()
        {
            cboDan.SelectedIndex = -1;
            dtpVremeOd.Value = DateTime.Today.AddHours(8); // Podrazumevano 8:00
            dtpVremeDo.Value = DateTime.Today.AddHours(16); // Podrazumevano 16:00
        }
    }
}
