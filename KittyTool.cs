using Terraria.ModLoader;

namespace KittyTool
{
    public class KittyTool : Mod
    {
        public override void Load()
        {
            Logger.Info("KittyTool Loaded");
        }

        public override void Unload()
        {
            Logger.Info("KittyTool Unloaded");
        }
    }
}