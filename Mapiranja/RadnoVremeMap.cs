using Farmacy.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Mapiranja
{
    public class RadnoVremeMap : ClassMap<RadnoVreme>
    {
        public RadnoVremeMap()
        {
            Table("Radno_vreme");
            CompositeId()
                .KeyProperty(x => x.ProdajnaJedinicaId, "prodajna_jedinica_id")
                .KeyProperty(x => x.Dan, "dan");
            // Oracle INTERVAL mapiranje – praktičan pristup: čuvaj u sekundama ili HH24:MI i konvertuj.
            // Ako kolona ostaje INTERVAL, koristi custom IUserType. Ovde: čuvamo kao minute (NUMBER) – vidi "mala izmena" u dokumentu, ako želiš bez custom type.
            Map(x => x.VremeOd, "vreme_od").CustomSqlType("INTERVAL DAY TO SECOND");
            Map(x => x.VremeDo, "vreme_do").CustomSqlType("INTERVAL DAY TO SECOND");

            References(x => x.ProdajnaJedinica, "prodajna_jedinica_id").Not.Nullable();
        }
    }
}
