using System;

namespace VirtualDice.Games {
    public class Player : IPlayer {
        public Player(string name, string password, Guid gameId) {
            Name     = name;
            Password = password;
            GameId = gameId;
            Id = Guid.NewGuid();
        }

        // ReSharper disable once UnusedMember.Local
        private Player() {

        }

        public Guid Id { get; set; }
        public string Name     { get; set; }
        public string Password { get; set; }

        public Guid GameId { get; set; }

        public virtual bool IsGameMaster => false;

        public PlayerCharacter Character { get; set; }

        #region Navigation Properties
        public Game Game { get; set; }
        #endregion
    }
}