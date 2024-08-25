using BepInEx;
using Menu.Remix.MixedUI;
using On.RWCustom;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;
using static DummyMod.PluginInfo;
namespace DummyMod;

[BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]


public partial class DummyMod : BaseUnityPlugin
{



    public DummyMod()
    {
       
    }



    private void Awake()
    {
        
        On.RainWorld.OnModsInit += RainWorldOnOnModsInitDetour;
       
    }

  



    private void RainWorldOnOnModsInitDetour(On.RainWorld.orig_OnModsInit orig, RainWorld self)
    {

        orig(self);
        
     
    }

   
}