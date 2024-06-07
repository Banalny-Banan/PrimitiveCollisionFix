using AdminToys;
using Exiled.API.Features;
using HarmonyLib;
using MapEditorReborn.API.Features.Objects;
using UnityEngine;

namespace PrimitiveCollisionFix;

//patch Init of SchematicObject
[HarmonyPatch(typeof(PrimitiveObject), nameof(PrimitiveObject.UpdateObject))]
public static class PrimitiveObject_UpdateObject_Patch
{
    public static void Postfix(PrimitiveObject __instance)
    {
        if (__instance.Scale.x < 0 || __instance.Scale.y < 0 || __instance.Scale.z < 0)
        {
            if (__instance.Primitive.AdminToyBase is PrimitiveObjectToy ptimitiveToy)
            {
                ptimitiveToy.NetworkPrimitiveFlags &= ~PrimitiveFlags.Collidable;
            }
        }
    }
}