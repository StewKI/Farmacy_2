using System;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class IzmeniZaposlenogForm : Form
    {
        private long mbr;
        private long prodajnaJedinicaId;
        private string tipZaposlenog;

        public IzmeniZaposlenogForm(long mbr, long prodajnaJedinicaId)
        {
            InitializeComponent();
            this.mbr = mbr;
            this.prodajnaJedinicaId = prodajnaJedinicaId;
            LoadZaposleniData();
        }

        private void LoadZaposleniData()
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

                txtIme.Text = zaposleni.Ime;
                txtPrezime.Text = zaposleni.Prezime;
                dtpDatumRodj.Value = zaposleni.DatumRodj;
                txtAdresa.Text = zaposleni.Adresa ?? "";
                txtTelefon.Text = zaposleni.Telefon ?? "";
                dtpDatumZaposlenja.Value = zaposleni.DatumZaposlenja;

                // Proveri tip zaposlenog i učitaj specifične podatke
                if (zaposleni is FarmaceutBasic farmaceut)
                {
                    tipZaposlenog = "Farmaceut";
                    txtSpecijalnost.Text = farmaceut.Specijalnost ?? "";
                    txtBrLicence.Text = farmaceut.BrLicence ?? "";
                    dtpDatumDiplomiranja.Value = farmaceut.DatumDiplomiranja;
                    dtpDatumPoslObnoveLicence.Value = farmaceut.DatumPoslednjeObnoveLicence;
                    
                    // Prikaži farmaceut sekciju
                    pnlFarmaceut.Visible = true;
                    pnlTehnicar.Visible = false;
                    pnlMenadzer.Visible = false;
                }
                else if (zaposleni is TehnicarBasic tehnicar)
                {
                    tipZaposlenog = "Tehničar";
                    cmbNivo.Text = tehnicar.NivoObrazovanja ?? "";
                    
                    // Prikaži tehničar sekciju
                    pnlFarmaceut.Visible = false;
                    pnlTehnicar.Visible = true;
                    pnlMenadzer.Visible = false;
                }
                else if (zaposleni is MenadzerBasic menadzer)
                {
                    tipZaposlenog = "Menadžer";
                    
                    // Prikaži menadžer sekciju
                    pnlFarmaceut.Visible = false;
                    pnlTehnicar.Visible = false;
                    pnlMenadzer.Visible = true;
                }
                else
                {
                    tipZaposlenog = "Zaposleni";
                    
                    // Prikaži samo osnovne podatke
                    pnlFarmaceut.Visible = false;
                    pnlTehnicar.Visible = false;
                    pnlMenadzer.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju podataka zaposlenog: {ex.Message}", "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (tipZaposlenog == "Farmaceut")
                {
                    var farmaceut = new FarmaceutBasic
                    {
                        Id = mbr,
                        Ime = txtIme.Text.Trim(),
                        Prezime = txtPrezime.Text.Trim(),
                        DatumRodj = dtpDatumRodj.Value,
                        Adresa = string.IsNullOrWhiteSpace(txtAdresa.Text) ? null : txtAdresa.Text.Trim(),
                        Telefon = string.IsNullOrWhiteSpace(txtTelefon.Text) ? null : txtTelefon.Text.Trim(),
                        DatumZaposlenja = dtpDatumZaposlenja.Value,
                        DatumDiplomiranja = dtpDatumDiplomiranja.Value,
                        BrLicence = txtBrLicence.Text.Trim(),
                        DatumPoslednjeObnoveLicence = dtpDatumPoslObnoveLicence.Value,
                        Specijalnost = string.IsNullOrWhiteSpace(txtSpecijalnost.Text) ? null : txtSpecijalnost.Text.Trim()
                    };
                    DTOManagerZaposleni.UpdateFarmaceuta(farmaceut);
                }
                else if (tipZaposlenog == "Tehničar")
                {
                    var tehnicar = new TehnicarBasic
                    {
                        Id = mbr,
                        Ime = txtIme.Text.Trim(),
                        Prezime = txtPrezime.Text.Trim(),
                        DatumRodj = dtpDatumRodj.Value,
                        Adresa = string.IsNullOrWhiteSpace(txtAdresa.Text) ? null : txtAdresa.Text.Trim(),
                        Telefon = string.IsNullOrWhiteSpace(txtTelefon.Text) ? null : txtTelefon.Text.Trim(),
                        DatumZaposlenja = dtpDatumZaposlenja.Value,
                        NivoObrazovanja = cmbNivo.Text
                    };
                    DTOManagerZaposleni.UpdateTehnicara(tehnicar);
                }
                else if (tipZaposlenog == "Menadžer")
                {
                    var menadzer = new MenadzerBasic
                    {
                        Id = mbr,
                        Ime = txtIme.Text.Trim(),
                        Prezime = txtPrezime.Text.Trim(),
                        DatumRodj = dtpDatumRodj.Value,
                        Adresa = string.IsNullOrWhiteSpace(txtAdresa.Text) ? null : txtAdresa.Text.Trim(),
                        Telefon = string.IsNullOrWhiteSpace(txtTelefon.Text) ? null : txtTelefon.Text.Trim(),
                        DatumZaposlenja = dtpDatumZaposlenja.Value
                    };
                    DTOManagerZaposleni.UpdateMenadzera(menadzer);
                }

                MessageBox.Show("Zaposleni je uspešno ažuriran!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri ažuriranju zaposlenog: {ex.Message}", "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}