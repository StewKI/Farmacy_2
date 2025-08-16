using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Entiteti
{
    public class PrimarnaGrupa
    {
        public virtual long Id { get; set; }
        public virtual string Naziv { get; set; } = default!;
    }
}
