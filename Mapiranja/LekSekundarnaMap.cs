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
                .KeyReference(x => x.Lek, "lek_id")
                .KeyReference(x => x.Kategorija, "kategorija_id");

        }
    }
}
