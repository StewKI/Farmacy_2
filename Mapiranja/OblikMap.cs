using Farmacy.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Mapiranja
{
    public class OblikMap : ClassMap<Oblik>
    {
        public OblikMap()
        {
            Table("Oblik");
            Id(x => x.Id)
            .Column("id")
            .GeneratedBy.Sequence("oblik_leka_seq");
            Map(x => x.Naziv, "naziv").Not.Nullable().Unique();
        }
    }
}
