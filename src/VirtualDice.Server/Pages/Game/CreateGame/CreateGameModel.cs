using System;
using System.ComponentModel.DataAnnotations;

namespace VirtualDice.Server.Pages.Game.CreateGame {
    public class CreateGameModel {
        private Guid _gameId;

        public CreateGameModel() {
            _gameId = Guid.NewGuid();
#if DEBUG
            Name = "Game Test - " + new Random().Next(0, 5000);
            Password = "test";
            GameMasterName = "Orion";
            GameMasterPassword = "test";
#endif
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string GameMasterName { get; set; }

        [Required]
        public string GameMasterPassword { get; set; }

        public Guid GameId => _gameId;
    }
}