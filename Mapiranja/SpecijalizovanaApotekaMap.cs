using Farmacy.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Mapiranja
{
    public class SpecijalizovanaApotekaMap : SubclassMap<SpecijalizovanaApoteka>
    {
        public SpecijalizovanaApotekaMap()
        {
            Table("Specijalizovana_apoteka");
            KeyColumn("id");
            Map(x => x.SpecijalnostTipa, "specijalnost_tipa");
            Map(x => x.Napomena, "napomena");
        }
    }
}
