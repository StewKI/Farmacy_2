using Farmacy.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Mapiranja
{
    public class ZaposleniProdajnaJedinicaMap : ClassMap<ZaposleniProdajnaJedinica>
    {
        public ZaposleniProdajnaJedinicaMap()
        {
            Table("Zaposleni_Prodajna_Jedinica");

            // Složeni primarni ključ = (m_br, prodajna_jedinica_id, datum_pocetka)
            CompositeId()
                .KeyReference(x => x.Zaposleni, "m_br")
                .KeyReference(x => x.ProdajnaJedinica, "prodajna_jedinica_id")
                .KeyProperty(x => x.DatumPocetka, "datum_pocetka");

            Map(x => x.DatumKraja, "datum_kraja")
                .CustomType("date")
                .Nullable();
        }
    }
}
