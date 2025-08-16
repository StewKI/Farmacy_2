using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Entiteti
{
    public class LekSekundarna
    {
        public virtual long LekId { get; set; }
        public virtual long KategorijaId { get; set; }

        public virtual Lek Lek { get; set; } = default!;
        public virtual SekundarnaKategorija Kategorija { get; set; } = default!;
    }
}
