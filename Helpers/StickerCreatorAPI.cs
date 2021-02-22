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
using LYNXAPI.Core;

namespace Helpers
{
    class StickerCreatorV1
    {
        /// <summary>
        /// Creates a valid StickerAsset for use
        /// </summary>
        /// <param name="Name">Localisation ID for Name</param>
        /// <param name="Desc">Localisation ID for Description</param>
        /// <param name="IconPath">Path to icon, starting from assets folder of your unity project</param>
        /// <param name="ObjectiveType">Specifies what type Objective the sticker requires</param>
        /// <param name="Objective">Specify objective if the StickerObjectiveType is CollectObject, CollectCategoryObject, CollectCategoryMass, or PAT</param>
        /// <param name="CurrencyType">Specify currency type if the StickerObjectiveType is Currency</param>
        /// <param name="AmountForSticker">Number of objects, total mass, or amount of currency required to obtain sticker</param>
        /// <param name="TypeSalvage">Specify salvage type if StickerOBjectiveType is CollectObject, CollectCategoryObject, or CollectCategoryMass</param>
        /// <param name="OneShipIsPlenty">If the objective must be met within a single salvage </param>
        /// <param name="AllItems">For object collection ONLY. Enable if all instances of an object must be collected within a single ship. (E.G all cola bottles)</param>
        /// <param name="MoneyOneShip">For currency stickers ONLY. Enable if an amount of currency must be collected within a single ship.</param>
        /// <param name="Modules">All ModuleConstructionAssets specifying what ships this sticker can be obtained on</param>
        /// <param name="matOverride">Overrides the sprite renderer material in PRF_Sticker_Location if not null</param>
        /// <returns></returns>

        public static StickerAsset CreateStickerAsset
            (
            string Name, string Desc, string IconPath, int ObjectiveType, ObjectiveEntry Objective, CurrencyAsset CurrencyType, float AmountForSticker,
            SalvageableChangedEvent.SalvageableState TypeSalvage, bool OneShipIsPlenty, bool AllItems, float MoneyOneShip, List<ModuleConstructionAsset> Modules,
             Material matOverride
            )
        {
            StickerAsset sticker = new StickerAsset();
            //Creates the sprite from the Iconpath fed in, loads from bundle and sets it to sprite
            Sprite sprite = SpriteAPI.CreateSprite(IconPath);
            StickerSizeAsset StickerSize = SpriteAPI.CreateStickerSizeAsset();
            


            //Accesses private fields and edits them to the correct value
            Traverse.Create(sticker).Field("m_NameLocID").SetValue(Name);
            Traverse.Create(sticker).Field("m_DescriptionLocID").SetValue(Desc);
            Traverse.Create(sticker).Field("m_StickerImage").SetValue(sprite);
            Traverse.Create(sticker).Field("m_StickerObjectiveType").SetValue(ObjectiveType);
            Traverse.Create(sticker).Field("m_Objective").SetValue(Objective);
            Traverse.Create(sticker).Field("m_CurrencyType").SetValue(CurrencyType);
            Traverse.Create(sticker).Field("m_AmountRequiredForSticker").SetValue(AmountForSticker);
            Traverse.Create(sticker).Field("m_SalvageType").SetValue(TypeSalvage);
            Traverse.Create(sticker).Field("m_MustCompleteWithinSingleShip").SetValue(OneShipIsPlenty);
            Traverse.Create(sticker).Field("m_MustCollectAllInstancesOfObject").SetValue(AllItems);
            Traverse.Create(sticker).Field("m_CurrencyAmountInSingleShip").SetValue(MoneyOneShip);
            Traverse.Create(sticker).Field("m_ModuleRequiredList").SetValue(Modules);
            Traverse.Create(sticker).Field("m_Size").SetValue(StickerSize);
            Traverse.Create(sticker).Field("m_MaterialOverride").SetValue(matOverride);
            

            return sticker;
        }

    }
}
