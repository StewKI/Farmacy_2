using Farmacy.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Mapiranja
{
    public class ZalihaMap : ClassMap<Zaliha>
    {
        public ZalihaMap()
        {
            Table("Zaliha");
            CompositeId()
                .KeyProperty(x => x.ProdajnaJedinicaId, "prodajna_jedinica_id")
                .KeyProperty(x => x.PakovanjeId, "pakovanje_id");

            Map(x => x.Kolicina, "kolicina").Not.Nullable();
            Map(x => x.DatumPoslednjeIsporuke, "datum_poslednje_isporuke").CustomType("date");
            References(x => x.OdgovorniMagacioner, "odgovorni_magacioner_mbr").Nullable();

            References(x => x.ProdajnaJedinica, "prodajna_jedinica_id").Not.Nullable();
            References(x => x.Pakovanje, "pakovanje_id").Not.Nullable();
        }
    }
}
