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
    public class LYNXtools
    {
        
        public static AssetBundle bundle;
        public static string keyWord = ""; // because who doesn't need a safe word in unconsensual modding ;p
        public static ManualLogSource LogSource;



    /// <summary>
    /// Initialize Registry with needed data
    /// </summary>
    /// <param name="bundleName">Name of bundle to load</param>
    /// <param name="keyword">UNIQUE keyword of your mod (This is used by the asset bundle loader to load the bundle)</param>
    /// <param name="requireBundle">Do you need to load asset bundles</param>
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

    /// <summary>
    /// Creates a valid stickerAsset specified by the modder for use
    /// </summary>
    /// <param name="nameID"></param>
    /// <param name="descID"></param>
    /// <param name="IconPath"></param>
    /// <param name="objectiveType"></param>
    /// <param name="objective"></param>
    /// <param name="currencyType"></param>
    /// <param name="amountForSticker"></param>
    /// <param name="salvageType"></param>
    /// <param name="mustCompleteSingleShip"></param>
    /// <param name="collectAllInstances"></param>
    /// <param name="currencyInOneShip"></param>
    /// <param name="moduleRequiredList"></param>
    /// <param name="size"></param>
    /// <param name="materialOverride"></param>
    /// <returns></returns>
    public static StickerAsset StickerCreatorV1(string nameID, string descID, string IconPath, StickerAsset.StickerObjectiveType objectiveType,
        ObjectiveEntry objective, CurrencyAsset currencyType, float amountForSticker, SalvageableChangedEvent.SalvageableState salvageType,
        bool mustCompleteSingleShip, bool collectAllInstances, float currencyInOneShip, List<ModuleConstructionAsset> moduleRequiredList, 
        StickerSizeAsset size, Material materialOverride)
    {

        //Properties are private :( going to need to do it via bundle or custom write a patch which lets us set

        StickerAsset sticker = new StickerAsset
        {
            




        };

        



        return sticker;
    }
    }
