using Farmacy.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Mapiranja
{
    public class IsporukaStavkaMap : ClassMap<IsporukaStavka>
    {
        public IsporukaStavkaMap()
        {
            Table("Isporuka_stavka");
            CompositeId()
                .KeyProperty(x => x.IsporukaId, "isporuka_id")
                .KeyProperty(x => x.PakovanjeId, "pakovanje_id");
            Map(x => x.Kolicina, "kolicina").Not.Nullable();

            References(x => x.Isporuka, "isporuka_id").Not.Nullable();
            References(x => x.Pakovanje, "pakovanje_id").Not.Nullable();
        }
    }
}
