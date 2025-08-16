using Farmacy.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TehnicarSertifikacijaMap : ClassMap<TehnicarSertifikacija>
{
    public TehnicarSertifikacijaMap()
    {
        Table("Tehnicar_sertifikacija");
        CompositeId()
            .KeyProperty(x => x.MBrTehnicara, "m_br_tehnicara")
            .KeyProperty(x => x.Naziv, "naziv");
        Map(x => x.Datum, "datum").CustomType("date").Not.Nullable();

        References(x => x.Tehnicar, "m_br_tehnicara").Not.Nullable();
    }
}
