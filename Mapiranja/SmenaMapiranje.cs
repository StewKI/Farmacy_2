using Farmacy.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Mapiranja
{
    internal class SmenaMapiranje : ClassMap<Smena>
    {
        public SmenaMapiranje()
        {
            Table("SMENA");
           
                CompositeId()
      .KeyProperty(x => x.MBr, "M_BR")
      .KeyProperty(x => x.ProdajnaJedinicaId, "PRODAJNA_JEDINICA_ID")
      .KeyProperty(x => x.Pocetak, "POCETAK")
      .KeyProperty(x => x.Datum, "DATUM")
      .KeyProperty(x => x.BrojSmene, "BROJ_SMENE");

            // (opciono) ako želiš i eksplicitnu referencu van CompositeId
            References(x => x.RasporedRada)
           .Columns("M_BR", "PRODAJNA_JEDINICA_ID", "POCETAK")
           .Not.Nullable()
           .Not.Insert()
           .Not.Update();
        }
    }
}
