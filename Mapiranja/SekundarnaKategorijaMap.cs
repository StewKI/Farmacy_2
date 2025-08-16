using Farmacy.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Mapiranja
{
    public class SekundarnaKategorijaMap : ClassMap<SekundarnaKategorija>
    {
        public SekundarnaKategorijaMap()
        {
            Table("Sekundarna_kategorija");
            Id(x => x.Id, "id").GeneratedBy.Identity();
            Map(x => x.Naziv, "naziv").Not.Nullable().Unique();
        }
    }
}
