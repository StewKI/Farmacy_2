using Farmacy.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Mapiranja
{
    public class MenadzerMap : SubclassMap<Menadzer>
    {
        public MenadzerMap()
        {
            Table("Menadzer");
            KeyColumn("m_br");
        }
    }
}
