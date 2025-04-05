using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace KittyTool
{
    public class KittyToolSystem : ModSystem
    {
        public override void ModifyLightingBrightness(ref float scale)
        {
            var config = ModContent.GetInstance<KittyToolConfig>();
            if (config.FullBrightToggle)
            {
                scale = config.BrightnessLevel;
            }
        }

        public override void PostUpdateEverything()
        {
            var config = ModContent.GetInstance<KittyToolConfig>();
            if (config.FullBrightToggle)
            {
                Lighting.GlobalBrightness = config.BrightnessLevel;
                ApplyFullBright(config.BrightnessLevel);
            }
        }

        private void ApplyFullBright(float brightnessLevel)
        {
            for (int i = 0; i < Main.maxTilesX; i++)
            {
                for (int j = 0; j < Main.maxTilesY; j++)
                {
                    // Assuming you want to add white light with the specified brightness
                    Lighting.AddLight(i, j, brightnessLevel, brightnessLevel, brightnessLevel);
                }
            }
        }
    }
}