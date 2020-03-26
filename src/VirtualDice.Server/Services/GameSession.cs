using System;

namespace VirtualDice.Server.Services {
    public class GameSession {
        public GameSession(in Guid gameId, string gamePassword, string userName, string userPassword) {
            GameId       = gameId;
            GamePassword = gamePassword;
            UserName     = userName;
            UserPassword = userPassword;
        }

        // ReSharper disable once UnusedMember.Global
        public GameSession() { }

        public Guid   GameId       { get; set; }
        public string GamePassword { get; set; }
        public string UserName     { get; set; }
        public string UserPassword { get; set; }
    }
}