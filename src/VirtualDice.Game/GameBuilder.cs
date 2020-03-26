using System;
using System.Linq;

namespace VirtualDice.Games {
    public class GameBuilder {
        private readonly Game _game;

        public GameBuilder(in Guid id, string name, string password) {
            _game = new Game(id, name, password);
        }

        public GameBuilder AddGameMaster(string name, string password) {
            var gm = new GameMaster(name, password, _game.Id);
            _game.Add(gm);
            return this;
        }

        public Game Build() {
            if (!_game.GameMasters.Any()) {
                throw new NeedAtLeastOneGameMasterException();
            }
            return _game;
        }
    }

    public class NeedAtLeastOneGameMasterException : Exception {

    }
}