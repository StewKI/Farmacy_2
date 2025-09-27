using Farmacy.Entiteti;
using FluentNHibernate.Data;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy
{
    public static class DTOManagerLek
    {

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Greška pri dodavanju sekundarne kategorije");
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
                MessageBox.Show(ex.ToString(), "Greška pri dodavanju leka");
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
                MessageBox.Show(ex.ToString(), "Greška pri dodavanju oblika");
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Greška pri dodavanju pakovanja");
            }
            return 0;
        }

        public static IList<Pakovanje> VratiSvaPakovanja()
        {
            var list = new List<Pakovanje>();
            try
            {
                using var s = DataLayer.GetSession();
                var pakovanja = s.Query<Pakovanje>().ToList();
                
                foreach (var p in pakovanja)
                {
                    var lekNaziv = p.Lek?.KomercijalniNaziv;
                    var oblikNaziv = p.Oblik?.Naziv;
                    list.Add(p);
                }
            }
            catch (Exception) { }
            return list;
        }

        public static Pakovanje VratiPakovanje(long id)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var pakovanje = s.Get<Pakovanje>(id);
                
                if (pakovanje != null)
                {
                    var lekNaziv = pakovanje.Lek?.KomercijalniNaziv;
                    var oblikNaziv = pakovanje.Oblik?.Naziv;
                }
                
                return pakovanje;
            }
            catch (Exception) { }
            return null;
        }

        public static void ObrisiPakovanje(long id)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var pakovanje = s.Get<Pakovanje>(id);
                if (pakovanje != null)
                {
                    s.Delete(pakovanje);
                    s.Flush();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri brisanju pakovanja: " + ex.Message);
            }
        }

        public static void IzmeniPakovanje(PakovanjeBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                using var transaction = s.BeginTransaction();
                try
                {
                    var pakovanje = s.Get<Pakovanje>(dto.Id);
                    if (pakovanje == null)
                    {
                        throw new Exception("Pakovanje sa ID " + dto.Id + " nije pronađeno.");
                    }
                    
                    pakovanje.Lek = s.Load<Lek>(dto.LekId);
                    pakovanje.Oblik = s.Load<Oblik>(dto.OblikId);
                    pakovanje.VelicinaPakovanja = dto.VelicinaPakovanja;
                    pakovanje.KolicinaAktivne = dto.KolicinaAktivne;
                    pakovanje.JedinicaMere = dto.JedinicaMere;
                    pakovanje.Ambalaza = dto.Ambalaza;
                    pakovanje.NacinCuvanja = dto.NacinCuvanja;
                    pakovanje.PreporuceniRokDana = dto.PreporuceniRokDana;
                    
                    s.Update(pakovanje);
                    s.Flush();
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri izmeni pakovanja: " + ex.Message);
            }
        }

        public static Farmacy.Entiteti.Lek? VratiLekEntitet(long id)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var lek = s.Get<Lek>(id);
                return lek;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Greška pri vraćanju leka");
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
                MessageBox.Show(ex.ToString(), "Greška pri vraćanju leka");
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

        public static Oblik VratiOblik(long id)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var oblik = s.Get<Oblik>(id);
                return oblik;
            }
            catch (Exception) { }
            return null;
        }

        public static OblikBasic VratiOblikBasic(long id)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var oblik = s.Get<Oblik>(id);
                if (oblik != null)
                {
                    return new OblikBasic
                    {
                        Id = oblik.Id,
                        Naziv = oblik.Naziv
                    };
                }
            }
            catch (Exception) { }
            return null;
        }

        public static void IzmeniOblik(Oblik oblik)
        {
            try
            {
                using var s = DataLayer.GetSession();
                s.Update(oblik);
                s.Flush();
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri izmeni oblika: " + ex.Message);
            }
        }

        public static void IzmeniOblik(OblikBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var oblik = s.Get<Oblik>(dto.Id);
                if (oblik != null)
                {
                    oblik.Naziv = dto.Naziv;
                    s.Update(oblik);
                    s.Flush();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri izmeni oblika: " + ex.Message);
            }
        }

        public static void ObrisiOblik(long id)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var oblik = s.Get<Oblik>(id);
                if (oblik != null)
                {
                    s.Delete(oblik);
                    s.Flush();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri brisanju oblika: " + ex.Message);
            }
        }

        public static void IzmeniLek(LekBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var lek = s.Get<Lek>(dto.Id);

                if (lek == null)
                {
                    return;
                }

                lek.HemijskiNaziv = dto.HemijskiNaziv;
                lek.KomercijalniNaziv = dto.KomercijalniNaziv;
                lek.Dejstvo = dto.Dejstvo;
                lek.Proizvodjac = s.Load<Proizvodjac>(dto.ProizvodjacId);
                lek.PrimarnaGrupa = s.Load<PrimarnaGrupa>(dto.PrimarnaGrupaId);

                if (lek.Sekundarne.Count > 0)
                {
                    var stareSekundarne = s.Query<LekSekundarna>()
                                       .Where(x => x.Lek.Id == dto.Id)
                                       .ToList();
                    foreach (var ls in stareSekundarne)
                    {
                        s.Delete(ls);
                    }
                }

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Greška pri izmeni leka");
            }
        }

        public static void ObrisiLek(long id)
        {
            try
            {
                using var s = DataLayer.GetSession();

                var sekundarne = s.Query<LekSekundarna>()
                                  .Where(x => x.Lek.Id == id)
                                  .ToList();
                foreach (var ls in sekundarne)
                {
                    s.Delete(ls);
                }

                var lek = s.Get<Lek>(id);
                if (lek != null)
                {
                    s.Delete(lek);
                    s.Flush();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Greška pri brisanju leka");
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

        public static PrimarnaGrupaBasic VratiPrimarnuGrupu(long id)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var grupa = s.Get<PrimarnaGrupa>(id);
                if (grupa != null)
                {
                    return new PrimarnaGrupaBasic
                    {
                        Id = grupa.Id,
                        Naziv = grupa.Naziv
                    };
                }
            }
            catch (Exception) { }
            return null;
        }

        public static void IzmeniPrimarnuGrupu(PrimarnaGrupaBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var grupa = s.Get<PrimarnaGrupa>(dto.Id);
                if (grupa != null)
                {
                    grupa.Naziv = dto.Naziv;
                    s.Update(grupa);
                    s.Flush();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri izmeni primarne grupe: " + ex.Message);
            }
        }

        public static void ObrisiPrimarnuGrupu(long id)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var grupa = s.Get<PrimarnaGrupa>(id);
                if (grupa != null)
                {
                    s.Delete(grupa);
                    s.Flush();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri brisanju primarne grupe: " + ex.Message);
            }
        }
        public static SekundarnaKategorija? VratiSekundarnuKategoriju(long id)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var sk = s.Get<SekundarnaKategorija>(id);
                if (sk == null) return null;




                return new SekundarnaKategorija
                {
                    Id = sk.Id,
                    Naziv = sk.Naziv,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Greška pri vraćanju sekundarne kategorije");
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
                    Lek = lek,
                    Kategorija = sk,
                };
                s.Save(veza);
                s.Flush();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Greška pri dodavanju veze lek-sekundarna kategorija");
            }
            
        }
    }
}
