using Robust.Shared.GameStates;
using Robust.Shared.Serialization;
using Robust.Shared.Utility;

namespace Content.Shared.CosmicCult.Components;

/// <summary>
/// Component for revealing cosmic cultists to the crew, but not if the cultist's face is covered.
/// </summary>
[NetworkedComponent, RegisterComponent]
public sealed partial class CosmicSubtleMarkComponent : Component
{
    [DataField]
    public LocId ExamineText = "cosmic-examine-text-subtle-mark";

    [DataField]
    public SpriteSpecifier Sprite = new SpriteSpecifier.Rsi(new("/Textures/CosmicCult/Effects/cultsubtlerevealed.rsi"), "default");
}