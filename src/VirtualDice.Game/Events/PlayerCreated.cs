namespace VirtualDice.Games.Events {
    public class PlayerCreated : IGameEvent {
        public PlayerCreated(IPlayer player) {
            Player = player;
        }

        public IPlayer Player { get; }
    }
}