using HarmonyLib;

namespace StackLongInserters.Patches
{
    // Token: 0x02000003 RID: 3
    public class InserterDefinitionPatch
    {
        // Token: 0x06000004 RID: 4 RVA: 0x000020D0 File Offset: 0x000002D0
        [HarmonyPatch(typeof(InserterDefinition), "InitInstance")]
        [HarmonyPostfix]
        private static void setToStack(ref InserterInstance newInstance)
        {
            if (newInstance.armLength >= 2)
            {
                newInstance.isStack = true;
            }
        }

        // Token: 0x04000006 RID: 6
        private static bool stackInserterUnlocked;
    }
}
