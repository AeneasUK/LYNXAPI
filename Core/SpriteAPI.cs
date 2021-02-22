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
using BBI.Unity.Game;

namespace LYNXAPI.Core
{
    class SpriteAPI
    {
        public static Sprite CreateSprite(string Iconpath)
        {
            //Loads the iconpath from the bundle specified in the initialiser
            Sprite mySprite = InitialiserAPI.bundle.LoadAsset<Sprite>(Iconpath);
            return mySprite;
        }
        public static StickerSizeAsset CreateStickerSizeAsset()
        {
            StickerSizeAsset stickerSize = new StickerSizeAsset();

            return stickerSize;

        }

    }
}
