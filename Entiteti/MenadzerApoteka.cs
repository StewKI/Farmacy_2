﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacy.Entiteti
{
    public class MenadzerApoteka : IEquatable<MenadzerApoteka>
    {
        public virtual MenadzerBasic Menadzer { get; set; } = default!;
        public virtual ProdajnaJedinicaBasic ProdajnaJedinica { get; set; } = default!;
        public virtual DateTime Od { get; set; }
        public virtual DateTime? Do { get; set; }
        public virtual DateTime? datumKontrole { get; set; }

        public virtual bool Equals(MenadzerApoteka? other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            var thisMenId = Menadzer?.Id;
            var otherMenId = other.Menadzer?.Id;
            var thisPjId = ProdajnaJedinica?.Id;
            var otherPjId = other.ProdajnaJedinica?.Id;

            return Equals(thisMenId, otherMenId)
                && Equals(thisPjId, otherPjId)
                && Od == other.Od;
        }

        public override bool Equals(object? obj) => Equals(obj as MenadzerApoteka);

        public override int GetHashCode()
        {
            unchecked
            {
                int h = 17;
                h = h * 23 + (Menadzer?.Id.GetHashCode() ?? 0);
                h = h * 23 + (ProdajnaJedinica?.Id.GetHashCode() ?? 0);
                h = h * 23 + Od.GetHashCode();
                return h;
            }
        }
    }
}
