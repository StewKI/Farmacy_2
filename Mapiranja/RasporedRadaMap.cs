using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Farmacy.Mapiranja
{
    public class RasporedRadaMap : ClassMap<Entiteti.RasporedRada>
    {
        public RasporedRadaMap()
        {
            Table("Raspored_rada");

            CompositeId()
                .KeyReference(x => x.Zaposleni, "id_zaposlenog")
                .KeyReference(x => x.ProdajnaJedinica, "prodajna_jedinica_id")
                .KeyProperty(x => x.Pocetak, "pocetak");

            Map(x => x.Kraj)
                .Column("kraj")
                .Not.Nullable();

            Map(x => x.BrojSmene)
                .Column("broj_smene")
                .Nullable();
        }
    }
}
