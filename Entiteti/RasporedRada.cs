using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Entiteti
{
    public class RasporedRada
    {
        public virtual Zaposleni Zaposleni { get; set; }
        public virtual ProdajnaJedinicaBasic ProdajnaJedinica { get; set; }
        public virtual DateTime Pocetak { get; set; }
        public virtual DateTime Kraj { get; set; }
        public virtual int? BrojSmene { get; set; }

        public override bool Equals(object? obj)
        {
            var other = obj as RasporedRada;
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;

            var thisZapId = Zaposleni?.Id ?? 0;
            var otherZapId = other.Zaposleni?.Id ?? 0;

            var thisPjId = ProdajnaJedinica?.Id ?? 0;
            var otherPjId = other.ProdajnaJedinica?.Id ?? 0;

            return thisZapId == otherZapId
                && thisPjId == otherPjId
                && Pocetak == other.Pocetak;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int h = 17;
                h = h * 23 + (Zaposleni?.Id ?? 0).GetHashCode();
                h = h * 23 + (ProdajnaJedinica?.Id ?? 0).GetHashCode();
                h = h * 23 + Pocetak.GetHashCode();
                return h;
            }
        }
    }
}
