using System;
using System.Threading.Tasks;
using VirtualDice.Games;

namespace VirtualDice.Server.Services {
    public interface IGameService {
        bool       IsRunningGame { get; }
        Task       CreateAsync(Game   game);
        Task<IGame> FindByIdAsync(Guid id);
        Task SaveAsync(IGame game);
        Task SaveAsync(IGame game, IPlayer player);
        Task AddPlayerToGame(IGame game, Player player);
    }
}