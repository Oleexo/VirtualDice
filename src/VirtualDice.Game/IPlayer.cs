namespace VirtualDice.Games {
    public interface IPlayer : IEntity {
        string Name         { get; }
        string Password     { get; }
        bool   IsGameMaster { get; }
        PlayerCharacter Character { get; set; }
    }
}