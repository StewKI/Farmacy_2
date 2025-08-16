using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Entiteti
{
    public class Distributer
    {
        public virtual long Id { get; set; }
        public virtual string Naziv { get; set; } = default!;
        public virtual string? Kontakt { get; set; }
    }

}
