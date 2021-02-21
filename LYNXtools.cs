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
    /// <param name="objectiveType">StickerObjectiveType:CollectObject, CollectCategoryOject,CollectCategoryMass,PAT,Currency</param>
    /// <param name="objective">Specify objective if the StickerObjectiveType is CollectObject, CollectCategoryObject, CollectCategoryMass, or PAT</param>
    /// <param name="currencyType">Specify currency type if the StickerObjectiveType is Currency</param>
    /// <param name="amountForSticker">Number of objects, total mass, or amount of currency required to obtain sticker.</param>
    /// <param name="salvageType">Specify salvage type if StickerOBjectiveType is CollectObject, CollectCategoryObject, or CollectCategoryMass"</param>
    /// <param name="mustCompleteSingleShip"></param>
    /// <param name="collectAllInstances">For object collection ONLY. Enable if all instances of an object must be collected within a single ship.</param>
    /// <param name="currencyInOneShip">For currency stickers ONLY. Enable if an amount of currency must be collected within a single ship.</param>
    /// <param name="moduleRequiredList">All ModuleConstructionAssets specifying what ships this sticker can be obtained on</param>
    /// <param name="size"></param>
    /// <param name="materialOverride">Overrides the sprite renderer material in PRF_Sticker_Location if not null.</param>
    /// <returns></returns>
    public static StickerAsset StickerCreatorV1(string nameID, string descID, string IconPath, StickerAsset.StickerObjectiveType objectiveType,
        ObjectiveEntry objective, CurrencyAsset currencyType, float amountForSticker, SalvageableChangedEvent.SalvageableState salvageType,
        bool mustCompleteSingleShip, bool collectAllInstances, float currencyInOneShip, List<ModuleConstructionAsset> moduleRequiredList, 
        StickerSizeAsset size, Material materialOverride)
    {

        //Properties are private :( going to need to do it via bundle or custom write a patch which let's us set

        StickerAsset sticker = new StickerAsset
        {
            




        };

        



        return sticker;
    }
    }
