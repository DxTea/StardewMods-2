namespace StardewMods.ToolbarIcons.Framework.Models.Events;

using StardewMods.Common.Services.Integrations.ToolbarIcons;

/// <inheritdoc cref="IIconPressedEventArgs" />
internal sealed class IconPressedEventArgs(string id, SButton button) : EventArgs, IIconPressedEventArgs
{
    /// <inheritdoc />
    public SButton Button { get; } = button;

    /// <inheritdoc />
    public string Id { get; } = id;
}