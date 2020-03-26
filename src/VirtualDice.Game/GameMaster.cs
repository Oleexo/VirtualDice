using System;

namespace VirtualDice.Games {
    public class GameMaster : Player {
        public GameMaster(string name, string password, Guid gameId) : base(name, password, gameId) { }

        public override bool IsGameMaster => true;
    }
}