using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BBI;
using BBI.Core;
using BBI.Unity.Core;
using BBI.Unity.Game;
using HarmonyLib;
using BepInEx;



namespace LYNXtool.Core
{
    public class Patcher
    {
        public void DoPatches()
        {
            var harmony = new Harmony("com.bepis.lynxapi");
            harmony.PatchAll();
        }
    }

}