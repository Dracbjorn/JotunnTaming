// JotunnTaming
// a Valheim mod skeleton using Jötunn
// 
// File:    JotunnTaming.cs
// Project: JotunnTaming

using BepInEx;

namespace JotunnTaming
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency(Jotunn.Main.ModGuid)]
    //[NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.Minor)]
    internal class JotunnTaming : BaseUnityPlugin
    {
        public const string PluginGUID = "com.jotunn.jotunntaming";
        public const string PluginName = "JotunnTaming";
        public const string PluginVersion = "0.0.1";

        private void Awake()
        {
            // Jotunn comes with MonoMod Detours enabled for hooking Valheim's code
            // https://github.com/MonoMod/MonoMod
            On.FejdStartup.Awake += FejdStartup_Awake;
            
            // Jotunn comes with its own Logger class to provide a consistent Log style for all mods using it
            Jotunn.Logger.LogInfo("ModStub has landed");
            
            // To learn more about Jotunn's features, go to
            // https://valheim-modding.github.io/Jotunn/tutorials/overview.html
        }

        private void FejdStartup_Awake(On.FejdStartup.orig_Awake orig, FejdStartup self)
        {
            // This code runs before Valheim's FejdStartup.Awake
            Jotunn.Logger.LogInfo("FejdStartup is going to awake");

            // Call this method so the original game method is invoked
            orig(self);

            // This code runs after Valheim's FejdStartup.Awake
            Jotunn.Logger.LogInfo("FejdStartup has awoken");
        }
    }
}