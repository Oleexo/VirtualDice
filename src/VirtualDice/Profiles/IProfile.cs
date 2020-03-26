using VirtualDice.Common;

namespace VirtualDice.Profiles {
    public interface IProfile {
        string NameId { get; }
        string DescriptionId { get; }

        DiceExpression StartLifeModifier { get; }
    }
}