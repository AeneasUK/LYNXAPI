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


namespace LYNXtools
{
    public class LYNXtools
    {
        
        public static AssetBundle bundle;
        public static string keyWord = ""; // because who doesn't need a safe word in unconsensual modding ;p
        public static ManualLogSource LogSource;

        public static void Init(string bundleName, string keyword, bool requireBundle)
        {

            LogSource = Logger.CreateLogSource("LYNXtools-" + keyword);
            keyWord = keyword;

            //Get location of the plugin
            string pluginfolder = Path.GetDirectoryName(Assembly.GetAssembly(typeof(LYNXtools)).Location);


            if (requireBundle)
            {
                //Load assetbundle 
                bundle = AssetBundle.LoadFromFile($"{pluginfolder}/{bundleName}");
            }

            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
        }
    }
}