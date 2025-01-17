namespace StardewMods.BetterChests.Framework.UI.Menus;

using StardewMods.Common.Services.Integrations.FauxCore;
using StardewMods.Common.UI.Menus;

internal sealed class TabPopup : BaseMenu
{
    public TabPopup(
        IIconRegistry iconRegistry,
        int? x = null,
        int? y = null,
        int? width = null,
        int? height = null,
        bool showUpperRightCloseButton = false)
        : base(x, y, width, height, showUpperRightCloseButton)
    {
        // var selectIcon = new SelectIcon(
        //     inputHelper,
        //     reflectionHelper,
        //     iconRegistry.GetIcons(),)
    }
}