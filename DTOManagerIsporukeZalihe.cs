using Farmacy.Entiteti;
using FluentNHibernate.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Assuming MessageBox is in System.Windows.Forms

namespace Farmacy
{
    public static class DTOManagerIsporukeZalihe
    {
        public static long KreirajIsporuku(IsporukaBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var isp = new Isporuka
                {
                    Distributer = s.Load<Distributer>(dto.DistributerId),
                    ProdajnaJedinica = s.Load<Entiteti.ProdajnaJedinicaBasic>(dto.ProdajnaJedinicaId),
                    Datum = dto.Datum,
                    Magacioner = dto.MagacionerMbr.HasValue ? s.Load<Zaposleni>(dto.MagacionerMbr.Value) : null
                };
                s.Save(isp);

                foreach (var st in dto.Stavke)
                {
                    var stavka = new IsporukaStavka
                    {
                        Isporuka = isp,
                        Pakovanje = s.Load<Pakovanje>(st.PakovanjeId),
                        Kolicina = st.Kolicina,
                    };
                    s.Save(stavka);

                    // update Zaliha (upsert)
                    var z = s.Query<Zaliha>()
                             .FirstOrDefault(x => x.ProdajnaJedinica.Id == dto.ProdajnaJedinicaId
                                               && x.Pakovanje.Id == st.PakovanjeId);
                    if (z == null)
                    {
                        z = new Zaliha
                        {
                            ProdajnaJedinica = isp.ProdajnaJedinica,
                            Pakovanje = stavka.Pakovanje,
                            Kolicina = st.Kolicina,
                            DatumPoslednjeIsporuke = dto.Datum,
                            OdgovorniMagacioner = isp.Magacioner,
                        };
                        s.Save(z);
                    }
                    else
                    {
                        z.Kolicina += st.Kolicina;
                        z.DatumPoslednjeIsporuke = dto.Datum;
                        z.OdgovorniMagacioner = isp.Magacioner;
                        s.Update(z);
                    }
                }

                s.Flush();
                dto.Id = isp.Id;
                return isp.Id;
            }
            catch (Exception) { }
            return 0;
        }

        public static IList<ZalihaBasic> VratiZaliheApoteke(long prodajnaJedinicaId)
        {
            var list = new List<ZalihaBasic>();
            try
            {
                using var s = DataLayer.GetSession();
                var zalihe = s.Query<Zaliha>()
                              .Where(x => x.ProdajnaJedinica.Id == prodajnaJedinicaId)
                              .ToList();
                foreach (var z in zalihe)
                {
                    list.Add(new ZalihaBasic
                    {
                        ProdajnaJedinicaId = z.ProdajnaJedinica.Id,
                        PakovanjeId = z.Pakovanje.Id,
                        Kolicina = z.Kolicina,
                        DatumPoslednjeIsporuke = z.DatumPoslednjeIsporuke,
                        OdgovorniMagacionerMbr = z.OdgovorniMagacioner?.MBr
                    });
                }
            }
            catch (Exception) { }
            return list;
        }

        public static void DodajDistributera(DistributerBasic dto)
        {
            try
            {
                using var s = DataLayer.GetSession();
                
                var d1 = new Distributer
                {
                    Naziv=dto.Naziv,
                    Kontakt=dto.Kontakt,
                };
                s.Save(d1);
                s.Flush();

                MessageBox.Show(
            $"Uspesno je dodat distributer",
            "Uspesno",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
           $"Greška pri dodavanju LekSekundarnaKategorija: {ex.Message}",
           "Greška",
           MessageBoxButtons.OK,
           MessageBoxIcon.Error);
            }
        }

        public static void DodajRecept(Recept r)
        {
            try
            {
                using var s = DataLayer.GetSession();

                var d1 = new Recept
                {
                    SerijskiBroj=r.SerijskiBroj,
                    SifraLekara=r.SifraLekara,
                    DatumIzd=r.DatumIzd,
                    Status=r.Status,
                    NazivUstanove=r.NazivUstanove,
                };
                s.Save(d1);
                s.Flush();

                MessageBox.Show(
            $"Uspesno je dodat recept",
            "Uspesno",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
           $"Greška pri dodavanju Recepta: {ex.Message}",
           "Greška",
           MessageBoxButtons.OK,
           MessageBoxIcon.Error);
            }

        }

        public static void RealizujRecept(string idR, ProdajnaJedinicaBasic p,DateTime d)
        {
            try
            {
                using var s = DataLayer.GetSession();
                var r = s.Get<Recept>(idR);
                var p1=s.Get<Entiteti.ProdajnaJedinicaBasic>(p.Id);
                if (r.RealizovaoFarmaceut != null)
                {
                    throw new Exception("Recept je vec realizovan");
                    
                }
                if(r !=null)
                {
                    r.RealizovanaProdajnaJedinica = p1;
                    r.RealizovaoFarmaceut = DTOManagerZaposleni.VratiOdgovornogFarmaceuta(p.OdgovorniFarmaceutMbr);
                    r.RealizacijaDatum = d;

                }
                s.Update(r);
                s.Flush();

                MessageBox.Show(
            $"Uspesno je realizovan recept",
            "Uspesno",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
           $"Greška pri realizaciji Recepta: {ex.Message}",
           "Greška",
           MessageBoxButtons.OK,
           MessageBoxIcon.Error);
            }

        }
    }
}
