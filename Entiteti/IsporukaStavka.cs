using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Entiteti
{
    public class IsporukaStavka
    {
        public virtual long IsporukaId { get; set; }
        public virtual long PakovanjeId { get; set; }
        public virtual int Kolicina { get; set; }

        public virtual Isporuka Isporuka { get; set; } = default!;
        public virtual Pakovanje Pakovanje { get; set; } = default!;
    }

}
