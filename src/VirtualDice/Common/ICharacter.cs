using VirtualDice.Races;

namespace VirtualDice.Common {
    public interface ICharacter {
        string Name { get; }
        IRaceInformation RaceInformation { get; }
        int Level { get; }
    }
}