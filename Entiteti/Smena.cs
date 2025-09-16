using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Entiteti
{
    public class Smena
    {
        public virtual long MBr { get; set; }
        public virtual long ProdajnaJedinicaId { get; set; }
        public virtual DateTime Pocetak { get; set; }  // (M_BR, PRODAJNA_JEDINICA_ID, POCETAK)
        public virtual DateTime Datum { get; set; }
        public virtual int BrojSmene { get; set; }

        // Kompozitni identitet (roditelj+delimični ključ)
        public virtual RasporedRada RasporedRada { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj)) return true;
            if (obj is null || obj.GetType() != GetType()) return false;
            var o = (Smena)obj;
            return MBr == o.MBr
                && ProdajnaJedinicaId == o.ProdajnaJedinicaId
                && Pocetak == o.Pocetak
                && Datum == o.Datum
                && BrojSmene == o.BrojSmene;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int h = 17;
                h = h * 23 + MBr.GetHashCode();
                h = h * 23 + ProdajnaJedinicaId.GetHashCode();
                h = h * 23 + Pocetak.GetHashCode();
                h = h * 23 + Datum.GetHashCode();
                h = h * 23 + BrojSmene.GetHashCode();
                return h;
            }
        }
    }
}
