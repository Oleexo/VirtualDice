using System.ComponentModel.DataAnnotations;

namespace VirtualDice.Server.Pages.Game.JoinGame {
    public class JoinGameModel {
        [Required]
        public string GameId { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserPassword { get; set; }
    }
}