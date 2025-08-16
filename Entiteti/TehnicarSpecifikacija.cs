using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Entiteti
{
    public class TehnicarSertifikacija
    {
        public virtual long MBrTehnicara { get; set; }
        public virtual string Naziv { get; set; } = default!;
        public virtual DateTime Datum { get; set; }
        public virtual Tehnicar Tehnicar { get; set; } = default!;
    }
}
