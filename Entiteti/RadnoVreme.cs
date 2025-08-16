using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Entiteti
{
    public class RadnoVreme
    {
        public virtual long ProdajnaJedinicaId { get; set; }
        public virtual int Dan { get; set; }                // 1..7
        public virtual TimeSpan VremeOd { get; set; }       // mapiramo na INTERVAL kao string/seconds – vidi mapu
        public virtual TimeSpan VremeDo { get; set; }

        public virtual ProdajnaJedinica ProdajnaJedinica { get; set; } = default!;
    }
}
