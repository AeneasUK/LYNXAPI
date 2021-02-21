<p align="center">
    <img src="https://avatars.githubusercontent.com/u/16382828?s=60&v=4">
</p>

# LYNX Tools
[![LYNX Modding Discord](https://user-images.githubusercontent.com/7288322/34429117-c74dbd12-ecb8-11e7-896d-46369cd0de5b.png)](https://discord.gg/SWmJ5eGJxN)

---

LYNXtools is a modding framework for the game: Hardspace Shipbreaker. 

(Currently WIP)

## Features
- Provides a uniform initialisation for assetbundles alongside secure loading ensuring conflicts between mods do not occur
- Allowing for the creation of stickerAssets

#### Platform compatibility chart

|              | Windows | OSX  | Linux | ARM |
|--------------|---------|------|-------|-----|
| Unity Mono   | ✔️       | ✔️    | ✔️     | N/A |
| Unity IL2CPP | ✔️       | ❌    | ❌ (Wine only)  | ❌   |
| .NET / XNA   | ✔️       | Mono | Mono  | N/A |

## Used libraries

- [BepInEx/HarmonyX](https://github.com/BepInEx/HarmonyX) - 2.3.1 ([bbc07d](https://github.com/BepInEx/HarmonyX/commit/bbc07dd1a6537cb1397c490f93a5619ad1d1fe3e))
- [0x0ade/MonoMod](https://github.com/0x0ade/MonoMod) - v20.11.26.02 ([1775ec9](https://github.com/MonoMod/MonoMod/commit/1775ec98e76d3420b2365d6103b4f1b69761a197))

### Available plugin loaders (for use with modding)

| Name              | Link to project                                                                           |
|-------------------|-------------------------------------------------------------------------------------------|
| BepInEx           | [BepInEx](https://github.com/BepInEx)                                                   |

## Resources

**[How to install BepInEx](https://bepinex.github.io/bepinex_docs/master/articles/user_guide/installation/index.html)**

**[Community Discord server](https://discord.gg/shipbreakergame)**

**[Modding Discord server](https://discord.gg/SWmJ5eGJxN)**

## Credits
- [Aeneas](https://github.com/AeneasUK) - Providing coding support for the establishment and maintainment of the framework
- **Library Providers/Plugin Loader Providers/Resource Providers** - Providing an excellent tool for allowing people of all backgrounds to be able to mod their games, but also providing support
