﻿using Farmacy.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy
{
    public class Prodaja
    {
        public virtual long Id { get; set; }

        public virtual ProdajnaJedinica ProdajnaJedinica { get; set; } = default!;
        public virtual DateTime DatumVreme { get; set; }
        public virtual Zaposleni? Blagajnik { get; set; }

        public virtual ISet<ProdajaStavka> Stavke { get; set; } = new HashSet<ProdajaStavka>();
    }
}
