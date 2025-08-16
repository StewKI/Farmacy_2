using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Entiteti
{
    public class Zaliha
    {
        public virtual long ProdajnaJedinicaId { get; set; }
        public virtual long PakovanjeId { get; set; }
        public virtual int Kolicina { get; set; }
        public virtual DateTime? DatumPoslednjeIsporuke { get; set; }
        public virtual Zaposleni? OdgovorniMagacioner { get; set; }

        public virtual ProdajnaJedinica ProdajnaJedinica { get; set; } = default!;
        public virtual Pakovanje Pakovanje { get; set; } = default!;
    }
}
