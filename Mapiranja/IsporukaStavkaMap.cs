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
                .KeyReference(x => x.Isporuka, "isporuka_id")
                .KeyReference(x => x.Pakovanje, "pakovanje_id");

            Map(x => x.Kolicina, "kolicina").Not.Nullable();
        }
    }
}
