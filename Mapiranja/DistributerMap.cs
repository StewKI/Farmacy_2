using Farmacy.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Mapiranja
{
    public class DistributerMap : ClassMap<Distributer>
    {
        public DistributerMap()
        {
            Table("Distributer");
            Id(x => x.Id, "id").GeneratedBy.Identity();
            Map(x => x.Naziv, "naziv").Not.Nullable();
            Map(x => x.Kontakt, "kontakt");
        }
    }
}
