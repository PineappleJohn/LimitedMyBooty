using BepInEx;
using System;
using UnityEngine;
using Newtilla;

namespace LimitedMyBooty
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        void Start()
        {
            Newtilla.Newtilla.AddGameMode("GHOSTTAG", "GHOSTTAG", "GHOST", false);
            Newtilla.Newtilla.AddGameMode("AMBUSH", "AMBUSH", "AMBUSH", false);
        }
    }
}
