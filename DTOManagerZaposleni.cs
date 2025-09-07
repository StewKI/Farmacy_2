using Farmacy.Entiteti;
using Farmacy.Forme;
using Farmacy_2.Forme;
using FluentNHibernate.Data;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy
{
    public static class DTOManagerZaposleni
    {
        // ========== ZAPOSLENI & PODTIPOVI ==========

        public static void DodajFarmaceuta(FarmaceutBasic dto,long idP,DateTime d)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var f = new Entiteti.FarmaceutBasic
                {
                    MBr = dto.MBr,
                    Ime = dto.Ime,
                    Prezime = dto.Prezime,
                    DatumRodj = dto.DatumRodj,
                    Adresa = dto.Adresa,
                    Telefon = dto.Telefon,
                    DatumZaposlenja = dto.DatumZaposlenja,
                    DatumDiplomiranja = dto.DatumDiplomiranja,
                    BrLicence = dto.BrLicence,
                    DatumPoslObnoveLicence = dto.DatumPoslednjeObnoveLicence,
                    Specijalnost = dto.Specijalnost
                };
                s.Save(f);
                s.Flush();

                var r = new RasporedRadaBasic();
                r.MBr = f.MBr;
                r.idProdajne = idP;
                r.Pocetak = dto.DatumZaposlenja;
                r.Kraj = d;
                DTOManagerZaposleni.DodajRasporedRada(r);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri dodavanju farmaceuta: {ex.Message}", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void UpdateFarmaceuta(FarmaceutBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();

                var farmaceut = s.Get<Entiteti.FarmaceutBasic>(dto.MBr);

                if (farmaceut == null)
                {
                    MessageBox.Show("Farmaceut sa datim MBr ne postoji!", "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                farmaceut.Ime = dto.Ime;
                farmaceut.Prezime = dto.Prezime;
                farmaceut.DatumRodj = dto.DatumRodj;
                farmaceut.Adresa = dto.Adresa;
                farmaceut.Telefon = dto.Telefon;
                farmaceut.DatumZaposlenja = dto.DatumZaposlenja;
                farmaceut.DatumDiplomiranja = dto.DatumDiplomiranja;
                farmaceut.BrLicence = dto.BrLicence;
                farmaceut.DatumPoslObnoveLicence = dto.DatumPoslednjeObnoveLicence;
                farmaceut.Specijalnost = dto.Specijalnost;

                s.Update(farmaceut);
                s.Flush();

                MessageBox.Show("Farmaceut uspešno ažuriran!", "Uspeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri ažuriranju farmaceuta: {ex.Message}", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void DodajTehnicara(TehnicarBasic dto,long idP,DateTime d)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var t = new Tehnicar
                {
                        //MBr = dto.MBr,
                    Ime = dto.Ime,
                    Prezime = dto.Prezime,
                    DatumRodj = dto.DatumRodj,
                    Adresa = dto.Adresa,
                    Telefon = dto.Telefon,
                    DatumZaposlenja = dto.DatumZaposlenja,
                    NivoObrazovanja = dto.NivoObrazovanja
                };
                s.Save(t);
                s.Flush();

                if (dto.Sertifikacije.Count > 0)
                {
                    foreach (var cert in dto.Sertifikacije)
                    {
                        var c = new TehnicarSertifikacija
                        {
                            Naziv = cert.Naziv,
                            Datum = cert.Datum,
                            Tehnicar = t
                        };
                        s.Save(c);
                    }
                }

                var r = new RasporedRadaBasic();
                r.MBr = t.MBr;
                r.idProdajne = idP;
                r.Pocetak = dto.DatumZaposlenja;
                r.Kraj = d;
                DTOManagerZaposleni.DodajRasporedRada(r);

                s.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri dodavanju tehničara: {ex.Message}", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void UpdateTehnicara(TehnicarBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();

                var tehnicar = s.Get<Tehnicar>(dto.MBr);

                if (tehnicar == null)
                {
                    MessageBox.Show("Tehničar sa datim MBr ne postoji!", "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tehnicar.Ime = dto.Ime;
                tehnicar.Prezime = dto.Prezime;
                tehnicar.DatumRodj = dto.DatumRodj;
                tehnicar.Adresa = dto.Adresa;
                tehnicar.Telefon = dto.Telefon;
                tehnicar.DatumZaposlenja = dto.DatumZaposlenja;
                tehnicar.NivoObrazovanja = dto.NivoObrazovanja;

                // Brišemo stare sertifikate
                //foreach (var stari in tehnicar.Sertifikacije.ToList())
                //{
                //    s.Delete(stari);
                //}

                // Dodajemo nove
                //foreach (var cert in dto.Sertifikacije)
                //{
                //    var c = new TehnicarSertifikacija
                //    {
                //        Naziv = cert.Naziv,
                //        Datum = cert.Datum,
                //        Tehnicar = tehnicar
                //    };
                //    s.Save(c);
                //}

                s.Update(tehnicar);
                s.Flush();

                MessageBox.Show("Tehničar uspešno ažuriran!", "Uspeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri ažuriranju tehničara: {ex.Message}", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void DodajMenadzera(MenadzerBasic dto,long idP,DateTime d)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var m = new Entiteti.MenadzerBasic
                {
                    MBr = dto.MBr,
                    Ime = dto.Ime,
                    Prezime = dto.Prezime,
                    DatumRodj = dto.DatumRodj,
                    Adresa = dto.Adresa,
                    Telefon = dto.Telefon,
                    DatumZaposlenja = dto.DatumZaposlenja
                };
                s.Save(m);
                s.Flush();

                var k = new MenadzerApotekaBasic
                {
                    MBrMenadzera = m.MBr,
                    ProdajnaJedinicaId = idP,
                    Od = dto.DatumZaposlenja,
                    Do =d,

                    datumKontrole =dto.DatumZaposlenja.AddDays(3),
                };
                DTOManagerZaposleni.DodajMenadzerApoteka(k);


                var r = new RasporedRadaBasic();
                r.MBr = m.MBr;
                r.idProdajne = idP;
                r.Pocetak = dto.DatumZaposlenja;
                r.Kraj = d;
                DTOManagerZaposleni.DodajRasporedRada(r);
            }
            catch (Exception)
            {
            }
        }

        public static void UpdateMenadzera(MenadzerBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();

                var menadzer = s.Get<Entiteti.MenadzerBasic>(dto.MBr);

                if (menadzer == null)
                {
                    MessageBox.Show("Menadžer sa datim MBr ne postoji!", "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                menadzer.Ime = dto.Ime;
                menadzer.Prezime = dto.Prezime;
                menadzer.DatumRodj = dto.DatumRodj;
                menadzer.Adresa = dto.Adresa;
                menadzer.Telefon = dto.Telefon;
                menadzer.DatumZaposlenja = dto.DatumZaposlenja;

                s.Update(menadzer);
                s.Flush();

                MessageBox.Show("Menadžer uspešno ažuriran!", "Uspeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri ažuriranju menadžera: {ex.Message}", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DodajZaposlenog(Zaposleni dto,long idP,DateTime d)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var m = new Zaposleni
                {
                    MBr = dto.MBr,
                    Ime = dto.Ime,
                    Prezime = dto.Prezime,
                    DatumRodj = dto.DatumRodj,
                    Adresa = dto.Adresa,
                    Telefon = dto.Telefon,
                    DatumZaposlenja = dto.DatumZaposlenja
                };
                s.Save(m);
                s.Flush();

                var r = new RasporedRadaBasic();
                r.MBr=m.MBr;
                r.idProdajne = idP;
                r.Pocetak=dto.DatumZaposlenja;
                r.Kraj = d;
                DTOManagerZaposleni.DodajRasporedRada(r);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
            $"Greška pri dodavanju zaposlenog: {ex.Message}",
            "Greška",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
            }
        }
        public static void UpdateZaposlenog(Zaposleni dto)
        {
            try
            {
                using var s = DataLayer.GetSession();

                // Pronađi postojećeg zaposlenog u bazi
                var zaposleni = s.Get<Zaposleni>(dto.MBr);

                if (zaposleni == null)
                {
                    MessageBox.Show(
                        "Zaposleni sa datim MBr ne postoji u bazi!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                // Ažuriraj polja
                zaposleni.Ime = dto.Ime;
                zaposleni.Prezime = dto.Prezime;
                zaposleni.DatumRodj = dto.DatumRodj;
                zaposleni.Adresa = dto.Adresa;
                zaposleni.Telefon = dto.Telefon;
                zaposleni.DatumZaposlenja = dto.DatumZaposlenja;

                // Sačuvaj izmene
                s.Update(zaposleni);
                s.Flush();

                MessageBox.Show(
                    "Podaci o zaposlenom su uspešno ažurirani!",
                    "Uspeh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Greška pri ažuriranju zaposlenog: {ex.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static ZaposleniBasic? VratiZaposlenog(long mbr)
        {
            try
            {
                using var s = DataLayer.GetSession();

                // NH polimorfno: prvo probaj specifičan tip
                var f = s.Get<Entiteti.FarmaceutBasic>(mbr);
                if (f != null)
                {
                    return new FarmaceutBasic
                    {
                        MBr = f.MBr,
                        Ime = f.Ime,
                        Prezime = f.Prezime,
                        DatumRodj = f.DatumRodj,
                        Adresa = f.Adresa,
                        Telefon = f.Telefon,
                        DatumZaposlenja = f.DatumZaposlenja,
                        DatumDiplomiranja = f.DatumDiplomiranja,
                        BrLicence = f.BrLicence,
                        DatumPoslednjeObnoveLicence = f.DatumPoslObnoveLicence,
                        Specijalnost = f.Specijalnost
                    };
                }

                var t = s.Get<Tehnicar>(mbr);
                if (t != null)
                {
                    var tb = new TehnicarBasic
                    {
                        MBr = t.MBr,
                        Ime = t.Ime,
                        Prezime = t.Prezime,
                        DatumRodj = t.DatumRodj,
                        Adresa = t.Adresa,
                        Telefon = t.Telefon,
                        DatumZaposlenja = t.DatumZaposlenja,
                        NivoObrazovanja = t.NivoObrazovanja
                    };

                    //var certs = s.Query<TehnicarSertifikacija>()
                    //             .Where(x => x.Tehnicar.MBr == t.MBr)
                    //             .Select(x => new TehnicarSertifikacijaBasic
                    //             {
                    //                 MBrTehnicara = x.Tehnicar.MBr,
                    //                 Naziv = x.Naziv,
                    //                 Datum = x.Datum
                    //             }).ToList();
                    //tb.Sertifikacije = certs;
                    return tb;
                }

                var m = s.Get<Entiteti.MenadzerBasic>(mbr);
                if (m != null)
                {
                    return new MenadzerBasic
                    {
                        MBr = m.MBr,
                        Ime = m.Ime,
                        Prezime = m.Prezime,
                        DatumRodj = m.DatumRodj,
                        Adresa = m.Adresa,
                        Telefon = m.Telefon,
                        DatumZaposlenja = m.DatumZaposlenja
                    };
                }

                var z = s.Get<Zaposleni>(mbr);
                if (z != null)
                {
                    return new ZaposleniBasic
                    {
                        MBr = z.MBr,
                        Ime = z.Ime,
                        Prezime = z.Prezime,
                        DatumRodj = z.DatumRodj,
                        Adresa = z.Adresa,
                        Telefon = z.Telefon,
                        DatumZaposlenja = z.DatumZaposlenja
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Greška pri izvlacenju zaposlenog iz baze: {ex.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return null;
        }

        public static Entiteti.FarmaceutBasic? VratiOdgovornogFarmaceuta(long id)
        {
            try
            {
                using var s = DataLayer.GetSession();

                var f = s.Get<Entiteti.FarmaceutBasic>(id); // ovde NE ide FarmaceutBasic
                if (f != null)
                {
                    return f;
                }

                return null; // ako nema farmaceuta
            }
            catch (Exception)
            {
                return null; // ako pukne nešto
            }
        }

        public static IList<ZaposleniBasic> VratiSveZaposlene()
        {
            var list = new List<ZaposleniBasic>();
            try
            {
                using var s = DataLayer.GetSession();
                var svi = s.Query<Zaposleni>().ToList();
                foreach (var z in svi)
                {
                    list.Add(new ZaposleniBasic
                    {
                        MBr = z.MBr,
                        Ime = z.Ime,
                        Prezime = z.Prezime,
                        DatumRodj = z.DatumRodj,
                        Adresa = z.Adresa,
                        Telefon = z.Telefon,
                        DatumZaposlenja = z.DatumZaposlenja
                    });
                }
            }
            catch (Exception) { }
            return list;
        }

        public static void ObrisiZaposlenog(long mbr)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var selektovaniZaposleni = VratiZaposlenog(mbr);
                
                if (selektovaniZaposleni is FarmaceutBasic faramaceut)
                {
                    var z = s.Get<Entiteti.FarmaceutBasic>(mbr);
                }
                else if (selektovaniZaposleni is TehnicarBasic tehnicar)
                {

                    var z = s.Get<Tehnicar>(mbr);

                }
                else if (selektovaniZaposleni is MenadzerBasic menadzer)
                {
                    var z = s.Get<Entiteti.MenadzerBasic>(mbr);

                }
                else
                {

                }
                

                var ras=s.Query<RasporedRada>().Where(r=>r.Zaposleni.MBr==mbr);

                if(ras!=null)
                {
                    s.Delete(ras);
                    s.Flush();
                }


                if (z != null)
                {
                    s.Delete(z);
                    s.Flush();
                }
            }
            catch (Exception) { }
        }

        public static void DodajRasporedRada(RasporedRadaBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var z = s.Get<Zaposleni>(dto.MBr);
                var p = s.Get<Entiteti.ProdajnaJedinicaBasic>(dto.idProdajne);

                var radnov = new RasporedRada
                {
                    Zaposleni = z,
                    ProdajnaJedinica = p,
                    Pocetak = dto.Pocetak,
                    Kraj = dto.Kraj,
                    BrojSmene = dto.BrojSmene,
                };

             
                s.Save(radnov);
                s.Flush();

                MessageBox.Show(
                    "Raspored rada kreiran",
                    "Uspeh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Greška pri kreiranju rasporeda rada: {ex.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void DodajMenadzerApoteka(MenadzerApotekaBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var m = s.Get<Entiteti.MenadzerBasic>(dto.MBrMenadzera);
                var p = s.Get<Entiteti.ProdajnaJedinicaBasic>(dto.ProdajnaJedinicaId);

                var radnov = new MenadzerApoteka
                {
                    Menadzer=m,
                    ProdajnaJedinica=p,
                    Do=dto.Do,
                    Od=dto.Od,
                    datumKontrole=dto.datumKontrole,
                };
                   


                s.Save(radnov);
                s.Flush();

                MessageBox.Show(
                    "Kontrola apoteke kreirana uspesno",
                    "Uspeh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Greška pri kreiranju kontrole apoteke: {ex.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

    }
  
}
