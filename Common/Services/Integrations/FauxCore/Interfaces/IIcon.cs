#if IS_FAUXCORE
namespace StardewMods.FauxCore.Common.Services.Integrations.FauxCore;
#else
namespace StardewMods.Common.Services.Integrations.FauxCore;
#endif

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.Menus;

/// <summary>Represents an icon on a sprite sheet.</summary>
public interface IIcon
{
    /// <summary>Gets the icon source area.</summary>
    public Rectangle Area { get; }

    /// <summary>Gets the icon id.</summary>
    public string Id { get; }

    /// <summary>Gets the icon texture path.</summary>
    public string Path { get; }

    /// <summary>Gets the id of the mod this icon is loaded from.</summary>
    public string Source { get; }

    /// <summary>Gets the unique identifier for this icon.</summary>
    public string UniqueId { get; }

    /// <summary>Gets the icon texture.</summary>
    /// <param name="style">The style of the icon.</param>
    /// <returns>Returns the texture.</returns>
    public Texture2D GetTexture(IconStyle style);

    /// <summary>Gets a component with the icon.</summary>
    /// <param name="style">The component style.</param>
    /// <param name="x">The component x-coordinate.</param>
    /// <param name="y">The component y-coordinate.</param>
    /// <param name="scale">The target component scale.</param>
    /// <returns>Returns a new button.</returns>
    public ClickableTextureComponent GetComponent(IconStyle style, int x = 0, int y = 0, float scale = Game1.pixelZoom);
}