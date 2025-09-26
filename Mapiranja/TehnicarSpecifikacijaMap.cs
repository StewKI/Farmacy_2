using Farmacy.Entiteti;
using FluentNHibernate.Mapping;
using NHibernate.Type;
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
            .KeyReference(x => x.Tehnicar, "id_tehnicara")
            .KeyProperty(x => x.Naziv, "naziv");

        Map(x => x.Datum, "datum")
            .CustomType<DateType>()
            .Not.Nullable();
    }
}
