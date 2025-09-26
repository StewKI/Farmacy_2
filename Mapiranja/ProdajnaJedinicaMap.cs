using Farmacy.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Mapiranja
{
    public class ProdajnaJedinicaMap : ClassMap<Entiteti.ProdajnaJedinicaBasic>
    {
        public ProdajnaJedinicaMap()
        {
            Table("Prodajna_jedinica");
            Id(x => x.Id, "id").GeneratedBy.Identity();
            Map(x => x.Naziv, "naziv").Not.Nullable();
            Map(x => x.Ulica, "ulica").Not.Nullable();
            Map(x => x.Broj, "broj").Not.Nullable();
            Map(x => x.PostanskiBroj, "postanski_broj").Not.Nullable();
            Map(x => x.Mesto, "mesto").Not.Nullable();

            References(x => x.OdgovorniFarmaceut, "odgovorni_farmaceut_id").Not.Nullable();

            HasMany(x => x.RadnaVremena)
                .KeyColumn("prodajna_jedinica_id")
                .Cascade.All()
                .Inverse();
        }
    }
}
