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
using Logger = BepInEx.Logging.Logger;
using BBI.Unity.Game;

namespace LYNXAPI.Core
{
    class Initialiser
    {
        public static AssetBundle bundle;
        public static string keyWord = ""; 
        public static ManualLogSource LogSource;

        /// <summary>
        /// Initialises the API with needed data
        /// </summary>
        /// <param name="bundleName"></param>
        /// <param name="keyword"></param>
        /// <param name="requireBundle"></param>
        public static void Init(string bundleName, string keyword, bool requireBundle)
        {

            LogSource = Logger.CreateLogSource("LYNXAPI-" + keyword);
            keyWord = keyword;

            //Get location of the plugin
            string pluginfolder = Path.GetDirectoryName(Assembly.GetAssembly(typeof(LYNXAPI)).Location);


            if (requireBundle)
            {
                //Load assetbundle 
                bundle = AssetBundle.LoadFromFile($"{pluginfolder}/{bundleName}");
            }

            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
