using Farmacy.Entiteti;
using FluentNHibernate.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy
{
    public static class DTOManagerLek
    {
        // ========== PROIZVOĐAČ / GRUPE / LEK / OBLIK / PAKOVANJE ==========

        public static long DodajProizvodjaca(ProizvodjacBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var p = new Proizvodjac
                {
                    Naziv = dto.Naziv,
                    Zemlja = dto.Zemlja,
                    Telefon = dto.Telefon,
                    Email = dto.Email
                };
                s.Save(p);
                s.Flush();
                dto.Id = p.Id;
                return p.Id;
            }
            catch (Exception) { }
            return 0;
        }

        public static long DodajPrimarnuGrupu(PrimarnaGrupaBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var g = new PrimarnaGrupa { Naziv = dto.Naziv };
                s.Save(g);
                s.Flush();
                dto.Id = g.Id;
                return g.Id;
            }
            catch (Exception) { }
            return 0;
        }

        public static long DodajSekundarnuKategoriju(SekundarnaKategorijaBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var k = new SekundarnaKategorija { Naziv = dto.Naziv };
                s.Save(k);
                s.Flush();
                dto.Id = k.Id;
                return k.Id;
            }
            catch (Exception ex) {
                MessageBox.Show(
                      $"Greška pri dodavanju nove sekundarne kategorije : {ex.Message}",
                      "Greška",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
            }
            return 0;
        }

        public static long DodajLek(LekBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var lek = new Lek
                {
                    HemijskiNaziv = dto.HemijskiNaziv,
                    KomercijalniNaziv = dto.KomercijalniNaziv,
                    Dejstvo = dto.Dejstvo,
                    Proizvodjac = s.Load<Proizvodjac>(dto.ProizvodjacId),
                    PrimarnaGrupa = s.Load<PrimarnaGrupa>(dto.PrimarnaGrupaId)
                };
                s.Save(lek);

                // M:N sekundarne kategorije
                if (dto.SekundarneKategorijeIds.Count>0)
                {
                    foreach (var kid in dto.SekundarneKategorijeIds.Distinct())
                    {
                        var kat = s.Load<SekundarnaKategorija>(kid);
                        var ls = new LekSekundarna
                        {
                            Lek = lek,
                            Kategorija = kat,
                        };
                        s.Save(ls);
                    }
                }
                

                s.Flush();
                dto.Id = lek.Id;
                return lek.Id;
            }
            catch (Exception ex) {
                MessageBox.Show(
                   $"Greška pri dodavanju novog leka : {ex.Message}",
                   "Greška",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);

            }
            return 0;
        }

        public static long DodajOblik(OblikBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var o = new Oblik { Naziv = dto.Naziv };
                s.Save(o);
                s.Flush();
                dto.Id = o.Id;
                return o.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                   $"Greška pri dodavanju novog oblika leka : {ex.Message}",
                   "Greška",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            return 0;
        }

        public static long DodajPakovanje(PakovanjeBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var p = new Pakovanje
                {
                    Lek = s.Load<Lek>(dto.LekId),
                    Oblik = s.Load<Oblik>(dto.OblikId),
                    VelicinaPakovanja = dto.VelicinaPakovanja,
                    KolicinaAktivne = dto.KolicinaAktivne,
                    JedinicaMere = dto.JedinicaMere,
                    Ambalaza = dto.Ambalaza,
                    NacinCuvanja = dto.NacinCuvanja,
                    PreporuceniRokDana = dto.PreporuceniRokDana                    
                };
                s.Save(p);
                s.Flush();
                dto.Id = p.Id;
                return p.Id;
            }
            catch (Exception ex) {
                MessageBox.Show(
                   $"Greška pri dodavanju novog pakovanja: {ex.Message}",
                   "Greška",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            return 0;
        }

        // Dodajte ove metode u DTOManager klasu
        public static Farmacy.Entiteti.Lek? VratiLekEntitet(long id)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var lek = s.Get<Lek>(id);
                return lek; // Vraća direktno entitet
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju leka: {ex.Message}", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        public static LekBasic? VratiLek(long id)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var lek = s.Get<Lek>(id);
                if (lek == null) return null;

                // Učitaj sekundarne kategorije
                var secIds = s.Query<LekSekundarna>()
                              .Where(x => x.Lek.Id == id)
                              .Select(x => x.Kategorija.Id)
                              .ToList();

                return new LekBasic
                {
                    Id = lek.Id,
                    HemijskiNaziv = lek.HemijskiNaziv,
                    KomercijalniNaziv = lek.KomercijalniNaziv,
                    Dejstvo = lek.Dejstvo,
                    ProizvodjacId = lek.Proizvodjac.Id,
                    PrimarnaGrupaId = lek.PrimarnaGrupa.Id,
                    SekundarneKategorijeIds = secIds
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju leka: {ex.Message}", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        public static IList<LekBasic> VratiSveLekove()
        {
            var list = new List<LekBasic>();
            try
            {
                using var s = DataLayer.GetSession();
                var lekovi = s.Query<Lek>().ToList();
                foreach (var l in lekovi)
                {
                    var secIds = s.Query<LekSekundarna>()
                                  .Where(x => x.Lek.Id == l.Id)
                                  .Select(x => x.Kategorija.Id)
                                  .ToList();

                    list.Add(new LekBasic
                    {
                        Id = l.Id,
                        HemijskiNaziv = l.HemijskiNaziv,
                        KomercijalniNaziv = l.KomercijalniNaziv,
                        Dejstvo = l.Dejstvo,
                        ProizvodjacId = l.Proizvodjac.Id,
                        PrimarnaGrupaId = l.PrimarnaGrupa.Id,
                        SekundarneKategorijeIds = secIds
                    });
                }
            }
            catch (Exception) { }
            return list;
        }
        public static IList<Oblik> VratiSveOblikeLekova()
        {
            var list = new List<Oblik>();
            try
            {
                using var s = DataLayer.GetSession();
                var lekovi = s.Query<Oblik>().ToList();

                foreach (var l in lekovi)
                {
                    list.Add(new Oblik
                    {
                        Id = l.Id,
                        Naziv =l.Naziv,

                    });
                }
                    
                
            }
            catch (Exception) { }
            return list;
        }
        public static void IzmeniLek(LekBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var lek = s.Get<Lek>(dto.Id);

                if (lek == null)
                {
                    MessageBox.Show("Lek sa datim ID ne postoji!", "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ažuriraj osnovne podatke
                lek.HemijskiNaziv = dto.HemijskiNaziv;
                lek.KomercijalniNaziv = dto.KomercijalniNaziv;
                lek.Dejstvo = dto.Dejstvo;
                lek.Proizvodjac = s.Load<Proizvodjac>(dto.ProizvodjacId);
                lek.PrimarnaGrupa = s.Load<PrimarnaGrupa>(dto.PrimarnaGrupaId);

                // Obriši stare sekundarne kategorije
                if(lek.Sekundarne.Count>0)
                {
                    var stareSekundarne = s.Query<LekSekundarna>()
                                       .Where(x => x.Lek.Id == dto.Id)
                                       .ToList();
                    foreach (var ls in stareSekundarne)
                    {
                        s.Delete(ls);
                    }
                }


                // Dodaj nove sekundarne kategorije
                if (dto.SekundarneKategorijeIds.Count > 0)
                {
                    foreach (var katId in dto.SekundarneKategorijeIds.Distinct())
                    {
                        var kategorija = s.Load<SekundarnaKategorija>(katId);
                        var ls = new LekSekundarna
                        {
                            Lek = lek,
                            Kategorija = kategorija
                        };
                        s.Save(ls);
                    }
                }
                
                s.Update(lek);
                s.Flush();

                MessageBox.Show("Lek je uspešno ažuriran!", "Uspeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri ažuriranju leka: {ex.Message}", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ObrisiLek(long id)
        {
            try
            {
                using var s = DataLayer.GetSession();

                // Prvo obriši sve sekundarne kategorije
                var sekundarne = s.Query<LekSekundarna>()
                                  .Where(x => x.Lek.Id == id)
                                  .ToList();
                foreach (var ls in sekundarne)
                {
                    s.Delete(ls);
                }

                // Zatim obriši lek
                var lek = s.Get<Lek>(id);
                if (lek != null)
                {
                    s.Delete(lek);
                    s.Flush();

                    MessageBox.Show("Lek je uspešno obrisan!", "Uspeh",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri brisanju leka: {ex.Message}", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static IList<PrimarnaGrupaBasic> VratiPrimarneGrupe()
        {
            var list = new List<PrimarnaGrupaBasic>();
            try
            {
                using var s = DataLayer.GetSession();
                var grupe = s.Query<PrimarnaGrupa>().ToList();
                foreach (var z in grupe)
                {
                    list.Add(new PrimarnaGrupaBasic
                    {
                       Naziv=z.Naziv,   
                       Id=z.Id,
                    });
                }
            }
            catch (Exception) { }
            return list;
        }
        public static SekundarnaKategorija? VratiSekundarnuKategoriju(long id)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var sk= s.Get<SekundarnaKategorija>(id);
                if (sk == null) return null;

                // Učitaj sekundarne kategorije
               
                

                return new SekundarnaKategorija
                {
                   Id=sk.Id,
                   Naziv=sk.Naziv,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju sekundarne kategorije: {ex.Message}", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public static void  DodajLekSekundarna(long skId,long lekId)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var sk = s.Get<SekundarnaKategorija>(skId);
                var lek = s.Get<Lek>(lekId);
                var veza = new LekSekundarna
                {
                    Lek=lek,
                    Kategorija=sk,
                };
                s.Save(veza);
                s.Flush();

                MessageBox.Show(
            $": Uspesno je dodata kategorija",
            "Uspesno",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show(
           $"Greška pri dodavanju LekSekundarnaKategorija: {ex.Message}",
           "Greška",
           MessageBoxButtons.OK,
           MessageBoxIcon.Error);
            }
            
        }
    }
}
