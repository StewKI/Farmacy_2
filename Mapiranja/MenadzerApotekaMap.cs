using Farmacy.Entiteti;
using FluentNHibernate.Mapping;
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
                .KeyProperty(x => x.MBrMenadzera, "m_br_menadzera")
                .KeyProperty(x => x.ProdajnaJedinicaId, "prodajna_jedinica_id")
                .KeyProperty(x => x.Od, "od");
            Map(x => x.Do, "do").CustomType("date");
            References(x => x.Menadzer, "m_br_menadzera").Not.Nullable();
            References(x => x.ProdajnaJedinica, "prodajna_jedinica_id").Not.Nullable();
        }
    }
}
