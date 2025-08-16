using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Entiteti
{
    public class Tehnicar : Zaposleni
    {
        public virtual string NivoObrazovanja { get; set; } = default!;
        public virtual ISet<TehnicarSertifikacija> Sertifikacije { get; set; } = new HashSet<TehnicarSertifikacija>();
    }
}
