using Farmacy.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Mapiranja
{
    public class TehnicarMap : SubclassMap<Tehnicar>
    {
        public TehnicarMap()
        {
            Table("Tehnicar");
            KeyColumn("m_br");  // PK isti kao Zaposleni

            Map(x => x.NivoObrazovanja, "nivo_obrazovanja").Not.Nullable();
        }
    }
}
