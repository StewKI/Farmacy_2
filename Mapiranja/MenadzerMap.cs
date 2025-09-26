using Farmacy.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Mapiranja
{
    public class MenadzerMap : SubclassMap<Entiteti.MenadzerBasic>
    {
        public MenadzerMap()
        {
            Table("Menadzer");
            KeyColumn("id");
        }
    }
}
