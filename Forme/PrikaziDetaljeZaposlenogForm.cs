using System;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class PrikaziDetaljeZaposlenogForm : Form
    {
        private long mbr;
        private long prodajnaJedinicaId;

        public PrikaziDetaljeZaposlenogForm(long mbr, long prodajnaJedinicaId)
        {
            InitializeComponent();
            this.mbr = mbr;
            this.prodajnaJedinicaId = prodajnaJedinicaId;
            LoadZaposleniDetalji();
        }

        private void LoadZaposleniDetalji()
        {
            try
            {
                // Učitaj osnovne podatke o zaposlenom
                var zaposleni = DTOManagerZaposleni.VratiZaposlenog(mbr);
                if (zaposleni == null)
                {
                    MessageBox.Show("Zaposleni nije pronađen!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lblIme.Text = zaposleni.Ime;
                lblPrezime.Text = zaposleni.Prezime;
                lblMBr.Text = zaposleni.MBr.ToString();
                lblDatumRodj.Text = zaposleni.DatumRodj.ToShortDateString();
                lblAdresa.Text = zaposleni.Adresa ?? "Nije uneseno";
                lblTelefon.Text = zaposleni.Telefon ?? "Nije uneseno";
                lblDatumZaposlenja.Text = zaposleni.DatumZaposlenja.ToShortDateString();

                // Proveri tip zaposlenog i učitaj specifične podatke
                if (zaposleni is FarmaceutBasic farmaceut)
                {
                    lblTipZaposlenog.Text = "Farmaceut";
                    lblSpecijalnost.Text = farmaceut.Specijalnost ?? "Nije uneseno";
                    lblBrLicence.Text = farmaceut.BrLicence ?? "Nije uneseno";
                    lblDatumDiplomiranja.Text = farmaceut.DatumDiplomiranja.ToShortDateString();
                    lblDatumPoslObnoveLicence.Text = farmaceut.DatumPoslednjeObnoveLicence.ToShortDateString();
                    
                    // Prikaži farmaceut sekciju
                    pnlFarmaceut.Visible = true;
                    pnlTehnicar.Visible = false;
                    pnlMenadzer.Visible = false;
                }
                else if (zaposleni is TehnicarBasic tehnicar)
                {
                    lblTipZaposlenog.Text = "Tehničar";
                    lblNivoObrazovanja.Text = tehnicar.NivoObrazovanja ?? "Nije uneseno";
                    
                    // Prikaži tehničar sekciju
                    pnlFarmaceut.Visible = false;
                    pnlTehnicar.Visible = true;
                    pnlMenadzer.Visible = false;
                }
                else if (zaposleni is MenadzerBasic menadzer)
                {
                    lblTipZaposlenog.Text = "Menadžer";
                    
                    // Prikaži menadžer sekciju
                    pnlFarmaceut.Visible = false;
                    pnlTehnicar.Visible = false;
                    pnlMenadzer.Visible = true;
                }
                else
                {
                    lblTipZaposlenog.Text = "Zaposleni";
                    
                    // Prikaži samo osnovne podatke
                    pnlFarmaceut.Visible = false;
                    pnlTehnicar.Visible = false;
                    pnlMenadzer.Visible = false;
                }

                // Učitaj informacije o prodajnoj jedinici
                var prodajnaJedinica = DTOManagerProdajneJedinice.VratiProdajnuJedinicu(prodajnaJedinicaId);
                if (prodajnaJedinica != null)
                {
                    lblProdajnaJedinica.Text = prodajnaJedinica.Naziv;
                    lblDatumPocetka.Text = "N/A"; // Veza se više ne čuva
                    lblDatumKraja.Text = "N/A"; // Veza se više ne čuva
                }
                else
                {
                    lblProdajnaJedinica.Text = "Nepoznato";
                    lblDatumPocetka.Text = "N/A";
                    lblDatumKraja.Text = "N/A";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju detalja zaposlenog: {ex.Message}", "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
