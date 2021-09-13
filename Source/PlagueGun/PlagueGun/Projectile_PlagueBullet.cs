using RimWorld;
using Verse;

namespace PlagueGun
{
    class Projectile_PlagueBullet : Bullet
    {

        public ModExtension_PlagueBullet Props => def.GetModExtension<ModExtension_PlagueBullet>();

        protected override void Impact(Thing hitThing)
        {
            base.Impact(hitThing);

            if (Props != null && hitThing != null && hitThing is Pawn hitPawn)
            {

                float rand = Rand.Value;
                if (rand <= Props.addHediffChance)
                {

                    Hediff plagueOnPawn = hitPawn.health?.hediffSet?.GetFirstHediffOfDef(Props.hediffToAdd);

                    float randomSeverity = Rand.Range(0.15f, 0.30f);
                    if (plagueOnPawn != null)
                    {
                        plagueOnPawn.Severity += randomSeverity;
                    }
                    else
                    {
                        Hediff hediff = HediffMaker.MakeHediff(Props.hediffToAdd, hitPawn);
                        hediff.Severity = randomSeverity;
                        hitPawn.health.AddHediff(hediff);
                    }

                }

            }
        }

    }
}
