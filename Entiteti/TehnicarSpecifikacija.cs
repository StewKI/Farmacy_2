using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Entiteti
{
    public class TehnicarSertifikacija : IEquatable<TehnicarSertifikacija>
    {
        public virtual Tehnicar Tehnicar { get; set; } = default!;
        public virtual string Naziv { get; set; } = default!;
        public virtual DateTime Datum { get; set; }

        // ---- Equality za composite-id (Tehnicar.MBr, Naziv) ----
        public virtual bool Equals(TehnicarSertifikacija? other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            var thisMbr = Tehnicar?.Id;
            var otherMbr = other.Tehnicar?.Id;

            return Equals(thisMbr, otherMbr)
                && string.Equals(Naziv, other.Naziv, StringComparison.Ordinal);
        }

        public override bool Equals(object? obj) => Equals(obj as TehnicarSertifikacija);

        public override int GetHashCode()
        {
            unchecked
            {
                int h = 17;
                h = h * 23 + (Tehnicar?.Id.GetHashCode() ?? 0);
                h = h * 23 + (Naziv?.GetHashCode() ?? 0);
                return h;
            }
        }
    }
}
