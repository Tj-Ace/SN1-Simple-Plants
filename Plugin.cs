using BepInEx;
using Nautilus.Handlers;

namespace SimplePlants;

[BepInDependency("com.snmodding.nautilus")]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public sealed class Plugin : BaseUnityPlugin
{
    public const string PluginGuid = "com.tj.simpleplants";
    public const string PluginName = "Simple Plants";
    public const string PluginVersion = "1.0.0";

    private void Awake()
    {
        CraftDataHandler.SetItemSize(global::TechType.CreepvinePiece, 1, 1);
        CraftDataHandler.SetItemSize(global::TechType.CreepvineSeedCluster, 1, 1);
        CraftDataHandler.SetItemSize(global::TechType.BloodOil, 1, 1);
        Logger.LogInfo("Simple Plants registered: creepvine samples, creepvine seeds, and blood oil are now 1x1.");
    }
}
