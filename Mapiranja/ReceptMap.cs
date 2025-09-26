using Farmacy.Entiteti;
using FluentNHibernate.Mapping;
using NHibernate.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Mapiranja
{
    public class ReceptMap : ClassMap<Recept>
    {
        public ReceptMap()
        {
            Table("Recept");

            Id(x => x.SerijskiBroj, "serijski_broj").GeneratedBy.Assigned();

            Map(x => x.SifraLekara, "sifra_lekara").Not.Nullable();
            Map(x => x.DatumIzd, "datum_izd").CustomType<DateType>().Not.Nullable();
            Map(x => x.Status, "status").Not.Nullable();
            Map(x => x.NazivUstanove, "naziv_ustanove").Not.Nullable();

            References(x => x.RealizovanaProdajnaJedinica, "realiz_prod_jed_id").Nullable();
            Map(x => x.RealizacijaDatum, "realizacija_datum").CustomType<DateType>().Nullable();
            References(x => x.RealizovaoFarmaceut, "realizovao_farmaceut_id").Nullable();
        }
    }
}
