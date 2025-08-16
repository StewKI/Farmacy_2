using Farmacy.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Mapiranja
{
    public class LekMap : ClassMap<Lek>
    {
        public LekMap()
        {
            Table("Lek");
            Id(x => x.Id, "id").GeneratedBy.Identity();
            Map(x => x.HemijskiNaziv, "hemijski_naziv").Not.Nullable().Unique();
            Map(x => x.KomercijalniNaziv, "komercijalni_naziv").Not.Nullable();
            Map(x => x.Dejstvo, "dejstvo");

            References(x => x.Proizvodjac, "proizvodjac_id").Not.Nullable();
            References(x => x.PrimarnaGrupa, "primarna_grupa_id").Not.Nullable();

            HasMany(x => x.Pakovanja).KeyColumn("lek_id").Inverse().Cascade.All();
            HasMany(x => x.Sekundarne).KeyColumn("lek_id").Inverse().Cascade.All();
        }
    }
}
