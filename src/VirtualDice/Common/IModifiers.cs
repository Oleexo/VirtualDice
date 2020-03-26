namespace VirtualDice.Common {
    public interface IModifiers {
        int Strength     { get; }
        int Dexterity    { get; }
        int Constitution { get; }
        int Intelligence { get; }
        int Wisdom       { get; }
        int Charisma     { get; }
    }
}