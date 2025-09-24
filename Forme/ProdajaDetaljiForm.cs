using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Farmacy.Entiteti;

namespace Farmacy.Forme
{
    public partial class ProdajaDetaljiForm : Form
    {
        private Prodaja prodaja;

        public ProdajaDetaljiForm(long prodajaId)
        {
            InitializeComponent();
            LoadProdajaData(prodajaId);
            SetupButtonEffects();
        }

        private void LoadProdajaData(long prodajaId)
        {
            try
            {
                prodaja = DTOManagerIsporukeZalihe.VratiProdajuSaStavkama(prodajaId);
                
                if (prodaja == null)
                {
                    MessageBox.Show("Prodaja nije pronađena!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // Populate form with sale information
                lblProdajaId.Text = $"ID: {prodaja.Id}";
                lblProdajnaJedinica.Text = $"Prodajna jedinica: {prodaja.ProdajnaJedinica?.Naziv ?? "N/A"}";
                lblDatumVreme.Text = $"Datum i vreme: {prodaja.DatumVreme:dd.MM.yyyy HH:mm}";
                lblBlagajnik.Text = $"Blagajnik: {prodaja.Blagajnik?.Ime} {prodaja.Blagajnik?.Prezime}" ?? "N/A";
                
                // Calculate and display total
                decimal ukupnaVrednost = 0;
                if (prodaja.Stavke != null)
                {
                    foreach (var stavka in prodaja.Stavke)
                    {
                        if (stavka.Cena.HasValue)
                        {
                            ukupnaVrednost += stavka.Cena.Value * stavka.Kolicina;
                        }
                    }
                }
                lblUkupnaVrednost.Text = $"Ukupna vrednost: {ukupnaVrednost:C}";

                // Load sale items into DataGridView
                LoadSaleItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju podataka o prodaji:\n{ex.Message}", "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSaleItems()
        {
            try
            {
                var stavkeList = new List<object>();
                
                // Try to get items from the loaded sale first
                if (prodaja?.Stavke != null && prodaja.Stavke.Count > 0)
                {
                    foreach (var stavka in prodaja.Stavke)
                    {
                        stavkeList.Add(new
                        {
                            LekNaziv = stavka.Pakovanje?.Lek?.KomercijalniNaziv ?? "N/A",
                            Pakovanje = $"{stavka.Pakovanje?.VelicinaPakovanja} {stavka.Pakovanje?.JedinicaMere}",
                            Kolicina = stavka.Kolicina,
                            Cena = stavka.Cena ?? 0,
                            UkupnaCena = (stavka.Cena ?? 0) * stavka.Kolicina,
                            Recept = stavka.Recept?.SerijskiBroj ?? "Bez recepta",
                            KontrolisanaKol = stavka.KontrolisanaKol ?? 0,
                            ProcenatParticip = stavka.ProcenatParticip ?? 0,
                            NeophodanIzvestaj = stavka.NeophodanIzvestaj ?? "N"
                        });
                    }
                }
                else
                {
                    // Fallback: Load items directly from database
                    var stavke = DTOManagerIsporukeZalihe.VratiStavkeProdaje(prodaja.Id);
                    
                    foreach (var stavka in stavke)
                    {
                        stavkeList.Add(new
                        {
                            LekNaziv = stavka.Pakovanje?.Lek?.KomercijalniNaziv ?? "N/A",
                            Pakovanje = $"{stavka.Pakovanje?.VelicinaPakovanja} {stavka.Pakovanje?.JedinicaMere}",
                            Kolicina = stavka.Kolicina,
                            Cena = stavka.Cena ?? 0,
                            UkupnaCena = (stavka.Cena ?? 0) * stavka.Kolicina,
                            Recept = stavka.Recept?.SerijskiBroj ?? "Bez recepta",
                            KontrolisanaKol = stavka.KontrolisanaKol ?? 0,
                            ProcenatParticip = stavka.ProcenatParticip ?? 0,
                            NeophodanIzvestaj = stavka.NeophodanIzvestaj ?? "N"
                        });
                    }
                }

                dgvStavke.DataSource = stavkeList;
                dgvStavke.Refresh();
                
                // Show info if no items found
                if (stavkeList.Count == 0)
                {
                    MessageBox.Show("Ova prodaja nema stavki.", "Informacija", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju stavki prodaje:\n{ex.Message}", "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetupButtonEffects()
        {
            btnZatvori.MouseEnter += Button_MouseEnter;
            btnZatvori.MouseLeave += Button_MouseLeave;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.Tag = button.BackColor;
                button.BackColor = Color.FromArgb(200, 35, 51); // Darker red
                button.Cursor = Cursors.Hand;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is Color originalColor)
            {
                button.BackColor = originalColor;
                button.Cursor = Cursors.Default;
            }
        }
    }
}
