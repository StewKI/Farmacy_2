using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Entiteti
{
    public class Recept
    {
        // PK
        public virtual string SerijskiBroj { get; set; } = default!;

        // Columns
        public virtual string SifraLekara { get; set; } = default!;
        public virtual DateTime DatumIzd { get; set; }          // DATE
        public virtual string Status { get; set; } = default!;  // 'IZDAT' | 'CEKANJE' | 'ODBIJEN'
        public virtual string NazivUstanove { get; set; } = default!;

        // FKs (nullable in schema)
        public virtual ProdajnaJedinica? RealizovanaProdajnaJedinica { get; set; }
        public virtual DateTime? RealizacijaDatum { get; set; } // DATE
        public virtual FarmaceutBasic? RealizovaoFarmaceut { get; set; }
    }
}
