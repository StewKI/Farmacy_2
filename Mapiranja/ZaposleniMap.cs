using Farmacy.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace Farmacy.Mapiranja
{
    public class ZaposleniMap : ClassMap<Zaposleni>
    {
        public ZaposleniMap()
        {
            Table("Zaposleni");
            Id(x => x.MBr, "m_br").GeneratedBy.Assigned();
            Map(x => x.Ime, "ime").Not.Nullable();
            Map(x => x.Prezime, "prezime").Not.Nullable();
            Map(x => x.DatumRodj, "datum_rodj").CustomType("date").Not.Nullable();
            Map(x => x.Adresa, "adresa");
            Map(x => x.Telefon, "telefon");
            Map(x => x.DatumZaposlenja, "datum_zaposlenja").CustomType("date").Not.Nullable();
        }
    }
}
