using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Entiteti
{
    public class MenadzerBasic : Zaposleni
    {
        public virtual ISet<MenadzerApoteka> Apoteke { get; set; } = new HashSet<MenadzerApoteka>();
    }
}
