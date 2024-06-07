using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using HarmonyLib;
using MEC;
using Handlers = Exiled.Events.Handlers;

namespace PrimitiveCollisionFix;

public class Plugin : Plugin<Config>
{
    public override string Prefix => "PrimitiveCollisionFix";
    public override string Name => Prefix;
    public override string Author => "BanalnyBanan";
    public override Version Version { get; } = new(1, 0, 0);
    public static Plugin Instance;

    private static Harmony harmony;

    public override void OnEnabled()
    {
        Instance = this;
        harmony = new Harmony("com.banalnybanan.primitivecollisionfix");
        harmony.PatchAll();
        base.OnEnabled();
    }

    public override void OnDisabled()
    {
        Instance = null;
        harmony.UnpatchAll();
        base.OnDisabled();
    }
}