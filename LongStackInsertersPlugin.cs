using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using StackLongInserters.Patches;

namespace LongStackInserters
{
    // Token: 0x02000002 RID: 2
    [BepInPlugin("net.hypexmon5ter.LongStackInserters", "LongStackInserters", "1.0.0")]
    public class LongStackInsertersPlugin : BaseUnityPlugin
    {
        // Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
        private void Awake()
        {
            base.Logger.LogInfo("PluginName: LongStackInserters, VersionString: 1.0.0 is loading...");
            LongStackInsertersPlugin.Harmony.PatchAll();
            base.Logger.LogInfo("PluginName: LongStackInserters, VersionString: 1.0.0 is loaded.");
            LongStackInsertersPlugin.Log = base.Logger;
            Harmony.CreateAndPatchAll(typeof(InserterDefinitionPatch), null);
        }

        // Token: 0x04000001 RID: 1
        private const string MyGUID = "net.hypexmon5ter.LongStackInserters";

        // Token: 0x04000002 RID: 2
        private const string PluginName = "LongStackInserters";

        // Token: 0x04000003 RID: 3
        private const string VersionString = "1.0.0";

        // Token: 0x04000004 RID: 4
        private static readonly Harmony Harmony = new Harmony("net.hypexmon5ter.LongStackInserters");

        // Token: 0x04000005 RID: 5
        public static ManualLogSource Log = new ManualLogSource("LongStackInserters");
    }
}
