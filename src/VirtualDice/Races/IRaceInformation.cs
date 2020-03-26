using VirtualDice.Common;

namespace VirtualDice.Races {
    public interface IRaceInformation {
        string             NameId             { get; }
        int                StartAge                { get; }
        int                LifeExpectancy     { get; }
        (int Min, int Max) Size               { get; }
        (int Min, int Max) Weight             { get; }
        string             SmallDescriptionId { get; }

        ICharacteristics Modifiers { get; }
    }
}