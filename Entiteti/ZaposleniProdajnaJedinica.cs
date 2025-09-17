using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Entiteti
{
    public class ZaposleniProdajnaJedinica
    {
        public virtual Zaposleni Zaposleni { get; set; } = default!;
        public virtual ProdajnaJedinicaBasic ProdajnaJedinica { get; set; } = default!;
        public virtual DateTime DatumPocetka { get; set; }
        public virtual DateTime? DatumKraja { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as ZaposleniProdajnaJedinica;
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;

            var thisZapId = Zaposleni?.MBr ?? 0;
            var otherZapId = other.Zaposleni?.MBr ?? 0;

            var thisPjId = ProdajnaJedinica?.Id ?? 0;
            var otherPjId = other.ProdajnaJedinica?.Id ?? 0;

            return thisZapId == otherZapId
                && thisPjId == otherPjId
                && DatumPocetka == other.DatumPocetka;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int h = 17;
                h = h * 23 + (Zaposleni?.MBr ?? 0).GetHashCode();
                h = h * 23 + (ProdajnaJedinica?.Id ?? 0).GetHashCode();
                h = h * 23 + DatumPocetka.GetHashCode();
                return h;
            }
        }
    }
}
