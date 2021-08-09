using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;

namespace Plague
{
    public class ThingDef_PlagueBullet : ThingDef
    {
        public float addHediffChance = 0.5f;
        public HediffDef HediffToAdd = HediffDefOf.Plague;
    }
}
