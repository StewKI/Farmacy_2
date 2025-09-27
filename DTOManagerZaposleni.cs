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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Farmacy
{
    public static class DTOManagerZaposleni
    {

        public static void DodajFarmaceuta(FarmaceutBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var f = new Entiteti.FarmaceutBasic
                {
                    MatBr = dto.MatBr,
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
                
                dto.Id = f.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void UpdateFarmaceuta(FarmaceutBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();

                var farmaceut = s.Get<Entiteti.FarmaceutBasic>(dto.Id);

                if (farmaceut == null)
                {
                    return;
                }

                farmaceut.MatBr = dto.MatBr;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void DodajTehnicara(TehnicarBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var t = new Tehnicar
                {
                    MatBr = dto.MatBr,
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
                dto.Id = t.Id;

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

                s.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void UpdateTehnicara(TehnicarBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();

                var tehnicar = s.Get<Tehnicar>(dto.Id);

                if (tehnicar == null)
                {
                    return;
                }

                tehnicar.Ime = dto.Ime;
                tehnicar.Prezime = dto.Prezime;
                tehnicar.DatumRodj = dto.DatumRodj;
                tehnicar.Adresa = dto.Adresa;
                tehnicar.Telefon = dto.Telefon;
                tehnicar.DatumZaposlenja = dto.DatumZaposlenja;
                tehnicar.NivoObrazovanja = dto.NivoObrazovanja;

                s.Update(tehnicar);
                s.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void DodajMenadzera(MenadzerBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var m = new Entiteti.MenadzerBasic
                {
                    MatBr = dto.MatBr,
                    Ime = dto.Ime,
                    Prezime = dto.Prezime,
                    DatumRodj = dto.DatumRodj,
                    Adresa = dto.Adresa,
                    Telefon = dto.Telefon,
                    DatumZaposlenja = dto.DatumZaposlenja
                };
                s.Save(m);
                s.Flush();
                dto.Id = m.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void UpdateMenadzera(MenadzerBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();

                var menadzer = s.Get<Entiteti.MenadzerBasic>(dto.Id);

                if (menadzer == null)
                {
                    return;
                }

                menadzer.MatBr = dto.MatBr;
                menadzer.Ime = dto.Ime;
                menadzer.Prezime = dto.Prezime;
                menadzer.DatumRodj = dto.DatumRodj;
                menadzer.Adresa = dto.Adresa;
                menadzer.Telefon = dto.Telefon;
                menadzer.DatumZaposlenja = dto.DatumZaposlenja;

                s.Update(menadzer);
                s.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void DodajZaposlenog(ZaposleniBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var m = new Zaposleni
                {
                    MatBr = dto.MatBr,
                    Ime = dto.Ime,
                    Prezime = dto.Prezime,
                    DatumRodj = dto.DatumRodj,
                    Adresa = dto.Adresa,
                    Telefon = dto.Telefon,
                    DatumZaposlenja = dto.DatumZaposlenja
                };
                s.Save(m);
                s.Flush();
                
                dto.Id = m.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void UpdateZaposlenog(Zaposleni dto)
        {
            try
            {
                using var s = DataLayer.GetSession();

                var zaposleni = s.Get<Zaposleni>(dto.Id);

                if (zaposleni == null)
                {
                    return;
                }

                zaposleni.Ime = dto.Ime;
                zaposleni.Prezime = dto.Prezime;
                zaposleni.DatumRodj = dto.DatumRodj;
                zaposleni.Adresa = dto.Adresa;
                zaposleni.Telefon = dto.Telefon;
                zaposleni.DatumZaposlenja = dto.DatumZaposlenja;

                s.Update(zaposleni);
                s.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static ZaposleniBasic? VratiZaposlenog(long mbr)
        {
            try
            {
                using var s = DataLayer.GetSession();

                var f = s.Get<Entiteti.FarmaceutBasic>(mbr);
                if (f != null)
                {
                    return new FarmaceutBasic
                    {
                        Id = f.Id,
                        MatBr = f.MatBr,
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
                        Id = t.Id,
                        MatBr = t.MatBr,
                        Ime = t.Ime,
                        Prezime = t.Prezime,
                        DatumRodj = t.DatumRodj,
                        Adresa = t.Adresa,
                        Telefon = t.Telefon,
                        DatumZaposlenja = t.DatumZaposlenja,
                        NivoObrazovanja = t.NivoObrazovanja
                    };
                    return tb;
                }

                var m = s.Get<Entiteti.MenadzerBasic>(mbr);
                if (m != null)
                {
                    return new MenadzerBasic
                    {
                        Id = m.Id,
                        MatBr = m.MatBr,
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
                        Id = z.Id,
                        MatBr = z.MatBr,
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
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public static FarmaceutBasic? VratiFarmaceuta(long mbr)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var f = s.Get<Entiteti.FarmaceutBasic>(mbr);
                if (f != null)
                {
                    return new FarmaceutBasic
                    {
                        Id = f.Id,
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
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static TehnicarBasic? VratiTehnicara(long mbr)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var t = s.Get<Tehnicar>(mbr);
                if (t != null)
                {
                    return new TehnicarBasic
                    {
                        Id = t.Id,
                        Ime = t.Ime,
                        Prezime = t.Prezime,
                        DatumRodj = t.DatumRodj,
                        Adresa = t.Adresa,
                        Telefon = t.Telefon,
                        DatumZaposlenja = t.DatumZaposlenja,
                        NivoObrazovanja = t.NivoObrazovanja
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static MenadzerBasic? VratiMenadzera(long mbr)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var m = s.Get<Entiteti.MenadzerBasic>(mbr);
                if (m != null)
                {
                    return new MenadzerBasic
                    {
                        Id = m.Id,
                        Ime = m.Ime,
                        Prezime = m.Prezime,
                        DatumRodj = m.DatumRodj,
                        Adresa = m.Adresa,
                        Telefon = m.Telefon,
                        DatumZaposlenja = m.DatumZaposlenja
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static Entiteti.FarmaceutBasic? VratiOdgovornogFarmaceuta(long id)
        {
            try
            {
                using var s = DataLayer.GetSession();

                var f = s.Get<Entiteti.FarmaceutBasic>(id);
                if (f != null)
                {
                    return f;
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static IList<ZaposleniBasic> VratiSveZaposlene()
        {
            var list = new List<ZaposleniBasic>();
            try
            {
                using var s = DataLayer.GetSession();
                var svi = s.Query<Zaposleni>().ToList();
                Console.WriteLine("svi " + svi.Count);
                foreach (var z in svi)
                {
                    list.Add(new ZaposleniBasic
                    {
                        Id = z.Id,
                        Ime = z.Ime,
                        MatBr = z.MatBr,
                        Prezime = z.Prezime,
                        DatumRodj = z.DatumRodj,
                        Adresa = z.Adresa,
                        Telefon = z.Telefon,
                        DatumZaposlenja = z.DatumZaposlenja
                    });
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
            return list;
        }

        public static IList<FarmaceutBasic> VratiSveFarmaceute()
        {
            var list = new List<FarmaceutBasic>();
            try
            {
                using var s = DataLayer.GetSession();
                var farmaceuti = s.Query<Entiteti.FarmaceutBasic>().ToList();
                foreach (var f in farmaceuti)
                {
                    list.Add(new FarmaceutBasic
                    {
                        Id = f.Id,
                        Ime = f.Ime,
                        Prezime = f.Prezime,
                        MatBr = f.MatBr,
                        DatumRodj = f.DatumRodj,
                        Adresa = f.Adresa,
                        Telefon = f.Telefon,
                        DatumZaposlenja = f.DatumZaposlenja,
                        DatumDiplomiranja = f.DatumDiplomiranja,
                        BrLicence = f.BrLicence,
                        DatumPoslednjeObnoveLicence = f.DatumPoslObnoveLicence,
                        Specijalnost = f.Specijalnost
                    });
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
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
                    var p = s.Query<Entiteti.ProdajnaJedinicaBasic>()
                        .Where(p => p.OdgovorniFarmaceut == z)
                        .ToList();

                    if(p.Count > 0)
                    {
                     
                         throw new Exception($"Farmaceut je odgovran za apoteku {p[0].Naziv}, pa ne moze biti izbrisan!");
                    }


                }
                else if (selektovaniZaposleni is TehnicarBasic tehnicar)
                {

                    var z = s.Get<Tehnicar>(mbr);
                    var sertifikacije=s.Query<Entiteti.TehnicarSertifikacija>().
                                        Where(p=>p.Tehnicar==z)
                                        .ToList();
                    if(sertifikacije.Count > 0)
                    {
                        foreach(var s1  in sertifikacije)
                        {
                            s.Delete(s1);
                            s.Flush();

                        }
                    }


                }
                else if (selektovaniZaposleni is MenadzerBasic menadzer)
                {
                    var z = s.Get<Entiteti.MenadzerBasic>(mbr);
                    var odgovran = s.Query<Entiteti.MenadzerApoteka>()
                                    .Where(m=>m.Menadzer==z)
                                    .ToList();
                    if( odgovran.Count > 0 )
                    {
                        foreach(var m in odgovran)
                        {
                            s.Delete(m);
                            s.Flush();

                        }
                    }
                }

                var z1 = s.Get<Entiteti.Zaposleni>(mbr);
                

                var ras=s.Query<RasporedRada>().Where(r=>r.Zaposleni==z1).ToList();

                if (ras.Count > 0)
                {
                    foreach (var r in ras)
                    {
                        s.Delete(r);
                        s.Flush();
                    }
                }


                if (z1 != null)
                {
                    s.Delete(z1);
                    s.Flush();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void DodajMenadzerApoteka(MenadzerApotekaBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var m = s.Get<Entiteti.MenadzerBasic>(dto.IdMenadzera);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void IzmeniRadnoMesto(long mbr,long idRadnogMesta,int smena1)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var raspored=s.Query<RasporedRada>()
                    .Where(r => r.Zaposleni.Id==mbr).FirstOrDefault();

                

                var novi = new RasporedRadaBasic
                {
                    ProdajnaJedinicaId = idRadnogMesta,
                    IdZaposlenog = mbr,
                    Pocetak = raspored.Pocetak,
                    Kraj = raspored.Kraj,
                    BrojSmene = smena1
                };

                s.Delete(raspored);
                s.Flush();

                DodajRasporedRada(novi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void IzbrisiRasporedRada(long mbr)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var raspored = s.Query<RasporedRada>()
                    .Where(r => r.Zaposleni.Id == mbr).FirstOrDefault();

                s.Delete(raspored);
                s.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static RasporedRadaBasic VratiRasporedRada(long mbr)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var raspored = s.Query<RasporedRada>()
                    .Where(r => r.Zaposleni.Id == mbr).FirstOrDefault();

                if (raspored == null)
                {
                    throw new Exception($"Zaposleni nema raspored rada");
                }

                return (new RasporedRadaBasic
                {
                    ProdajnaJedinicaId = raspored.ProdajnaJedinica.Id,
                    IdZaposlenog = raspored.Zaposleni.Id,
                    Pocetak = raspored.Pocetak,
                    Kraj = raspored.Kraj,

                });

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }




        public static void DodajRasporedRada(RasporedRadaBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                
                var zaposleni = s.Get<Zaposleni>(dto.IdZaposlenog);
                if (zaposleni == null)
                {
                    return;
                }
                
                var prodajnaJedinica = s.Get<Entiteti.ProdajnaJedinicaBasic>(dto.ProdajnaJedinicaId);
                if (prodajnaJedinica == null)
                {
                    return;
                }
                
                var raspored = new RasporedRada
                {
                    Zaposleni = zaposleni,
                    ProdajnaJedinica = prodajnaJedinica,
                    Pocetak = dto.Pocetak,
                    Kraj = dto.Kraj,
                    BrojSmene = dto.BrojSmene
                };
                
                s.Save(raspored);
                s.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static IList<RasporedRadaBasic> VratiRasporedRadaZaZaposlenog(long mbr)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var query = s.Query<RasporedRada>()
                    .Where(rr => rr.Zaposleni.Id == mbr)
                    .Select(rr => new RasporedRadaBasic
                    {
                        IdZaposlenog = rr.Zaposleni.Id,
                        ProdajnaJedinicaId = rr.ProdajnaJedinica.Id,
                        Pocetak = rr.Pocetak,
                        Kraj = rr.Kraj,
                        BrojSmene = rr.BrojSmene,
                        ZaposleniIme = rr.Zaposleni.Ime,
                        ZaposleniPrezime = rr.Zaposleni.Prezime,
                        ProdajnaJedinicaNaziv = rr.ProdajnaJedinica.Naziv,
                        SmenaNaziv = rr.BrojSmene == null ? "Nije dodeljena" : 
                                   rr.BrojSmene == 1 ? "Prva smena" :
                                   rr.BrojSmene == 2 ? "Druga smena" : "Treća smena"
                    });
                return query.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<RasporedRadaBasic>();
            }
        }

        public static IList<RasporedRadaBasic> VratiRasporedRadaZaProdajnuJedinicu(long prodajnaJedinicaId)
        {
            try
            {
                using var s = DataLayer.GetSession();
                
                var query = s.Query<RasporedRada>()
                    .Where(rr => rr.ProdajnaJedinica.Id == prodajnaJedinicaId)
                    .Fetch(x => x.Zaposleni)
                    .Fetch(x => x.ProdajnaJedinica)
                    .OrderBy(x => x.Pocetak)
                    .Select(rr => new RasporedRadaBasic
                    {
                        IdZaposlenog = rr.Zaposleni.Id,
                        ProdajnaJedinicaId = rr.ProdajnaJedinica.Id,
                        Pocetak = rr.Pocetak,
                        Kraj = rr.Kraj,
                        BrojSmene = rr.BrojSmene,
                        ZaposleniIme = rr.Zaposleni.Ime,
                        ZaposleniPrezime = rr.Zaposleni.Prezime,
                        ProdajnaJedinicaNaziv = rr.ProdajnaJedinica.Naziv,
                        SmenaNaziv = rr.BrojSmene == null ? "Nije dodeljena" : 
                                   rr.BrojSmene == 1 ? "Prva smena" :
                                   rr.BrojSmene == 2 ? "Druga smena" : "Treća smena"
                    });
                
                return query.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<RasporedRadaBasic>();
            }
        }

        public static IList<RasporedRadaBasic> VratiSveRasporedeRada()
        {
            try
            {
                using var s = DataLayer.GetSession();
                
                var query = s.Query<RasporedRada>()
                    .Fetch(x => x.Zaposleni)
                    .Fetch(x => x.ProdajnaJedinica)
                    .OrderBy(x => x.Pocetak)
                    .Select(rr => new RasporedRadaBasic
                    {
                        IdZaposlenog = rr.Zaposleni.Id,
                        ProdajnaJedinicaId = rr.ProdajnaJedinica.Id,
                        Pocetak = rr.Pocetak,
                        Kraj = rr.Kraj,
                        BrojSmene = rr.BrojSmene,
                        ZaposleniIme = rr.Zaposleni.Ime,
                        ZaposleniPrezime = rr.Zaposleni.Prezime,
                        ProdajnaJedinicaNaziv = rr.ProdajnaJedinica.Naziv,
                        SmenaNaziv = rr.BrojSmene == null ? "Nije dodeljena" : 
                                   rr.BrojSmene == 1 ? "Prva smena" :
                                   rr.BrojSmene == 2 ? "Druga smena" : "Treća smena"
                    });
                
                return query.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<RasporedRadaBasic>();
            }
        }

        public static void ObrisiRasporedRada(long mbr, long prodajnaJedinicaId, DateTime pocetak)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var raspored = s.Query<RasporedRada>()
                    .FirstOrDefault(rr => rr.Zaposleni.Id == mbr 
                                       && rr.ProdajnaJedinica.Id == prodajnaJedinicaId 
                                       && rr.Pocetak == pocetak);
                
                if (raspored != null)
                {
                    s.Delete(raspored);
                    s.Flush();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
  
}
