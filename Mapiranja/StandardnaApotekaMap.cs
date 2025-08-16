using Farmacy.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Mapiranja
{
    public class StandardnaApotekaMap : SubclassMap<StandardnaApoteka>
    {
        public StandardnaApotekaMap()
        {
            Table("Standardna_apoteka");
            KeyColumn("id");
            Map(x => x.Napomena, "napomena");
        }
    }
}
