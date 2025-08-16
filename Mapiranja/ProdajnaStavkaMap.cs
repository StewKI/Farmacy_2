using Farmacy.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Mapiranja
{
    public class ProdajnaStavkaMap : ClassMap<ProdajaStavka>
    {
        public ProdajnaStavkaMap()
        {
            Table("Prodaja_stavka");

            // Composite PK
            CompositeId()
                .KeyReference(x => x.Prodaja, "prodaja_id")
                .KeyReference(x => x.Pakovanje, "pakovanje_id");

            Map(x => x.Kolicina, "kolicina").Not.Nullable();

            Map(x => x.Cena, "cena"); // NUMBER(12,2)

            References(x => x.Recept, "recept_serijski_broj") // nullable → OTC vs RX
                .Nullable();

            Map(x => x.KontrolisanaKol, "kontrolisana_kol")
                .Nullable();

            Map(x => x.ProcenatParticip, "procenat_particip")
                .Nullable();

            Map(x => x.NeophodanIzvestaj, "neophodan_izvestaj")
                .Length(1)     // CHAR(1) 'Y'/'N'
                .Nullable();
        }
    }
}
