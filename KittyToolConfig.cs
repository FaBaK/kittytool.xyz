using Terraria.ModLoader.Config;
using System.ComponentModel;

namespace KittyTool
{
    public class KittyToolConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [LabelKey("$Mods.KittyTool.Configs.KittyToolConfig.FullBrightToggle.Label")]
        [TooltipKey("$Mods.KittyTool.Configs.KittyToolConfig.FullBrightToggle.Tooltip")]
        [DefaultValue(false)]
        public bool FullBrightToggle { get; set; }

        [LabelKey("$Mods.KittyTool.Configs.KittyToolConfig.BrightnessLevel.Label")]
        [TooltipKey("$Mods.KittyTool.Configs.KittyToolConfig.BrightnessLevel.Tooltip")]
        [DefaultValue(1.0f)]
        [Range(1.0f, 5.0f)]
        public float BrightnessLevel { get; set; }
    }
}