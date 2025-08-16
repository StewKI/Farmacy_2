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
    public class MenadzerApotekaMap : ClassMap<MenadzerApoteka>
    {
        public MenadzerApotekaMap()
        {
            Table("Menadzer_Apoteka");

            CompositeId()
                .KeyReference(x => x.Menadzer, "m_br_menadzera")
                .KeyReference(x => x.ProdajnaJedinica, "prodajna_jedinica_id")
                .KeyProperty(x => x.Od, "od").CustomType<DateType>();

            Map(x => x.Do, "do").CustomType<DateType>().Nullable();
        }
    }
}
