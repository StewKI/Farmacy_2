using Farmacy.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Mapiranja
{
    public class LekSekundarnaMap : ClassMap<LekSekundarna>
    {
        public LekSekundarnaMap()
        {
            Table("Lek_Sekundarna");
            CompositeId()
                .KeyProperty(x => x.LekId, "lek_id")
                .KeyProperty(x => x.KategorijaId, "kategorija_id");

            References(x => x.Lek, "lek_id").Not.Nullable();
            References(x => x.Kategorija, "kategorija_id").Not.Nullable();
        }
    }
}
