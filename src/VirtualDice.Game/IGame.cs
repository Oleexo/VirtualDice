using System;
using System.Collections.Generic;

namespace VirtualDice.Games {
    public interface IGame : IEntity {
        string Name { get; }
        string Password { get; }
        IReadOnlyCollection<GameMaster> GameMasters { get; }
        IReadOnlyCollection<IPlayer> Players { get; }
        GameStatus Status { get; set; }
        IObservable<IGameEvent> Events { get; }

        void Add(Player player);
    }
}