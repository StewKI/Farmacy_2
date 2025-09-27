using Farmacy.Entiteti;
using FluentNHibernate.Data;
using NHibernate.Exceptions;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy
{
    public static class DTOManagerProdajneJedinice
    {

        public static void IzmeniMenadzerApoteka(MenadzerApotekaBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var ent = s.Query<MenadzerApoteka>()
                           .FirstOrDefault(x => x.Menadzer.Id == dto.IdMenadzera
                                             && x.ProdajnaJedinica.Id == dto.ProdajnaJedinicaId);

                if (ent != null)
                {
                    ent.Od = dto.Od;
                    ent.Do = dto.Do;
                }

                s.Update(ent);
                s.Flush();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška pri ažuriranju veze menadžer-apoteka");
            }
        }

        public static IList<MenadzerBasic> VratiMenadzereZaApoteku(long id)
        {
            var list = new List<MenadzerBasic>();
            try
            {
                using var s = DataLayer.GetSession();
                var menadzeri = s.Query<MenadzerApoteka>()
                    .Where(x => x.ProdajnaJedinica.Id == id)
                    .Select(x => x.Menadzer)
                    .ToList();

                foreach (var z in menadzeri)
                {
                    list.Add(new MenadzerBasic
                    {
                        Id = z.Id,
                        Ime = z.Ime,
                        Prezime = z.Prezime,
                        DatumRodj = z.DatumRodj,
                        Adresa = z.Adresa,
                        Telefon = z.Telefon,
                        DatumZaposlenja = z.DatumZaposlenja
                    });
                }

                
            }

            
            catch(Exception ex)
            {

            }
            return list;
        }
        public static void DodajProdajnuJedinicu(ProdajnaJedinicaBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var odgovorni = s.Load<Entiteti.FarmaceutBasic>(dto.OdgovorniFarmaceutId);

                var pj = new Entiteti.ProdajnaJedinicaBasic
                {
                    Naziv = dto.Naziv,
                    Ulica = dto.Ulica,
                    Broj = dto.Broj,
                    PostanskiBroj = dto.PostanskiBroj,
                    Mesto = dto.Mesto,
                    OdgovorniFarmaceut = odgovorni
                };

                s.Save(pj);
                s.Flush();
                dto.Id = pj.Id;
            }
            catch (GenericADOException ex)
            {
                MessageBox.Show("Greška pri dodavanju prodajne jedinice: " + ex.Message, "Greška");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju prodajne jedinice: " + ex.Message, "Greška");
            }
        }

        public static void DodajApotekuSaLab(ApotekaSaLabBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();

                if (dto.OdgovorniFarmaceut == null)
                {
                    throw new Exception("Odgovorni farmaceut je obavezan!");
                }

                var pj = new Entiteti.ApotekaSaLabBasic
                {
                    Naziv = dto.Naziv,
                    Ulica = dto.Ulica,
                    Broj = dto.Broj,
                    PostanskiBroj = dto.PostanskiBroj,
                    Mesto = dto.Mesto,
                    Napomena = dto.Napomena,
                    OdgovorniFarmaceut = dto.OdgovorniFarmaceut,
                };

                s.Save(pj);
                s.Flush();
                dto.Id = pj.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju apoteke sa laboratorijom: " + ex.Message, "Greška");
            }
        }

        public static void DodajSpecApoteku(SpecijalizovanaApoteka dto)
        {
            try
            {
                using var s = DataLayer.GetSession();


                var pj = new Entiteti.SpecijalizovanaApoteka
                {
                    Naziv = dto.Naziv,
                    Ulica = dto.Ulica,
                    Broj = dto.Broj,
                    PostanskiBroj = dto.PostanskiBroj,
                    Mesto = dto.Mesto,
                    Napomena = dto.Napomena,
                    SpecijalnostTipa = dto.SpecijalnostTipa,
                    OdgovorniFarmaceut = dto.OdgovorniFarmaceut,
                };

                s.Save(pj);
                s.Flush();
                dto.Id = pj.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju specijalizovane apoteke: " + ex.Message, "Greška");
            }
        }
        public static void DodajStandardnuApoteku(StandardnaApoteka dto)
        {
            try
            {
                using var s = DataLayer.GetSession();


                var pj = new Entiteti.StandardnaApoteka
                {
                    Naziv = dto.Naziv,
                    Ulica = dto.Ulica,
                    Broj = dto.Broj,
                    PostanskiBroj = dto.PostanskiBroj,
                    Mesto = dto.Mesto,
                    Napomena = dto.Napomena,
                    OdgovorniFarmaceut = dto.OdgovorniFarmaceut,
                };

                s.Save(pj);
                s.Flush();
                dto.Id = pj.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju standardne apoteke: " + ex.Message, "Greška");
            }
        }

        public static ProdajnaJedinicaBasic VratiProdajnuJedinicu(long id)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var pj = s.Get<Entiteti.ProdajnaJedinicaBasic>(id);
                if (pj == null) return null;

                return new ProdajnaJedinicaBasic
                {
                    Id = pj.Id,
                    Naziv = pj.Naziv,
                    Ulica = pj.Ulica,
                    Broj = pj.Broj,
                    PostanskiBroj = pj.PostanskiBroj,
                    Mesto = pj.Mesto,
                    OdgovorniFarmaceutId = pj.OdgovorniFarmaceut?.Id ?? 0
                };
            }
            catch (Exception) { }
            return null;
        }

        public static Entiteti.ProdajnaJedinicaBasic VratiProdajnuJedinicuTip(long id)
        {
            try
            {
                using var s = DataLayer.GetSession();

                var lab = s.Get<Entiteti.ApotekaSaLabBasic>(id); // <-- ako ti se entitet zove drugačije, promeni ovde
                if (lab != null)
                {
                    return new ApotekaSaLabBasic
                    {
                        Id = lab.Id,
                        Naziv = lab.Naziv,
                        Ulica = lab.Ulica,
                        Broj = lab.Broj,
                        PostanskiBroj = lab.PostanskiBroj,
                        Mesto = lab.Mesto,
                        OdgovorniFarmaceut = lab.OdgovorniFarmaceut,
                        Napomena = lab.Napomena
                    };
                }

                var spec = s.Get<Entiteti.SpecijalizovanaApoteka>(id);
                if (spec != null)
                {
                    return new SpecijalizovanaApoteka
                    {
                        Id = spec.Id,
                        Naziv = spec.Naziv,
                        Ulica = spec.Ulica,
                        Broj = spec.Broj,
                        PostanskiBroj = spec.PostanskiBroj,
                        Mesto = spec.Mesto,
                        OdgovorniFarmaceut = spec.OdgovorniFarmaceut,
                        SpecijalnostTipa = spec.SpecijalnostTipa,
                        Napomena = spec.Napomena
                    };
                }

                var standardna = s.Get<Entiteti.StandardnaApoteka>(id);
                if (standardna != null)
                {
                    return new StandardnaApoteka
                    {
                        Id = standardna.Id,
                        Naziv = standardna.Naziv,
                        Ulica = standardna.Ulica,
                        Broj = standardna.Broj,
                        PostanskiBroj = standardna.PostanskiBroj,
                        Mesto = standardna.Mesto,
                        OdgovorniFarmaceut = standardna.OdgovorniFarmaceut,
                        Napomena = standardna.Napomena
                    };

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška pri učitavanju prodajne jedinice");
            }

            return null;
        }
        public static IList<ProdajnaJedinicaBasic> VratiSveProdajneJedinice()
        {
            var list = new List<ProdajnaJedinicaBasic>();
            try
            {
                using var s = DataLayer.GetSession();
                var sve = s.Query<Entiteti.ProdajnaJedinicaBasic>()
                    .Fetch(x => x.OdgovorniFarmaceut)
                    .ToList();
                
                foreach (var pj in sve)
                {
                    list.Add(new ProdajnaJedinicaBasic
                    {
                        Id = pj.Id,
                        Naziv = pj.Naziv,
                        Ulica = pj.Ulica,
                        Broj = pj.Broj,
                        PostanskiBroj = pj.PostanskiBroj,
                        Mesto = pj.Mesto,
                        OdgovorniFarmaceutId = pj.OdgovorniFarmaceut?.Id ?? 0
                    });
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        public static IList<ProdajnaJedinicaBasic> VratiOsnovneProdajneJedinice()
        {
            var list = new List<ProdajnaJedinicaBasic>();
            try
            {
                using var s = DataLayer.GetSession();
                var sve = s.Query<Entiteti.ProdajnaJedinicaBasic>()
                    .Fetch(x => x.OdgovorniFarmaceut)
                    .ToList();

                foreach (var pj in sve)
                {
                    var typeName = pj.GetType().Name;

                    if (typeName == "ProdajnaJedinicaBasic")
                    {
                        list.Add(new ProdajnaJedinicaBasic
                        {
                            Id = pj.Id,
                            Naziv = pj.Naziv,
                            Ulica = pj.Ulica,
                            Broj = pj.Broj,
                            PostanskiBroj = pj.PostanskiBroj,
                            Mesto = pj.Mesto,
                            OdgovorniFarmaceutId = pj.OdgovorniFarmaceut?.Id ?? 0
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        public static IList<ApotekaSaLabBasic> VratiApotekeSaLab()
        {
            var list = new List<ApotekaSaLabBasic>();
            try
            {
                using var s = DataLayer.GetSession();
                var sve = s.Query<Entiteti.ApotekaSaLabBasic>()
                    .Fetch(x => x.OdgovorniFarmaceut)
                    .ToList();

                foreach (var pj in sve)
                {
                    list.Add(new ApotekaSaLabBasic
                    {
                        Id = pj.Id,
                        Naziv = pj.Naziv,
                        Ulica = pj.Ulica,
                        Broj = pj.Broj,
                        PostanskiBroj = pj.PostanskiBroj,
                        Mesto = pj.Mesto,
                        OdgovorniFarmaceut = pj.OdgovorniFarmaceut,
                        Napomena = pj.Napomena
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        public static IList<StandardnaApoteka> VratiStandardneApoteke()
        {
            var list = new List<StandardnaApoteka>();
            try
            {
                using var s = DataLayer.GetSession();
                var sve = s.Query<Entiteti.StandardnaApoteka>()
                    .Fetch(x => x.OdgovorniFarmaceut)
                    .ToList();
                
                foreach (var pj in sve)
                {
                    list.Add(new StandardnaApoteka
                    {
                        Id = pj.Id,
                        Naziv = pj.Naziv,
                        Ulica = pj.Ulica,
                        Broj = pj.Broj,
                        PostanskiBroj = pj.PostanskiBroj,
                        Mesto = pj.Mesto,
                        OdgovorniFarmaceut = pj.OdgovorniFarmaceut,
                        Napomena = pj.Napomena
                    });
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        public static IList<SpecijalizovanaApoteka> VratiSpecijalizovaneApoteke()
        {
            var list = new List<SpecijalizovanaApoteka>();
            try
            {
                using var s = DataLayer.GetSession();
                var sve = s.Query<Entiteti.SpecijalizovanaApoteka>()
                    .Fetch(x => x.OdgovorniFarmaceut)
                    .ToList();
                
                foreach (var pj in sve)
                {
                    list.Add(new SpecijalizovanaApoteka
                    {
                        Id = pj.Id,
                        Naziv = pj.Naziv,
                        Ulica = pj.Ulica,
                        Broj = pj.Broj,
                        PostanskiBroj = pj.PostanskiBroj,
                        Mesto = pj.Mesto,
                        OdgovorniFarmaceut = pj.OdgovorniFarmaceut,
                        SpecijalnostTipa = pj.SpecijalnostTipa,
                        Napomena = pj.Napomena
                    });
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        public static void IzmeniProdajnuJedinicu(ProdajnaJedinicaBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var pj = s.Load<Entiteti.ProdajnaJedinicaBasic>(dto.Id);
                pj.Naziv = dto.Naziv;
                pj.Ulica = dto.Ulica;
                pj.Broj = dto.Broj;
                pj.PostanskiBroj = dto.PostanskiBroj;
                pj.Mesto = dto.Mesto;
                pj.OdgovorniFarmaceut = s.Load<Entiteti.FarmaceutBasic>(dto.OdgovorniFarmaceutId);

                s.Update(pj);
                s.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri izmeni prodajne jedinice: " + ex.Message, "Greška");
            }
        }
        public static void IzmeniSpecApoetku(SpecijalizovanaApoteka dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var pj = s.Load<Entiteti.SpecijalizovanaApoteka>(dto.Id);
                pj.Naziv = dto.Naziv;
                pj.Ulica = dto.Ulica;
                pj.Broj = dto.Broj;
                pj.PostanskiBroj = dto.PostanskiBroj;
                pj.Mesto = dto.Mesto;
                pj.OdgovorniFarmaceut = dto.OdgovorniFarmaceut;
                pj.SpecijalnostTipa = dto.SpecijalnostTipa;
               

                s.Update(pj);
                s.Flush();
            }
            catch (Exception ex) {
                MessageBox.Show("Greška pri izmeni specijalizovane apoteke: " + ex.Message, "Greška");
            }
        }

        public static void IzmeniSApoetku(Entiteti.StandardnaApoteka dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var pj = s.Load<Entiteti.StandardnaApoteka>(dto.Id);
                pj.Naziv = dto.Naziv;
                pj.Ulica = dto.Ulica;
                pj.Broj = dto.Broj;
                pj.PostanskiBroj = dto.PostanskiBroj;
                pj.Mesto = dto.Mesto;
                pj.OdgovorniFarmaceut = dto.OdgovorniFarmaceut;



                s.Update(pj);
                s.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri izmeni standardne apoteke: " + ex.Message, "Greška");
            }
        }
        public static void IzmeniApoetkuSaLab(Entiteti.ApotekaSaLabBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var pj = s.Load<Entiteti.ApotekaSaLabBasic>(dto.Id);
                pj.Naziv = dto.Naziv;
                pj.Ulica = dto.Ulica;
                pj.Broj = dto.Broj;
                pj.PostanskiBroj = dto.PostanskiBroj;
                pj.Mesto = dto.Mesto;
                pj.OdgovorniFarmaceut = dto.OdgovorniFarmaceut;



                s.Update(pj);
                s.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri izmeni apoteke sa laboratorijom: " + ex.Message, "Greška");
            }
        }

        public static void ObrisiProdajnuJedinicu(long id)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var pj = s.Get<Entiteti.ProdajnaJedinicaBasic>(id);
                if (pj != null)
                {
                    s.Delete(pj);
                    s.Flush();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri brisanju prodajne jedinice: " + ex.Message, "Greška");
            }
        }


        public static void DodeliMenadzeraApoteci(MenadzerApotekaBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var m = s.Load<Entiteti.MenadzerBasic>(dto.IdMenadzera);
                var pj = s.Load<Entiteti.ProdajnaJedinicaBasic>(dto.ProdajnaJedinicaId);

                var veza = new MenadzerApoteka
                {
                    Menadzer = m,
                    ProdajnaJedinica = pj,
                    Od = dto.Od,
                    Do = dto.Do
                };

                s.Save(veza);
                s.Flush();
            }
            catch (Exception) { }
        }

        public static IList<MenadzerApotekaBasic> VratiApotekeMenadzera(long idMenadzera)
        {
            var list = new List<MenadzerApotekaBasic>();
            try
            {
                using var s = DataLayer.GetSession();
                var veze = s.Query<MenadzerApoteka>()
                            .Where(x => x.Menadzer.Id == idMenadzera).ToList();

                list.AddRange(veze.Select(x => new MenadzerApotekaBasic
                {
                    IdMenadzera = x.Menadzer.Id,
                    ProdajnaJedinicaId = x.ProdajnaJedinica.Id,
                    Od = x.Od,
                    Do = x.Do
                }));
            }
            catch (Exception) { }
            return list;
        }

        public static void UkloniMenadzeraSaApoteke(long idA,long idM)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var ent = s.Query<MenadzerApoteka>()
                           .FirstOrDefault(x => x.Menadzer.Id == idM
                                             && x.ProdajnaJedinica.Id == idA);
                                            
                if (ent != null)
                {
                    s.Delete(ent);
                    s.Flush();
                }
            }
            catch (Exception) { }
        }


        public static IList<RadnoVremeBasic> VratiRadnoVremeZaProdajnuJedinicu(long prodajnaJedinicaId)
        {
            var list = new List<RadnoVremeBasic>();
            try
            {
                using var s = DataLayer.GetSession();
                var radnaVremena = s.Query<RadnoVreme>()
                    .Where(rv => rv.ProdajnaJedinica.Id == prodajnaJedinicaId)
                    .ToList();

                string[] dani = { "Ponedeljak", "Utorak", "Sreda", "Četvrtak", "Petak", "Subota", "Nedelja" };

                foreach (var rv in radnaVremena)
                {
                    list.Add(new RadnoVremeBasic
                    {
                        Id = rv.ProdajnaJedinica.Id * 100 + rv.Dan, // Composite key simulation
                        ProdajnaJedinicaId = rv.ProdajnaJedinica.Id,
                        Dan = rv.Dan,
                        VremeOd = rv.VremeOd,
                        VremeDo = rv.VremeDo,
                        DanNaziv = dani[rv.Dan - 1],
                        ProdajnaJedinicaNaziv = rv.ProdajnaJedinica.Naziv
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri učitavanju radnog vremena: " + ex.Message);
            }
            return list;
        }

        public static RadnoVremeBasic VratiRadnoVreme(long prodajnaJedinicaId, int dan)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var rv = s.Query<RadnoVreme>()
                    .FirstOrDefault(x => x.ProdajnaJedinica.Id == prodajnaJedinicaId && x.Dan == dan);
                if (rv != null)
                {
                    string[] dani = { "Ponedeljak", "Utorak", "Sreda", "Četvrtak", "Petak", "Subota", "Nedelja" };
                    return new RadnoVremeBasic
                    {
                        Id = rv.ProdajnaJedinica.Id * 100 + rv.Dan, // Composite key simulation
                        ProdajnaJedinicaId = rv.ProdajnaJedinica.Id,
                        Dan = rv.Dan,
                        VremeOd = rv.VremeOd,
                        VremeDo = rv.VremeDo,
                        DanNaziv = dani[rv.Dan - 1],
                        ProdajnaJedinicaNaziv = rv.ProdajnaJedinica.Naziv
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri učitavanju radnog vremena: " + ex.Message);
            }
            return null;
        }

        public static void IzmeniRadnoVreme(RadnoVremeBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var rv = s.Query<RadnoVreme>()
                    .FirstOrDefault(x => x.ProdajnaJedinica.Id == dto.ProdajnaJedinicaId && x.Dan == dto.Dan);
                if (rv != null)
                {
                    rv.VremeOd = dto.VremeOd ?? DateTime.MinValue;
                    rv.VremeDo = dto.VremeDo ?? DateTime.MinValue;
                    s.Update(rv);
                    s.Flush();
                }
                else
                {
                    var prodajnaJedinica = s.Query<Entiteti.ProdajnaJedinicaBasic>()
                        .FirstOrDefault(x => x.Id == dto.ProdajnaJedinicaId);
                    if (prodajnaJedinica != null)
                    {
                        var noviRadnoVreme = new RadnoVreme
                        {
                            ProdajnaJedinica = prodajnaJedinica,
                            Dan = dto.Dan,
                            VremeOd = dto.VremeOd ?? DateTime.MinValue,
                            VremeDo = dto.VremeDo ?? DateTime.MinValue
                        };
                        s.Save(noviRadnoVreme);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri izmeni radnog vremena: " + ex.Message);
            }
        }

        public static void DodajRadnoVreme(RadnoVremeBasic dto)
        {
            try
            {
                if (!dto.VremeOd.HasValue || !dto.VremeDo.HasValue)
                {
                    throw new Exception("Morate uneti i početno i krajnje vreme!");
                }

                using var s = DataLayer.GetSession();
                var prodajnaJedinica = s.Load<Entiteti.ProdajnaJedinicaBasic>(dto.ProdajnaJedinicaId);
                var rv = new RadnoVreme
                {
                    ProdajnaJedinica = prodajnaJedinica,
                    Dan = dto.Dan,
                    VremeOd = dto.VremeOd.Value,
                    VremeDo = dto.VremeDo.Value
                };
                s.Save(rv);
                s.Flush();
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri dodavanju radnog vremena: " + ex.Message);
            }
        }

        public static void ObrisiRadnoVreme(long prodajnaJedinicaId, int dan)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var rv = s.Query<RadnoVreme>()
                    .FirstOrDefault(x => x.ProdajnaJedinica.Id == prodajnaJedinicaId && x.Dan == dan);
                if (rv != null)
                {
                    s.Delete(rv);
                    s.Flush();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri brisanju radnog vremena: " + ex.Message);
            }
        }

        public static bool PostojiRadnoVremeZaProdajnuJedinicu(long prodajnaJedinicaId)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var count = s.Query<RadnoVreme>()
                    .Count(x => x.ProdajnaJedinica.Id == prodajnaJedinicaId);
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri proveri radnog vremena: " + ex.Message);
            }
        }

        public static IList<FarmaceutBasic> VratiSveFarmaceuteUSistemu()
        {
            var list = new List<FarmaceutBasic>();

            try
            {
                using var s = DataLayer.GetSession();
                var rv = s.Query<RasporedRada>().ToList();
                  


                foreach (var x in rv)
                {
                    var z=DTOManagerZaposleni.VratiZaposlenog(x.Zaposleni.Id);
                    if(z is FarmaceutBasic f)
                    {
                        list.Add(f);
                    }
                    
                }

                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri učitavanju radnog vremena: " + ex.Message);
            }
            return list;
        }

        public static IList<MenadzerBasic> VratiSveMenadzereUSistemu()
        {
            var list = new List<MenadzerBasic>();

            try
            {
                using var s = DataLayer.GetSession();
                var rv = s.Query<RasporedRada>().ToList();



                foreach (var x in rv)
                {
                    var z = DTOManagerZaposleni.VratiZaposlenog(x.Zaposleni.Id);
                    if (z is MenadzerBasic f)
                    {
                        list.Add(f);
                    }

                }

                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri učitavanju radnog vremena: " + ex.Message);
            }
            return list;
        }
        public static IList<FarmaceutBasic> VratiSveFarmaceuteZaApoteku(long id)
        {
            var list = new List<FarmaceutBasic>();

            try
            {
                using var s = DataLayer.GetSession();
                var rv = s.Query<RasporedRada>().
                    Where(x=>x.ProdajnaJedinica.Id==id).
                    ToList();




                foreach (var x in rv)
                {
                    var z = DTOManagerZaposleni.VratiZaposlenog(x.Zaposleni.Id);
                    if (z is FarmaceutBasic f)
                    {
                        list.Add(f);
                    }

                }

                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri učitavanju radnog vremena: " + ex.Message);
            }
            return list;
        }


        
    }
}
