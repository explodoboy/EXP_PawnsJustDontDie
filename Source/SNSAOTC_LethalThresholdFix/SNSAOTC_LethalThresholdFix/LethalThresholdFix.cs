using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using HarmonyLib;
using Verse;
using System.Reflection;

namespace SNSAOTC_LethalThresholdFix
{
    [StaticConstructorOnStartup]
    static class Patch_LethalThreshold
    {
        static Patch_LethalThreshold()
        {
            new Harmony("explodoboy.SNSAmbitionCosmic").PatchAll();
        }
        [HarmonyPatch(typeof(Pawn_HealthTracker), nameof(Pawn_HealthTracker.LethalDamageThreshold), MethodType.Getter)]
        class PatchHarmony_LethalThreshold
        {
            [HarmonyPostfix]
            public static void LethalDamageThresholdPostfix(ref float __result)
            {
                __result = 24000f;
            }
        }
    }
}
