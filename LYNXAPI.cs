using System;
using BepInEx;
using HarmonyLib;
using System.Linq;
using UnityEngine;
using BepInEx.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using BepInEx.Logging;
using BBI.Unity.Game;
using Logger = BepInEx.Logging.Logger;
using BBI;

namespace LYNXAPI {
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    public class LYNXAPI : BaseUnityPlugin {

        public const string PluginGUID = "com.bepis.lynxapi";
        public const string PluginName = "LYNXAPI";
        public const string PluginVersion = "0.0.1";

        
        public static ManualLogSource LogSource;

        void Awake()
        {
            

        }

        void Start()
        {
            
        }
        



    }
}