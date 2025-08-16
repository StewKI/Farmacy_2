using Farmacy.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Mapiranja
{
    public class ProizvodjacMap : ClassMap<Proizvodjac>
    {
        public ProizvodjacMap()
        {
            Table("Proizvodjac");
            Id(x => x.Id, "id").GeneratedBy.Identity();
            Map(x => x.Naziv, "naziv").Not.Nullable();
            Map(x => x.Zemlja, "zemlja").Not.Nullable();
            Map(x => x.Telefon, "telefon");
            Map(x => x.Email, "email");
            HasMany(x => x.Lekovi).KeyColumn("proizvodjac_id").Inverse();
        }
    }
}
