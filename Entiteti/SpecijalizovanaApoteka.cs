using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Entiteti
{
    public class SpecijalizovanaApoteka : ProdajnaJedinica
    {
        public virtual string? SpecijalnostTipa { get; set; }
        public virtual string? Napomena { get; set; }
    }
}
