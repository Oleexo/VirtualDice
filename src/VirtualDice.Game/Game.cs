using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using VirtualDice.Games.Events;

namespace VirtualDice.Games {
    public class Game : IGame {
        private Subject<IGameEvent> _subject;

        internal Game(in Guid id, string name, string password) {
            Id       = id;
            Name     = name;
            Password = password;
            Players = new List<Player>();
            _subject = new Subject<IGameEvent>();
        }

        // ReSharper disable once UnusedMember.Local
        private Game() {
            _subject = new Subject<IGameEvent>();
        }

        public Guid    Id       { get; set; }
        public string Name     { get; set; }
        public string Password { get; set; }
        public GameStatus Status { get; set; }

        public IReadOnlyCollection<GameMaster> GameMasters => Players.OfType<GameMaster>().ToArray();

        public List<Player> Players { get; set; }

        IReadOnlyCollection<IPlayer> IGame.Players => Players;

        public IObservable<IGameEvent> Events => _subject;

        public void Add(Player player) {
            Players.Add(player);
            _subject.OnNext(new PlayerCreated(player));
        }
    }
}