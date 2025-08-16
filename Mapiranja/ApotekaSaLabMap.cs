using Farmacy.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Mapiranja
{
    public class ApotekaSaLabMap : SubclassMap<ApotekaSaLab>
    {
        public ApotekaSaLabMap()
        {
            Table("Apoteka_sa_lab");
            KeyColumn("id");
            Map(x => x.Napomena, "napomena");
        }
    }
}
