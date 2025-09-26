using Farmacy.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Mapiranja
{
    public class TehnicarMap : SubclassMap<Entiteti.Tehnicar>
    {
        public TehnicarMap()
        {
            Table("Tehnicar");
            KeyColumn("id");
            Map(x => x.NivoObrazovanja, "nivo_obrazovanja").Not.Nullable();
        }
    }
}
