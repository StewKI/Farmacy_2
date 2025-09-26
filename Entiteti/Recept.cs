using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Entiteti
{
    public class Recept
    {
        public virtual string SerijskiBroj { get; set; } = default!;

        public virtual string SifraLekara { get; set; } = default!;
        public virtual DateTime DatumIzd { get; set; }
        public virtual string Status { get; set; } = default!;
        public virtual string NazivUstanove { get; set; } = default!;

        public virtual ProdajnaJedinicaBasic? RealizovanaProdajnaJedinica { get; set; }
        public virtual DateTime? RealizacijaDatum { get; set; }
        public virtual FarmaceutBasic? RealizovaoFarmaceut { get; set; }
    }
}
