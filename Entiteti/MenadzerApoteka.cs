using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Entiteti
{
    public class MenadzerApoteka
    {
        public virtual long MBrMenadzera { get; set; }
        public virtual long ProdajnaJedinicaId { get; set; }
        public virtual DateTime Od { get; set; }
        public virtual DateTime? Do { get; set; }

        public virtual Menadzer Menadzer { get; set; } = default!;
        public virtual ProdajnaJedinica ProdajnaJedinica { get; set; } = default!;
    }
}
