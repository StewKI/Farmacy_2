using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class RadnoVremeForm : Form
    {
        private long prodajnaJedinicaId;

        public RadnoVremeForm(long prodajnaJedinicaId)
        {
            InitializeComponent();
            this.prodajnaJedinicaId = prodajnaJedinicaId;
            
            // Proveri da li postoji radno vreme za ovu prodajnu jedinicu
            try
            {
                bool postojiRadnoVreme = DTOManagerProdajneJedinice.PostojiRadnoVremeZaProdajnuJedinicu(prodajnaJedinicaId);
                
                if (!postojiRadnoVreme)
                {
                    // Nema radnog vremena - otvori formu za kreiranje
                    RadnoVremeCreateForm createForm = new RadnoVremeCreateForm(prodajnaJedinicaId);
                    createForm.ShowDialog();
                    
                    // Nakon zatvaranja forme za kreiranje, zatvori i ovu formu
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri proveri radnog vremena:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }
            
            InitializeForm();
        }

        private void InitializeForm()
        {
            LoadRadnoVremeData();
        }

        private void LoadRadnoVremeData()
        {
            try
            {
                // Učitaj podatke o prodajnoj jedinici
                var prodajnaJedinica = DTOManagerProdajneJedinice.VratiProdajnuJedinicu(prodajnaJedinicaId);
                if (prodajnaJedinica != null)
                {
                    txtProdajnaJedinica.Text = prodajnaJedinica.Naziv;
                }

                // Učitaj radno vreme za prodajnu jedinicu
                var radnaVremena = DTOManagerProdajneJedinice.VratiRadnoVremeZaProdajnuJedinicu(prodajnaJedinicaId);
                
                // Kreiraj listu sa svim danima u nedelji
                var listaDana = new List<RadnoVremeBasic>();
                
                // Nazivi dana u nedelji
                string[] naziviDana = { "Ponedeljak", "Utorak", "Sreda", "Četvrtak", "Petak", "Subota", "Nedelja" };
                
                for (int i = 1; i <= 7; i++) // Dani su numerisani od 1 do 7
                {
                    var radnoVremeZaDan = radnaVremena?.FirstOrDefault(rv => rv.Dan == i);
                    
                    if (radnoVremeZaDan != null)
                    {
                        // Postoji radno vreme za ovaj dan
                        listaDana.Add(radnoVremeZaDan);
                    }
                    else
                    {
                        // Nema radnog vremena za ovaj dan - dodaj prazan red
                        listaDana.Add(new RadnoVremeBasic
                        {
                            Id = prodajnaJedinicaId * 100 + i, // Simulirani ID
                            ProdajnaJedinicaId = prodajnaJedinicaId,
                            Dan = i,
                            DanNaziv = naziviDana[i - 1],
                            VremeOd = (TimeSpan?)null,
                            VremeDo = (TimeSpan?)null,
                            ProdajnaJedinicaNaziv = prodajnaJedinica?.Naziv ?? ""
                        });
                    }
                }
                
                dgvRadnoVreme.AutoGenerateColumns = false;
                dgvRadnoVreme.DataSource = listaDana;

                // Dodaj kolone ako nisu već dodane
                if (dgvRadnoVreme.Columns.Count == 0)
                {
                    dgvRadnoVreme.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colId",
                        HeaderText = "ID",
                        DataPropertyName = "Id",
                        Width = 50,
                        Visible = false
                    });
                    dgvRadnoVreme.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colProdajnaJedinicaId",
                        HeaderText = "ProdajnaJedinicaId",
                        DataPropertyName = "ProdajnaJedinicaId",
                        Width = 50,
                        Visible = false
                    });
                    dgvRadnoVreme.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colDan",
                        HeaderText = "Dan",
                        DataPropertyName = "Dan",
                        Width = 50,
                        Visible = false
                    });
                    dgvRadnoVreme.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colDanNaziv",
                        HeaderText = "Dan",
                        DataPropertyName = "DanNaziv",
                        Width = 120
                    });
                    dgvRadnoVreme.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colVremeOd",
                        HeaderText = "Početak rada",
                        DataPropertyName = "VremeOd",
                        Width = 120
                    });
                    dgvRadnoVreme.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colVremeDo",
                        HeaderText = "Kraj rada",
                        DataPropertyName = "VremeDo",
                        Width = 120
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju radnog vremena:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvRadnoVreme.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati dan za izmenu!", "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                long prodajnaJedinicaId = Convert.ToInt64(dgvRadnoVreme.CurrentRow.Cells["colProdajnaJedinicaId"].Value);
                int dan = Convert.ToInt32(dgvRadnoVreme.CurrentRow.Cells["colDan"].Value);
                
                // Uvek pokušaj da učitamo radno vreme za taj dan
                var radnoVreme = DTOManagerProdajneJedinice.VratiRadnoVreme(prodajnaJedinicaId, dan);
                
                // Ako ne postoji, kreiraj novi DTO sa osnovnim podacima
                if (radnoVreme == null)
                {
                    string[] naziviDana = { "Ponedeljak", "Utorak", "Sreda", "Četvrtak", "Petak", "Subota", "Nedelja" };
                    radnoVreme = new RadnoVremeBasic
                    {
                        Id = prodajnaJedinicaId * 100 + dan,
                        ProdajnaJedinicaId = prodajnaJedinicaId,
                        Dan = dan,
                        DanNaziv = naziviDana[dan - 1],
                        VremeOd = (TimeSpan?)null,
                        VremeDo = (TimeSpan?)null,
                        ProdajnaJedinicaNaziv = txtProdajnaJedinica.Text
                    };
                }
                
                RadnoVremeEditForm editForm = new RadnoVremeEditForm(radnoVreme);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadRadnoVremeData(); // Osveži podatke
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju radnog vremena za izmenu:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
