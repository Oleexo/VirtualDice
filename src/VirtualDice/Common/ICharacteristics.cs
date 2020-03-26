namespace VirtualDice.Common {
    public interface ICharacteristics {
        int Strength     { get; }
        int Dexterity    { get; }
        int Constitution { get; }
        int Intelligence { get; }
        int Wisdom       { get; }
        int Charisma     { get; }
    }
}