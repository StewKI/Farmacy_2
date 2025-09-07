using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Farmacy.Mapiranja
{
    internal class RasporedRadaMapiranje
    {
        
            public class RasporedRadaMap : ClassMap<Entiteti.RasporedRada>
            {
                public RasporedRadaMap()
                {
                    Table("RASPORED_RADA");

                    // Složeni primarni ključ = (M_BR, PRODAJNA_JEDINICA_ID, POCETAK)
                    CompositeId()
                        .KeyReference(x => x.Zaposleni, "M_BR")
                        .KeyReference(x => x.ProdajnaJedinica, "PRODAJNA_JEDINICA_ID")
                        .KeyProperty(x => x.Pocetak, "POCETAK");

                    Map(x => x.Kraj)
                        .Column("KRAJ")
                        .Not.Nullable();

                    Map(x => x.BrojSmene)
                        .Column("BROJ_SMENE")
                        .Nullable();
                }
            }
        
    }
}
