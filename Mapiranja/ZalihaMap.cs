﻿using Farmacy.Entiteti;
using FluentNHibernate.Mapping;
using NHibernate.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Mapiranja
{
    public class ZalihaMap : ClassMap<Zaliha>
    {
        public ZalihaMap()
        {
            Table("Zaliha");

            CompositeId()
                .KeyReference(x => x.ProdajnaJedinica, "prodajna_jedinica_id")
                .KeyReference(x => x.Pakovanje, "pakovanje_id");

            Map(x => x.Kolicina, "kolicina").Not.Nullable();

            Map(x => x.DatumPoslednjeIsporuke, "datum_poslednje_isporuke")
                .CustomType<DateType>()
                .Nullable();

            References(x => x.OdgovorniMagacioner, "odgovorni_magacioner_mbr")
                .Nullable();

        }
    }
}
