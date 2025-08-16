using Farmacy.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Mapiranja
{
    public class FarmaceutMap : SubclassMap<Farmaceut>
    {
        public FarmaceutMap()
        {
            Table("Farmaceut");
            KeyColumn("m_br");

            Map(x => x.DatumDiplomiranja, "datum_diplomiranja").CustomType("date").Not.Nullable();
            Map(x => x.BrLicence, "br_licence").Not.Nullable().Unique();
            Map(x => x.DatumPoslObnoveLicence, "datum_poslednje_obnove_licence").CustomType("date").Not.Nullable();
            Map(x => x.Specijalnost, "specijalnost");
        }
    }
}
